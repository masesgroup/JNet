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

using MASES.JCOBridge.C2JBridge;
using MASES.JNet;
using MASES.JNetPSCore.Cmdlet;
using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Reflection;

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

        public static Type TraverseUntil(this Type source, Type t)
        {
            var baseType = source;
            while (baseType != null && CheckOn(baseType, t) != t)
            {
                baseType = baseType.BaseType;
            }

            return baseType;
        }

        public static object GetStaticPropertyOn(this Type source, Type destination, string propertyName)
        {
            PropertyInfo prop = source.TraverseUntil(destination).GetProperty(propertyName);
            return prop.GetValue(null);
        }

        public static object GetStaticPropertyOn<TContainingClass>(this Type source, string propertyName)
        {
            return GetStaticPropertyOn(source, typeof(TContainingClass), propertyName);
        }

        public static void SetStaticPropertyOn(this Type source, Type destination, string propertyName, object value)
        {
            PropertyInfo prop = source.TraverseUntil(destination).GetProperty(propertyName);
            prop.SetValue(null, value);
        }

        public static void SetStaticPropertyOn<TContainingClass>(this Type source, string propertyName, object value)
        {
            SetStaticPropertyOn(source, typeof(TContainingClass), propertyName, value);
        }

        public static object RunStaticMethodOn(this Type source, Type destination, string methodName, params object[] args)
        {
            List<Type> lst = new List<Type>();
            foreach (var item in args)
            {
                if (item == null) throw new ArgumentNullException("Cannot infer Type from a null value.");
                lst.Add(item.GetType());
            }

            MethodInfo method = source.TraverseUntil(destination).GetMethod(methodName, lst.ToArray());
            if (method == null) throw new ArgumentException($"Not found method {methodName} with supplied arguments.");
            return method.Invoke(null, args);
        }

        public static object RunStaticMethodOn<TContainingClass>(this Type source, string methodName, params object[] args)
        {
            return RunStaticMethodOn(source, typeof(TContainingClass), methodName, args);
        }

        public static string NounName<T>(this T cmdlet) where T : System.Management.Automation.Cmdlet
        {
            return JNetPSHelper.NounName<T>();
        }

        public static string VerbName<T>(this T cmdlet) where T : System.Management.Automation.Cmdlet
        {
            return JNetPSHelper.VerbName<T>();
        }

        public static bool IsExternal<T>(this T cmdlet) where T : System.Management.Automation.PSCmdlet
        {
            return cmdlet.MyInvocation.BoundParameters.ContainsKey("JNetPSCmdletDetached");
        }

        public static void InvokeExternal<T>(this T cmdlet) where T : PSCmdlet
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
                    else
                    {
                        psInfo.Arguments += $" '{item.Value}'";
                    }
                }
            }

            cmdlet.WriteVerbose("Running: " + psInfo.Arguments);

            using (var proc = System.Diagnostics.Process.Start(psInfo))
            {
                try
                {
                    proc.ErrorDataReceived += Proc_ErrorDataReceived;
                    proc.BeginErrorReadLine();
                    proc.OutputDataReceived += Proc_OutputDataReceived;
                    proc.BeginOutputReadLine();
                    while (!proc.HasExited)
                    {
                        proc.StandardInput.Write(System.Console.In.Read());
                    }
                }
                finally
                {
                    proc.ErrorDataReceived -= Proc_ErrorDataReceived;
                    proc.OutputDataReceived -= Proc_OutputDataReceived;
                }
            }
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
        public static bool NeedExternalProcess<T>() where T : System.Management.Automation.Cmdlet
        {
            var t = typeof(T);
            if (t.IsGenericType) t = t.GenericTypeArguments.FirstOrDefault();
            return t.IsDefined(typeof(JNetPSExternalize), false);
        }

        public static string NounName<T>() where T : System.Management.Automation.Cmdlet
        {
            var t = typeof(T);
            if (t.IsGenericType) t = t.GenericTypeArguments.FirstOrDefault();
            if (!t.IsDefined(typeof(CmdletAttribute), false)) throw new PSInvalidOperationException("Missing Cmdlet attribute");
            var attribute = t.GetCustomAttributes(typeof(CmdletAttribute), false).First() as CmdletAttribute;
            return attribute.NounName;
        }

        public static string VerbName<T>() where T : System.Management.Automation.Cmdlet
        {
            var t = typeof(T);
            if (t.IsGenericType) t = t.GenericTypeArguments.FirstOrDefault();
            if (!t.IsDefined(typeof(CmdletAttribute), false)) throw new PSInvalidOperationException("Missing Cmdlet attribute");
            var attribute = t.GetCustomAttributes(typeof(CmdletAttribute), false).First() as CmdletAttribute;
            return attribute.VerbName;
        }
    }

    /// <summary>
    /// Public Helper class customized on <typeparamref name="TClass"/>
    /// </summary>
    /// <typeparam name="TClass">A class extendind <see cref="JNetCore{T}"/></typeparam>
    public static class JNetPSHelper<TClass> where TClass : JNetCore<TClass>
    {
        public static TProperty Get<TProperty>(Type target, string propertName) { return (TProperty)typeof(TClass).GetStaticPropertyOn(target, propertName); }

        public static TProperty Get<TTarget, TProperty>(string propertName) { return (TProperty)typeof(TClass).GetStaticPropertyOn(typeof(TTarget), propertName); }

        public static void Set<TProperty>(Type target, string propertName, TProperty value) { typeof(TClass).SetStaticPropertyOn(target, propertName, value); }

        public static void Set<TTarget, TProperty>(string propertName, TProperty value) { typeof(TClass).SetStaticPropertyOn(typeof(TTarget), propertName, value); }

        public static void SetLicensePath(string licensePath) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationLicensePath), licensePath); }

        public static void SetJDKHome(string jdkHome) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJDKHome), jdkHome); }

        public static void SetJVMPath(string jvmPath) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJVMPath), jvmPath); }

        public static void SetJNIVerbosity(string jniVerbosity) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJNIVerbosity), jniVerbosity); }

        public static void SetJNIOutputFile(string jniOutputFile) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJNIOutputFile), jniOutputFile); }

        public static void SetJmxPort(short? jmxPort) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJmxPort), jmxPort); }

        public static void SetEnableDebug(bool? enableDebug) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationEnableDebug), enableDebug); }

        public static void SetJavaDebugPort(short? javaDebugPort) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJavaDebugPort), javaDebugPort); }

        public static void SetDebugSuspendFlag(string debugSuspendFlag) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationDebugSuspendFlag), debugSuspendFlag); }

        public static void SetJavaDebugOpts(string javaDebugOpts) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJavaDebugOpts), javaDebugOpts); }

        public static void SetHeapSize(string heapSize) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationHeapSize), heapSize); }

        public static void SetInitialHeapSize(string initialHeapSize) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationInitialHeapSize), initialHeapSize); }

        public static void SetLogClassPath(bool? logClassPath) { Set(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationLogClassPath), logClassPath); }

        public static void CreateGlobalInstance()
        {
            _ = typeof(TClass).RunStaticMethodOn(typeof(SetupJVMWrapper<>), nameof(JNetCore.CreateGlobalInstance));
        }

        public static object New(string className, params object[] args)
        {
            return typeof(TClass).RunStaticMethodOn(typeof(JNetCoreBase<>), nameof(JNetCore.New), className, args);
        }
    }
}