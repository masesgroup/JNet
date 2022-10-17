/*
*  Copyright 2022 MASES s.r.l.
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

using MASES.CLIParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using MASES.JNetReflector.Templates;

namespace MASES.JNetReflector
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var assembly = typeof(Program).Assembly;
                Console.WriteLine($"{assembly.GetName().Name} (ver. {assembly.GetName().Version}) - JNet class reflection utility command line interface");
                Console.WriteLine();

                JNetReflectedCore.CreateGlobalInstance();

                foreach (var item in JNetReflectedCore.JarsToAnaylyze)
                {
                    AnalyzedJar(item, JNetReflectedCore.DestinationRootPath, JNetReflectedCore.OriginJavadocUrl, JNetReflectedCore.DryRun);
                }
            }
            catch (Exception e)
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(e.Message);
                Exception innerException = e.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }
                ShowHelp(sb.ToString());
            }
        }

        static void AnalyzedJar(string pathToJar, string rootDesinationFolder, string javaDocUrl = null, bool dryRun = false)
        {
            using (ZipArchive archive = ZipFile.OpenRead(pathToJar))
            {
                Dictionary<string, IDictionary<string, IList<ZipArchiveEntry>>> resultingArguments = new Dictionary<string, IDictionary<string, IList<ZipArchiveEntry>>>();

                foreach (var entry in archive.Entries)
                {
                    if (entry.IsSpecialFolder()) continue; // do not reflect this folders
                    if (entry.IsSpecialClass()) continue; // do not reflect this folders
                    if (entry.IsFolder())
                    {
                        var path = Path.Combine(rootDesinationFolder, entry.Namespace().Replace('.', Path.DirectorySeparatorChar));
                        if (!dryRun && !Directory.Exists(path)) Directory.CreateDirectory(path);
                    }
                    if (entry.IsJVMClass() || entry.IsJVMNestedClass())
                    {
                        var package = entry.Namespace();
                        IDictionary<string, IList<ZipArchiveEntry>> entries;
                        if (!resultingArguments.TryGetValue(package, out entries))
                        {
                            entries = new Dictionary<string, IList<ZipArchiveEntry>>();
                            resultingArguments.Add(package, entries);
                        }
                        IList<ZipArchiveEntry> subEntries;
                        if (!entries.TryGetValue(entry.JVMClassName(), out subEntries))
                        {
                            subEntries = new List<ZipArchiveEntry>();
                            entries.Add(entry.JVMClassName(), subEntries);
                        }
                        subEntries.Add(entry);
                    }
                }

                var allPackageClasses = Template.GetTemplate(Template.AllPackageClassesTemplate);

                foreach (var item in resultingArguments)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var entry in item.Value)
                    {
                        var classContent = AnalyzedClass(entry.Value, rootDesinationFolder, javaDocUrl, dryRun);
                        if (!string.IsNullOrEmpty(classContent))
                        {
                            sb.Append(classContent);
                        }
                    }

                    var itemPackage = allPackageClasses.Replace(AllPackageClasses.USING_PLACEHOLDER, string.Empty)
                                                       .Replace(AllPackageClasses.NAMESPACE_PLACEHOLDER, item.Key)
                                                       .Replace(AllPackageClasses.CLASSES_PLACEHOLDER, sb.ToString());

                    var path = Path.Combine(rootDesinationFolder, item.Key.Replace('.', Path.DirectorySeparatorChar), "AllPackageClasses.cs");
                    if (!dryRun)
                    {
                        if (File.Exists(path)) File.Delete(path);
                        File.WriteAllText(path, itemPackage);
                    }
                }
            }
        }

        static string AnalyzedClass(IList<ZipArchiveEntry> classDefinitions, string rootDesinationFolder, string javaDocUrl, bool dryRun)
        {
            bool mainClassDone = false;
            string classBlock = string.Empty;
            var allPackageStubNestedClass = Template.GetTemplate(Template.AllPackageClassesStubNestedClassTemplate);
            var allPackageStubClass = Template.GetTemplate(Template.AllPackageClassesStubClassTemplate);
            var singleClassTemplate = Template.GetTemplate(Template.SingleClassTemplate);
            var singleNestedClassTemplate = Template.GetTemplate(Template.SingleNestedClassTemplate);

            StringBuilder sb = new StringBuilder();
            StringBuilder subClassBlock = new StringBuilder();
            StringBuilder subClassAutonoumous = new StringBuilder();
            ZipArchiveEntry mainClass = null;

            foreach (var entry in classDefinitions)
            {
                if (entry.IsJVMNestedClass())
                {
                    var nestedClassBlock = allPackageStubNestedClass.Replace(AllPackageClasses.ClassStub.NestedClassStub.JAVACLASS_PLACEHOLDER, entry.JVMFullClassName())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.CLASS_PLACEHOLDER, entry.JVMNestedClassName())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.HELP_PLACEHOLDER, entry.JavadocUrl(javaDocUrl))
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.BASECLASS_PLACEHOLDER, entry.JVMBaseClassName());

                    subClassBlock.AppendLine(nestedClassBlock);

                    var singleNestedClassStr = singleNestedClassTemplate.Replace(AllPackageClasses.ClassStub.NestedClassStub.CLASS_PLACEHOLDER, entry.JVMNestedClassName());
                    subClassAutonoumous.AppendLine(singleNestedClassStr);
                }

                if (entry.IsJVMClass())
                {
                    if (mainClassDone) throw new InvalidOperationException("Too many main class");
                    mainClassDone = true;
                    mainClass = entry;
                }
            }

            if (!mainClassDone) return string.Empty;

            classBlock = allPackageStubClass.Replace(AllPackageClasses.ClassStub.JAVACLASS_PLACEHOLDER, mainClass.JVMFullClassName())
                                            .Replace(AllPackageClasses.ClassStub.CLASS_PLACEHOLDER, mainClass.JVMClassName())
                                            .Replace(AllPackageClasses.ClassStub.HELP_PLACEHOLDER, mainClass.JavadocUrl(javaDocUrl))
                                            .Replace(AllPackageClasses.ClassStub.BASECLASS_PLACEHOLDER, mainClass.JVMBaseClassName());

            sb.AppendLine(classBlock);

            var singleClassStr = singleClassTemplate.Replace(AllPackageClasses.USING_PLACEHOLDER, string.Empty)
                                                    .Replace(AllPackageClasses.NAMESPACE_PLACEHOLDER, mainClass.Namespace())
                                                    .Replace(AllPackageClasses.ClassStub.CLASS_PLACEHOLDER, mainClass.JVMClassName())
                                                    .Replace(AllPackageClasses.ClassStub.NESTED_CLASSES_PLACEHOLDER, subClassAutonoumous.ToString());

            var classPath = Path.Combine(rootDesinationFolder, mainClass.Namespace().Replace('.', Path.DirectorySeparatorChar), $"{mainClass.JVMClassName()}.cs");

            if (!dryRun)
            {
                if (File.Exists(classPath)) File.Delete(classPath);
                File.WriteAllText(classPath, singleClassStr);
            }

            var subClassStr = subClassBlock.ToString();
            classBlock = classBlock.Replace(AllPackageClasses.ClassStub.NESTED_CLASSES_PLACEHOLDER, subClassStr.Length != 0 ? subClassStr : string.Empty);

            return classBlock;
        }

        static void ShowHelp(string errorString = null)
        {
            var assembly = typeof(Program).Assembly;

            Console.WriteLine($"{assembly.GetName().Name} (ver. {assembly.GetName().Version}) - JNet class reflection utility command line interface");
            Console.WriteLine($"{assembly.GetName().Name} ");
            Console.WriteLine();
            if (!string.IsNullOrEmpty(errorString))
            {
                Console.WriteLine("Error: {0}", errorString);
            }

            Console.WriteLine();
            Console.WriteLine("Examples:");
            Console.WriteLine(assembly.GetName().Name + " ");
        }
    }
}