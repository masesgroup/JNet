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
using System.Linq;

namespace MASES.JNet
{
    /// <summary>
    /// Public entry point of <see cref="JNetCore{T}"/>
    /// </summary>
    public abstract class JNetCore<T> : SetupJVMWrapper<T> where T : JNetCore<T>
    {
        /// <summary>
        /// Sets the global value of the heap size
        /// </summary>
        public static string ApplicationHeapSize { get; set; }

        /// <summary>
        /// Sets the global value of the heap size
        /// </summary>
        public static string ApplicationInitialHeapSize { get; set; }

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
        IEnumerable<IArgumentMetadataParsed> _parsedArgs = null;
        /// <summary>
        /// Arguments parsed
        /// </summary>
        public IEnumerable<IArgumentMetadataParsed> ParsedArgs => _parsedArgs;
        /// <summary>
        /// Public ctor
        /// </summary>
        public JNetCore()
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
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.ThreadDeath>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.UnknownError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.UnsatisfiedLinkError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.UnsupportedClassVersionError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.VerifyError>();
            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Lang.VirtualMachineError>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Util.Concurrent.ExecutionException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<Java.Sql.SQLException>();

            JCOBridge.C2JBridge.JCOBridge.RegisterException<JavaX.Naming.NamingException>();
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
            ClassPathBuilder builder = new(System.IO.Path.Combine(System.IO.Path.GetDirectoryName(typeof(JNetCore).Assembly.Location), "jnet-*.jar"));

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
    /// <summary>
    /// Concrete implementation of <see cref="JNetCore{T}"/>
    /// </summary>
    public class JNetCore : JNetCore<JNetCore>
    {
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
    }
}