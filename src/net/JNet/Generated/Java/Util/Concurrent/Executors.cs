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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region Executors
    public partial class Executors
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#callable(java.lang.Runnable,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable Callable(Java.Lang.Runnable arg0, object arg1)
        {
            return SExecute<Java.Util.Concurrent.Callable>("callable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#privilegedCallable(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable PrivilegedCallableMethod(Java.Util.Concurrent.Callable arg0)
        {
            return SExecute<Java.Util.Concurrent.Callable>("privilegedCallable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#privilegedCallableUsingCurrentClassLoader(java.util.concurrent.Callable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Callable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable PrivilegedCallableUsingCurrentClassLoaderMethod(Java.Util.Concurrent.Callable arg0)
        {
            return SExecute<Java.Util.Concurrent.Callable>("privilegedCallableUsingCurrentClassLoader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#callable(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable Callable(Java.Lang.Runnable arg0)
        {
            return SExecute<Java.Util.Concurrent.Callable>("callable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#callable(java.security.PrivilegedAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedAction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable Callable(Java.Security.PrivilegedAction arg0)
        {
            return SExecute<Java.Util.Concurrent.Callable>("callable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#callable(java.security.PrivilegedExceptionAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PrivilegedExceptionAction"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Callable"/></returns>
        public static Java.Util.Concurrent.Callable Callable(Java.Security.PrivilegedExceptionAction arg0)
        {
            return SExecute<Java.Util.Concurrent.Callable>("callable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newCachedThreadPool()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewCachedThreadPool()
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("newCachedThreadPool");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newCachedThreadPool(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewCachedThreadPool(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("newCachedThreadPool", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newFixedThreadPool(int,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewFixedThreadPool(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("newFixedThreadPool", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newFixedThreadPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewFixedThreadPool(int arg0)
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("newFixedThreadPool", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newSingleThreadExecutor()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewSingleThreadExecutor()
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("newSingleThreadExecutor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newSingleThreadExecutor(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewSingleThreadExecutor(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("newSingleThreadExecutor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newWorkStealingPool()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewWorkStealingPool()
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("newWorkStealingPool");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newWorkStealingPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService NewWorkStealingPool(int arg0)
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("newWorkStealingPool", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#unconfigurableExecutorService(java.util.concurrent.ExecutorService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ExecutorService"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ExecutorService"/></returns>
        public static Java.Util.Concurrent.ExecutorService UnconfigurableExecutorService(Java.Util.Concurrent.ExecutorService arg0)
        {
            return SExecute<Java.Util.Concurrent.ExecutorService>("unconfigurableExecutorService", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newScheduledThreadPool(int,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewScheduledThreadPool(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
        {
            return SExecute<Java.Util.Concurrent.ScheduledExecutorService>("newScheduledThreadPool", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newScheduledThreadPool(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewScheduledThreadPool(int arg0)
        {
            return SExecute<Java.Util.Concurrent.ScheduledExecutorService>("newScheduledThreadPool", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newSingleThreadScheduledExecutor()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewSingleThreadScheduledExecutor()
        {
            return SExecute<Java.Util.Concurrent.ScheduledExecutorService>("newSingleThreadScheduledExecutor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#newSingleThreadScheduledExecutor(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService NewSingleThreadScheduledExecutor(Java.Util.Concurrent.ThreadFactory arg0)
        {
            return SExecute<Java.Util.Concurrent.ScheduledExecutorService>("newSingleThreadScheduledExecutor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#unconfigurableScheduledExecutorService(java.util.concurrent.ScheduledExecutorService)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></param>
        /// <returns><see cref="Java.Util.Concurrent.ScheduledExecutorService"/></returns>
        public static Java.Util.Concurrent.ScheduledExecutorService UnconfigurableScheduledExecutorService(Java.Util.Concurrent.ScheduledExecutorService arg0)
        {
            return SExecute<Java.Util.Concurrent.ScheduledExecutorService>("unconfigurableScheduledExecutorService", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#defaultThreadFactory()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.ThreadFactory"/></returns>
        public static Java.Util.Concurrent.ThreadFactory DefaultThreadFactoryMethod()
        {
            return SExecute<Java.Util.Concurrent.ThreadFactory>("defaultThreadFactory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Executors.html#privilegedThreadFactory()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Concurrent.ThreadFactory"/></returns>
        public static Java.Util.Concurrent.ThreadFactory PrivilegedThreadFactoryMethod()
        {
            return SExecute<Java.Util.Concurrent.ThreadFactory>("privilegedThreadFactory");
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}