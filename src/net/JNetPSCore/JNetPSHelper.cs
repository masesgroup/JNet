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

using MASES.JCOBridge.C2JBridge;
using MASES.JNet;
using MASES.JNetPSCore.Cmdlet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading;

namespace MASES.JNetPSCore
{
    /// <summary>
    /// Public extension class
    /// </summary>
    public static class JNetPSHelperExtensions
    {
        static Type CheckOn(Type source, Type t)
        {
            if (t.IsGenericTypeDefinition)
            {
                if (source.IsGenericType)
                {
                    return source.GetGenericTypeDefinition();
                }
                else
                {
                    return source;
                }
            }
            return source;
        }
        /// <summary>
        /// Traverse the class chain from <paramref name="source"/> until <paramref name="t"/>
        /// </summary>
        /// <param name="source">The source</param>
        /// <param name="t">The target</param>
        /// <returns>The <see cref="Type"/> found</returns>
        public static Type TraverseUntil(this Type source, Type t)
        {
            var baseType = source;
            while (baseType != null && CheckOn(baseType, t) != t)
            {
                baseType = baseType.BaseType;
            }

            return baseType;
        }
        /// <summary>
        /// Generic static property getter
        /// </summary>
        /// <param name="origin">The origin</param>
        /// <param name="target">The target <see cref="Type"/> where the static property was defined</param>
        /// <param name="propertName">The property name</param>
        /// <returns>The property value</returns>
        public static object GetStaticPropertyOn(this Type origin, Type target, string propertyName)
        {
            PropertyInfo prop = origin.TraverseUntil(target).GetProperty(propertyName);
            return prop.GetValue(null);
        }
        /// <summary>
        /// Generic static property getter
        /// </summary>
        /// <typeparam name="TContainingClass">The target <see cref="Type"/> where the static property was defined</typeparam>
        /// <param name="origin">The origin</param>
        /// <param name="propertName">The property name</param>
        /// <returns>The property value</returns>
        public static object GetStaticPropertyOn<TContainingClass>(this Type origin, string propertyName)
        {
            return GetStaticPropertyOn(origin, typeof(TContainingClass), propertyName);
        }
        /// <summary>
        /// Generic static property setter
        /// </summary>
        /// <param name="origin">The origin</param>
        /// <param name="destination">The target <see cref="Type"/> where the static property was defined</param>
        /// <param name="propertName">The property name</param>
        /// <param name="value">The property value</param>
        public static void SetStaticPropertyOn(this Type origin, Type destination, string propertyName, object value)
        {
            PropertyInfo prop = origin.TraverseUntil(destination).GetProperty(propertyName);
            prop.SetValue(null, value);
        }
        /// <summary>
        /// Generic static property setter
        /// </summary>
        /// <typeparam name="TContainingClass">The target <see cref="Type"/> where the static property was defined</typeparam>
        /// <param name="origin">The origin</param>
        /// <param name="propertName">The property name</param>
        /// <param name="value">The property value</param>
        public static void SetStaticPropertyOn<TContainingClass>(this Type origin, string propertyName, object value)
        {
            SetStaticPropertyOn(origin, typeof(TContainingClass), propertyName, value);
        }
        /// <summary>
        /// Executes a static method defined in <paramref name="destination"/>
        /// </summary>
        /// <param name="origin">The origin</param>
        /// <param name="destination">The target <see cref="Type"/> where the static method was defined</param>
        /// <param name="methodName">The method name</param>
        /// <param name="args">The method arguments</param>
        /// <returns>The method result</returns>
        public static object RunStaticMethodOn(this Type origin, Type destination, string methodName, params object[] args)
        {
            List<Type> lst = new List<Type>();
            foreach (var item in args)
            {
                if (item == null) throw new ArgumentNullException("Cannot infer Type from a null value.");
                lst.Add(item.GetType());
            }

            MethodInfo method = origin.TraverseUntil(destination).GetMethod(methodName, lst.ToArray());
            if (method == null) throw new ArgumentException($"Not found method {methodName} with supplied arguments.");
            return method.Invoke(null, args);
        }
        /// <summary>
        /// Executes a static method defined in <paramref name="destination"/>
        /// </summary>
        /// <typeparam name="TContainingClass">The target <see cref="Type"/> where the static method was defined</typeparam>
        /// <param name="origin">The origin</param>
        /// <param name="methodName">The method name</param>
        /// <param name="args">The method arguments</param>
        /// <returns>The method result</returns>
        public static object RunStaticMethodOn<TContainingClass>(this Type source, string methodName, params object[] args)
        {
            return RunStaticMethodOn(source, typeof(TContainingClass), methodName, args);
        }
        /// <summary>
        /// The noun name of <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="System.Management.Automation.Cmdlet"/></typeparam>
        /// <param name="cmdlet">The <see cref="System.Management.Automation.Cmdlet"/></param>
        /// <returns>Noun name</returns>
        public static string NounName<T>(this T cmdlet) where T : System.Management.Automation.Cmdlet
        {
            return JNetPSHelper.NounName<T>();
        }
        /// <summary>
        /// The verb name of <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="System.Management.Automation.Cmdlet"/></typeparam>
        /// <param name="cmdlet">The <see cref="System.Management.Automation.Cmdlet"/></param>
        /// <returns>Verb name</returns>
        public static string VerbName<T>(this T cmdlet) where T : System.Management.Automation.Cmdlet
        {
            return JNetPSHelper.VerbName<T>();
        }

