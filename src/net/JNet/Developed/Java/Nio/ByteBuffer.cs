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
using MASES.JNet;
using MASES.JNet.Specific.Extensions;
using Microsoft.IO;
using System;
using System.Collections.Concurrent;
using System.IO;
using System.Threading;

namespace Java.Nio
{
    public partial class ByteBuffer
    {
        #region RecyclableMemoryStream

        static readonly ConcurrentDictionary<string, RecyclableMemoryStream> _storer = new();

        static readonly object _configurationLock = new object();
        static bool _enable;
        static RecyclableMemoryStreamManager.Options _options;
        static RecyclableMemoryStreamManager _manager;

        static long _streamId = 0;
        static ByteBuffer()
        {
            _options = null;
            _manager = null;
        }

        static void RemoveRecyclableMemoryStreamManager()
        {
            if (_manager != null)
            {
                while (!_storer.IsEmpty) System.Threading.Thread.Sleep(1); // wait the queue of current RecyclableMemoryStreamManager is empty
                _manager.StreamDoubleDisposed -= RecyclableMemoryStreamManager_StreamDoubleDisposed;
                _manager.StreamDisposed -= RecyclableMemoryStreamManager_StreamDisposed;
                _manager.UsageReport -= RecyclableMemoryStreamManager_UsageReport;
                _manager.LargeBufferCreated -= RecyclableMemoryStreamManager_LargeBufferCreated;
            }
            _manager = null;
            _options = null;
        }

        static void CreateRecyclableMemoryStreamManager(RecyclableMemoryStreamManager.Options options)
        {
            _options = options ?? new RecyclableMemoryStreamManager.Options()
            {
                BlockSize = 1024,
                LargeBufferMultiple = 1024 * 1024,
                MaximumBufferSize = 16 * 1024 * 1024,
#if DEBUG
                GenerateCallStacks = true,
#endif
                AggressiveBufferReturn = true,
                MaximumLargePoolFreeBytes = 16 * 1024 * 1024 * 4,
                MaximumSmallPoolFreeBytes = 100 * 1024,
            };

            _manager = new RecyclableMemoryStreamManager(_options);
            _manager.StreamDoubleDisposed += RecyclableMemoryStreamManager_StreamDoubleDisposed;
            _manager.StreamDisposed += RecyclableMemoryStreamManager_StreamDisposed;
            _manager.UsageReport += RecyclableMemoryStreamManager_UsageReport;
            _manager.LargeBufferCreated += RecyclableMemoryStreamManager_LargeBufferCreated;
        }

        private static void RecyclableMemoryStreamManager_StreamDisposed(object sender, RecyclableMemoryStreamManager.StreamDisposedEventArgs e)
        {
            _storer.TryRemove(e.Tag!, out _);
        }

        private static void RecyclableMemoryStreamManager_StreamDoubleDisposed(object sender, RecyclableMemoryStreamManager.StreamDoubleDisposedEventArgs e)
        {
            if (ReportDoubleDisposed)
            {
                JCOBridge.RaiseEventOrException($"Stream {e.Tag} disposed twice:");
                JCOBridge.RaiseEventOrException($"First callstack is {e.DisposeStack1}");
                JCOBridge.RaiseEventOrException($"Second callstack is {e.DisposeStack2}");
                JCOBridge.RaiseEventOrException($"Originally allocated from {e.AllocationStack}");
            }
        }

        private static void RecyclableMemoryStreamManager_UsageReport(object sender, RecyclableMemoryStreamManager.UsageReportEventArgs e)
        {
            if (ReportUsage)
            {
                JCOBridge.RaiseEventOrException($"RecyclableMemoryStreamManager LargePoolFreeBytes={e.LargePoolFreeBytes} LargePoolInUseBytes={e.LargePoolInUseBytes} SmallPoolFreeBytes={e.SmallPoolFreeBytes} SmallPoolInUseBytes={e.SmallPoolInUseBytes}");
            }
        }

        private static void RecyclableMemoryStreamManager_LargeBufferCreated(object sender, RecyclableMemoryStreamManager.LargeBufferCreatedEventArgs e)
        {
            LargeBufferCreated?.Invoke(e);
        }
        /// <summary>
        /// Reports the current <see cref="RecyclableMemoryStreamManager.Options"/> in use, <see langword="null"/> if not enable
        /// </summary>
        public static RecyclableMemoryStreamManager.Options CurrentSettings => _options;

