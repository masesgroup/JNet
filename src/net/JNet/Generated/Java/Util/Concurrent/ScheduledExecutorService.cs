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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region ScheduledExecutorService
    public partial class ScheduledExecutorService
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ScheduledExecutorService"/> to <see cref="Java.Util.Concurrent.ExecutorService"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ExecutorService(Java.Util.Concurrent.ScheduledExecutorService t) => t.Cast<Java.Util.Concurrent.ExecutorService>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#schedule(java.util.concurrent.Callable%3CV%3E,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        public Java.Util.Concurrent.ScheduledFuture Schedule(Java.Util.Concurrent.Callable arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<Java.Util.Concurrent.ScheduledFuture>("schedule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#schedule(java.lang.Runnable,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        public Java.Util.Concurrent.ScheduledFuture Schedule(Java.Lang.Runnable arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<Java.Util.Concurrent.ScheduledFuture>("schedule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#scheduleAtFixedRate(java.lang.Runnable,long,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        public Java.Util.Concurrent.ScheduledFuture ScheduleAtFixedRate(Java.Lang.Runnable arg0, long arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3)
        {
            return IExecute<Java.Util.Concurrent.ScheduledFuture>("scheduleAtFixedRate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledExecutorService.html#scheduleWithFixedDelay(java.lang.Runnable,long,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledFuture"/></returns>
        public Java.Util.Concurrent.ScheduledFuture ScheduleWithFixedDelay(Java.Lang.Runnable arg0, long arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3)
        {
            return IExecute<Java.Util.Concurrent.ScheduledFuture>("scheduleWithFixedDelay", arg0, arg1, arg2, arg3);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}