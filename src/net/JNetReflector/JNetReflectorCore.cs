﻿/*
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

using MASES.CLIParser;
using MASES.JNet;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MASES.JNetReflector
{
    /// <summary>
    /// Public entry point of <see cref="JNetReflectorCore{T}"/>
    /// </summary>
    public abstract class JNetReflectorCore<T> : JNetCoreBase<T> where T : JNetReflectorCore<T>
    {
        #region Initialization
        /// <inheritdoc cref="JNetCoreBase{T}.CommandLineArguments"/>
        public override IEnumerable<IArgumentMetadata> CommandLineArguments
        {
            get
            {
                var lst = new List<IArgumentMetadata>(base.CommandLineArguments);
                lst.AddRange(new IArgumentMetadata[]
                {
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.OriginRootPath,
                        Type = ArgumentType.Double,
                        Help = "The origin path where Jars to be analyzed, and dependencies, are stored",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.OriginJavadocUrl,
                        Type = ArgumentType.Double,
                        Default = null,
                        Help = "The base URL of the Javadoc to be associated to the classes",
                    },
                    new ArgumentMetadata<int>()
                    {
                        Name = CLIParam.JavadocVersion,
                        Type = ArgumentType.Double,
                        Default = 11,
                        Help = "The version of the Javadoc to be associated to the classes, it means the Javadoc tool version used",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.OriginJavadocJARVersionAndUrls,
                        Type = ArgumentType.Double,
                        Default = null,
                        Help = "A CSV list of keypair of JavadocVersion and OriginJavadocUrl, separated by |, associated to the JARs to be analyzed",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.DestinationRootPath,
                        Type = ArgumentType.Double,
                        Default = SpecialNames.JNetReflectorGeneratedFolder,
                        Help = "The destination root path where reflected classes will be stored",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesToAnalyze,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of full qualified class names to be analyzed",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.JarList,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of JAR to be analyzed or folders containing the JARs",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ModulesToParse,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of module patterns to be parsed during analysis, it avoids the usage of OriginRootPath",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesToBeListener,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of class names to be treated as Listener",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.NamespacesInConflict,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of namespaces in conflict with class name: to this one will be added an \"Ns\" at the end",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.NamespacesToAvoid,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of namespaces to be removed during analysis",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesToAvoid,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of classes to be removed during analysis",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassesToAvoidInGenerics,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of classes to be removed during analysis from the classes which have generics types",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.OnlyPropertiesForGetterSetter,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to convert into properties only getter/setter",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.ReflectDeprecated,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to write any constructor, method or field marked as deprecated, default is to avoid deprecated",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.AvoidCSharpGenericDefinition,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to reflect generics without create the C# generic definition",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.AvoidCSharpGenericClauseDefinition,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to reflect generics without create the clauses of C# generic definition",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DisableGenericsInNonGenericClasses,
                        Type = ArgumentType.Single,
                        Help = "The option disables generation of generic methods in non generic classes",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DisableGenerics,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to disable any generic type",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.AvoidParallelBuild,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to disable parallel execution",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DryRun,
                        Type = ArgumentType.Single,
                        Help = "Execute everything, but do not write anything to disk",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DoNotCamel,
                        Type = ArgumentType.Single,
                        Help = "Does not use camelized names in methods, class and so on",
                    },
                    new ArgumentMetadata<int>()
                    {
                        Name = CLIParam.TraceLevel,
                        Type = ArgumentType.Double,
                        Default = (int)ReflectionUtils.ReflectionTraceLevel.Verbose,
                        Help = "The level of traces to be reported: 0 - Critical ... 5 - Verbose",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.TraceTo,
                        Type = ArgumentType.Double,
                        Default = null,
                        Help = "The file name where traces will be write, default write to console",
                    },
                });
                return lst;
            }
        }

        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetReflectorCore()
        {
            JCOBridge.C2JBridge.JCOBridge.RegisterExceptions(typeof(JNetReflectorCore<>).Assembly);
        }

        static string _OriginRootPath;
        public static string OriginRootPath => _OriginRootPath;

        static string _OriginJavadocUrl;
        public static string OriginJavadocUrl => _OriginJavadocUrl;

        static IEnumerable<(int, string)> _OriginJavadocJARVersionAndUrls;
        public static IEnumerable<(int, string)> OriginJavadocJARVersionAndUrls => _OriginJavadocJARVersionAndUrls;

        static int _JavadocVersion;
        public static int JavadocVersion => _JavadocVersion;

        static string _DestinationRootPath;
        public static string DestinationRootPath => _DestinationRootPath;

        static IEnumerable<string> _ClassesToAnalyze;
        public static IEnumerable<string> ClassesToAnalyze => _ClassesToAnalyze;

        static IEnumerable<string> _JarsToAddInClassPath;
        static IEnumerable<string> _JarsToAnalyze;
        public static IEnumerable<string> JarsToAnalyze => _JarsToAnalyze;

        static IEnumerable<string> _ModulesToParse;
        public static IEnumerable<string> ModulesToParse => _ModulesToParse;

        static IEnumerable<string> _ClassesToBeListener;
        public static IEnumerable<string> ClassesToBeListener => _ClassesToBeListener;

        static IEnumerable<string> _NamespacesInConflict;
        public static IEnumerable<string> NamespacesInConflict => _NamespacesInConflict;

        static IEnumerable<string> _NamespacesToAvoid;
        public static IEnumerable<string> NamespacesToAvoid => _NamespacesToAvoid;

        static IEnumerable<string> _ClassesToAvoid;
        public static IEnumerable<string> ClassesToAvoid => _ClassesToAvoid;

        static IEnumerable<string> _ClassesToAvoidInGenerics;
        public static IEnumerable<string> ClassesToAvoidInGenerics => _ClassesToAvoidInGenerics;

        static bool _OnlyPropertiesForGetterSetter;
        public static bool OnlyPropertiesForGetterSetter => _OnlyPropertiesForGetterSetter;

        static bool _ReflectDeprecated;
        public static bool ReflectDeprecated => _ReflectDeprecated;

        static bool _AvoidCSharpGenericDefinition;
        public static bool AvoidCSharpGenericDefinition => _AvoidCSharpGenericDefinition;

        static bool _AvoidCSharpGenericClauseDefinition;
        public static bool AvoidCSharpGenericClauseDefinition => _AvoidCSharpGenericClauseDefinition;

        static bool _DisableGenericsInNonGenericClasses;
        public static bool DisableGenericsInNonGenericClasses => _DisableGenericsInNonGenericClasses;

        static bool _DisableGenerics;
        public static bool DisableGenerics => _DisableGenerics;

        static bool _AvoidParallelBuild;
        public static bool AvoidParallelBuild => _AvoidParallelBuild;

        static bool _DryRun;
        public static bool DryRun => _DryRun;

        static bool _UseCamel;
        public static bool UseCamel => _UseCamel;

        static int _TraceLevel;
        public static int TraceLevel => _TraceLevel;

        static string _TraceTo;
        public static string TraceTo => _TraceTo;

        /// <inheritdoc cref="JNetCoreBase{T}.ProcessCommandLine"/>
        protected override string[] ProcessCommandLine()
        {
            var result = base.ProcessCommandLine();

            List<string> classesToAnalyze = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesToAnalyze))
            {
                var classes = ParsedArgs.Get<string>(CLIParam.ClassesToAnalyze).Split(',', ';');
                foreach (var item in classes.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!classesToAnalyze.Contains(item)) classesToAnalyze.Add(item);
                }
                _ClassesToAnalyze = classesToAnalyze;
            }

            List<string> jarsToAnaylyze = new List<string>();
            if (ParsedArgs.Exist(CLIParam.OriginRootPath))
            {
                var originalRootPath = ParsedArgs.Get<string>(CLIParam.OriginRootPath);
                _OriginRootPath = Path.GetFullPath(originalRootPath);
                if (!Directory.Exists(_OriginRootPath)) throw new DirectoryNotFoundException($"{_OriginRootPath} not exist.");
                _JarsToAddInClassPath = new List<string>(Directory.EnumerateFiles(originalRootPath, "*.jar"));
            }

            if (ParsedArgs.Exist(CLIParam.JarList))
            {
                var jars = ParsedArgs.Get<string>(CLIParam.JarList).Split(',', ';');
                foreach (var item in jars.Select((o) => Path.Combine(OriginRootPath, o)))
                {
                    if (!jarsToAnaylyze.Contains(item)) jarsToAnaylyze.Add(item);
                }
                _JarsToAnalyze = jarsToAnaylyze;
            }

            List<string> modulesToParse = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ModulesToParse))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.ModulesToParse).Split(',', ';');
                foreach (var item in namespaces.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!modulesToParse.Contains(item)) modulesToParse.Add(item);
                }
                _ModulesToParse = modulesToParse;
            }

            List<(int, string)> jarURLsToAnaylyze = new List<(int, string)>();
            if (ParsedArgs.Exist(CLIParam.OriginJavadocJARVersionAndUrls))
            {
                var jarURLs = ParsedArgs.Get<string>(CLIParam.OriginJavadocJARVersionAndUrls).Split(',', ';');
                foreach (var item in jarURLs)
                {
                    var items = item.Split('|');
                    if (items.Length < 2) throw new System.InvalidOperationException($"{item} does not conform to expected pattern.");
                    var version = int.Parse(items[0]);
                    var url = string.Join(string.Empty, items.Skip(1));
                    jarURLsToAnaylyze.Add((version, url));
                }
                _OriginJavadocJARVersionAndUrls = jarURLsToAnaylyze;
                if (_JarsToAnalyze.Count() != _OriginJavadocJARVersionAndUrls.Count())
                    throw new System.InvalidOperationException("Number of entries in OriginJavadocJARVersionAndUrls shall be equal to the number of JarList");
            }

            List<string> classesToBeListener = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesToBeListener))
            {
                var classes = ParsedArgs.Get<string>(CLIParam.ClassesToBeListener).Split(',', ';');
                foreach (var item in classes)
                {
                    if (!classesToBeListener.Contains(item)) classesToBeListener.Add(item);
                }
            }
            _ClassesToBeListener = classesToBeListener;

            List<string> namespacesInConflict = new List<string>();
            if (ParsedArgs.Exist(CLIParam.NamespacesInConflict))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.NamespacesInConflict).Split(',', ';');
                foreach (var item in namespaces.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!namespacesInConflict.Contains(item)) namespacesInConflict.Add(item);
                }
            }
            _NamespacesInConflict = namespacesInConflict;

            List<string> namespacesToAvoid = new List<string>();
            if (ParsedArgs.Exist(CLIParam.NamespacesToAvoid))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.NamespacesToAvoid).Split(',', ';');
                foreach (var item in namespaces.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!namespacesToAvoid.Contains(item)) namespacesToAvoid.Add(item);
                }
            }
            _NamespacesToAvoid = namespacesToAvoid;

            List<string> classesToAvoid = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesToAvoid))
            {
                var classes = ParsedArgs.Get<string>(CLIParam.ClassesToAvoid).Split(',', ';');
                foreach (var item in classes.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!classesToAvoid.Contains(item)) classesToAvoid.Add(item);
                }
            }
            _ClassesToAvoid = classesToAvoid;

            List<string> classesToAvoidInGenerics = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ClassesToAvoidInGenerics))
            {
                var classes = ParsedArgs.Get<string>(CLIParam.ClassesToAvoidInGenerics).Split(',', ';');
                foreach (var item in classes.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!classesToAvoidInGenerics.Contains(item)) classesToAvoidInGenerics.Add(item);
                }
            }
            _ClassesToAvoidInGenerics = classesToAvoidInGenerics;

            var destinationFolder = Path.GetFullPath(ParsedArgs.Get<string>(CLIParam.DestinationRootPath));
            _DestinationRootPath = Path.GetFullPath(destinationFolder);

            _OriginJavadocUrl = ParsedArgs.Get<string>(CLIParam.OriginJavadocUrl);
            _JavadocVersion = ParsedArgs.Get<int>(CLIParam.JavadocVersion);

            _OnlyPropertiesForGetterSetter = ParsedArgs.Exist(CLIParam.OnlyPropertiesForGetterSetter);
            _ReflectDeprecated = ParsedArgs.Exist(CLIParam.ReflectDeprecated);
            _AvoidCSharpGenericDefinition = ParsedArgs.Exist(CLIParam.AvoidCSharpGenericDefinition);
            _AvoidCSharpGenericClauseDefinition = ParsedArgs.Exist(CLIParam.AvoidCSharpGenericClauseDefinition);
            _DisableGenericsInNonGenericClasses = ParsedArgs.Exist(CLIParam.DisableGenericsInNonGenericClasses);
            _DisableGenerics = ParsedArgs.Exist(CLIParam.DisableGenerics);
            _AvoidParallelBuild = ParsedArgs.Exist(CLIParam.AvoidParallelBuild);
            _DryRun = ParsedArgs.Exist(CLIParam.DryRun);
            _UseCamel = !ParsedArgs.Exist(CLIParam.DoNotCamel);
            _TraceLevel = ParsedArgs.Get<int>(CLIParam.TraceLevel);
            _TraceTo = ParsedArgs.Get<string>(CLIParam.TraceTo);

            return result;
        }

        protected override IDictionary<string, string> Options => new Dictionary<string, string>();

        /// <inheritdoc cref="JNetCoreBase{T}.PathToParse"/>
        protected override IList<string> PathToParse
        {
            get
            {
                var lst = base.PathToParse;
                var assembly = typeof(JNetReflectorCore<>).Assembly;
                var path = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(assembly.Location), JARsSubFolder, $"*.jar");
                lst.Add(path);
                if (_JarsToAddInClassPath != null)
                {
                    foreach (var item in _JarsToAddInClassPath)
                    {
                        lst.Add(Path.GetFullPath(item));
                    }
                }
                return lst;
            }
        }
        #endregion

#if DEBUG
        public override bool EnableDebug => true;
#endif
    }
    /// <summary>
    /// Concrete implementation of <see cref="JNetReflectorCore{T}"/>
    /// </summary>
    public class JNetReflectorCore : JNetReflectorCore<JNetReflectorCore>
    {
    }
}