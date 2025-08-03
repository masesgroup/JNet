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
using Java.Util;
using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace MASES.JNet.Specific
{
    /// <summary>
    /// Helper class of JNet for some specific operations
    /// </summary>
    public sealed class JNetHelper : MASES.JCOBridge.C2JBridge.JVMBridgeBase<JNetHelper>
    {
        const string _bridgeClassName = "org.mases.jnet.developed.JNetHelper";

        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <inheritdoc/>
        public override string BridgeClassName => _bridgeClassName;
        /// <inheritdoc/>
        public override bool IsBridgeAbstract => false;
        /// <inheritdoc/>
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc/>
        public override bool IsBridgeInterface => false;
        /// <inheritdoc/>
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// Retrieve the <see cref="IJVMBridgeDefinition.BridgeClassName"/> of <typeparamref name="TClass"></typeparamref>
        /// </summary>
        /// <typeparam name="TClass">A type implementing <see cref="IJVMBridgeBase"/></typeparam>
        /// <returns>The <see cref="IJVMBridgeDefinition.BridgeClassName"/></returns>
        public static Java.Lang.Class<TClass> Class<TClass>() where TClass : IJVMBridgeBase, new()
        {
            var className = JVMBridgeBase.ClassNameOf<TClass>();
            return Java.Lang.Class<TClass>.SExecute<Java.Lang.Class<TClass>>("forName", className);
        }

        /// <summary>
        /// Executes the <see href="https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/Arrays.html#asList(T...)"/> over primitive types
        /// </summary>
        /// <param name="data">Array of primitive types</param>
        /// <param name="buffered">Set to <see langword="true"/> to use <see cref="ByteBuffer"/>, <see cref="IntBuffer"/>, <see cref="DoubleBuffer"/> and so on to transfer data to JVM</param>
        /// <returns>A <see cref="Java.Util.List"/> can be used as input of <see cref="ArrayList{T}"/></returns>
        public static List ListFrom<T>(T[] data, bool buffered = false)
        {
            if (data == null) throw new ArgumentNullException(nameof(data));
            if (!buffered)
            {
                return SExecute<List>(LocalBridgeClazz, "listFromPrimitiveArray", data);
            }
            else
            {
                var buf = JCOBridge.C2JBridge.JCOBridge.Global.JVM.NewDirectBuffer(data, false, false);
                ByteBuffer bb = JVMBridgeBase.WrapsDirect<ByteBuffer>(buf.JavaObject);
                if (data is byte[]) return ListFrom(bb);
                else
                {
                    bb.Order(BitConverter.IsLittleEndian ? ByteOrder.LITTLE_ENDIAN : ByteOrder.BIG_ENDIAN);
                    if (data is char[]) return ListFrom(bb.AsCharBuffer());
                    else if (data is double[]) return ListFrom(bb.AsDoubleBuffer());
                    else if (data is float[]) return ListFrom(bb.AsFloatBuffer());
                    else if (data is int[]) return ListFrom(bb.AsIntBuffer());
                    else if (data is long[]) return ListFrom(bb.AsLongBuffer());
                    else if (data is short[]) return ListFrom(bb.AsShortBuffer());
                    else throw new System.InvalidCastException($"{typeof(T)} does not have a ready made counter part");
                }
            }
        }

        /// <summary>
        /// Executes the <see href="https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/Arrays.html#asList(T...)"/> using a <see cref="ByteBuffer"/> in <paramref name="arg0"/>
        /// </summary>
        /// <param name="arg0"><see cref="ByteBuffer"/> to be used</param>
        /// <returns>A <see cref="Java.Util.List"/> can be used as input of <see cref="ArrayList{T}"/></returns>
        public static List ListFrom(ByteBuffer arg0)
        {
            return SExecute<List>(LocalBridgeClazz, "listFromByteBuffer", arg0);
        }

        /// <summary>
        /// Executes the <see href="https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/Arrays.html#asList(T...)"/> using a <see cref="CharBuffer"/> in <paramref name="arg0"/>
        /// </summary>
        /// <param name="arg0"><see cref="CharBuffer"/> to be used</param>
        /// <returns>A <see cref="Java.Util.List"/> can be used as input of <see cref="ArrayList{T}"/></returns>
        public static List ListFrom(CharBuffer arg0)
        {
            return SExecute<List>(LocalBridgeClazz, "listFromCharBuffer", arg0);
        }

        /// <summary>
        /// Executes the <see href="https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/Arrays.html#asList(T...)"/> using a <see cref="DoubleBuffer"/> in <paramref name="arg0"/>
        /// </summary>
        /// <param name="arg0"><see cref="DoubleBuffer"/> to be used</param>
        /// <returns>A <see cref="Java.Util.List"/> can be used as input of <see cref="ArrayList{T}"/></returns>
        public static List ListFrom(DoubleBuffer arg0)
        {
            return SExecute<List>(LocalBridgeClazz, "listFromDoubleBuffer", arg0);
        }

        /// <summary>
        /// Executes the <see href="https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/Arrays.html#asList(T...)"/> using a <see cref="FloatBuffer"/> in <paramref name="arg0"/>
        /// </summary>
        /// <param name="arg0"><see cref="FloatBuffer"/> to be used</param>
        /// <returns>A <see cref="Java.Util.List"/> can be used as input of <see cref="ArrayList{T}"/></returns>
        public static List ListFrom(FloatBuffer arg0)
        {
            return SExecute<List>(LocalBridgeClazz, "listFromFloatBuffer", arg0);
        }

        /// <summary>
        /// Executes the <see href="https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/Arrays.html#asList(T...)"/> using a <see cref="IntBuffer"/> in <paramref name="arg0"/>
        /// </summary>
        /// <param name="arg0"><see cref="IntBuffer"/> to be used</param>
        /// <returns>A <see cref="Java.Util.List"/> can be used as input of <see cref="ArrayList{T}"/></returns>
        public static List ListFrom(IntBuffer arg0)
        {
            return SExecute<List>(LocalBridgeClazz, "listFromIntBuffer", arg0);
        }

        /// <summary>
        /// Executes the <see href="https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/Arrays.html#asList(T...)"/> using a <see cref="LongBuffer"/> in <paramref name="arg0"/>
        /// </summary>
        /// <param name="arg0"><see cref="LongBuffer"/> to be used</param>
        /// <returns>A <see cref="Java.Util.List"/> can be used as input of <see cref="ArrayList{T}"/></returns>
        public static List ListFrom(LongBuffer arg0)
        {
            return SExecute<List>(LocalBridgeClazz, "listFromLongBuffer", arg0);
        }

        /// <summary>
        /// Executes the <see href="https://docs.oracle.com/en%2Fjava%2Fjavase%2F11%2Fdocs%2Fapi%2F%2F/java.base/java/util/Arrays.html#asList(T...)"/> using a <see cref="ShortBuffer"/> in <paramref name="arg0"/>
        /// </summary>
        /// <param name="arg0"><see cref="ShortBuffer"/> to be used</param>
        /// <returns>A <see cref="Java.Util.List"/> can be used as input of <see cref="ArrayList{T}"/></returns>
        public static List ListFrom(ShortBuffer arg0)
        {
            return SExecute<List>(LocalBridgeClazz, "listFromShortBuffer", arg0);
        }
    }
}
