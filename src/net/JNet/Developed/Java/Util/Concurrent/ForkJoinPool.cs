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

namespace Java.Util.Concurrent
{
    public partial class ForkJoinPool
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#%3Cinit%3E(int,java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory,java.lang.Thread.UncaughtExceptionHandler,boolean,int,int,int,java.util.function.Predicate,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Thread.UncaughtExceptionHandler"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="Java.Util.Function.Predicate"/></param>
        /// <param name="arg8"><see cref="long"/></param>
        /// <param name="arg9"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        public ForkJoinPool(int arg0, Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory arg1, Java.Lang.Thread.UncaughtExceptionHandler arg2, bool arg3, int arg4, int arg5, int arg6, Java.Util.Function.Predicate arg7, long arg8, Java.Util.Concurrent.TimeUnit arg9)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ForkJoinPool.html#%3Cinit%3E(int,java.util.concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory,java.lang.Thread.UncaughtExceptionHandler,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Thread.UncaughtExceptionHandler"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public ForkJoinPool(int arg0, Java.Util.Concurrent.ForkJoinPool.ForkJoinWorkerThreadFactory arg1, Java.Lang.Thread.UncaughtExceptionHandler arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
    }
}
