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
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace MASES.JNetReflector
{
    class CLIParam : MASES.JNet.CLIParam
    {
        // ReflectorArgs
        public const string OriginRootPath = "OriginRootPath";
        public const string OriginJavadocUrl = "OriginJavadocUrl";
        public const string JavadocVersion = "JavadocVersion";
        public const string DestinationRootPath = "DestinationRootPath";
        public const string JarList = "JarList";
        public const string ModulesToParse = "ModulesToParse";
        public const string ClassToBeListener = "ClassToBeListener";
        public const string NamespacesInConflict = "NamespacesInConflict";
        public const string NamespacesToAvoid = "NamespacesToAvoid";
        public const string ClassesToAvoid = "ClassesToAvoid";
        public const string DoNotAddJarsInClasspath = "DoNotAddJarsInClasspath";
        public const string ReflectDeprecated = "ReflectDeprecated";
        public const string DryRun = "DryRun";
        public const string TraceLevel = "TraceLevel";
        public const string TraceTo = "TraceTo";
    }

    public static class SpecialNames
    {
        static Assembly assembly = typeof(Program).Assembly;

        public static string VersionPlaceHolder()
        {
            return $"{assembly.GetName().Name} (ver. {assembly.GetName().Version})";
        }

        public const string JNetReflectorGeneratedFolder = "JNetReflectorGenerated";
        public const string ClassExtension = ".class";
        public const char JNISeparator = '/';
        public const char NamespaceSeparator = '.';
        public const char NestedClassSeparator = '$';
        public const string JavaLangObject = "java.lang.Object";
        public const string JavaLangListener = "Listener";
        public const string JavaLangAdapter = "Adapter";
        public const string ArrayTypeTrailer = "[]";
        public const string PropertySuffix = "Property";
        public const string MethodSuffix = "Method";
        public const string NamespaceSuffix = "Ns";

        public static bool IsJavaLangException(string canonicalName)
        {
            return JavaLangExceptions.Contains(canonicalName);
        }

        public static IEnumerable<string> JavaLangExceptions = new string[]
        {
            "java.lang.Throwable",
            "java.lang.ArithmeticException",
            "java.lang.ArrayIndexOutOfBoundsException",
            "java.lang.ArrayStoreException",
            "java.lang.ClassCastException",
            "java.lang.ClassNotFoundException",
            "java.lang.CloneNotSupportedException",
            "java.lang.EnumConstantNotPresentException",
            "java.lang.Exception",
            "java.lang.IllegalAccessException",
            "java.lang.IllegalArgumentException",
            "java.lang.IllegalMonitorStateException",
            "java.lang.IllegalStateException",
            "java.lang.IllegalThreadStateException",
            "java.lang.IndexOutOfBoundsException",
            "java.lang.InstantiationException",
            "java.lang.InterruptedException",
            "java.lang.NegativeArraySizeException",
            "java.lang.NoSuchFieldException",
            "java.lang.NoSuchMethodException",
            "java.lang.NullPointerException",
            "java.lang.NumberFormatException",
            "java.lang.ReflectiveOperationException",
            "java.lang.RuntimeException",
            "java.lang.SecurityException",
            "java.lang.StringIndexOutOfBoundsException",
            "java.lang.TypeNotPresentException",
            "java.lang.UnsupportedOperationException",
            "java.lang.AbstractMethodError",
            "java.lang.AssertionError",
            "java.lang.BootstrapMethodError",
            "java.lang.ClassCircularityError",
            "java.lang.ClassFormatError",
            "java.lang.Error",
            "java.lang.ExceptionInInitializerError",
            "java.lang.IllegalAccessError",
            "java.lang.IncompatibleClassChangeError",
            "java.lang.InstantiationError",
            "java.lang.InternalError",
            "java.lang.LinkageError",
            "java.lang.NoClassDefFoundError",
            "java.lang.NoSuchFieldError",
            "java.lang.NoSuchMethodError",
            "java.lang.OutOfMemoryError",
            "java.lang.StackOverflowError",
            "java.lang.UnknownError",
            "java.lang.UnsatisfiedLinkError",
            "java.lang.UnsupportedClassVersionError",
            "java.lang.VerifyError",
            "java.lang.VirtualMachineError",
        };


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

        public static IEnumerable<string> ReservedLanguageNames = CreateReservedLanguageNames();

        static IEnumerable<string> CreateReservedLanguageNames()
        {
            List<string> lst = new List<string>();
            lst.Add("in");
            lst.Add("out");
            lst.Add("base");
            return lst;
        }

        public static IEnumerable<string> ReservedJNetNames = CreateReservedJNetNames();

        static IEnumerable<string> CreateReservedJNetNames()
        {
            List<string> lst = new List<string>();
            lst.Add("Instance");
            lst.Add("ClassName");
            lst.Add("IsAbstract");
            lst.Add("IsCloseable");
            lst.Add("IsInterface");
            lst.Add("IsStatic");
            return lst;
        }

        public static IEnumerable<string> NumberStartNames = CreateNumberStartNames();

        static IEnumerable<string> CreateNumberStartNames()
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < 10; i++)
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
