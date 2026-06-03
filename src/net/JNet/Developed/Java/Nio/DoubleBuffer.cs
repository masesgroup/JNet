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
    public partial class DoubleBuffer
    {
        // can be extended with methods not reflected or not available in Java;

        JCOBridgeDirectBuffer<double> _directBuffer = null;

        #region Operators

        /// <summary>
        /// Converter from <see cref="DoubleBuffer"/> to <see cref="Comparable{DoubleBuffer}"/>
        /// </summary>
        public static implicit operator Comparable<DoubleBuffer>(DoubleBuffer buffer) => buffer.Cast<Comparable<DoubleBuffer>>();
        /// <summary>
        /// Converts an instance of <see cref="DoubleBuffer"/> into <see cref="JCOBridgeDirectBuffer{T}"/>
        /// </summary>
        public static implicit operator JCOBridgeDirectBuffer<double>(DoubleBuffer t) => t.ToDirectBuffer(true);
        /// <summary>
        /// Converts an instance of <see cref="double"/> array into <see cref="DoubleBuffer"/> using the default parameters of <see cref="From(double[], bool, int)"/>
        /// </summary>
        /// <remarks>If the JVM supports direct access the function will share with the JVM the memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator DoubleBuffer(double[] t) => From(t);
        /// <summary>
        /// Converts an instance of <see cref="DoubleBuffer"/> into <see cref="double"/> array
        /// </summary>
        /// <remarks>If the <see cref="DoubleBuffer"/> supports direct access the function tries to move data from JVM memory without JNI, otherwise fallback to the standard memory copy.</remarks>
        public static implicit operator double[](DoubleBuffer t) => t.ToArray();

        #endregion

        #region Methods

        /// <summary>
        /// Returns the <see cref="double"/> array managed from this <see cref="DoubleBuffer"/>
        /// </summary>
        /// <param name="bypassDirectConvert"><see langword="true"/> to bypass the conversion using direct buffer</param>
        /// <returns>The <see cref="double"/> array managed from this <see cref="DoubleBuffer"/></returns>
        public double[] ToArray(bool bypassDirectConvert = false)
        {
            if (!bypassDirectConvert)
            {
                try
                {
                    return ToDirectBuffer(true).ToArray<double>();
                }
                catch (UnsupportedOperationException) { }
                catch (System.NotSupportedException) { }
            }
            return IExecuteWithSignatureArray<double>("array", "()Ljava/lang/Object;");
        }
        /// <summary>
        /// Creates a new <see cref="DoubleBuffer"/> in the JVM which belongs to <paramref name="data"/>
        /// </summary>
        /// <param name="data">The data to be shared</param>
        /// <param name="arrangeCapacity">If <see langword="true"/> the <see cref="double"/> array in <paramref name="data"/> will be resized to the next power of 2, 
        /// so capacity will be memory aligned and the limit of java.nio.DoubleBuffer will be current size of <paramref name="data"/>
        /// </param>
        /// <param name="timeToLive">The time to live, expressed in milliseconds, the underlying memory shall remain available; if the time to live expires the pinned memory is retired leaving potentially the JVM under the possibility of an access violation.</param>
        /// <returns>A new instance of <see cref="DoubleBuffer"/></returns>
        public static DoubleBuffer From(double[] data, bool arrangeCapacity = true, int timeToLive = System.Threading.Timeout.Infinite)
        {
            try
            {
                return data.DirectBufferWithWrap<double, DoubleBuffer>(arrangeCapacity, timeToLive);
            }
            catch (UnsupportedOperationException) { }
            catch (System.NotSupportedException) { }

            return DoubleBuffer.Wrap(data);
        }

        /// <summary>
        /// Returns a <see cref="JCOBridgeSharedBufferStream{T}"/> with an initial capacity derived from <paramref name="capacity"/>,
        /// to be populated via Stream-based APIs and then passed to <see cref="From(JCOBridgeSharedBufferStream{double})"/>.
        /// </summary>
        /// <param name="capacity">The plausible number of elements of <see langword="double"/> type to be written into the stream; the byte size is computed as <c>capacity * sizeof(<see langword="double"/>)</c>.
        /// The default value of <c>-1</c> instructs the subsystem to allocate the minimum meaningful unit, which corresponds to one system memory page (see <see cref="Environment.SystemPageSize"/>).
        /// Regardless of the value provided, the effective allocation is always rounded up to the nearest multiple of the system page size, since the underlying native allocator operates at page granularity.
        /// Passing a value smaller than one page therefore has no practical advantage over using the default.
        /// This value is a hint, not a hard limit: if the actual data written exceeds the initial allocation, the underlying buffer will grow automatically via reallocation.
        /// However, providing a value greater than or equal to the actual data size is strongly recommended to avoid reallocation overhead, especially in high-rate scenarios.
        /// Callers that process data of a known or predictable size are encouraged to implement their own estimation strategy — for example, tracking the stable size observed in previous invocations —
        /// so that the initial capacity converges toward the real value over time and reallocations become increasingly rare or disappear entirely.
        /// </param>
        /// <returns>A pooled instance of <see cref="JCOBridgeSharedBufferStream{T}"/> ready to be written via Stream-based APIs and then passed to <see cref="From(JCOBridgeSharedBufferStream{double})"/>.</returns>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when <paramref name="capacity"/> is zero or any positive value that, once multiplied by <c>sizeof(<see langword="double"/>)</c>, overflows a <see cref="long"/>.</exception>
        /// <remarks>
        /// The returned <see cref="JCOBridgeSharedBufferStream{T}"/> is drawn from an internal pool. The HPA (High Performance Application) runtime variant uses a highly optimized pool tuned for high-throughput scenarios,
        /// while the standard runtime variant uses a lighter pool suitable for moderate workloads.
        /// The instance must not be manually disposed; its lifecycle is fully managed by the subsystem and it is automatically returned to the pool once the JVM Garbage Collector retires the associated
        /// <see cref="DoubleBuffer"/> created by <see cref="From(JCOBridgeSharedBufferStream{double})"/>.
        /// </remarks>
        public static JCOBridgeSharedBufferStream<double> Rent(long capacity = -1)
        {
            return JCOBridge.Global.JVM.Rent<double>(capacity);
        }

        /// <summary>
        /// Creates a new <see cref="DoubleBuffer"/> in the JVM which shares the memory of <paramref name="stream"/>.
        /// This is the preferred overload for high-rate scenarios as it avoids repeated array copies from CLR to JVM and benefits from pooled buffer management.
        /// </summary>
        /// <param name="stream">A <see cref="JCOBridgeSharedBufferStream{T}"/> obtained from <see cref="Rent"/> and populated via Stream-based APIs,
        /// to be used directly within the JVM from a <see cref="DoubleBuffer"/>.</param>
        /// <returns>A new instance of <see cref="DoubleBuffer"/> holding the memory of <paramref name="stream"/> shared with the <see cref="DoubleBuffer"/>.</returns>
        /// <remarks>
        /// The memory associated to <paramref name="stream"/> will be retained until the JVM reference of the newly created <see cref="DoubleBuffer"/> is garbage collected.
        /// Under heavy pressure the memory footprint can raise up and generate an <see cref="OutOfMemoryException"/>; use the functionality with caution.
        /// <para>
        /// <b>Lifecycle management:</b> the subsystem automatically returns <paramref name="stream"/> to the internal pool once the JVM Garbage Collector retires the associated
        /// <see cref="DoubleBuffer"/>, i.e. when the <see cref="DoubleBuffer"/> has been fully consumed by the JVM.
        /// A direct call to <see cref="IDisposable.Dispose"/> on the returned <see cref="DoubleBuffer"/> is therefore a no-op; do not attempt to manually dispose <paramref name="stream"/> after passing it to this method.
        /// </para>
        /// <para>
        /// <b>Pool strategy:</b> the HPA (High Performance Application) runtime variant draws <paramref name="stream"/> instances from a highly optimized pool tuned for high-throughput workloads,
        /// while the standard runtime variant uses a lighter pool. In both cases the pooling is fully transparent to the caller.
        /// </para>
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when <paramref name="stream"/> was not obtained through <see cref="Rent"/>.</exception>
        /// <exception cref="NotSupportedException">Thrown when the JVM is unable to generate a <see cref="DoubleBuffer"/> instance.</exception>
        public static DoubleBuffer From(JCOBridgeSharedBufferStream<double> stream)
        {
            var buf = JCOBridge.Global.JVM.NewDirectBuffer(stream);
            return JVMBridgeBase.WrapsDirect<DoubleBuffer>(buf.DisableCleanupAndReturn());
        }

#if NET5_0_OR_GREATER
        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.AsSpan"/>
        public ReadOnlySpan<double> AsSpan()
        {
            return ToDirectBuffer(false).AsSpan();
        }

        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.AsSpanFromIndex"/>
        public ReadOnlySpan<double> AsSpanFromIndex(int fromIndex)
        {
            return ToDirectBuffer(false).AsSpanFromIndex(fromIndex);
        }

        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.AsWritableSpan"/>
        public Span<double> AsWritableSpan()
        {
            return ToDirectBuffer(false).AsWritableSpan();
        }

        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.AsWritableSpanFromIndex(int)"/>
        public Span<double> AsWritableSpanFromIndex(int fromIndex)
        {
            return ToDirectBuffer(false).AsWritableSpanFromIndex(fromIndex);
        }

        /// <inheritdoc cref="JCOBridgeDirectBuffer{T}.FlushOnDispose"/>
        public void FlushOnDispose()
        {
            ToDirectBuffer(false).FlushOnDispose();
        }
#endif
        /// <summary>
        /// Returns an instance of <see cref="JCOBridgeDirectBuffer{T}"/> can be used to directly access and manages JVM memory without any memory move
        /// </summary>
        /// <param name="rewind"><see cref="Buffer.Rewind()"/> the instance before return <see cref="JCOBridgeDirectBuffer{T}"/></param>
        /// <returns>The <see cref="JCOBridgeDirectBuffer{T}"/> associated to this <see cref="DoubleBuffer"/> instance</returns>
        /// <remarks>
        /// <b>Do not call Dispose()</b> on the returned instance.
        /// Its lifetime is managed by the owning object.
        /// </remarks>
        [Obsolete("DO NOT CALL Dispose() on the returned JCOBridgeDirectBuffer: it is an internal instance whose lifetime is managed by the owning object.", error: false)]
        public JCOBridgeDirectBuffer<double> ToDirectBuffer(bool rewind)
        {
            if (rewind)
            {
                // Rewind(); removed to avoid the build of a new DoubleBuffer object will be discarded and replace with a more simple invocation
                // still remains the allocation of a returning object that is the copy of the current managed DoubleBuffer, the copy will be immediately disposed to avoid GEN1 in GC
                IExecuteWithSignature("rewind", "()Ljava/nio/Buffer;").DisposeIfDisposable();
            }
            return _directBuffer ??= JVM.GetDirectBuffer<double>(BridgeInstance);
        }
        /// <inheritdoc/>
        protected override void Dispose(bool disposing)
        {
            _directBuffer?.Dispose();
            _directBuffer = null;
            base.Dispose(disposing);
        }

        #endregion
    }
}
