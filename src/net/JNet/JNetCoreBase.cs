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
using MASES.JCOBridge.C2JBridge.JVMInterop;
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
        #region Initialization
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.LicensePath"/>
        /// </summary>
        public static string ApplicationLicensePath { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.JDKHome"/>
        /// </summary>
        public static string ApplicationJDKHome { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.JVMPath"/>
        /// </summary>
        public static string ApplicationJVMPath { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.JNIVerbosity"/>
        /// </summary>
        public static string ApplicationJNIVerbosity { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.JNIOutputFile"/>
        /// </summary>
        public static string ApplicationJNIOutputFile { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.JmxPort"/>
        /// </summary>
        public static short? ApplicationJmxPort { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.EnableDebug"/>
        /// </summary>
        public static bool? ApplicationEnableDebug { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.JavaDebugPort"/>
        /// </summary>
        public static short? ApplicationJavaDebugPort { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.DebugSuspendFlag"/>
        /// </summary>
        public static string ApplicationDebugSuspendFlag { get; set; }
        /// <summary>
        /// Sets the value of <see cref="SetupJVMWrapper{T}.JavaDebugOpts"/>
        /// </summary>
        public static string ApplicationJavaDebugOpts { get; set; }
        /// <summary>
        /// Sets the global value of the heap size
        /// </summary>
        public static string ApplicationHeapSize { get; set; }
        /// <summary>
        /// Sets the global value of the heap size
        /// </summary>
        public static string ApplicationInitialHeapSize { get; set; }
        /// <summary>
        /// Sets the global value of the log class path
        /// </summary>
        public static bool? ApplicationLogClassPath { get; set; }

        /// <inheritdoc cref="SetupJVMWrapper{T}.LicensePath" />
        public override string LicensePath { get { return ApplicationLicensePath ?? base.LicensePath; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.JDKHome" />
        public override string JDKHome { get { return ApplicationJDKHome ?? base.JDKHome; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.JVMPath" />
        public override string JVMPath { get { return ApplicationJVMPath ?? base.JVMPath; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.JNIVerbosity" />
        public override string JNIVerbosity { get { return ApplicationJNIVerbosity ?? base.JNIVerbosity; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.JNIOutputFile" />
        public override string JNIOutputFile { get { return ApplicationJNIOutputFile ?? base.JNIOutputFile; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.JmxPort" />
        public override short? JmxPort { get { return ApplicationJmxPort.HasValue ? ApplicationJmxPort : base.JmxPort; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.EnableDebug" />
        public override bool EnableDebug { get { return ApplicationEnableDebug ?? base.EnableDebug; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.JavaDebugPort" />
        public override short JavaDebugPort { get { return ApplicationJavaDebugPort ?? base.JavaDebugPort; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.DebugSuspendFlag" />
        public override string DebugSuspendFlag { get { return ApplicationDebugSuspendFlag != null ? ApplicationDebugSuspendFlag : base.DebugSuspendFlag; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.JavaDebugOpts" />
        public override string JavaDebugOpts { get { return ApplicationJavaDebugOpts != null ? ApplicationJavaDebugOpts : base.JavaDebugOpts; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.GlobalHeapSize" />
        public override string GlobalHeapSize { get { return string.IsNullOrEmpty(base.GlobalHeapSize) ? ApplicationHeapSize : base.GlobalHeapSize; } }
        /// <inheritdoc cref="SetupJVMWrapper{T}.InitialHeapSize" />
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
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.Throwable>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ArithmeticException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ArrayIndexOutOfBoundsException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ArrayStoreException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ClassCastException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ClassNotFoundException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.CloneNotSupportedException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.EnumConstantNotPresentException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.Exception>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.IllegalAccessException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.IllegalArgumentException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.IllegalMonitorStateException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.IllegalStateException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.IllegalThreadStateException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.IndexOutOfBoundsException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.InstantiationException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.InterruptedException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.NegativeArraySizeException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.NoSuchFieldException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.NoSuchMethodException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.NullPointerException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.NumberFormatException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ReflectiveOperationException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.RuntimeException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.SecurityException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.StringIndexOutOfBoundsException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.TypeNotPresentException>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.UnsupportedOperationException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.AbstractMethodError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.AssertionError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.BootstrapMethodError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ClassCircularityError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ClassFormatError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.Error>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ExceptionInInitializerError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.IllegalAccessError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.IncompatibleClassChangeError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.InstantiationError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.InternalError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.LinkageError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.NoClassDefFoundError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.NoSuchFieldError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.NoSuchMethodError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.OutOfMemoryError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.StackOverflowError>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.UnknownError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.UnsatisfiedLinkError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.UnsupportedClassVersionError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.VerifyError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.VirtualMachineError>();
        }

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

        /// <inheritdoc cref="SetupJVMWrapper.JVMOptions"/>
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
        /// Retrieve the <see cref="IJVMBridgeDefinition.ClassName"/> of <typeparamref name="T"></typeparamref>
        /// </summary>
        /// <typeparam name="T">A type implementing <see cref="IJVMBridgeBase"/></typeparam>
        /// <returns>The <see cref="IJVMBridgeDefinition.ClassName"/></returns>
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

    public static class JNetExtensions
    {
        /// <summary>
        /// Execute the method and build the result as an array of <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The expected result <see cref="Type"/></typeparam>
        /// <param name="instance">The <see cref="JVMBridgeBase"/> instance to execute on</param>
        /// <param name="methodName">The method to execute</param>
        /// <param name="args">The aruments</param>
        /// <returns>An array of <typeparamref name="T"/></returns>
        public static T[] IExecuteArray<T>(this JVMBridgeBase instance, string methodName, params object[] args)
        {
            bool assignable = typeof(IJVMBridgeBase).IsAssignableFrom(typeof(T));
            var array = instance.IExecute(methodName, args) as IJavaArray;
            if (array == null) return null;
            System.Collections.Generic.List<T> elements = new System.Collections.Generic.List<T>();
            foreach (var item in array)
            {
                if (assignable)
                {
                    elements.Add(JVMBridgeBase.Wraps<T>(item as IJavaObject));
                }
                else
                {
                    elements.Add((T)item);
                }
            }
            return elements.ToArray();
        }
    }
}