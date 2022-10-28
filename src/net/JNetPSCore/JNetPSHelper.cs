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
using System;
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
            MethodInfo method = source.TraverseUntil(destination).GetMethod(nameof(JNetCore.CreateGlobalInstance));
            return method.Invoke(null, args);
        }

        public static object RunStaticMethodOn<TContainingClass>(this Type source, string methodName, params object[] args)
        {
            return RunStaticMethodOn(source, typeof(TContainingClass), methodName, args);
        }
    }

    /// <summary>
    /// Public Helper class
    /// </summary>
    public static class JNetPSHelper<TClass> where TClass : JNetCore<TClass>
    {
        public static void SetLicensePath(string licensePath) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationLicensePath), licensePath); }

        public static void SetJDKHome(string jdkHome) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJDKHome), jdkHome); }

        public static void SetJVMPath(string jvmPath) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJVMPath), jvmPath); }

        public static void SetJNIVerbosity(string jniVerbosity) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJNIVerbosity), jniVerbosity); }

        public static void SetJNIOutputFile(string jniOutputFile) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJNIOutputFile), jniOutputFile); }

        public static void SetJmxPort(short? jmxPort) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJmxPort), jmxPort); }

        public static void SetEnableDebug(bool? enableDebug) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationEnableDebug), enableDebug); }

        public static void SetJavaDebugPort(short? javaDebugPort) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJavaDebugPort), javaDebugPort); }

        public static void SetDebugSuspendFlag(string debugSuspendFlag) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationDebugSuspendFlag), debugSuspendFlag); }

        public static void SetJavaDebugOpts(string javaDebugOpts) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationJavaDebugOpts), javaDebugOpts); }

        public static void SetHeapSize(string heapSize) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationHeapSize), heapSize); }

        public static void SetInitialHeapSize(string initialHeapSize) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationInitialHeapSize), initialHeapSize); }

        public static void SetLogClassPath(bool? logClassPath) { typeof(TClass).SetStaticPropertyOn(typeof(JNetCoreBase<>), nameof(JNetCore.ApplicationLogClassPath), logClassPath); }

        public static void CreateGlobalInstance()
        {
            _ = typeof(TClass).RunStaticMethodOn(typeof(SetupJVMWrapper<>), nameof(JNetCore.CreateGlobalInstance));
        }
    }
}