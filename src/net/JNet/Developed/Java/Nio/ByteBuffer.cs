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

using Java.Lang;
using MASES.JCOBridge.C2JBridge;
using MASES.JNet.Specific.Extensions;
using System.IO;
using System;

namespace Java.Nio
{
    public partial class ByteBuffer : IDisposable
    {
        // can be extended with methods not reflected or not available in Java;

        #region Operators

        /// <summary>
        /// Converter from <see cref="ByteBuffer"/> to <see cref="Comparable{ByteBuffer}"/>
        /// </summary>
        public static implicit operator Comparable<ByteBuffer>(ByteBuffer buffer) => buffer.Cast<Comparable<ByteBuffer>>();
        /// <summary>
        /// Converts an instance of <see cref="ByteBuffer"/> into <see cref="JCOBridgeDirectBuffer{T}"/>
        /// </summary>
        public static implicit operator JCOBridgeDirectBuffer<byte>(ByteBuffer t) => t.ToDirectBuffer();
        /// <summary>
        /// Converts an instance of <see cref="byte"/> array into <see cref="ByteBuffer"/> using the default parameters of <see cref="From(byte[], bool, bool, int)"/>
        /// </summary>
        /// <remarks>If the JVM supports direct access the function will share with the JVM the memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator ByteBuffer(byte[] t) => From(t);
        /// <summary>
        /// Converts an instance of <see cref="ByteBuffer"/> into <see cref="byte"/> array
        /// </summary>
        /// <remarks>If the <see cref="ByteBuffer"/> supports direct access the function tries to move data from JVM memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator byte[](ByteBuffer t) => t.ToArray();
        /// <summary>
        /// Converts an instance of <see cref="System.IO.MemoryStream"/> into a <see cref="ByteBuffer"/> using the default parameters of <see cref="From(MemoryStream, bool, EventHandler{MemoryStream}, int)"/>
        /// </summary>
        /// <remarks>See remarks of <see cref="From(MemoryStream, bool, EventHandler{MemoryStream}, int)"/></remarks>
        public static implicit operator ByteBuffer(System.IO.MemoryStream stream) => From(stream);
        /// <summary>
        /// Converts an instance of <see cref="ByteBuffer"/> into <see cref="System.IO.Stream"/>
        /// </summary>
        /// <remarks>The returned <see cref="System.IO.Stream"/> can be used to directly access and manages JVM memory without any memory move</remarks>
        public static implicit operator System.IO.Stream(ByteBuffer t) => t.ToStream();

        #endregion

        #region Methods

