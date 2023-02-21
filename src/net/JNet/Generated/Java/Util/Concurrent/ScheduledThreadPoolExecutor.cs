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
    #region ScheduledThreadPoolExecutor
    public partial class ScheduledThreadPoolExecutor
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#<init>(int)
        /// </summary>
        public ScheduledThreadPoolExecutor(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#<init>(int,java.util.concurrent.RejectedExecutionHandler)
        /// </summary>
        public ScheduledThreadPoolExecutor(int arg0, Java.Util.Concurrent.RejectedExecutionHandler arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#<init>(int,java.util.concurrent.ThreadFactory,java.util.concurrent.RejectedExecutionHandler)
        /// </summary>
        public ScheduledThreadPoolExecutor(int arg0, Java.Util.Concurrent.ThreadFactory arg1, Java.Util.Concurrent.RejectedExecutionHandler arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#<init>(int,java.util.concurrent.ThreadFactory)
        /// </summary>
        public ScheduledThreadPoolExecutor(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Util.Concurrent.ScheduledExecutorService(Java.Util.Concurrent.ScheduledThreadPoolExecutor t) => t.Cast<Java.Util.Concurrent.ScheduledExecutorService>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#getContinueExistingPeriodicTasksAfterShutdownPolicy() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#setContinueExistingPeriodicTasksAfterShutdownPolicy(boolean)
        /// </summary>
        public bool ContinueExistingPeriodicTasksAfterShutdownPolicy
        {
            get { return IExecute<bool>("getContinueExistingPeriodicTasksAfterShutdownPolicy"); } set { IExecute("setContinueExistingPeriodicTasksAfterShutdownPolicy", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#getExecuteExistingDelayedTasksAfterShutdownPolicy() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#setExecuteExistingDelayedTasksAfterShutdownPolicy(boolean)
        /// </summary>
        public bool ExecuteExistingDelayedTasksAfterShutdownPolicy
        {
            get { return IExecute<bool>("getExecuteExistingDelayedTasksAfterShutdownPolicy"); } set { IExecute("setExecuteExistingDelayedTasksAfterShutdownPolicy", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#getRemoveOnCancelPolicy() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ScheduledThreadPoolExecutor.html#setRemoveOnCancelPolicy(boolean)
        /// </summary>
        public bool RemoveOnCancelPolicy
        {
            get { return IExecute<bool>("getRemoveOnCancelPolicy"); } set { IExecute("setRemoveOnCancelPolicy", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}