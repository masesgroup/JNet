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

using System.IO;
using System;
using System.IO.Compression;
using System.Linq;
using System.Collections.Generic;
using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace MASES.JNet
{
    class CLIParam
    {
        // CommonArgs
        public const string LogClassPath = "LogClassPath";
    }
}

namespace MASES.JNetReflector
{
    class CLIParam : MASES.JNet.CLIParam
    {
        // ReflectorArgs
        public const string OriginRootPath = "OriginRootPath";
        public const string OriginJavadocUrl = "OriginJavadocUrl";
        public const string DestinationRootPath = "DestinationRootPath";
        public const string JarList = "JarList";
        public const string NamespacesToAvoid = "NamespacesToAvoid";
        public const string DryRun = "DryRun";
    }

    public static class JNetReflectorExtensions
    {
        static Java.Lang.ClassLoader _loader;
        static Java.Lang.ClassLoader SystemClassLoader
        {
            get
            {
                if (_loader == null) _loader = Java.Lang.ClassLoader.SystemClassLoader;
                return _loader;
            }
        }


        public static bool IsSpecialFolder(this ZipArchiveEntry entry)
        {
            var name = entry.FullName.ToLowerInvariant();
            if (name.Contains(FileNameAndDirectory.METAINF.ToLowerInvariant())
                || JNetReflectedCore.NamespacesToAvoid.Contains(entry.Namespace(false))) return true;
            return false;
        }

        public static bool IsSpecialClass(this ZipArchiveEntry entry)
        {
            if (entry.IsJVMNestedClass()
                && SpecialNames.SpecialNumberedNames.Any((o) => entry.JVMNestedClassName().StartsWith(o))) return true;
            return false;
        }

        public static bool IsFolder(this ZipArchiveEntry entry)
        {
            if (entry.Length == 0) return true;
            return false;
        }

        public static bool IsJVMNestedClass(this ZipArchiveEntry entry)
        {
            if (entry.Length != 0
                && entry.Name.EndsWith(FileNameAndDirectory.JavaClassExtension)
                && entry.Name.Contains(SpecialNames.NestedClassSeparator)) return true;
            return false;
        }

        public static bool IsJVMClass(this ZipArchiveEntry entry)
        {
            if (entry.Length != 0
                && entry.Name.EndsWith(FileNameAndDirectory.JavaClassExtension)
                && !entry.Name.Contains(SpecialNames.NestedClassSeparator)) return true;
            return false;
        }

