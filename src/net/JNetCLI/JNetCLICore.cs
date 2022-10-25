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

namespace MASES.JNetCLI
{
    /// <summary>
    /// Public entry point of <see cref="JNetCLICore{T}"/>
    /// </summary>
    public abstract class JNetCLICore<T> : JNetCore<T> where T : JNetCLICore<T>
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
                        Name = CLIParam.Interactive,
                        ShortName = CLIParam.Interactive[0].ToString(),
                        Type = ArgumentType.Single,
                        Help = "Activate an interactive shell",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.RunCommand,
                        ShortName = CLIParam.RunCommand[0].ToString(),
                        Type = ArgumentType.Double,
                        Help = "Run the Java class, remaining options are passed to the main method of the Java class",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.Script,
                        ShortName = CLIParam.Script[0].ToString(),
                        Type = ArgumentType.Double,
                        Help = "Run the script code and exit, the argument is the path to the file containing the script",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.JarList,
                        ShortName = CLIParam.JarList[0].ToString(),
                        Type = ArgumentType.Double,
                        Help = "A CSV list of JAR to be used or folders containing the JARs",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.NamespaceList,
                        ShortName = CLIParam.NamespaceList[0].ToString(),
                        Type = ArgumentType.Double,
                        Help = "A CSV list of namespace to be used for interactive shell, JNet namespace are added automatically",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ImportList,
                        ShortName = CLIParam.ImportList[0].ToString(),
                        Type = ArgumentType.Double,
                        Help = "A CSV list of import to be used",
                    },
                }); ;
                return lst;
            }
        }

        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetCLICore()
        {
            foreach (var item in ImportList)
            {
                ImportPackage(item);
            }
        }

        static bool _Interactive;
        public static bool Interactive => _Interactive;

        static string _RunCommand;
        public static string RunCommand => _RunCommand;

        static string _Script;
        public static string Script => _Script;

        static IEnumerable<string> _JarList;
        public static IEnumerable<string> JarList => _JarList;

        static IEnumerable<string> _NamespaceList;
        public static IEnumerable<string> NamespaceList => _NamespaceList;

        static IEnumerable<string> _ImportList;
        public static IEnumerable<string> ImportList => _ImportList;

        /// <inheritdoc cref="JNetCoreBase{T}.ProcessCommandLine"/>
        protected override string[] ProcessCommandLine()
        {
            var result = base.ProcessCommandLine();

            _Interactive = ParsedArgs.Exist(CLIParam.Interactive);

            _RunCommand = ParsedArgs.Get<string>(CLIParam.RunCommand);

            _Script = ParsedArgs.Get<string>(CLIParam.Script);

            List<string> jarList = new List<string>();
            if (ParsedArgs.Exist(CLIParam.JarList))
            {
                var jars = ParsedArgs.Get<string>(CLIParam.JarList).Split(',', ';');
                jarList.AddRange(jars);
            }
            _JarList = jarList;

            List<string> namespaceList = new List<string>();

            var jnetAssembly = typeof(JNetCoreBase<>).Assembly;
            foreach (var item in jnetAssembly.GetExportedTypes())
            {
                if (item.IsPublic)
                {
                    if (!namespaceList.Contains(item.Namespace)) namespaceList.Add(item.Namespace);
                }
            }
            if (ParsedArgs.Exist(CLIParam.NamespaceList))
            {
                var namespaces = ParsedArgs.Get<string>(CLIParam.JarList).Split(',', ';');
                foreach (var item in namespaces)
                {
                    if (!namespaceList.Contains(item)) namespaceList.Add(item);
                }
            }
            _NamespaceList = namespaceList;

            List<string> importList = new List<string>();
            if (ParsedArgs.Exist(CLIParam.ImportList))
            {
                var imports = ParsedArgs.Get<string>(CLIParam.JarList).Split(',', ';');
                foreach (var item in imports)
                {
                    if (!importList.Contains(item)) importList.Add(item);
                }
            }
            _ImportList = importList;

            return result;
        }

        protected override IDictionary<string, string> Options => new Dictionary<string, string>();

        /// <inheritdoc cref="JNetCoreBase{T}.PathToParse"/>
        protected override IList<string> PathToParse
        {
            get
            {
                var lst = base.PathToParse;
                foreach (var item in _JarList)
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
    /// Concrete implementation of <see cref="JNetCLICore{T}"/>
    /// </summary>
    public class JNetCLICore : JNetCLICore<JNetCLICore>
    {
    }
}