        internal static bool IsExternal<T>(this T cmdlet) where T : System.Management.Automation.PSCmdlet
        {
            return cmdlet.MyInvocation.BoundParameters.ContainsKey("JNetPSCmdletDetached");
        }

        internal static void InvokeExternal<T>(this T cmdlet) where T : PSCmdlet
        {
            System.Diagnostics.ProcessStartInfo psInfo = new System.Diagnostics.ProcessStartInfo();

            var filename = Environment.GetCommandLineArgs()[0];
            switch (Environment.OSVersion.Platform)
            {
                case PlatformID.Unix:
                    psInfo.FileName = "dotnet";
                    psInfo.Arguments = filename + " ";
                    break;
                case PlatformID.MacOSX:
                    throw new NotImplementedException();
                default:
                    psInfo.FileName = System.IO.Path.ChangeExtension(filename, "exe");
                    break;
            }

            var cmdletType = typeof(T);
            while (cmdletType.IsGenericType)
            {
                cmdletType = cmdletType.GetGenericArguments().First();
            }

            psInfo.WorkingDirectory = Path.GetDirectoryName(cmdletType.Assembly.Location);
            psInfo.UseShellExecute = false;
            psInfo.RedirectStandardInput = true;
            psInfo.RedirectStandardOutput = true;
            psInfo.RedirectStandardError = true;
            psInfo.CreateNoWindow = true;

            psInfo.Arguments += $"-Command Import-Module {cmdletType.Assembly.Location}; {cmdlet.VerbName()}-{cmdlet.NounName()}";
            psInfo.Arguments += " -JNetPSCmdletDetached";
            foreach (var item in cmdlet.MyInvocation.BoundParameters)
            {
                psInfo.Arguments += $" -{item.Key}";
                if (item.Value != null)
                {
                    if (item.Value is string)
                    {
                        psInfo.Arguments += $" '{item.Value}'";
                    }
                    else if (item.Value is IEnumerable enumerable)
                    {
                        foreach (var entry in enumerable)
                        {
                            psInfo.Arguments += $" '{entry}'";
                        }
                    }
                    else if (item.Value is SwitchParameter) continue;
                    else
                    {
                        psInfo.Arguments += $" '{item.Value}'";
                    }
                }
            }

            cmdlet.WriteVerbose($"Running: {psInfo.FileName} {psInfo.Arguments}");
            using (var proc = new System.Diagnostics.Process())
            {
                try
                {
                    processExited = cancelKeyRaised = false;
                    Console.CancelKeyPress += Console_CancelKeyPress;
                    proc.StartInfo = psInfo;
                    proc.ErrorDataReceived += Proc_ErrorDataReceived;
                    proc.OutputDataReceived += Proc_OutputDataReceived;
                    proc.Exited += Proc_Exited;
                    proc.Start();
                    proc.BeginErrorReadLine();
                    proc.BeginOutputReadLine();
                    while (!proc.HasExited)
                    {
                        if (Console.KeyAvailable)
                        {
                            var key = Console.ReadKey();
                            if (!processExited)
                            {
                                proc.StandardInput.Write(key.KeyChar);
                                if (key.Key == ConsoleKey.Enter) { Console.WriteLine(); }
                            }
                        }
                        else Thread.Sleep(1);

                        if (cancelKeyRaised)
                        {
                            proc.Kill();
                        }
                    }
                }
                finally
                {
                    proc.ErrorDataReceived -= Proc_ErrorDataReceived;
                    proc.OutputDataReceived -= Proc_OutputDataReceived;
                    Console.CancelKeyPress -= Console_CancelKeyPress;
                    proc.Exited -= Proc_Exited;
                }
                cmdlet.WriteVerbose($"Return code is: {proc.ExitCode}");
            }
        }

        static bool processExited = false;

        private static void Proc_Exited(object sender, EventArgs e)
        {
            processExited = true;
        }

