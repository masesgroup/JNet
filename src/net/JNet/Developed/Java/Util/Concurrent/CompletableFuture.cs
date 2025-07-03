/*
*  Copyright 2025 MASES s.r.l.
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
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Java.Util.Concurrent
{
    public partial class CompletableFuture
    {
        /// <summary>
        /// Executes <see cref="Get()"/> in <see langword="async"/>/<see langword="await"/> fashion
        /// </summary>
        /// <param name="token">The optional <see cref="CancellationToken"/> can be passed</param>
        /// <returns>The <see cref="Task{TResult}"/> of the <see langword="async"/> pattern</returns>
        public async Task<object> GetAsync(CancellationToken token = default)
        {
            return await Task<object>.Run(() =>
            {
                try
                {
                    token.ThrowIfCancellationRequested();
                    object result = this.Get();
                    return Task<object>.FromResult<object>(result);
                }
                catch (OperationCanceledException)
                {
                    this.Cancel(true);
                    return Task<object>.FromCanceled<object>(token);
                }
                catch (ExecutionException ee)
                {
                    return Task<object>.FromException<object>(ee.InnerException);
                }
                catch (System.Exception e)
                {
                    if (e is CancellationException || e is InterruptedException)
                    {
                        return Task<object>.FromCanceled<object>(token);
                    }
                    throw;
                }
                finally
                {
                }
            }, token);
        }
    }

    public partial class CompletableFuture<T>
    {
        /// <summary>
        /// Executes <see cref="Get()"/> in <see langword="async"/>/<see langword="await"/> fashion
        /// </summary>
        /// <param name="token">The optional <see cref="CancellationToken"/> can be passed</param>
        /// <returns>The <see cref="Task{TResult}"/> of the <see langword="async"/> pattern</returns>
        public async Task<T> GetAsync(CancellationToken token = default)
        {
            return await Task<T>.Run(() =>
            {
                try
                {
                    token.ThrowIfCancellationRequested();
                    T result = this.Get();
                    return Task<T>.FromResult<T>(result);
                }
                catch (OperationCanceledException)
                {
                    this.Cancel(true);
                    return Task<T>.FromCanceled<T>(token);
                }
                catch (ExecutionException ee)
                {
                    return Task<T>.FromException<T>(ee.InnerException);
                }
                catch (System.Exception e)
                {
                    if (e is CancellationException || e is InterruptedException)
                    {
                        return Task<T>.FromCanceled<T>(token);
                    }
                    throw;
                }
                finally
                {
                }
            }, token);
        }

        /// <summary>
        /// Execute the <paramref name="process"/> on completion of <paramref name="cf"/> using the <see cref="CancellationToken"/> passed from <paramref name="token"/>
        /// </summary>
        /// <param name="process">The <see cref="Action{T}"/> to be executed on <see cref="CompletableFuture{T}.WhenComplete(Java.Util.Function.BiConsumer)"/> of <paramref name="cf"/></param>
        /// <param name="token">The optional <see cref="CancellationToken"/> can be passed</param>
        /// <returns>The <see cref="Task"/> of the <see langword="async"/> pattern</returns>
        public async Task<T> CompleteAsync(Action<T> process, CancellationToken token = default)
        {
            return await Task<T>.Run(() =>
            {
                Java.Lang.Exception _exception = null;
                ManualResetEvent _resetEvent = new(false);
                try
                {
                    using Java.Util.Function.BiConsumer<T, Java.Lang.Exception> responseWaiter = new()
                    {
                        OnAccept = (r, e) =>
                        {
                            _exception = e;
                            _resetEvent.Set();
                            if (_exception == null)
                            {
                                process?.Invoke(r);
                            }
                        }
                    };
                    var cpStage = this.WhenCompleteAsync(responseWaiter);
                    _resetEvent.WaitOne();
                    if (_exception != null) return Task<T>.FromException<T>(_exception);
                    return Task<T>.FromResult<T>(this.Get());
                }
                catch (OperationCanceledException)
                {
                    return Task<T>.FromCanceled<T>(token);
                }
                finally
                {
                    _resetEvent.Dispose();
                }
            }, token);
        }
    }
}
