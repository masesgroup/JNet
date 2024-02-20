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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent
{
    #region ThreadPoolExecutor
    public partial class ThreadPoolExecutor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#%3Cinit%3E(int,int,long,java.util.concurrent.TimeUnit,java.util.concurrent.BlockingQueue,java.util.concurrent.RejectedExecutionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.BlockingQueue"/></param>
        /// <param name="arg5"><see cref="Java.Util.Concurrent.RejectedExecutionHandler"/></param>
        public ThreadPoolExecutor(int arg0, int arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3, Java.Util.Concurrent.BlockingQueue<Java.Lang.Runnable> arg4, Java.Util.Concurrent.RejectedExecutionHandler arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#%3Cinit%3E(int,int,long,java.util.concurrent.TimeUnit,java.util.concurrent.BlockingQueue,java.util.concurrent.ThreadFactory,java.util.concurrent.RejectedExecutionHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.BlockingQueue"/></param>
        /// <param name="arg5"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <param name="arg6"><see cref="Java.Util.Concurrent.RejectedExecutionHandler"/></param>
        public ThreadPoolExecutor(int arg0, int arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3, Java.Util.Concurrent.BlockingQueue<Java.Lang.Runnable> arg4, Java.Util.Concurrent.ThreadFactory arg5, Java.Util.Concurrent.RejectedExecutionHandler arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#%3Cinit%3E(int,int,long,java.util.concurrent.TimeUnit,java.util.concurrent.BlockingQueue,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.BlockingQueue"/></param>
        /// <param name="arg5"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        public ThreadPoolExecutor(int arg0, int arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3, Java.Util.Concurrent.BlockingQueue<Java.Lang.Runnable> arg4, Java.Util.Concurrent.ThreadFactory arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#%3Cinit%3E(int,int,long,java.util.concurrent.TimeUnit,java.util.concurrent.BlockingQueue)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <param name="arg4"><see cref="Java.Util.Concurrent.BlockingQueue"/></param>
        public ThreadPoolExecutor(int arg0, int arg1, long arg2, Java.Util.Concurrent.TimeUnit arg3, Java.Util.Concurrent.BlockingQueue<Java.Lang.Runnable> arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getActiveCount()"/> 
        /// </summary>
        public int ActiveCount
        {
            get { return IExecute<int>("getActiveCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getCompletedTaskCount()"/> 
        /// </summary>
        public long CompletedTaskCount
        {
            get { return IExecute<long>("getCompletedTaskCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getCorePoolSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#setCorePoolSize(int)"/>
        /// </summary>
        public int CorePoolSize
        {
            get { return IExecute<int>("getCorePoolSize"); } set { IExecute("setCorePoolSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getLargestPoolSize()"/> 
        /// </summary>
        public int LargestPoolSize
        {
            get { return IExecute<int>("getLargestPoolSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getMaximumPoolSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#setMaximumPoolSize(int)"/>
        /// </summary>
        public int MaximumPoolSize
        {
            get { return IExecute<int>("getMaximumPoolSize"); } set { IExecute("setMaximumPoolSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getPoolSize()"/> 
        /// </summary>
        public int PoolSize
        {
            get { return IExecute<int>("getPoolSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getQueue()"/> 
        /// </summary>
        public Java.Util.Concurrent.BlockingQueue<Java.Lang.Runnable> Queue
        {
            get { return IExecute<Java.Util.Concurrent.BlockingQueue<Java.Lang.Runnable>>("getQueue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getRejectedExecutionHandler()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#setRejectedExecutionHandler(java.util.concurrent.RejectedExecutionHandler)"/>
        /// </summary>
        public Java.Util.Concurrent.RejectedExecutionHandler RejectedExecutionHandler
        {
            get { return IExecute<Java.Util.Concurrent.RejectedExecutionHandler>("getRejectedExecutionHandler"); } set { IExecute("setRejectedExecutionHandler", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getTaskCount()"/> 
        /// </summary>
        public long TaskCount
        {
            get { return IExecute<long>("getTaskCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getThreadFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#setThreadFactory(java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        public Java.Util.Concurrent.ThreadFactory ThreadFactory
        {
            get { return IExecute<Java.Util.Concurrent.ThreadFactory>("getThreadFactory"); } set { IExecute("setThreadFactory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#allowsCoreThreadTimeOut()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool AllowsCoreThreadTimeOut()
        {
            return IExecute<bool>("allowsCoreThreadTimeOut");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#isTerminating()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTerminating()
        {
            return IExecute<bool>("isTerminating");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#prestartCoreThread()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool PrestartCoreThread()
        {
            return IExecute<bool>("prestartCoreThread");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#remove(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(Java.Lang.Runnable arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#prestartAllCoreThreads()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int PrestartAllCoreThreads()
        {
            return IExecute<int>("prestartAllCoreThreads");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#getKeepAliveTime(java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetKeepAliveTime(Java.Util.Concurrent.TimeUnit arg0)
        {
            return IExecute<long>("getKeepAliveTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#allowCoreThreadTimeOut(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void AllowCoreThreadTimeOut(bool arg0)
        {
            IExecute("allowCoreThreadTimeOut", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#purge()"/>
        /// </summary>
        public void Purge()
        {
            IExecute("purge");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.html#setKeepAliveTime(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        public void SetKeepAliveTime(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            IExecute("setKeepAliveTime", arg0, arg1);
        }

        #endregion

        #region Nested classes
        #region AbortPolicy
        public partial class AbortPolicy
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.AbortPolicy.html#rejectedExecution(java.lang.Runnable,java.util.concurrent.ThreadPoolExecutor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
            /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadPoolExecutor"/></param>
            public void RejectedExecution(Java.Lang.Runnable arg0, Java.Util.Concurrent.ThreadPoolExecutor arg1)
            {
                IExecute("rejectedExecution", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CallerRunsPolicy
        public partial class CallerRunsPolicy
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.CallerRunsPolicy.html#rejectedExecution(java.lang.Runnable,java.util.concurrent.ThreadPoolExecutor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
            /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadPoolExecutor"/></param>
            public void RejectedExecution(Java.Lang.Runnable arg0, Java.Util.Concurrent.ThreadPoolExecutor arg1)
            {
                IExecute("rejectedExecution", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DiscardOldestPolicy
        public partial class DiscardOldestPolicy
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.DiscardOldestPolicy.html#rejectedExecution(java.lang.Runnable,java.util.concurrent.ThreadPoolExecutor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
            /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadPoolExecutor"/></param>
            public void RejectedExecution(Java.Lang.Runnable arg0, Java.Util.Concurrent.ThreadPoolExecutor arg1)
            {
                IExecute("rejectedExecution", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DiscardPolicy
        public partial class DiscardPolicy
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ThreadPoolExecutor.DiscardPolicy.html#rejectedExecution(java.lang.Runnable,java.util.concurrent.ThreadPoolExecutor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
            /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadPoolExecutor"/></param>
            public void RejectedExecution(Java.Lang.Runnable arg0, Java.Util.Concurrent.ThreadPoolExecutor arg1)
            {
                IExecute("rejectedExecution", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}