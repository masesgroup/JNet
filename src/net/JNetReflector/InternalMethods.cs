/*
*  Copyright 2023 MASES s.r.l.
*
*  Licensed under the Apache License, Version 2.0 (the "License");
*  you may not use this file except in compliance with the License.
*  You may obtain a copy of the License at
*
*  http://www.apache.org/licenses/LICENSE-2.0
*
*  Unless required by applicable law or agreed to in writing, software
*  distributed under the License is distributed on an "AS IS" BASIS,
*  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*  See the License for the specific language governing permissions and
*  limitations under the License.
*
*  Refer to LICENSE for more information.
*/

using System.IO;
using System;
using System.IO.Compression;
using System.Collections.Generic;
using Java.Lang;
using Java.Lang.Reflect;
using System.Text;
using MASES.JNetReflector.Templates;
using System.Linq;
using Org.Mases.Jnet;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MASES.JNetReflector
{
    static class ReflectionUtils
    {
        public enum ReflectionTraceLevel
        {
            Critical,
            Error,
            Info,
            Debug,
            Trace,
            Verbose,
        }

        static int Level { get; set; }
        static EventHandler<string> TraceReportHandler { get; set; }

        public static void SetHandlerAndLevel(EventHandler<string> traceReport, int level)
        {
            TraceReportHandler = traceReport;
            Level = level;
        }

        static void ReportTrace(ReflectionTraceLevel level, string format, params object[] args)
        {
            if ((int)level > Level) return;
            try
            {
                TraceReportHandler(null, level.ToString() + ": " + string.Format(format, args));
            }
            catch (System.Exception e)
            {
                TraceReportHandler(null, e.ToString());
            }
        }

        static long namespaces = 0;
        static long classes = 0;

        static void WriteFile(string path, string content)
        {
            if (path.EndsWith(FileNameAndDirectory.AllPackageClassesFileName)) Interlocked.Increment(ref namespaces);
            else Interlocked.Increment(ref classes);

            if (!JNetReflectorCore.DryRun)
            {
                if (File.Exists(path)) File.Delete(path);
                var directory = Path.GetDirectoryName(path);
                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
                File.WriteAllText(path, content);
            }
        }

        public static void Reflect()
        {
            namespaces = classes = 0;
            Stopwatch w = Stopwatch.StartNew();
            if (JNetReflectorCore.JarsToAnalyze != null)
            {
                AnalyzeJars();
            }
            else if (JNetReflectorCore.ModulesToParse != null)
            {
                AnalyzeNamespaces();
            }
            else if (JNetReflectorCore.ClassesToAnalyze != null)
            {
                AnalyzeClasses();
            }
            else throw new ArgumentException("At least one of ClassesToAnaylyze, NamespacesToParse or OriginRootPath must be set");
            w.Stop();
            Console.WriteLine();
            Console.WriteLine($"Operation completed in {w.Elapsed}. Namespaces: {namespaces} - Classes: {classes}");
        }

        public static void AnalyzeJars()
        {
            List<string> jarNames = new List<string>(JNetReflectorCore.JarsToAnalyze);
            for (int i = 0; i < jarNames.Count; i++)
            {
                string javadocUrl = JNetReflectorCore.OriginJavadocUrl;
                int javadocVersion = JNetReflectorCore.JavadocVersion;
                if (JNetReflectorCore.OriginJavadocJARVersionAndUrls != null)
                {
                    var data = JNetReflectorCore.OriginJavadocJARVersionAndUrls.ElementAt(i);
                    javadocVersion = data.Item1;
                    javadocUrl = data.Item2;
                }

                AnalyzeJar(jarNames[i], javadocUrl, javadocVersion);
            }
        }

        public static void AnalyzeClasses()
        {
            SortedDictionary<string, IDictionary<string, IDictionary<string, Class>>> resultingArguments = new SortedDictionary<string, IDictionary<string, IDictionary<string, Class>>>();
            foreach (var item in JNetReflectorCore.ClassesToAnalyze)
            {
                var jClass = item.JVMClass(true);
                if (jClass != null) resultingArguments.AddItem(jClass);
            }
            JNetReflectorExtensions.SetJavaDocInfo(JNetReflectorCore.OriginJavadocUrl, JNetReflectorCore.JavadocVersion);
            JarOrModuleName = "CustomSelection";
            resultingArguments.AnalyzeItems();
        }

        public static void AddItem(this IDictionary<string, IDictionary<string, IDictionary<string, Class>>> data, Class cls)
        {
            if (cls == null) return;
            ReportTrace(ReflectionTraceLevel.Debug, "Entry {0}", cls.Name);
            if (cls.IsSpecialClass()) return; // do not reflect this classes
            if (cls.IsNamespaceToAvoid()) return; // do not reflect this classes
            if (!(cls.IsJVMClass() || cls.IsJVMNestedClass())) return;

            ReportTrace(ReflectionTraceLevel.Debug, "Adding entry {0}", cls.Name);
            var package = cls.Namespace(JNetReflectorCore.UseCamel);
            IDictionary<string, IDictionary<string, Class>> entries;
            if (!data.TryGetValue(package, out entries))
            {
                entries = new SortedDictionary<string, IDictionary<string, Class>>();
                data.Add(package, entries);
            }
            IDictionary<string, Class> subEntries;
            if (!entries.TryGetValue(cls.JVMMainClassName(), out subEntries))
            {
                subEntries = new SortedDictionary<string, Class>();
                entries.Add(cls.JVMMainClassName(), subEntries);
            }
            subEntries.Add(cls.Name, cls);
        }

        public static void AnalyzeJar(string pathToJar, string javadocUrl, int javadocVersion)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Jar {0} *******************", pathToJar);
            using (ZipArchive archive = ZipFile.OpenRead(pathToJar))
            {
                SortedDictionary<string, IDictionary<string, IDictionary<string, Class>>> resultingArguments = new SortedDictionary<string, IDictionary<string, IDictionary<string, Class>>>();

                foreach (var entry in archive.Entries)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Entry {0}", entry.ToString());
                    if (entry.IsSpecialFolder()) continue; // do not reflect this folders
                    if (entry.IsFolder()) continue; // do not reflect this folders

                    var jClass = entry.JVMClass();
                    if (jClass != null && (jClass.IsJVMClass() || jClass.IsJVMNestedClass()))
                    {
                        resultingArguments.AddItem(jClass);
                    }
                }

                ReportTrace(ReflectionTraceLevel.Info, "Starting analysis for {0} entries", resultingArguments.Count);
                JNetReflectorExtensions.SetJavaDocInfo(javadocUrl, javadocVersion);
                JarOrModuleName = Path.GetFileName(pathToJar);
                resultingArguments.AnalyzeItems();
            }
        }

        public static void AnalyzeNamespaces()
        {
            SortedDictionary<string, IDictionary<string, IDictionary<string, Class>>> resultingArguments = new SortedDictionary<string, IDictionary<string, IDictionary<string, Class>>>();
            foreach (var ns in JNetReflectorCore.ModulesToParse)
            {
                AnalyzeNamespace(resultingArguments, ns);
            }
        }

        public static void AnalyzeNamespace(IDictionary<string, IDictionary<string, IDictionary<string, Class>>> data, string ns)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Namespace {0} *******************", ns);
            var classes = JNetReflectorHelper.Find(ns, false);

            foreach (var entry in classes)
            {
                data.AddItem(entry);
            }

            ReportTrace(ReflectionTraceLevel.Info, "Starting analysis for {0} entries", data.Count);
            JNetReflectorExtensions.SetJavaDocInfo(JNetReflectorCore.OriginJavadocUrl, JNetReflectorCore.JavadocVersion);
            JarOrModuleName = ns;
            data.AnalyzeItems();
        }

        static string JarOrModuleName { get; set; }

        static CancellationTokenSource CancellationTokenSource { get; set; }

        static void AnalyzeItems(this IDictionary<string, IDictionary<string, IDictionary<string, Class>>> items)
        {
            if (!JNetReflectorCore.AvoidParallelBuild)
            {
                try
                {
                    ParallelOptions po = new ParallelOptions();
                    Console.CancelKeyPress += Console_CancelKeyPress;
                    CancellationTokenSource = new CancellationTokenSource();
                    CancellationTokenSource.Token.ThrowIfCancellationRequested();
                    po.CancellationToken = CancellationTokenSource.Token;
                    po.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
                    Parallel.ForEach(items, po, AnalyzeSubItemsParallel);
                }
                finally
                {
                    CancellationTokenSource = null;
                    Console.CancelKeyPress -= Console_CancelKeyPress;
                }
            }
            else
            {
                foreach (var item in items)
                {
                    AnalyzeSubItems(item.Key, item.Value, JarOrModuleName);
                }
            }
        }

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            CancellationTokenSource.Cancel();
        }

        static void AnalyzeSubItemsParallel(KeyValuePair<string, IDictionary<string, IDictionary<string, Class>>> items)
        {
            try
            {
                AnalyzeSubItems(items.Key, items.Value, JarOrModuleName);
            }
            catch (OperationCanceledException)
            {
                throw;
            }
            catch (System.Exception e)
            {
                ReportTrace(ReflectionTraceLevel.Error, "Error in parallel for package {0}: {1}", items.Key, e.Message);
                throw;
            }
        }

        static void AnalyzeSubItems(string package, IDictionary<string, IDictionary<string, Class>> items, string jarOrModuleName)
        {
            var allPackageClasses = Template.GetTemplate(Template.AllPackageClassesTemplate);

            ReportTrace(ReflectionTraceLevel.Info, "Starting analysis for package {0}", package);
            StringBuilder sb = new StringBuilder();
            foreach (var entry in items)
            {
                var classContent = AnalyzeClass(jarOrModuleName, entry.Value.Values, JNetReflectorCore.DestinationRootPath);
                if (!string.IsNullOrEmpty(classContent))
                {
                    sb.AppendLine(classContent);
                    sb.AppendLine();
                }
            }

            var itemPackage = allPackageClasses.Replace(AllPackageClasses.VERSION, SpecialNames.VersionPlaceHolder())
                                               .Replace(AllPackageClasses.JAR, jarOrModuleName)
                                               .Replace(AllPackageClasses.NAMESPACE, package)
                                               .Replace(AllPackageClasses.CLASSES, sb.ToString());

            var path = Path.Combine(JNetReflectorCore.DestinationRootPath, package.Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar), "AllPackageClasses.cs");
            WriteFile(path, itemPackage);
        }

        static string AnalyzeClass(string jarOrModuleName, ICollection<Class> classDefinitions, string rootDesinationFolder)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* AnalyzeClass {0} *******************", jarOrModuleName);

            bool mainClassDone = false;
            Class jClass = null;
            List<Class> nestedClasses = new List<Class>();

            foreach (var entry in classDefinitions)
            {
                if (entry == null)
                {
                    ReportTrace(ReflectionTraceLevel.Error, "Class Entry {0} returned a null Class", entry.GenericString);
                    continue;
                }

                if (entry.MustBeAvoided())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarding avoided class {0}", entry.GenericString);
                    continue;
                }

                if (entry.IsJVMException() && entry.IsJavaLangException())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarding Java Lang exception class {0}", entry.GenericString);
                    continue;
                }

                if (entry.IsJVMNestedClass())
                {
                    bool jSubClassIsDepracated = entry.IsDeprecated();
                    if (!JNetReflectorCore.ReflectDeprecated && jSubClassIsDepracated)
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarding deprecated class {0}", entry.GenericString);
                        continue;
                    }

                    bool jSubClassIsOrFromGeneric = entry.IsOrInheritFromJVMGenericClass();
                    if (JNetReflectorCore.DisableGenerics && jSubClassIsOrFromGeneric)
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarding generic class {0}", entry.GenericString);
                        continue;
                    }

                    nestedClasses.Add(entry);
                }
                else if (entry.IsJVMClass())
                {
                    if (mainClassDone) throw new InvalidOperationException("Too many main class");
                    if (!JNetReflectorCore.ReflectDeprecated && entry.IsDeprecated())
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarded deprecated main class {0}", jClass.GenericString);
                        return string.Empty;
                    }
                    if (JNetReflectorCore.DisableGenerics && entry.IsOrInheritFromJVMGenericClass())
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarding generic class {0}", jClass.GenericString);
                        return string.Empty;
                    }
                    mainClassDone = true;
                    jClass = entry;
                    ReportTrace(ReflectionTraceLevel.Debug, "Identified main class {0}", jClass.CanonicalName);
                }
            }

            if (!mainClassDone) return string.Empty;
            if (jClass == null)
            {
                ReportTrace(ReflectionTraceLevel.Error, "Main Class Entry returned a null class");
                return string.Empty;
            }

            StringBuilder subClassBlock = new StringBuilder();
            StringBuilder subClassAutonoumous = new StringBuilder();
            StringBuilder subClassGenericBlock = new StringBuilder();
            StringBuilder subClassGenericAutonoumous = new StringBuilder();

            foreach (var entry in nestedClasses)
            {
                string nestedClassBlock;
                string singleNestedClassStr;
                entry.PrepareSingleClass(classDefinitions, true, false, 3, out nestedClassBlock, out singleNestedClassStr);

                if (!string.IsNullOrEmpty(nestedClassBlock))
                {
                    subClassBlock.AppendLine(nestedClassBlock);
                    subClassBlock.AppendLine();
                }

                if (!string.IsNullOrEmpty(singleNestedClassStr))
                {
                    subClassAutonoumous.AppendLine(singleNestedClassStr);
                    subClassAutonoumous.AppendLine();
                }

                if (!JNetReflectorCore.AvoidCSharpGenericDefinition && entry.IsJVMGenericClass() && !entry.IsClassToAvoidInGenerics())
                {
                    entry.PrepareSingleClass(classDefinitions, true, true, 3, out nestedClassBlock, out singleNestedClassStr);

                    if (!string.IsNullOrEmpty(nestedClassBlock))
                    {
                        subClassBlock.AppendLine(nestedClassBlock);
                        subClassBlock.AppendLine();
                    }

                    if (!string.IsNullOrEmpty(singleNestedClassStr))
                    {
                        subClassAutonoumous.AppendLine(singleNestedClassStr);
                        subClassAutonoumous.AppendLine();
                    }
                }
            }

            StringBuilder allClassBlock = new StringBuilder();
            StringBuilder singleFileBlock = new StringBuilder();

            string classBlock;
            string singleClassStr;
            jClass.PrepareSingleClass(classDefinitions, false, false, 2, out classBlock, out singleClassStr);
            singleClassStr = singleClassStr.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, subClassAutonoumous.ToString());
            singleFileBlock.Append(singleClassStr);
            var subClassStr = subClassBlock.ToString();
            classBlock = classBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, subClassStr.Length != 0 ? subClassStr : string.Empty);
            allClassBlock.Append(classBlock);

            string classGenericBlock;
            string singleClassGenericStr;
            if (!JNetReflectorCore.AvoidCSharpGenericDefinition && jClass.IsJVMGenericClass() && !jClass.IsClassToAvoidInGenerics())
            {
                jClass.PrepareSingleClass(classDefinitions, false, true, 2, out classGenericBlock, out singleClassGenericStr);
                singleClassGenericStr = singleClassGenericStr.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, subClassGenericAutonoumous.ToString());
                singleFileBlock.AppendLine();
                singleFileBlock.AppendLine();
                singleFileBlock.Append(singleClassGenericStr);
                var subClassGenericStr = subClassGenericBlock.ToString();
                classGenericBlock = classGenericBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, subClassGenericStr.Length != 0 ? subClassGenericStr : string.Empty);
                allClassBlock.AppendLine();
                allClassBlock.AppendLine();
                allClassBlock.Append(classGenericBlock);
            }

            var singleFileBlockStr = singleFileBlock.ToString();
            if (!string.IsNullOrWhiteSpace(singleFileBlockStr))
            {
                var singleClassFileTemplate = Template.GetTemplate(Template.SingleClassFileTemplate);

                var fileContent = singleClassFileTemplate.Replace(AllPackageClasses.VERSION, SpecialNames.VersionPlaceHolder())
                                                         .Replace(AllPackageClasses.JAR, jarOrModuleName)
                                                         .Replace(AllPackageClasses.NAMESPACE, jClass.Namespace(JNetReflectorCore.UseCamel))
                                                         .Replace(AllPackageClasses.CLASSES, singleFileBlockStr);

                var clsName = jClass.JVMClassName(null, false);
                var classPath = Path.Combine(rootDesinationFolder, jClass.Namespace(JNetReflectorCore.UseCamel).Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar), $"{clsName}.cs");
                WriteFile(classPath, fileContent);
            }

            return allClassBlock.ToString();
        }

        static void PrepareSingleClass(this Class jClass, ICollection<Class> classDefinitions, bool isNested, bool isGeneric, int tabLevel, out string classBlock, out string singleClassStr)
        {
            string stubException = isNested ? Template.GetTemplate(Template.AllPackageClassesStubNestedExceptionTemplate) : Template.GetTemplate(Template.AllPackageClassesStubExceptionTemplate);
            string stubListener = isNested ? Template.GetTemplate(Template.AllPackageClassesStubNestedClassListenerTemplate) : Template.GetTemplate(Template.AllPackageClassesStubClassListenerTemplate);
            string stubClass = isNested ? Template.GetTemplate(Template.AllPackageClassesStubNestedClassTemplate) : Template.GetTemplate(Template.AllPackageClassesStubClassTemplate);
            string singleClass = isNested ? Template.GetTemplate(Template.SingleNestedClassTemplate) : Template.GetTemplate(Template.SingleClassTemplate);
            string constructorBlock = string.Empty;
            string operatorBlock = string.Empty;
            string fieldBlock = string.Empty;
            string staticMethodBlock = string.Empty;
            string methodBlock = string.Empty;

            bool jClassIsDepracated = jClass.IsDeprecated();
            bool jClassIsOrFromGeneric = jClass.IsOrInheritFromJVMGenericClass();
            bool jClassIsListener = jClass.IsJVMListenerClass();
            string template = jClassIsListener ? stubListener : stubClass;
            bool isMainClass = false;
            IList<Method> methodPrefilter = null;
            if (!jClassIsListener)
            {
                methodPrefilter = jClass.PrefilterMethods(isGeneric, out isMainClass);
                if (isMainClass)
                {
                    template = isNested ? Template.GetTemplate(Template.AllPackageClassesStubNestedClassMainClassTemplate) : Template.GetTemplate(Template.AllPackageClassesStubClassMainClassTemplate);
                }
            }
            bool classCantBeAnalyzed = jClassIsListener || isMainClass;

            ReportTrace(ReflectionTraceLevel.Debug, "Preparing nested class {0}", jClass.GenericString);

            if (jClass.IsJVMException())
            {
                classBlock = stubException.Replace(AllPackageClasses.ClassStub.JAVACLASS, jClass.JVMFullClassName())
                                          .Replace(AllPackageClasses.ClassStub.SIMPLECLASS, jClass.JVMClassName(null, false))
                                          .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(null, isGeneric))
                                          .Replace(AllPackageClasses.ClassStub.HELP, jClass.JavadocHrefUrl(JNetReflectorCore.UseCamel))
                                          .Replace(AllPackageClasses.ClassStub.BASECLASS, jClass.JVMBaseClassName(isGeneric, false, JNetReflectorCore.UseCamel))
                                          .Replace(AllPackageClasses.ClassStub.WHERECLAUSES, string.Empty);
            }
            else
            {
                bool isClassCloseable = jClass.IsCloseable();
                bool isClassAbstract = jClass.IsAbstract();
                bool isClassInterface = jClass.IsInterface();
                bool isClassStatic = jClass.IsStatic();
                List<KeyValuePair<string, string>> genClause = new List<KeyValuePair<string, string>>();

                classBlock = template.Replace(AllPackageClasses.ClassStub.JAVACLASS, jClass.JVMFullClassName())
                                     .Replace(AllPackageClasses.ClassStub.SIMPLECLASS, jClass.JVMClassName(genClause, false))
                                     .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(genClause, isGeneric))
                                     .Replace(AllPackageClasses.ClassStub.HELP, jClass.JavadocHrefUrl(JNetReflectorCore.UseCamel))
                                     .Replace(AllPackageClasses.ClassStub.BASECLASS, jClass.JVMBaseClassName(isGeneric, jClassIsListener, JNetReflectorCore.UseCamel))
                                     .Replace(AllPackageClasses.ClassStub.WHERECLAUSES, jClass.WhereClauses(isGeneric, JNetReflectorCore.UseCamel))
                                     .Replace(AllPackageClasses.ClassStub.ISABSTRACT, isClassAbstract ? "true" : "false")
                                     .Replace(AllPackageClasses.ClassStub.ISCLOSEABLE, isClassCloseable ? "true" : "false")
                                     .Replace(AllPackageClasses.ClassStub.ISINTERFACE, isClassInterface ? "true" : "false")
                                     .Replace(AllPackageClasses.ClassStub.ISSTATIC, isClassStatic ? "true" : "false");

                if (!classCantBeAnalyzed)
                {
                    constructorBlock = jClass.AnalyzeConstructors(classDefinitions, isGeneric, true).AddTabLevel(tabLevel);
                    operatorBlock = jClass.AnalyzeOperators(classDefinitions, isGeneric, true).AddTabLevel(tabLevel);
                    fieldBlock = jClass.AnalyzeFields(classDefinitions, isGeneric).AddTabLevel(tabLevel);
                    staticMethodBlock = jClass.AnalyzeMethods(classDefinitions, methodPrefilter, isGeneric, true, true).AddTabLevel(tabLevel);
                    methodBlock = jClass.AnalyzeMethods(classDefinitions, methodPrefilter, isGeneric, true, false).AddTabLevel(tabLevel);
                }
            }

            singleClassStr = string.Empty;

            if (!classCantBeAnalyzed)
            {
                List<KeyValuePair<string, string>> genClause = new List<KeyValuePair<string, string>>();

                StringBuilder jClassDecoration = new StringBuilder(AllPackageClasses.ClassStub.DEFAULT_DECORATION.AddTabLevel(tabLevel - 1));
                if (jClassIsDepracated)
                {
                    jClassDecoration.AppendLine();
                    jClassDecoration.Append(AllPackageClasses.ClassStub.OBSOLETE_DECORATION.AddTabLevel(tabLevel - 1));
                }

                singleClassStr = singleClass.Replace(AllPackageClasses.ClassStub.DECORATION, jClassDecoration.ToString())
                                            .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(genClause, isGeneric))
                                            .Replace(AllPackageClasses.ClassStub.CONSTRUCTORS, constructorBlock)
                                            .Replace(AllPackageClasses.ClassStub.OPERATORS, operatorBlock)
                                            .Replace(AllPackageClasses.ClassStub.FIELDS, fieldBlock)
                                            .Replace(AllPackageClasses.ClassStub.STATICMETHODS, staticMethodBlock)
                                            .Replace(AllPackageClasses.ClassStub.METHODS, methodBlock);
            }
        }

        static string AnalyzeConstructors(this Class classDefinition, ICollection<Class> classDefinitions, bool isGeneric, bool isNested)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Constructors of {0} *******************", classDefinition.GenericString);

            var singleConstructorTemplate = Template.GetTemplate(Template.SingleConstructorTemplate);

            SortedDictionary<string, Constructor> sortedFilteredCtors = new SortedDictionary<string, Constructor>();

            foreach (var constructor in classDefinition.DeclaredConstructors)
            {
                var paramCount = constructor.ParameterCount;
                var methodNameOrigin = constructor.Name;

                if (paramCount == 0) continue; // default constructor managed from AllClasses template as default for any JCOBridge reflected class
                bool isDeprecated = constructor.IsDeprecated();
                if (!JNetReflectorCore.ReflectDeprecated && isDeprecated)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded deprecated constructor {0}", constructor.GenericString);
                    continue;
                }
                if (constructor.IsStatic())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded static constructor {0}", constructor.GenericString);
                    continue;
                }
                if (!constructor.IsPublic()) continue; // avoid not public methods

                sortedFilteredCtors.Add(constructor.GenericString, constructor);
            }

            List<string> classGenerics = new List<string>();
            List<KeyValuePair<string, string>> classClauses = new List<KeyValuePair<string, string>>();
            classDefinition.GetGenerics(classGenerics, classClauses, string.Empty, JNetReflectorCore.UseCamel);

            StringBuilder subClassBlock = new StringBuilder();
            foreach (var constructor in sortedFilteredCtors.Values)
            {
                var paramCount = constructor.ParameterCount;
                var methodNameOrigin = constructor.Name;

                bool isDeprecated = constructor.IsDeprecated();
                string modifier = constructor.IsStatic() ? " static" : string.Empty;
                string constructorName = constructor.Name(JNetReflectorCore.UseCamel);
                bool bypass = false;
                bool hasVarArg = false;
                List<Parameter> parameters = new List<Parameter>();
                Parameter varArg = null;

                foreach (var parameter in constructor.Parameters)
                {
                    List<string> genArgumentsLocal = new List<string>();
                    List<KeyValuePair<string, string>> genClauseLocal = new List<KeyValuePair<string, string>>();
                    if (JNetReflectorCore.DisableGenerics && parameter.Type.IsOrInheritFromJVMGenericClass()) { bypass = true; break; }
                    if (parameter.Type.MustBeAvoided()) { bypass = true; break; }
                    if (parameter.Type(genArgumentsLocal, genClauseLocal, string.Empty, isGeneric, JNetReflectorCore.UseCamel) == "object[]") { bypass = true; break; }
                    if (!parameter.IsVarArgs)
                    {
                        parameters.Add(parameter);
                    }
                    else // store var arg becuase it is not clear that results are ordered
                    {
                        hasVarArg = true;
                        varArg = parameter;
                    }
                }

                if (bypass)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded constructor {0}", constructor.GenericString);
                    continue;
                }
                if (hasVarArg && paramCount == 1 && varArg.IsObjectType(JNetReflectorCore.UseCamel)) continue; // this kind of constructor is managed from AllClasses template as default for any JCOBridge reflected class

                if (hasVarArg)
                {
                    parameters.Add(varArg);
                }

                StringBuilder constructorHelpBuilder = new StringBuilder();
                StringBuilder constructorParamsBuilder = new StringBuilder();
                StringBuilder constructorExecutionParamsBuilder = new StringBuilder();

                foreach (var item in parameters)
                {
                    List<string> paramGenArguments = new List<string>();
                    List<KeyValuePair<string, string>> paramGenClause = new List<KeyValuePair<string, string>>();
                    var typeStr = item.Type(paramGenArguments, paramGenClause, item.Name().Camel(), isGeneric, JNetReflectorCore.UseCamel);
                    var typeStrForDoc = typeStr.Contains('<') ? typeStr.Substring(0, typeStr.IndexOf('<')) : typeStr;
                    if (isGeneric && paramGenArguments.Count != 0 && classGenerics != null)
                    {
                        bool usableGenStrings = true;
                        foreach (var genString in paramGenArguments)
                        {
                            if (!classGenerics.Contains(genString)) usableGenStrings = false;
                        }
                        if (typeStr.StartsWith(SpecialNames.JavaLangClass))
                        {
                            typeStr = typeStrForDoc;
                            usableGenStrings = false;
                        }
                        if (!usableGenStrings)
                        {
                            typeStr = typeStrForDoc;
                        }
                    }
                    constructorHelpBuilder.AppendLine(string.Format(AllPackageClasses.ClassStub.ConstructorStub.HELP_PARAM_DECORATION, item.Name,
                                                                                                                                       typeStrForDoc.ConvertToJavadoc()));
                    if (item.IsVarArgs)
                    {
                        constructorParamsBuilder.AppendFormat($"params {typeStr} {varArg.Name()}, ");
                    }
                    else
                    {
                        constructorParamsBuilder.AppendFormat($"{typeStr} {item.Name()}, ");
                    }
                    constructorExecutionParamsBuilder.AppendFormat($"{item.Name()}, ");
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing constructor {0}", constructor.GenericString);

                string paramsString = constructorParamsBuilder.ToString();
                string executionParamsString = constructorExecutionParamsBuilder.ToString();
                if (paramCount != 0)
                {
                    if (paramsString.EndsWith(", ")) paramsString = paramsString.Substring(0, paramsString.Length - 2); // remove last occurrence of ", "
                    if (executionParamsString.EndsWith(", ")) executionParamsString = executionParamsString.Substring(0, executionParamsString.Length - 2); // remove last occurrence of ", "
                }

                var exceptions = constructor.ExceptionTypes;
                if (exceptions.Length > 0)
                {
                    StringBuilder exceptionBuilder = new StringBuilder();
                    for (int i = 0; i < exceptions.Length; i++)
                    {
                        var expType = exceptions[i].ToNetType(JNetReflectorCore.UseCamel);
                        exceptionBuilder.AppendFormat(AllPackageClasses.ClassStub.ConstructorStub.HELP_EXCEPTION_DECORATION, expType.ConvertToJavadoc());
                        if (i < exceptions.Length - 1) exceptionBuilder.AppendLine();
                    }
                    if (!constructorHelpBuilder.ToString().EndsWith(Environment.NewLine)) constructorHelpBuilder.AppendLine();
                    constructorHelpBuilder.Append(exceptionBuilder.ToString());
                }

                StringBuilder jDecoration = new StringBuilder(AllPackageClasses.ClassStub.ConstructorStub.DEFAULT_DECORATION);
                string paramHelp = constructorHelpBuilder.ToString();
                if (paramHelp.EndsWith(Environment.NewLine)) paramHelp = paramHelp.Substring(0, paramHelp.LastIndexOf(Environment.NewLine));
                if (!string.IsNullOrEmpty(paramHelp))
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(paramHelp);
                }
                if (isDeprecated)
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(AllPackageClasses.ClassStub.ConstructorStub.OBSOLETE_DECORATION);
                }

                var singleConstructor = singleConstructorTemplate.Replace(AllPackageClasses.ClassStub.ConstructorStub.DECORATION, jDecoration.ToString())
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.MODIFIER, modifier)
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.NAME, constructorName)
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.PARAMETERS, paramsString)
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.EXECUTION, executionParamsString)
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.HELP, constructor.JavadocHrefUrl(JNetReflectorCore.UseCamel));

                subClassBlock.AppendLine(singleConstructor);
            }

            return subClassBlock.ToString();
        }

        static string AnalyzeOperators(this Class classDefinition, ICollection<Class> classDefinitions, bool isGeneric, bool isNested)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Operators of {0} *******************", classDefinition.GenericString);

            StringBuilder subOperatorBlock = new StringBuilder();

            if (classDefinition.NeedsOperators(isGeneric))
            {
                List<string> classGenerics = new List<string>();
                List<KeyValuePair<string, string>> classClauses = new List<KeyValuePair<string, string>>();
                classDefinition.GetGenerics(classGenerics, classClauses, string.Empty, JNetReflectorCore.UseCamel);

                List<Class> filteredInterfaces = new List<Class>();
                foreach (var implementedInterface in classDefinition.Interfaces)
                {
                    var superCls = classDefinition.SuperClass;
                    if (superCls == null
                        || !superCls.IsPublic()
                        || (JNetReflectorCore.ReflectDeprecated ? false : superCls.IsDeprecated())
                        || superCls.MustBeAvoided()
                        || superCls.TypeName == SpecialNames.JavaLangObject)
                    {
                        filteredInterfaces.Add(implementedInterface);
                    }
                    else
                    {
                        bool foundInSuperClass = false;
                        foreach (var supInterface in superCls.Interfaces)
                        {
                            if (supInterface.TypeName == implementedInterface.TypeName)
                            {
                                foundInSuperClass = true; break;
                            }
                        }
                        if (!foundInSuperClass) filteredInterfaces.Add(implementedInterface);
                    }
                }

                foreach (var implementedInterface in filteredInterfaces)
                {
                    if (implementedInterface.IsIterable())
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarded iterable {0}", implementedInterface.GenericString);
                        continue;
                    }
                    if (implementedInterface.MustBeAvoided())
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarded avoided {0}", implementedInterface.GenericString);
                        continue;
                    }
                    if (implementedInterface.IsStatic())
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarded static operator {0}", implementedInterface.GenericString);
                        continue;
                    }
                    if (JNetReflectorCore.DisableGenerics && implementedInterface.IsOrInheritFromJVMGenericClass())
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarded generic operator {0}", implementedInterface.GenericString);
                        continue;
                    }

                    List<string> implClassGenerics = new List<string>();
                    List<KeyValuePair<string, string>> implClassClauses = new List<KeyValuePair<string, string>>();
                    implementedInterface.GetGenerics(implClassGenerics, implClassClauses, string.Empty, JNetReflectorCore.UseCamel);

                    var implClass = implementedInterface.ToFullQualifiedClassName(false, JNetReflectorCore.UseCamel);
                    if (isGeneric && implClassGenerics != null && classGenerics != null)
                    {
                        bool usableGenStrings = true;
                        foreach (var genString in implClassGenerics)
                        {
                            if (!classGenerics.Contains(genString)) usableGenStrings = false;
                        }
                        if (usableGenStrings && implClass != SpecialNames.JavaLangClass)
                        {
                            implClass += implClassGenerics.ApplyGenerics();
                        }
                    }

                    var classDef = classDefinition.ToFullQualifiedClassName(isGeneric, JNetReflectorCore.UseCamel);

                    var singleOperatorHelp = string.Format(AllPackageClasses.ClassStub.OperatorStub.DEFAULT_DECORATION, implClass.ConvertToJavadoc(),
                                                                                                                        classDef.ConvertToJavadoc());
                    subOperatorBlock.AppendLine(singleOperatorHelp);

                    var singleOperator = string.Format(AllPackageClasses.ClassStub.OperatorStub.IMPLICIT_EXECUTION_FORMAT, implClass, classDef);
                    subOperatorBlock.AppendLine(singleOperator);
                }
            }

            if (isGeneric)
            {
                // auto cast to non generic 

                var implClass = classDefinition.ToFullQualifiedClassName(false, JNetReflectorCore.UseCamel);
                var classDef = classDefinition.ToFullQualifiedClassName(true, JNetReflectorCore.UseCamel);

                var singleOperatorHelp = string.Format(AllPackageClasses.ClassStub.OperatorStub.DEFAULT_DECORATION, implClass.ConvertToJavadoc(),
                                                                                                                    classDef.ConvertToJavadoc());
                subOperatorBlock.AppendLine(singleOperatorHelp);

                var singleOperator = string.Format(AllPackageClasses.ClassStub.OperatorStub.IMPLICIT_EXECUTION_FORMAT, implClass, classDef);
                subOperatorBlock.AppendLine(singleOperator);
            }

            return subOperatorBlock.ToString();
        }

        static IList<Method> PrefilterMethods(this Class classDefinition, bool isGeneric, out bool isMainClass)
        {
            isMainClass = false;
            ReportTrace(ReflectionTraceLevel.Info, "******************* Prefilter Methods of {0} *******************", classDefinition.GenericString);

            List<Method> prefilteredMethods = new List<Method>();
            foreach (var method in classDefinition.DeclaredMethods)
            {
                var genString = method.GenericString;
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;

                if (methodNameOrigin.Contains(SpecialNames.NestedClassSeparator)) // scala classes can contains this kind of methods
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded not manegeable method {0}", genString);
                    continue;
                }

                if (methodNameOrigin == "main" && method.IsStatic())
                {
                    isMainClass = true;
                    prefilteredMethods.Clear();
                    return prefilteredMethods;
                }

                if (paramCount == 0 && !method.IsVoid() &&
                    (methodNameOrigin == "toString" || methodNameOrigin == "hashCode")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 0 && method.IsVoid() &&
                    (methodNameOrigin == "notify" || methodNameOrigin == "notifyAll" || methodNameOrigin == " wait")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 1 && method.IsVoid() &&
                    (methodNameOrigin == " wait")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 1 && !method.IsVoid() &&
                    (methodNameOrigin == "equals")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 2 && method.IsVoid() &&
                    (methodNameOrigin == " wait")
                   ) continue; // special methods managed from JCOBridge

                if (!JNetReflectorCore.ReflectDeprecated && method.IsDeprecated())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded deprecated method {0}", genString);
                    continue;
                }

                if (method.IsFromSuperInterface())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded IsFromSuperInterface method {0}", genString);
                    continue; // this is very time consuming, anyway seems the only way to identify if a method was defined in the super abstract class
                }

                if (method.IsOverrideOrConcrete())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded OverrideOrConcrete method {0}", genString);
                    continue; // this is very time consuming, anyway seems the only way to identify if a method was defined in the super abstract class
                }

                if (!method.IsPublic()) continue; // avoid not public methods
                if (JNetReflectorCore.DisableGenerics && method.ReturnType.IsOrInheritFromJVMGenericClass())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded IsOrInheritFromJVMGenericClass method {0}", genString);
                    continue; // avoid generics till now
                }
                if (method.ReturnType.MustBeAvoided())
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded MustBeAvoided method for ReturnType {0}", genString);
                    continue;
                }

                prefilteredMethods.Add(method);
            }

            return prefilteredMethods;
        }

        static string AnalyzeMethods(this Class classDefinition, ICollection<Class> classDefinitions, IList<Method> prefilteredMethods, bool isGeneric, bool isNested, bool staticMethods)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Methods of {0} with static {1} *******************", classDefinition.GenericString, staticMethods);

            if (!JNetReflectorCore.DisableGenericsInNonGenericClasses && !JNetReflectorCore.DisableGenerics && !classDefinition.IsJVMGenericClass())
            {
                isGeneric = true; // force generic to true to build generic methods on classes that does not have generics
            }

            var singleMethodTemplate = Template.GetTemplate(Template.SingleMethodTemplate);
            var singlePropertyTemplate = Template.GetTemplate(Template.SinglePropertyTemplate);

            StringBuilder subClassBlock = new StringBuilder();
            SortedDictionary<string, Method> methods = new SortedDictionary<string, Method>();
            SortedDictionary<string, IList<Method>> properties = new SortedDictionary<string, IList<Method>>();

            foreach (var method in prefilteredMethods.ToArray())
            {
                if (staticMethods ^ method.IsStatic()) continue;

                var genString = method.GenericString;
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;

                if (method.IsProperty())
                {
                    var propertyName = method.PropertyName(classDefinitions, false, JNetReflectorCore.UseCamel);
                    if (propertyName.IsReservedName()
                        || propertyName.CollapseWithClassOrNestedClass(classDefinitions)
                        || propertyName.CollapseWithOtherMethods(method, prefilteredMethods, classDefinitions, JNetReflectorCore.UseCamel))
                    {
                        methods.Add(genString, method);
                    }
                    else
                    {
                        IList<Method> propertyMethods;
                        if (!properties.TryGetValue(propertyName, out propertyMethods))
                        {
                            propertyMethods = new List<Method>();
                            properties.Add(propertyName, propertyMethods);
                        }

                        propertyMethods.Add(method);
                    }
                }
                else
                {
                    methods.Add(genString, method);
                }
            }

            List<string> classGenerics = new List<string>();
            List<KeyValuePair<string, string>> classClauses = new List<KeyValuePair<string, string>>();
            classDefinition.GetGenerics(classGenerics, classClauses, string.Empty, JNetReflectorCore.UseCamel);

            foreach (var prop in properties.ToArray())
            {
                string methodName = prop.Key;
                string modifier = string.Empty;
                string returnType = string.Empty;
                Method getMethod = null;
                Method setMethod = null;
                var propToCheck = new List<Method>(prop.Value);
                if (propToCheck.Count > 2)
                {
                    List<Method> getMethods = new List<Method>();
                    List<Method> setMethods = new List<Method>();
                    // test properties with duplicated name
                    foreach (var item in propToCheck)
                    {
                        if (item.IsGetProperty()) getMethods.Add(item);
                        if (item.IsSetProperty()) setMethods.Add(item);
                    }

                    if (getMethods.Count > 1)
                    {
                        foreach (var item in getMethods)
                        {
                            propToCheck.Remove(item);
                            methods.Add(item.GenericString, item);
                            ReportTrace(ReflectionTraceLevel.Debug, "Get Property moved to methods {0}", item.GenericString);
                        }
                    }

                    if (setMethods.Count > 1)
                    {
                        foreach (var item in setMethods)
                        {
                            propToCheck.Remove(item);
                            methods.Add(item.GenericString, item);
                            ReportTrace(ReflectionTraceLevel.Debug, "Set Property moved to methods {0}", item.GenericString);
                        }
                    }
                }

                if (propToCheck.Count == 0)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "No more properties to be created");
                    break;
                }

                List<string> genArguments = new List<string>();

                foreach (var item in propToCheck)
                {
                    if (item.IsGetProperty()) { getMethod = item; modifier = item.IsStatic() ? " static" : string.Empty; returnType = item.ReturnType(genArguments, null, string.Empty, isGeneric, JNetReflectorCore.UseCamel); }
                    if (item.IsSetProperty()) { setMethod = item; }
                }

                var returnTypeForDoc = returnType.Contains('<') ? returnType.Substring(0, returnType.IndexOf('<')) : returnType;

                if (returnType.StartsWith(SpecialNames.JavaLangClass))
                {
                    returnType = returnTypeForDoc;
                }

                if (isGeneric && genArguments.Count != 0 && classGenerics != null)
                {
                    bool usableGenStrings = true;
                    foreach (var genString in genArguments)
                    {
                        if (!classGenerics.Contains(genString)) usableGenStrings = false;
                    }
                    if (!usableGenStrings)
                    {
                        returnType = returnTypeForDoc;
                    }
                }

                bool isArrayReturnType = false;
                if (returnType.EndsWith(SpecialNames.ArrayTypeTrailer))
                {
                    isArrayReturnType = true;
                    returnType = returnType.Substring(0, returnType.IndexOf(SpecialNames.ArrayTypeTrailer));
                }

                if (getMethod == null && setMethod != null)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Property moved to methods {0}", prop.Key);
                    methods.Add(setMethod.GenericString, setMethod);
                    continue;
                } // avoid to create property which have only a set method

                bool isGetDeprecated = false;
                bool isSetDeprecated = false;

                StringBuilder executionStub = new StringBuilder();
                if (getMethod != null)
                {
                    string execStub = getMethod.IsStatic() ? "SExecute" : "IExecute";
                    if (isArrayReturnType) execStub += "Array";
                    if (JNetReflectorCore.ReflectDeprecated) isGetDeprecated = getMethod.IsDeprecated();
                    if (getMethod.IsReturnTypeAnException())
                    {
                        var execFormat = getMethod.IsStatic() ? AllPackageClasses.ClassStub.PropertyStub.STATIC_GET_EXECUTION_FORMAT_EXCEPTION : AllPackageClasses.ClassStub.PropertyStub.GET_EXECUTION_FORMAT_EXCEPTION;
                        executionStub.AppendFormat(execFormat, execStub, returnType, getMethod.Name);
                    }
                    else
                    {
                        var execFormat = getMethod.IsStatic() ? AllPackageClasses.ClassStub.PropertyStub.STATIC_GET_EXECUTION_FORMAT : AllPackageClasses.ClassStub.PropertyStub.GET_EXECUTION_FORMAT;
                        executionStub.AppendFormat(execFormat, execStub, 
                                                               getMethod.IsVoid() || getMethod.IsObjectReturnType(isGeneric, JNetReflectorCore.UseCamel) ? string.Empty : $"<{returnType}>",
                                                               getMethod.Name);
                    }
                }

                if (setMethod != null)
                {
                    if (JNetReflectorCore.ReflectDeprecated) isSetDeprecated = setMethod.IsDeprecated();
                    string setExecStub = setMethod.IsStatic() ? AllPackageClasses.ClassStub.PropertyStub.STATIC_SET_EXECUTION_FORMAT : AllPackageClasses.ClassStub.PropertyStub.SET_EXECUTION_FORMAT;
                    if (returnType.EndsWith(SpecialNames.ArrayTypeTrailer))
                    {
                        setExecStub = setMethod.IsStatic() ? AllPackageClasses.ClassStub.PropertyStub.STATIC_SET_ARRAY_EXECUTION_FORMAT : AllPackageClasses.ClassStub.PropertyStub.SET_ARRAY_EXECUTION_FORMAT;
                    }
                    executionStub.AppendFormat(setExecStub, setMethod.IsStatic() ? "SExecute" : "IExecute",
                                                              setMethod.Name);
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing properties of {0}", prop.Key);

                StringBuilder jPropDecoration = new StringBuilder(AllPackageClasses.ClassStub.PropertyStub.DEFAULT_DECORATION);
                if (isGetDeprecated || isSetDeprecated)
                {
                    jPropDecoration.AppendLine();
                    jPropDecoration.Append(AllPackageClasses.ClassStub.MethodStub.OBSOLETE_DECORATION);
                }

                var singleProperty = singlePropertyTemplate.Replace(AllPackageClasses.ClassStub.PropertyStub.DECORATION, jPropDecoration.ToString())
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.MODIFIER, modifier)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.TYPE, isArrayReturnType ? returnType + SpecialNames.ArrayTypeTrailer : returnType)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.NAME, methodName)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.EXECUTION, executionStub.ToString())
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.GET_HELP, getMethod != null ? getMethod.JavadocHrefUrl(JNetReflectorCore.UseCamel) : string.Empty)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.SET_HELP, setMethod != null ? setMethod.JavadocHrefUrl(JNetReflectorCore.UseCamel) : string.Empty);

                subClassBlock.AppendLine(singleProperty);
            }

            foreach (var item in methods)
            {
                var method = item.Value;
                var genString = method.GenericString;
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;

                List<string> genericArguments = new List<string>();
                List<KeyValuePair<string, string>> genericClauses = new List<KeyValuePair<string, string>>();
                List<string> retGenArguments = new List<string>();
                List<KeyValuePair<string, string>> retGenClause = new List<KeyValuePair<string, string>>();
                string modifier = method.IsStatic() ? " static" : string.Empty;
                string returnType = method.ReturnType(retGenArguments, retGenClause, "Return", isGeneric, JNetReflectorCore.UseCamel);
                genericArguments.AddRange(retGenArguments);
                genericClauses.AddRange(retGenClause);
                string methodName = method.MethodName(classDefinitions, false, JNetReflectorCore.UseCamel);

                if (methodName == "Clone" && returnType == "object") continue;
                if (methodName == "Dispose") modifier = " new" + modifier; // avoids warning for override
                if (returnType.StartsWith(SpecialNames.JavaLangClass))
                {
                    returnType = returnType.Contains('<') ? returnType.Substring(0, returnType.IndexOf('<')) : returnType;
                }

                bool bypass = false;
                bool hasVarArg = false;
                List<Parameter> parameters = new List<Parameter>();
                Parameter varArg = null;

                foreach (var parameter in method.Parameters)
                {
                    if (JNetReflectorCore.DisableGenerics && parameter.Type.IsOrInheritFromJVMGenericClass()) { bypass = true; break; }
                    if (parameter.Type.MustBeAvoided()) { bypass = true; break; }
                    if (!parameter.IsVarArgs)
                    {
                        parameters.Add(parameter);
                    }
                    else // store var arg becuase it is not clear that results are ordered
                    {
                        hasVarArg = true;
                        varArg = parameter;
                    }
                }

                if (bypass)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded method {0}", genString);
                    continue;
                }
                if (hasVarArg)
                {
                    parameters.Add(varArg);
                }

                StringBuilder methodHelpBuilder = new StringBuilder();
                StringBuilder methodParamsBuilder = new StringBuilder();
                StringBuilder methodExecutionParamsBuilder = new StringBuilder();

                foreach (var parameter in parameters)
                {
                    List<string> paramGenArguments = new List<string>();
                    List<KeyValuePair<string, string>> paramGenClause = new List<KeyValuePair<string, string>>();
                    var typeStr = parameter.Type(paramGenArguments, paramGenClause, parameter.Name().Camel(), isGeneric, JNetReflectorCore.UseCamel);
                    var typeStrForDoc = typeStr.Contains('<') ? typeStr.Substring(0, typeStr.IndexOf('<')) : typeStr;
                    if (isGeneric && paramGenArguments.Count != 0 && classGenerics != null)
                    {
                        bool usableGenStrings = true;
                        if (typeStr.IsNetNativeType()) usableGenStrings = false;
                        else if (typeStr.EndsWith(SpecialNames.ArrayTypeTrailer))
                        {
                            typeStr = typeStr.Substring(0, typeStr.IndexOf(SpecialNames.ArrayTypeTrailer));
                        }
                        else if (typeStr.StartsWith(SpecialNames.JavaLangClass))
                        {
                            typeStr = typeStrForDoc;
                            usableGenStrings = false;
                        }
                        if (usableGenStrings && !typeStr.IsNetNativeType())
                        {
                            genericArguments.AddRange(paramGenArguments);
                            genericClauses.AddRange(paramGenClause);
                        }
                    }

                    methodHelpBuilder.AppendLine(string.Format(AllPackageClasses.ClassStub.ConstructorStub.HELP_PARAM_DECORATION, parameter.Name,
                                                                                                                                  typeStrForDoc.ConvertToJavadoc()));
                    if (parameter.IsVarArgs)
                    {
                        if (!typeStr.EndsWith(SpecialNames.ArrayTypeTrailer)) typeStr += SpecialNames.ArrayTypeTrailer;
                        methodParamsBuilder.AppendFormat($"params {typeStr} {varArg.Name()}, ");
                    }
                    else
                    {
                        methodParamsBuilder.AppendFormat($"{typeStr} {parameter.Name()}, ");
                        methodExecutionParamsBuilder.AppendFormat($"{parameter.Name()}, ");
                    }
                }

                if (isGeneric)
                {
                    string[] argArray = genericArguments.ToArray();
                    KeyValuePair<string, string>[] argClausesArray = genericClauses.ToArray();
                    for (int i = 0; i < argArray.Length; i++)
                    {
                        int counter = 0;
                        foreach (var genericArgument in genericArguments)
                        {
                            if (genericArgument == argArray[i]) counter++;
                        }
                        if (counter > 1)
                        {
                            for (int i2 = i + 1; i2 < argArray.Length; i2++)
                            {
                                if (argArray[i] == argArray[i2])
                                {
                                    argArray[i2] = null;
                                }
                            }
                        }
                    }
                    genericArguments.Clear();
                    genericClauses.Clear();
                    for (int i = 0; i < argArray.Length; i++)
                    {
                        var argInArray = argArray[i];
                        if (argInArray != null)
                        {
                            if (argInArray.IsNetNativeType()) continue;
                            else if (argInArray.EndsWith(SpecialNames.ArrayTypeTrailer))
                            {
                                var valueToAdd = argInArray.Substring(0, argInArray.IndexOf(SpecialNames.ArrayTypeTrailer));
                                genericArguments.Add(valueToAdd);
                                genericClauses.Add(new KeyValuePair<string, string>(valueToAdd, argClausesArray[i].Value));
                            }
                            else
                            {
                                genericArguments.Add(argInArray);
                                genericClauses.Add(new KeyValuePair<string, string>(argInArray, argClausesArray[i].Value));
                            }
                        }
                    }

                    if (classGenerics != null)
                    {
                        foreach (var classGeneric in classGenerics)
                        {
                            if (genericArguments.Contains(classGeneric))
                            {
                                genericArguments.Remove(classGeneric);
                                foreach (var genericClause in genericClauses.ToArray())
                                {
                                    if (genericClause.Key == classGeneric)
                                    {
                                        genericClauses.Remove(genericClause);
                                    }
                                }
                            }
                        }
                    }

                    methodName += genericArguments.ApplyGenerics();
                }

                string paramsString = methodParamsBuilder.ToString();
                string executionParamsString = methodExecutionParamsBuilder.ToString();
                if (paramCount != 0)
                {
                    if (paramsString.EndsWith(", ")) paramsString = paramsString.Substring(0, paramsString.Length - 2); // remove last occurrence of ", "
                    if (executionParamsString.EndsWith(", ")) executionParamsString = executionParamsString.Substring(0, executionParamsString.Length - 2); // remove last occurrence of ", "
                }

                bool isArrayReturnType = false;

                string execStub = method.IsStatic() ? "SExecute" : "IExecute";
                if (returnType.EndsWith(SpecialNames.ArrayTypeTrailer))
                {
                    returnType = returnType.Substring(0, returnType.IndexOf(SpecialNames.ArrayTypeTrailer));
                    execStub += "Array";
                    isArrayReturnType = true;
                }

                if (paramCount == 1 && parameters[0].Type(null, null, parameters[0].Name().Camel(), isGeneric, JNetReflectorCore.UseCamel).EndsWith(SpecialNames.ArrayTypeTrailer))
                {
                    executionParamsString = string.Format(AllPackageClasses.ClassStub.MethodStub.SINGLE_ARRAY_EXECUTION_FORMAT, parameters[0].Name);
                }

                bool isVoidMethod = method.IsVoid();
                bool isReturnTypeException = method.IsReturnTypeAnException();
                string executionStub = string.Empty;
                if (isReturnTypeException)
                {
                    var execFormat = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTION_FORMAT_EXCEPTION : AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT_EXCEPTION;
                    executionStub = string.Format(execFormat, execStub,
                                                              methodNameOrigin,
                                                              executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString,
                                                              returnType);
                }
                else
                {
                    var execFormat = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTION_FORMAT : AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT;
                    executionStub = string.Format(execFormat, method.IsVoid() ? string.Empty : "return ",
                                                              execStub,
                                                              isVoidMethod || method.IsObjectReturnType(isGeneric, JNetReflectorCore.UseCamel) ? string.Empty : $"<{returnType}>",
                                                              methodNameOrigin,
                                                              executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString);
                }

                if (hasVarArg)
                {
                    string executionStubWithVarArg = string.Empty;
                    if (isReturnTypeException)
                    {
                        var execFormat = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTION_FORMAT_EXCEPTION : AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT_EXCEPTION;
                        executionStubWithVarArg = string.Format(execFormat, execStub,
                                                                            methodNameOrigin,
                                                                            (executionParamsString.Length == 0 ? string.Empty : ", ")
                                                                            + executionParamsString + ", " + varArg.Name(),
                                                                            returnType);
                    }
                    else
                    {
                        var execFormat = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTION_FORMAT : AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT;
                        executionStubWithVarArg = string.Format(execFormat, isVoidMethod ? string.Empty : "return ",
                                                                            execStub,
                                                                            isVoidMethod || method.IsObjectReturnType(isGeneric, JNetReflectorCore.UseCamel) ? string.Empty : $"<{returnType}>",
                                                                            methodNameOrigin,
                                                                            (executionParamsString.Length == 0 ? string.Empty : ", ")
                                                                            + executionParamsString + ", " + varArg.Name());
                    }
                    executionStub = $"if ({varArg.Name()}.Length == 0) {executionStub} else {executionStubWithVarArg}";
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing method {0}", genString);

                if (!isVoidMethod)
                {
                    var returnTypeForDocs = returnType.Contains('<') ? returnType.Substring(0, returnType.IndexOf('<')) : returnType;
                    string strReturn = string.Format(AllPackageClasses.ClassStub.MethodStub.HELP_RETURN_DECORATION, returnTypeForDocs.ConvertToJavadoc());
                    if (!methodHelpBuilder.ToString().EndsWith(Environment.NewLine)) methodHelpBuilder.AppendLine();
                    methodHelpBuilder.Append(strReturn);
                }
                var exceptions = method.ExceptionTypes;
                if (exceptions.Length > 0)
                {
                    StringBuilder exceptionBuilder = new StringBuilder();
                    for (int i = 0; i < exceptions.Length; i++)
                    {
                        var expType = exceptions[i].ToNetType(JNetReflectorCore.UseCamel);
                        exceptionBuilder.AppendFormat(AllPackageClasses.ClassStub.MethodStub.HELP_EXCEPTION_DECORATION, expType.ConvertToJavadoc());
                        if (i < exceptions.Length - 1) exceptionBuilder.AppendLine();
                    }
                    if (!methodHelpBuilder.ToString().EndsWith(Environment.NewLine)) methodHelpBuilder.AppendLine();
                    methodHelpBuilder.Append(exceptionBuilder.ToString());
                }

                StringBuilder jDecoration = new StringBuilder(AllPackageClasses.ClassStub.MethodStub.DEFAULT_DECORATION);
                string paramHelp = methodHelpBuilder.ToString();
                if (paramHelp.EndsWith(Environment.NewLine)) paramHelp = paramHelp.Substring(0, paramHelp.LastIndexOf(Environment.NewLine));
                if (!string.IsNullOrEmpty(paramHelp))
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(paramHelp);
                }
                if (JNetReflectorCore.ReflectDeprecated && method.IsDeprecated())
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(AllPackageClasses.ClassStub.MethodStub.OBSOLETE_DECORATION);
                }

                var singleMethod = singleMethodTemplate.Replace(AllPackageClasses.ClassStub.MethodStub.DECORATION, jDecoration.ToString())
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.MODIFIER, modifier)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.RETURNTYPE, isArrayReturnType ? returnType + SpecialNames.ArrayTypeTrailer : returnType)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.NAME, methodName)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.PARAMETERS, paramsString)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.WHERECLAUSES, genericClauses.ConvertClauses(isGeneric)) // method.WhereClauses(isGeneric))
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.EXECUTION, executionStub)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.HELP, method.JavadocHrefUrl(JNetReflectorCore.UseCamel));

                subClassBlock.AppendLine(singleMethod);
            }

            return subClassBlock.ToString();
        }

        static string AnalyzeFields(this Class classDefinition, ICollection<Class> classDefinitions, bool isGeneric)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Fields of {0} *******************", classDefinition.GenericString);

            var singleFieldTemplate = Template.GetTemplate(Template.SingleFieldTemplate);

            SortedDictionary<string, Field> sortedFilteredFields = new SortedDictionary<string, Field>();

            foreach (var field in classDefinition.Fields)
            {
                if (!field.DeclaringClass.Equals(classDefinition)) continue;
                if (field.Type.MustBeAvoided()) continue;
                if (!field.IsPublic()) continue; // avoid not public methods
                bool isDeprecated = field.IsDeprecated();
                if (!JNetReflectorCore.ReflectDeprecated && isDeprecated)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded deprecated field {0}", field.GenericString);
                    continue; // avoid generics till now
                }
                bool isFieldGeneric = field.Type.IsOrInheritFromJVMGenericClass();
                if (JNetReflectorCore.DisableGenerics && isFieldGeneric)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarding generic class {0}", field.GenericString);
                    continue;
                }

                sortedFilteredFields.Add(field.GenericString, field);
            }

            StringBuilder subClassBlock = new StringBuilder();
            foreach (var field in sortedFilteredFields.Values)
            {
                bool isDeprecated = field.IsDeprecated();
                string modifier = field.IsStatic() ? " static" : string.Empty;
                if (field.IsTypeNative())
                {
                    //  modifier += field.IsFinal() ? " readonly" : string.Empty; // avoid till now because seems not compile the test project
                }
                List<string> genArguments = new List<string>();
                List<KeyValuePair<string, string>> genClause = new List<KeyValuePair<string, string>>();
                string fieldType = field.Type(genArguments, genClause, isGeneric, JNetReflectorCore.UseCamel);
                string fieldName = field.Name(false);

                if (fieldName.IsReservedName() || fieldName.CollapseWithClassOrNestedClass(classDefinitions))
                {
                    fieldName += "Field";
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing field {0}", field.GenericString);

                string executionStub = string.Format(AllPackageClasses.ClassStub.FieldStub.EXECUTION_FORMAT, field.IsStatic() ? "Clazz" : "Instance",
                                                                                                             field.IsObjectReturnType(JNetReflectorCore.UseCamel) ? string.Empty : $"<{fieldType}>",
                                                                                                             field.Name);

                StringBuilder jDecoration = new StringBuilder(AllPackageClasses.ClassStub.FieldStub.DEFAULT_DECORATION);
                if (isDeprecated)
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(AllPackageClasses.ClassStub.FieldStub.OBSOLETE_DECORATION);
                }

                var singleField = singleFieldTemplate.Replace(AllPackageClasses.ClassStub.FieldStub.DECORATION, jDecoration.ToString())
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.MODIFIER, modifier)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.TYPE, fieldType)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.NAME, fieldName)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.EXECUTION, executionStub)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.HELP, field.JavadocHrefUrl(JNetReflectorCore.UseCamel));

                subClassBlock.AppendLine(singleField);
            }

            return subClassBlock.ToString();
        }
    }
}