        /// <summary>
        /// Returns the <see cref="byte"/> array managed from this <see cref="ByteBuffer"/>
        /// </summary>
        /// <param name="bypassDirectConvert"><see langword="true"/> to bypass the conversion using direct buffer</param>
        /// <returns>The <see cref="byte"/> array managed from this <see cref="ByteBuffer"/></returns>
        public byte[] ToArray(bool bypassDirectConvert = false)
        {
            if (!bypassDirectConvert)
            {
                try
                {
                    return ToDirectBuffer().ToArray<byte>();
                }
                catch (UnsupportedOperationException) { }
                catch (System.NotSupportedException) { }
            }
            return IExecuteWithSignatureArray<byte>("array", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// Fills the <paramref name="array"/> with data managed from this <see cref="ByteBuffer"/>
        /// </summary>
        /// <param name="array">The array to be filled with the content of the <see cref="ByteBuffer"/></param>
        /// <param name="resizeToFill">Resize <paramref name="array"/> to contain all data available in the <see cref="ByteBuffer"/></param>
        public void ToArray(ref byte[] array, bool resizeToFill = true)
        {
            try
            {
                ToDirectBuffer().ToArray<byte>(ref array, resizeToFill);
            }
            catch (UnsupportedOperationException) { }
            catch (System.NotSupportedException) { }
        }
        /// <summary>
        /// Creates a new <see cref="ByteBuffer"/> in the JVM which belongs to <paramref name="rawAddr"/>. 
        /// </summary>
        /// <param name="rawAddr">The pointer where data is stored</param>
        /// <param name="capacity">Declares the memory available, in <see cref="byte"/>, associated to <paramref name="rawAddr"/></param>
        /// <param name="disposeEvent">An optional <see cref="EventHandler{TEventArgs}"/> can be used to be informed when the <paramref name="rawAddr"/> can be safely retired becuase the JVM is no moore using the pointer of <paramref name="rawAddr"/>.</param>
        /// <param name="disposeEventState">The data will be associated to <paramref name="disposeEvent"/>, by default the value will be <paramref name="rawAddr"/></param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <returns>A new instance of <see cref="ByteBuffer"/> holding the memory of <paramref name="rawAddr"/></returns>
        /// <remarks>
        /// The memory associated to <paramref name="rawAddr"/> shall be available until the JVM reference of the newly created <see cref="ByteBuffer"/> is garbage collected to avoid access violation within the JVM. 
        /// Under heavy pressure the memory footprint can raise up and generate an <see cref="OutOfMemoryException"/>, use the functionality with caution or take into account the <paramref name="timeToLive"/> option which can help to recover the memory in advance before the Garbage Collector of the JVM retires the <see cref="ByteBuffer"/>
        /// If the user of <see cref="ByteBuffer"/> is pretty sure that the memory is no more needed from the JVM, e.g. the invoked method does not queue the <see cref="ByteBuffer"/> and its lifetime ends when the method returns, invoke <see cref="Dispose"/> to immediately release unmanaged resources and free the memory
        /// </remarks>
        public static ByteBuffer From(IntPtr rawAddr, long capacity, EventHandler<object> disposeEvent = null, object disposeEventState = null, int timeToLive = System.Threading.Timeout.Infinite)
        {
            var buf = JCOBridge.Global.JVM.NewDirectBuffer(rawAddr, capacity, disposeEvent, disposeEventState, timeToLive);
            return JVMBridgeBase.WrapsDirect<ByteBuffer>(buf.DisableCleanupAndReturn());
        }
        /// <summary>
        /// Creates a new <see cref="ByteBuffer"/> in the JVM which belongs to <paramref name="data"/>
        /// </summary>
        /// <param name="data">The data to be shared</param>
        /// <param name="useMemoryControlBlock">Appends to the end of the <paramref name="data"/> a memory block will be used to controls and arbitrates memory between CLR and JVM</param>
        /// <param name="arrangeCapacity">If <see langword="true"/> the <see cref="byte"/> array in <paramref name="data"/> will be resized to the next power of 2, 
        /// so capacity will be memory aligned and the limit of <see cref="ByteBuffer"/> will be current size of <paramref name="data"/>
        /// </param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <returns>A new instance of <see cref="ByteBuffer"/> holding the memory of <paramref name="data"/></returns>
        /// <remarks>
        /// The memory associated to <paramref name="data"/> will be pinned until the JVM reference of the newly created <see cref="ByteBuffer"/> is garbage collected to avoid access violation within the JVM. 
        /// Under heavy pressure the memory footprint can raise up and generate an <see cref="OutOfMemoryException"/>, use the functionality with caution or take into account the <paramref name="timeToLive"/> option which can help to recover the memory in advance before the Garbage Collector of the JVM retires the <see cref="ByteBuffer"/>
        /// If the user of <see cref="ByteBuffer"/> is pretty sure that the pinned memory is no more needed from the JVM, e.g. the invoked method does not queue the <see cref="ByteBuffer"/> and its lifetime ends when the method returns, invoke <see cref="Dispose"/> to immediately release unmanaged resources and free the memory
        /// </remarks>
        public static ByteBuffer From(byte[] data, bool useMemoryControlBlock = true, bool arrangeCapacity = true, int timeToLive = System.Threading.Timeout.Infinite)
        {
            try
            {
                return data.DirectBufferWithWrap<byte, ByteBuffer>(useMemoryControlBlock, arrangeCapacity, timeToLive);
            }
            catch (UnsupportedOperationException) { }
            catch (System.NotSupportedException) { }

            return ByteBuffer.Wrap(data);
        }
        /// <summary>
        /// Creates a new <see cref="ByteBuffer"/> in the JVM which shares the <paramref name="stream"/>. The method helps to avoid too many array copies from CLR to JVM
        /// </summary>
        /// <param name="stream">The non disposed <see cref="System.IO.MemoryStream"/> to be used directly within the JVM from a <see cref="ByteBuffer"/>, see remarks</param>
        /// <param name="useMemoryControlBlock">Appends to the end of the <paramref name="stream"/> a memory block will be used to controls and arbitrates memory between CLR and JVM</param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <param name="disposeEvent">An optional <see cref="EventHandler{TEventArgs}"/> can be used to be informed when the <paramref name="stream"/> can be safely disposed (the dispose action shall be in the user code), if <see langword="null"/> the underlying system will automatically dispose the <see cref="System.IO.MemoryStream"/>.</param>
        /// <returns>A new instance of <see cref="ByteBuffer"/> holding the memory of <paramref name="stream"/> shared with the <see cref="ByteBuffer"/></returns>
        /// <remarks>
        /// The memory associated to <paramref name="stream"/> will be pinned until the JVM reference of the newly created <see cref="ByteBuffer"/> is garbage collected to avoid access violation within the JVM. 
        /// Under heavy pressure the memory footprint can raise up and generate an <see cref="OutOfMemoryException"/>, use the functionality with caution or take into account the <paramref name="timeToLive"/> option which can help to recover the memory in advance before the Garbage Collector of the JVM retires the <see cref="ByteBuffer"/>
        /// 
        /// <b>The <see cref="System.IO.MemoryStream"/> cannot be disposed otherwise the underlying system is not able to access the memory. The <see cref="System.IO.MemoryStream"/> can be written, or read, and changes are visible to both CLR and JVM,
        /// however, if the <see cref="System.IO.MemoryStream"/> grows, the underlying system cannot resize too and capacity still remains the one when <see cref="From(MemoryStream, bool, EventHandler{MemoryStream}, int)"/> was invoked the first time.</b>
        /// </remarks>
        public static ByteBuffer From(System.IO.MemoryStream stream, bool useMemoryControlBlock = true, EventHandler<MemoryStream> disposeEvent = null, int timeToLive = System.Threading.Timeout.Infinite)
        {
            var buf = JCOBridge.Global.JVM.NewDirectBuffer(stream, useMemoryControlBlock, disposeEvent, timeToLive);
            return JVMBridgeBase.WrapsDirect<ByteBuffer>(buf.DisableCleanupAndReturn());
        }
        /// <summary>
        /// Returns an instance of <see cref="System.IO.Stream"/> associated to this <see cref="ByteBuffer"/> instance
        /// </summary>
        /// <returns>The <see cref="System.IO.Stream"/> associated to this <see cref="ByteBuffer"/> instance</returns>
        /// <remarks>The returned <see cref="System.IO.Stream"/> can be used to directly access and manages JVM memory without any memory move</remarks>
        public System.IO.Stream ToStream()
        {
            return ToDirectBuffer().ToStream();
        }
        /// <summary>
        /// Returns an instance of <see cref="JCOBridgeDirectBuffer{T}"/>
        /// </summary>
        /// <returns>The <see cref="JCOBridgeDirectBuffer{T}"/> associated to this <see cref="ByteBuffer"/> instance</returns>
        /// <remarks>The returned <see cref="JCOBridgeDirectBuffer{T}"/> can be used to directly access and manages JVM memory without any memory move</remarks>
        public JCOBridgeDirectBuffer<byte> ToDirectBuffer()
        {
            Rewind();
            return JVM.GetDirectBuffer<byte>(BridgeInstance);
        }

        #endregion
    }
}
