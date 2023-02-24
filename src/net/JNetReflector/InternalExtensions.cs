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
using System.Text;
using MASES.JNetReflector.Templates;

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

        public static bool IsJVMNestedClass(this string entry)
        {
            if (entry.Contains(SpecialNames.NestedClassSeparator)) return true;
            return false;
        }

        public static bool IsReservedName(this string entry)
        {
            if (SpecialNames.ReservedLanguageNames.Any((n) => entry.Equals(n))) return true;
            if (SpecialNames.ReservedJNetNames.Any((n) => entry.Equals(n))) return true;
            if (SpecialNames.NumberStartNames.Any((n) => entry.StartsWith(n))) return true;
            return false;
        }

        public static bool CollapseWithClassOrNestedClass(this string entry, ICollection<string> classDefinitions)
        {
            foreach (var classDefinition in classDefinitions)
            {
                bool collpase = false;
                if (classDefinition.IsJVMNestedClass())
                {
                    collpase = entry == classDefinition.JVMNestedClassName();
                }
                else
                {
                    collpase = entry == classDefinition.JVMSimpleClassName();
                }
                if (collpase) return true;
            }
            return false;
        }

        public static bool CollapseWithOtherMethods(this string entry, ICollection<Method> methodToBeReflected, ICollection<string> classDefinitions)
        {
            foreach (var method in methodToBeReflected)
            {
                if (entry == method.MethodName(classDefinitions))
                {
                    return true;
                }
            }
            return false;
        }

        public static Class JVMClass(this string entry)
        {
            try
            {
                return Class.ForName(entry, true, SystemClassLoader);
            }
            catch
            {
                return null;
            }
        }

        public static string JVMNestedClassName(this string entry)
        {
            return entry.Substring(entry.LastIndexOf(SpecialNames.NestedClassSeparator) + 1);
        }

        public static string JVMSimpleClassName(this string entry)
        {
            var cName = entry.Remove(0, entry.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
            return cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
        }

        public static string Namespace(string fullName, bool camel = true)
        {
            if (fullName.EndsWith(SpecialNames.ClassExtension))
            {
                fullName = fullName.Remove(fullName.IndexOf(SpecialNames.ClassExtension));
            }
            var package = fullName.Substring(0, fullName.LastIndexOf(SpecialNames.NamespaceSeparator));
            foreach (var nsc in JNetReflectorCore.NamespacesInConflict)
            {
                if (package.StartsWith(nsc))
                {
                    package = package.Replace(nsc, nsc + SpecialNames.NamespaceSuffix);
                    break;
                }
            }
            var splitted = package.Split(SpecialNames.NamespaceSeparator);
            var ns = string.Join(SpecialNames.NamespaceSeparator.ToString(), splitted.Select((o) => camel ? Camel(o) : o));
            return ns;
        }

        public static string Camel(string str)
        {
            if (str.Length == 0 || str.Length == 1) return str;
            else return char.ToUpper(str[0]) + str.Substring(1);
        }

        public static string ToFullQualifiedClassName(string canonicalName, bool camel = true)
        {
            string className = canonicalName.Substring(canonicalName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
            className = Namespace(canonicalName, camel) + SpecialNames.NamespaceSeparator + className.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);
            return className;
        }

        public static string AddTabLevel(this string origin, int level)
        {
            if (string.IsNullOrEmpty(origin)) return origin;
            string tabber = string.Empty;
            for (int i = 0; i < level; i++)
            {
                tabber += "    ";
            }
            StringBuilder sb = new StringBuilder();
            var pieces = origin.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            for (int i = 0; i < pieces.Length; i++)
            {
                if (i == pieces.Length - 1) sb.Append(tabber + pieces[i]);
                else sb.AppendLine(tabber + pieces[i]);
            }
            return sb.ToString();
        }

        #endregion

        #region ZipArchiveEntry extension

        public static bool IsSpecialFolder(this ZipArchiveEntry entry)
        {
            var name = entry.FullName.ToLowerInvariant();
            if (name.Contains(FileNameAndDirectory.METAINF.ToLowerInvariant())
                || JNetReflectorCore.NamespacesToAvoid.Any((n) => entry.Namespace(false).StartsWith(n)))
            {
                return true;
            }
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

        public static string JVMFullQualifiedClassName(this ZipArchiveEntry entry)
        {
            var cName = entry.FullName.Substring(0, entry.FullName.LastIndexOf(SpecialNames.ClassExtension));
            return cName.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator);
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

        #endregion

        #region Class extension

        public static bool IsJVMListenerClass(this Class entry)
        {
            if (entry.TypeName.EndsWith(SpecialNames.JavaLangListener)) return true;
            if (entry.TypeName.EndsWith(SpecialNames.JavaLangAdapter)) return true;
            if (JNetReflectorCore.ClassesToBeListener.Any((o) => entry.TypeName == o)) return true;
            return false;
        }

        public static bool IsJVMNestedClass(this Class entry)
        {
            if (entry.TypeName.Contains(SpecialNames.NestedClassSeparator)) return true;
            return false;
        }

        public static bool IsJVMClass(this Class entry)
        {
            if (!entry.TypeName.Contains(SpecialNames.NestedClassSeparator)) return true;
            return false;
        }

        public static string JVMSimpleClassName(this Class entry)
        {
            var cName = entry.SimpleName;
            return cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
        }

        public static string JVMClassName(this Class entry)
        {
            var cName = entry.TypeName;
            return cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
        }

        public static string JVMNestedClassName(this Class entry)
        {
            var cName = entry.TypeName;
            return cName.Substring(cName.LastIndexOf(SpecialNames.NestedClassSeparator) + 1);
        }

        public static string JVMFullClassName(this Class entry)
        {
            var name = entry.TypeName;
            return name.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator);
        }

        public static string JVMBaseClassName(this Class entry, bool isListener)
        {
            if (isListener) return "MASES.JCOBridge.C2JBridge.JVMBridgeListener";
            try
            {
                if (entry.SuperClass == null
                    || !entry.SuperClass.IsPublic()
                    || (JNetReflectorCore.ReflectDeprecated ? false : entry.SuperClass.IsDeprecated())
                    || entry.SuperClass.MustBeAvoided()
                    || entry.SuperClass.TypeName == SpecialNames.JavaLangObject)
                {
                    string innerName = entry.IsJVMNestedClass() ? entry.JVMNestedClassName() : entry.JVMSimpleClassName();
                    return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeBase<{0}>", innerName);
                }
                else if (entry.SuperClass == null || SpecialNames.IsJavaLangException(entry.SuperClass.TypeName))
                {
                    return ToFullQualifiedClassName(entry.SuperClass.TypeName);
                }
                return ToFullQualifiedClassName(entry.SuperClass.TypeName);
            }
            catch
            {
                string className = entry.IsJVMNestedClass() ? entry.JVMNestedClassName() : entry.JVMSimpleClassName();
                return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeBase<{0}>", className);
            }
        }

        public static bool IsNamespaceToAvoid(this Class entry)
        {
            if (JNetReflectorCore.NamespacesToAvoid.Any((n) => entry.Namespace(false).StartsWith(n))) return true;
            return false;
        }

        public static bool IsClassToAvoid(this Class entry)
        {
            var typeName = entry.TypeName;
            if (typeName.EndsWith(SpecialNames.ArrayTypeTrailer)) typeName = typeName.Remove(typeName.LastIndexOf(SpecialNames.ArrayTypeTrailer));
            if (JNetReflectorCore.ClassesToAvoid.Any((n) => typeName == n)) return true;
            return false;
        }

        public static bool IsSpecialClass(this Class entry)
        {
            if (!entry.IsJVMNestedClass()) return false;
            string className = entry.JVMNestedClassName();

            if (entry.IsJVMNestedClass()
                && SpecialNames.SpecialNumberedNames.Any((o) => className.StartsWith(o))) return true;
            return false;
        }

        public static string Namespace(this Class entry, bool camel = true)
        {
            return Namespace(entry.TypeName, camel);
        }

        public static bool IsDeprecatedAnnotation(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.IsInterface() && entry.TypeName == "java.lang.Deprecated";
        }

        public static bool IsDeprecated(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var item in entry.DeclaredAnnotations)
            {
                if (item.AnnotationType.IsDeprecatedAnnotation())
                {
                    return true;
                }
            }
            return false;
        }

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

        public static bool IsCloseable(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var interfaceToCheck in entry.Interfaces)
            {
                if (interfaceToCheck.TypeName == "java.lang.Closeable") return true;
            }
            return false;
        }

        public static bool IsJavaLangException(this Class entry)
        {
            if (entry == null) return false;
            if (SpecialNames.IsJavaLangException(entry.TypeName)) return true;
            return false;
        }

        public static bool IsJVMException(this Class entry)
        {
            if (entry == null) return false;
            if (entry.IsJavaLangException()) return true;
            return IsJVMException(entry.SuperClass);
        }

        public static bool IsOrInheritFromJVMGenericClass(this Class entry)
        {
            if (entry == null) return false;
            if (entry.EnclosingClass != null && entry.EnclosingClass.IsOrInheritFromJVMGenericClass()) return true;
            if (entry.IsJVMGenericClass()) return true;
            return IsOrInheritFromJVMGenericClass(entry.SuperClass);
        }

        public static bool MustBeAvoided(this Class entry)
        {
            if (entry == null) return false;
            if (entry.IsNetNative()) return false;
            if (!entry.IsPublic()) return true;
            if (!JNetReflectorCore.ReflectDeprecated && entry.IsDeprecated()) return true;
            if (entry.TypeName.Contains(SpecialNames.NamespaceSeparator))
            {
                if (entry.IsNamespaceToAvoid()) return true;
                if (entry.IsClassToAvoid()) return true;
            }

            return false;
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
            return ToNetType(type.TypeName, false, camel);
        }

        public static string ToNetType(string typeName, bool isFromArray, bool camel = true)
        {
            if (typeName.EndsWith(SpecialNames.ArrayTypeTrailer)) return ToNetType(typeName.Remove(typeName.LastIndexOf(SpecialNames.ArrayTypeTrailer)), true, camel) + SpecialNames.ArrayTypeTrailer;

            switch (typeName)
            {
                case "void":
                case "java.lang.Void":
                    return "void";
                case "boolean":
                    return "bool";
                case "java.lang.Boolean":
                    return isFromArray ? "bool" : "bool?";
                case "byte":
                    return "byte";
                case "java.lang.Byte":
                    return isFromArray ? "byte" : "byte?";
                case "char":
                    return "char";
                case "java.lang.Character":
                    return isFromArray ? "char" : "char?";
                case "short":
                    return "short";
                case "java.lang.Short":
                    return isFromArray ? "short" : "short?";
                case "int":
                    return "int";
                case "java.lang.Integer":
                    return isFromArray ? "int" : "int?";
                case "long":
                    return "long";
                case "java.lang.Long":
                    return isFromArray ? "long" : "long?";
                case "float":
                    return "float";
                case "java.lang.Float":
                    return isFromArray ? "float" : "float?";
                case "double":
                    return "double";
                case "java.lang.Double":
                    return isFromArray ? "double" : "double?";
                case "java.lang.String":
                    return "string";
                case "java.lang.Object":
                    return "object";
                default:
                    //var splitted = typeName.Split(SpecialNames.NamespaceSeparator, SpecialNames.NestedClassSeparator);
                    //typeName = string.Join(SpecialNames.NamespaceSeparator.ToString(), splitted.Select((o) => camel ? Camel(o) : o));
                    return ToFullQualifiedClassName(typeName, camel);
            }
        }

        public static string JavadocUrl(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            var newURl = JNetReflectorCore.OriginJavadocUrl;
            if (newURl != null)
            {
                if (!newURl.EndsWith("/"))
                    newURl += '/';

                if (JNetReflectorCore.JavadocVersion > 9)
                {
                    var module = entry.Module;
#if USE_MODULEINFO
                    try
                    {
                        if (module.IsNamed)
                        {
                            newURl += module.Name + "/";
                        }
                    }
                    catch (System.Exception e)
#endif
                    {
                        var name = module.ToString();
                        name = name.Remove(0, "module ".Length);
                        newURl += name + "/";
                    }
                }

                newURl += entry.TypeName.Replace('.', '/').Replace('$', '.') + ".html";

                return newURl;
            }

            return entry.TypeName;
        }

        public static string JavadocHrefUrl(this Class entry)
        {
            return string.Format(AllPackageClasses.HREF_URL, JavadocUrl(entry).Replace("<", "%3C").Replace(">", "%3E"));
        }

        #endregion

        #region Constructor extension

        public static bool IsDeprecated(this Constructor entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var item in entry.DeclaredAnnotations)
            {
                if (item.AnnotationType.IsDeprecatedAnnotation())
                {
                    return true;
                }
            }
            return false;
        }

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
            return constructorName.Contains(SpecialNames.NestedClassSeparator) ? constructorName.Remove(0, constructorName.LastIndexOf(SpecialNames.NestedClassSeparator) + 1) : constructorName;
        }

        public static string JavadocUrl(this Constructor entry)
        {
            var newURl = entry.DeclaringClass.JavadocUrl();
            if (JNetReflectorCore.OriginJavadocUrl != null)
            {
                var genString = entry.GenericString;
                if (genString.Contains("throws")) genString = genString.Substring(0, genString.IndexOf("throws") - 1);
                if (JNetReflectorCore.JavadocVersion > 9)
                {
                    genString = genString.Substring(genString.IndexOf(entry.Name) + entry.Name.Length);
                    genString = "<init>" + genString;
                }
                else
                {
                    genString = genString.Substring(genString.IndexOf(entry.Name));
                }

                if (JNetReflectorCore.JavadocVersion < 7)
                {
                    genString = genString.Replace(",", ", ");
                }

                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name;
        }

        public static string JavadocHrefUrl(this Constructor entry)
        {
            return string.Format(AllPackageClasses.HREF_URL, JavadocUrl(entry).Replace("<", "%3C").Replace(">", "%3E")); 
        }

        #endregion

        #region Method extension

        public static bool IsDeprecated(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var item in entry.DeclaredAnnotations)
            {
                if (item.AnnotationType.IsDeprecatedAnnotation())
                {
                    return true;
                }
            }
            return false;
        }

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

        public static string Name(this Method entry, ICollection<string> classDefinitions, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var methodName = entry.Name;
            if (classDefinitions != null)
            {
                foreach (var classDefinition in classDefinitions)
                {
                    if (classDefinition.JVMNestedClassName() == entry.Name(null))
                    {
                        methodName += SpecialNames.MethodSuffix;
                        break;
                    }
                }
            }
            return camel ? Camel(methodName) : methodName;
        }

        public static string PropertyName(this Method entry, ICollection<string> classDefinitions, bool camel = true)
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
                        methodName += SpecialNames.PropertySuffix;
                        break;
                    }
                }
            }
            return camel ? Camel(methodName) : methodName;
        }

        public static string MethodName(this Method entry, ICollection<string> classDefinitions, bool camel = true)
        {
            string nameToReport = entry.Name(classDefinitions, camel);
            if (nameToReport.IsReservedName() || nameToReport.CollapseWithClassOrNestedClass(classDefinitions))
            {
                nameToReport += SpecialNames.MethodSuffix;
            }
            return nameToReport;
        }

        public static bool IsReturnTypeAnException(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.ReturnType.IsJVMException();
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
                if (superClass.TypeName == "java.lang.Object") return false;
                Method method = superClass.GetMethod(entry.Name, entry.ParameterTypes);
                return true;
            }
            catch (NoSuchMethodException)
            {
                return false;
            }
        }

        public static bool IsFromSuperInterface(this Method entry)
        {
            // to be optimized: very time consuming method
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var interfaceToCheck in entry.DeclaringClass.Interfaces)
            {
                try
                {
                    Method method = interfaceToCheck.GetMethod(entry.Name, entry.ParameterTypes);
                    if (!method.ReturnType.Equals(entry.ReturnType))
                    {
                        return true;
                    }
                }
                catch (NoSuchMethodException) { }
            }

            return false;
        }

        public static string JavadocUrl(this Method entry)
        {
            var newURl = entry.DeclaringClass.JavadocUrl();
            if (JNetReflectorCore.OriginJavadocUrl != null)
            {
                var genString = entry.GenericString;
                genString = genString.Substring(genString.IndexOf(entry.Name));
                if (genString.Contains("throws")) genString = genString.Substring(0, genString.IndexOf("throws") - 1);
                if (JNetReflectorCore.JavadocVersion < 7)
                {
                    genString = genString.Replace(",", ", ");
                }
                else if (JNetReflectorCore.JavadocVersion > 7 && JNetReflectorCore.JavadocVersion < 10)
                {
                    genString = genString.Replace(",", "-").Replace('(', '-').Replace(')', '-');
                }

                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name;
        }

        public static string JavadocHrefUrl(this Method entry)
        {
            return string.Format(AllPackageClasses.HREF_URL, JavadocUrl(entry).Replace("<", "%3C").Replace(">", "%3E"));
        }

        #endregion

        #region Field extension

        public static bool IsDeprecated(this Field entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var item in entry.DeclaredAnnotations)
            {
                if (item.AnnotationType.IsDeprecatedAnnotation())
                {
                    return true;
                }
            }
            return false;
        }

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
            if (JNetReflectorCore.OriginJavadocUrl != null)
            {
                var genString = entry.Name;
                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name;
        }

        public static string JavadocHrefUrl(this Field entry)
        {
            return string.Format(AllPackageClasses.HREF_URL, JavadocUrl(entry).Replace("<", "%3C").Replace(">", "%3E"));
        }

        #endregion

        #region Parameter extension

        public static bool IsDeprecated(this Parameter entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var item in entry.DeclaredAnnotations)
            {
                if (item.AnnotationType.IsDeprecatedAnnotation())
                {
                    return true;
                }
            }
            return false;
        }

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

        public static string TypeWithoutArray(this Parameter entry, bool camel = true)
        {
            var result = entry.Type(camel);
            return result.Contains(SpecialNames.ArrayTypeTrailer) ? result.Substring(0, result.IndexOf(SpecialNames.ArrayTypeTrailer)) : result;
        }

        public static bool IsObjectType(this Parameter entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.ToNetType(camel) == "object";
        }

        #endregion
    }
}
