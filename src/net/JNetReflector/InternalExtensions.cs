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
            var testName = entry.Contains('<') ? entry.Substring(0, entry.IndexOf('<')) : entry;
            if (SpecialNames.ReservedLanguageNames.Any((n) => testName.Equals(n))) return true;
            if (SpecialNames.ReservedJNetNames.Any((n) => testName.Equals(n))) return true;
            if (SpecialNames.NumberStartNames.Any((n) => testName.StartsWith(n))) return true;
            return false;
        }

        public static bool CollapseWithClassOrNestedClass(this string entry, ICollection<Class> classDefinitions)
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

        public static bool CollapseWithOtherMethods(this string entry, ICollection<Method> methodToBeReflected, ICollection<Class> classDefinitions)
        {
            foreach (var method in methodToBeReflected)
            {
                var testName = method.MethodName(classDefinitions);
                testName = testName.Contains('<') ? testName.Substring(0, testName.IndexOf('<')) : testName;
                if (entry == testName)
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

        static string Camel(string str)
        {
            if (str.Length == 0 || str.Length == 1) return str;
            else return char.ToUpper(str[0]) + str.Substring(1);
        }

        static string ToFullQualifiedClassName(string canonicalName, bool camel = true)
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

        public static string ConvertToJavadoc(this string result)
        {
            if (result.EndsWith("?")) result = result.Substring(0, result.IndexOf("?"));
            if (result.Contains(SpecialNames.ArrayTypeTrailer)) result = result.Substring(0, result.IndexOf(SpecialNames.ArrayTypeTrailer));
            return result.Replace('<', '{').Replace('>', '}');
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

        #region TypeVariable[] extension

        static string ApplyGenerics(this TypeVariable[] entry, string name)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in entry)
            {
                sb.AppendFormat("{0}, ", item.Name);
            }
            var parameters = sb.ToString();
            if (!string.IsNullOrEmpty(parameters))
            {
                parameters = parameters.Substring(0, parameters.LastIndexOf(", "));
                return $"{name}<{parameters}>";
            }
            return name;
        }

        public static string WhereClauses(this TypeVariable[] entry, bool camel = true)
        {
            StringBuilder sbWhere = new StringBuilder();
            foreach (var typeParameter in entry)
            {
                StringBuilder sbBounds = new StringBuilder();
                foreach (var bound in typeParameter.Bounds)
                {
                    if (!IsNetNative(bound.TypeName)) sbBounds.AppendFormat("{0}, ", ToNetType(bound.TypeName, false, camel));
                }
                var bounds = sbBounds.ToString();
                if (!string.IsNullOrEmpty(bounds))
                {
                    bounds = bounds.Substring(0, bounds.LastIndexOf(", "));
                    sbWhere.AppendFormat(" where {0}: {1}", typeParameter.Name, bounds);
                }
            }
            var parameters = sbWhere.ToString();
            return parameters;
        }

        #endregion

        #region Type extension

        static string ApplyGenerics(this Java.Lang.Reflect.Type entry, bool camel = true)
        {
            if (JNetReflectorCore.AvoidCSharpGenericDefinition) return string.Empty;

            if (entry.IsInstanceOf<ParameterizedType>())
            {
                return ApplyGenerics(entry.CastTo<ParameterizedType>(), camel);
            }
            else if (entry.IsInstanceOf<GenericArrayType>())
            {
                return ApplyGenerics(entry.CastTo<GenericArrayType>(), camel);
            }
            else if (entry.IsInstanceOf<WildcardType>())
            {
                return ApplyGenerics(entry.CastTo<WildcardType>(), camel);
            }
            return $"<{ToFullQualifiedClassName(entry.TypeName, camel)}>";
        }

        static string ApplyGenerics(this GenericArrayType entry, bool camel = true)
        {
            return $"<{ToFullQualifiedClassName(entry.TypeName, camel)}>";
        }

        static string ApplyGenerics(this ParameterizedType entry, bool camel = true)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in entry.ActualTypeArguments)
            {
                sb.AppendFormat("{0}, ", ToFullQualifiedClassName(item.TypeName, camel));
            }
            var parameters = sb.ToString();
            if (!string.IsNullOrEmpty(parameters))
            {
                parameters = parameters.Substring(0, parameters.LastIndexOf(", "));
                return $"<{parameters}>";
            }
            return string.Empty;
        }

        static string ApplyGenerics(this WildcardType entry, bool camel = true)
        {
            return $"<{ToFullQualifiedClassName(entry.TypeName, camel)}>";
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

        public static string JVMClassName(this Class entry, bool withoutGenerics)
        {
            if (entry.IsJVMNestedClass()) return entry.JVMNestedClassName();
            var cName = entry.SimpleName;
            cName = cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
            if (!withoutGenerics) cName = entry.ApplyGenerics(cName);
            return cName;
        }

        public static string JVMMainClassName(this Class entry)
        {
            var cName = entry.TypeName;
            return cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
        }

        static string JVMNestedClassName(this Class entry, bool onlyName = false)
        {
            var cName = entry.TypeName;
            cName = cName.Substring(cName.LastIndexOf(SpecialNames.NestedClassSeparator) + 1);
            if (!onlyName) cName = entry.ApplyGenerics(cName);
            return cName;
        }

        public static string JVMSimpleClassName(this Class entry)
        {
            var cName = entry.TypeName;
            cName = cName.Remove(0, cName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
            return cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
        }

        static string ApplyGenerics(this Class entry, string name)
        {
            if (JNetReflectorCore.DisableGenerics || JNetReflectorCore.AvoidCSharpGenericDefinition || !entry.IsJVMGenericClass()) return name;
            return entry.TypeParameters.ApplyGenerics(name);
        }

        public static string WhereClauses(this Class entry, bool camel = true)
        {
            if (JNetReflectorCore.DisableGenerics || JNetReflectorCore.AvoidCSharpGenericDefinition || !entry.IsJVMGenericClass()) return string.Empty;
            return entry.TypeParameters.WhereClauses(camel);
        }

        public static string JVMFullClassName(this Class entry)
        {
            var name = entry.TypeName;
            return name.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator);
        }

        static string ToFullQualifiedClassName(Class cls, bool withoutGenerics, bool camel = true)
        {
            var cName = cls.TypeName;
            cName = ToFullQualifiedClassName(cName, camel);
            if (!withoutGenerics) cName = cls.ApplyGenerics(cName);
            return cName;
        }

        public static string JVMBaseClassName(this Class entry, bool isListener, bool camel = true)
        {
            if (isListener) return "MASES.JCOBridge.C2JBridge.JVMBridgeListener";
            try
            {
                var superCls = entry.SuperClass;
                if (superCls != null && SpecialNames.IsJavaLangException(superCls.TypeName))
                {
                    return ToFullQualifiedClassName(superCls, false, camel);
                }
                else if (superCls == null
                    || !superCls.IsPublic()
                    || (JNetReflectorCore.ReflectDeprecated ? false : superCls.IsDeprecated())
                    || superCls.MustBeAvoided()
                    || superCls.TypeName == SpecialNames.JavaLangObject)
                {
                    if ((superCls == null || superCls.TypeName == SpecialNames.JavaLangObject) && entry.ContainsIterable())
                    {
                        var method = entry.GetMethod("iterator");
                        string innerName = method.GenericReturnType.ApplyGenerics();
                        return string.Format("Java.Lang.Iterable{0}", innerName);
                    }
                    else
                    {
                        string innerName = entry.JVMClassName(false);
                        return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeBase<{0}>", innerName);
                    }
                }
                else if (superCls.IsJVMGenericClass())
                {
                    var cName = ToFullQualifiedClassName(superCls, true, camel);
                    cName += entry.GenericSuperClass.ApplyGenerics(camel);
                    return cName;
                }
                return ToFullQualifiedClassName(superCls, false, camel);
            }
            catch
            {
                string className = entry.JVMClassName(false);
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
            string className = entry.JVMNestedClassName(true);

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
            return entry.IsInterface() && entry.TypeName == SpecialNames.JavaLangDeprecated;
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

        public static bool IsIterable(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (entry.TypeName.StartsWith(SpecialNames.JavaLangIterable)) // direct name is Iterabale
            {
                return true;
            }
            return false;
        }

        public static bool ContainsIterable(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var item in entry.Interfaces) // or implemented interfaces contains iterbale
            {
                if (item.IsIterable())
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
            return IsVoid(type.TypeName);
        }

        static bool IsVoid(string typeName)
        {
            if (typeName == null) throw new ArgumentNullException(nameof(typeName));
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
            return IsNetNative(type.TypeName);
        }

        static bool IsNetNative(string typeName)
        {
            if (typeName == null) throw new ArgumentNullException(nameof(typeName));
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
            var cName = type.TypeName;
            cName = ToNetType(cName, false, camel);
            cName = type.ApplyGenerics(cName);
            return cName;
        }

        static string ToNetType(string typeName, bool isFromArray, bool camel = true)
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

        static string ApplyGenerics(this Method entry, string name)
        {
            if (JNetReflectorCore.DisableGenerics || JNetReflectorCore.AvoidCSharpGenericDefinition) return name;
            return entry.TypeParameters.ApplyGenerics(name);
        }

        public static string WhereClauses(this Method entry, bool camel = true)
        {
            if (JNetReflectorCore.DisableGenerics || JNetReflectorCore.AvoidCSharpGenericDefinition) return string.Empty;
            return entry.TypeParameters.WhereClauses(camel);
        }

        public static string Name(this Method entry, ICollection<Class> classDefinitions, bool camel = true)
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
            methodName = entry.ApplyGenerics(methodName);
            return camel ? Camel(methodName) : methodName;
        }

        public static string PropertyName(this Method entry, ICollection<Class> classDefinitions, bool camel = true)
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

        public static string MethodName(this Method entry, ICollection<Class> classDefinitions, bool camel = true)
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
            if (JNetReflectorCore.AvoidCSharpGenericDefinition)
            {
                return entry.ReturnType.ToNetType(camel);
            }
            else
            {
                if (entry.TypeParameters.Length != 0 && (entry.IsObjectReturnType() || entry.IsObjectArrayReturnType()))
                {
                    var paramName = entry.TypeParameters[0].Name;
                    if (entry.IsObjectReturnType())
                    {
                        return $"{paramName}";
                    }
                    else
                    {
                        return $"{paramName}[]";
                    }
                }
                else return entry.ReturnType.ToNetType(camel);
            }
        }

        public static bool IsObjectReturnType(this Method entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.ReturnType.ToNetType(camel) == "object";
        }

        public static bool IsObjectArrayReturnType(this Method entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.ReturnType.ToNetType(camel) == "object[]";
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
            string entryType;
            if (!JNetReflectorCore.AvoidCSharpGenericDefinition && entry.Type.IsJVMGenericClass())
            {
                entryType = ToFullQualifiedClassName(entry.Type, true, camel);
                entryType += entry.ParameterizedType.ApplyGenerics(camel);
            }
            else entryType = entry.Type.ToNetType(camel);

            if (JNetReflectorCore.AvoidCSharpGenericDefinition)
            {
                return entryType;
            }
            else
            {
                if (entry.ParameterizedType != null && (entryType == "object" || entryType == "object[]"))
                {
                    var paramName = entry.ParameterizedType.TypeName;
                    return paramName;
                }
                else return entryType;
            }
        }

        public static bool IsObjectType(this Parameter entry, bool camel = true)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.ToNetType(camel) == "object";
        }

        #endregion
    }
}