        /// <summary>
        /// <see langword="true"/> to report double-disposed (<see cref="RecyclableMemoryStreamManager.StreamDoubleDisposed"/>) conditions using <see cref="JNetCoreBase{T}.EventOrExceptionEvent"/> or, on command-line, setting to true <see cref="JNetCoreBase{T}.WriteEventOrExceptionOnCmdLine"/>
        /// </summary>
        public static bool ReportDoubleDisposed { get; set; }
        /// <summary>
        /// <see langword="true"/> to report usage (<see cref="RecyclableMemoryStreamManager.UsageReport"/>) using <see cref="JNetCoreBase{T}.EventOrExceptionEvent"/> or, on command-line, setting to true <see cref="JNetCoreBase{T}.WriteEventOrExceptionOnCmdLine"/>
        /// </summary>
        public static bool ReportUsage { get; set; }
        /// <summary>
        /// Invoked when a large buffer (<see cref="RecyclableMemoryStreamManager.LargeBufferCreated"/>) is created
        /// </summary>
        public static Action<RecyclableMemoryStreamManager.LargeBufferCreatedEventArgs> LargeBufferCreated { get; set; }

        /// <summary>
        /// Set to <see langword="true"/> to enable, or set to <see langword="false"/> to disable, the usage of <see cref="RecyclableMemoryStream"/>
        /// </summary>
        /// <param name="enable"><see langword="true"/> to enable <see cref="RecyclableMemoryStream"/> support with optional <paramref name="options"/></param>
        /// <param name="options">The <see cref="RecyclableMemoryStreamManager.Options"/> options to use</param>
        public static void EnableRecyclableMemoryStream(bool enable, RecyclableMemoryStreamManager.Options options = null)
        {
            lock (_configurationLock)
            {
                bool shallCreate = _enable != enable && enable;
                _enable = enable;
                if (shallCreate)
                {
                    RemoveRecyclableMemoryStreamManager();
                    CreateRecyclableMemoryStreamManager(options);
                }
                else if (!enable)
                {
                    RemoveRecyclableMemoryStreamManager();
                }
            }
        }

        /// <summary>
        /// Returns a new <see cref="MemoryStream"/> or a preallocated <see cref="MemoryStream"/> which is an implementation  of <see cref="RecyclableMemoryStream"/>
        /// can be used from <see cref="ByteBuffer.From(MemoryStream, EventHandler{MemoryStream}, int)"/>. When underlying sub-system ends the usage of <see cref="MemoryStream"/>
        /// the <see cref="IDisposable.Dispose"/> method is automatically invoked and <see cref="MemoryStream"/> id disposed or <see cref="RecyclableMemoryStream"/> is returned back
        /// to the pool.
        /// </summary>
        /// <returns>The requested <see cref="MemoryStream"/></returns>
        /// <remarks>The same remarks of <see cref="ByteBuffer.From(MemoryStream, EventHandler{MemoryStream}, int)"/> applies: the returned <see cref="MemoryStream"/> shall not be disposed.</remarks>
        /// <example>
        /// <code>
        /// var ms = ByteBuffer.GetMemoryStream(); // never use an using statement
        /// 
        /// ByteBuffer bb = ByteBuffer.From(ms);
        /// </code>
        /// </example>
        public static MemoryStream GetMemoryStream()
        {
            if (!_enable) return new MemoryStream();

            var tag = Interlocked.Increment(ref _streamId).ToString();
            var stream = _manager.GetStream(tag);
            _storer.TryAdd(tag, stream);
            return stream;
        }

        #endregion

        // can be extended with methods not reflected or not available in Java;

