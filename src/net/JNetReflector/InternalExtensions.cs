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
using System.Linq;
using System.Collections.Generic;
using Java.Lang;
using Java.Lang.Reflect;

namespace MASES.JNetReflector
{
    static class JNetReflectorExtensions
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

        #region string extension

        public static string Namespace(string fullName, bool camel = true)
        {
            if (fullName.EndsWith(SpecialNames.ClassExtension))
            {
                fullName = fullName.Remove(fullName.IndexOf(SpecialNames.ClassExtension));
            }
            var package = fullName.Substring(0, fullName.LastIndexOf(SpecialNames.NamespaceSeparator));
            var splitted = package.Split(SpecialNames.NamespaceSeparator);
            var ns = string.Join(SpecialNames.NamespaceSeparator.ToString(), splitted.Select((o) => camel ? Camel(o) : o));
            return ns;
        }

        public static string Camel(string str)
        {
            if (str.Length == 0 || str.Length == 1) return str;
            else return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static string ToFullQualifiedClassName(string canonicalName)
        {
            string className = canonicalName.Substring(canonicalName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
            className = Namespace(canonicalName) + SpecialNames.NamespaceSeparator + className.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);
            return className;
        }

        #endregion

        #region ZipArchiveEntry extension

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

        public static string Namespace(this ZipArchiveEntry entry, bool camel = true)
        {
            return Namespace(entry.FullName.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator), camel);
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
            var name = entry.FullName.Substring(0, entry.FullName.LastIndexOf(SpecialNames.NamespaceSeparator + FileNameAndDirectory.JavaClassExtension));
            return name.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator);
        }

        public static string JVMFullQualifiedClassName(this ZipArchiveEntry entry)
        {
            var cName = entry.FullName.Substring(0, entry.FullName.LastIndexOf(SpecialNames.ClassExtension));
            return cName.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator);
        }

        public static string JVMBaseClassName(this ZipArchiveEntry entry)
        {
            try
            {
                var jType = Class.ForName(entry.JVMFullQualifiedClassName(), true, SystemClassLoader);

                if (jType == null || jType.SuperClass == null || jType.SuperClass.CanonicalName == SpecialNames.JavaLangObject)
                {
                    string innerName = entry.IsJVMNestedClass() ? entry.JVMNestedClassName() : entry.JVMClassName();
                    return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeBase<{0}>", innerName);
                }
                else if (jType == null || jType.SuperClass == null || SpecialNames.IsJavaLangException(jType.SuperClass.CanonicalName))
                {
                    return ToFullQualifiedClassName(jType.SuperClass.CanonicalName);
                }
                //else if (jType == null || jType.SuperClass == null || jType.SuperClass.CanonicalName == SpecialNames.JavaLangException)
                //{
                //    string innerName = entry.IsJVMNestedClass() ? entry.JVMNestedClassName() : entry.JVMClassName();
                //    return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeException<{0}>", innerName);
                //}
                //else if (jType == null || jType.SuperClass == null || jType.SuperClass.CanonicalName == SpecialNames.JavaLangError)
                //{
                //    return "Java.Lang.Error";
                //}

                return ToFullQualifiedClassName(jType.SuperClass.CanonicalName);
            }
            catch
            {
                string className = entry.IsJVMNestedClass() ? entry.JVMNestedClassName() : entry.JVMClassName();
                return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeBase<{0}>", className);
            }
        }

        public static Class JVMClass(this ZipArchiveEntry entry)
        {
            var cName = entry.JVMFullQualifiedClassName();
            try
            {
                return Class.ForName(cName, true, SystemClassLoader);
            }
            catch
            {
                return null;
            }
        }

        public static string JavadocUrl(this ZipArchiveEntry entry)
        {
            var newURl = JNetReflectedCore.OriginJavadocUrl;
            if (newURl != null)
            {
                if (!newURl.EndsWith("/"))
                    newURl += '/';
                newURl += Path.ChangeExtension(entry.FullName, ".html");
                return newURl;
            }

            return entry.JVMClassName();
        }

        #endregion

        #region Class extension

        public static bool IsInterface(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsInterface(entry.Modifiers);
        }

        public static bool IsFinal(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsFinal(entry.Modifiers);
        }

        public static bool IsAbstract(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsAbstract(entry.Modifiers);
        }

        public static bool IsPublic(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsPublic(entry.Modifiers);
        }

        public static bool IsStatic(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsStatic(entry.Modifiers);
        }

        public static bool IsJVMException(this Class entry)
        {
            if (entry == null) return false;
            if (SpecialNames.IsJavaLangException(entry.CanonicalName)) return true;
            return IsJVMException(entry.SuperClass);
        }

        public static bool IsOrInheritFromJVMGenericClass(this Class entry)
        {
            if (entry == null) return false;
            if (entry.EnclosingClass != null && entry.EnclosingClass.IsOrInheritFromJVMGenericClass()) return true;
            if (entry.IsJVMGenericClass()) return true;
            return IsOrInheritFromJVMGenericClass(entry.SuperClass);
        }

        public static bool IsJVMGenericClass(this Class entry)
        {
            if (entry == null) return false;
            if (entry.TypeParameters.Length == 0) return false;
            return true;
        }

        public static bool IsVoid(this Class type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            var typeName = type.TypeName;
            switch (typeName)
            {
                case "void":
                case "java.lang.Void":
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsNetNative(this Class type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            var typeName = type.TypeName;
            switch (typeName)
            {
                case "void":
                case "java.lang.Void":
                case "boolean":
                case "java.lang.Boolean":
                case "byte":
                case "java.lang.Byte":
                case "char":
                case "java.lang.Character":
                case "short":
                case "java.lang.Short":
                case "int":
                case "java.lang.Integer":
                case "long":
                case "java.lang.Long":
                case "float":
                case "java.lang.Float":
                case "double":
                case "java.lang.Double":
                case "java.lang.String": // special case
                case "java.lang.Object": // special case
                    return true;
                default:
                    return false;
            }
        }

        public static string ToNetType(this Class type, bool camel = true)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            return ToNetType(type.TypeName);
        }

        public static string ToNetType(string typeName, bool camel = true)
        {
            if (typeName.EndsWith("[]")) return ToNetType(typeName.Remove(typeName.LastIndexOf("[]")), camel) + "[]";

            switch (typeName)
            {
                case "void":
                case "java.lang.Void":
                    return "void";
                case "boolean":
                case "java.lang.Boolean":
                    return "bool";
                case "byte":
                case "java.lang.Byte":
                    return "byte";
                case "char":
                case "java.lang.Character":
                    return "char";
                case "short":
                case "java.lang.Short":
                    return "short";
                case "int":
                case "java.lang.Integer":
                    return "int";
                case "long":
                case "java.lang.Long":
                    return "long";
                case "float":
                case "java.lang.Float":
                    return "float";
                case "double":
                case "java.lang.Double":
                    return "double";
                case "java.lang.String":
                    return "string";
                case "java.lang.Object":
                    return "object";
                default:
                    var splitted = typeName.Split(SpecialNames.NamespaceSeparator, SpecialNames.NestedClassSeparator);
                    typeName = string.Join(SpecialNames.NamespaceSeparator.ToString(), splitted.Select((o) => camel ? Camel(o) : o));
                    return typeName;
            }
        }

        public static string JavadocUrl(this Class entry)
        {
            var newURl = JNetReflectedCore.OriginJavadocUrl;
            if (newURl != null)
            {
                if (!newURl.EndsWith("/"))
                    newURl += '/';

                newURl += entry.TypeName.Replace('.', '/').Replace('$', '.') + ".html";

                return newURl;
            }

            return entry.CanonicalName;
        }

        #endregion

        #region Constructor extension

        public static bool IsInterface(this Constructor entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsInterface(entry.Modifiers);
        }

        public static bool IsFinal(this Constructor entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsFinal(entry.Modifiers);
        }

        public static bool IsAbstract(this Constructor entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsAbstract(entry.Modifiers);
        }

        public static bool IsPublic(this Constructor entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsPublic(entry.Modifiers);
        }

        public static bool IsStatic(this Constructor entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsStatic(entry.Modifiers);
        }

        public static string Name(this Constructor entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var constructorName = entry.Name;
            if (constructorName.Contains(SpecialNames.NamespaceSeparator)) constructorName = constructorName.Substring(constructorName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
            return constructorName.Contains(SpecialNames.NestedClassSeparator) ? constructorName.Substring(0, constructorName.LastIndexOf(SpecialNames.NestedClassSeparator)) : constructorName;
        }

        public static string JavadocUrl(this Constructor entry)
        {
            var newURl = entry.DeclaringClass.JavadocUrl();
            if (JNetReflectedCore.OriginJavadocUrl != null)
            {
                var genString = entry.GenericString;

                if (JNetReflectedCore.JavadocVersion > 9)
                {
                    genString = genString.Substring(genString.IndexOf(entry.Name) + entry.Name.Length);
                    genString = "<init>" + genString;
                }
                else
                {
                    genString = genString.Substring(genString.IndexOf(entry.Name));
                }

                if (JNetReflectedCore.JavadocVersion < 7)
                {
                    genString = genString.Replace(",", ", ");
                }

                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name;
        }

        #endregion

        #region Method extension

        public static bool IsVoid(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.ReturnType.IsVoid();
        }

        public static bool IsInterface(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsInterface(entry.Modifiers);
        }

        public static bool IsFinal(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsFinal(entry.Modifiers);
        }

        public static bool IsAbstract(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsAbstract(entry.Modifiers);
        }

        public static bool IsPublic(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsPublic(entry.Modifiers);
        }

        public static bool IsStatic(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsStatic(entry.Modifiers);
        }

        public static bool IsGetProperty(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var name = entry.Name;
            if (name.StartsWith("get") && name.Length > 3 && entry.ParameterCount == 0) return true;
            return false;
        }

        public static bool IsSetProperty(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var name = entry.Name;
            if (name.StartsWith("set") && name.Length > 3 && entry.ParameterCount == 1 && entry.ReturnType.IsVoid()) return true;
            return false;
        }

        public static bool IsProperty(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (entry.IsGetProperty() || entry.IsSetProperty()) return true;
            return false;
        }

        public static string PropertyName(this Method entry, IList<ZipArchiveEntry> classDefinitions, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var methodName = entry.Name;
            if (methodName.StartsWith("get") && methodName.Length > 3 && entry.ParameterCount == 0) methodName = methodName.Substring(3);
            if (methodName.StartsWith("set") && methodName.Length > 3 && entry.ParameterCount == 1 && entry.ReturnType.IsVoid()) methodName = methodName.Substring(3);
            if (classDefinitions != null)
            {
                foreach (var classDefinition in classDefinitions)
                {
                    if (classDefinition.JVMNestedClassName() == entry.Name(null))
                    {
                        methodName += "Property";
                        break;
                    }
                }
            }
            return camel ? Camel(methodName) : methodName;
        }

        public static string Name(this Method entry, IList<ZipArchiveEntry> classDefinitions, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var methodName = entry.Name;
            if (classDefinitions != null)
            {
                foreach (var classDefinition in classDefinitions)
                {
                    if (classDefinition.JVMNestedClassName() == entry.Name(null))
                    {
                        methodName += "Method";
                        break;
                    }
                }
            }
            return camel ? Camel(methodName) : methodName;
        }

        public static string ReturnType(this Method entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.ReturnType.ToNetType(camel);
        }

        public static bool IsObjectReturnType(this Method entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.ReturnType.ToNetType(camel) == "object";
        }

        public static bool IsOverrideOrConcrete(this Method entry)
        {
            // to be optimized: very time consuming method
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            try
            {
                var superClass = entry.DeclaringClass.SuperClass;
                if (superClass == null) return false;
                Method method = superClass.GetMethod(entry.Name, entry.ParameterTypes);
                return true;
            }
            catch (NoSuchMethodException)
            {
                return false;
            }
        }

        public static string JavadocUrl(this Method entry)
        {
            var newURl = entry.DeclaringClass.JavadocUrl();
            if (JNetReflectedCore.OriginJavadocUrl != null)
            {
                var genString = entry.GenericString;
                genString = genString.Substring(genString.IndexOf(entry.Name));
                if (JNetReflectedCore.JavadocVersion < 7)
                {
                    genString = genString.Replace(",", ", ");
                }
                else if (JNetReflectedCore.JavadocVersion > 7 && JNetReflectedCore.JavadocVersion < 10)
                {
                    genString = genString.Replace(",", "-").Replace('(', '-').Replace(')', '-');
                }

                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name;
        }

        #endregion

        #region Field extension

        public static bool IsInterface(this Field entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsInterface(entry.Modifiers);
        }

        public static bool IsFinal(this Field entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsFinal(entry.Modifiers);
        }

        public static bool IsAbstract(this Field entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsAbstract(entry.Modifiers);
        }

        public static bool IsPublic(this Field entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsPublic(entry.Modifiers);
        }

        public static bool IsStatic(this Field entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsStatic(entry.Modifiers);
        }

        public static string Name(this Field entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return camel ? Camel(entry.Name) : entry.Name;
        }

        public static bool IsTypeNative(this Field entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.IsNetNative();
        }

        public static string Type(this Field entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.ToNetType(camel);
        }

        public static bool IsObjectReturnType(this Field entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.ToNetType(camel) == "object";
        }

        public static string JavadocUrl(this Field entry)
        {
            var newURl = entry.DeclaringClass.JavadocUrl();
            if (JNetReflectedCore.OriginJavadocUrl != null)
            {
                var genString = entry.Name;
                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name;
        }

        #endregion

        #region Parameter extension

        public static bool IsInterface(this Parameter entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsInterface(entry.Modifiers);
        }

        public static bool IsFinal(this Parameter entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsFinal(entry.Modifiers);
        }

        public static bool IsAbstract(this Parameter entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsAbstract(entry.Modifiers);
        }

        public static bool IsPublic(this Parameter entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsPublic(entry.Modifiers);
        }

        public static bool IsStatic(this Parameter entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return Modifier.IsStatic(entry.Modifiers);
        }

        public static string Type(this Parameter entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.ToNetType(camel);
        }

        public static bool IsObjectType(this Parameter entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.ToNetType(camel) == "object";
        }

        #endregion

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
}
