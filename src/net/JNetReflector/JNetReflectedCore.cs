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
using MASES.JNet;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MASES.JNetReflector
{
    /// <summary>
    /// Public entry point of <see cref="JNetReflectedCore{T}"/>
    /// </summary>
    public abstract class JNetReflectedCore<T> : JNetCoreBase<T> where T : JNetReflectedCore<T>
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
                        IsMandatory = true,
                        Help = "Set the origin path where Jars are stored",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.OriginJavadocUrl,
                        Type = ArgumentType.Double,
                        Default = null,
                        Help = "The base URL of the Javadoc to be associated to the classes",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.DestinationRootPath,
                        Type = ArgumentType.Double,
                        Default = SpecialNames.JNetReflectorGeneratedFolder,
                        Help = "Set the destination root path",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.JarList,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of JAR to be analyzed or folders containing the JARs",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.NamespacesToAvoid,
                        Type = ArgumentType.Double,
                        Help = "A CSV list of namespaces to be removed from analysis",
                    },
                    new ArgumentMetadata<bool>()
                    {
                        Name = CLIParam.DryRun,
                        Type = ArgumentType.Single,
                        Default = false,
                        Help = "Do not write anything to disk",
                    },
                });
                return lst;
            }
        }

        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetReflectedCore()
        {
        }

        static string _OriginRootPath;
        public static string OriginRootPath => _OriginRootPath;

        static string _OriginJavadocUrl;
        public static string OriginJavadocUrl => _OriginJavadocUrl;

        static string _DestinationRootPath;
        public static string DestinationRootPath => _DestinationRootPath;

        static IEnumerable<string> _JarsToAnaylyze;
        public static IEnumerable<string> JarsToAnaylyze => _JarsToAnaylyze;

        static IEnumerable<string> _NamespacesToAvoid;
        public static IEnumerable<string> NamespacesToAvoid => _NamespacesToAvoid;

        static bool _DryRun;
        public static bool DryRun => _DryRun;

        /// <inheritdoc cref="JNetCoreBase{T}.ProcessCommandLine"/>
        protected override string[] ProcessCommandLine()
        {
            var result = base.ProcessCommandLine();

            var originalRootPath = ParsedArgs.Get<string>(CLIParam.OriginRootPath);
            _OriginRootPath = Path.GetFullPath(originalRootPath);
            if (!Directory.Exists(_OriginRootPath)) throw new DirectoryNotFoundException($"{_OriginRootPath} not exist.");

            List<string> jarsToAnaylyze = new List<string>();
            if (ParsedArgs.Exist(CLIParam.JarList))
            {
                var jars = ParsedArgs.Get<string>(CLIParam.JarList).Split(',', ';');
                jarsToAnaylyze.AddRange(jars.Select((o) => Path.Combine(originalRootPath, o)));
            }
            else
            {
                jarsToAnaylyze.AddRange(Directory.EnumerateFiles(originalRootPath));
            }
            _JarsToAnaylyze = jarsToAnaylyze;

            List<string> namespacesToAvoid = new List<string>();
            if (ParsedArgs.Exist(CLIParam.NamespacesToAvoid))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.NamespacesToAvoid).Split(',', ';');
                namespacesToAvoid.AddRange(namespaces.Select((o) => o.Replace('/', '.')));
            }
            _NamespacesToAvoid = namespacesToAvoid;

            var destinationFolder = Path.GetFullPath(ParsedArgs.Get<string>(CLIParam.DestinationRootPath));
            _DestinationRootPath = Path.GetFullPath(destinationFolder);

            _OriginJavadocUrl = ParsedArgs.Get<string>(CLIParam.OriginJavadocUrl);

            _DryRun = ParsedArgs.Get<bool>(CLIParam.DryRun);

            return result;
        }

        protected override IDictionary<string, string> Options => new Dictionary<string, string>();

        /// <inheritdoc cref="JNetCoreBase{T}.PathToParse"/>
        protected override IList<string> PathToParse
        {
            get
            {
                var lst = base.PathToParse;
                foreach (var item in _JarsToAnaylyze)
                {
                    lst.Add(Path.GetFullPath(item));
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
    /// Concrete implementation of <see cref="JNetReflectedCore{T}"/>
    /// </summary>
    public class JNetReflectedCore : JNetReflectedCore<JNetReflectedCore>
    {
        /// <inheritdoc cref="Parser.HelpInfo(int?)"/>
        public static string HelpInfo(int? width = null) => Parser.HelpInfo(width);
    }
}