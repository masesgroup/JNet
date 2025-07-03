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
    public partial class Future
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

    public partial class Future<V>
    {
        /// <summary>
        /// Executes <see cref="Get()"/> in <see langword="async"/>/<see langword="await"/> fashion
        /// </summary>
        /// <param name="token">The optional <see cref="CancellationToken"/> can be passed</param>
        /// <returns>The <see cref="Task{TResult}"/> of the <see langword="async"/> pattern</returns>
        public async Task<V> GetAsync(CancellationToken token = default)
        {
            return await Task<V>.Run(() =>
            {
                try
                {
                    token.ThrowIfCancellationRequested();
                    V result = this.Get();
                    return Task<V>.FromResult<V>(result);
                }
                catch (OperationCanceledException)
                {
                    this.Cancel(true);
                    return Task<V>.FromCanceled<V>(token);
                }
                catch (ExecutionException ee)
                {
                    return Task<V>.FromException<V>(ee.InnerException);
                }
                catch (System.Exception e)
                {
                    if (e is CancellationException || e is InterruptedException)
                    {
                        return Task<V>.FromCanceled<V>(token);
                    }
                    throw;
                }
                finally
                {
                }
            }, token);
        }
    }
}
