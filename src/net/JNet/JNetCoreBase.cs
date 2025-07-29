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
using System;
using System.Collections.Concurrent;
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
        /// Sets the value of <see cref="SetupJVMWrapper.LicensePath" />
        /// </summary>
        public static string ApplicationLicensePath { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.JDKHome" />
        /// </summary>
        public static string ApplicationJDKHome { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.JVMPath" />
        /// </summary>
        public static string ApplicationJVMPath { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.JNIVerbosity" />
        /// </summary>
        public static string ApplicationJNIVerbosity { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.JNIOutputFile" />
        /// </summary>
        public static string ApplicationJNIOutputFile { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.JmxPort" />
        /// </summary>
        public static short? ApplicationJmxPort { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.EnableDebug" />
        /// </summary>
        public static bool? ApplicationEnableDebug { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.JavaDebugPort" />
        /// </summary>
        public static short? ApplicationJavaDebugPort { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.DebugSuspendFlag" />
        /// </summary>
        public static string ApplicationDebugSuspendFlag { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper.JavaDebugOpts" />
        /// </summary>
        public static string ApplicationJavaDebugOpts { get; set; }
        /// <summary>
        /// Sets the global value of <see cref="SetupJVMWrapper.GlobalHeapSize" />
        /// </summary>
        public static string ApplicationHeapSize { get; set; }
        /// <summary>
        /// Sets the global value of the <see cref="SetupJVMWrapper.InitialHeapSize" />
        /// </summary>
        public static string ApplicationInitialHeapSize { get; set; }
        /// <summary>
        /// Sets the global value of the log class path
        /// </summary>
        public static bool? ApplicationLogClassPath { get; set; }
        /// <summary>
        /// Generic extra options to be used from JVM
        /// </summary>
        public static IDictionary<string, string> ApplicationJVMExtraOptions { get; } = new ConcurrentDictionary<string, string>();

        /// <inheritdoc/>
        public override string LicensePath { get { return ApplicationLicensePath ?? base.LicensePath; } }
        /// <inheritdoc/>
        public override string JDKHome { get { return ApplicationJDKHome ?? base.JDKHome; } }
        /// <inheritdoc/>
        public override string JVMPath { get { return ApplicationJVMPath ?? base.JVMPath; } }
        /// <inheritdoc/>
        public override string JNIVerbosity { get { return ApplicationJNIVerbosity ?? base.JNIVerbosity; } }
        /// <inheritdoc/>
        public override string JNIOutputFile { get { return ApplicationJNIOutputFile ?? base.JNIOutputFile; } }
        /// <inheritdoc/>
        public override short? JmxPort { get { return ApplicationJmxPort.HasValue ? ApplicationJmxPort : base.JmxPort; } }
        /// <inheritdoc/>
        public override bool EnableDebug { get { return ApplicationEnableDebug ?? base.EnableDebug; } }
        /// <inheritdoc/>
        public override short JavaDebugPort { get { return ApplicationJavaDebugPort ?? base.JavaDebugPort; } }
        /// <inheritdoc/>
        public override string DebugSuspendFlag { get { return ApplicationDebugSuspendFlag != null ? ApplicationDebugSuspendFlag : base.DebugSuspendFlag; } }
        /// <inheritdoc/>
        public override string JavaDebugOpts { get { return ApplicationJavaDebugOpts != null ? ApplicationJavaDebugOpts : base.JavaDebugOpts; } }
        /// <inheritdoc/>
        public override string GlobalHeapSize { get { return string.IsNullOrEmpty(base.GlobalHeapSize) ? ApplicationHeapSize : base.GlobalHeapSize; } }
        /// <inheritdoc/>
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
            JCOBridge.C2JBridge.JCOBridge.RegisterExceptions(typeof(JNetCoreBase<>).Assembly);
        }

        void EventOrExceptionHandlerInternal(object o, EventOrExceptionEventArgs e)
        {
            EventOrExceptionHandler(e);
        }
        /// <summary>
        /// Manages events raised from the underlying JCOBridge engine; see <see cref="JCOBridge.C2JBridge.JCOBridge.SetEventOrExceptionHandler(EventHandler{EventOrExceptionEventArgs})"/>
        /// </summary>
        /// <param name="e">The <see cref="EventOrExceptionEventArgs"/> with information</param>
        protected virtual void EventOrExceptionHandler(EventOrExceptionEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(e.Message)) Console.WriteLine(e.Message);
            else if (e.Error is LicenseManager.Common.FallbackInTrialModeException || e.Error is LicenseManager.Common.MissingLicenseException) return;
            else if (e.Error != null)
            {
                Console.WriteLine();
                Console.WriteLine("{0}: {1}", e.Error.GetType().Name, e.Error.Message);
                Console.WriteLine();
            }
        }
        /// <inheritdoc/>
        protected override void PreInitialization(ref string scopeOn, ref Version scopeOnVersion)
        {
            base.PreInitialization(ref scopeOn, ref scopeOnVersion);
            JCOBridge.C2JBridge.JCOBridge.SetEventOrExceptionHandler(EventOrExceptionHandlerInternal);
        }

        /// <inheritdoc/>
        protected override string[] ProcessCommandLine()
        {
            JCOBridge.C2JBridge.JCOBridge.SetEventOrExceptionHandler(EventOrExceptionHandlerInternal);
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
        /// <summary>
        /// Replace environment variable in <paramref name="item"/>
        /// </summary>
        /// <param name="item">The string where the environemnt variables shall be replaced</param>
        /// <returns>The string with replaced environment varibales</returns>
        /// <remarks>Each environment variable is expected in the form $(ENV_VAR)</remarks>
        public static string ReplaceEnvironmentVariable(string item)
        {
            const string startTemplate = "$(";
            const string endTemplate = ")";

            if (!string.IsNullOrWhiteSpace(item))
            {
                int firstIndex = 0;
                while ((firstIndex = item.IndexOf(startTemplate, firstIndex)) != -1)
                {
                    var secondIndex = item.IndexOf(endTemplate, firstIndex);
                    if (secondIndex != -1)
                    {
                        var envVar = item.Substring(firstIndex + startTemplate.Length, secondIndex - (firstIndex + startTemplate.Length));
                        var envVal = Environment.GetEnvironmentVariable(envVar);
                        if (envVal != null)
                        {
                            item = item.Replace($"{startTemplate}{envVar}{endTemplate}", envVal);
                        }
                    }
                    firstIndex = secondIndex;
                }
            }
            return item;
        }

        /// <inheritdoc/>
        public sealed override IEnumerable<KeyValuePair<string, string>> JVMOptions
        {
            get
            {
                IDictionary<string, string> opt = new Dictionary<string, string>();
                var jvmOptions = base.JVMOptions;
                if (jvmOptions != null)
                {
                    foreach (var item in jvmOptions)
                    {
                        opt.Add(new KeyValuePair<string, string>(ReplaceEnvironmentVariable(item.Key), ReplaceEnvironmentVariable(item.Value)));
                    }
                }
                var options = Options;
                if (options != null)
                {
                    foreach (var item in options)
                    {
                        try
                        {
                            opt.Add(new KeyValuePair<string, string>(ReplaceEnvironmentVariable(item.Key), ReplaceEnvironmentVariable(item.Value)));
                        }
                        catch (Exception e)
                        {
                            throw new ArgumentException($"Cannot add option {item.Key}: {e.Message}", e);
                        }
                    }
                }
                foreach (var item in ApplicationJVMExtraOptions)
                {
                    try
                    {
                        opt.Add(new KeyValuePair<string, string>(ReplaceEnvironmentVariable(item.Key), ReplaceEnvironmentVariable(item.Value)));
                    }
                    catch (Exception e)
                    {
                        throw new ArgumentException($"Cannot add option {item.Key}: {e.Message}", e);
                    }
                }
                return opt;
            }
        }

        string classPath = string.Empty;
        /// <inheritdoc/>
#if JNETREFLECTOR
        public override string ClassPath => buildClassPath();
#else
        public sealed override string ClassPath => buildClassPath();
#endif
        /// <summary>
        /// A list of paths to be used in initialization of JVM ClassPath
        /// </summary>
        protected virtual IList<string> PathToParse => new List<string>();

        string buildClassPath()
        {
            ClassPathBuilder builder = new();

            var pathToParse = PathToParse;

            if (pathToParse != null) builder.Add(pathToParse.ToArray());

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
        /// <summary>
        /// Adds <paramref name="jvmOptionName"/>, with optional <paramref name="jvmOptionValue"/>, to <see cref="ApplicationJVMExtraOptions"/>
        /// </summary>
        /// <param name="jvmOptionName">The JVM option name</param>
        /// <param name="jvmOptionValue">The value of <paramref name="jvmOptionName"/> if it is an option like name=value</param>
        public static void AddJVMOption(string jvmOptionName, string jvmOptionValue = null)
        {
            if (string.IsNullOrWhiteSpace(jvmOptionName)) return;
            ApplicationJVMExtraOptions.Add(jvmOptionName, jvmOptionValue);
        }

        /// <inheritdoc cref="Parser.HelpInfo(int?)"/>
        public static string HelpInfo(int? width = null) => Parser.HelpInfo(width);

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

        /// <summary>
        /// Launch the <typeparamref name="TClass"/> class with the <see cref="SetupJVMWrapper.FilteredArgs"/> arguments
        /// </summary>
        /// <typeparam name="TClass">A type which is defined as Main-Class</typeparam>
        public static void LaunchWithFilteredArgs<TClass>()
            where TClass : IJVMBridgeMain
        {
            Launch<TClass>(FilteredArgs);
        }

        /// <summary>
        /// Launch the <typeparamref name="TClass"/> class with the <paramref name="args"/> arguments
        /// </summary>
        /// <typeparam name="TClass">A type which is defined as Main-Class</typeparam>
        /// <param name="args">The arguments of the main method</param>
        public static new void Launch<TClass>(params string[] args)
            where TClass : IJVMBridgeMain
        {
            Launch(typeof(TClass), args);
        }

        /// <summary>
        /// Launch the <paramref name="type"/> with the <see cref="SetupJVMWrapper.FilteredArgs"/> arguments
        /// </summary>
        /// <param name="type">The <see cref="Type"/> extending <see cref="IJVMBridgeMain"/></param>
        public static void LaunchWithFilteredArgs(Type type)
        {
            Launch(type, FilteredArgs);
        }

        /// <summary>
        /// Launch the <paramref name="type"/> with the <paramref name="args"/> arguments
        /// </summary>
        /// <param name="type">The <see cref="Type"/> extending <see cref="IJVMBridgeMain"/></param>
        /// <param name="args">The arguments of the main method</param>
        public static new void Launch(Type type, params string[] args)
        {
            if (type == null) throw new ArgumentNullException(nameof(type));

            try
            {
                SetupJVMWrapper<T>.Launch(type, args);
            }
            catch (ArgumentException)
            {
#if !JNETREFLECTOR && !JNET_SIMPLIFIED_GENERATION
                if (type.GetInterface(typeof(IJVMBridgeMain).Name) == null) throw;
                var execType = type;
                do
                {
                    if (args.Length == 0)
                    {
                        System.Reflection.MethodInfo method = execType.GetMethods().FirstOrDefault(method => method.Name == "SExecute" & method.GetParameters().Length == 2 & method.IsGenericMethod == false);
                        if (method != null)
                        {
                            method.Invoke(null, new object[] { "main", new object[] { args } });
                            return;
                        }
                    }
                    else
                    {
                        System.Reflection.MethodInfo method = execType.GetMethod("Main", new Type[] { typeof(Java.Lang.String[]) });
                        if (method != null)
                        {
                            Java.Lang.String[] strings = new Java.Lang.String[args.Length];
                            for (int i = 0; i < args.Length; i++)
                            {
                                strings[i] = args[i];
                            }
                            method.Invoke(null, new object[] { strings });
                        }
                        return;
                    }
                    execType = execType.BaseType;
                }
                while (execType != null && execType != typeof(object));
#endif
            }
            throw new ArgumentException($"{type} does not define any IJVMBridgeMain type or interface", "type");
        }

        #endregion
    }
}