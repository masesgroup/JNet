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

namespace Java.Util.Concurrent.Locks
{
    #region ReentrantReadWriteLock
    public partial class ReentrantReadWriteLock
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#<init>(boolean)
        /// </summary>
        public ReentrantReadWriteLock(bool arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Util.Concurrent.Locks.ReadWriteLock(Java.Util.Concurrent.Locks.ReentrantReadWriteLock t) => t.Cast<Java.Util.Concurrent.Locks.ReadWriteLock>();
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.ReentrantReadWriteLock t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#getQueueLength() 
        /// </summary>
        public int QueueLength
        {
            get { return IExecute<int>("getQueueLength"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#getReadHoldCount() 
        /// </summary>
        public int ReadHoldCount
        {
            get { return IExecute<int>("getReadHoldCount"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#getReadLockCount() 
        /// </summary>
        public int ReadLockCount
        {
            get { return IExecute<int>("getReadLockCount"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#getWriteHoldCount() 
        /// </summary>
        public int WriteHoldCount
        {
            get { return IExecute<int>("getWriteHoldCount"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#hasWaiters(java.util.concurrent.locks.Condition)
        /// </summary>
        public bool HasWaiters(Java.Util.Concurrent.Locks.Condition arg0)
        {
            return IExecute<bool>("hasWaiters", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#isWriteLocked()
        /// </summary>
        public bool IsWriteLocked()
        {
            return IExecute<bool>("isWriteLocked");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#isWriteLockedByCurrentThread()
        /// </summary>
        public bool IsWriteLockedByCurrentThread()
        {
            return IExecute<bool>("isWriteLockedByCurrentThread");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#hasQueuedThread(java.lang.Thread)
        /// </summary>
        public bool HasQueuedThread(Java.Lang.Thread arg0)
        {
            return IExecute<bool>("hasQueuedThread", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#hasQueuedThreads()
        /// </summary>
        public bool HasQueuedThreads()
        {
            return IExecute<bool>("hasQueuedThreads");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#isFair()
        /// </summary>
        public bool IsFair()
        {
            return IExecute<bool>("isFair");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#getWaitQueueLength(java.util.concurrent.locks.Condition)
        /// </summary>
        public int GetWaitQueueLength(Java.Util.Concurrent.Locks.Condition arg0)
        {
            return IExecute<int>("getWaitQueueLength", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#readLock()
        /// </summary>
        public Java.Util.Concurrent.Locks.Lock ReadLockMethod()
        {
            return IExecute<Java.Util.Concurrent.Locks.Lock>("readLock");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.html#writeLock()
        /// </summary>
        public Java.Util.Concurrent.Locks.Lock WriteLockMethod()
        {
            return IExecute<Java.Util.Concurrent.Locks.Lock>("writeLock");
        }
        
        #endregion

        #region Nested classes
        #region ReadLock
        public partial class ReadLock
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Util.Concurrent.Locks.Lock(Java.Util.Concurrent.Locks.ReentrantReadWriteLock.ReadLock t) => t.Cast<Java.Util.Concurrent.Locks.Lock>();
            public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.ReentrantReadWriteLock.ReadLock t) => t.Cast<Java.Io.Serializable>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#tryLock()
            /// </summary>
            public bool TryLock()
            {
                return IExecute<bool>("tryLock");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#newCondition()
            /// </summary>
            public Java.Util.Concurrent.Locks.Condition NewCondition()
            {
                return IExecute<Java.Util.Concurrent.Locks.Condition>("newCondition");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#locks.ReentrantReadWriteLock$ReadLock.lock()
            /// </summary>
            public void Lock()
            {
                IExecute("lock");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#lockInterruptibly() throws java.lang.InterruptedException
            /// </summary>
            public void LockInterruptibly()
            {
                IExecute("lockInterruptibly");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.ReadLock.html#unlock()
            /// </summary>
            public void Unlock()
            {
                IExecute("unlock");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region WriteLock
        public partial class WriteLock
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Util.Concurrent.Locks.Lock(Java.Util.Concurrent.Locks.ReentrantReadWriteLock.WriteLock t) => t.Cast<Java.Util.Concurrent.Locks.Lock>();
            public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.ReentrantReadWriteLock.WriteLock t) => t.Cast<Java.Io.Serializable>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#getHoldCount() 
            /// </summary>
            public int HoldCount
            {
                get { return IExecute<int>("getHoldCount"); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#isHeldByCurrentThread()
            /// </summary>
            public bool IsHeldByCurrentThread()
            {
                return IExecute<bool>("isHeldByCurrentThread");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#tryLock()
            /// </summary>
            public bool TryLock()
            {
                return IExecute<bool>("tryLock");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#newCondition()
            /// </summary>
            public Java.Util.Concurrent.Locks.Condition NewCondition()
            {
                return IExecute<Java.Util.Concurrent.Locks.Condition>("newCondition");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#locks.ReentrantReadWriteLock$WriteLock.lock()
            /// </summary>
            public void Lock()
            {
                IExecute("lock");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#lockInterruptibly() throws java.lang.InterruptedException
            /// </summary>
            public void LockInterruptibly()
            {
                IExecute("lockInterruptibly");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantReadWriteLock.WriteLock.html#unlock()
            /// </summary>
            public void Unlock()
            {
                IExecute("unlock");
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