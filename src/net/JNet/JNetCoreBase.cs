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
using MASES.JCOBridge.C2JBridge;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MASES.JNet
{
    class CLIParam
    {
        // CommonArgs
        public const string LogClassPath = "LogClassPath";
    }

    /// <summary>
    /// Public entry point of <see cref="JNetCoreBase{T}"/>
    /// </summary>
    public abstract class JNetCoreBase<T> : SetupJVMWrapper<T> where T : JNetCoreBase<T>
    {
        #region Public const
        /// <summary>
        /// The path where JARs are stored
        /// </summary>
        public const string JARsSubFolder = "jars";
        #endregion

        #region Initialization
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_LicensePath.htm" />
        /// </summary>
        public static string ApplicationLicensePath { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JDKHome.htm" />
        /// </summary>
        public static string ApplicationJDKHome { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JVMPath.htm" />
        /// </summary>
        public static string ApplicationJVMPath { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JNIVerbosity.htm" />
        /// </summary>
        public static string ApplicationJNIVerbosity { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JNIOutputFile.htm" />
        /// </summary>
        public static string ApplicationJNIOutputFile { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JmxPort.htm" />
        /// </summary>
        public static short? ApplicationJmxPort { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_EnableDebug.htm" />
        /// </summary>
        public static bool? ApplicationEnableDebug { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JavaDebugPort.htm" />
        /// </summary>
        public static short? ApplicationJavaDebugPort { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_DebugSuspendFlag.htm" />
        /// </summary>
        public static string ApplicationDebugSuspendFlag { get; set; }
        /// <summary>
        /// Sets the value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JavaDebugOpts.htm" />
        /// </summary>
        public static string ApplicationJavaDebugOpts { get; set; }
        /// <summary>
        /// Sets the global value of <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_GlobalHeapSize.htm" />
        /// </summary>
        public static string ApplicationHeapSize { get; set; }
        /// <summary>
        /// Sets the global value of the <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_InitialHeapSize.htm" />
        /// </summary>
        public static string ApplicationInitialHeapSize { get; set; }
        /// <summary>
        /// Sets the global value of the log class path
        /// </summary>
        public static bool? ApplicationLogClassPath { get; set; }

        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_LicensePath.htm" />
        public override string LicensePath { get { return ApplicationLicensePath ?? base.LicensePath; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JDKHome.htm" />
        public override string JDKHome { get { return ApplicationJDKHome ?? base.JDKHome; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JVMPath.htm" />
        public override string JVMPath { get { return ApplicationJVMPath ?? base.JVMPath; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JNIVerbosity.htm" />
        public override string JNIVerbosity { get { return ApplicationJNIVerbosity ?? base.JNIVerbosity; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JNIOutputFile.htm" />
        public override string JNIOutputFile { get { return ApplicationJNIOutputFile ?? base.JNIOutputFile; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JmxPort.htm" />
        public override short? JmxPort { get { return ApplicationJmxPort.HasValue ? ApplicationJmxPort : base.JmxPort; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_EnableDebug.htm" />
        public override bool EnableDebug { get { return ApplicationEnableDebug ?? base.EnableDebug; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JavaDebugPort.htm" />
        public override short JavaDebugPort { get { return ApplicationJavaDebugPort ?? base.JavaDebugPort; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_DebugSuspendFlag.htm" />
        public override string DebugSuspendFlag { get { return ApplicationDebugSuspendFlag != null ? ApplicationDebugSuspendFlag : base.DebugSuspendFlag; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JavaDebugOpts.htm" />
        public override string JavaDebugOpts { get { return ApplicationJavaDebugOpts != null ? ApplicationJavaDebugOpts : base.JavaDebugOpts; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_GlobalHeapSize.htm" />
        public override string GlobalHeapSize { get { return string.IsNullOrEmpty(base.GlobalHeapSize) ? ApplicationHeapSize : base.GlobalHeapSize; } }
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_InitialHeapSize.htm" />
        public override string InitialHeapSize { get { return string.IsNullOrEmpty(base.InitialHeapSize) ? ApplicationInitialHeapSize : base.InitialHeapSize; } }

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
        public virtual IEnumerable<IArgumentMetadata> CommandLineArguments =>
        new IArgumentMetadata[]
            {
                new ArgumentMetadata<bool>()
                {
                    Name = CLIParam.LogClassPath,
                    Type = ArgumentType.Single,
                    Help = "Add on command-line to show ClassPath resolution.",
                },
            };

        bool _logClassPath = false;
        /// <summary>
        /// Set to <see langword="true"/> to print ClassPath
        /// </summary>
        public virtual bool LogClassPath => ApplicationLogClassPath ?? _logClassPath;

        IEnumerable<IArgumentMetadataParsed> _parsedArgs = null;
        /// <summary>
        /// Arguments parsed
        /// </summary>
        public IEnumerable<IArgumentMetadataParsed> ParsedArgs => _parsedArgs;
        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetCoreBase()
        {
        }
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/M_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_ProcessCommandLine.htm"/>
        /// </summary>
        protected override string[] ProcessCommandLine()
        {
            Parser.Add(CommandLineArguments);
            _parsedArgs = Parser.Parse(base.ProcessCommandLine());
#if DEBUG
            _logClassPath = true;
#else
            _logClassPath = _parsedArgs.Exist(CLIParam.LogClassPath);
#endif
            return Parser.UnparsedArgs.FilterJCOBridgeArguments();
        }
        /// <summary>
        /// Adds options to the JVM
        /// </summary>
        protected abstract IDictionary<string, string> Options { get; }

        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_JVMOptions.htm"/>
        public sealed override IEnumerable<KeyValuePair<string, string>> JVMOptions
        {
            get
            {
                IDictionary<string, string> opt = new Dictionary<string, string>();
                if (base.JVMOptions != null)
                {
                    foreach (var item in base.JVMOptions)
                    {
                        opt.Add(item);
                    }
                }
                if (Options != null)
                {
                    foreach (var item in Options)
                    {
                        try
                        {
                            opt.Add(item);
                        }
                        catch (Exception e)
                        {
                            throw new ArgumentException($"Cannot add option {item.Key}: {e.Message}");
                        }
                    }
                }
                return opt;
            }
        }

        string classPath = string.Empty;
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_SetupJVMWrapper_ClassPath.htm"/>
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

            if (LogClassPath)
            {
                Console.WriteLine("ClassPath is defined from:");
                foreach (var item in classPath.Split(ClassPathBuilder.PathSeparator))
                {
                    Console.WriteLine(item);
                }
            }
            return classPath;
        }

        #endregion

        #region Auxiliary Methods
        /// <inheritdoc cref="Parser.HelpInfo(int?)"/>
        public static string HelpInfo(int? width = null) => Parser.HelpInfo(width);

        /// <summary>
        /// Retrieve the <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_IJVMBridgeDefinition_BridgeClassName.htm"/> of <typeparamref name="TClass"></typeparamref>
        /// </summary>
        /// <typeparam name="TClass">A type implementing <see href="https://www.jcobridge.com/api-clr/html/T_MASES_JCOBridge_C2JBridge_IJVMBridgeBase.htm"/></typeparam>
        /// <returns>The <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_IJVMBridgeDefinition_BridgeClassName.htm"/></returns>
        public static Java.Lang.Class<TClass> Class<TClass>() where TClass : IJVMBridgeBase, new()
        {
            var className = JVMBridgeBase.ClassNameOf<TClass>();
            return Java.Lang.Class<TClass>.SExecute<Java.Lang.Class<TClass>>("forName", className);
        }

        /// <summary>
        /// Retrieve the object associated to <paramref name="className"/>
        /// </summary>
        /// <param name="className">The java class to be instantiated</param>
        /// <returns>The instance associated to the requested <paramref name="className"/></returns>
        public static dynamic New(string className)
        {
            return New(className, null);
        }

        /// <summary>
        /// Retrieve the object associated to <paramref name="className"/>
        /// </summary>
        /// <param name="className">The java class to be instantiated</param>
        /// <param name="args">The argument of the costructor</param>
        /// <returns>The instance associated to the requested <paramref name="className"/></returns>
        public static dynamic New(string className, params object[] args)
        {
            return GlobalInstance.JVM.New(className, args);
        }

        #endregion
    }
}