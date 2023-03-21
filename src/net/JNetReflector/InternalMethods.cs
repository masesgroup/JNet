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
            if (JNetReflectorCore.JarsToAnaylyze != null)
            {
                AnalyzeJars();
            }
            else if (JNetReflectorCore.ModulesToParse != null)
            {
                AnalyzeNamespaces();
            }
            else throw new ArgumentException("At least one of NamespacesToParse or OriginRootPath must be set");
            w.Stop();
            Console.WriteLine();
            Console.WriteLine($"Operation completed in {w.Elapsed}. Namespaces: {namespaces} - Classes: {classes}");
        }

        public static void AnalyzeJars()
        {
            foreach (var item in JNetReflectorCore.JarsToAnaylyze)
            {
                AnalyzeJar(item);
            }
        }

        public static void AddItem(IDictionary<string, IDictionary<string, IDictionary<string, Class>>> data, Class cls)
        {
            if (cls == null) return;
            ReportTrace(ReflectionTraceLevel.Debug, "Adding entry {0}", cls.Name);
            var package = cls.Namespace();
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

        public static void AnalyzeJar(string pathToJar)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Jar {0} *******************", pathToJar);
            using (ZipArchive archive = ZipFile.OpenRead(pathToJar))
            {
                SortedDictionary<string, IDictionary<string, IDictionary<string, Class>>> resultingArguments = new SortedDictionary<string, IDictionary<string, IDictionary<string, Class>>>();

                foreach (var entry in archive.Entries)
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Entry {0}", entry.ToString());
                    if (entry.IsSpecialFolder()) continue; // do not reflect this folders
                    if (entry.IsSpecialClass()) continue; // do not reflect this classes
                    if (entry.IsJVMClass() || entry.IsJVMNestedClass())
                    {
                        var jClass = entry.JVMClass();
                        AddItem(resultingArguments, jClass);
                    }
                }

                ReportTrace(ReflectionTraceLevel.Info, "Starting analysis for {0} entries", resultingArguments.Count);
                var jarName = Path.GetFileName(pathToJar);
                AnalyzeItems(resultingArguments, jarName);
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
                ReportTrace(ReflectionTraceLevel.Debug, "Entry {0}", entry.Name);
                if (entry.IsSpecialClass()) continue; // do not reflect this classes
                if (entry.IsNamespaceToAvoid()) continue; // do not reflect this classes
                if (entry.IsJVMClass() || entry.IsJVMNestedClass())
                {
                    AddItem(data, entry);
                }
            }

            ReportTrace(ReflectionTraceLevel.Info, "Starting analysis for {0} entries", data.Count);
            AnalyzeItems(data, ns);
        }

        static string JarOrModuleName { get; set; }

        static void AnalyzeItems(IDictionary<string, IDictionary<string, IDictionary<string, Class>>> items, string jarOrModuleName)
        {
            JarOrModuleName = jarOrModuleName;

            if (!JNetReflectorCore.AvoidParallelBuild)
            {
                ParallelOptions po = new ParallelOptions();
                po.MaxDegreeOfParallelism = System.Environment.ProcessorCount;
                Parallel.ForEach(items, po, AnalyzeSubItemsParallel);
            }
            else
            {
                foreach (var item in items)
                {
                    AnalyzeSubItems(item.Key, item.Value, JarOrModuleName);
                }
            }
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
            var allPackageStubNestedClass = Template.GetTemplate(Template.AllPackageClassesStubNestedClassTemplate);
            var allPackageStubNestedClassListener = Template.GetTemplate(Template.AllPackageClassesStubNestedClassListenerTemplate);
            var allPackageStubNestedException = Template.GetTemplate(Template.AllPackageClassesStubNestedExceptionTemplate);
            var allPackageStubClass = Template.GetTemplate(Template.AllPackageClassesStubClassTemplate);
            var allPackageStubClassListener = Template.GetTemplate(Template.AllPackageClassesStubClassListenerTemplate);
            var allPackageStubException = Template.GetTemplate(Template.AllPackageClassesStubExceptionTemplate);
            var singleClassTemplate = Template.GetTemplate(Template.SingleClassTemplate);
            var singleNestedClassTemplate = Template.GetTemplate(Template.SingleNestedClassTemplate);

            StringBuilder subClassBlock = new StringBuilder();
            StringBuilder subClassAutonoumous = new StringBuilder();
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

            foreach (var entry in nestedClasses)
            {
                string nestedClassBlock;
                string singleNestedClassStr;
                entry.PrepareSingleClass(classDefinitions, 3, allPackageStubNestedException, allPackageStubNestedClassListener, allPackageStubNestedClass, singleNestedClassTemplate, out nestedClassBlock, out singleNestedClassStr);

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

            string classBlock;
            string singleClassStr;
            jClass.PrepareSingleClass(classDefinitions, 2, allPackageStubException, allPackageStubClassListener, allPackageStubClass, singleClassTemplate, out classBlock, out singleClassStr);

            if (!string.IsNullOrEmpty(singleClassStr))
            {
                singleClassStr = singleClassStr.Replace(AllPackageClasses.VERSION, SpecialNames.VersionPlaceHolder())
                                               .Replace(AllPackageClasses.JAR, jarOrModuleName)
                                               .Replace(AllPackageClasses.NAMESPACE, jClass.Namespace())
                                               .Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, subClassAutonoumous.ToString());

                var clsName = jClass.JVMClassName(true);
                var classPath = Path.Combine(rootDesinationFolder, jClass.Namespace().Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar), $"{clsName}.cs");
                WriteFile(classPath, singleClassStr);
            }

            var subClassStr = subClassBlock.ToString();
            classBlock = classBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, subClassStr.Length != 0 ? subClassStr : string.Empty);

            return classBlock;
        }

        static void PrepareSingleClass(this Class jClass, ICollection<Class> classDefinitions, int tabLevel, string stubException, string stubListener, string stubClass, string singleClass, out string classBlock, out string singleClassStr)
        {
            string constructorBlock = string.Empty;
            string operatorBlock = string.Empty;
            string fieldBlock = string.Empty;
            string staticMethodBlock = string.Empty;
            string methodBlock = string.Empty;

            bool jClassIsDepracated = jClass.IsDeprecated();
            bool jClassIsOrFromGeneric = jClass.IsOrInheritFromJVMGenericClass();
            bool jClassIsListener = jClass.IsJVMListenerClass();
            classBlock = string.Empty;

            ReportTrace(ReflectionTraceLevel.Debug, "Preparing nested class {0}", jClass.GenericString);

            if (jClass.IsJVMException())
            {
                classBlock = stubException.Replace(AllPackageClasses.ClassStub.JAVACLASS, jClass.JVMFullClassName())
                                          .Replace(AllPackageClasses.ClassStub.SIMPLECLASS, jClass.JVMClassName(true))
                                          .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(false))
                                          .Replace(AllPackageClasses.ClassStub.HELP, jClass.JavadocHrefUrl())
                                          .Replace(AllPackageClasses.ClassStub.BASECLASS, jClass.JVMBaseClassName(false))
                                          .Replace(AllPackageClasses.ClassStub.WHERECLAUSES, string.Empty)
                                          .Replace(AllPackageClasses.ClassStub.JCOBRIDGE_VERSION, SpecialNames.JCOBridgeVersion);
            }
            else
            {
                bool isSubClassCloseable = jClass.IsCloseable();
                bool isSubClassAbstract = jClass.IsAbstract();
                bool isSubClassInterface = jClass.IsInterface();
                bool isSubClassStatic = jClass.IsStatic();

                string template = jClassIsListener ? stubListener : stubClass;

                classBlock = template.Replace(AllPackageClasses.ClassStub.JAVACLASS, jClass.JVMFullClassName())
                                     .Replace(AllPackageClasses.ClassStub.SIMPLECLASS, jClass.JVMClassName(true))
                                     .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(false))
                                     .Replace(AllPackageClasses.ClassStub.HELP, jClass.JavadocHrefUrl())
                                     .Replace(AllPackageClasses.ClassStub.BASECLASS, jClass.JVMBaseClassName(jClassIsListener))
                                     .Replace(AllPackageClasses.ClassStub.WHERECLAUSES, jClass.WhereClauses())
                                     .Replace(AllPackageClasses.ClassStub.ISABSTRACT, isSubClassAbstract ? "true" : "false")
                                     .Replace(AllPackageClasses.ClassStub.ISCLOSEABLE, isSubClassCloseable ? "true" : "false")
                                     .Replace(AllPackageClasses.ClassStub.ISINTERFACE, isSubClassInterface ? "true" : "false")
                                     .Replace(AllPackageClasses.ClassStub.ISSTATIC, isSubClassStatic ? "true" : "false")
                                     .Replace(AllPackageClasses.ClassStub.JCOBRIDGE_VERSION, SpecialNames.JCOBridgeVersion);

                if (!jClassIsListener)
                {
                    constructorBlock = jClass.AnalyzeConstructors(classDefinitions, true).AddTabLevel(tabLevel);
                    operatorBlock = jClass.AnalyzeOperators(classDefinitions, true).AddTabLevel(tabLevel);
                    fieldBlock = jClass.AnalyzeFields(classDefinitions).AddTabLevel(tabLevel);
                    var nestedPrefilter = jClass.PrefilterMethods();
                    staticMethodBlock = jClass.AnalyzeMethods(classDefinitions, nestedPrefilter, true, true).AddTabLevel(tabLevel);
                    methodBlock = jClass.AnalyzeMethods(classDefinitions, nestedPrefilter, true, false).AddTabLevel(tabLevel);
                }
            }

            singleClassStr = string.Empty;

            if (!jClassIsListener)
            {
                StringBuilder jClassDecoration = new StringBuilder(AllPackageClasses.ClassStub.DEFAULT_DECORATION.AddTabLevel(tabLevel - 1));
                if (jClassIsDepracated)
                {
                    jClassDecoration.AppendLine();
                    jClassDecoration.Append(AllPackageClasses.ClassStub.OBSOLETE_DECORATION.AddTabLevel(tabLevel - 1));
                }

                singleClassStr = singleClass.Replace(AllPackageClasses.ClassStub.DECORATION, jClassDecoration.ToString())
                                            .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(false))
                                            .Replace(AllPackageClasses.ClassStub.CONSTRUCTORS, constructorBlock)
                                            .Replace(AllPackageClasses.ClassStub.OPERATORS, operatorBlock)
                                            .Replace(AllPackageClasses.ClassStub.FIELDS, fieldBlock)
                                            .Replace(AllPackageClasses.ClassStub.STATICMETHODS, staticMethodBlock)
                                            .Replace(AllPackageClasses.ClassStub.METHODS, methodBlock);
            }
        }

        static string AnalyzeConstructors(this Class classDefinition, ICollection<Class> classDefinitions, bool isNested)
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

            StringBuilder subClassBlock = new StringBuilder();
            foreach (var constructor in sortedFilteredCtors.Values)
            {
                var paramCount = constructor.ParameterCount;
                var methodNameOrigin = constructor.Name;

                bool isDeprecated = constructor.IsDeprecated();
                string modifier = constructor.IsStatic() ? " static" : string.Empty;
                string constructorName = constructor.Name();
                bool bypass = false;
                bool hasVarArg = false;
                Parameter varArg = null;
                StringBuilder constructorHelpBuilder = new StringBuilder();
                StringBuilder constructorParamsBuilder = new StringBuilder();
                StringBuilder constructorExecutionParamsBuilder = new StringBuilder();
                foreach (var parameter in constructor.Parameters)
                {
                    if (JNetReflectorCore.DisableGenerics && parameter.Type.IsOrInheritFromJVMGenericClass()) { bypass = true; break; }
                    if (parameter.Type.MustBeAvoided()) { bypass = true; break; }
                    if (parameter.Type() == "object[]") { bypass = true; break; }
                    if (!parameter.IsVarArgs)
                    {
                        var typeStr = parameter.Type();
                        constructorHelpBuilder.AppendLine(string.Format(AllPackageClasses.ClassStub.ConstructorStub.HELP_PARAM_DECORATION, parameter.Name,
                                                                                                                                           typeStr.ConvertToJavadoc()));
                        constructorParamsBuilder.AppendFormat($"{typeStr} {parameter.Name}, ");
                        constructorExecutionParamsBuilder.AppendFormat($"{parameter.Name}, ");
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
                if (hasVarArg && paramCount == 1 && varArg.IsObjectType()) continue; // this kinf of constructor is managed from AllClasses template as default for any JCOBridge reflected class
                if (hasVarArg)
                {
                    var typeStr = varArg.Type();
                    constructorHelpBuilder.AppendLine(string.Format(AllPackageClasses.ClassStub.ConstructorStub.HELP_PARAM_DECORATION, varArg.Name,
                                                                                                                                       typeStr.ConvertToJavadoc()));
                    constructorParamsBuilder.AppendFormat($"params {varArg.Type()} {varArg.Name}, ");
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
                        var expType = exceptions[i].ToNetType();
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
                                                                 .Replace(AllPackageClasses.ClassStub.ConstructorStub.HELP, constructor.JavadocHrefUrl());

                subClassBlock.AppendLine(singleConstructor);
            }

            return subClassBlock.ToString();
        }

        static string AnalyzeOperators(this Class classDefinition, ICollection<Class> classDefinitions, bool isNested)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Operators of {0} *******************", classDefinition.GenericString);

            StringBuilder subOperatorBlock = new StringBuilder();
            foreach (var implementedInterface in classDefinition.Interfaces)
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

                var singleOperatorHelp = string.Format(AllPackageClasses.ClassStub.OperatorStub.DEFAULT_DECORATION, implementedInterface.ToNetType(),
                                                                                                                    classDefinition.ToNetType());
                subOperatorBlock.AppendLine(singleOperatorHelp);

                var singleOperator = string.Format(AllPackageClasses.ClassStub.OperatorStub.IMPLICIT_EXECUTION_FORMAT, implementedInterface.ToNetType(),
                                                                                                                       classDefinition.ToNetType());
                subOperatorBlock.AppendLine(singleOperator);
            }

            return subOperatorBlock.ToString();
        }

        static IList<Method> PrefilterMethods(this Class classDefinition)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Prefilter Methods of {0} *******************", classDefinition.GenericString);

            List<Method> prefilteredMethods = new List<Method>();
            foreach (var method in classDefinition.DeclaredMethods)
            {
                var genString = method.GenericString;
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;

                if (paramCount == 0 &&
                    (methodNameOrigin == "toString" || methodNameOrigin == "hashCode"
                    || methodNameOrigin == "notify" || methodNameOrigin == "notifyAll" || methodNameOrigin == " wait")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 1 &&
                    (methodNameOrigin == "equals" || methodNameOrigin == " wait")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 2 &&
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
                    continue; // avoid generics till now
                }

                prefilteredMethods.Add(method);
            }

            return prefilteredMethods;
        }

        static string AnalyzeMethods(this Class classDefinition, ICollection<Class> classDefinitions, IList<Method> prefilteredMethods, bool isNested, bool staticMethods)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Methods of {0} with static {1} *******************", classDefinition.GenericString, staticMethods);

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
                    var propertyName = method.PropertyName(classDefinitions);
                    if (propertyName.IsReservedName()
                        || propertyName.CollapseWithClassOrNestedClass(classDefinitions)
                        || propertyName.CollapseWithOtherMethods(prefilteredMethods, classDefinitions))
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

                foreach (var item in propToCheck)
                {
                    if (item.IsGetProperty()) { getMethod = item; modifier = item.IsStatic() ? " static" : string.Empty; returnType = item.ReturnType(); }
                    if (item.IsSetProperty()) { setMethod = item; }
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
                        executionStub.AppendFormat(AllPackageClasses.ClassStub.PropertyStub.GET_EXECUTION_FORMAT_EXCEPTION, execStub,
                                                                                                                            returnType,
                                                                                                                            getMethod.Name);
                    }
                    else
                    {
                        executionStub.AppendFormat(AllPackageClasses.ClassStub.PropertyStub.GET_EXECUTION_FORMAT, execStub,
                                                                                                                  getMethod.IsVoid() || getMethod.IsObjectReturnType() ? string.Empty : $"<{returnType}>",
                                                                                                                  getMethod.Name);
                    }
                }

                if (setMethod != null)
                {
                    if (JNetReflectorCore.ReflectDeprecated) isSetDeprecated = setMethod.IsDeprecated();
                    executionStub.AppendFormat(AllPackageClasses.ClassStub.PropertyStub.SET_EXECUTION_FORMAT, setMethod.IsStatic() ? "SExecute" : "IExecute",
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
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.GET_HELP, getMethod != null ? getMethod.JavadocHrefUrl() : string.Empty)
                                                           .Replace(AllPackageClasses.ClassStub.PropertyStub.SET_HELP, setMethod != null ? setMethod.JavadocHrefUrl() : string.Empty);

                subClassBlock.AppendLine(singleProperty);
            }

            foreach (var item in methods)
            {
                var method = item.Value;
                var genString = method.GenericString;
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;

                string modifier = method.IsStatic() ? " static" : string.Empty;
                string returnType = method.ReturnType();
                string methodName = method.MethodName(classDefinitions);

                if (methodName == "Clone" && returnType == "object") continue;
                if (methodName == "Dispose") modifier = " new" + modifier; // avoids warning for override

                bool bypass = false;
                bool hasVarArg = false;
                Parameter varArg = null;
                StringBuilder methodHelpBuilder = new StringBuilder();
                StringBuilder methodParamsBuilder = new StringBuilder();
                StringBuilder methodExecutionParamsBuilder = new StringBuilder();
                foreach (var parameter in method.Parameters)
                {
                    if (JNetReflectorCore.DisableGenerics && parameter.Type.IsOrInheritFromJVMGenericClass()) { bypass = true; break; }
                    if (parameter.Type.MustBeAvoided()) { bypass = true; break; }
                    if (!parameter.IsVarArgs)
                    {
                        var typeStr = parameter.Type();
                        methodHelpBuilder.AppendLine(string.Format(AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_DECORATION, parameter.Name,
                                                                                                                                 typeStr.ConvertToJavadoc()));
                        methodParamsBuilder.AppendFormat($"{typeStr} {parameter.Name}, ");
                        methodExecutionParamsBuilder.AppendFormat($"{parameter.Name}, ");
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
                    var typeStr = varArg.Type();
                    methodHelpBuilder.AppendLine(string.Format(AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_DECORATION, varArg.Name,
                                                                                                                             typeStr.ConvertToJavadoc()));
                    methodParamsBuilder.AppendFormat($"params {typeStr} {varArg.Name}, ");
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

                bool isVoidMethod = method.IsVoid();
                bool isReturnTypeException = method.IsReturnTypeAnException();
                string executionStub = string.Empty;
                if (isReturnTypeException)
                {
                    executionStub = string.Format(AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT_EXCEPTION, execStub,
                                                                                                                     methodNameOrigin,
                                                                                                                     executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString,
                                                                                                                     returnType);
                }
                else
                {
                    executionStub = string.Format(AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT, method.IsVoid() ? string.Empty : "return ",
                                                                                                           execStub,
                                                                                                           isVoidMethod || method.IsObjectReturnType() ? string.Empty : $"<{returnType}>",
                                                                                                           methodNameOrigin,
                                                                                                           executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString);
                }

                if (hasVarArg)
                {
                    string executionStubWithVarArg = string.Empty;
                    if (isReturnTypeException)
                    {
                        executionStubWithVarArg = string.Format(AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT_EXCEPTION, execStub,
                                                                                                                                   methodNameOrigin,
                                                                                                                                   (executionParamsString.Length == 0 ? string.Empty : ", ")
                                                                                                                                   + executionParamsString + ", " + varArg.Name,
                                                                                                                                   returnType);
                    }
                    else
                    {
                        executionStubWithVarArg = string.Format(AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT, isVoidMethod ? string.Empty : "return ",
                                                                                                                         execStub,
                                                                                                                         isVoidMethod || method.IsObjectReturnType() ? string.Empty : $"<{returnType}>",
                                                                                                                         methodNameOrigin,
                                                                                                                         (executionParamsString.Length == 0 ? string.Empty : ", ")
                                                                                                                         + executionParamsString + ", " + varArg.Name);
                    }
                    executionStub = $"if ({varArg.Name}.Length == 0) {executionStub} else {executionStubWithVarArg}";
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing method {0}", genString);

                if (!isVoidMethod)
                {
                    string strReturn = string.Format(AllPackageClasses.ClassStub.MethodStub.HELP_RETURN_DECORATION, returnType.ConvertToJavadoc());
                    if (!methodHelpBuilder.ToString().EndsWith(Environment.NewLine)) methodHelpBuilder.AppendLine();
                    methodHelpBuilder.Append(strReturn);
                }
                var exceptions = method.ExceptionTypes;
                if (exceptions.Length > 0)
                {
                    StringBuilder exceptionBuilder = new StringBuilder();
                    for (int i = 0; i < exceptions.Length; i++)
                    {
                        var expType = exceptions[i].ToNetType();
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
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.WHERECLAUSES, method.WhereClauses())
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.EXECUTION, executionStub)
                                                       .Replace(AllPackageClasses.ClassStub.MethodStub.HELP, method.JavadocHrefUrl());

                subClassBlock.AppendLine(singleMethod);
            }

            return subClassBlock.ToString();
        }

        static string AnalyzeFields(this Class classDefinition, ICollection<Class> classDefinitions)
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
                string fieldType = field.Type();
                string fieldName = field.Name(false);

                if (fieldName.IsReservedName() || fieldName.CollapseWithClassOrNestedClass(classDefinitions))
                {
                    fieldName += "Field";
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing field {0}", field.GenericString);

                string executionStub = string.Format(AllPackageClasses.ClassStub.FieldStub.EXECUTION_FORMAT, field.IsStatic() ? "Clazz" : "Instance",
                                                                                                             field.IsObjectReturnType() ? string.Empty : $"<{fieldType}>",
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
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.HELP, field.JavadocHrefUrl());

                subClassBlock.AppendLine(singleField);
            }

            return subClassBlock.ToString();
        }
    }
}
