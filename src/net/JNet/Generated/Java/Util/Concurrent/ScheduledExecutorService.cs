/*
*  Copyright 2024 MASES s.r.l.
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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region IScheduledExecutorService
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IScheduledExecutorService : Java.Util.Concurrent.IExecutorService
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#schedule(java.util.concurrent.Callable,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        Java.Util.Concurrent.ScheduledFuture<V> Schedule<V>(Java.Util.Concurrent.Callable<V> arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#schedule(java.lang.Runnable,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        Java.Util.Concurrent.ScheduledFuture<object> Schedule(Java.Lang.Runnable arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#scheduleAtFixedRate(java.lang.Runnable,long,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        Java.Util.Concurrent.ScheduledFuture<object> ScheduleAtFixedRate(Java.Lang.Runnable arg0, long arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#scheduleWithFixedDelay(java.lang.Runnable,long,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        Java.Util.Concurrent.ScheduledFuture<object> ScheduleWithFixedDelay(Java.Lang.Runnable arg0, long arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScheduledExecutorService
    public partial class ScheduledExecutorService : Java.Util.Concurrent.IScheduledExecutorService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#schedule(java.util.concurrent.Callable,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <typeparam name="V"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        public Java.Util.Concurrent.ScheduledFuture<V> Schedule<V>(Java.Util.Concurrent.Callable<V> arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<Java.Util.Concurrent.ScheduledFuture<V>>("schedule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#schedule(java.lang.Runnable,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        public Java.Util.Concurrent.ScheduledFuture<object> Schedule(Java.Lang.Runnable arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<Java.Util.Concurrent.ScheduledFuture<object>>("schedule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#scheduleAtFixedRate(java.lang.Runnable,long,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        public Java.Util.Concurrent.ScheduledFuture<object> ScheduleAtFixedRate(Java.Lang.Runnable arg0, long arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3)
        {
            return IExecute<Java.Util.Concurrent.ScheduledFuture<object>>("scheduleAtFixedRate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#scheduleWithFixedDelay(java.lang.Runnable,long,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        public Java.Util.Concurrent.ScheduledFuture<object> ScheduleWithFixedDelay(Java.Lang.Runnable arg0, long arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3)
        {
            return IExecute<Java.Util.Concurrent.ScheduledFuture<object>>("scheduleWithFixedDelay", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}