        JCOBridgeDirectBuffer<byte> _directBuffer = null;

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
        /// Converts an instance of <see cref="byte"/> array into <see cref="ByteBuffer"/> using the default parameters of <see cref="From(byte[], bool, int)"/>
        /// </summary>
        /// <remarks>If the JVM supports direct access the function will share with the JVM the memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator ByteBuffer(byte[] t) => From(t);
        /// <summary>
        /// Converts an instance of <see cref="ByteBuffer"/> into <see cref="byte"/> array
        /// </summary>
        /// <remarks>If the <see cref="ByteBuffer"/> supports direct access the function tries to move data from JVM memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator byte[](ByteBuffer t) => t.ToArray();
        /// <summary>
        /// Converts an instance of <see cref="System.IO.MemoryStream"/> into a <see cref="ByteBuffer"/> using the default parameters of <see cref="From(MemoryStream, EventHandler{MemoryStream}, int)"/>
        /// </summary>
        /// <remarks>See remarks of <see cref="From(MemoryStream, EventHandler{MemoryStream}, int)"/></remarks>
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
        /// If the user of <see cref="ByteBuffer"/> is pretty sure that the memory is no more needed from the JVM, e.g. the invoked method does not queue the <see cref="ByteBuffer"/> and its lifetime ends when the method returns; to immediately release unmanaged resources, and free the memory, invokes <see cref="ToDirectBuffer"/> and invoke <see cref="JCOBridgeDirectBuffer{T}.Dispose"/>
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
        /// <param name="arrangeCapacity">If <see langword="true"/> the <see cref="byte"/> array in <paramref name="data"/> will be resized to the next power of 2, 
        /// so capacity will be memory aligned and the limit of <see cref="ByteBuffer"/> will be current size of <paramref name="data"/>
        /// </param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <returns>A new instance of <see cref="ByteBuffer"/> holding the memory of <paramref name="data"/></returns>
        /// <remarks>
        /// The memory associated to <paramref name="data"/> will be pinned until the JVM reference of the newly created <see cref="ByteBuffer"/> is garbage collected to avoid access violation within the JVM. 
        /// Under heavy pressure the memory footprint can raise up and generate an <see cref="OutOfMemoryException"/>, use the functionality with caution or take into account the <paramref name="timeToLive"/> option which can help to recover the memory in advance before the Garbage Collector of the JVM retires the <see cref="ByteBuffer"/>
        /// If the user of <see cref="ByteBuffer"/> is pretty sure that the pinned memory is no more needed from the JVM, e.g. the invoked method does not queue the <see cref="ByteBuffer"/> and its lifetime ends when the method returns; to immediately release unmanaged resources, and free the memory, invokes <see cref="ToDirectBuffer"/> and invoke <see cref="JCOBridgeDirectBuffer{T}.Dispose"/>
        /// </remarks>
        public static ByteBuffer From(byte[] data, bool arrangeCapacity = true, int timeToLive = System.Threading.Timeout.Infinite)
        {
            try
            {
                return data.DirectBufferWithWrap<byte, ByteBuffer>(arrangeCapacity, timeToLive);
            }
            catch (UnsupportedOperationException) { }
            catch (System.NotSupportedException) { }

            return ByteBuffer.Wrap(data);
        }
        /// <summary>
        /// Creates a new <see cref="ByteBuffer"/> in the JVM which shares the <paramref name="stream"/>. The method helps to avoid too many array copies from CLR to JVM
        /// </summary>
        /// <param name="stream">The non disposed <see cref="System.IO.MemoryStream"/> to be used directly within the JVM from a <see cref="ByteBuffer"/>, see remarks</param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <param name="disposeEvent">An optional <see cref="EventHandler{TEventArgs}"/> can be used to be informed when the <paramref name="stream"/> can be safely disposed (the dispose action shall be in the user code), if <see langword="null"/> the underlying system will automatically dispose the <see cref="System.IO.MemoryStream"/>.</param>
        /// <returns>A new instance of <see cref="ByteBuffer"/> holding the memory of <paramref name="stream"/> shared with the <see cref="ByteBuffer"/></returns>
        /// <remarks>
        /// The memory associated to <paramref name="stream"/> will be pinned until the JVM reference of the newly created <see cref="ByteBuffer"/> is garbage collected to avoid access violation within the JVM. 
        /// Under heavy pressure the memory footprint can raise up and generate an <see cref="OutOfMemoryException"/>, use the functionality with caution or take into account the <paramref name="timeToLive"/> option which can help to recover the memory in advance before the Garbage Collector of the JVM retires the <see cref="ByteBuffer"/>
        /// 
        /// <b>The <see cref="System.IO.MemoryStream"/> cannot be disposed otherwise the underlying system is not able to access the memory. The <see cref="System.IO.MemoryStream"/> can be written, or read, and changes are visible to both CLR and JVM,
        /// however, if the <see cref="System.IO.MemoryStream"/> grows, the underlying system cannot resize too and capacity still remains the one when <see cref="From(MemoryStream, EventHandler{MemoryStream}, int)"/> was invoked the first time.</b>
        /// </remarks>
        public static ByteBuffer From(System.IO.MemoryStream stream, EventHandler<MemoryStream> disposeEvent = null, int timeToLive = System.Threading.Timeout.Infinite)
        {
            var buf = JCOBridge.Global.JVM.NewDirectBuffer(stream, disposeEvent, timeToLive);
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
            // Rewind(); removed to avoid the build of a new ByteBuffer object will be discarded and replace with a more simple invocation
            // still remains the allocation of a returning object that is the copy of the current managed ByteBuffer, the copy will be immediately disposed to avoid GEN1 in GC
            using (var iJobj = IExecuteWithSignature("rewind", "()Ljava/nio/Buffer;") as IJavaObject) { }
            return _directBuffer ?? JVM.GetDirectBuffer<byte>(BridgeInstance);
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
