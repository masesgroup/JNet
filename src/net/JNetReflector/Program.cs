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

using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Reflection;
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
            catch (TargetInvocationException tie)
            {
                StringBuilder sb = new StringBuilder();
                Exception e = tie.InnerException;
                sb.AppendLine(e.Message);
                Exception innerException = e.InnerException;
                while (innerException != null)
                {
                    sb.AppendLine(innerException.Message);
                    innerException = innerException.InnerException;
                }
                ShowHelp(sb.ToString());
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
                    if (entry.IsSpecialClass()) continue; // do not reflect this classes
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
                var jarName = Path.GetFileName(pathToJar);

                foreach (var item in resultingArguments)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var entry in item.Value)
                    {
                        var classContent = AnalyzedClass(jarName, entry.Value, rootDesinationFolder, javaDocUrl, dryRun);
                        if (!string.IsNullOrEmpty(classContent))
                        {
                            sb.AppendLine(classContent);
                            sb.AppendLine();
                        }
                    }

                    var itemPackage = allPackageClasses.Replace(AllPackageClasses.VERSION_PLACEHOLDER, SpecialNames.VersionPlaceHolder())
                                                       .Replace(AllPackageClasses.JAR_PLACEHOLDER, jarName)
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

        static string AnalyzedClass(string jarName, IList<ZipArchiveEntry> classDefinitions, string rootDesinationFolder, string javaDocUrl, bool dryRun)
        {
            bool mainClassDone = false;
            var allPackageStubNestedClass = Template.GetTemplate(Template.AllPackageClassesStubNestedClassTemplate);
            var allPackageStubNestedException = Template.GetTemplate(Template.AllPackageClassesStubNestedExceptionTemplate);
            var allPackageStubClass = Template.GetTemplate(Template.AllPackageClassesStubClassTemplate);
            var allPackageStubException = Template.GetTemplate(Template.AllPackageClassesStubExceptionTemplate);
            var singleClassTemplate = Template.GetTemplate(Template.SingleClassTemplate);
            var singleNestedClassTemplate = Template.GetTemplate(Template.SingleNestedClassTemplate);

            StringBuilder subClassBlock = new StringBuilder();
            StringBuilder subClassAutonoumous = new StringBuilder();
            ZipArchiveEntry mainClass = null;

            foreach (var entry in classDefinitions)
            {
                if (entry.IsJVMNestedClass())
                {
                    var jSubClass = entry.JVMClass();
                    if (jSubClass.IsOrInheritFromJVMGenericClass()) continue;

                    string nestedClassBlock;

                    if (jSubClass.IsJVMException())
                    {
                        nestedClassBlock = allPackageStubNestedException.Replace(AllPackageClasses.ClassStub.NestedClassStub.JAVACLASS_PLACEHOLDER, entry.JVMFullClassName())
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.CLASS_PLACEHOLDER, entry.JVMNestedClassName())
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.HELP_PLACEHOLDER, entry.JavadocUrl(javaDocUrl))
                                                                        .Replace(AllPackageClasses.ClassStub.NestedClassStub.BASECLASS_PLACEHOLDER, entry.JVMBaseClassName());
                    }
                    else
                    {
                        bool isSubClassCloseable = false; // to be defined
                        bool isSubClassStatic = Java.Lang.Reflect.Modifier.IsStatic(jSubClass.Modifiers);

                        nestedClassBlock = allPackageStubNestedClass.Replace(AllPackageClasses.ClassStub.NestedClassStub.JAVACLASS_PLACEHOLDER, entry.JVMFullClassName())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.CLASS_PLACEHOLDER, entry.JVMNestedClassName())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.HELP_PLACEHOLDER, entry.JavadocUrl(javaDocUrl))
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.BASECLASS_PLACEHOLDER, entry.JVMBaseClassName())
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.ISABSTRACT_PLACEHOLDER, jSubClass.IsAbstract ? "true" : "false")
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.ISCLOSEABLE_PLACEHOLDER, isSubClassCloseable ? "true" : "false")
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.ISINTERFACE_PLACEHOLDER, jSubClass.IsInterface ? "true" : "false")
                                                                    .Replace(AllPackageClasses.ClassStub.NestedClassStub.ISSTATIC_PLACEHOLDER, isSubClassStatic ? "true" : "false");
                    }

                    subClassBlock.AppendLine(nestedClassBlock);
                    subClassBlock.AppendLine();

                    var singleNestedClassStr = singleNestedClassTemplate.Replace(AllPackageClasses.ClassStub.NestedClassStub.CLASS_PLACEHOLDER, entry.JVMNestedClassName());
                    subClassAutonoumous.AppendLine(singleNestedClassStr);
                    subClassAutonoumous.AppendLine();
                }

                if (entry.IsJVMClass())
                {
                    if (mainClassDone) throw new InvalidOperationException("Too many main class");
                    mainClassDone = true;
                    mainClass = entry;
                }
            }

            if (!mainClassDone) return string.Empty;

            var jClass = mainClass.JVMClass();
            if (jClass.IsOrInheritFromJVMGenericClass()) return string.Empty;

            string classBlock = string.Empty;
            if (jClass.IsJVMException())
            {
                classBlock = allPackageStubException.Replace(AllPackageClasses.ClassStub.JAVACLASS_PLACEHOLDER, mainClass.JVMFullClassName())
                                                    .Replace(AllPackageClasses.ClassStub.CLASS_PLACEHOLDER, mainClass.JVMClassName())
                                                    .Replace(AllPackageClasses.ClassStub.HELP_PLACEHOLDER, mainClass.JavadocUrl(javaDocUrl))
                                                    .Replace(AllPackageClasses.ClassStub.BASECLASS_PLACEHOLDER, mainClass.JVMBaseClassName());
            }
            else
            {
                bool isClassCloseable = false; // to be defined
                bool isClassStatic = Java.Lang.Reflect.Modifier.IsStatic(jClass.Modifiers);
                classBlock = allPackageStubClass.Replace(AllPackageClasses.ClassStub.JAVACLASS_PLACEHOLDER, mainClass.JVMFullClassName())
                                                .Replace(AllPackageClasses.ClassStub.CLASS_PLACEHOLDER, mainClass.JVMClassName())
                                                .Replace(AllPackageClasses.ClassStub.HELP_PLACEHOLDER, mainClass.JavadocUrl(javaDocUrl))
                                                .Replace(AllPackageClasses.ClassStub.BASECLASS_PLACEHOLDER, mainClass.JVMBaseClassName())
                                                .Replace(AllPackageClasses.ClassStub.ISABSTRACT_PLACEHOLDER, jClass.IsAbstract ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISCLOSEABLE_PLACEHOLDER, isClassCloseable ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISINTERFACE_PLACEHOLDER, jClass.IsInterface ? "true" : "false")
                                                .Replace(AllPackageClasses.ClassStub.ISSTATIC_PLACEHOLDER, isClassStatic ? "true" : "false");
            }

            var singleClassStr = singleClassTemplate.Replace(AllPackageClasses.VERSION_PLACEHOLDER, SpecialNames.VersionPlaceHolder())
                                                    .Replace(AllPackageClasses.JAR_PLACEHOLDER, jarName)
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
            if (!string.IsNullOrEmpty(errorString))
            {
                Console.WriteLine("Error: {0}", errorString);
            }

            Console.WriteLine(JNetReflectedCore.HelpInfo());

            Console.WriteLine();
            Console.WriteLine("Examples: ");
            Console.WriteLine("dotnet" + assembly.GetName().Name + ".dll -OriginRootPath C:\\myJars -OriginJavadocUrl \"https://thehost/javadoc/\" -DestinationRootPath c:\\ReflectionDestination ");
        }
    }
}