/*
*  Copyright 2024 MASES s.r.l.
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
using System.Reflection;

namespace MASES.JNetReflector
{
    static class ReflectionUtils
    {
        static object _allPackagesLock = new object();
        static Dictionary<string, string> _allPackages = new Dictionary<string, string>();

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
            if (JNetReflectorCore.ClassesToAnalyze != null)
            {
                AnalyzeClasses();
            }
            else if (JNetReflectorCore.JarsToAnalyze != null)
            {
                AnalyzeJars();
            }
            else if (JNetReflectorCore.ModulesToParse != null)
            {
                AnalyzeNamespaces();
            }
            else throw new ArgumentException("At least one of ClassesToAnaylyze, NamespacesToParse or OriginRootPath must be set");
            w.Stop();

            if (JNetReflectorCore.JarsToAnalyze != null)
            {
                foreach (var item in _allPackages)
                {
                    var packageContent = File.ReadAllText(item.Key);
                    var itemPackage = packageContent.Replace(AllPackageClasses.CLASSES, string.Empty);

                    WriteFile(item.Key, itemPackage);
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Operation completed at {DateTime.Now} in {w.Elapsed}. Namespaces: {namespaces} - Classes: {classes}");
        }

        public static void AnalyzeJars()
        {
            List<string> jarNames = new List<string>(JNetReflectorCore.JarsToAnalyze.Select((o) => Path.Combine(JNetReflectorCore.OriginRootPath, o)));
            for (int i = 0; i < jarNames.Count; i++)
            {
                string javadocUrl = JNetReflectorCore.OriginJavadocUrl;
                int javadocVersion = JNetReflectorCore.JavadocVersion;
                if (JNetReflectorCore.OriginJavadocJARVersionAndUrls != null)
                {
                    var data = JNetReflectorCore.OriginJavadocJARVersionAndUrls.ElementAt(i);
                    javadocVersion = data.Version;
                    javadocUrl = data.Url;
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
                foreach (var jSubClass in jClass.Classes)
                {
                    resultingArguments.AddItem(jSubClass);
                }
            }
            JNetReflectorExtensions.SetJavaDocInfo(JNetReflectorCore.OriginJavadocUrl, JNetReflectorCore.JavadocVersion);
            JarOrModuleName = "CustomSelection";
            resultingArguments.AnalyzeItems();
        }

        public static void AddItem(this IDictionary<string, IDictionary<string, IDictionary<string, Class>>> data, Class cls)
        {
            if (cls == null || cls.JVMNestingLevels() > 1) return;
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
            JNetReflectorHelper.EnableLogging = Level >= (int)ReflectionTraceLevel.Debug;
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

            IDictionary<Class, IReadOnlyDictionary<string, string>> signaturesForClasses = null;
            if (JNetReflectorCore.PreferMethodWithSignature)
            {
                List<Class> classes = new List<Class>();
                foreach (var entry in items)
                {
                    classes.AddRange(entry.Value.Values);
                }

                signaturesForClasses = JNetReflectorHelper.ExtractJavaInfo(classes, JNetReflectorCore.CurrentClassPath, JNetReflectorCore.JavaPLocationPath);
            }

            foreach (var entry in items)
            {
                var classContent = AnalyzeClasses(jarOrModuleName, entry.Value.Values, signaturesForClasses);
                if (!string.IsNullOrEmpty(classContent))
                {
                    sb.AppendLine(classContent);
                    sb.AppendLine();
                }
            }

            var path = Path.Combine(JNetReflectorCore.DestinationCSharpClassPath, package.Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar), "AllPackageClasses.cs");
            if (JNetReflectorCore.JarsToAnalyze != null)
            {
                sb.AppendLine(AllPackageClasses.CLASSES);
                lock (_allPackagesLock)
                {
                    if (!_allPackages.ContainsKey(path))
                    {
                        var itemPackage = allPackageClasses.Replace(AllPackageClasses.VERSION, SpecialNames.VersionPlaceHolder())
                                                           .Replace(AllPackageClasses.JAR, jarOrModuleName)
                                                           .Replace(AllPackageClasses.NAMESPACE, package)
                                                           .Replace(AllPackageClasses.CLASSES, sb.ToString());

                        WriteFile(path, itemPackage);
                        _allPackages.Add(path, itemPackage);
                    }
                    else
                    {
                        var packageContent = File.ReadAllText(path);
                        var itemPackage = packageContent.Replace(AllPackageClasses.CLASSES, sb.ToString());

                        WriteFile(path, itemPackage);
                        _allPackages[path] = itemPackage;
                    }
                }
            }
            else
            {
                var itemPackage = allPackageClasses.Replace(AllPackageClasses.VERSION, SpecialNames.VersionPlaceHolder())
                                                   .Replace(AllPackageClasses.JAR, jarOrModuleName)
                                                   .Replace(AllPackageClasses.NAMESPACE, package)
                                                   .Replace(AllPackageClasses.CLASSES, sb.ToString());

                WriteFile(path, itemPackage);
            }
        }

        static string AnalyzeClasses(string jarOrModuleName, IEnumerable<Class> classDefinitions, IDictionary<Class, IReadOnlyDictionary<string, string>> signaturesForClasses)
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
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarded deprecated main class {0}", entry.GenericString);
                        return string.Empty;
                    }
                    if (JNetReflectorCore.DisableGenerics && entry.IsOrInheritFromJVMGenericClass())
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarding generic class {0}", entry.GenericString);
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

            string nestedBlock;
            string subClassStr;
            string subInterfaceStr;
            AnalyzeNestedClasses(nestedClasses, classDefinitions, out subClassStr, out nestedBlock, out subInterfaceStr);

            IReadOnlyDictionary<string, string> signatures = null;
            signaturesForClasses?.TryGetValue(jClass, out signatures);
            string classBlock;
            string singleClassStr;
            string singleInterfaceStr;
            jClass.PrepareSingleClass(signatures, classDefinitions, false, out classBlock, out singleClassStr, out singleInterfaceStr);

            singleInterfaceStr = singleInterfaceStr.Replace(AllPackageClasses.ClassStub.NESTED_INTERFACES, string.IsNullOrWhiteSpace(subInterfaceStr) ? string.Empty : subInterfaceStr);
            singleInterfaceStr = singleInterfaceStr.AddTabLevel(1);
            singleClassStr = singleClassStr.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.IsNullOrWhiteSpace(nestedBlock) ? string.Empty : nestedBlock);
            singleClassStr = singleClassStr.AddTabLevel(1);

            StringBuilder singleFileBlock;
            if (!string.IsNullOrWhiteSpace(singleInterfaceStr))
            {
                singleFileBlock = new StringBuilder(singleInterfaceStr);
                singleFileBlock.AppendLine();
                singleFileBlock.AppendLine();
                singleFileBlock.Append(singleClassStr);
            }
            else
            {
                singleFileBlock = new StringBuilder(singleClassStr);
            }

            classBlock = classBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.IsNullOrWhiteSpace(subClassStr) ? string.Empty : subClassStr);
            classBlock = classBlock.AddTabLevel(1);
            StringBuilder allClassBlock = new StringBuilder(classBlock);

            string classGenericBlock;
            string singleClassGenericStr;
            string singleInterfaceGenericStr;
            if (!JNetReflectorCore.AvoidCSharpGenericDefinition && jClass.IsJVMGenericClass() && !jClass.IsClassToAvoidInGenerics())
            {
                jClass.PrepareSingleClass(signatures, classDefinitions, true, out classGenericBlock, out singleClassGenericStr, out singleInterfaceGenericStr);
                singleClassGenericStr = singleClassGenericStr.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.Empty);
                singleInterfaceGenericStr = singleInterfaceGenericStr.Replace(AllPackageClasses.ClassStub.NESTED_INTERFACES, string.Empty);
                classGenericBlock = classGenericBlock.AddTabLevel(1);
                singleClassGenericStr = singleClassGenericStr.AddTabLevel(1);
                singleInterfaceGenericStr = singleInterfaceGenericStr.AddTabLevel(1);

                if (!string.IsNullOrWhiteSpace(singleInterfaceGenericStr))
                {
                    singleFileBlock.AppendLine();
                    singleFileBlock.AppendLine();
                    singleFileBlock.Append(singleInterfaceGenericStr);
                }

                singleFileBlock.AppendLine();
                singleFileBlock.AppendLine();
                singleFileBlock.Append(singleClassGenericStr);
                classGenericBlock = classGenericBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.Empty);
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

                var clsName = jClass.JVMClassName(null, false, false);
                var classPath = Path.Combine(JNetReflectorCore.DestinationCSharpClassPath, jClass.Namespace(JNetReflectorCore.UseCamel).Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar), $"{clsName}.cs");
                WriteFile(classPath, fileContent);
            }

            return allClassBlock.ToString();
        }

        static void AnalyzeNestedClasses(IEnumerable<Class> nestedClasses, IEnumerable<Class> classDefinitions, out string allPackagesNestedClassBlock, out string singleClassNestedBlock, out string singleInterfaceNestedBlock)
        {
            StringBuilder subClassBlock = new StringBuilder();
            StringBuilder subClassAutonoumous = new StringBuilder();
            StringBuilder subInterfaceAutonoumous = new StringBuilder();

            IDictionary<Class, IReadOnlyDictionary<string, string>> signaturesForNestedClasses = null;
            if (JNetReflectorCore.PreferMethodWithSignature)
            {
                signaturesForNestedClasses = JNetReflectorHelper.ExtractJavaInfo(nestedClasses, JNetReflectorCore.CurrentClassPath, JNetReflectorCore.JavaPLocationPath);
            }

            foreach (var entry in nestedClasses)
            {
                string innerNestedClassBlock = string.Empty;
                string innerSingleNestedClassStr = string.Empty;
                string innerSingleNestedInterfaceStr = string.Empty;
                // filter only classes with nesting level higher than current: e.g. java.awt.geom.Arc2D$Double reports in Classes the same nested classes of java.awt.geom.Arc2D
                List<Class> nesting = new List<Class>();
                foreach (var item in entry.Classes)
                {
                    if (item.JVMNestingLevels() > entry.JVMNestingLevels()) nesting.Add(item);
                }
                if (nesting.Count > 0)
                {
                    AnalyzeNestedClasses(nesting, classDefinitions.Concat(nesting), out innerNestedClassBlock, out innerSingleNestedClassStr, out innerSingleNestedInterfaceStr);
                }
                string nestedClassBlock;
                string singleNestedClassStr;
                string singleNestedInterfaceStr;
                IReadOnlyDictionary<string, string> signatures = null;
                signaturesForNestedClasses?.TryGetValue(entry, out signatures);
                entry.PrepareSingleClass(signatures, classDefinitions, false, out nestedClassBlock, out singleNestedClassStr, out singleNestedInterfaceStr);
                nestedClassBlock = nestedClassBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.IsNullOrWhiteSpace(innerNestedClassBlock) ? string.Empty : innerNestedClassBlock);
                singleNestedClassStr = singleNestedClassStr.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.IsNullOrWhiteSpace(innerSingleNestedClassStr) ? string.Empty : innerSingleNestedClassStr);
                singleNestedInterfaceStr = singleNestedInterfaceStr.Replace(AllPackageClasses.ClassStub.NESTED_INTERFACES, string.IsNullOrWhiteSpace(innerSingleNestedInterfaceStr) ? string.Empty : innerSingleNestedInterfaceStr);
                nestedClassBlock = nestedClassBlock.AddTabLevel(1);
                singleNestedClassStr = singleNestedClassStr.AddTabLevel(1);
                singleNestedInterfaceStr = singleNestedInterfaceStr.AddTabLevel(1);

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

                if (!string.IsNullOrEmpty(singleNestedInterfaceStr))
                {
                    subInterfaceAutonoumous.AppendLine(singleNestedInterfaceStr);
                    subInterfaceAutonoumous.AppendLine();
                }

                if (!JNetReflectorCore.AvoidCSharpGenericDefinition && entry.IsJVMGenericClass() && !entry.IsClassToAvoidInGenerics())
                {
                    innerNestedClassBlock = string.Empty;
                    innerSingleNestedClassStr = string.Empty;
                    innerSingleNestedInterfaceStr = string.Empty;
                    // filter only classes with nesting level higher than current: e.g. java.awt.geom.Arc2D$Double reports in Classes the same nested classes of java.awt.geom.Arc2D
                    nesting = new List<Class>();
                    foreach (var item in entry.Classes)
                    {
                        if (item.JVMNestingLevels() > entry.JVMNestingLevels()) nesting.Add(item);
                    }
                    if (nesting.Count > 0)
                    {
                        AnalyzeNestedClasses(nesting, classDefinitions.Concat(nesting), out innerNestedClassBlock, out innerSingleNestedClassStr, out innerSingleNestedInterfaceStr);
                    }
                    entry.PrepareSingleClass(signatures, classDefinitions, true, out nestedClassBlock, out singleNestedClassStr, out singleNestedInterfaceStr);
                    nestedClassBlock = nestedClassBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.IsNullOrWhiteSpace(innerNestedClassBlock) ? string.Empty : innerNestedClassBlock);
                    singleNestedClassStr = singleNestedClassStr.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.IsNullOrWhiteSpace(innerSingleNestedClassStr) ? string.Empty : innerSingleNestedClassStr);
                    singleNestedInterfaceStr = singleNestedInterfaceStr.Replace(AllPackageClasses.ClassStub.NESTED_INTERFACES, string.IsNullOrWhiteSpace(innerSingleNestedInterfaceStr) ? string.Empty : innerSingleNestedInterfaceStr);
                    nestedClassBlock = nestedClassBlock.AddTabLevel(1);
                    singleNestedClassStr = singleNestedClassStr.AddTabLevel(1);
                    singleNestedInterfaceStr = singleNestedInterfaceStr.AddTabLevel(1);

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

                    if (!string.IsNullOrEmpty(singleNestedInterfaceStr))
                    {
                        subInterfaceAutonoumous.AppendLine(singleNestedInterfaceStr);
                        subInterfaceAutonoumous.AppendLine();
                    }
                }
            }

            allPackagesNestedClassBlock = subClassBlock.ToString();
            singleClassNestedBlock = subClassAutonoumous.ToString();
            singleInterfaceNestedBlock = subInterfaceAutonoumous.ToString();
        }

        static void PrepareSingleClass(this Class jClass, IReadOnlyDictionary<string, string> signatures, IEnumerable<Class> classDefinitions, bool isGeneric, out string allPackagesClassBlock, out string singleClassStr, out string singleInterfaceStr)
        {
            if (jClass.IsJNetInternalOrManuallyDeveloped())
            {
                allPackagesClassBlock = singleClassStr = singleInterfaceStr = string.Empty;
                return;
            }

            int nestingLevel = jClass.JVMNestingLevels();
            string stubException = Template.GetTemplate(Template.AllPackageClassesStubExceptionTemplate);
            string stubListener = Template.GetTemplate(Template.AllPackageClassesStubClassListenerTemplate);
            string stubClass = Template.GetTemplate(Template.AllPackageClassesStubClassTemplate);
            string singleClass = Template.GetTemplate(Template.SingleClassTemplate);
            string singleInterface = Template.GetTemplate(Template.SingleInterfaceTemplate);
            string constructorClassBlock = string.Empty;
            string operatorClassBlock = string.Empty;
            string fieldClassBlock = string.Empty;
            string staticMethodClassBlock = string.Empty;
            string methodClassBlock = string.Empty;
            string methodClassBlockDirect = string.Empty;
            string methodInterfaceBlock = string.Empty;

            bool jClassIsDepracated = jClass.IsDeprecated();
            bool jClassIsOrFromGeneric = jClass.IsOrInheritFromJVMGenericClass();
            bool jClassIsListener = jClass.IsJVMListenerClass();
            bool bPrepareJavaListener = jClassIsListener && !jClass.IsJVMListenerClassAvoidJavaFile();
            string javaClassListenerName = string.Empty;
            string javaClassListenerPackage = string.Empty;
            if (bPrepareJavaListener)
            {
                javaClassListenerPackage = JNetReflectorCore.JavaListenerBasePackage;
                javaClassListenerPackage += string.IsNullOrEmpty(jClass.Package.Name) ? string.Empty : SpecialNames.NamespaceSeparator + jClass.Package.Name;
                javaClassListenerName = javaClassListenerPackage + SpecialNames.NamespaceSeparator + jClass.SimpleName;
            }
            bool isClassCloseable = jClass.IsCloseable();
            bool isClassAbstract = jClass.IsAbstract();
            bool isClassInterface = jClass.IsInterface();
            bool isClassStatic = jClass.IsStatic();

            if (isClassInterface || isClassAbstract) stubClass = Template.GetTemplate(Template.AllPackageClassesStubClassInterfaceOrAbstractTemplate);

            string template = jClassIsListener ? stubListener : stubClass;
            bool isMainClass = false;

            bool createInterfaceData = nestingLevel == 0 && isClassInterface;
            if (jClass.IsJVMGenericClass() && isGeneric == false) // avoid interface generation when the class is generic
            {
                createInterfaceData = false;
            }

            IList<Method> methodPrefilter = jClass.PrefilterMethods(out isMainClass, isGeneric, jClassIsListener);

            ReportTrace(ReflectionTraceLevel.Debug, "Preparing nested class {0}", jClass.GenericString);

            StringBuilder jClassDecoration = new StringBuilder(AllPackageClasses.ClassStub.DEFAULT_DECORATION);
            if (isGeneric && jClass.IsJVMGenericClass())
            {
                List<string> classGenerics = new List<string>();
                List<KeyValuePair<string, string>> classClauses = new List<KeyValuePair<string, string>>();
                jClass.GetGenerics(classGenerics, classClauses, string.Empty, isGeneric, JNetReflectorCore.UseCamel);

                if (classClauses.Count != 0)
                {
                    StringBuilder typeParamHelp = new StringBuilder();
                    foreach (var classClause in classClauses)
                    {
                        var typeParamContent = string.Empty;
                        if (!string.IsNullOrWhiteSpace(classClause.Value))
                        {
                            typeParamContent = string.Format(AllPackageClasses.ClassStub.HELP_PARAM_SEE_DECORATION, classClause.Value.ConvertToJavadoc());
                        }
                        var singleTypeParam = string.Format(AllPackageClasses.ClassStub.HELP_TYPEPARAM_DECORATION, classClause.Key, typeParamContent);
                        typeParamHelp.AppendLine(singleTypeParam);
                    }
                    var typeParamHelpStr = typeParamHelp.ToString();
                    if (!string.IsNullOrWhiteSpace(typeParamHelpStr))
                    {
                        jClassDecoration.AppendLine();
                        typeParamHelpStr = typeParamHelpStr.Substring(0, typeParamHelpStr.LastIndexOf(Environment.NewLine));
                        jClassDecoration.Append(typeParamHelpStr);
                    }
                }
            }

            if (jClassIsDepracated)
            {
                jClassDecoration.AppendLine();
                jClassDecoration.Append(AllPackageClasses.ClassStub.OBSOLETE_DECORATION);
            }

            if (jClass.IsJVMException())
            {
                allPackagesClassBlock = stubException.Replace(AllPackageClasses.ClassStub.DECORATION, jClassDecoration.ToString())
                                                     .Replace(AllPackageClasses.ClassStub.JAVACLASS, jClass.JVMFullClassName())
                                                     .Replace(AllPackageClasses.ClassStub.SIMPLECLASS, jClass.JVMClassName(null, false, false))
                                                     .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(null, isGeneric, false))
                                                     .Replace(AllPackageClasses.ClassStub.HELP, jClass.JavadocHrefUrl(JNetReflectorCore.UseCamel))
                                                     .Replace(AllPackageClasses.ClassStub.BASECLASS, jClass.JVMBaseClassName(isGeneric, false, JNetReflectorCore.UseCamel))
                                                     .Replace(AllPackageClasses.ClassStub.WHERECLAUSES, string.Empty);
            }
            else
            {
                allPackagesClassBlock = template.Replace(AllPackageClasses.ClassStub.DECORATION, jClassDecoration.ToString())
                                                .Replace(AllPackageClasses.ClassStub.LISTENER_CLASS, bPrepareJavaListener ? AllPackageClasses.ClassStub.LISTENER_CLASS_BLOCK : AllPackageClasses.ClassStub.LISTENER_CLASS_WARNING)
                                                .Replace(AllPackageClasses.ClassStub.JAVACLASS, bPrepareJavaListener ? javaClassListenerName : jClass.JVMFullClassName())
                                                .Replace(AllPackageClasses.ClassStub.JAVACLASS_DIRECT, jClass.JVMFullClassName())
                                                .Replace(AllPackageClasses.ClassStub.SIMPLECLASS, jClass.JVMClassName(new List<KeyValuePair<string, string>>(), false, false))
                                                .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(new List<KeyValuePair<string, string>>(), isGeneric, false))
                                                .Replace(AllPackageClasses.ClassStub.CLASS_DIRECT, jClass.JVMClassName(new List<KeyValuePair<string, string>>(), isGeneric, true))
                                                .Replace(AllPackageClasses.ClassStub.HELP, jClass.JavadocHrefUrl(JNetReflectorCore.UseCamel))
                                                .Replace(AllPackageClasses.ClassStub.BASECLASS, jClass.JVMBaseClassName(isGeneric, jClassIsListener, JNetReflectorCore.UseCamel) + (isMainClass ? SpecialNames.MainClassPlaceHolder : string.Empty))
                                                .Replace(AllPackageClasses.ClassStub.WHERECLAUSES, jClass.WhereClauses(isGeneric, JNetReflectorCore.UseCamel))
                                                .Replace(AllPackageClasses.ClassStub.ISABSTRACT, isClassAbstract ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISCLOSEABLE, isClassCloseable ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISINTERFACE, isClassInterface ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISSTATIC, isClassStatic ? "true" : "false");

                if (!jClassIsListener)
                {
                    constructorClassBlock = jClass.AnalyzeConstructors(classDefinitions, isGeneric, true).AddTabLevel(1);
                    operatorClassBlock = jClass.AnalyzeOperators(classDefinitions, isGeneric, true).AddTabLevel(1);
                    fieldClassBlock = jClass.AnalyzeFields(classDefinitions, isGeneric).AddTabLevel(1);
                    staticMethodClassBlock = jClass.AnalyzeMethods(signatures, classDefinitions, methodPrefilter, isGeneric, false, jClassIsListener, false, true).AddTabLevel(1);
                    methodClassBlock = jClass.AnalyzeMethods(signatures, classDefinitions, methodPrefilter, isGeneric, false, jClassIsListener, false, false).AddTabLevel(1);
                }
                else
                {
                    staticMethodClassBlock = jClass.AnalyzeMethods(signatures, classDefinitions, methodPrefilter, isGeneric, false, jClassIsListener, false, true).AddTabLevel(1);
                    methodClassBlock = jClass.AnalyzeMethods(signatures, classDefinitions, methodPrefilter, isGeneric, false, jClassIsListener, false, false).AddTabLevel(1);
                    methodClassBlockDirect = jClass.AnalyzeMethods(signatures, classDefinitions, methodPrefilter, isGeneric, false, false, true, false).AddTabLevel(1);
                }
                if (!JNetReflectorCore.DisableInterfaceMethodGeneration && createInterfaceData)
                {
                    methodInterfaceBlock = jClass.AnalyzeMethods(signatures, classDefinitions, methodPrefilter, isGeneric, true, jClassIsListener, false, false).AddTabLevel(1);
                }
            }

            string interfaceConstraint = string.Empty;
            singleInterfaceStr = string.Empty;
            if (createInterfaceData)
            {
                string baseInterface = jClass.JVMBaseInterfaceName(isGeneric, jClassIsListener, JNetReflectorCore.UseCamel);
                if (!string.IsNullOrWhiteSpace(baseInterface))
                {
                    baseInterface = " : " + baseInterface;
                }

                var help = "TO BE DEFINED FROM USER";
                if (bPrepareJavaListener)
                {
                    help = javaClassListenerName + " implementing " + jClass.JavadocHrefUrl(JNetReflectorCore.UseCamel);
                }

                singleInterfaceStr = singleInterface.Replace(AllPackageClasses.ClassStub.HELP, help)
                                                    .Replace(AllPackageClasses.ClassStub.INTERFACE, jClass.JVMInterfaceName(new List<KeyValuePair<string, string>>(), isGeneric, false))
                                                    .Replace(AllPackageClasses.ClassStub.BASEINTERFACE, baseInterface)
                                                    .Replace(AllPackageClasses.ClassStub.METHODS, methodInterfaceBlock);

                interfaceConstraint = jClass.JVMInterfaceName(new List<KeyValuePair<string, string>>(), isGeneric, true);
            }

            string extraInterfaces = string.Empty;
            if (JNetReflectorCore.CreateInterfaceInheritance)
            {
                if (!(jClass.IsJVMGenericClass() && isGeneric == false))
                {
                    StringBuilder sbInterfaces = new StringBuilder();
                    foreach (var item in jClass.JVMGenericInterfaces(isGeneric, JNetReflectorCore.UseCamel))
                    {
                        sbInterfaces.AppendFormat("{0}, ", item);
                    }

                    extraInterfaces = sbInterfaces.ToString();
                    if (!string.IsNullOrWhiteSpace(extraInterfaces))
                    {
                        extraInterfaces = extraInterfaces.Substring(0, extraInterfaces.LastIndexOf(", "));
                    }
                }
            }

            interfaceConstraint = string.IsNullOrWhiteSpace(interfaceConstraint) ? extraInterfaces : interfaceConstraint + ", " + extraInterfaces;

            if (interfaceConstraint.EndsWith(", "))
            {
                interfaceConstraint = interfaceConstraint.Substring(0, interfaceConstraint.LastIndexOf(", "));
            }

            singleClassStr = singleClass.Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(new List<KeyValuePair<string, string>>(), isGeneric, false))
                                        .Replace(AllPackageClasses.ClassStub.INTERFACE_CONSTRAINT, !string.IsNullOrWhiteSpace(interfaceConstraint) ? " : " + interfaceConstraint : string.Empty)
                                        .Replace(AllPackageClasses.ClassStub.CONSTRUCTORS, constructorClassBlock)
                                        .Replace(AllPackageClasses.ClassStub.OPERATORS, operatorClassBlock)
                                        .Replace(AllPackageClasses.ClassStub.FIELDS, fieldClassBlock)
                                        .Replace(AllPackageClasses.ClassStub.STATICMETHODS, staticMethodClassBlock)
                                        .Replace(AllPackageClasses.ClassStub.METHODS, methodClassBlock);

            if (jClassIsListener)
            {
                string singleClassStrDirect = singleClass.Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMClassName(new List<KeyValuePair<string, string>>(), isGeneric, true))
                                                         .Replace(AllPackageClasses.ClassStub.INTERFACE_CONSTRAINT, !string.IsNullOrWhiteSpace(interfaceConstraint) ? " : " + interfaceConstraint : string.Empty)
                                                         .Replace(AllPackageClasses.ClassStub.CONSTRUCTORS, string.Empty)
                                                         .Replace(AllPackageClasses.ClassStub.OPERATORS, string.Empty)
                                                         .Replace(AllPackageClasses.ClassStub.FIELDS, string.Empty)
                                                         .Replace(AllPackageClasses.ClassStub.STATICMETHODS, string.Empty)
                                                         .Replace(AllPackageClasses.ClassStub.METHODS, methodClassBlockDirect)
                                                         .Replace(AllPackageClasses.ClassStub.NESTED_CLASSES, string.Empty); // remove from direct the nested classes since they will be managed from listener

                singleClassStr += Environment.NewLine + Environment.NewLine;
                singleClassStr += singleClassStrDirect;
            }

            if (bPrepareJavaListener)
            {
                var clsName = jClass.SimpleName;
                var fullInterfaces = jClass.Name.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);

                var javaClassMethodBlock = jClass.AnalyzeJavaMethods(fullInterfaces, isGeneric).AddTabLevel(1);
                string singleJavaListenerTemplate = Template.GetTemplate(Template.SingleListenerJavaFileTemplate);

                if (!jClass.IsInterface()) // it is a class, we have to implement the interfaces
                {
                    StringBuilder sbInterfaces = new StringBuilder();
                    foreach (var item in jClass.Interfaces)
                    {
                        sbInterfaces.AppendFormat("{0}, ", item.Name.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator));
                    }

                    fullInterfaces = sbInterfaces.ToString();
                    if (!string.IsNullOrWhiteSpace(fullInterfaces))
                    {
                        fullInterfaces = fullInterfaces.Substring(0, fullInterfaces.LastIndexOf(", "));
                    }
                }

                var singleJavaListenerStr = singleJavaListenerTemplate.Replace(AllPackageClasses.VERSION, SpecialNames.VersionPlaceHolder())
                                                                      .Replace(AllPackageClasses.PACKAGE, javaClassListenerPackage)
                                                                      .Replace(AllPackageClasses.ClassStub.SIMPLECLASS, clsName)
                                                                      .Replace(AllPackageClasses.ClassStub.JAVACLASS, fullInterfaces)
                                                                      .Replace(AllPackageClasses.ClassStub.CLASS, jClass.JVMFullClassName())
                                                                      .Replace(AllPackageClasses.ClassStub.LISTENER_METHODS, javaClassMethodBlock);


                var classPath = Path.Combine(JNetReflectorCore.DestinationJavaListenerPath, javaClassListenerPackage.Replace(SpecialNames.NamespaceSeparator, Path.DirectorySeparatorChar), $"{clsName}.java");
                WriteFile(classPath, singleJavaListenerStr);
            }
        }

        static string AnalyzeConstructors(this Class classDefinition, IEnumerable<Class> classDefinitions, bool isGeneric, bool isNested)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Constructors of {0} *******************", classDefinition.GenericString);

            if (!JNetReflectorCore.DisableGenericsInNonGenericClasses && !JNetReflectorCore.DisableGenerics && !classDefinition.IsJVMGenericClass())
            {
                isGeneric = true; // force generic to true to build generic constructors on classes that does not have generics
            }

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
            classDefinition.GetGenerics(classGenerics, classClauses, string.Empty, isGeneric, JNetReflectorCore.UseCamel);

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
                    if (parameter.MustBeAvoided(isGeneric)) { bypass = true; break; }
                    if (parameter.Type(genArgumentsLocal, genClauseLocal, isGeneric ? null : string.Empty, isGeneric, JNetReflectorCore.UseCamel) == "object[]") { bypass = true; break; }
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
                    var typeStr = item.Type(paramGenArguments, paramGenClause, isGeneric ? null : item.Name().Camel(), isGeneric, JNetReflectorCore.UseCamel);
                    var typeStrForDoc = typeStr.Contains('<') ? typeStr.Substring(0, typeStr.IndexOf('<')) : typeStr;
                    if (isGeneric && paramGenArguments.Count != 0 && classGenerics != null)
                    {
                        bool usableGenStrings = true;
                        foreach (var genString in paramGenArguments)
                        {
                            if (!classGenerics.Contains(genString))
                            {
                                usableGenStrings = false; // avoid generics in parameter type
                                if (typeStr == genString)
                                {
                                    typeStrForDoc = SpecialNames.NetObject;
                                }
                                if (typeStr == genString + SpecialNames.ArrayTypeTrailer)
                                {
                                    typeStrForDoc = SpecialNames.NetObject + SpecialNames.ArrayTypeTrailer;
                                }
                            }
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

                    var helpFormat = AllPackageClasses.ClassStub.ConstructorStub.HELP_PARAM_SEE_DECORATION;
                    if (paramGenArguments.Contains(typeStrForDoc.ConvertToJavadoc()) || classGenerics.Contains(typeStrForDoc.ConvertToJavadoc()))
                    {
                        helpFormat = AllPackageClasses.ClassStub.ConstructorStub.HELP_PARAM_TYPEPARAMREF_DECORATION;
                    }
                    var content = string.Format(helpFormat, typeStrForDoc.ConvertToJavadoc());
                    constructorHelpBuilder.AppendLine(string.Format(AllPackageClasses.ClassStub.ConstructorStub.HELP_PARAM_DECORATION, item.Name(), content));
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

        static string AnalyzeOperators(this Class classDefinition, IEnumerable<Class> classDefinitions, bool isGeneric, bool isNested)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Operators of {0} *******************", classDefinition.GenericString);

            StringBuilder subOperatorBlock = new StringBuilder();

            if (classDefinition.NeedsOperators(isGeneric))
            {
                List<string> classGenerics = new List<string>();
                List<KeyValuePair<string, string>> classClauses = new List<KeyValuePair<string, string>>();
                classDefinition.GetGenerics(classGenerics, classClauses, string.Empty, isGeneric, JNetReflectorCore.UseCamel);

                IEnumerable<Class> filteredInterfaces = classDefinition.JVMInterfaces(isGeneric);
                foreach (var implementedInterface in filteredInterfaces)
                {
                    if (implementedInterface.IsIterable() || implementedInterface.IsIterator())
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Discarded iterable/iterator {0}", implementedInterface.GenericString);
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
                    implementedInterface.GetGenerics(implClassGenerics, implClassClauses, string.Empty, isGeneric, JNetReflectorCore.UseCamel);

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

        static IList<Method> PrefilterMethods(this Class classDefinition, out bool isMainClass, bool isGeneric, bool isListener)
        {
            isMainClass = false;
            ReportTrace(ReflectionTraceLevel.Info, "******************* Prefilter Methods of {0} *******************", classDefinition.GenericString);

            List<Method> prefilteredMethods = new List<Method>();
            foreach (var method in isListener ? classDefinition.Methods : classDefinition.DeclaredMethods)
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
                }

                if (paramCount == 0 && !method.IsVoid() &&
                    (methodNameOrigin == "toString" || methodNameOrigin == "hashCode" || methodNameOrigin == "getClass")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 0 && method.IsVoid() &&
                    (methodNameOrigin == "notify" || methodNameOrigin == "notifyAll" || methodNameOrigin == "wait")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 1 && method.IsVoid() &&
                    (methodNameOrigin == "wait")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 1 && !method.IsVoid() &&
                    (methodNameOrigin == "equals")
                   ) continue; // special methods managed from JCOBridge

                if (paramCount == 2 && method.IsVoid() &&
                    (methodNameOrigin == "wait")
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
                if (method.MustBeAvoided(isGeneric))
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded MustBeAvoided method for ReturnType {0}", genString);
                    continue;
                }

                prefilteredMethods.Add(method);
            }

            return prefilteredMethods;
        }

        static string AnalyzeMethods(this Class classDefinition, IReadOnlyDictionary<string, string> methodsToSignature, IEnumerable<Class> classDefinitions, IList<Method> prefilteredMethods, bool isGeneric, bool forInterface, bool forListener, bool isDirectListener, bool staticMethods)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Methods of {0} with static {1} *******************", classDefinition.GenericString, staticMethods);

            if (!JNetReflectorCore.DisableGenericsInNonGenericClasses && !JNetReflectorCore.DisableGenerics && !classDefinition.IsJVMGenericClass())
            {
                isGeneric = true; // force generic to true to build generic methods on classes that does not have generics
            }

            StringBuilder subClassBlock = new StringBuilder();
            StringBuilder subListenerHandlerBlock = new StringBuilder();
            SortedDictionary<string, Method> methods = new SortedDictionary<string, Method>();
            SortedDictionary<string, IList<Method>> properties = new SortedDictionary<string, IList<Method>>();

            foreach (var method in prefilteredMethods.ToArray())
            {
                if (staticMethods ^ method.IsStatic()) continue;

                int nestingLevel = classDefinition.JVMNestingLevels();
                var genString = method.GenericString;
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;

                if (!forListener && method.IsProperty()) // avoid properties in Listeners
                {
                    var propertyName = method.PropertyName(classDefinitions, false, JNetReflectorCore.UseCamel);
                    if (propertyName.IsReservedName()
                        || propertyName.CollapseWithClassOrNestedClass(nestingLevel, classDefinitions)
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
            classDefinition.GetGenerics(classGenerics, classClauses, string.Empty, isGeneric, JNetReflectorCore.UseCamel);

            foreach (var prop in properties.ToArray())
            {
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
                else if (propToCheck.Count == 2) // check if there is one get and one set otherwise convert into methods
                {
                    List<Method> getMethods = new List<Method>();
                    List<Method> setMethods = new List<Method>();
                    // test properties with duplicated name
                    foreach (var item in propToCheck)
                    {
                        if (item.IsGetProperty()) getMethods.Add(item);
                        if (item.IsSetProperty()) setMethods.Add(item);
                    }

                    if (getMethods.Count == 1 && setMethods.Count == 1)
                    {
                        ReportTrace(ReflectionTraceLevel.Debug, "Processing can continue, we are good");
                    }
                    else
                    {
                        foreach (var item in getMethods)
                        {
                            propToCheck.Remove(item);
                            methods.Add(item.GenericString, item);
                            ReportTrace(ReflectionTraceLevel.Debug, "Get Property moved to methods {0}", item.GenericString);
                        }

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
                    continue;
                }

                string methodName = prop.Key;
                string modifier = string.Empty;
                string returnType = string.Empty;
                Method getMethod = null;
                Method setMethod = null;
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
                    string getSignature = methodsToSignature?.SignatureFromGenericString(getMethod.GenericString.RemoveThrowsAndCleanupSignature());
                    string execStub = getMethod.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTE : AllPackageClasses.ClassStub.MethodStub.INSTANCE_EXECUTE;
                    if (!string.IsNullOrWhiteSpace(getSignature))
                    {
                        execStub += AllPackageClasses.ClassStub.MethodStub.SIGNATURE_EXECUTE_TRAILER;
                    }
                    if (isArrayReturnType) execStub += "Array";
                    if (JNetReflectorCore.ReflectDeprecated) isGetDeprecated = getMethod.IsDeprecated();
                    if (getMethod.IsReturnTypeAnException())
                    {
                        var execFormat = getMethod.IsStatic() ? AllPackageClasses.ClassStub.PropertyStub.STATIC_GET_EXECUTION_FORMAT_EXCEPTION : AllPackageClasses.ClassStub.PropertyStub.GET_EXECUTION_FORMAT_EXCEPTION;
                        executionStub.AppendFormat(execFormat, execStub, returnType, getMethod.Name, string.IsNullOrWhiteSpace(getSignature) ? string.Empty : $", \"{getSignature}\"");
                    }
                    else
                    {
                        var execFormat = getMethod.IsStatic() ? AllPackageClasses.ClassStub.PropertyStub.STATIC_GET_EXECUTION_FORMAT : AllPackageClasses.ClassStub.PropertyStub.GET_EXECUTION_FORMAT;
                        executionStub.AppendFormat(execFormat, execStub,
                                                               getMethod.IsVoid() || getMethod.IsObjectReturnType(isGeneric, JNetReflectorCore.UseCamel) ? string.Empty : $"<{returnType}>",
                                                               getMethod.Name,
                                                               string.IsNullOrWhiteSpace(getSignature) ? string.Empty : $", \"{getSignature}\"");
                    }
                }

                if (setMethod != null)
                {
                    string setSignature = methodsToSignature?.SignatureFromGenericString(setMethod.GenericString.RemoveThrowsAndCleanupSignature());
                    if (JNetReflectorCore.ReflectDeprecated) isSetDeprecated = setMethod.IsDeprecated();
                    string setExecStub = setMethod.IsStatic() ? AllPackageClasses.ClassStub.PropertyStub.STATIC_SET_EXECUTION_FORMAT : AllPackageClasses.ClassStub.PropertyStub.SET_EXECUTION_FORMAT;
                    var methodToCall = setMethod.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTE : AllPackageClasses.ClassStub.MethodStub.INSTANCE_EXECUTE;
                    if (!string.IsNullOrWhiteSpace(setSignature))
                    {
                        methodToCall += AllPackageClasses.ClassStub.MethodStub.SIGNATURE_EXECUTE_TRAILER;
                    }
                    if (returnType.EndsWith(SpecialNames.ArrayTypeTrailer))
                    {
                        setExecStub = setMethod.IsStatic() ? AllPackageClasses.ClassStub.PropertyStub.STATIC_SET_ARRAY_EXECUTION_FORMAT : AllPackageClasses.ClassStub.PropertyStub.SET_ARRAY_EXECUTION_FORMAT;
                    }
                    executionStub.AppendFormat(setExecStub, methodToCall,
                                                            setMethod.Name,
                                                            string.IsNullOrWhiteSpace(setSignature) ? string.Empty : $", \"{setSignature}\"");
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing properties of {0}", prop.Key);

                StringBuilder jPropDecoration = new StringBuilder(AllPackageClasses.ClassStub.PropertyStub.DEFAULT_DECORATION);
                if (isGetDeprecated || isSetDeprecated)
                {
                    jPropDecoration.AppendLine();
                    jPropDecoration.Append(AllPackageClasses.ClassStub.MethodStub.OBSOLETE_DECORATION);
                }

                string singleProperty;
                if (forInterface)
                {
                    var execInterface = (getMethod != null ? AllPackageClasses.ClassStub.PropertyStub.GET_INTERFACE_FORMAT : string.Empty) + (setMethod != null ? AllPackageClasses.ClassStub.PropertyStub.SET_INTERFACE_FORMAT : string.Empty);

                    var template = Template.GetTemplate(Template.SingleInterfacePropertyTemplate);
                    singleProperty = template.Replace(AllPackageClasses.ClassStub.PropertyStub.DECORATION, jPropDecoration.ToString())
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.TYPE, isArrayReturnType ? returnType + SpecialNames.ArrayTypeTrailer : returnType)
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.NAME, methodName)
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.EXECUTION, execInterface)
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.GET_HELP, getMethod != null ? getMethod.JavadocHrefUrl(JNetReflectorCore.UseCamel) : string.Empty)
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.SET_HELP, setMethod != null ? setMethod.JavadocHrefUrl(JNetReflectorCore.UseCamel) : string.Empty);
                }
                else
                {
                    var template = Template.GetTemplate(Template.SinglePropertyTemplate);
                    singleProperty = template.Replace(AllPackageClasses.ClassStub.PropertyStub.DECORATION, jPropDecoration.ToString())
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.MODIFIER, modifier)
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.TYPE, isArrayReturnType ? returnType + SpecialNames.ArrayTypeTrailer : returnType)
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.NAME, methodName)
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.EXECUTION, executionStub.ToString())
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.GET_HELP, getMethod != null ? getMethod.JavadocHrefUrl(JNetReflectorCore.UseCamel) : string.Empty)
                                             .Replace(AllPackageClasses.ClassStub.PropertyStub.SET_HELP, setMethod != null ? setMethod.JavadocHrefUrl(JNetReflectorCore.UseCamel) : string.Empty);
                }

                subClassBlock.AppendLine(singleProperty);
            }

            Dictionary<string, int> methodCounter = new Dictionary<string, int>();

            foreach (var item in methods)
            {
                var method = item.Value;
                var genString = method.GenericString;
                string signature = methodsToSignature?.SignatureFromGenericString(genString);
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;
                var eventHandlerName = methodNameOrigin;
                if (!methodCounter.TryGetValue(methodNameOrigin, out int methodIndexer))
                {
                    methodCounter.Add(methodNameOrigin, 0);
                }
                else
                {
                    methodCounter[methodNameOrigin] = ++methodIndexer;
                    eventHandlerName = methodIndexer == 0 ? eventHandlerName : (methodIndexer == 1 ? eventHandlerName + paramCount : eventHandlerName + paramCount + $"_{methodIndexer}");
                }

                List<string> genericArguments = new List<string>();
                List<KeyValuePair<string, string>> genericClauses = new List<KeyValuePair<string, string>>();
                List<string> retGenArguments = new List<string>();
                List<KeyValuePair<string, string>> retGenClause = new List<KeyValuePair<string, string>>();
                string modifier = method.IsStatic() ? " static" : string.Empty;
                string returnType = method.ReturnType(retGenArguments, retGenClause, "Return", isGeneric, JNetReflectorCore.UseCamel);
                genericArguments.AddRange(retGenArguments);
                genericClauses.AddRange(retGenClause);
                string methodName = method.MethodName(classDefinitions, false, JNetReflectorCore.UseCamel);

                if (methodName == "Clone" && returnType == SpecialNames.NetObject) continue;
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
                    if (parameter.MustBeAvoided(isGeneric)) { bypass = true; break; }
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
                StringBuilder listenerParamsBuilder = new StringBuilder();
                StringBuilder listenerExecutionParamsBuilder = new StringBuilder();
                string firstListenerParameter = null;

                for (int i = 0; i < parameters.Count; i++)
                {
                    var parameter = parameters[i];

                    List<string> paramGenArguments = new List<string>();
                    List<KeyValuePair<string, string>> paramGenClauses = new List<KeyValuePair<string, string>>();

                    var typeStr = parameter.Type(paramGenArguments, paramGenClauses, parameter.Name().Camel(), isGeneric, JNetReflectorCore.UseCamel);
                    var typeStrForDoc = typeStr.Contains('<') ? typeStr.Substring(0, typeStr.IndexOf('<')) : typeStr;
                    if (isGeneric && paramGenArguments.Count != 0 && classGenerics != null)
                    {
                        bool usableGenStrings = true;
                        if (typeStr.IsNetNativeType()) usableGenStrings = false;
                        else if (parameter.IsVarArgs && typeStr.EndsWith(SpecialNames.ArrayTypeTrailer))
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
                            genericClauses.AddRange(paramGenClauses);
                        }
                    }

                    if (parameter.IsJVMException())
                    {
                        // https://github.com/masesgroup/JNet/issues/137#issuecomment-1585716272: replace only the type used in signature and leaves anything else like it was from Java
                        typeStr = SpecialNames.JVMBridgeException;
                    }

                    if (i == 0)
                    {
                        if (!parameter.IsJVMException())
                        {
                            firstListenerParameter = typeStr;
                        }
                    }

                    var helpFormat = AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_SEE_DECORATION;
                    if (paramGenArguments.Contains(typeStrForDoc.ConvertToJavadoc()) || classGenerics.Contains(typeStrForDoc.ConvertToJavadoc()))
                    {
                        helpFormat = AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_TYPEPARAMREF_DECORATION;
                    }
                    var content = string.Format(helpFormat, typeStrForDoc.ConvertToJavadoc());
                    methodHelpBuilder.AppendLine(string.Format(AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_DECORATION, parameter.Name(), content));
                    if (parameter.IsVarArgs)
                    {
                        if (!typeStr.EndsWith(SpecialNames.ArrayTypeTrailer)) typeStr += SpecialNames.ArrayTypeTrailer;
                        methodParamsBuilder.AppendFormat($"params {typeStr} {varArg.Name()}, ");
                    }
                    else
                    {
                        methodParamsBuilder.AppendFormat($"{typeStr} {parameter.Name()}, ");
                        methodExecutionParamsBuilder.AppendFormat($"{parameter.Name()}, ");
                        listenerParamsBuilder.AppendFormat($"{typeStr}, ");
                        if (i == 0)
                        {
                            if (!parameter.IsJVMException())
                            {
                                listenerExecutionParamsBuilder.AppendFormat("data.EventData.TypedEventData, ");
                            }
                            else
                            {
                                listenerExecutionParamsBuilder.AppendFormat("JVMBridgeException.New(data.EventData.EventData as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject), ");
                            }
                        }
                        else
                        {
                            if (parameter.IsJVMException())
                            {
                                listenerExecutionParamsBuilder.AppendFormat($"JVMBridgeException.New(data.EventData.ExtraData.Get({i - 1}) as MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject), ");
                            }
                            else
                            {
                                listenerExecutionParamsBuilder.AppendFormat($"data.EventData.GetAt<{typeStr}>({i - 1}), ");
                            }
                        }
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
                string listenerParamsString = listenerParamsBuilder.ToString();
                string listenerExecutionParamsString = listenerExecutionParamsBuilder.ToString();
                if (paramCount != 0)
                {
                    if (paramsString.EndsWith(", ")) paramsString = paramsString.Substring(0, paramsString.Length - 2); // remove last occurrence of ", "
                    if (executionParamsString.EndsWith(", ")) executionParamsString = executionParamsString.Substring(0, executionParamsString.Length - 2); // remove last occurrence of ", "
                    if (listenerParamsString.EndsWith(", ")) listenerParamsString = listenerParamsString.Substring(0, listenerParamsString.Length - 2); // remove last occurrence of ", "
                    if (listenerExecutionParamsString.EndsWith(", ")) listenerExecutionParamsString = listenerExecutionParamsString.Substring(0, listenerExecutionParamsString.Length - 2); // remove last occurrence of ", "
                }

                bool isArrayReturnType = false;

                string execStub = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTE : AllPackageClasses.ClassStub.MethodStub.INSTANCE_EXECUTE;
                if (!string.IsNullOrWhiteSpace(signature))
                {
                    execStub += AllPackageClasses.ClassStub.MethodStub.SIGNATURE_EXECUTE_TRAILER;
                }
                if (returnType.EndsWith(SpecialNames.ArrayTypeTrailer))
                {
                    returnType = returnType.Substring(0, returnType.IndexOf(SpecialNames.ArrayTypeTrailer));
                    execStub += "Array";
                    isArrayReturnType = true;
                }

                if (paramCount == 1 && !parameters[0].IsVarArgs && parameters[0].Type(null, null, parameters[0].Name().Camel(), isGeneric, JNetReflectorCore.UseCamel).EndsWith(SpecialNames.ArrayTypeTrailer))
                {
                    executionParamsString = string.Format(AllPackageClasses.ClassStub.MethodStub.SINGLE_ARRAY_EXECUTION_FORMAT, parameters[0].Name);
                }

                bool isListenerReturnType = method.IsReturnTypeAListener();
                bool isVoidMethod = method.IsVoid();
                bool isReturnTypeException = method.IsReturnTypeAnException();
                string executionStub = string.Empty;
                string executionStubDirect = string.Empty;
                if (forListener && method.IsDefault) methodNameOrigin += SpecialNames.DefaultMethodSuffix;

                string directNewClass = returnType;
                var indexOfGenerics = returnType.IndexOf('<');
                if (indexOfGenerics > 0)
                {
                    directNewClass = returnType.Insert(indexOfGenerics, SpecialNames.DirectMethodSuffix);
                }
                else
                {
                    directNewClass = returnType + SpecialNames.DirectMethodSuffix;
                }

                if (isReturnTypeException)
                {
                    var execFormat = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTION_FORMAT_EXCEPTION : AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT_EXCEPTION;
                    executionStub = string.Format(execFormat,
                                                  execStub,
                                                  methodNameOrigin,
                                                  string.IsNullOrWhiteSpace(signature) ? string.Empty : $", \"{signature}\"",
                                                  executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString,
                                                  returnType);
                }
                else
                {
                    string executeGenType = $"<{returnType}>";
                    string executeGenTypeDirect = $"<{directNewClass}, {returnType}>";
                    if (isListenerReturnType && isDirectListener == true)
                    {
                        executeGenType = executeGenTypeDirect;
                    }

                    var execFormat = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTION_FORMAT : AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT;
                    executionStub = string.Format(execFormat,
                                                  method.IsVoid() ? string.Empty : "return ",
                                                  execStub,
                                                  isVoidMethod || method.IsObjectReturnType(isGeneric, JNetReflectorCore.UseCamel) ? string.Empty : executeGenType,
                                                  methodNameOrigin,
                                                  string.IsNullOrWhiteSpace(signature) ? string.Empty : $", \"{signature}\"",
                                                  executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString);
                    if (isListenerReturnType && isDirectListener == false)
                    {
                        executionStubDirect = string.Format(execFormat,
                                                            method.IsVoid() ? string.Empty : "return ",
                                                            execStub,
                                                            isVoidMethod || method.IsObjectReturnType(isGeneric, JNetReflectorCore.UseCamel) ? string.Empty : executeGenTypeDirect,
                                                            methodNameOrigin,
                                                            string.IsNullOrWhiteSpace(signature) ? string.Empty : $", \"{signature}\"",
                                                            executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString);
                    }
                }

                if (hasVarArg)
                {
                    string executionStubWithVarArg = string.Empty;
                    string executionStubWithVarArgDirect = string.Empty;
                    if (isReturnTypeException)
                    {
                        var execFormat = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTION_FORMAT_EXCEPTION : AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT_EXCEPTION;
                        executionStubWithVarArg = string.Format(execFormat,
                                                                execStub,
                                                                methodNameOrigin,
                                                                string.IsNullOrWhiteSpace(signature) ? string.Empty : $", \"{signature}\"",
                                                                (executionParamsString.Length == 0 ? string.Empty : ", ")
                                                                + executionParamsString + ", " + varArg.Name(),
                                                                returnType);
                    }
                    else
                    {
                        string executeGenType = $"<{returnType}>";
                        string executeGenTypeDirect = $"<{directNewClass}, {returnType}>";
                        if (isListenerReturnType && isDirectListener == true)
                        {
                            executeGenType = executeGenTypeDirect;
                        }

                        var execFormat = method.IsStatic() ? AllPackageClasses.ClassStub.MethodStub.STATIC_EXECUTION_FORMAT : AllPackageClasses.ClassStub.MethodStub.EXECUTION_FORMAT;
                        executionStubWithVarArg = string.Format(execFormat,
                                                                isVoidMethod ? string.Empty : "return ",
                                                                execStub,
                                                                isVoidMethod || method.IsObjectReturnType(isGeneric, JNetReflectorCore.UseCamel) ? string.Empty : executeGenType,
                                                                methodNameOrigin,
                                                                string.IsNullOrWhiteSpace(signature) ? string.Empty : $", \"{signature}\"",
                                                                (executionParamsString.Length == 0 ? string.Empty : ", ")
                                                                + executionParamsString + ", " + varArg.Name());

                        if (isListenerReturnType && isDirectListener == false)
                        {
                            executionStubWithVarArgDirect = string.Format(execFormat,
                                                                          isVoidMethod ? string.Empty : "return ",
                                                                          execStub,
                                                                          isVoidMethod || method.IsObjectReturnType(isGeneric, JNetReflectorCore.UseCamel) ? string.Empty : executeGenTypeDirect,
                                                                          methodNameOrigin,
                                                                          string.IsNullOrWhiteSpace(signature) ? string.Empty : $", \"{signature}\"",
                                                                          (executionParamsString.Length == 0 ? string.Empty : ", ")
                                                                          + executionParamsString + ", " + varArg.Name());
                        }
                    }
                    executionStub = $"if ({varArg.Name()}.Length == 0) {executionStub} else {executionStubWithVarArg}";
                    executionStubDirect = $"if ({varArg.Name()}.Length == 0) {executionStubDirect} else {executionStubWithVarArgDirect}";
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing method {0}", genString);

                if (genericClauses.Count != 0)
                {
                    StringBuilder typeParamHelp = new StringBuilder();
                    foreach (var genericClause in genericClauses)
                    {
                        if (!classGenerics.Contains(genericClause.Key))
                        {
                            var typeParamContent = string.Empty;
                            if (!string.IsNullOrWhiteSpace(genericClause.Value))
                            {
                                var helpFormat = AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_SEE_DECORATION;
                                if (genericArguments.Contains(genericClause.Value.ConvertToJavadoc()) || classGenerics.Contains(genericClause.Value.ConvertToJavadoc()))
                                {
                                    helpFormat = AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_TYPEPARAMREF_DECORATION;
                                }
                                typeParamContent = string.Format(helpFormat, genericClause.Value.ConvertToJavadoc());
                            }
                            var singleTypeParam = string.Format(AllPackageClasses.ClassStub.MethodStub.HELP_TYPEPARAM_DECORATION, genericClause.Key, typeParamContent);
                            typeParamHelp.AppendLine(singleTypeParam);
                        }
                    }
                    if (!methodHelpBuilder.ToString().EndsWith(Environment.NewLine)) methodHelpBuilder.AppendLine();
                    methodHelpBuilder.Append(typeParamHelp.ToString());
                }

                if (!isVoidMethod)
                {
                    var returnTypeForDocs = returnType.Contains('<') ? returnType.Substring(0, returnType.IndexOf('<')) : returnType;
                    var helpFormat = AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_SEE_DECORATION;
                    if (genericArguments.Contains(returnTypeForDocs.ConvertToJavadoc()) || classGenerics.Contains(returnTypeForDocs.ConvertToJavadoc()))
                    {
                        helpFormat = AllPackageClasses.ClassStub.MethodStub.HELP_PARAM_TYPEPARAMREF_DECORATION;
                    }
                    var returnContent = string.Format(helpFormat, returnTypeForDocs.ConvertToJavadoc());
                    string strReturn = string.Format(AllPackageClasses.ClassStub.MethodStub.HELP_RETURN_DECORATION, returnContent);
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
                if (!string.IsNullOrWhiteSpace(paramHelp) && paramHelp.Contains('/'))
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(paramHelp);
                }
                if (JNetReflectorCore.ReflectDeprecated && method.IsDeprecated())
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(AllPackageClasses.ClassStub.MethodStub.OBSOLETE_DECORATION);
                }

                string jDecorationTemporary = jDecoration.ToString();

                returnType = isArrayReturnType ? returnType + SpecialNames.ArrayTypeTrailer : returnType;

                string CLRListenerEventArgsType = string.Empty;
                string executionPropertyParams = string.Empty;
                string listenerHandlerType = string.Empty;
                string singleMethod;
                string template;
                string baseHandlerName = methodIndexer == 0 ? methodName : (methodIndexer == 1 ? methodName + paramCount : methodName + paramCount + $"_{methodIndexer}");
                if (forListener)
                {
                    if (method.IsDefault)
                    {
                        jDecoration.AppendLine();
                        jDecoration.Append(AllPackageClasses.ClassStub.MethodStub.HELP_REMARK_DEFAULT_METHOD);

                        string methodNameDefault = methodName + SpecialNames.DefaultMethodSuffix;
                        template = Template.GetTemplate(Template.SingleMethodTemplate);
                        singleMethod = template.Replace(AllPackageClasses.ClassStub.MethodStub.DECORATION, jDecoration.ToString())
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_HANDLER_EXECUTION, listenerHandlerType)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_HANDLER_NAME, baseHandlerName)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.MODIFIER, modifier)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.RETURNTYPE, returnType)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.NAME, methodNameDefault)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.PARAMETERS, paramsString)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.WHERECLAUSES, genericClauses.ConvertClauses(isGeneric))
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.EXECUTION, executionStub)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_EXECUTION_TYPE, executionPropertyParams)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_FIRST_PARAMETER, CLRListenerEventArgsType)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_EXECUTION, listenerExecutionParamsString)
                                               .Replace(AllPackageClasses.ClassStub.MethodStub.HELP, method.JavadocHrefUrl(JNetReflectorCore.UseCamel));

                        jDecoration = new StringBuilder(jDecorationTemporary);
                        if (!forInterface)
                        {
                            subClassBlock.AppendLine(singleMethod);
                            jDecoration.AppendLine();
                            jDecoration.AppendFormat(AllPackageClasses.ClassStub.MethodStub.HELP_REMARK_HANDLER_WITH_DEFAULT, methodNameDefault);
                        }
                        executionStub = isVoidMethod ? $"{methodNameDefault}({executionParamsString});" : $"return {methodNameDefault}({executionParamsString});";
                    }
                    else
                    {
                        executionStub = isVoidMethod ? string.Empty : "return default;";
                    }
                    if (firstListenerParameter != null)
                    {
                        CLRListenerEventArgsType = $"<{firstListenerParameter}>";
                    }
                    if (!isVoidMethod)
                    {
                        listenerParamsString = paramCount == 0 ? $"{returnType}" : listenerParamsString + $", {returnType}";
                        executionPropertyParams = $"System.Func<{listenerParamsString}>";
                        listenerHandlerType = AllPackageClasses.ClassStub.MethodStub.FUNC_LISTENER_EXECUTION_HANDLER_FORMAT;
                    }
                    else
                    {
                        executionPropertyParams = paramCount == 0 ? "System.Action" : $"System.Action<{listenerParamsString}>";
                        listenerHandlerType = AllPackageClasses.ClassStub.MethodStub.ACTION_LISTENER_EXECUTION_HANDLER_FORMAT;
                    }

                    string singleListenerHandler = string.Format(AllPackageClasses.ClassStub.MethodStub.SINGLE_LISTENER_HANDLER_FORMAT, eventHandlerName);
                    singleListenerHandler = singleListenerHandler.Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_FIRST_PARAMETER, CLRListenerEventArgsType)
                                                                 .Replace(AllPackageClasses.ClassStub.MethodStub.NAME, methodName)
                                                                 .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_HANDLER_NAME, baseHandlerName);

                    subListenerHandlerBlock.AppendLine(singleListenerHandler);
                }

                if (forInterface)
                {
                    template = Template.GetTemplate(Template.SingleInterfaceMethodTemplate);
                }
                else if (forListener)
                {
                    template = Template.GetTemplate(Template.SingleListenerMethodTemplate);
                }
                else
                {
                    template = Template.GetTemplate(Template.SingleMethodTemplate);
                }
                if (forListener) modifier = " virtual";
                if (isDirectListener) modifier = " override";
                singleMethod = template.Replace(AllPackageClasses.ClassStub.MethodStub.DECORATION, jDecoration.ToString())
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_HANDLER_EXECUTION, listenerHandlerType)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_HANDLER_NAME, baseHandlerName)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.MODIFIER, modifier)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.RETURNTYPE, returnType)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.NAME, methodName)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.PARAMETERS, paramsString)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.WHERECLAUSES, genericClauses.ConvertClauses(isGeneric))
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.EXECUTION, executionStub)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_EXECUTION_TYPE, executionPropertyParams)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_FIRST_PARAMETER, CLRListenerEventArgsType)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_EXECUTION, listenerExecutionParamsString)
                                       .Replace(AllPackageClasses.ClassStub.MethodStub.HELP, method.JavadocHrefUrl(JNetReflectorCore.UseCamel));

                subClassBlock.AppendLine(singleMethod);

                if (isListenerReturnType && !forListener && isDirectListener == false)
                {
                    string directMethodName = methodName;
                    indexOfGenerics = methodName.IndexOf('<');
                    if (indexOfGenerics > 0)
                    {
                        directMethodName = methodName.Insert(indexOfGenerics, SpecialNames.DirectMethodSuffix);
                    }
                    else
                    {
                        directMethodName = methodName + SpecialNames.DirectMethodSuffix;
                    }

                    singleMethod = template.Replace(AllPackageClasses.ClassStub.MethodStub.DECORATION, jDecoration.ToString())
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_HANDLER_EXECUTION, listenerHandlerType)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_HANDLER_NAME, baseHandlerName)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.MODIFIER, modifier)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.RETURNTYPE, returnType)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.NAME, directMethodName)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.PARAMETERS, paramsString)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.WHERECLAUSES, genericClauses.ConvertClauses(isGeneric))
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.EXECUTION, executionStubDirect)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_EXECUTION_TYPE, executionPropertyParams)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_FIRST_PARAMETER, CLRListenerEventArgsType)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.LISTENER_EXECUTION, listenerExecutionParamsString)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.HELP, method.JavadocHrefUrl(JNetReflectorCore.UseCamel));

                    subClassBlock.AppendLine(singleMethod);
                }
            }

            var returnStr = subClassBlock.ToString();

            if (forListener && !forInterface && !staticMethods)
            {
                var listenerBlock = string.Format(AllPackageClasses.ClassStub.MethodStub.BLOCK_LISTENER_HANDLER_FORMAT, classDefinition.JVMClassName(null, false, false), subListenerHandlerBlock.ToString());
                returnStr = listenerBlock + returnStr;
            }

            return returnStr;
        }

        static string AnalyzeJavaMethods(this Class classDefinition, string extendingInterface, bool isGeneric)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Java Methods of {0} *******************", classDefinition.GenericString);

            if (!JNetReflectorCore.DisableGenericsInNonGenericClasses && !JNetReflectorCore.DisableGenerics && !classDefinition.IsJVMGenericClass())
            {
                isGeneric = true; // force generic to true to build generic methods on classes that does not have generics
            }

            string template = Template.GetTemplate(Template.SingleListenerJavaMethodTemplate);

            StringBuilder subClassBlock = new StringBuilder();
            StringBuilder subListenerHandlerBlock = new StringBuilder();
            SortedDictionary<string, Method> methods = new SortedDictionary<string, Method>();

            bool isAbstract = classDefinition.IsAbstract();

            foreach (var method in classDefinition.Methods) // here we need to get all methods
            {
                var genString = method.GenericString;
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;
                if (method.IsStatic()) continue;

                if (paramCount == 0 && !method.IsVoid() &&
                    (methodNameOrigin == "toString" || methodNameOrigin == "hashCode" || methodNameOrigin == "getClass")
                   ) continue; // special methods of java.lang.Object

                if (paramCount == 0 && method.IsVoid() &&
                    (methodNameOrigin == "notify" || methodNameOrigin == "notifyAll" || methodNameOrigin == "wait")
                   ) continue; // special methods of java.lang.Object

                if (paramCount == 1 && method.IsVoid() &&
                    (methodNameOrigin == "wait")
                   ) continue; // special methods of java.lang.Object

                if (paramCount == 1 && !method.IsVoid() &&
                    (methodNameOrigin == "equals")
                   ) continue; // special methods of java.lang.Object

                if (paramCount == 2 && method.IsVoid() &&
                    (methodNameOrigin == "wait")
                   ) continue; // special methods of java.lang.Object

                if (methodNameOrigin.Contains(SpecialNames.NestedClassSeparator)) // scala classes can contains this kind of methods
                {
                    ReportTrace(ReflectionTraceLevel.Debug, "Discarded not manegeable method {0}", genString);
                    continue;
                }

                if (!method.IsPublic()) continue; // avoid not public methods

                methods.Add(genString, method);
            }

            Dictionary<string, int> methodCounter = new Dictionary<string, int>();

            foreach (var item in methods)
            {
                var method = item.Value;
                var genString = method.GenericString;
                var paramCount = method.ParameterCount;
                var methodNameOrigin = method.Name;
                var eventHandlerName = methodNameOrigin;
                if (!methodCounter.TryGetValue(methodNameOrigin, out int methodIndexer))
                {
                    methodCounter.Add(methodNameOrigin, methodIndexer);
                }
                else
                {
                    methodCounter[methodNameOrigin] = ++methodIndexer;
                    eventHandlerName = methodIndexer == 0 ? eventHandlerName : (methodIndexer == 1 ? eventHandlerName + paramCount : eventHandlerName + paramCount + $"_{methodIndexer}");
                }

                string returnType = method.GenericReturnType.TypeName;
                if (method.GenericReturnType.IsInstanceOf<TypeVariable>())
                {
                    returnType = SpecialNames.JavaLangObject;
                }
                returnType = returnType.Contains(SpecialNames.BeginGenericDeclaration) ? returnType.Substring(0, returnType.IndexOf(SpecialNames.BeginGenericDeclaration)) : returnType;
                returnType = returnType.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);

                bool hasVarArg = false;
                List<Parameter> parameters = new List<Parameter>();
                Parameter varArg = null;

                foreach (var parameter in method.Parameters)
                {
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

                if (hasVarArg)
                {
                    parameters.Add(varArg);
                }

                StringBuilder methodParamsBuilder = new StringBuilder();
                StringBuilder methodExecutionParamsBuilder = new StringBuilder();

                for (int i = 0; i < parameters.Count; i++)
                {
                    var parameter = parameters[i];
                    var typeStr = parameter.ParameterizedType.TypeName;
                    if (parameter.ParameterizedType.IsInstanceOf<TypeVariable>())
                    {
                        typeStr = SpecialNames.JavaLangObject;
                    }
                    typeStr = typeStr.Contains(SpecialNames.BeginGenericDeclaration) ? typeStr.Substring(0, typeStr.IndexOf(SpecialNames.BeginGenericDeclaration)) : typeStr;
                    typeStr = typeStr.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);

                    methodParamsBuilder.AppendFormat($"{typeStr} {parameter.Name()}, ");
                    methodExecutionParamsBuilder.AppendFormat($"{parameter.Name()}, ");
                }

                string paramsString = methodParamsBuilder.ToString();
                string executionParamsString = methodExecutionParamsBuilder.ToString();
                if (paramCount != 0)
                {
                    if (paramsString.EndsWith(", ")) paramsString = paramsString.Substring(0, paramsString.Length - 2); // remove last occurrence of ", "
                    if (executionParamsString.EndsWith(", ")) executionParamsString = executionParamsString.Substring(0, executionParamsString.Length - 2); // remove last occurrence of ", "
                }

                bool isVoidMethod = method.IsVoid();
                string execStub;
                if (isVoidMethod)
                {
                    execStub = string.Format(AllPackageClasses.ClassStub.MethodStub.VOID_LISTENER_EXECUTION_FORMAT, eventHandlerName, executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString);
                }
                else
                {
                    execStub = string.Format(AllPackageClasses.ClassStub.MethodStub.TYPED_LISTENER_EXECUTION_FORMAT, eventHandlerName, executionParamsString.Length == 0 ? string.Empty : ", " + executionParamsString, returnType);
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing method {0}", genString);

                var singleMethod = template.Replace(AllPackageClasses.ClassStub.MethodStub.RETURNTYPE, returnType)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.NAME, methodNameOrigin)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.PARAMETERS, paramsString)
                                           .Replace(AllPackageClasses.ClassStub.MethodStub.EXECUTION, execStub);

                subClassBlock.AppendLine(singleMethod);

                if (method.IsDefault)
                {
                    execStub = string.Format(isVoidMethod ? AllPackageClasses.ClassStub.MethodStub.SUPERINTERFACE_VOID_LISTENER_EXECUTION_FORMAT : AllPackageClasses.ClassStub.MethodStub.SUPERINTERFACE_TYPED_LISTENER_EXECUTION_FORMAT,
                                             extendingInterface, methodNameOrigin, executionParamsString.Length == 0 ? string.Empty : executionParamsString);

                    var singleDefaultMethod = template.Replace(AllPackageClasses.ClassStub.MethodStub.RETURNTYPE, returnType)
                                                      .Replace(AllPackageClasses.ClassStub.MethodStub.NAME, methodNameOrigin + SpecialNames.DefaultMethodSuffix)
                                                      .Replace(AllPackageClasses.ClassStub.MethodStub.PARAMETERS, paramsString)
                                                      .Replace(AllPackageClasses.ClassStub.MethodStub.EXECUTION, execStub);

                    subClassBlock.AppendLine(singleDefaultMethod);
                }
            }

            var returnStr = subClassBlock.ToString();

            return returnStr;
        }

        static string AnalyzeFields(this Class classDefinition, IEnumerable<Class> classDefinitions, bool isGeneric)
        {
            ReportTrace(ReflectionTraceLevel.Info, "******************* Analyze Fields of {0} *******************", classDefinition.GenericString);

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

            int nestingLevel = classDefinition.JVMNestingLevels();
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

                if (fieldName.IsReservedName() || fieldName.CollapseWithClassOrNestedClass(nestingLevel, classDefinitions))
                {
                    fieldName += "Field";
                }

                ReportTrace(ReflectionTraceLevel.Debug, "Preparing field {0}", field.GenericString);

                bool isFinal = field.IsFinal();
                string getFunction;
                string getFormat;
                string setFormat;
                if (field.IsStatic())
                {
                    getFunction = "SGetField";
                    getFormat = isFinal ? AllPackageClasses.ClassStub.FieldStub.GET_STATIC_EXECUTION_FORMAT_FINAL : AllPackageClasses.ClassStub.FieldStub.GET_STATIC_EXECUTION_FORMAT;
                    setFormat = AllPackageClasses.ClassStub.FieldStub.SET_STATIC_EXECUTION_FORMAT;
                }
                else
                {
                    getFunction = "IGetField";
                    getFormat = isFinal ? AllPackageClasses.ClassStub.FieldStub.GET_EXECUTION_FORMAT_FINAL : AllPackageClasses.ClassStub.FieldStub.GET_EXECUTION_FORMAT;
                    setFormat = AllPackageClasses.ClassStub.FieldStub.SET_EXECUTION_FORMAT;
                }

                bool isArrayReturnType = false;
                if (fieldType.EndsWith(SpecialNames.ArrayTypeTrailer))
                {
                    fieldType = fieldType.Substring(0, fieldType.IndexOf(SpecialNames.ArrayTypeTrailer));
                    getFunction += "Array";
                    isArrayReturnType = true;
                }

                string executionStub = isFinal ? string.Format(getFormat, getFunction, field.IsObjectReturnType(JNetReflectorCore.UseCamel) ? string.Empty : $"<{fieldType}>", field.Name, fieldName)
                                               : string.Format(getFormat, getFunction, field.IsObjectReturnType(JNetReflectorCore.UseCamel) ? string.Empty : $"<{fieldType}>", field.Name);

                if (!isFinal)
                {
                    executionStub += " " + string.Format(setFormat, field.Name);
                }

                StringBuilder jDecoration = new StringBuilder(AllPackageClasses.ClassStub.FieldStub.DEFAULT_DECORATION);
                if (isDeprecated)
                {
                    jDecoration.AppendLine();
                    jDecoration.Append(AllPackageClasses.ClassStub.FieldStub.OBSOLETE_DECORATION);
                }

                var singleFieldTemplate = isFinal ? Template.GetTemplate(Template.SingleFieldFinalTemplate) : Template.GetTemplate(Template.SingleFieldTemplate);
                var singleField = singleFieldTemplate.Replace(AllPackageClasses.ClassStub.FieldStub.DECORATION, jDecoration.ToString())
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.MODIFIER, modifier)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.TYPE, isArrayReturnType ? fieldType + SpecialNames.ArrayTypeTrailer : fieldType)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.NAME, fieldName)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.EXECUTION, executionStub)
                                                     .Replace(AllPackageClasses.ClassStub.FieldStub.HELP, field.JavadocHrefUrl(JNetReflectorCore.UseCamel));

                subClassBlock.AppendLine(singleField);
            }

            return subClassBlock.ToString();
        }
    }
}
