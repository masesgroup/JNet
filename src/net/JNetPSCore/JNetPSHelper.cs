/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
using MASES.JNet.PowerShell.Cmdlet;
using MASES.JNet.Specific.CLI;
using MASES.JNet.Specific.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;
using System.Threading;

namespace MASES.JNet.PowerShell
{
    /// <summary>
    /// Public extension class
    /// </summary>
    public static class JNetPSHelperExtensions
    {
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
        /// Return an <see cref="IEnumerable{T}"/> of <see cref="string"> from the single <paramref name="arguments"/>
        /// </summary>
        /// <param name="arguments">The string to be splitted</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of <see cref="string"></returns>
        public static IEnumerable<string> ExtractArguments(string arguments)
        {
            string[] tmp = string.IsNullOrWhiteSpace(arguments) ? Array.Empty<string>() : arguments.Split(' ');
            return tmp.Where((arg) => !string.IsNullOrWhiteSpace(arg)).Select((arg) => arg.Trim());
        }
        /// <summary>
        /// Convert <see cref="PSObject"/> from the <see cref="IEnumerable{T}"/> of <see cref="object"> in <paramref name="arguments"/>
        /// </summary>
        /// <param name="arguments">The <see cref="IEnumerable{T}"/> of <see cref="object"> to be converted</param>
        /// <returns>An <see cref="IEnumerable{T}"/> of converted <see cref="object"></returns>
        public static IEnumerable<object> ConvertArguments(IEnumerable<object> arguments)
        {
            if (arguments != null)
            {
                List<object> objects = new List<object>();
                foreach (var item in arguments)
                {
                    if (item is PSObject psObject)
                    {
                        objects.Add(psObject.BaseObject);
                    }
                    else
                    {
                        objects.Add(item);
                    }
                }
                return objects.ToArray();
            }
            return Array.Empty<object>();
        }
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
        /// Sets <see cref="JNetCLICoreHelper.ApplicationClassToRun"/> using <see cref="NounName{T}"/>
        /// </summary>
        public static void SetClassToRunByNounName<T>() where T : System.Management.Automation.Cmdlet
        {
            JNetCLICoreHelper.ApplicationClassToRun = NounName<T>();
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
        /// Sets <see cref="JNetCoreBase{T}.ApplicationWriteEventOrExceptionOnCmdLine"/>
        /// </summary>
        public static void SetWriteEventOrExceptionOnCmdLine(bool? writeEventOrExceptionOnCmdLine) { Set(typeof(JNetCoreBase<>), nameof(JNetCore<TClass>.ApplicationWriteEventOrExceptionOnCmdLine), writeEventOrExceptionOnCmdLine); }

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
                try
                {
                    try
                    {
                        _ = typeof(TClass).RunStaticMethodOn(typeof(SetupJVMWrapper<>), nameof(JNetCore<TClass>.CreateGlobalInstance));
                    }
                    catch (TargetInvocationException tie) { throw tie.InnerException; }
                }
                catch (Exception jbe)
                {
                    cmdlet.WriteExtendedError(jbe);
                    cmdlet.WriteWarning("Something went wrong within CreateGlobalInstance, maybe the instance is unusable.");
                }
                finally
                {
                    cmdlet.WriteDebug("Invoked CreateGlobalInstance");
                    _instanceCreated = true;
                }
            }
        }
        /// <summary>
        /// Invokes <see cref="JNetCore{TClass}.Launch(Type, string[])"/> to start a Main-Class
        /// </summary>
        public static void Launch(Type type, params string[] args)
        {
            _ = typeof(TClass).RunStaticMethodOn(typeof(JNetCoreBase<>), nameof(JNetCoreBase<TClass>.Launch), type, args);
        }
        /// <summary>
        /// Creates a new class instance
        /// </summary>
        /// <param name="className">The class to be created</param>
        /// <param name="args">The arguments of the constructor</param>
        /// <returns>The newly created object</returns>
        public static object New(string className, params object[] args)
        {
            return typeof(TClass).RunStaticMethodOn(typeof(JNetCoreBase<>), nameof(JNetCoreBase<TClass>.New), className, args);
        }
        /// <summary>
        /// Adds <paramref name="jvmOptionName"/>, with optional <paramref name="jvmOptionValue"/>, to <see cref="ApplicationJVMExtraOptions"/>
        /// </summary>
        /// <param name="jvmOptionName">The JVM option name</param>
        /// <param name="jvmOptionValue">The value of <paramref name="jvmOptionName"/> if it is an option like name=value</param>
        public static void AddJVMOption(string jvmOptionName, string jvmOptionValue = null)
        {
            typeof(TClass).RunStaticMethodOn(typeof(JNetCoreBase<>), nameof(JNetCoreBase<TClass>.AddJVMOption), jvmOptionName, jvmOptionValue);
        }
    }
}