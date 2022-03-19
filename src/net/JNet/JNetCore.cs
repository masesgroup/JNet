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
using MASES.JCOBridge.C2JBridge;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MASES.JNet
{
    /// <summary>
    /// Public entry point of <see cref="JNetCore"/>
    /// </summary>
    public class JNetCore<T> : SetupJVMWrapper<T> where T : JNetCore<T>
    {
        static readonly object lockInstance = new();
        static T _instance = null;
        /// <summary>
        /// Create and return a singleton global instance of <typeparamref name="T"/>
        /// </summary>
        public static T GlobalInstance
        {
            get
            {
                lock (lockInstance)
                {
                    if (_instance == null) _instance = Activator.CreateInstance(typeof(T)) as T;
                    _instance.Globalize();
                }
                return _instance;
            }
        }
        /// <summary>
        /// Creates the <see cref="GlobalInstance"/> and initialize the engine
        /// </summary>
        public static void CreateGlobalInstance()
        {
            lock (lockInstance)
            {
                if (_instance == null) _instance = Activator.CreateInstance(typeof(T)) as T;
                _instance.Globalize();
            }
        }

        /// <summary>
        /// Command line <see cref="Parser"/> instance
        /// </summary>
        protected static readonly Parser Parser = Parser.CreateInstance(new Settings()
        {
            DefaultType = ArgumentType.Double
        });
        /// <summary>
        /// <see cref="IEnumerable{IArgumentMetadata}"/> for command line
        /// </summary>
        protected virtual IEnumerable<IArgumentMetadata> CommandLineArguments =>
        new IArgumentMetadata[]
            {
                new ArgumentMetadata<bool>()
                {
                    Name = CLIParam.LogClassPath,
                    Type = ArgumentType.Single,
                    Help = "Add on command-line to show ClassPath resolution.",
                },
            };

        readonly bool _logClassPath = false;
        IEnumerable<IArgumentMetadataParsed> _parsedArgs = null;
        /// <summary>
        /// Arguments parsed
        /// </summary>
        protected IEnumerable<IArgumentMetadataParsed> ParsedArgs => _parsedArgs;
        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetCore()
        {
            Parser.Add(CommandLineArguments);
            _parsedArgs = Parser.Parse(FilteredArgs);

            ApplicationArgs = Parser.UnparsedArgs.FilterJCOBridgeArguments();
#if DEBUG
            _logClassPath = true;
#else
            _logClassPath = _parsedArgs.Exist(CLIParam.LogClassPath);
#endif

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Util.Concurrent.ExecutionException>();
        }

        /// <summary>
        /// The filtered application arguments 
        /// </summary>
        public string[] ApplicationArgs { get; private set; }
        /// <summary>
        /// Default performance options used in initialization
        /// </summary>
        protected virtual IList<string> PerformanceOptions => new List<string>();
        /// <summary>
        /// Adds options to the JVM
        /// </summary>
        protected virtual IDictionary<string, string> Options
        {
            get
            {
                IDictionary<string, string> opt = new Dictionary<string, string>();
                if (PerformanceOptions != null)
                {
                    foreach (var item in PerformanceOptions)
                    {
                        opt.Add(item, null);
                    }
                }
                return opt;
            }
        }
        /// <inheritdoc cref="SetupJVMWrapper.JVMOptions"/>
        public sealed override IEnumerable<KeyValuePair<string, string>> JVMOptions
        {
            get
            {
                IDictionary<string, string> opt = Options;
                if (base.JVMOptions != null)
                {
                    foreach (var item in base.JVMOptions)
                    {
                        opt.Add(item);
                    }
                }
                return opt;
            }
        }

        string classPath = string.Empty;
        /// <inheritdoc cref="SetupJVMWrapper.ClassPath"/>
        public sealed override string ClassPath => buildClassPath();
        /// <summary>
        /// A list of paths to be used in initialization of JVM ClassPath
        /// </summary>
        protected virtual IList<string> PathToParse => new List<string>();

        string buildClassPath()
        {
            ClassPathBuilder builder = new();

            if (PathToParse != null) builder.Add(PathToParse.ToArray());

            classPath = builder.Build();

            if (_logClassPath)
            {
                Console.WriteLine("ClassPath is defined from:");
                foreach (var item in classPath.Split(ClassPathBuilder.PathSeparator))
                {
                    Console.WriteLine(item);
                }
            }
            return classPath;
        }
    }

    public class JNetCore : JNetCore<JNetCore>
    {

    }
}