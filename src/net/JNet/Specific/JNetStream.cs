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

using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MASES.JNet.Specific
{
    /// <summary>
    /// Helper class of JNet to use <see cref="JCOBridgeStream{T}"/>
    /// </summary>
    /// <remarks>
    /// <para>
    /// Wraps a <see cref="JCOBridgeStream{T}"/> instance obtained via <see cref="IJavaArray.ToStream{T}(FileAccess, bool)"/>.
    /// Dispose behavior, license modes, and performance characteristics are inherited from the underlying stream — see <see cref="JCOBridgeStream{T}"/> remarks for full details.
    /// </para>
    /// <para>
    /// When the underlying stream is opened with write access, modifications are written back to the JVM array automatically on <see cref="IDisposable.Dispose"/>.
    /// Explicit disposal is always preferred over relying on the finalizer.
    /// </para>
    /// <para>
    /// Under HPA license with <c>forceRawMemory = true</c>, the JVM garbage collector is suspended for the entire lifetime of this instance.
    /// No JVM interaction of any kind is permitted while this object is alive. Always use a <see langword="using"/> block — leaving disposal to the finalizer may result in a deadlock or JVM crash.
    /// </para>
    /// <para>
    /// Methods relying on <see cref="ReadOnlySpan{T}"/> (such as <c>AsSpan</c>) are only available on .NET 5 and later,
    /// due to a conflict between the <c>System.Memory</c> dependency introduced transitively by <see cref="Microsoft.IO.RecyclableMemoryStream"/> and the JCOBridge shim on .NET Framework.
    /// </para>
    /// </remarks>
    public sealed class JNetStream<T> : IDisposable, IEnumerable<T> where T : unmanaged
    {
        readonly bool _disposeSource;
        readonly IJavaObject _javaObject;
        readonly IJavaArray _javaArray;
        readonly JCOBridgeStream<T> _stream;

        /// <summary>
        /// Initialize an instance of <see cref="JNetStream{T}"/>
        /// </summary>
        /// <param name="source">The <see cref="object"/> to be converted</param>
        /// <param name="mode"><inheritdoc cref="IJavaArray.ToStream{T}(FileAccess, bool)" path="/param[@name='mode']"/></param>
        /// <param name="forceRawMemory"><inheritdoc cref="IJavaArray.ToStream{T}(FileAccess, bool)" path="/param[@name='forceRawMemory']"/></param>
        /// <param name="disposeSource">Automatically invoke <see cref="IDisposable.Dispose"/> on <paramref name="source"/></param>
        public JNetStream(object source, FileAccess mode = FileAccess.Read, bool forceRawMemory = false, bool disposeSource = true)
        {
            _disposeSource = disposeSource;
            if (source is IJavaObject javaObject)
            {
                _javaObject = javaObject;
                _javaArray = _javaObject.ToJavaArray();
            }
            else if (source is IJavaArray javaArray)
            {
                _javaArray = javaArray;
            }
            else throw new ArgumentException($"Source {source} of type {source?.GetType()} shall be {nameof(IJavaArray)} or {nameof(IJavaObject)}", nameof(source));

            _stream = _javaArray.ToStream<T>(mode, forceRawMemory);
        }
        /// <inheritdoc/>
        public void Dispose()
        {
            _stream.Dispose();
            if (_disposeSource) _javaArray?.Dispose();
            if (_disposeSource) _javaObject?.Dispose();
        }
        /// <inheritdoc cref="JCOBridgeStream{T}.this[int]"/>
        public T this[int index] { get => _stream[index]; set { _stream[index] = value; } }
        /// <inheritdoc cref="JCOBridgeStream{T}.Count"/>
        public int Count => _stream.Count;
        /// <inheritdoc cref="JCOBridgeStream{T}.CopyTo"/>
        public void CopyTo(T[] destination, int destinationIndex = 0) => _stream.CopyTo(destination, destinationIndex);
        /// <inheritdoc cref="JCOBridgeStream{T}.FlushOnDispose"/>
        public void FlushOnDispose() => _stream.FlushOnDispose();
        /// <inheritdoc cref="JCOBridgeStream{T}.Write(byte[], int, int)"/>
        public void Write(byte[] buffer, int offset, int count) => _stream.Write(buffer, offset, count);
        /// <inheritdoc cref="JCOBridgeStream{T}.WriteAsync(byte[], int, int, CancellationToken)"/>
        public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => _stream.WriteAsync(buffer, offset, count, cancellationToken);
        /// <inheritdoc cref="JCOBridgeStream{T}.WriteByte"/>
        public void WriteByte(byte value) => _stream.WriteByte(value);
#if NET5_0_OR_GREATER
        /// <inheritdoc cref="JCOBridgeStream{T}.AsSpan"/>
        public ReadOnlySpan<T> AsSpan() => _stream.AsSpan();
        /// <inheritdoc cref="JCOBridgeStream{T}.AsSpanFromPosition"/>
        public ReadOnlySpan<T> AsSpanFromPosition() => _stream.AsSpanFromPosition();
        /// <inheritdoc cref="JCOBridgeStream{T}.AsWritableSpan"/>
        public Span<T> AsWritableSpan() => _stream.AsWritableSpan();
        /// <inheritdoc cref="JCOBridgeStream{T}.AsWritableSpan"/>
        public Span<T> AsWritableSpanFromPosition() => _stream.AsWritableSpanFromPosition();
        /// <inheritdoc cref="JCOBridgeStream{T}.Write(ReadOnlySpan{byte})"/>
        public void Write(ReadOnlySpan<byte> buffer) => _stream.Write(buffer);
        /// <inheritdoc cref="JCOBridgeStream{T}.WriteAsync(ReadOnlyMemory{byte}, CancellationToken)"/>
        public ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default) => _stream.WriteAsync(buffer, cancellationToken);
#endif
        /// <inheritdoc cref="JCOBridgeStream{T}.GetEnumerator"/>
        public IEnumerator<T> GetEnumerator()
        {
            return _stream.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
