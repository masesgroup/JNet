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
        static string _CurrentJavadocBaseUrl;
        static int _CurrentJavadocVersion;

        static Java.Lang.ClassLoader _loader;
        static Java.Lang.ClassLoader SystemClassLoader
        {
            get
            {
                if (_loader == null) _loader = Java.Lang.ClassLoader.SystemClassLoader;
                return _loader;
            }
        }

        #region General info

        public static void SetJavaDocInfo(string currentJavadocBaseUrl, int currentJavadocVersion)
        {
            _CurrentJavadocBaseUrl = currentJavadocBaseUrl;
            _CurrentJavadocVersion = currentJavadocVersion;
        }

        #endregion

        #region string extension

        public static bool IsJVMNestedClass(this string entry)
        {
            if (entry.Contains(SpecialNames.NestedClassSeparator)) return true;
            return false;
        }

        public static bool IsReservedName(this string entry)
        {
            var testName = entry.Contains(SpecialNames.BeginGenericDeclaration) ? entry.Substring(0, entry.IndexOf(SpecialNames.BeginGenericDeclaration)) : entry;
            if (SpecialNames.ReservedLanguageNames.Any((n) => testName.Equals(n))) return true;
            if (SpecialNames.ReservedJNetNames.Any((n) => testName.Equals(n))) return true;
            if (SpecialNames.NumberStartNames.Any((n) => testName.StartsWith(n))) return true;
            return false;
        }

        public static bool CollapseWithClassOrNestedClass(this string entry, int nestingLevel, IEnumerable<Class> classDefinitions)
        {
            foreach (var classDefinition in classDefinitions)
            {
                bool collpase = false;
                if (classDefinition.IsJVMNestedClass())
                {
                    if (classDefinition.JVMNestingLevels() == nestingLevel) // same level of requester
                    {
                        collpase = entry == classDefinition.JVMNestedClassName(nestingLevel, null, false);
                    }
                    else if (classDefinition.JVMNestingLevels() > nestingLevel) // more levels then requester
                    {
                        collpase = entry == classDefinition.JVMNestedClassName(nestingLevel + 1, null, false);
                    }
                }
                else
                {
                    collpase = entry == classDefinition.JVMSimpleClassName();
                }
                if (collpase) return true;
            }
            return false;
        }

        public static bool CollapseWithOtherMethods(this string entry, Method methodToCheck, IEnumerable<Method> methodToBeReflected, IEnumerable<Class> classDefinitions, bool camel)
        {
            foreach (var method in methodToBeReflected)
            {
                if (methodToCheck.GenericString == method.GenericString) continue; // bypass this method

                var testName = method.MethodName(classDefinitions, false, camel);
                testName = testName.Contains(SpecialNames.BeginGenericDeclaration) ? testName.Substring(0, testName.IndexOf(SpecialNames.BeginGenericDeclaration)) : testName;
                if (entry == testName)
                {
                    return true;
                }
            }
            return false;
        }

        public static Class JVMClass(this string entry, bool throwOnError = false)
        {
            try
            {
                return Class.ForName(entry, true, SystemClassLoader);
            }
            catch
            {
                if (throwOnError) throw;
                return null;
            }
        }

        static bool IsJVMListenerClassAvoidJavaFile(this string typeName)
        {
            if (JNetReflectorCore.ClassesToAvoidJavaListener != null && JNetReflectorCore.ClassesToAvoidJavaListener.Any((o) => typeName == o)) return true;
            return false;
        }

        static bool IsJVMListenerClass(this string typeName)
        {
            if (typeName.StartsWith(SpecialNames.JavaUtilFunctions)) return true;
            if (typeName.EndsWith(SpecialNames.JavaLangListener)) return true;
            if (typeName.EndsWith(SpecialNames.JavaLangAdapter)) return true;
            if (JNetReflectorCore.ClassesToBeListener != null && JNetReflectorCore.ClassesToBeListener.Any((o) => typeName == o)) return true;
            return false;
        }

        public static string JVMNestedClassName(this string entry)
        {
            return entry.Substring(entry.LastIndexOf(SpecialNames.NestedClassSeparator) + 1);
        }

        public static string JVMSimpleClassName(this string entry)
        {
            var cName = entry.Remove(0, entry.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
            cName = cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
            return cName;
        }

        public static string Namespace(string fullName, bool camel)
        {
            if (fullName.EndsWith(SpecialNames.ClassExtension))
            {
                fullName = fullName.Remove(fullName.IndexOf(SpecialNames.ClassExtension));
            }
            var package = fullName.Contains(SpecialNames.NamespaceSeparator) ? fullName.Substring(0, fullName.LastIndexOf(SpecialNames.NamespaceSeparator)) : fullName;
            if (JNetReflectorCore.NamespacesInConflict != null)
            {
                foreach (var nsc in JNetReflectorCore.NamespacesInConflict)
                {
                    if (package.StartsWith(nsc))
                    {
                        package = package.Replace(nsc, nsc + SpecialNames.NamespaceSuffix);
                        break;
                    }
                }
            }
            var splitted = package.Split(SpecialNames.NamespaceSeparator);
            var ns = string.Join(SpecialNames.NamespaceSeparator.ToString(), splitted.Select((o) => camel ? Camel(o) : o));
            return ns;
        }

        public static string Camel(this string str)
        {
            if (str.Length == 0 || str.Length == 1) return str;
            else return char.ToUpper(str[0]) + str.Substring(1);
        }

        static string ToFullQualifiedClassName(string canonicalName, bool camel)
        {
            if (canonicalName.Contains(SpecialNames.NamespaceSeparator))
            {
                string className = canonicalName.Substring(canonicalName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
                className = Namespace(canonicalName, camel) + SpecialNames.NamespaceSeparator + className.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);
                return className;
            }
            else
            {
                return canonicalName.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);
            }
        }

        static string ToFullQualifiedInterfaceName(string canonicalName, bool camel)
        {
            string nsStr = string.Empty;
            string className = string.Empty;
            if (canonicalName.Contains(SpecialNames.BeginGenericDeclaration))
            {
                var generic = canonicalName.Substring(canonicalName.IndexOf(SpecialNames.BeginGenericDeclaration));
                var baseClass = canonicalName.Substring(0, canonicalName.IndexOf(generic));
                if (baseClass.Contains(SpecialNames.NamespaceSeparator))
                {
                    className = baseClass.Substring(baseClass.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
                    nsStr = baseClass.Substring(0, baseClass.LastIndexOf(SpecialNames.NamespaceSeparator));
                }
                else
                {
                    className = baseClass;
                }
                className += generic;
            }
            else
            {
                if (canonicalName.Contains(SpecialNames.NamespaceSeparator))
                {
                    className = canonicalName.Substring(canonicalName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
                    nsStr = canonicalName.Substring(0, canonicalName.LastIndexOf(SpecialNames.NamespaceSeparator));
                }
                else
                {
                    className = canonicalName;
                }
            }

            return string.IsNullOrWhiteSpace(nsStr) ? "I" + className : nsStr + SpecialNames.NamespaceSeparator + "I" + className;
        }

        static string ConvertClassesInConflict(this string fName)
        {
            string nName = string.Empty;
            string cName = string.Empty;
            if (fName.Contains(SpecialNames.NamespaceSeparator))
            {
                var index = fName.LastIndexOf(SpecialNames.NamespaceSeparator);
                nName = fName.Substring(0, index);
                cName = fName.Substring(index + 1);
            }
            else
            {
                cName = fName;
            }
            if (JNetReflectorCore.ClassesInConflict != null)
            {
                foreach (var cic in JNetReflectorCore.ClassesInConflict)
                {
                    if (cName == cic)
                    {
                        cName += "Class";
                        break;
                    }
                }
            }
            return string.IsNullOrEmpty(nName) ? cName : nName + SpecialNames.NamespaceSeparator + cName;
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
                if (i > 0 && i != pieces.Length - 1 && pieces[i - 1].Length != 0 && pieces[i].Length == 0) sb.Append(Environment.NewLine);
                else if (i == pieces.Length - 1 && pieces[i].Length != 0) sb.Append(tabber + pieces[i]);
                else if (i == pieces.Length - 1 && pieces[i].Length == 0) sb.Append(pieces[i]);
                else sb.AppendLine(tabber + pieces[i]);
            }
            return sb.ToString();
        }

        public static string ConvertToJavadoc(this string result)
        {
            if (result.EndsWith(SpecialNames.JavaLangAnyType)) result = result.Substring(0, result.IndexOf(SpecialNames.JavaLangAnyType));
            if (result.EndsWith(", new()")) result = result.Substring(0, result.IndexOf(", new()"));
            if (result.Contains(SpecialNames.ArrayTypeTrailer)) result = result.Substring(0, result.IndexOf(SpecialNames.ArrayTypeTrailer));
            return result.Replace(SpecialNames.BeginGenericDeclaration, "{").Replace(SpecialNames.EndGenericDeclaration, "}");
        }

        #endregion

        #region ZipArchiveEntry extension

        public static bool IsSpecialFolder(this ZipArchiveEntry entry)
        {
            var name = entry.FullName.ToLowerInvariant();
            if (name.Contains(FileNameAndDirectory.METAINF.ToLowerInvariant())
                || (JNetReflectorCore.NamespacesToAvoid != null && JNetReflectorCore.NamespacesToAvoid.Any((n) => entry.Namespace(false).StartsWith(n))))
            {
                return true;
            }
            return false;
        }

        public static bool IsSpecialClass(this ZipArchiveEntry entry)
        {
            if (entry.Name.EndsWith(SpecialNames.NestedClassSeparator.ToString()) // special class defined from Scala conversion
                || (entry.IsJVMNestedClass()
                    && SpecialNames.SpecialNumberedNames.Any((o) => entry.JVMNestedClassName().StartsWith(o)))
                ) return true;
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

        public static string Namespace(this ZipArchiveEntry entry, bool camel)
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
            var cName = entry.FullName;
            cName = cName.Contains(SpecialNames.ClassExtension) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.ClassExtension)) : cName;
            return cName.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator);
        }

        public static Class JVMClass(this ZipArchiveEntry entry)
        {
            try
            {
                var cName = entry.JVMFullQualifiedClassName();
                return Class.ForName(cName, true, SystemClassLoader);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region TypeVariable[] extension

        public static void GetGenerics(this Java.Lang.Reflect.TypeVariable[] entries, IList<string> genArguments, IList<KeyValuePair<string, string>> genClauses, string prefix, bool reportNative, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            mustBeAvoided = false;
            foreach (var entry in entries)
            {
                List<string> genArgumentsLocal = new List<string>();
                List<KeyValuePair<string, string>> genClauseLocal = new List<KeyValuePair<string, string>>();
                entry.GetGenerics(genArgumentsLocal, genClauseLocal, prefix, reportNative, usedInGenerics, camel, out var localMustBeAvoided);
                mustBeAvoided |= localMustBeAvoided;
                foreach (var item in genArgumentsLocal)
                {
                    if (genArguments != null && !genArguments.Contains(item))
                    {
                        genArguments?.Add(item);
                    }
                }
                foreach (var item in genClauseLocal)
                {
                    if (genClauses != null)
                    {
                        bool hasKey = false;
                        foreach (var genClause in genClauses)
                        {
                            if (genClause.Key == item.Key) { hasKey = true; break; }
                        }
                        if (!hasKey) genClauses?.Add(item);
                    }
                }
            }
        }

        static string ApplyGenerics(this TypeVariable[] entries, IList<KeyValuePair<string, string>> genClause, string prefix, string name, bool usedInGenerics, bool camel)
        {
            List<string> genArguments = new List<string>();
            entries.GetGenerics(genArguments, genClause, prefix, true, usedInGenerics, camel, out bool _);
            var parameters = genArguments.ConvertGenerics();
            if (!string.IsNullOrEmpty(parameters))
            {
                return $"{name}<{parameters}>";
            }
            return name;
        }

        public static string WhereClauses(this TypeVariable[] entry, bool usedInGenerics, bool camel)
        {
            StringBuilder sbWhere = new StringBuilder();
            foreach (var typeParameter in entry)
            {
                StringBuilder sbBounds = new StringBuilder();
                foreach (var bound in typeParameter.Bounds)
                {
                    if (!IsJVMNativeType(bound.TypeName))
                    {
                        string result = bound.GetBound(usedInGenerics, camel);
                        sbBounds.AppendFormat("{0}, ", result);
                    }
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

        public static string Namespace(this TypeVariable entry, bool camel)
        {
            var typeName = entry.Name;
            typeName = typeName.Contains(SpecialNames.BeginGenericDeclaration) ? typeName.Substring(0, typeName.IndexOf(SpecialNames.BeginGenericDeclaration)) : typeName;
            return Namespace(typeName, camel);
        }

        public static bool IsNamespaceToAvoid(this TypeVariable entry)
        {
            if (JNetReflectorCore.NamespacesToAvoid != null && JNetReflectorCore.NamespacesToAvoid.Any((n) => entry.Namespace(false).StartsWith(n))) return true;
            return false;
        }

        public static bool IsClassToAvoid(this TypeVariable entry)
        {
            var typeName = entry.Name;
            if (typeName.EndsWith(SpecialNames.ArrayTypeTrailer)) typeName = typeName.Remove(typeName.LastIndexOf(SpecialNames.ArrayTypeTrailer));
            typeName = typeName.Contains(SpecialNames.BeginGenericDeclaration) ? typeName.Substring(0, typeName.IndexOf(SpecialNames.BeginGenericDeclaration)) : typeName;
            if (JNetReflectorCore.ClassesToAvoid != null && JNetReflectorCore.ClassesToAvoid.Any((n) => typeName == n)) return true;
            return false;
        }

        #endregion

        #region Type extension

        public static bool TypeNameMustBeAvoided(this string typeName)
        {
            bool toBeAvoided = false;
            if (typeName.Contains(SpecialNames.BeginGenericDeclaration))
            {
                var clsName = typeName.Substring(0, typeName.IndexOf(SpecialNames.BeginGenericDeclaration));
                clsName = clsName.Contains(SpecialNames.ArrayTypeTrailer) ? clsName.Substring(0, clsName.IndexOf(SpecialNames.ArrayTypeTrailer)) : clsName;
                toBeAvoided = clsName.ClassTypeNameMustBeAvoided();
                if (!toBeAvoided)
                {
                    var genTypes = typeName.Substring(typeName.IndexOf(SpecialNames.BeginGenericDeclaration) + 1);
                    genTypes = genTypes.Substring(0, genTypes.LastIndexOf(SpecialNames.EndGenericDeclaration));
                    var types = genTypes.Split(',', ' ');
                    foreach (var type in types)
                    {
                        if (string.IsNullOrEmpty(type) || type == SpecialNames.JavaLangAnyType || type == "extends" || type == "super") continue;
                        toBeAvoided |= TypeNameMustBeAvoided(type.Trim());
                    }
                }
            }
            else
            {
                var clsName = typeName.Contains(SpecialNames.ArrayTypeTrailer) ? typeName.Substring(0, typeName.IndexOf(SpecialNames.ArrayTypeTrailer)) : typeName;
                toBeAvoided = clsName.ClassTypeNameMustBeAvoided();
            }
            return toBeAvoided;
        }

        public static int JVMNestingLevels(this Java.Lang.Reflect.Type type)
        {
            var result = type.TypeName.Split(SpecialNames.NestedClassSeparator);
            return result.Length - 1;
        }

        public static string JVMInterfaceName(this Java.Lang.Reflect.Type type, IList<KeyValuePair<string, string>> genClause, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            var tName = type.GetGenerics(null, genClause, string.Empty, true, usedInGenerics, camel, out mustBeAvoided);
            string genName = null;
            string nsName = null;
            string cName = tName;
            if (tName.Contains(SpecialNames.BeginGenericDeclaration))
            {
                genName = tName.Substring(tName.IndexOf(SpecialNames.BeginGenericDeclaration));
                cName = tName.Substring(0, tName.IndexOf(SpecialNames.BeginGenericDeclaration));
            }
            if (cName.Contains(SpecialNames.NamespaceSeparator))
            {
                nsName = cName.Substring(0, cName.LastIndexOf(SpecialNames.NamespaceSeparator));
                cName = cName.Substring(cName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
            }
            cName = "I" + cName;
            cName = genName != null ? cName + genName : cName;
            return nsName != null ? nsName + SpecialNames.NamespaceSeparator + cName : cName;
        }

        public static bool IsJVMListenerClass(this Java.Lang.Reflect.Type type)
        {
            return type.TypeName.IsJVMListenerClass();
        }

        public static string Type(this Java.Lang.Reflect.Type type, Class clazz, IList<string> genArguments, IList<KeyValuePair<string, string>> genClauses, string prefix, bool usedInGenerics, bool camel)
        {
            var retString = type.GetGenerics(genArguments, genClauses, prefix, true, usedInGenerics, camel, out bool _);
            if (clazz.IsJVMGenericClass() && genClauses != null)
            {
                List<string> classArguments = new List<string>();
                List<KeyValuePair<string, string>> classClauses = new List<KeyValuePair<string, string>>();
                clazz.GetGenerics(classArguments, classClauses, string.Empty, usedInGenerics, JNetReflectorCore.UseCamel);
                int classNeedsConstraints = 0;
                foreach (var classClause in classClauses)
                {
                    if (genClauses != null)
                    {
                        foreach (var genClause in genClauses)
                        {
                            if (classClause.Key == genClause.Key && !string.IsNullOrWhiteSpace(classClause.Value))
                            {
                                classNeedsConstraints++;
                            }
                        }
                    }
                    else if (!string.IsNullOrWhiteSpace(classClause.Value))
                    {
                        classNeedsConstraints++;
                    }
                }
                if (classNeedsConstraints > 0) // the return class have some constraint
                {
                    int genClausesConstraint = 0;
                    // check if genClauses has something in it near to the one expected from the class
                    foreach (var genClause in genClauses)
                    {
                        foreach (var classClause in classClauses)
                        {
                            if (classClause.Value != null && genClause.Value != null && classClause.Value == genClause.Value)
                            {
                                genClausesConstraint++; // found matched constraint
                            }
                        }
                    }
                    if (classNeedsConstraints != genClausesConstraint) // constraints does not match
                    {
                        genArguments.Clear();
                        genClauses.Clear();
                        return retString.Contains(SpecialNames.BeginGenericDeclaration) ? retString.Substring(0, retString.IndexOf(SpecialNames.BeginGenericDeclaration)) : retString;
                    }
                }
            }
            return retString;
        }

        static bool IsGenerics(this Java.Lang.Reflect.Type entry)
        {
            if (entry.IsInstanceOf<TypeVariable>())
            {
                return true;
            }
            else if (entry.IsInstanceOf<ParameterizedType>())
            {
                return true;
            }
            else if (entry.IsInstanceOf<GenericArrayType>())
            {
                return true;
            }
            else if (entry.IsInstanceOf<WildcardType>())
            {
                return true;
            }
            return false;
        }

        static string ApplyGenerics(this Java.Lang.Reflect.Type entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool reportNative, bool usedInGenerics, bool camel)
        {
            var retClass = entry.GetGenerics(genArguments, genClause, prefix, reportNative, usedInGenerics, camel, out bool _);
            return retClass;
        }

        static string ApplyGenerics(this Java.Lang.Reflect.Type[] entries, string prefix, bool reportNative, bool usedInGenerics, bool camel)
        {
            List<string> genArguments = new List<string>();
            List<KeyValuePair<string, string>> genClause = new List<KeyValuePair<string, string>>();
            entries.GetGenerics(genArguments, genClause, prefix, reportNative, usedInGenerics, camel, out bool _);
            var parameters = genArguments.ConvertGenerics();
            if (!string.IsNullOrEmpty(parameters))
            {
                return $"<{parameters}>";
            }
            return string.Empty;
        }

        public static string ApplyGenerics(this IEnumerable<string> entry)
        {
            var parameters = entry.ConvertGenerics();
            if (!string.IsNullOrEmpty(parameters))
            {
                return $"<{parameters}>";
            }
            return string.Empty;
        }

        static string ConvertGenerics(this IEnumerable<string> entry)
        {
            StringBuilder sb = new StringBuilder();
            if (entry != null)
            {
                foreach (var item in entry)
                {
                    sb.AppendFormat("{0}, ", item);
                }
            }
            var parameters = sb.ToString();
            if (!string.IsNullOrEmpty(parameters))
            {
                parameters = parameters.Substring(0, parameters.LastIndexOf(", "));
                return parameters;
            }
            return string.Empty;
        }

        public static string ConvertClauses(this IEnumerable<KeyValuePair<string, string>> entries, bool isGeneric)
        {
            if (JNetReflectorCore.AvoidCSharpGenericClauseDefinition || !isGeneric) return string.Empty;
            StringBuilder sbWhere = new StringBuilder();
            foreach (var clause in entries)
            {
                if (!string.IsNullOrEmpty(clause.Value)
                    && clause.Key != clause.Value) // this avoids circular clauses
                {
                    sbWhere.AppendFormat(" where {0}: {1}", clause.Key, clause.Value);
                }
            }
            var parameters = sbWhere.ToString();
            return parameters;
        }

        static void GetGenerics(this Java.Lang.Reflect.Type[] entries, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool reportNative, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            mustBeAvoided = false;
            foreach (var entry in entries)
            {
                entry.GetGenerics(genArguments, genClause, prefix, reportNative, usedInGenerics, camel, out var localMustBeAvoided);
                mustBeAvoided |= localMustBeAvoided;
            }
        }

        static string GetBound(this Java.Lang.Reflect.Type bound, bool usedInGenerics, bool camel)
        {
            var bClass = bound.TypeName.JVMClass();
            string result;
            if (bClass != null && bClass.IsInterface())
            {
                result = bClass.JVMInterfaceName(new List<KeyValuePair<string, string>>(), usedInGenerics, true) + ", new()"; // the new constraint means the type shall be a class implementing the interface
            }
            else
            {
                result = ToNetType(bound.TypeName, false, camel);
            }
            return result;
        }

        static string GetGenerics(this Java.Lang.Reflect.Type entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool reportNative, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            if (entry.IsInstanceOf<TypeVariable>())
            {
                return entry.CastTo<TypeVariable>().GetGenerics(genArguments, genClause, prefix, reportNative, usedInGenerics, camel, out mustBeAvoided);
            }
            else if (entry.IsInstanceOf<ParameterizedType>())
            {
                return entry.CastTo<ParameterizedType>().GetGenerics(genArguments, genClause, prefix, reportNative, usedInGenerics, camel, out mustBeAvoided);
            }
            else if (entry.IsInstanceOf<GenericArrayType>())
            {
                return entry.CastTo<GenericArrayType>().GetGenerics(genArguments, genClause, prefix, reportNative, usedInGenerics, camel, out mustBeAvoided);
            }
            else if (entry.IsInstanceOf<WildcardType>())
            {
                return entry.CastTo<WildcardType>().GetGenerics(genArguments, genClause, prefix, reportNative, usedInGenerics, camel, out mustBeAvoided);
            }
            mustBeAvoided = entry.TypeName.TypeNameMustBeAvoided();
            string retVal = string.Empty;
            if (reportNative)
            {
                if (IsVoid(entry.TypeName))
                {
                    return SpecialNames.JavaLangVoid;
                }
                else
                {
                    retVal = ToNetType(entry.TypeName, false, camel);
                }
            }
            return retVal;
        }

        static string GetGenerics(this GenericArrayType entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClauses, string prefix, bool reportNative, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            List<string> genArgumentsLocal = new List<string>();
            List<KeyValuePair<string, string>> genClauseLocal = new List<KeyValuePair<string, string>>();
            var result = entry.GenericComponentType.GetGenerics(genArgumentsLocal, genClauseLocal, prefix, reportNative, usedInGenerics, camel, out mustBeAvoided);
            foreach (var item in genArgumentsLocal)
            {
                if (genArguments != null && !genArguments.Contains(item))
                {
                    genArguments?.Add(item);
                }
            }
            foreach (var item in genClauseLocal)
            {
                if (genClauses != null)
                {
                    bool hasKey = false;
                    foreach (var genClause in genClauses)
                    {
                        if (genClause.Key == item.Key) { hasKey = true; break; }
                    }
                    if (!hasKey) genClauses?.Add(item);
                }
            }
            return result.EndsWith(SpecialNames.ArrayTypeTrailer) ? result : result + SpecialNames.ArrayTypeTrailer;
        }

        static string GetGenerics(this ParameterizedType entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool reportNative, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            List<string> types = new List<string>();
            List<string> genArgumentsLocal = new List<string>();
            List<KeyValuePair<string, string>> genClauseLocal = new List<KeyValuePair<string, string>>();
            bool constraintMismatch = false;
            var cName = entry.TypeName;
            cName = cName.Contains(SpecialNames.BeginGenericDeclaration) ? cName.Substring(0, cName.IndexOf(SpecialNames.BeginGenericDeclaration)) : cName;
            var cEntry = cName.JVMClass();
            mustBeAvoided = cEntry.MustBeAvoided();
            for (int i = 0; i < entry.ActualTypeArguments.Length; i++)
            {
                var actualType = entry.ActualTypeArguments[i];
                var actualTypeName = actualType.TypeName;
                var expectedType = cEntry.TypeParameters[i];
                var resType = actualType.GetGenerics(genArgumentsLocal, genClauseLocal, prefix, reportNative, usedInGenerics, camel, out var localMustBeAvoided);
                mustBeAvoided |= localMustBeAvoided;
                foreach (var bound in expectedType.Bounds)
                {
                    string result = bound.GetBound(usedInGenerics, camel);
                    if (actualTypeName == SpecialNames.JavaLangAnyType && !(result == SpecialNames.NetObject || result == (SpecialNames.NetObject + SpecialNames.ArrayTypeTrailer)
                                                  || result.Contains(SpecialNames.JavaLangAnyType))) // type used in Java to define any-type
                    {
                        constraintMismatch = true;
                    }
                }


                types.Add(resType);
            }
            var type = entry.ToNetType(camel);
            if (constraintMismatch || entry.IsClassToAvoidInGenerics())
            {
                return type;
            }
            foreach (var item in genArgumentsLocal)
            {
                genArguments?.Add(item);
            }
            foreach (var item in genClauseLocal)
            {
                genClause?.Add(item);
            }
            return type.StartsWith(SpecialNames.JavaLangClass) ? type : entry.ToNetType(camel) + types?.ApplyGenerics();
        }

        static string GetGenerics(this TypeVariable entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool reportNative, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            mustBeAvoided = false;
            genArguments?.Add(entry.Name);
            List<string> bounds = null;
            /*** this piece of code crashes the JVM
             
            if (entry.Bounds.Length != 0)
            {
                bounds = new List<string>();
                foreach (var bound in entry.Bounds)
                {
                    var result = bound.GetGenerics(null, null, null, true, camel);
                    if (!(result == "object" || result == "object[]")) bounds.Add(result);
                }
            }

            so try to limit it to the not generic value
            *****/

            if (entry.Bounds.Length != 0)
            {
                bounds = new List<string>();
                foreach (var bound in entry.Bounds)
                {
                    string result = bound.GetBound(usedInGenerics, camel);
                    if (!(result == SpecialNames.NetObject || result == (SpecialNames.NetObject + SpecialNames.ArrayTypeTrailer)
                        || result.Contains(SpecialNames.JavaLangAnyType))) // type used in Java to define any-type
                    {
                        bounds.Add(result);
                    }
                }
            }

            genClause?.Add(new KeyValuePair<string, string>(entry.Name, bounds?.ConvertGenerics()));
            return entry.Name;
        }

        static string GetGenerics(this WildcardType entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool reportNative, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            mustBeAvoided = false;
            string retVal = string.Empty;
            if (entry.LowerBounds.Length == 0)
            {
                for (int i = 0; i < entry.UpperBounds.Length; i++)
                {
                    List<string> innerGenArguments = new List<string>();
                    List<KeyValuePair<string, string>> innerGenClauses = new List<KeyValuePair<string, string>>();
                    var upper = GetGenerics(entry.UpperBounds[i], innerGenArguments, innerGenClauses, prefix, reportNative, usedInGenerics, camel, out var localMustBeAvoided);
                    mustBeAvoided |= localMustBeAvoided;
                    if (IsNetNativeType(upper))
                    {
                        retVal = upper;
                    }
                    else
                    {
                        upper = upper.EndsWith(SpecialNames.JavaLangAnyType) ? upper.Substring(0, upper.LastIndexOf(SpecialNames.JavaLangAnyType)) : upper;
                        var upperConverted = upper.Replace(SpecialNames.NamespaceSeparator, '_')
                                                  .Replace(", ", "_")
                                                  .Replace(",", "_")
                                                  .Replace(SpecialNames.BeginGenericDeclaration, "_")
                                                  .Replace(SpecialNames.EndGenericDeclaration, "_")
                                                  .Replace(SpecialNames.JavaLangAnyType, "_");
                        if (prefix == null)
                        {
                            retVal = upperConverted;
                        }
                        else
                        {
                            retVal = $"{prefix}Extends{upperConverted}";
                        }
                        genArguments?.Add(retVal);
                        genClause?.Add(new KeyValuePair<string, string>(retVal, IsNetNativeType(upper) ? null : upper));
                        if (entry.UpperBounds[i].IsInstanceOf<TypeVariable>())
                        {
                            if (genArguments != null && !genArguments.Contains(upper))
                            {
                                genArguments?.Add(upper);
                            }
                            if (genClause != null)
                            {
                                bool hasKey = false;
                                foreach (var item in genClause)
                                {
                                    if (item.Key == upper) { hasKey = true; break; }
                                }
                                if (!hasKey) genClause?.Add(new KeyValuePair<string, string>(upper, null));
                            }
                        }
                        if (!JNetReflectorCore.AvoidCSharpGenericClauseDefinition)
                        {
                            foreach (var item in innerGenArguments)
                            {
                                if (item != upper && genArguments != null && !genArguments.Contains(item))
                                {
                                    genArguments?.Add(item);
                                }
                            }
                            foreach (var item in innerGenClauses)
                            {
                                if (item.Key != upper && genClause != null && !genClause.ContainsClause(item))
                                {
                                    genClause?.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            else if (entry.LowerBounds.Length != 0 && entry.LowerBounds.Length == entry.UpperBounds.Length)
            {
                for (int i = 0; i < entry.LowerBounds.Length; i++)
                {
                    List<string> innerGenArguments = new List<string>();
                    List<KeyValuePair<string, string>> innerGenClauses = new List<KeyValuePair<string, string>>();
                    var upper = GetGenerics(entry.UpperBounds[i], null, null, prefix, reportNative, usedInGenerics, camel, out var upperMustBeAvoided);
                    mustBeAvoided |= upperMustBeAvoided;
                    upper = upper.EndsWith(SpecialNames.JavaLangAnyType) ? upper.Substring(0, upper.LastIndexOf(SpecialNames.JavaLangAnyType)) : upper;
                    var lower = GetGenerics(entry.LowerBounds[i], innerGenArguments, innerGenClauses, prefix, reportNative, usedInGenerics, camel, out var lowerMustBeAvoided);
                    mustBeAvoided |= lowerMustBeAvoided;
                    lower = lower.EndsWith(SpecialNames.JavaLangAnyType) ? lower.Substring(0, lower.LastIndexOf(SpecialNames.JavaLangAnyType)) : lower;

                    if (IsNetNativeType(lower))
                    {
                        retVal = lower;
                    }
                    else
                    {
                        var upperConverted = upper.Replace(SpecialNames.NamespaceSeparator, '_')
                                              .Replace(", ", "_")
                                              .Replace(",", "_")
                                              .Replace(SpecialNames.BeginGenericDeclaration, "_")
                                              .Replace(SpecialNames.EndGenericDeclaration, "_")
                                              .Replace(SpecialNames.JavaLangAnyType, "_");
                        var lowerConverted = lower.Replace(SpecialNames.NamespaceSeparator, '_')
                                                  .Replace(", ", "_")
                                                  .Replace(",", "_")
                                                  .Replace(SpecialNames.BeginGenericDeclaration, "_")
                                                  .Replace(SpecialNames.EndGenericDeclaration, "_")
                                                  .Replace(SpecialNames.JavaLangAnyType, "_");
                        if (prefix == null)
                        {
                            retVal = lowerConverted;
                        }
                        else
                        {
                            retVal = $"{prefix}{upperConverted}Super{lowerConverted}";
                        }
                        genArguments?.Add(retVal);
                        genClause?.Add(new KeyValuePair<string, string>(retVal, IsNetNativeType(lower) ? null : lower));
                        if (entry.LowerBounds[i].IsInstanceOf<TypeVariable>())
                        {
                            if (genArguments != null && !genArguments.Contains(lower))
                            {
                                genArguments?.Add(lower);
                            }
                            if (genClause != null)
                            {
                                bool hasKey = false;
                                foreach (var item in genClause)
                                {
                                    if (item.Key == lower) { hasKey = true; break; }
                                }
                                if (!hasKey) genClause?.Add(new KeyValuePair<string, string>(lower, null));
                            }
                        }
                        if (!JNetReflectorCore.AvoidCSharpGenericClauseDefinition)
                        {
                            foreach (var item in innerGenArguments)
                            {
                                if (item != upper && genArguments != null && !genArguments.Contains(item))
                                {
                                    genArguments?.Add(item);
                                }
                            }
                            foreach (var item in innerGenClauses)
                            {
                                if (item.Key != upper && genClause != null && !genClause.ContainsClause(item))
                                {
                                    genClause?.Add(item);
                                }
                            }
                        }
                    }
                }
            }
            else throw new NotImplementedException($"Condition for {entry.TypeName} not implemented yet.");
            return retVal;
        }

        static bool ContainsClause(this IList<KeyValuePair<string, string>> lst, KeyValuePair<string, string> matcher)
        {
            foreach (var item in lst)
            {
                if (item.Key == matcher.Key)
                {
                    if (string.IsNullOrWhiteSpace(item.Value) && string.IsNullOrWhiteSpace(matcher.Value)) return true;
                    return item.Value == matcher.Value;
                }
            }
            return false;
        }

        #endregion

        #region Class extension

        public static bool IsJVMListenerClassAvoidJavaFile(this Class entry)
        {
            return entry.TypeName.IsJVMListenerClassAvoidJavaFile();
        }

        public static bool IsJVMListenerClass(this Class entry)
        {
            return entry.TypeName.IsJVMListenerClass();
        }

        public static bool ImplementsJVMListenerClass(this Class entry)
        {
            if (!entry.IsInterface())
            {
                foreach (var item in entry.Interfaces)
                {
                    if (item.IsJVMListenerClass())
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool IsJVMNestedClass(this Class entry)
        {
            if (entry.TypeName.Contains(SpecialNames.NestedClassSeparator)) return true;
            return false;
        }

        public static int JVMNestingLevels(this Class entry)
        {
            var result = entry.TypeName.Split(SpecialNames.NestedClassSeparator);
            return result.Length - 1;
        }

        public static bool IsJVMClass(this Class entry)
        {
            if (!entry.TypeName.Contains(SpecialNames.NestedClassSeparator)) return true;
            return false;
        }

        public static string JVMClassName(this Class entry, IList<KeyValuePair<string, string>> genClause, bool usedInGenerics)
        {
            if (entry.IsJVMNestedClass()) return entry.JVMNestedClassName(entry.JVMNestingLevels(), genClause, usedInGenerics);
            var cName = entry.SimpleName;
            cName = cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
            cName = cName.ConvertClassesInConflict();
            if (usedInGenerics) cName = entry.ApplyGenerics(genClause, usedInGenerics, cName);
            return cName;
        }

        public static string JVMMainClassName(this Class entry)
        {
            var cName = entry.TypeName;
            return cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.IndexOf(SpecialNames.NestedClassSeparator)) : cName;
        }

        static string JVMNestedClassName(this Class entry, int nestingLevel, IList<KeyValuePair<string, string>> genClause, bool usedInGenerics, bool onlyName = false)
        {
            var cName = entry.TypeName;
            if (cName.Contains(SpecialNames.NestedClassSeparator))
            {
                var names = cName.Split(SpecialNames.NestedClassSeparator);
                cName = names[nestingLevel];
            }
            cName = cName.ConvertClassesInConflict();
            if (!onlyName) cName = entry.ApplyGenerics(genClause, usedInGenerics, cName);
            return cName;
        }

        public static string JVMSimpleClassName(this Class entry)
        {
            var cName = entry.TypeName;
            cName = cName.Contains(SpecialNames.NamespaceSeparator) ? cName.Remove(0, cName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1) : cName;
            return cName.Contains(SpecialNames.NestedClassSeparator) ? cName.Substring(0, cName.LastIndexOf(SpecialNames.NestedClassSeparator)) : cName;
        }

        public static void GetGenerics(this Class entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool usedInGenerics, bool camel)
        {
            if (!entry.IsJVMGenericClass()) return;
            entry.TypeParameters.GetGenerics(genArguments, genClause, prefix, true, usedInGenerics, camel, out bool _);
        }

        static string ApplyGenerics(this Class entry, IList<KeyValuePair<string, string>> genClause, bool usedInGenerics, string name)
        {
            if (!usedInGenerics || !entry.IsJVMGenericClass()) return name;
            return entry.TypeParameters.ApplyGenerics(genClause, null, name, usedInGenerics, true);
        }

        public static string WhereClauses(this Class entry, bool usedInGenerics, bool camel)
        {
            if (JNetReflectorCore.AvoidCSharpGenericClauseDefinition || !usedInGenerics || !entry.IsJVMGenericClass()) return string.Empty;
            StringBuilder sbWhere = new StringBuilder();
            foreach (var typeParameter in entry.TypeParameters)
            {
                StringBuilder sbBounds = new StringBuilder();
                foreach (var bound in typeParameter.Bounds)
                {
                    if (!IsJVMNativeType(bound.TypeName))
                    {
                        string result;
                        if (entry.TypeName == bound.TypeName && entry.IsJVMGenericClass() && usedInGenerics)
                        {
                            // force the generic class in this case
                            result = entry.ToFullQualifiedClassName(usedInGenerics, camel);
                        }
                        else
                        {
                            result = bound.GetBound(usedInGenerics, camel);
                        }
                        sbBounds.AppendFormat("{0}, ", result);
                    }
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

        public static string JVMFullClassName(this Class entry)
        {
            var name = entry.TypeName;
            return name.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator);
        }

        public static string ToFullQualifiedClassName(this Class cls, bool usedInGenerics, bool camel)
        {
            var cName = cls.TypeName;
            cName = ToFullQualifiedClassName(cName, camel);
            if (usedInGenerics) cName = cls.ApplyGenerics(null, usedInGenerics, cName);
            return cName;
        }

        public static bool NeedsOperators(this Class entry, bool usedInGenerics)
        {
            if (entry.IsJVMListenerClass()) return true;
            try
            {
                var superCls = entry.SuperClass;
                if (superCls != null && SpecialNames.IsJavaLangException(superCls.TypeName))
                {
                    return true;
                }
                else if (superCls == null
                    || !superCls.IsPublic()
                    || (JNetReflectorCore.ReflectDeprecated ? false : superCls.IsDeprecated())
                    || superCls.MustBeAvoided()
                    || superCls.TypeName == SpecialNames.JavaLangObject)
                {
                    if ((superCls == null || superCls.TypeName == SpecialNames.JavaLangObject) && entry.ContainsIterable())
                    {
                        return true;
                    }
                    else if ((superCls == null || superCls.TypeName == SpecialNames.JavaLangObject) && entry.ContainsIterator())
                    {
                        return true;
                    }
                    // if there is single super interface use it as superclass, it will be avoided in operators
                    else if (entry.IsInterface() && entry.Interfaces.Length == 1 && !entry.Interfaces[0].MustBeAvoided())
                    {
                        return false;
                    }
                    // if there is single super interface which isn't a listener use it as superclass, it will be avoided in operators
                    else if (entry.Interfaces.Length == 1 && !entry.Interfaces[0].MustBeAvoided() && !entry.ImplementsJVMListenerClass())
                    {
                        return false;
                    }
                    else if (entry.Interfaces.Length == 1 && entry.Interfaces[0].IsCollection())
                    {
                        // if there is single super interface java.util.Collection use it as superclass, it will be avoided in operators
                        return false;
                    }
                    else if (entry.Interfaces.Length == 1 && entry.Interfaces[0].IsEventListener())
                    {
                        // if there is single super interface java.util.EventListener use it as superclass, it will be avoided in operators
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else if (usedInGenerics && superCls.IsJVMGenericClass())
                {
                    return true;
                }
                return true;
            }
            catch
            {
                return true;
            }
        }

        public static bool HasJVMBaseClassName(this Class entry, bool usedInGenerics, bool isListener, bool camel)
        {
            if (isListener)
            {
                return false;
            }
            try
            {
                var superCls = entry.SuperClass;
                if (superCls != null && SpecialNames.IsJavaLangException(superCls.TypeName))
                {
                    return false;
                }
                else if (superCls == null
                    || !superCls.IsPublic()
                    || (JNetReflectorCore.ReflectDeprecated ? false : superCls.IsDeprecated())
                    || superCls.MustBeAvoided()
                    || superCls.TypeName == SpecialNames.JavaLangObject)
                {
                    if ((superCls == null || superCls.TypeName == SpecialNames.JavaLangObject) && entry.ContainsIterable())
                    {
                        return false;
                    }
                    else if ((superCls == null || superCls.TypeName == SpecialNames.JavaLangObject) && entry.ContainsIterator())
                    {
                        return false;
                    }
                    // if there is single super interface use it as superclass, it will be avoided in operators
                    else if (entry.IsInterface() && entry.Interfaces.Length == 1 && !entry.Interfaces[0].MustBeAvoided())
                    {
                        return true;
                    }
                    // if there is single super interface which isn't a listener use it as superclass, it will be avoided in operators
                    else if (entry.Interfaces.Length == 1 && !entry.Interfaces[0].MustBeAvoided() && !entry.ImplementsJVMListenerClass())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if ((usedInGenerics || !entry.IsJVMGenericClass()) && superCls.IsJVMGenericClass())
                {
                    return true;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static string JVMBaseClassName(this Class entry, bool usedInGenerics, bool isListener, bool camel)
        {
            if (isListener)
            {
                if (entry.ContainsEventListener())
                {
                    return "Java.Util.EventListener";
                }
                return "MASES.JCOBridge.C2JBridge.JVMBridgeListener";
            }
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
                        string innerName = string.Empty;
                        if (usedInGenerics || (!usedInGenerics && !entry.IsJVMGenericClass()))
                        {
                            foreach (var genInterface in entry.GenericInterfaces)
                            {
                                if (genInterface.IsIterable())
                                {
                                    List<string> genArguments = new List<string>();
                                    var genInt = genInterface.GetGenerics(genArguments, null, string.Empty, true, usedInGenerics, camel, out bool _);
                                    innerName = genInt.Substring(genInt.IndexOf(SpecialNames.BeginGenericDeclaration));
                                    break;
                                }
                            }
                        }
                        return string.Format("Java.Lang.Iterable{0}", innerName);
                    }
                    else if ((superCls == null || superCls.TypeName == SpecialNames.JavaLangObject) && entry.ContainsIterator())
                    {
                        string innerName = string.Empty;
                        if (usedInGenerics || (!usedInGenerics && !entry.IsJVMGenericClass()))
                        {
                            foreach (var genInterface in entry.GenericInterfaces)
                            {
                                if (genInterface.IsIterator())
                                {
                                    List<string> genArguments = new List<string>();
                                    var genInt = genInterface.GetGenerics(genArguments, null, string.Empty, true, usedInGenerics, camel, out bool _);
                                    innerName = genInt.Substring(genInt.IndexOf(SpecialNames.BeginGenericDeclaration));
                                    break;
                                }
                            }
                        }
                        return string.Format("Java.Util.Iterator{0}", innerName);
                    }
                    // if there is single super interface use it as superclass, it will be avoided in operators
                    else if (entry.IsInterface() && entry.Interfaces.Length == 1 && !entry.Interfaces[0].MustBeAvoided())
                    {
                        if ((usedInGenerics && entry.Interfaces[0].IsJVMGenericClass())
                            || (!usedInGenerics && !entry.IsJVMGenericClass() && entry.Interfaces[0].IsJVMGenericClass()))
                        {
                            return entry.GenericInterfaces[0].ApplyGenerics(null, null, null, true, usedInGenerics, camel);
                        }

                        return ToFullQualifiedClassName(entry.Interfaces[0], false, camel);
                    }
                    // if there is single super interface which isn't a listener use it as superclass, it will be avoided in operators
                    else if (entry.Interfaces.Length == 1 && !entry.Interfaces[0].MustBeAvoided() && !entry.ImplementsJVMListenerClass())
                    {
                        if ((usedInGenerics && entry.Interfaces[0].IsJVMGenericClass())
                            || (!usedInGenerics && !entry.IsJVMGenericClass() && entry.Interfaces[0].IsJVMGenericClass()))
                        {
                            return entry.GenericInterfaces[0].ApplyGenerics(null, null, null, true, usedInGenerics, camel);
                        }

                        return ToFullQualifiedClassName(entry.Interfaces[0], false, camel);
                    }
                    else
                    {
                        string innerName = entry.JVMClassName(null, usedInGenerics);
                        return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeBase<{0}>", innerName);
                    }
                }
                else if ((usedInGenerics || !entry.IsJVMGenericClass()) && superCls.IsJVMGenericClass())
                {
                    return entry.GenericSuperClass.ApplyGenerics(null, null, null, true, usedInGenerics, camel);
                }
                return ToFullQualifiedClassName(superCls, false, camel);
            }
            catch
            {
                string className = entry.JVMClassName(null, usedInGenerics);
                return string.Format("MASES.JCOBridge.C2JBridge.JVMBridgeBase<{0}>", className);
            }
        }

        public static string JVMBaseInterfaceName(this Class entry, bool usedInGenerics, bool isListener, bool camel)
        {
            if (!entry.HasJVMBaseClassName(usedInGenerics, isListener, camel)) return string.Empty;

            var fName = entry.JVMBaseClassName(usedInGenerics, isListener, camel);
            return ToFullQualifiedInterfaceName(fName, camel);
        }

        public static string JVMInterfaceName(this Class entry, IList<KeyValuePair<string, string>> genClause, bool usedInGenerics, bool fullyQualified)
        {
            var cName = entry.JVMClassName(genClause, usedInGenerics);
            cName = "I" + cName;
            if (fullyQualified)
            {
                var nName = entry.Namespace(JNetReflectorCore.UseCamel);
                return string.IsNullOrWhiteSpace(nName) ? cName : nName + SpecialNames.NamespaceSeparator + cName;
            }
            else return cName;
        }

        public static IEnumerable<Class> JVMInterfaces(this Class entry, bool usedInGenerics)
        {
            List<Class> filteredInterfaces = new List<Class>();

            foreach (var implementedInterface in entry.Interfaces)
            {
                if (implementedInterface.MustBeAvoided()) continue;
                var superCls = entry.SuperClass;
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

            return filteredInterfaces;
        }

        public static IEnumerable<string> JVMGenericInterfaces(this Class entry, bool usedInGenerics, bool camel)
        {
            List<string> filteredInterfaces = new List<string>();

            if (entry.GenericInterfaces.Length != 1) // a single interface will be the base class
            {
                foreach (var implementedInterface in entry.GenericInterfaces)
                {
                    if (implementedInterface.JVMNestingLevels() != 0) continue;
                    var str = implementedInterface.JVMInterfaceName(new List<KeyValuePair<string, string>>(), usedInGenerics, camel, out var mustBeAvoided);
                    if (mustBeAvoided) continue;
                    var superCls = entry.SuperClass;
                    if (superCls == null
                        || !superCls.IsPublic()
                        || (JNetReflectorCore.ReflectDeprecated ? false : superCls.IsDeprecated())
                        || superCls.MustBeAvoided()
                        || superCls.TypeName == SpecialNames.JavaLangObject)
                    {
                        filteredInterfaces.Add(str);
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
                        if (!foundInSuperClass) filteredInterfaces.Add(str);
                    }
                }
            }
            return filteredInterfaces;
        }

        public static bool IsNamespaceToAvoid(this string typeName)
        {
            if (JNetReflectorCore.NamespacesToAvoid != null && JNetReflectorCore.NamespacesToAvoid.Any((n) => Namespace(typeName, false).StartsWith(n))) return true;
            return false;
        }

        public static bool IsNamespaceToAvoid(this Class entry)
        {
            return entry.TypeName.IsNamespaceToAvoid();
        }

        public static bool IsClassToAvoid(this string typeName)
        {
            if (typeName.EndsWith(SpecialNames.ArrayTypeTrailer)) typeName = typeName.Remove(typeName.LastIndexOf(SpecialNames.ArrayTypeTrailer));
            if (JNetReflectorCore.ClassesToAvoid != null && JNetReflectorCore.ClassesToAvoid.Any((n) => typeName == n)) return true;
            return false;
        }

        public static bool IsClassToAvoid(this Class entry)
        {
            return IsClassToAvoid(entry.TypeName);
        }

        public static bool IsClassToAvoidInGenerics(this Class entry)
        {
            var typeName = entry.TypeName;
            if (typeName.EndsWith(SpecialNames.ArrayTypeTrailer)) typeName = typeName.Remove(typeName.LastIndexOf(SpecialNames.ArrayTypeTrailer));
            if (JNetReflectorCore.ClassesToAvoidInGenerics != null && JNetReflectorCore.ClassesToAvoidInGenerics.Any((n) => typeName == n)) return true;
            return false;
        }

        public static bool IsClassToAvoidInGenerics(this Java.Lang.Reflect.Type entry)
        {
            var typeName = entry.TypeName;
            if (typeName.EndsWith(SpecialNames.ArrayTypeTrailer)) typeName = typeName.Remove(typeName.LastIndexOf(SpecialNames.ArrayTypeTrailer));
            if (typeName.Contains(SpecialNames.BeginGenericDeclaration)) typeName = typeName.Substring(0, typeName.IndexOf(SpecialNames.BeginGenericDeclaration));
            if (JNetReflectorCore.ClassesToAvoidInGenerics != null && JNetReflectorCore.ClassesToAvoidInGenerics.Any((n) => typeName == n)) return true;
            return false;
        }

        public static bool IsSpecialClass(this Class entry)
        {
            if (!entry.IsJVMNestedClass()) return false;

            if (entry.Name.EndsWith(SpecialNames.NestedClassSeparator.ToString()))
            {
                // special class defined from Scala conversion
                return true;
            }

            string className = entry.JVMNestedClassName(entry.JVMNestingLevels(), null, true);

            if (entry.IsJVMNestedClass()
                && SpecialNames.SpecialNumberedNames.Any((o) => className.StartsWith(o))) return true;
            return false;
        }

        public static string Namespace(this Class entry, bool camel)
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

        public static bool IsCollection(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (entry.TypeName.StartsWith(SpecialNames.JavaUtilCollection)) // direct name is Collection
            {
                return true;
            }
            return false;
        }

        public static bool IsIterable(this Java.Lang.Reflect.Type entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (entry.TypeName.StartsWith(SpecialNames.JavaLangIterable)) // direct name is Iterabale
            {
                return true;
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
            foreach (var item in entry.Interfaces) // or implemented interfaces contains Iterabale
            {
                if (item.IsIterable())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsIterator(this Java.Lang.Reflect.Type entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (entry.TypeName.StartsWith(SpecialNames.JavaUtilIterator)) // direct name is Iterabale
            {
                return true;
            }
            return false;
        }

        public static bool IsIterator(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (entry.TypeName.StartsWith(SpecialNames.JavaUtilIterator)) // direct name is Iterator
            {
                return true;
            }
            return false;
        }

        public static bool ContainsIterator(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var item in entry.Interfaces) // or implemented interfaces contains Iterator
            {
                if (item.IsIterator())
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsEventListener(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (entry.TypeName.StartsWith(SpecialNames.JavaUtilEventListener)) // direct name is EventListener
            {
                return true;
            }
            return false;
        }

        public static bool ContainsEventListener(this Class entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            foreach (var item in entry.Interfaces) // or implemented interfaces contains java.util.EventListener
            {
                if (item.IsEventListener())
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

        public static bool IsJNetInternalOrManuallyDeveloped(this Class entry)
        {
            string tName = entry.TypeName;

            if (tName == SpecialNames.JavaLangIterable
                || tName == SpecialNames.JavaUtilIterator) return true;

            if (JNetReflectorCore.ClassesManuallyDeveloped != null && JNetReflectorCore.ClassesManuallyDeveloped.Any((o) => tName == o)) return true;

            return false;
        }

        public static bool ClassTypeNameMustBeAvoided(this string typeName)
        {
            bool toBeAvoided = false;
            if (typeName == null) toBeAvoided = false;
            if (IsJVMNativeType(typeName)) toBeAvoided = false;
            if (typeName.Contains(SpecialNames.NamespaceSeparator))
            {
                if (typeName.IsNamespaceToAvoid()) toBeAvoided = true;
                if (typeName.IsClassToAvoid()) toBeAvoided = true;
            }

            return toBeAvoided;
        }

        public static bool MustBeAvoided(this Class entry)
        {
            bool toBeAvoided = false;
            if (entry == null) toBeAvoided = false;
            if (!entry.IsPublic()) toBeAvoided = true;
            if (!JNetReflectorCore.ReflectDeprecated && entry.IsDeprecated()) toBeAvoided = true;
            if (!toBeAvoided) toBeAvoided |= entry.TypeName.ClassTypeNameMustBeAvoided();
            if (!toBeAvoided && entry.IsJVMGenericClass()) // test inner types
            {
                foreach (var item in entry.TypeParameters)
                {
                    item.GetGenerics(null, null, string.Empty, true, true, false, out bool localMustBeAvoided);
                    toBeAvoided |= localMustBeAvoided;

                    //if (item.Name.Contains(SpecialNames.NamespaceSeparator))
                    //{
                    //    if (item.IsNamespaceToAvoid()) toBeAvoided = true;
                    //    if (item.IsClassToAvoid()) toBeAvoided = true;
                    //    if (toBeAvoided) break;
                    //}
                }
            }

            return toBeAvoided;
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

        public static bool IsNetNativeType(this string typeName)
        {
            if (typeName == null) throw new ArgumentNullException(nameof(typeName));
            if (typeName.EndsWith(SpecialNames.ArrayTypeTrailer)) return IsNetNativeType(typeName.Remove(typeName.LastIndexOf(SpecialNames.ArrayTypeTrailer)));

            switch (typeName)
            {
                case "void":
                case "bool":
                case "bool?":
                case "byte":
                case "byte?":
                case "char":
                case "char?":
                case "short":
                case "short?":
                case "int":
                case "int?":
                case "long":
                case "long?":
                case "float":
                case "float?":
                case "double":
                case "double?":
                case "string":
                case "object":
                    return true;
                default:
                    return false;
            }
        }

        public static bool IsJVMNativeType(this Class type)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            return IsJVMNativeType(type.TypeName);
        }

        static bool IsJVMNativeType(string typeName)
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

        public static string ToNetType(this Java.Lang.Reflect.Type type, bool camel)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            var cName = type.TypeName;
            cName = cName.Contains(SpecialNames.BeginGenericDeclaration) ? cName.Substring(0, cName.IndexOf(SpecialNames.BeginGenericDeclaration)) : cName;
            cName = ToNetType(cName, false, camel);
            return cName;
        }

        public static string ToNetType(this Class type, bool camel)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));
            var cName = type.TypeName;
            cName = cName.Contains(SpecialNames.BeginGenericDeclaration) ? cName.Substring(0, cName.IndexOf(SpecialNames.BeginGenericDeclaration)) : cName;
            cName = ToNetType(cName, false, camel);
            return cName;
        }

        static string ToNetType(string typeName, bool isFromArray, bool camel)
        {
            if (typeName.EndsWith(SpecialNames.ArrayTypeTrailer)) return ToNetType(typeName.Remove(typeName.LastIndexOf(SpecialNames.ArrayTypeTrailer)), true, camel) + SpecialNames.ArrayTypeTrailer;

            if (JNetReflectorCore.UseDotNetNullable)
            {
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
                        {
                            var fName = ToFullQualifiedClassName(typeName, camel);
                            return fName.ConvertClassesInConflict();
                        }
                }
            }
            else
            {
                switch (typeName)
                {
                    case "void":
                    case "java.lang.Void":
                        return "void";
                    case "boolean":
                        return "bool";
                    case "byte":
                        return "byte";
                    case "char":
                        return "char";
                    case "short":
                        return "short";
                    case "int":
                        return "int";
                    case "long":
                        return "long";
                    case "float":
                        return "float";
                    case "double":
                        return "double";
                    case "java.lang.String":
                        return "string";
                    case "java.lang.Object":
                        return "object";
                    default:
                        {
                            var fName = ToFullQualifiedClassName(typeName, camel);
                            return fName.ConvertClassesInConflict();
                        }
                }
            }
        }

        public static string JavadocUrl(this Class entry, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));

            var newURl = _CurrentJavadocBaseUrl;
            if (newURl != null)
            {
                if (!newURl.EndsWith("/"))
                    newURl += '/';

                if (_CurrentJavadocVersion > 9)
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
                        if (!string.IsNullOrEmpty(name) && !name.StartsWith("unnamed"))
                        {
                            name = name.Remove(0, "module ".Length);
                            newURl += name + "/";
                        }
                    }
                }

                newURl += entry.TypeName.Replace('.', '/').Replace('$', '.') + ".html";

                return newURl;
            }

            return entry.ToNetType(camel);
        }

        public static string JavadocHrefUrl(this Class entry, bool camel)
        {
            return string.Format(AllPackageClasses.DocTemplate(_CurrentJavadocBaseUrl), JavadocUrl(entry, camel).Replace(SpecialNames.BeginGenericDeclaration, "%3C").Replace(SpecialNames.EndGenericDeclaration, "%3E"));
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

        public static string Name(this Constructor entry, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var constructorName = entry.Name;
            if (constructorName.Contains(SpecialNames.NamespaceSeparator)) constructorName = constructorName.Substring(constructorName.LastIndexOf(SpecialNames.NamespaceSeparator) + 1);
            return constructorName.Contains(SpecialNames.NestedClassSeparator) ? constructorName.Remove(0, constructorName.LastIndexOf(SpecialNames.NestedClassSeparator) + 1) : constructorName;
        }

        public static string JavadocUrl(this Constructor entry, bool camel)
        {
            var newURl = entry.DeclaringClass.JavadocUrl(camel);
            if (_CurrentJavadocBaseUrl != null)
            {
                var genString = entry.GenericString;
                genString = entry.Name + "(";
                foreach (var item in entry.Parameters)
                {
                    var typeName = item.Type.TypeName;
                    typeName = typeName.Contains(SpecialNames.BeginGenericDeclaration) ? typeName.Substring(0, typeName.IndexOf(SpecialNames.BeginGenericDeclaration)) : typeName;
                    typeName = typeName.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);
                    genString += typeName + ",";
                }
                genString = genString.EndsWith(",") ? genString.Substring(0, genString.LastIndexOf(",")) : genString;
                genString += ")";

                if (genString.Contains("throws")) genString = genString.Substring(0, genString.IndexOf("throws") - 1);
                if (_CurrentJavadocVersion > 9)
                {
                    genString = genString.StartsWith(entry.Name) ? genString.Substring(entry.Name.Length) : genString.Substring(genString.IndexOf(entry.Name) + entry.Name.Length);
                    genString = "<init>" + genString;
                }
                else if (!genString.StartsWith(entry.Name))
                {
                    genString = genString.Substring(genString.IndexOf(entry.Name));
                }

                if (_CurrentJavadocVersion < 7)
                {
                    genString = genString.Replace(",", ", ");
                }

                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name(camel);
        }

        public static string JavadocHrefUrl(this Constructor entry, bool camel)
        {
            return string.Format(AllPackageClasses.DocTemplate(_CurrentJavadocBaseUrl), JavadocUrl(entry, camel).Replace(SpecialNames.BeginGenericDeclaration, "%3C").Replace(SpecialNames.EndGenericDeclaration, "%3E"));
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
            if (name.StartsWith("get") && name.Length > 3 && entry.ParameterCount == 0 && !entry.ReturnType.IsVoid()) return true;
            else if (!JNetReflectorCore.OnlyPropertiesForGetterSetter)
            {
                if (entry.ParameterCount == 0 && !entry.ReturnType.IsVoid()) return true;
            }
            return false;
        }

        public static bool IsSetProperty(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var name = entry.Name;
            if (name.StartsWith("set") && name.Length > 3 && entry.ParameterCount == 1 && entry.ReturnType.IsVoid()) return true;
            else if (!JNetReflectorCore.OnlyPropertiesForGetterSetter)
            {
                if (entry.ParameterCount == 1 && entry.ReturnType.IsVoid()) return true;
            }
            return false;
        }

        public static bool IsProperty(this Method entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (entry.IsGetProperty() || entry.IsSetProperty())
            {
                var name = entry.Name;
                if (SpecialNames.ReservedPropertyNames.Any((n) => name.Equals(n))) return false;
                return true;
            }
            return false;
        }

        public static void GetGenerics(this Method entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool reportNative, bool usedInGenerics, bool camel, out bool mustBeAvoided)
        {
            entry.GenericParameterTypes.GetGenerics(genArguments, genClause, prefix, reportNative, usedInGenerics, camel, out mustBeAvoided);
        }

        public static string WhereClauses(this Method entry, bool usedInGenerics, bool camel)
        {
            if (!usedInGenerics) return string.Empty;
            return entry.TypeParameters.WhereClauses(usedInGenerics, camel);
        }

        public static string Name(this Method entry, IEnumerable<Class> classDefinitions, IList<string> genArguments, IList<KeyValuePair<string, string>> genClause, string prefix, bool usedInGenerics, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var methodName = entry.Name;
            if (classDefinitions != null)
            {
                foreach (var classDefinition in classDefinitions)
                {
                    if (classDefinition.JVMSimpleClassName() == entry.Name(null, null, null, string.Empty, false, camel))
                    {
                        methodName += SpecialNames.MethodSuffix;
                        break;
                    }
                }
            }
            if (usedInGenerics)
            {
                entry.GetGenerics(genArguments, genClause, prefix, false, usedInGenerics, camel, out bool _);
                methodName += genArguments.ApplyGenerics();
            }
            return camel ? Camel(methodName) : methodName;
        }

        public static string PropertyName(this Method entry, IEnumerable<Class> classDefinitions, bool usedInGenerics, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var methodName = entry.Name(classDefinitions, null, null, string.Empty, usedInGenerics, camel);
            string methodName2 = string.Empty;
            if (methodName.StartsWith("Get") && methodName.Length > 3 && entry.ParameterCount == 0 && !entry.ReturnType.IsVoid()) methodName2 = methodName.Substring(3).Camel();
            else if (methodName.StartsWith("Set") && methodName.Length > 3 && entry.ParameterCount == 1 && entry.ReturnType.IsVoid()) methodName2 = methodName.Substring(3);
            else if (!JNetReflectorCore.OnlyPropertiesForGetterSetter)
            {
                if (entry.ParameterCount == 0 && !entry.ReturnType.IsVoid()) methodName2 = methodName.Camel();
                if (entry.ParameterCount == 1 && entry.ReturnType.IsVoid()) methodName2 = methodName.Camel();
            }

            if (camel) methodName2 = methodName2.Camel();
            if (methodName2.IsReservedName() || methodName2.CollapseWithClassOrNestedClass(entry.DeclaringClass.JVMNestingLevels(), classDefinitions))
            {
                return methodName;
            }
            return methodName2;
        }

        public static string MethodName(this Method entry, IEnumerable<Class> classDefinitions, bool usedInGenerics, bool camel)
        {
            string nameToReport = entry.Name(classDefinitions, null, null, string.Empty, usedInGenerics, camel);
            if (nameToReport.IsReservedName() || nameToReport.CollapseWithClassOrNestedClass(entry.DeclaringClass.JVMNestingLevels(), classDefinitions))
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

        public static string ReturnType(this Method entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClauses, string prefix, bool usedInGenerics, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (!usedInGenerics || !entry.GenericReturnType.IsGenerics())
            {
                return entry.ReturnType.ToNetType(camel);
            }
            else
            {
                if (entry.TypeParameters.Length != 0 && (entry.IsObjectReturnType(usedInGenerics, JNetReflectorCore.UseCamel) || entry.IsObjectArrayReturnType(usedInGenerics, JNetReflectorCore.UseCamel)))
                {
                    var paramName = entry.TypeParameters[0].Name;
                    genArguments.Add(paramName);
                    if (entry.IsObjectReturnType(usedInGenerics, JNetReflectorCore.UseCamel))
                    {
                        return $"{paramName}";
                    }
                    else
                    {
                        return $"{paramName}[]";
                    }
                }
                else
                {
                    return entry.GenericReturnType.Type(entry.ReturnType, genArguments, genClauses, prefix, true, camel);
                }
            }
        }

        public static bool IsObjectReturnType(this Method entry, bool usedInGenerics, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (!usedInGenerics || !entry.GenericReturnType.IsGenerics())
            {
                return entry.ReturnType.ToNetType(camel) == SpecialNames.NetObject;
            }
            else return false;
        }

        public static bool IsObjectArrayReturnType(this Method entry, bool usedInGenerics, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (!usedInGenerics || !entry.GenericReturnType.IsGenerics())
            {
                return entry.ReturnType.ToNetType(camel) == (SpecialNames.NetObject + SpecialNames.ArrayTypeTrailer);
            }
            else return false;
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

        public static bool MustBeAvoided(this Method entry, bool usedInGenerics)
        {
            bool mustBeAvoided = entry.ReturnType.MustBeAvoided();
            if (!mustBeAvoided) entry.GenericReturnType.GetGenerics(null, null, string.Empty, true, usedInGenerics, false, out mustBeAvoided);
            return mustBeAvoided;
        }

        public static string JavadocUrl(this Method entry, bool camel)
        {
            var newURl = entry.DeclaringClass.JavadocUrl(camel);
            if (_CurrentJavadocBaseUrl != null)
            {
                var genString = entry.GenericString;
                genString = genString.Substring(genString.IndexOf(entry.Name));
                genString = entry.Name + "(";
                foreach (var item in entry.Parameters)
                {
                    var typeName = item.Type.TypeName;
                    typeName = typeName.Contains(SpecialNames.BeginGenericDeclaration) ? typeName.Substring(0, typeName.IndexOf(SpecialNames.BeginGenericDeclaration)) : typeName;
                    typeName = typeName.Replace(SpecialNames.NestedClassSeparator, SpecialNames.NamespaceSeparator);
                    genString += typeName + ",";
                }
                genString = genString.EndsWith(",") ? genString.Substring(0, genString.LastIndexOf(",")) : genString;
                genString += ")";

                if (genString.Contains("throws")) genString = genString.Substring(0, genString.IndexOf("throws") - 1);
                if (_CurrentJavadocVersion < 7)
                {
                    genString = genString.Replace(",", ", ");
                }
                else if (_CurrentJavadocVersion > 7 && _CurrentJavadocVersion < 10)
                {
                    genString = genString.Replace(",", "-").Replace('(', '-').Replace(')', '-');
                }

                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name(null, null, null, string.Empty, false, camel);
        }

        public static string JavadocHrefUrl(this Method entry, bool camel)
        {
            return string.Format(AllPackageClasses.DocTemplate(_CurrentJavadocBaseUrl), JavadocUrl(entry, camel).Replace(SpecialNames.BeginGenericDeclaration, "%3C").Replace(SpecialNames.EndGenericDeclaration, "%3E"));
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

        public static string Name(this Field entry, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return camel ? Camel(entry.Name) : entry.Name;
        }

        public static bool IsTypeNative(this Field entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.IsJVMNativeType();
        }

        public static string Type(this Field entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClauses, bool usedInGenerics, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (!usedInGenerics || !entry.GenericType.IsGenerics())
            {
                return entry.Type.ToNetType(camel);
            }
            else
            {
                return entry.GenericType.Type(entry.Type, genArguments, genClauses, string.Empty, true, camel);
            }
        }

        public static bool IsObjectReturnType(this Field entry, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.GenericType.ToNetType(camel) == SpecialNames.NetObject;
        }

        public static string JavadocUrl(this Field entry, bool camel)
        {
            var newURl = entry.DeclaringClass.JavadocUrl(camel);
            if (_CurrentJavadocBaseUrl != null)
            {
                var genString = entry.Name;
                newURl += "#" + genString;
                return newURl;
            }

            return entry.Name(false);
        }

        public static string JavadocHrefUrl(this Field entry, bool camel)
        {
            return string.Format(AllPackageClasses.DocTemplate(_CurrentJavadocBaseUrl), JavadocUrl(entry, camel).Replace(SpecialNames.BeginGenericDeclaration, "%3C").Replace(SpecialNames.EndGenericDeclaration, "%3E"));
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

        public static string Name(this Parameter entry)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            var cName = entry.Name.Replace(SpecialNames.NestedClassSeparator, '_');
            if (SpecialNames.ReservedLanguageNames.Any((n) => cName.Equals(n))) cName = "_" + cName;
            return cName;
        }

        public static string Type(this Parameter entry, IList<string> genArguments, IList<KeyValuePair<string, string>> genClauses, string prefix, bool usedInGenerics, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            if (!usedInGenerics || !entry.ParameterizedType.IsGenerics())
            {
                return entry.Type.ToNetType(camel);
            }
            else
            {
                var entryType = entry.Type.ToNetType(camel);
                if (entry.ParameterizedType.IsGenerics() && (entryType == SpecialNames.NetObject || entryType == (SpecialNames.NetObject + SpecialNames.ArrayTypeTrailer)))
                {
                    var retVal = entry.ParameterizedType.GetGenerics(genArguments, genClauses, prefix, true, usedInGenerics, camel, out bool _);
                    //var retVal = genArguments.ConvertGenerics();
                    return retVal;
                }
                else
                {
                    return entry.ParameterizedType.Type(entry.Type, genArguments, genClauses, prefix, true, camel);
                }
            }
        }

        public static bool IsObjectType(this Parameter entry, bool camel)
        {
            if (entry == null) throw new ArgumentNullException(nameof(entry));
            return entry.Type.ToNetType(camel) == SpecialNames.NetObject;
        }

        public static bool IsJVMException(this Parameter entry)
        {
            if (entry == null || entry.ParameterizedType == null || entry.ParameterizedType.TypeName == null) return false;
            var cName = entry.ParameterizedType.TypeName;
            cName = cName.Contains(SpecialNames.BeginGenericDeclaration) ? cName.Substring(0, cName.IndexOf(SpecialNames.BeginGenericDeclaration)) : cName;
            var cEntry = cName.JVMClass();
            return cEntry.IsJVMException();
        }

        public static bool MustBeAvoided(this Parameter entry, bool usedInGenerics)
        {
            bool mustBeAvoided = entry.Type.MustBeAvoided();
            if (!mustBeAvoided) entry.ParameterizedType.GetGenerics(null, null, string.Empty, true, usedInGenerics, false, out mustBeAvoided);
            return mustBeAvoided;
        }

        #endregion
    }
}
