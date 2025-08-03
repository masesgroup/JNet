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

using MASES.JCOBridge.C2JBridge.JVMInterop;
using MASES.JCOBridge.C2JBridge;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Threading;

namespace MASES.JNet.Specific
{
    /// <summary>
    /// An extension of <see cref="JVMBridgeBasePrefetchableEnumerator{TObject}"/> implementing <see cref="IAsyncEnumerator{TObject}"/> used to manage Java Iterator in async way
    /// </summary>
    /// <typeparam name="TObject">The returning type of the iterator</typeparam>
    public class JNetAsyncEnumerator<TObject> : JVMBridgeBasePrefetchableEnumerator<TObject>, IAsyncEnumerator<TObject>
    {
        readonly ManualResetEvent _sync = new ManualResetEvent(false);
        readonly IEnumerator<TObject> enumeratorBase = default;
        readonly CancellationToken _cancellationToken = default;
        /// <summary>
        /// Initialize a new <see cref="JNetAsyncEnumerator{TObject}"/>
        /// </summary>
        /// <param name="refObj">Reference to <see cref="IJavaObject"/> implementing Java Iterator</param>
        /// <param name="extension">Extension from <see cref="JVMBridgeBaseEnumerable{TClass}"/></param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/> to use in the iteration</param>
        public JNetAsyncEnumerator(IJavaObject refObj, IEnumerableExtension extension, CancellationToken cancellationToken)
            : base(refObj, extension)
        {
            _cancellationToken = cancellationToken;
            enumeratorBase = this;
        }
        /// <inheritdoc/>
        protected override bool DoWorkCycle()
        {
            _sync.WaitOne();
            _sync.Reset();
            return !_cancellationToken.IsCancellationRequested;
        }

        /// <inheritdoc cref="IAsyncEnumerator{T}.Current"/>
        TObject IAsyncEnumerator<TObject>.Current => enumeratorBase.Current;

        /// <inheritdoc cref="IAsyncDisposable.DisposeAsync"/>
        ValueTask IAsyncDisposable.DisposeAsync()
        {
            _sync.Set();
            enumeratorBase.Dispose();
            _sync.Dispose();
            GC.SuppressFinalize(this);
            return new ValueTask();
        }
        /// <inheritdoc cref="IAsyncEnumerator{T}.MoveNextAsync"/>
        public ValueTask<bool> MoveNextAsync()
        {
            _sync.Set();
            if (_cancellationToken.IsCancellationRequested) return new ValueTask<bool>(false);
            var retVal = enumeratorBase.MoveNext();
            return new ValueTask<bool>(retVal);
        }
    }

    /// <summary>
    /// An extension of <see cref="JVMBridgeBaseEnumerable{TClass, TObject}"/> implementing <see cref="IAsyncEnumerable{TObject}"/> to manage Java Iterable in async way
    /// </summary>
    /// <typeparam name="TClass">The class implementing <see cref="IJVMBridgeBase"/></typeparam>
    /// <typeparam name="TObject">The type of objects to enumerate implementing <see cref="IJVMBridgeBase"/></typeparam>
    public abstract class JNetAsyncEnumerable<TClass, TObject> : JVMBridgeBaseEnumerable<TClass, TObject>, IAsyncEnumerable<TObject>
        where TClass : JVMBridgeBase, new()
    {
        /// <summary>
        /// Create an instance of <see cref="JNetAsyncEnumerable{TClass, TObject}"/>
        /// </summary>
        public JNetAsyncEnumerable()
        {
        }
        /// <summary>
        /// Create an instance of <see cref="JNetAsyncEnumerable{TClass, TObject}"/>
        /// </summary>
        /// <param name="args">The arguments to send to base class <see cref="JVMBridgeBaseEnumerable{TClass,TObject}"/></param>
        public JNetAsyncEnumerable(params object[] args)
            : base(args)
        {
        }
        /// <inheritdoc cref="IAsyncEnumerable{TObject}.GetAsyncEnumerator(CancellationToken)"/>
        public IAsyncEnumerator<TObject> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new JNetAsyncEnumerator<TObject>(IExecute("iterator") as IJavaObject, this, cancellationToken);
        }
    }
}
