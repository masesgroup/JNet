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

using Java.Nio;
using MASES.JCOBridge.C2JBridge;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace MASES.JNet.Specific.Extensions
{
    /// <summary>
    /// Extension class
    /// </summary>
    public static class JNetCoreExtensions
    {
        /// <summary>
        /// Builds a new var-arg result starting from fixed parameters stored in <paramref name="fixedParameters"/> and the <see langword="params"/> argument available in <paramref name="varArg"/>
        /// </summary>
        /// <typeparam name="T">A supporting type if <see langword="params"/> has a type different from <see langword="object"/></typeparam>
        /// <param name="varArg">The <see langword="params"/> parameter reported as array</param>
        /// <param name="fixedParameters">The fixed parameters listed as <see langword="params"/></param>
        /// <returns>A new array to be passed to the <see langword="params"/> argument with <paramref name="fixedParameters"/> concatedned with <paramref name="varArg"/></returns>
        public static object[] VarArgRebuild<T>(this T[] varArg, params object[] fixedParameters)
        {
            List<object> varArgs = new List<object>(fixedParameters);
            if (varArg != null)
            {
                foreach (var item in varArg)
                {
                    varArgs.Add(item);
                }
            }
            return varArgs.ToArray();
        }

        /// <summary>
        /// Retrieve the <see cref="Java.Lang.Class{TClass}"/> from the <typeparamref name="TClass"/>
        /// </summary>
        /// <typeparam name="TClass">A class extending <see cref="IJVMBridgeBase"/></typeparam>
        /// <returns>The <see cref="Java.Lang.Class{TClass}"/></returns>
        public static Java.Lang.Class<TClass> Class<TClass>(this TClass _) where TClass : IJVMBridgeBase, new()
        {
            return Java.Lang.Class.Of<TClass>();
        }

        /// <summary>
        /// The method creates a <see cref="ByteBuffer"/> and wrap it into <typeparamref name="TWrap"/>
        /// </summary>
        /// <typeparam name="TData">The data to be wrapped</typeparam>
        /// <typeparam name="TWrap">The wrapping class</typeparam>
        /// <param name="data">The array of <typeparamref name="TData"/> to be wrapped</param>
        /// <param name="useMemoryControlBlock">Appends to the end of the <paramref name="data"/> a memory block will be used to controls and arbitrates memory between CLR and JVM</param>
        /// <param name="arrangeCapacity">If <see langword="true"/> the <typeparamref name="TData"/> array in <paramref name="data"/> will be resized to the next power of 2, 
        /// so capacity will be memory aligned and the limit of java.nio.ByteBuffer will be current size of <paramref name="data"/>
        /// </param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <param name="converter">A <see cref="Func{T, TResult}"/> that receives the prepared <see cref="ByteBuffer"/> and shall return <typeparamref name="TWrap"/></param>
        /// <returns>The <typeparamref name="TWrap"/> instance</returns>
        public static TWrap DirectBufferWithWrap<TData, TWrap>(this TData[] data, bool useMemoryControlBlock = true, bool arrangeCapacity = true, int timeToLive = System.Threading.Timeout.Infinite, Func<ByteBuffer, TWrap> converter = null) where TWrap : IJVMBridgeBase, new()
        {
            var buf = JCOBridge.C2JBridge.JCOBridge.Global.JVM.NewDirectBuffer(data, useMemoryControlBlock, arrangeCapacity, timeToLive);
            if (data is byte[]) return JVMBridgeBase.WrapsDirect<TWrap>(buf.DisableCleanupAndReturn());
            else
            {
                IJVMBridgeBase ibb;
                ByteBuffer bb = JVMBridgeBase.WrapsDirect<ByteBuffer>(buf.DisableCleanupAndReturn());
                bb.Order(BitConverter.IsLittleEndian ? ByteOrder.LITTLE_ENDIAN : ByteOrder.BIG_ENDIAN);
                if (data is char[]) ibb = bb.AsCharBuffer();
                else if (data is double[]) ibb = bb.AsDoubleBuffer();
                else if (data is float[]) ibb = bb.AsFloatBuffer();
                else if (data is int[]) ibb = bb.AsIntBuffer();
                else if (data is long[]) ibb = bb.AsLongBuffer();
                else if (data is short[]) ibb = bb.AsShortBuffer();
                else if (converter != null) ibb = converter(bb);
                else throw new System.InvalidCastException($"{typeof(TData)} does not have a ready made counter part, try use the converter to return {typeof(TWrap)}");
                return JVMBridgeBase.WrapsDirect<TWrap>(ibb.BridgeInstance);
            }
        }

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
        /// <param name="propertyName">The property name</param>
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
        /// <param name="propertyName">The property name</param>
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
        /// <param name="propertyName">The property name</param>
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
        /// <param name="propertyName">The property name</param>
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
        /// <param name="types">The <see cref="Type"/> of the arguments</param>
        /// <param name="args">The method arguments</param>
        /// <returns>The method result</returns>
        public static object RunStaticMethodOn(this Type origin, Type destination, string methodName, Type[] types, params object[] args)
        {
            MethodInfo method = origin.TraverseUntil(destination).GetMethod(methodName, types);
            if (method == null) throw new ArgumentException($"Not found method {methodName} with supplied arguments.");
            return method.Invoke(null, args);
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

            return RunStaticMethodOn(origin, destination, methodName, lst.ToArray(), args);
        }
        /// <summary>
        /// Executes a static method defined in <paramref name="source"/>
        /// </summary>
        /// <typeparam name="TContainingClass">The target <see cref="Type"/> where the static method was defined</typeparam>
        /// <param name="source">The origin</param>
        /// <param name="methodName">The method name</param>
        /// <param name="args">The method arguments</param>
        /// <returns>The method result</returns>
        public static object RunStaticMethodOn<TContainingClass>(this Type source, string methodName, params object[] args)
        {
            return RunStaticMethodOn(source, typeof(TContainingClass), methodName, args);
        }
    }
}
