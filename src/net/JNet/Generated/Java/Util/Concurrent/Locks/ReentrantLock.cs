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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent.Locks
{
    #region ReentrantLock
    public partial class ReentrantLock
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public ReentrantLock(bool arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Locks.ReentrantLock"/> to <see cref="Java.Util.Concurrent.Locks.Lock"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Locks.Lock(Java.Util.Concurrent.Locks.ReentrantLock t) => t.Cast<Java.Util.Concurrent.Locks.Lock>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Locks.ReentrantLock"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Locks.ReentrantLock t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#getHoldCount()"/> 
        /// </summary>
        public int HoldCount
        {
            get { return IExecute<int>("getHoldCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#getQueueLength()"/> 
        /// </summary>
        public int QueueLength
        {
            get { return IExecute<int>("getQueueLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#hasWaiters(java.util.concurrent.locks.Condition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.Condition"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasWaiters(Java.Util.Concurrent.Locks.Condition arg0)
        {
            return IExecute<bool>("hasWaiters", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#isHeldByCurrentThread()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsHeldByCurrentThread()
        {
            return IExecute<bool>("isHeldByCurrentThread");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#isLocked()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLocked()
        {
            return IExecute<bool>("isLocked");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#tryLock()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool TryLock()
        {
            return IExecute<bool>("tryLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#tryLock(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("tryLock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#hasQueuedThread(java.lang.Thread)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Thread"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool HasQueuedThread(Java.Lang.Thread arg0)
        {
            return IExecute<bool>("hasQueuedThread", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#hasQueuedThreads()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasQueuedThreads()
        {
            return IExecute<bool>("hasQueuedThreads");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#isFair()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFair()
        {
            return IExecute<bool>("isFair");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#getWaitQueueLength(java.util.concurrent.locks.Condition)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.Locks.Condition"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetWaitQueueLength(Java.Util.Concurrent.Locks.Condition arg0)
        {
            return IExecute<int>("getWaitQueueLength", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#newCondition()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Locks.Condition"/></returns>
        public Java.Util.Concurrent.Locks.Condition NewCondition()
        {
            return IExecute<Java.Util.Concurrent.Locks.Condition>("newCondition");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#lock()"/>
        /// </summary>
        public void Lock()
        {
            IExecute("lock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#lockInterruptibly()"/>
        /// </summary>

        /// <exception cref="Java.Lang.InterruptedException"/>
        public void LockInterruptibly()
        {
            IExecute("lockInterruptibly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/ReentrantLock.html#unlock()"/>
        /// </summary>
        public void Unlock()
        {
            IExecute("unlock");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}