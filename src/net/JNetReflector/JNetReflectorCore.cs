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
                        Help = "The origin path where Jars to be analyzed are stored",
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
                        Name = CLIParam.DestinationRootPath,
                        Type = ArgumentType.Double,
                        Default = SpecialNames.JNetReflectorGeneratedFolder,
                        Help = "The destination root path where reflected classes will be stored",
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
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DoNotAddJarsInClasspath,
                        Type = ArgumentType.Single,
                        Help = "The option inform the tool to not add the Jars in classpath",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.ReflectDeprecated,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to write any constructor, method or field marked as deprecated, default is to avoid deprecated",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DisableGenerics,
                        Type = ArgumentType.Single,
                        Help = "The option forces the tool to disable any generic type",
                    },
                    new ArgumentMetadata<object>()
                    {
                        Name = CLIParam.DryRun,
                        Type = ArgumentType.Single,
                        Help = "Execute everything, but do not write anything to disk",
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

        static int _JavadocVersion;
        public static int JavadocVersion => _JavadocVersion;

        static string _DestinationRootPath;
        public static string DestinationRootPath => _DestinationRootPath;

        static IEnumerable<string> _JarsToAnaylyze;
        public static IEnumerable<string> JarsToAnaylyze => _JarsToAnaylyze;

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

        static bool _DoNotAddJarsInClasspath;
        public static bool DoNotAddJarsInClasspath => _DoNotAddJarsInClasspath;

        static bool _ReflectDeprecated;
        public static bool ReflectDeprecated => _ReflectDeprecated;

        static bool _DisableGenerics;
        public static bool DisableGenerics => _DisableGenerics;

        static bool _DryRun;
        public static bool DryRun => _DryRun;

        static int _TraceLevel;
        public static int TraceLevel => _TraceLevel;

        static string _TraceTo;
        public static string TraceTo => _TraceTo;

        /// <inheritdoc cref="JNetCoreBase{T}.ProcessCommandLine"/>
        protected override string[] ProcessCommandLine()
        {
            var result = base.ProcessCommandLine();
            if (ParsedArgs.Exist(CLIParam.OriginRootPath))
            {
                var originalRootPath = ParsedArgs.Get<string>(CLIParam.OriginRootPath);
                _OriginRootPath = Path.GetFullPath(originalRootPath);
                if (!Directory.Exists(_OriginRootPath)) throw new DirectoryNotFoundException($"{_OriginRootPath} not exist.");

                List<string> jarsToAnaylyze = new List<string>();
                if (ParsedArgs.Exist(CLIParam.JarList))
                {
                    var jars = ParsedArgs.Get<string>(CLIParam.JarList).Split(',', ';');
                    foreach (var item in jars.Select((o) => Path.Combine(originalRootPath, o)))
                    {
                        if (!jarsToAnaylyze.Contains(item)) jarsToAnaylyze.Add(item);
                    }
                }
                else
                {
                    jarsToAnaylyze.AddRange(Directory.EnumerateFiles(originalRootPath, "*.jar"));
                }
                _JarsToAnaylyze = jarsToAnaylyze;
            }

            List<string> modulesToParse = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ModulesToParse))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.ModulesToParse).Split(',', ';');
                foreach (var item in namespaces.Select((o) => o.Replace(SpecialNames.JNISeparator, SpecialNames.NamespaceSeparator)))
                {
                    if (!modulesToParse.Contains(item)) modulesToParse.Add(item);
                }
            }
            _ModulesToParse = modulesToParse;

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

            var destinationFolder = Path.GetFullPath(ParsedArgs.Get<string>(CLIParam.DestinationRootPath));
            _DestinationRootPath = Path.GetFullPath(destinationFolder);

            _OriginJavadocUrl = ParsedArgs.Get<string>(CLIParam.OriginJavadocUrl);
            _JavadocVersion = ParsedArgs.Get<int>(CLIParam.JavadocVersion);

            _DoNotAddJarsInClasspath = ParsedArgs.Exist(CLIParam.DoNotAddJarsInClasspath);
            _ReflectDeprecated = ParsedArgs.Exist(CLIParam.ReflectDeprecated);
            _DisableGenerics = ParsedArgs.Exist(CLIParam.DisableGenerics);
            _DryRun = ParsedArgs.Exist(CLIParam.DryRun);
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
                if (DoNotAddJarsInClasspath) return lst;
                if (_JarsToAnaylyze != null)
                {
                    foreach (var item in _JarsToAnaylyze)
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