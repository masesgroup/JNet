﻿/*
*  Copyright 2024 MASES s.r.l.
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

using Java.Lang;
using MASES.JCOBridge.C2JBridge;
using MASES.JNet.Specific.Extensions;

namespace Java.Nio
{
    public partial class FloatBuffer
    {
        // can be extended with methods not reflected or not available in Java;

        #region Operators

        /// <summary>
        /// Converter from <see cref="FloatBuffer"/> to <see cref="Comparable{FloatBuffer}"/>
        /// </summary>
        public static implicit operator Comparable<FloatBuffer>(FloatBuffer buffer) => buffer.Cast<Comparable<FloatBuffer>>();
        /// <summary>
        /// Converts an instance of <see cref="FloatBuffer"/> into <see cref="JCOBridgeDirectBuffer{T}"/>
        /// </summary>
        public static implicit operator JCOBridgeDirectBuffer<float>(FloatBuffer t) => t.ToDirectBuffer();
        /// <summary>
        /// Converts an instance of <see cref="float"/> array into <see cref="FloatBuffer"/> using the default parameters of <see cref="From(float[], bool, bool, int)"/>
        /// </summary>
        /// <remarks>If the JVM supports direct access the function will share with the JVM the memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator FloatBuffer(float[] t) => From(t);
        /// <summary>
        /// Converts an instance of <see cref="FloatBuffer"/> into <see cref="float"/> array
        /// </summary>
        /// <remarks>If the <see cref="FloatBuffer"/> supports direct access the function tries to move data from JVM memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator float[](FloatBuffer t) => t.ToArray();

        #endregion

        #region Methods

        /// <summary>
        /// Returns the <see cref="float"/> array managed from this <see cref="FloatBuffer"/>
        /// </summary>
        /// <param name="bypassDirectConvert"><see langword="true"/> to bypass the conversion using direct buffer</param>
        /// <returns>The <see cref="float"/> array managed from this <see cref="FloatBuffer"/></returns>
        public float[] ToArray(bool bypassDirectConvert = false)
        {
            if (!bypassDirectConvert)
            {
                try
                {
                    return ToDirectBuffer().ToArray<float>();
                }
                catch (UnsupportedOperationException) { }
                catch (System.NotSupportedException) { }
            }
            return IExecuteWithSignatureArray<float>("array", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// Creates a new <see cref="FloatBuffer"/> in the JVM which belongs to <paramref name="data"/>
        /// </summary>
        /// <param name="data">The data to be shared</param>
        /// <param name="useMemoryControlBlock">Appends to the end of the <paramref name="data"/> a memory block will be used to controls and arbitrates memory between CLR and JVM</param>
        /// <param name="arrangeCapacity">If <see langword="true"/> the <see cref="float"/> array in <paramref name="data"/> will be resized to the next power of 2, 
        /// so capacity will be memory aligned and the limit of java.nio.ByteBuffer will be current size of <paramref name="data"/>
        /// </param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <returns>A new instance of <see cref="FloatBuffer"/></returns>
        public static FloatBuffer From(float[] data, bool useMemoryControlBlock = true, bool arrangeCapacity = true, int timeToLive = System.Threading.Timeout.Infinite)
        {
            try
            {
                return data.DirectBufferWithWrap<float, FloatBuffer>(useMemoryControlBlock, arrangeCapacity, timeToLive);
            }
            catch (UnsupportedOperationException) { }
            catch (System.NotSupportedException) { }

            return FloatBuffer.Wrap(data);
        }
        /// <summary>
        /// Returns an instance of <see cref="JCOBridgeDirectBuffer{T}"/>
        /// </summary>
        /// <returns>The <see cref="JCOBridgeDirectBuffer{T}"/> associated to this instance</returns>
        /// <remarks>The returned <see cref="JCOBridgeDirectBuffer{T}"/> can be used to directly access and manages JVM memory without any memory move</remarks>
        public JCOBridgeDirectBuffer<float> ToDirectBuffer()
        {
            Rewind();
            return JVM.GetDirectBuffer<float>(BridgeInstance);
        }

        #endregion
    }
}
