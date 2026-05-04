/*
*  Copyright (c) 2022-2026 MASES s.r.l.
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
using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JNet.Specific.Extensions;
using System;

namespace Java.Nio
{
    public partial class CharBuffer
    {
        // can be extended with methods not reflected or not available in Java;

        JCOBridgeDirectBuffer<char> _directBuffer = null;

        #region Operators

        /// <summary>
        /// Converter from <see cref="CharBuffer"/> to <see cref="Comparable{CharBuffer}"/>
        /// </summary>
        public static implicit operator Comparable<CharBuffer>(CharBuffer buffer) => buffer.Cast<Comparable<CharBuffer>>();
        /// <summary>
        /// Converts an instance of <see cref="CharBuffer"/> into <see cref="JCOBridgeDirectBuffer{T}"/>
        /// </summary>
        public static implicit operator JCOBridgeDirectBuffer<char>(CharBuffer t) => t.ToDirectBuffer();
        /// <summary>
        /// Converts an instance of <see cref="char"/> array into <see cref="CharBuffer"/> using the default parameters of <see cref="From(char[], bool, int)"/>
        /// </summary>
        /// <remarks>If the JVM supports direct access the function will share with the JVM the memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator CharBuffer(char[] t) => From(t);
        /// <summary>
        /// Converts an instance of <see cref="CharBuffer"/> into <see cref="char"/> array
        /// </summary>
        /// <remarks>If the <see cref="CharBuffer"/> supports direct access the function tries to move data from JVM memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator char[](CharBuffer t) => t.ToArray();

        #endregion

        #region Methods

        /// <summary>
        /// Returns the <see cref="char"/> array managed from this <see cref="CharBuffer"/>
        /// </summary>
        /// <param name="bypassDirectConvert"><see langword="true"/> to bypass the conversion using direct buffer</param>
        /// <returns>The <see cref="char"/> array managed from this <see cref="CharBuffer"/></returns>
        public char[] ToArray(bool bypassDirectConvert = false)
        {
            if (!bypassDirectConvert)
            {
                try
                {
                    return ToDirectBuffer().ToArray<char>();
                }
                catch (UnsupportedOperationException) { }
                catch (System.NotSupportedException) { }
            }
            return IExecuteWithSignatureArray<char>("array", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// Creates a new <see cref="CharBuffer"/> in the JVM which belongs to <paramref name="data"/>
        /// </summary>
        /// <param name="data">The data to be shared</param>
        /// <param name="arrangeCapacity">If <see langword="true"/> the <see cref="char"/> array in <paramref name="data"/> will be resized to the next power of 2, 
        /// so capacity will be memory aligned and the limit of java.nio.ByteBuffer will be current size of <paramref name="data"/>
        /// </param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <returns>A new instance of <see cref="CharBuffer"/></returns>
        public static CharBuffer From(char[] data, bool arrangeCapacity = true, int timeToLive = System.Threading.Timeout.Infinite)
        {
            try
            {
                return data.DirectBufferWithWrap<char, CharBuffer>(arrangeCapacity, timeToLive);
            }
            catch (UnsupportedOperationException) { }
            catch (System.NotSupportedException) { }

            return CharBuffer.Wrap(data);
        }
#if NET5_0_OR_GREATER
        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.AsSpan"/>
        public ReadOnlySpan<char> AsSpan()
        {
            return _directBuffer.AsSpan();
        }

        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.AsSpanFromIndex"/>
        public ReadOnlySpan<char> AsSpanFromIndex(int fromIndex)
        {
            return _directBuffer.AsSpanFromIndex(fromIndex);
        }

        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.AsWritableSpan"/>
        public Span<char> AsWritableSpan()
        {
            return _directBuffer.AsWritableSpan();
        }

        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.AsWritableSpanFromIndex(int)"/>
        public Span<char> AsWritableSpanFromIndex(int fromIndex)
        {
            return _directBuffer.AsWritableSpanFromIndex(fromIndex);
        }

        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.FlushOnDispose"/>
        public void FlushOnDispose()
        {

        }
#endif
        /// <summary>
        /// Returns an instance of <see cref="JCOBridgeDirectBuffer{T}"/> can be used to directly access and manages JVM memory without any memory move
        /// </summary>
        /// <returns>The <see cref="JCOBridgeDirectBuffer{T}"/> associated to this <see cref="ByteBuffer"/> instance</returns>
        /// <remarks>DO NOT DISPOSE: the returned <see cref="JCOBridgeDirectBuffer{T}"/> is an internal value disposed when this instance will be disposed</remarks>
        public JCOBridgeDirectBuffer<char> ToDirectBuffer()
        {
            // Rewind(); removed to avoid the build of a new ByteBuffer object will be discarded and replace with a more simple invocation
            // still remains the allocation of a returning object that is the copy of the current managed ByteBuffer, the copy will be immediately disposed to avoid GEN1 in GC
            using var _ = IExecuteWithSignature("rewind", "()Ljava/nio/Buffer;") as IJavaObject;
            return _directBuffer ??= JVM.GetDirectBuffer<char>(BridgeInstance);
        }
        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            _directBuffer?.Dispose();
            base.Dispose(disposing);
        }

        #endregion
    }
}
