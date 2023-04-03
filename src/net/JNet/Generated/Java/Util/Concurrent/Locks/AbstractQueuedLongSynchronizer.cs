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

namespace Java.Util.Concurrent.Locks
{
    #region AbstractQueuedLongSynchronizer
    public partial class AbstractQueuedLongSynchronizer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#getExclusiveQueuedThreads()"/> 
        /// </summary>
        public Java.Util.Collection<Java.Lang.Thread> ExclusiveQueuedThreads
        {
            get { return IExecute<Java.Util.Collection<Java.Lang.Thread>>("getExclusiveQueuedThreads"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#getFirstQueuedThread()"/> 
        /// </summary>
        public Java.Lang.Thread FirstQueuedThread
        {
            get { return IExecute<Java.Lang.Thread>("getFirstQueuedThread"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#hasContended()"/> 
        /// </summary>
        public bool HasContended
        {
            get { return IExecute<bool>("hasContended"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#hasQueuedPredecessors()"/> 
        /// </summary>
        public bool HasQueuedPredecessors
        {
            get { return IExecute<bool>("hasQueuedPredecessors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#hasQueuedThreads()"/> 
        /// </summary>
        public bool HasQueuedThreads
        {
            get { return IExecute<bool>("hasQueuedThreads"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#getQueuedThreads()"/> 
        /// </summary>
        public Java.Util.Collection<Java.Lang.Thread> QueuedThreads
        {
            get { return IExecute<Java.Util.Collection<Java.Lang.Thread>>("getQueuedThreads"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#getQueueLength()"/> 
        /// </summary>
        public int QueueLength
        {
            get { return IExecute<int>("getQueueLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#getSharedQueuedThreads()"/> 
        /// </summary>
        public Java.Util.Collection<Java.Lang.Thread> SharedQueuedThreads
        {
            get { return IExecute<Java.Util.Collection<Java.Lang.Thread>>("getSharedQueuedThreads"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#hasWaiters(java.util.concurrent.locks.AbstractQueuedLongSynchronizer.ConditionObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasWaiters(Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject arg0)
        {
            return IExecute<bool>("hasWaiters", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#isQueued(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsQueued(Java.Lang.Thread arg0)
        {
            return IExecute<bool>("isQueued", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#owns(java.util.concurrent.locks.AbstractQueuedLongSynchronizer.ConditionObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Owns(Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject arg0)
        {
            return IExecute<bool>("owns", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#release(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Release(long arg0)
        {
            return IExecute<bool>("release", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#releaseShared(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ReleaseShared(long arg0)
        {
            return IExecute<bool>("releaseShared", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#tryAcquireNanos(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryAcquireNanos(long arg0, long arg1)
        {
            return IExecute<bool>("tryAcquireNanos", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#tryAcquireSharedNanos(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryAcquireSharedNanos(long arg0, long arg1)
        {
            return IExecute<bool>("tryAcquireSharedNanos", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#getWaitQueueLength(java.util.concurrent.locks.AbstractQueuedLongSynchronizer.ConditionObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetWaitQueueLength(Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject arg0)
        {
            return IExecute<int>("getWaitQueueLength", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#getWaitingThreads(java.util.concurrent.locks.AbstractQueuedLongSynchronizer.ConditionObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        public Java.Util.Collection<Java.Lang.Thread> GetWaitingThreads(Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject arg0)
        {
            return IExecute<Java.Util.Collection<Java.Lang.Thread>>("getWaitingThreads", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#acquire(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Acquire(long arg0)
        {
            IExecute("acquire", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#acquireInterruptibly(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void AcquireInterruptibly(long arg0)
        {
            IExecute("acquireInterruptibly", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#acquireShared(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void AcquireShared(long arg0)
        {
            IExecute("acquireShared", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.html#acquireSharedInterruptibly(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void AcquireSharedInterruptibly(long arg0)
        {
            IExecute("acquireSharedInterruptibly", arg0);
        }
        
        #endregion

        #region Nested classes
        #region ConditionObject
        public partial class ConditionObject
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html#%3Cinit%3E(java.util.concurrent.locks.AbstractQueuedLongSynchronizer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer"/></param>
            public ConditionObject(Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject"/> to <see cref="Java.Util.Concurrent.Locks.Condition"/>
            /// </summary>
            public static implicit operator Java.Util.Concurrent.Locks.Condition(Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject t) => t.Cast<Java.Util.Concurrent.Locks.Condition>();
            /// <summary>
            /// Converter from <see cref="Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.AbstractQueuedLongSynchronizer.ConditionObject t) => t.Cast<Java.Io.Serializable>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html#await(long,java.util.concurrent.TimeUnit)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public bool Await(long arg0, Java.Util.Concurrent.TimeUnit arg1)
            {
                return IExecute<bool>("await", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html#awaitUntil(java.util.Date)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Date"/></param>
            /// <returns><see cref="bool"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public bool AwaitUntil(Java.Util.Date arg0)
            {
                return IExecute<bool>("awaitUntil", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html#awaitNanos(long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="long"/></param>
            /// <returns><see cref="long"/></returns>
            /// <exception cref="Java.Lang.InterruptedException"/>
            public long AwaitNanos(long arg0)
            {
                return IExecute<long>("awaitNanos", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html#await()"/>
            /// </summary>
            
            /// <exception cref="Java.Lang.InterruptedException"/>
            public void Await()
            {
                IExecute("await");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html#awaitUninterruptibly()"/>
            /// </summary>
            public void AwaitUninterruptibly()
            {
                IExecute("awaitUninterruptibly");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html#signal()"/>
            /// </summary>
            public void Signal()
            {
                IExecute("signal");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/AbstractQueuedLongSynchronizer.ConditionObject.html#signalAll()"/>
            /// </summary>
            public void SignalAll()
            {
                IExecute("signalAll");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}