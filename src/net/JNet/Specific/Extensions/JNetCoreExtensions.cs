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

using Java.Nio;
using MASES.JCOBridge.C2JBridge;
using System;

namespace MASES.JNet.Specific.Extensions
{
    /// <summary>
    /// Extension class
    /// </summary>
    public static class JNetCoreExtensions
    {
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
            if (data is byte[]) return JVMBridgeBase.WrapsDirect<TWrap>(buf.JavaObject);
            else
            {
                IJVMBridgeBase ibb;
                ByteBuffer bb = JVMBridgeBase.WrapsDirect<ByteBuffer>(buf.JavaObject);
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
    }
}
