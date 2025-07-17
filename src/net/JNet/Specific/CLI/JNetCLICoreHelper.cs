/*
*  Copyright 2025 MASES s.r.l.
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
using MASES.JCOBridge.C2JBridge;
using MASES.JNet;
using MASES.JNet.Specific.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Reflection;

namespace MASES.JNet.Specific.CLI
{
    /// <summary>
    /// Helper class for CLI operations
    /// </summary>
    public static class JNetCLICoreHelper
    {
        class CLIParam
        {
            // ReflectorArgs
            public static string[] NoLogo = new string[] { "NoLogo", "nl" };
            public static string[] ClassToRun = new string[] { "ClassToRun", "ctr" };
            public static string[] Interactive = new string[] { "Interactive", "i" };
            public static string[] RunCommand = new string[] { "RunCommand", "rc" };
            public static string[] Script = new string[] { "Script", "s" };
            public static string[] JarList = new string[] { "JarList", "jl" };
            public static string[] NamespaceList = new string[] { "NamespaceList", "nl" };
            public static string[] ImportList = new string[] { "ImportList", "il" };
        }

        #region Initialization
        /// <summary>
        /// Adds command line arguments on the set managed from <see cref="JNetCoreBase{T}.CommandLineArguments"/>
        /// </summary>
        /// <param name="args">The base arguments to be integrated with command-line options</param>
        /// <returns>The new <see cref="IEnumerable{T}"/> of <see cref="IArgumentMetadata"/></returns>
        public static IEnumerable<IArgumentMetadata> SetCLICommandLineArguments(this IEnumerable<IArgumentMetadata> args)
        {
            var lst = new List<IArgumentMetadata>(args);

            lst.AddRange(new IArgumentMetadata[]
            {
                new ArgumentMetadata<string>()
                {
                    Name = CLIParam.NoLogo[0],
                    ShortName = CLIParam.NoLogo[1],
                    Type = ArgumentType.Single,
                    Help = "Do not display initial informative string",
                },
            });

            if (EnableMainClassToRun)
            {
                lst.AddRange(new IArgumentMetadata[]
                {
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ClassToRun[0],
                        ShortName = CLIParam.ClassToRun[1],
                        Help = "The class to be instantiated from CLI.",
                    },
                });
            }

            if (EnableInteractive)
            {
                lst.AddRange(new IArgumentMetadata[]
                {
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.Interactive[0],
                        ShortName = CLIParam.Interactive[1],
                        Type = ArgumentType.Single,
                        Help = "Activate an interactive shell",
                    },
                });
            }

            if (EnableRunCommand)
            {
                lst.AddRange(new IArgumentMetadata[]
                {
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.RunCommand[0],
                        ShortName = CLIParam.RunCommand[1],
                        Type = ArgumentType.Double,
                        Help = "Run the Java Main-Class, remaining options are passed to the main method of the Java Main-Class",
                    },  
                });
            }

            if (EnableScript)
            {
                lst.AddRange(new IArgumentMetadata[]
                {
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.Script[0],
                        ShortName = CLIParam.Script[1],
                        Type = ArgumentType.Double,
                        Help = "Run the script code and exit, the argument is the path to the file containing the script",
                    },
                });
            }

            if (EnableScript || EnableInteractive)
            {
                lst.AddRange(new IArgumentMetadata[]
                {
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.JarList[0],
                        ShortName = CLIParam.JarList[1],
                        Type = ArgumentType.Double,
                        Help = "A CSV list of JAR to be used or folders containing the JARs",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.NamespaceList[0],
                        ShortName = CLIParam.NamespaceList[1],
                        Type = ArgumentType.Double,
                        Help = "A CSV list of namespace to be used for interactive shell, JNet namespace are added automatically",
                    },
                    new ArgumentMetadata<string>()
                    {
                        Name = CLIParam.ImportList[0],
                        ShortName = CLIParam.ImportList[1],
                        Type = ArgumentType.Double,
                        Help = "A CSV list of import to be used",
                    },
                });
            }
            return lst;
        }
        /// <summary>
        /// Extract all <see cref="Assembly"/> associated to <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> to parse</typeparam>
        /// <returns>An <see cref="IEnumerable{T}"/> containing the <see cref="Assembly"/> found from <typeparamref name="T"/></returns>
        public static IEnumerable<Assembly> ReferencesOf<T>()
        {
            List<Assembly> assemblies = new List<Assembly>();
            var baseType = typeof(T);
            do
            {
                var ass = baseType.Assembly;
                if (!assemblies.Contains(ass))
                {
                    assemblies.Add(ass);
                }
                baseType = baseType.BaseType;
            } while (baseType != typeof(object));
            return assemblies;
        }

        /// <summary>
        /// Initialize CLI
        /// </summary>
        public static void InitCLI<T>(this JNetCoreBase<T> runner) where T : JNetCoreBase<T>
        {
            foreach (var item in ImportList)
            {
                runner.ImportPackage(item);
            }
        }
        /// <summary>
        /// Retrieves the list of classes usable as Main-Class
        /// </summary>
        /// <typeparam name="TRunner">The class extending <see cref="JNetCoreBase{T}"/></typeparam>
        /// <returns>A <see cref="IDictionary{TKey, TValue}"/> of class name and corresponding <see cref="Type"/></returns>
        public static IDictionary<string, Type> MainClassesFrom<TRunner>() where TRunner : JNetCoreBase<TRunner>
        {
            Type RunnerType = typeof(TRunner);
            Dictionary<string, Type> implementedClasses = new Dictionary<string, Type>();
            foreach (var reference in JNetCLICoreHelper.ReferencesOf<TRunner>())
            {
                IDictionary<string, Type> classes = RunnerType.RunStaticMethodOn(typeof(SetupJVMWrapper), nameof(JNetCoreBase<TRunner>.GetMainClasses), reference) as IDictionary<string, Type>;
                foreach (var cls in classes)
                {
                    if (!implementedClasses.ContainsKey(cls.Key))
                    {
                        implementedClasses.Add(cls.Key, cls.Value);
                    }
                    else if (implementedClasses[cls.Key].FullName != cls.Value.FullName)
                    {
                        implementedClasses.Add(cls.Value.FullName, cls.Value);
                    }
                }
            }

            return implementedClasses;
        }

        /// <summary>
        /// Prepare <see cref="MainClassToRun"/> property
        /// </summary>
        /// <typeparam name="T">A <see cref="Type"/> contained in the <see cref="Assembly"/> where <paramref name="className"/> shall be searched</typeparam>
        /// <param name="on">A <see cref="Type"/> contained in the <see cref="Assembly"/> where <paramref name="className"/> shall be searched</param>
        /// <param name="className">The class to search</param>
        public static void PrepareMainClassToRun<T>(this JNetCoreBase<T> on, string className) where T : JNetCoreBase<T>
        {
            PrepareMainClassToRun(MainClassesFrom<T>(), className);
        }

        /// <summary>
        /// Prepare <see cref="MainClassToRun"/> property
        /// </summary>
        /// <param name="on">The <see cref="IDictionary{TKey, TValue}"/> of class name and corresponding <see cref="Type"/> to search the class in</param>
        /// <param name="className">The class to search</param>
        /// <exception cref="ArgumentNullException">If <paramref name="on"/> is <see langword="null"/></exception>
        /// <exception cref="ArgumentException"></exception>
        public static void PrepareMainClassToRun(this IDictionary<string, Type> on, string className)
        {
            if (string.IsNullOrWhiteSpace(className)) return;
            if (on == null) throw new ArgumentNullException(nameof(on), $"Requested class {className} is not applicable.");
            var invariantLowClassName = className.ToLowerInvariant();
            Console.WriteLine($"Searching class {invariantLowClassName}");
            Type type = null;
            foreach (var item in on)
            {
                if (item.Key.ToLowerInvariant() == invariantLowClassName)
                {
                    type = item.Value;
                    break;
                }
            }

            _mainClassToRun = type ?? throw new ArgumentException($"Requested class {className} is not a valid class name.");
        }

        /// <summary>
        /// The default class to run in CLI version if neighter <see cref="ApplicationClassToRun"/> nor <see cref="ClassToRun"/> are set
        /// </summary>
        public static string DefaultClassToRun { get; set; }

        /// <summary>
        /// Set to <see langword="true"/> to use <see cref="MainClassToRun"/>
        /// </summary>
        public static bool EnableMainClassToRun { get; set; } = true;

        static Type _mainClassToRun;
        /// <summary>
        /// Sets the <see cref="Type"/> to be invoked at startup
        /// </summary>
        public static Type MainClassToRun => _mainClassToRun;

        /// <summary>
        /// Sets the global value of class to run
        /// </summary>
        public static string ApplicationClassToRun { get; set; }

        /// <summary>
        /// value can be overridden in subclasses
        /// </summary>
        static string _classToRun;
        /// <summary>
        /// The class to run in CLI version
        /// </summary>
        public static string ClassToRun { get { return ApplicationClassToRun ?? _classToRun; } }

        /// <summary>
        /// Set to <see langword="true"/> to use <see cref="Interactive"/>
        /// </summary>
        public static bool EnableInteractive { get; set; } = true;

        static bool _Interactive;
        /// <summary>
        /// <see langword="true"/> if the CLI was requested in interactive mode
        /// </summary>
        public static bool Interactive => _Interactive;

        /// <summary>
        /// Set to <see langword="true"/> to use <see cref="RunCommand"/>
        /// </summary>
        public static bool EnableRunCommand { get; set; } = true;

        static string _RunCommand;
        /// <summary>
        /// The Java Main-Class to run
        /// </summary>
        public static string RunCommand => _RunCommand;

        static bool _NoLogo;
        /// <summary>
        /// <see langword="true"/> if the CLI shall not display initial informative string
        /// </summary>
        public static bool NoLogo => _NoLogo;

        /// <summary>
        /// Set to <see langword="true"/> to use <see cref="Script"/>
        /// </summary>
        public static bool EnableScript { get; set; } = true;

        static string _Script;
        /// <summary>
        /// The script to be executed
        /// </summary>
        public static string Script => _Script;

        static IEnumerable<string> _JarList;
        /// <summary>
        /// The list of JARs to be added to the classpath
        /// </summary>
        public static IEnumerable<string> JarList => _JarList;

        static IEnumerable<string> _NamespaceList;
        /// <summary>
        /// The set of namespaces to be associated to the execution
        /// </summary>
        public static IEnumerable<string> NamespaceList => _NamespaceList;

        static IEnumerable<string> _ImportList;
        /// <summary>
        /// The set of imports to be associated to the execution
        /// </summary>
        public static IEnumerable<string> ImportList => _ImportList;

        class ClassComparer : IEqualityComparer<string>
        {
            public bool Equals(string x, string y)
            {
                if (x == null && y == null) return true;
                return x?.ToLowerInvariant() == y?.ToLowerInvariant();
            }

            public int GetHashCode(string obj)
            {
                if (obj == null) return 0;
                return obj.GetHashCode();
            }
        }

        /// <summary>
        /// Process parsed args
        /// </summary>
        /// <typeparam name="T">A type extending <see cref="JNetCoreBase{T}"/></typeparam>
        /// <param name="runner">The instance extending <see cref="JNetCoreBase{T}"/></param>
        /// <param name="result">The list of remaining command-line arguments</param>
        /// <param name="settingsCallback">Callback invoked to setup parameters based on <see cref="ClassToRun"/></param>
        public static string[] ProcessCLIParsedArgs<T>(this JNetCoreBase<T> runner, string[] result, Action<string> settingsCallback = null) where T : JNetCoreBase<T>
        {
            IEnumerable<IArgumentMetadataParsed> parsedArgs = runner.ParsedArgs;

            _classToRun = parsedArgs.Get<string>(CLIParam.ClassToRun[0]);

            Console.WriteLine($"Found class to run {_classToRun}");
            Console.WriteLine($"Default class to run {DefaultClassToRun}");

            _Interactive = parsedArgs.Exist(CLIParam.Interactive[0]);

            _RunCommand = parsedArgs.Get<string>(CLIParam.RunCommand[0]);

            _NoLogo = parsedArgs.Exist(CLIParam.NoLogo[0]);

            _Script = parsedArgs.Get<string>(CLIParam.Script[0]);

            if (string.IsNullOrWhiteSpace(_classToRun)
                && string.IsNullOrWhiteSpace(DefaultClassToRun)
                && result != null && result.Length > 0)
            {
                Console.WriteLine($"Searching remaining arguments {string.Join(" ", result)}");
                // search in remaining arguments
                List<string> lst = new List<string>(result);
                var implementedClasses = new Dictionary<string, Type>(JNetCLICoreHelper.MainClassesFrom<T>(), new ClassComparer());
                foreach (var item in lst.ToArray())
                {
                    Console.WriteLine($"Searching remaining argument {item}");
                    if (implementedClasses.ContainsKey(item))
                    {
                        Console.WriteLine($"Using remaining argument {item}");
                        _classToRun = item;
                        lst.Remove(item);
                    }
                    else Console.WriteLine($"Discarded remaining argument {item}");
                }

                result = lst.ToArray();
            }

            List<string> jarList = new List<string>();
            if (parsedArgs.Exist(CLIParam.JarList[0]))
            {
                var jars = parsedArgs.Get<string>(CLIParam.JarList[0]).Split(',', ';');
                jarList.AddRange(jars);
            }
            _JarList = jarList;

            List<string> namespaceList = new List<string>();
            foreach (var assembly in ReferencesOf<T>())
            {
                foreach (var item in assembly.GetExportedTypes())
                {
                    if (item.IsPublic)
                    {
                        if (!namespaceList.Contains(item.Namespace)) namespaceList.Add(item.Namespace);
                    }
                }
            }

            if (parsedArgs.Exist(CLIParam.NamespaceList[0]))
            {
                var namespaces = parsedArgs.Get<string>(CLIParam.JarList[0]).Split(',', ';');
                foreach (var item in namespaces)
                {
                    if (!namespaceList.Contains(item)) namespaceList.Add(item);
                }
            }
            _NamespaceList = namespaceList;

            List<string> importList = new List<string>();
            if (parsedArgs.Exist(CLIParam.ImportList[0]))
            {
                var imports = parsedArgs.Get<string>(CLIParam.JarList[0]).Split(',', ';');
                foreach (var item in imports)
                {
                    if (!importList.Contains(item)) importList.Add(item);
                }
            }
            _ImportList = importList;

            if (!Interactive
                && string.IsNullOrWhiteSpace(Script)
                && string.IsNullOrWhiteSpace(_classToRun)) // set default to DefaultClassToRun since nothing was set
            {
                Console.WriteLine($"Set _classToRun to {DefaultClassToRun}");
                _classToRun = DefaultClassToRun;
            }

            runner.PrepareMainClassToRun(ClassToRun);

            settingsCallback?.Invoke(ClassToRun);

            return result;
        }

        /// <summary>
        /// Set the paths to be parsed
        /// </summary>
        /// <param name="args">The list of paths to be extended</param>
        /// <returns>The resulting paths</returns>
        public static IList<string> SetCLIPathToParse(this IList<string> args)
        {
            foreach (var item in _JarList)
            {
                args.Add(Path.GetFullPath(item));
            }
            return args;
        }
        #endregion
    }
}