        public static string Camel(string str)
        {
            if (str.Length == 0 || str.Length == 1) return str;
            else return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static string Namespace(this ZipArchiveEntry entry, bool camel = true)
        {
            return Namespace(entry.FullName.Replace('/', '.'), camel);
        }

        public static string Namespace(string fullName, bool camel = true)
        {
            if (fullName.EndsWith(SpecialNames.ClassExtension))
            {
                fullName = fullName.Remove(fullName.IndexOf(SpecialNames.ClassExtension));
            }
            var package = fullName.Substring(0, fullName.LastIndexOf('.'));
            var splitted = package.Split('.');
            var ns = string.Join(".", splitted.Select((o) => camel ? Camel(o) : o));
            return ns;
        }

        public static string JVMClassName(this ZipArchiveEntry entry)
        {
            var cName = Path.GetFileNameWithoutExtension(entry.Name);

            return cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
        }

        public static string JVMNestedClassName(this ZipArchiveEntry entry)
        {
            var cName = Path.GetFileNameWithoutExtension(entry.Name);
            return cName.Substring(cName.LastIndexOf(SpecialNames.NestedClassSeparator) + 1);
        }

        public static string JVMFullClassName(this ZipArchiveEntry entry)
        {
            var name = entry.FullName.Substring(0, entry.FullName.LastIndexOf("." + FileNameAndDirectory.JavaClassExtension));
            return name.Replace('/', '.');
        }

        public static string JVMFullQualifiedClassName(this ZipArchiveEntry entry)
        {
            var cName = entry.FullName.Substring(0, entry.FullName.LastIndexOf(SpecialNames.ClassExtension));
            return cName.Replace('/', '.');
        }

        public static string JVMBaseClassName(this ZipArchiveEntry entry)
        {
            var cName = entry.JVMFullQualifiedClassName();
            try
            {
                var jType = Java.Lang.Class.ForName(cName, true, SystemClassLoader);

                if (jType == null || jType.SuperClass == null || jType.SuperClass.CanonicalName == SpecialNames.JavaLangObject)
                {
                    string innerName = entry.IsJVMNestedClass() ? entry.JVMNestedClassName() : entry.JVMClassName();
                    return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeCore<{0}>", innerName);
                }
                else if (jType == null || jType.SuperClass == null || jType.SuperClass.CanonicalName == SpecialNames.JavaLangThrowable)
                {
                    return "Java.Lang.Throwable";
                }
                else if (jType == null || jType.SuperClass == null || jType.SuperClass.CanonicalName == SpecialNames.JavaLangException)
                {
                    string innerName = entry.IsJVMNestedClass() ? entry.JVMNestedClassName() : entry.JVMClassName();
                    return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeException<{0}>", innerName);
                }
                else if (jType == null || jType.SuperClass == null || jType.SuperClass.CanonicalName == SpecialNames.JavaLangError)
                {
                    return "Java.Lang.Error";
                }

                var sClassName = jType.SuperClass.CanonicalName;
                string className = sClassName.Substring(sClassName.LastIndexOf('.') + 1);
                className = Namespace(sClassName) + "." + className.Replace(SpecialNames.NestedClassSeparator, '.');
                return className;
            }
            catch
            {
                string className = entry.IsJVMNestedClass() ? entry.JVMNestedClassName() : entry.JVMClassName();
                return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeCore<{0}>", className);
            }
        }

        public static Java.Lang.Class JVMClass(this ZipArchiveEntry entry)
        {
            var cName = entry.JVMFullQualifiedClassName();
            try
            {
                return Java.Lang.Class.ForName(cName, true, SystemClassLoader);
            }
            catch
            {
                return null;
            }
        }

        public static string JavadocUrl(this ZipArchiveEntry entry, string javaDocBaseUrl)
        {
            var newURl = javaDocBaseUrl;
            if (newURl != null)
            {
                if (!newURl.EndsWith("/"))
                    newURl += '/';
                newURl += Path.ChangeExtension(entry.FullName, ".html");
                return newURl;
            }

            return entry.JVMClassName();
        }

        public static string ToFolderName(this System.Reflection.AssemblyName assName)
        {
            var name = string.Concat(assName.FullName.Split(' '));

            name = name.Replace(',', '_')
                       .Replace('=', '_').ToLowerInvariant();

            return name;
        }

        public static readonly string ReflectorVersion = typeof(JNetReflectorExtensions).Assembly.GetName().Version.ToString();

        public static string[] KeyWords = new string[]
        {
            "import",
            "final",
            "package",
            "implements",
            "extends",
            "break",
            "finally",
            "continue",
            "Class",
            "classType",
            "classInstance",
            "native"
        };
    }

    public static class SpecialNames
    {
        public const string JNetReflectorGeneratedFolder = "JNetReflectorGenerated";
        public const string ClassExtension = ".class";
        public const char NestedClassSeparator = '$';
        public const string JavaLangObject = "java.lang.Object";
        public const string JavaLangThrowable = "java.lang.Throwable";
        public const string JavaLangException = "java.lang.Exception";
        public const string JavaLangError = "java.lang.Error";

        public static IEnumerable<string> SpecialNumberedNames = CreateSpecialNumberedNames();

        static IEnumerable<string> CreateSpecialNumberedNames()
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < 100; i++)
            {
                lst.Add(i.ToString());
            }
            return lst;
        }
    }

    public static class FileNameAndDirectory
    {
        public static string GetRelativePath(string filespec, string folder)
        {
            Uri pathUri = new Uri(filespec);
            if (!folder.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                folder += Path.DirectorySeparatorChar;
            }
            Uri folderUri = new Uri(folder);
            return Uri.UnescapeDataString(folderUri.MakeRelativeUri(pathUri).ToString().Replace('/', Path.DirectorySeparatorChar));
        }

        public const string METAINF = "META-INF";
        public const string JavaClassExtension = "class";

        public const string AllPackageClassesFileName = "AllPackageClasses.cs";
    }
}
