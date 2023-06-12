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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent.Locks
{
    #region StampedLock
    public partial class StampedLock
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#isLockStamp(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsLockStamp(long arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isLockStamp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#isOptimisticReadStamp(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsOptimisticReadStamp(long arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isOptimisticReadStamp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#isReadLockStamp(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsReadLockStamp(long arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isReadLockStamp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#isWriteLockStamp(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsWriteLockStamp(long arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isWriteLockStamp", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#getReadLockCount()"/> 
        /// </summary>
        public int ReadLockCount
        {
            get { return IExecute<int>("getReadLockCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#isReadLocked()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsReadLocked()
        {
            return IExecute<bool>("isReadLocked");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#isWriteLocked()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsWriteLocked()
        {
            return IExecute<bool>("isWriteLocked");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryUnlockRead()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool TryUnlockRead()
        {
            return IExecute<bool>("tryUnlockRead");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryUnlockWrite()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool TryUnlockWrite()
        {
            return IExecute<bool>("tryUnlockWrite");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#validate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Validate(long arg0)
        {
            return IExecute<bool>("validate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#asReadLock()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Locks.Lock"/></returns>
        public Java.Util.Concurrent.Locks.Lock AsReadLock()
        {
            return IExecute<Java.Util.Concurrent.Locks.Lock>("asReadLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#asWriteLock()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Locks.Lock"/></returns>
        public Java.Util.Concurrent.Locks.Lock AsWriteLock()
        {
            return IExecute<Java.Util.Concurrent.Locks.Lock>("asWriteLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#asReadWriteLock()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Concurrent.Locks.ReadWriteLock"/></returns>
        public Java.Util.Concurrent.Locks.ReadWriteLock AsReadWriteLock()
        {
            return IExecute<Java.Util.Concurrent.Locks.ReadWriteLock>("asReadWriteLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#readLock()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long ReadLock()
        {
            return IExecute<long>("readLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#readLockInterruptibly()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long ReadLockInterruptibly()
        {
            return IExecute<long>("readLockInterruptibly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryConvertToOptimisticRead(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long TryConvertToOptimisticRead(long arg0)
        {
            return IExecute<long>("tryConvertToOptimisticRead", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryConvertToReadLock(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long TryConvertToReadLock(long arg0)
        {
            return IExecute<long>("tryConvertToReadLock", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryConvertToWriteLock(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long TryConvertToWriteLock(long arg0)
        {
            return IExecute<long>("tryConvertToWriteLock", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryOptimisticRead()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long TryOptimisticRead()
        {
            return IExecute<long>("tryOptimisticRead");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryReadLock()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long TryReadLock()
        {
            return IExecute<long>("tryReadLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryReadLock(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long TryReadLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<long>("tryReadLock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryWriteLock()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long TryWriteLock()
        {
            return IExecute<long>("tryWriteLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#tryWriteLock(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long TryWriteLock(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<long>("tryWriteLock", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#writeLock()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long WriteLock()
        {
            return IExecute<long>("writeLock");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#writeLockInterruptibly()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public long WriteLockInterruptibly()
        {
            return IExecute<long>("writeLockInterruptibly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#unlock(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Unlock(long arg0)
        {
            IExecute("unlock", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#unlockRead(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void UnlockRead(long arg0)
        {
            IExecute("unlockRead", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/locks/StampedLock.html#unlockWrite(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void UnlockWrite(long arg0)
        {
            IExecute("unlockWrite", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}