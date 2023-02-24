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
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Semaphore"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Semaphore t) => t.Cast<Java.Io.Serializable>();
        
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
            get { return IExecute<int>("getQueueLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#isFair()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsFair()
        {
            return IExecute<bool>("isFair");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#tryAcquire()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool TryAcquire()
        {
            return IExecute<bool>("tryAcquire");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#tryAcquire(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool TryAcquire(int arg0)
        {
            return IExecute<bool>("tryAcquire", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#hasQueuedThreads()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasQueuedThreads()
        {
            return IExecute<bool>("hasQueuedThreads");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#availablePermits()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int AvailablePermits()
        {
            return IExecute<int>("availablePermits");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#drainPermits()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int DrainPermits()
        {
            return IExecute<int>("drainPermits");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#acquire()"/>
        /// </summary>
        
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Acquire()
        {
            IExecute("acquire");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#acquire(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public void Acquire(int arg0)
        {
            IExecute("acquire", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#acquireUninterruptibly()"/>
        /// </summary>
        public void AcquireUninterruptibly()
        {
            IExecute("acquireUninterruptibly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#acquireUninterruptibly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void AcquireUninterruptibly(int arg0)
        {
            IExecute("acquireUninterruptibly", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#release()"/>
        /// </summary>
        public void Release()
        {
            IExecute("release");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/Semaphore.html#release(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Release(int arg0)
        {
            IExecute("release", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}