        static bool cancelKeyRaised = false;

        private static void Console_CancelKeyPress(object sender, ConsoleCancelEventArgs e)
        {
            cancelKeyRaised = true;
        }

        private static void Proc_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            System.Console.WriteLine(e.Data);
        }

        private static void Proc_ErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            System.Console.WriteLine(e.Data);
        }
    }

    /// <summary>
    /// Generic public Helper class
    /// </summary>
    public static class JNetPSHelper
    {
        /// <summary>
        /// <see langword="true"/> if the <typeparamref name="T"/> needs to be executed externally
        /// </summary>
        /// <typeparam name="T">The <see cref="System.Management.Automation.Cmdlet"/></typeparam>
        /// <returns><see langword="true"/> if the <typeparamref name="T"/> needs to be executed externally</returns>
        public static bool NeedExternalProcess<T>() where T : System.Management.Automation.Cmdlet
        {
            var t = typeof(T);
            if (t.IsGenericType) t = t.GenericTypeArguments.FirstOrDefault();
            return t.IsDefined(typeof(JNetPSExternalize), false);
        }
        /// <summary>
        /// Extracts the noun name from the <see cref="CmdletAttribute"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="System.Management.Automation.Cmdlet"/></typeparam>
        /// <returns>The noun name</returns>
        public static string NounName<T>() where T : System.Management.Automation.Cmdlet
        {
            var t = typeof(T);
            if (t.IsGenericType) t = t.GenericTypeArguments.FirstOrDefault();
            if (!t.IsDefined(typeof(CmdletAttribute), false)) throw new PSInvalidOperationException("Missing Cmdlet attribute");
            var attribute = t.GetCustomAttributes(typeof(CmdletAttribute), false).First() as CmdletAttribute;
            return attribute.NounName;
        }
        /// <summary>
        /// Extracts the verb name from the <see cref="CmdletAttribute"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="System.Management.Automation.Cmdlet"/></typeparam>
        /// <returns>The verb name</returns>
        public static string VerbName<T>() where T : System.Management.Automation.Cmdlet
        {
            var t = typeof(T);
            if (t.IsGenericType) t = t.GenericTypeArguments.FirstOrDefault();
            if (!t.IsDefined(typeof(CmdletAttribute), false)) throw new PSInvalidOperationException("Missing Cmdlet attribute");
            var attribute = t.GetCustomAttributes(typeof(CmdletAttribute), false).First() as CmdletAttribute;
            return attribute.VerbName;
        }

        /// <summary>
        /// Wites full exception in <paramref name="e"/> raised from <paramref name="cmdlet"/>
        /// </summary>
        /// <param name="cmdlet">The <see cref="System.Management.Automation.Cmdlet"/> executing</param>
        /// <param name="e">The base <see cref="Exception"/> raised</param>
        public static void WriteExtendedError(this System.Management.Automation.Cmdlet cmdlet, Exception e)
        {
            var exception = e;
            while (exception != null)
            {
                cmdlet.WriteError(new ErrorRecord(exception, exception.Source, ErrorCategory.InvalidOperation, exception));
                if (exception is JVMBridgeException jvmException)
                {
                    exception = jvmException.InnerException;
                }
                else
                {
                    exception = exception.InnerException;
                }
            }
        }
    }

    /// <summary>
    /// Public Helper class customized on <typeparamref name="TClass"/>
    /// </summary>
    /// <typeparam name="TClass">A class extendind <see cref="JNetCore{T}"/></typeparam>
    public static class JNetPSHelper<TClass> where TClass : JNetCore<TClass>
    {
        static object _instanceCreatedLock = new object();
        static bool _instanceCreated = false;
        /// <summary>
        /// <see langword="true"/> if a call to <see cref="CreateGlobalInstance"/> was done
        /// </summary>
        public static bool InstanceCreated { get { lock (_instanceCreatedLock) { return _instanceCreated; } } }
        /// <summary>
        /// Generic static property getter
        /// </summary>
        /// <typeparam name="TProperty">Property type</typeparam>
        /// <param name="target">The target <see cref="Type"/> where the static property was defined</param>
        /// <param name="propertName">The property name</param>
        /// <returns>The property <typeparamref name="TProperty"/> value</returns>
        public static TProperty Get<TProperty>(Type target, string propertName) { return (TProperty)typeof(TClass).GetStaticPropertyOn(target, propertName); }
        /// <summary>
        /// Generic static property getter
        /// </summary>
        /// <typeparam name="TTarget">The target <see cref="Type"/> where the static property was defined</typeparam>
        /// <typeparam name="TProperty">Property type</typeparam>
        /// <param name="propertName">The property name</param>
        /// <returns>The property <typeparamref name="TProperty"/> value</returns>
        public static TProperty Get<TTarget, TProperty>(string propertName) { return (TProperty)typeof(TClass).GetStaticPropertyOn(typeof(TTarget), propertName); }
        /// <summary>
        /// Generic static property setter
        /// </summary>
        /// <typeparam name="TProperty">Property type</typeparam>
        /// <param name="target">The target <see cref="Type"/> where the static property was defined</param>
        /// <param name="propertName">The property name</param>
        /// <param name="value">The <typeparamref name="TProperty"/> property value</param>
        public static void Set<TProperty>(Type target, string propertName, TProperty value) { typeof(TClass).SetStaticPropertyOn(target, propertName, value); }
        /// <summary>
        /// Generic static property setter
        /// </summary>
        /// <typeparam name="TTarget">The target <see cref="Type"/> where the static property was defined</typeparam>
        /// <typeparam name="TProperty">Property type</typeparam>
        /// <param name="propertName">The property name</param>
        /// <param name="value">The <typeparamref name="TProperty"/> property value</param>
        public static void Set<TTarget, TProperty>(string propertName, TProperty value) { typeof(TClass).SetStaticPropertyOn(typeof(TTarget), propertName, value); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationLicensePath"/>
        /// </summary>
        public static void SetLicensePath(string licensePath) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationLicensePath), licensePath); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationJDKHome"/>
        /// </summary>
        public static void SetJDKHome(string jdkHome) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationJDKHome), jdkHome); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationJVMPath"/>
        /// </summary>
        public static void SetJVMPath(string jvmPath) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationJVMPath), jvmPath); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationJNIVerbosity"/>
        /// </summary>
        public static void SetJNIVerbosity(string jniVerbosity) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationJNIVerbosity), jniVerbosity); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationJNIOutputFile"/>
        /// </summary>
        public static void SetJNIOutputFile(string jniOutputFile) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationJNIOutputFile), jniOutputFile); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationJmxPort"/>
        /// </summary>
        public static void SetJmxPort(short? jmxPort) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationJmxPort), jmxPort); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationEnableDebug"/>
        /// </summary>
        public static void SetEnableDebug(bool? enableDebug) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationEnableDebug), enableDebug); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationJavaDebugPort"/>
        /// </summary>
        public static void SetJavaDebugPort(short? javaDebugPort) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationJavaDebugPort), javaDebugPort); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationDebugSuspendFlag"/>
        /// </summary>
        public static void SetDebugSuspendFlag(string debugSuspendFlag) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationDebugSuspendFlag), debugSuspendFlag); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationJavaDebugOpts"/>
        /// </summary>
        public static void SetJavaDebugOpts(string javaDebugOpts) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationJavaDebugOpts), javaDebugOpts); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationHeapSize"/>
        /// </summary>
        public static void SetHeapSize(string heapSize) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationHeapSize), heapSize); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationInitialHeapSize"/>
        /// </summary>
        public static void SetInitialHeapSize(string initialHeapSize) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationInitialHeapSize), initialHeapSize); }
        /// <summary>
        /// Sets <see cref="JNetCoreBase{T}.ApplicationLogClassPath"/>
        /// </summary>
        public static void SetLogClassPath(bool? logClassPath) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationLogClassPath), logClassPath); }
        /// <summary>
        /// Invokes <see cref="SetupJVMWrapper{T}.CreateGlobalInstance"/> to start engine
        /// </summary>
        /// <remarks>All properties must be set prior to execute this command. Updates to the JVM environment cannot be done later.</remarks>
        public static void CreateGlobalInstance(System.Management.Automation.Cmdlet cmdlet)
        {
            lock (_instanceCreatedLock)
            {
                if (_instanceCreated) { cmdlet.WriteWarning("A new CreateGlobalInstance requested, but it was previously requested."); return; }
                cmdlet.WriteDebug("Invoking CreateGlobalInstance");
                _ = typeof(TClass).RunStaticMethodOn(typeof(SetupJVMWrapper<>), nameof(JNetCore<TClass>.CreateGlobalInstance));
                cmdlet.WriteDebug("Invoked CreateGlobalInstance");
                _instanceCreated = true;
            }
        }
        /// <summary>
        /// Creates a new class instance
        /// </summary>
        /// <param name="className">The class to be created</param>
        /// <param name="args">The arguments of the constructor</param>
        /// <returns>The newly created object</returns>
        public static object New(string className, params object[] args)
        {
            return typeof(TClass).RunStaticMethodOn(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.New), className, args);
        }
    }
}