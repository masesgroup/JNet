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
    /// Methods relying on <c>ReadOnlySpan&lt;T&gt;</c> (such as <c>AsSpan</c>) are only available on .NET 5 and later,
    /// due to a conflict between the <c>System.Memory</c> dependency introduced transitively by <see cref="Microsoft.IO.RecyclableMemoryStream"/> and the JCOBridge shim on .NET Framework.
    /// </para>
    /// </remarks>
    public sealed class JNetStream<T> : IDisposable, IEnumerable<T> where T : unmanaged
    {
        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        static JNetStream<T> Allocate() => new JNetStream<T>();
        static JCOBridgeObjectPool<JNetStream<T>> _pool = new JCOBridgeObjectPool<JNetStream<T>>(Allocate);

        struct JNetStreamState
        {
            public JNetStreamState(object source, FileAccess mode, bool forceRawMemory, bool disposeSource)
            {
                if (source is IJavaObject javaObject)
                {
                    JavaObject = javaObject;
                    JavaArray = JavaObject.ToJavaArray();
                }
                else if (source is IJavaArray javaArray)
                {
                    JavaArray = javaArray;
                }
                else throw new ArgumentException($"Source {source} of type {source?.GetType()} shall be {nameof(IJavaArray)} or {nameof(IJavaObject)}", nameof(source));

                Stream = JavaArray.ToStream<T>(mode, forceRawMemory);

                DisposeSource = disposeSource;
            }
            public bool DisposeSource;
            public IJavaObject JavaObject;
            public IJavaArray JavaArray;
            public JCOBridgeStream<T> Stream;

            public void Dispose()
            {
                Stream.Dispose();
                if (DisposeSource) JavaArray?.Dispose();
                if (DisposeSource) JavaObject?.Dispose();
            }
        }

        JNetStreamState _state;

        /// <summary>
        /// Initialize an instance of <see cref="JNetStream{T}"/>
        /// </summary>
        /// <param name="source">The <see cref="object"/> to be converted</param>
        /// <param name="mode"><inheritdoc cref="IJavaArray.ToStream{T}(FileAccess, bool)" path="/param[@name='mode']"/></param>
        /// <param name="forceRawMemory"><inheritdoc cref="IJavaArray.ToStream{T}(FileAccess, bool)" path="/param[@name='forceRawMemory']"/></param>
        /// <param name="disposeSource">Automatically invoke <see cref="IDisposable.Dispose"/> on <paramref name="source"/></param>
        public static JNetStream<T> Create(object source, FileAccess mode = FileAccess.Read, bool forceRawMemory = false, bool disposeSource = true)
        {
            bool fromPool = false;
            var instance =  _pool.Rent(ref fromPool);
            instance.Setup(source, mode, forceRawMemory, disposeSource, fromPool);
            return instance;
        }

        void Setup(object source, FileAccess mode, bool forceRawMemory, bool disposeSource, bool fromPool)
        {
            _state = new JNetStreamState(source, mode, forceRawMemory, disposeSource);
        }
        /// <inheritdoc/>
        public void Dispose()
        {
            _state.Dispose();
            _state = default;
            _pool.Return(this);
        }
        /// <summary>
        /// The <see cref="JCOBridgeStream{T}"/> associated to this <see cref="JNetStream{T}"/> instance
        /// </summary>
        public JCOBridgeStream<T> BaseStream => _state.Stream;
        /// <inheritdoc cref="JCOBridgeStream{T}.IsCopy"/>
        public bool IsCopy => _state.Stream.IsCopy;
        /// <inheritdoc cref="JCOBridgeStream{T}.this[int]"/>
        public T this[int index] { get => _state.Stream[index]; set { _state.Stream[index] = value; } }
        /// <inheritdoc cref="JCOBridgeStream{T}.Count"/>
        public int Count => _state.Stream.Count;
        /// <inheritdoc cref="JCOBridgeStream{T}.CopyTo"/>
        public void CopyTo(T[] destination, int destinationIndex = 0) => _state.Stream.CopyTo(destination, destinationIndex);
        /// <inheritdoc cref="JCOBridgeStream{T}.FlushOnDispose"/>
        public void FlushOnDispose() => _state.Stream.FlushOnDispose();
        /// <inheritdoc cref="JCOBridgeStream{T}.Write(byte[], int, int)"/>
        public void Write(byte[] buffer, int offset, int count) => _state.Stream.Write(buffer, offset, count);
        /// <inheritdoc cref="JCOBridgeStream{T}.WriteAsync(byte[], int, int, CancellationToken)"/>
        public Task WriteAsync(byte[] buffer, int offset, int count, CancellationToken cancellationToken) => _state.Stream.WriteAsync(buffer, offset, count, cancellationToken);
        /// <inheritdoc cref="JCOBridgeStream{T}.WriteByte"/>
        public void WriteByte(byte value) => _state.Stream.WriteByte(value);
#if NET5_0_OR_GREATER
        /// <inheritdoc cref="JCOBridgeStream{T}.AsSpan"/>
        public ReadOnlySpan<T> AsSpan() => _state.Stream.AsSpan();
        /// <inheritdoc cref="JCOBridgeStream{T}.AsSpanFromPosition"/>
        public ReadOnlySpan<T> AsSpanFromPosition() => _state.Stream.AsSpanFromPosition();
        /// <inheritdoc cref="JCOBridgeStream{T}.AsWritableSpan"/>
        public Span<T> AsWritableSpan() => _state.Stream.AsWritableSpan();
        /// <inheritdoc cref="JCOBridgeStream{T}.AsWritableSpan"/>
        public Span<T> AsWritableSpanFromPosition() => _state.Stream.AsWritableSpanFromPosition();
        /// <inheritdoc cref="JCOBridgeStream{T}.Write(ReadOnlySpan{byte})"/>
        public void Write(ReadOnlySpan<byte> buffer) => _state.Stream.Write(buffer);
        /// <inheritdoc cref="JCOBridgeStream{T}.WriteAsync(ReadOnlyMemory{byte}, CancellationToken)"/>
        public ValueTask WriteAsync(ReadOnlyMemory<byte> buffer, CancellationToken cancellationToken = default) => _state.Stream.WriteAsync(buffer, cancellationToken);
#endif
        /// <inheritdoc cref="JCOBridgeStream{T}.GetEnumerator"/>
        public IEnumerator<T> GetEnumerator()
        {
            return _state.Stream.GetEnumerator();
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
