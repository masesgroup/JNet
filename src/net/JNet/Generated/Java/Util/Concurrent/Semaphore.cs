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
    #region Semaphore
    public partial class Semaphore
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#%3Cinit%3E(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public Semaphore(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Semaphore(int arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#getQueueLength()"/> 
        /// </summary>
        public int QueueLength
        {
            get { return IExecuteWithSignature<int>("getQueueLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#isFair()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFair()
        {
            return IExecuteWithSignature<bool>("isFair", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#tryAcquire()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool TryAcquire()
        {
            return IExecuteWithSignature<bool>("tryAcquire", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#tryAcquire(int,long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryAcquire(int arg0, long arg1, Java.Util.Concurrent.TimeUnit arg2)
        {
            return IExecute<bool>("tryAcquire", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#tryAcquire(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool TryAcquire(int arg0)
        {
            return IExecuteWithSignature<bool>("tryAcquire", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#tryAcquire(long,java.util.concurrent.TimeUnit)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.TimeUnit"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool TryAcquire(long arg0, Java.Util.Concurrent.TimeUnit arg1)
        {
            return IExecute<bool>("tryAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#hasQueuedThreads()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasQueuedThreads()
        {
            return IExecuteWithSignature<bool>("hasQueuedThreads", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#availablePermits()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int AvailablePermits()
        {
            return IExecuteWithSignature<int>("availablePermits", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#drainPermits()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int DrainPermits()
        {
            return IExecuteWithSignature<int>("drainPermits", "()I");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#acquire()"/>
        /// </summary>

        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Acquire()
        {
            IExecuteWithSignature("acquire", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#acquire(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Acquire(int arg0)
        {
            IExecuteWithSignature("acquire", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#acquireUninterruptibly()"/>
        /// </summary>
        public void AcquireUninterruptibly()
        {
            IExecuteWithSignature("acquireUninterruptibly", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#acquireUninterruptibly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcquireUninterruptibly(int arg0)
        {
            IExecuteWithSignature("acquireUninterruptibly", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecuteWithSignature("release", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#release(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Release(int arg0)
        {
            IExecuteWithSignature("release", "(I)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}