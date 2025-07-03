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
using Java.Util;
using Java.Util.Concurrent;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace MASES.JNet.Specific.Extensions
{
    /// <summary>
    /// Extension for Java.Util classes
    /// </summary>
    public static class JavaUtilConcurrentExtensions
    {
        /// <summary>
        /// Execute the <paramref name="process"/> on completion of <paramref name="cf"/>
        /// </summary>
        /// <typeparam name="T">The <see cref="Type"/> asociated to the <see cref="Future{T}"/> passed from <paramref name="cf"/></typeparam>
        /// <param name="cf">The <see cref="CompletableFuture{T}"/> to manage</param>
        /// <param name="process">The <see cref="Action{T}"/> to be executed on completion of <paramref name="cf"/></param>
        public static void Complete<T>(this Future<T> cf, Action<T> process)
        {
            var response = cf.Get();
            process?.Invoke(response);
        }
        /// <summary>
        /// <see langword="async"/> executes the <paramref name="f"/> using the <see cref="CancellationToken"/> passed from <paramref name="token"/>
        /// </summary>
        /// <typeparam name="TResult">A <see cref="Type"/> asociated to the <see cref="Future{T}"/> passed from <paramref name="f"/></typeparam>
        /// <param name="f">The <see cref="CompletableFuture{T}"/> to manage</param>
        /// <param name="token">The optional <see cref="CancellationToken"/> can be passed</param>
        /// <returns>The <see cref="Task{TResult}"/> of the <see langword="async"/> pattern</returns>
        public static async Task<TResult> CompleteAsync<TResult>(this Future<TResult> f, CancellationToken token = default)
        {
            return await Task<TResult>.Run(() =>
            {
                try
                {
                    TResult result = f.Get();
                    return Task<TResult>.FromResult<TResult>(result);
                }
                catch (OperationCanceledException)
                {
                    f.Cancel(true);
                    return Task<TResult>.FromCanceled<TResult>(token);
                }
                catch (ExecutionException ee)
                {
                    return Task<TResult>.FromException<TResult>(ee.InnerException);
                }
                catch (System.Exception e)
                {
                    if (e is CancellationException || e is InterruptedException)
                    {
                        return Task<TResult>.FromCanceled<TResult>(token);
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
        /// <typeparam name="T">A <see cref="Type"/> asociated to the <see cref="CompletableFuture{T}"/> passed from <paramref name="cf"/></typeparam>
        /// <param name="cf">The <see cref="CompletableFuture{T}"/> to manage</param>
        /// <param name="process">The <see cref="Action{T}"/> to be executed on <see cref="CompletableFuture{T}.WhenComplete(Java.Util.Function.BiConsumer)"/> of <paramref name="cf"/></param>
        /// <param name="token">The optional <see cref="CancellationToken"/> can be passed</param>
        /// <returns>The <see cref="Task"/> of the <see langword="async"/> pattern</returns>
        public static async Task<T> CompleteAsync<T>(this CompletableFuture<T> cf, Action<T> process, CancellationToken token = default)
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
                    var cpStage = cf.WhenComplete(responseWaiter);
                    _resetEvent.WaitOne();
                    if (_exception != null) return Task<T>.FromException<T>(_exception);
                    return Task<T>.FromResult<T>(cf.Get());
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
