/*
*  Copyright 2023 MASES s.r.l.
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
using System.Collections.Concurrent;

namespace MASES.JNet.Specific
{
    /// <summary>
    /// An extension of <see cref="JVMBridgeBaseEnumerator{TObject}"/> implementing <see cref="IAsyncEnumerator{TObject}"/> used to manage Java Iterator in async way
    /// </summary>
    /// <typeparam name="TObject">The returning type of the iterator</typeparam>
    public class JVMBridgeBaseAsyncEnumerator<TObject> : JVMBridgeBaseEnumerator<TObject>, IAsyncEnumerator<TObject>
    {
        CancellationToken _cancellationToken = default;
        IJavaObject _refObj = null;
        ManualResetEvent startObj = new ManualResetEvent(false);
        ConcurrentQueue<(bool, TObject)> dataQueue = new ConcurrentQueue<(bool, TObject)>();
        (bool, TObject) _currentValue;
        bool disposing = false;
        bool advancingThreadRun = false;
        Thread advancingThread = null;
        /// <summary>
        /// Initialize a new <see cref="JVMBridgeBaseAsyncEnumerator{TObject}"/>
        /// </summary>
        /// <param name="refObj">Reference to <see cref="IJavaObject"/> implementing Java Iterator</param>
        /// <param name="cancellationToken"><see cref="CancellationToken"/> to use in the iteration</param>
        public JVMBridgeBaseAsyncEnumerator(IJavaObject refObj, CancellationToken cancellationToken)
            : base(refObj)
        {
            _refObj = refObj;
            _cancellationToken = cancellationToken;
            if (Advance())
            {
                advancingThread = new Thread(() =>
                {
                    try
                    {
                        advancingThreadRun = true; startObj.Set();
                        while (_cancellationToken == null || !_cancellationToken.IsCancellationRequested)
                        {
                            if (disposing) return;
                            if (!Advance())
                            {
                                return;
                            }
                        }
                    }
                    finally { advancingThreadRun = false; }
                });
                advancingThread.Start();
                startObj.WaitOne();
            }
        }
        bool Advance()
        {
            TObject data = default;
            bool hasNext = _refObj.Invoke<bool>("hasNext");
            if (hasNext)
            {
                data = _refObj.Invoke<TObject>("next");
            }
            dataQueue.Enqueue((hasNext, data));
            return hasNext;
        }
        /// <inheritdoc cref="IAsyncEnumerator{T}.Current"/>
        public TObject Current
        {
            get
            {
                return _currentValue.Item2;
            }
        }

        /// <inheritdoc cref="IAsyncDisposable.DisposeAsync"/>
        public ValueTask DisposeAsync()
        {
            disposing = true;
            advancingThread?.Join();
            return new ValueTask();
        }
        /// <inheritdoc cref="IAsyncEnumerator{T}.MoveNextAsync"/>
        public ValueTask<bool> MoveNextAsync()
        {
            if (_cancellationToken.IsCancellationRequested) return new ValueTask<bool>(false);
            lock (startObj)
            {
                if (!dataQueue.TryDequeue(out _currentValue) && !advancingThreadRun) return new ValueTask<bool>(false);
            }
            return new ValueTask<bool>(_currentValue.Item1);
        }
    }

    /// <summary>
    /// An extension of <see cref="JVMBridgeBaseEnumerable{TClass, TObject}"/> implementing <see cref="IAsyncEnumerable{TObject}"/> to manage Java Iterable in async way
    /// </summary>
    /// <typeparam name="TClass">The class implementing <see cref="IJVMBridgeBase"/></typeparam>
    /// <typeparam name="TObject">The type of objects to enumerate implementing <see cref="IJVMBridgeBase"/></typeparam>
    public abstract class JVMBridgeBaseAsyncEnumerable<TClass, TObject> : JVMBridgeBaseEnumerable<TClass, TObject>, IAsyncEnumerable<TObject>
        where TClass : JVMBridgeBase, new()
    {
        /// <inheritdoc cref="IAsyncEnumerable{TObject}.GetAsyncEnumerator(CancellationToken)"/>
        public IAsyncEnumerator<TObject> GetAsyncEnumerator(CancellationToken cancellationToken = default)
        {
            return new JVMBridgeBaseAsyncEnumerator<TObject>(IExecute("iterator") as IJavaObject, cancellationToken);
        }
    }
}
