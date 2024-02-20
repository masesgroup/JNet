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

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicInteger
    public partial class AtomicInteger
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public AtomicInteger(int arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getAcquire()"/> 
        /// </summary>
        public int Acquire
        {
            get { return IExecute<int>("getAcquire"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getAndDecrement()"/> 
        /// </summary>
        public int AndDecrement
        {
            get { return IExecute<int>("getAndDecrement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getAndIncrement()"/> 
        /// </summary>
        public int AndIncrement
        {
            get { return IExecute<int>("getAndIncrement"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getOpaque()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#setOpaque(int)"/>
        /// </summary>
        public int Opaque
        {
            get { return IExecute<int>("getOpaque"); } set { IExecute("setOpaque", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getPlain()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#setPlain(int)"/>
        /// </summary>
        public int Plain
        {
            get { return IExecute<int>("getPlain"); } set { IExecute("setPlain", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#compareAndSet(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(int arg0, int arg1)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#weakCompareAndSetAcquire(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetAcquire(int arg0, int arg1)
        {
            return IExecute<bool>("weakCompareAndSetAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#weakCompareAndSetPlain(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetPlain(int arg0, int arg1)
        {
            return IExecute<bool>("weakCompareAndSetPlain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#weakCompareAndSetRelease(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetRelease(int arg0, int arg1)
        {
            return IExecute<bool>("weakCompareAndSetRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#weakCompareAndSetVolatile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSetVolatile(int arg0, int arg1)
        {
            return IExecute<bool>("weakCompareAndSetVolatile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#accumulateAndGet(int,java.util.function.IntBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntBinaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int AccumulateAndGet(int arg0, Java.Util.Function.IntBinaryOperator arg1)
        {
            return IExecute<int>("accumulateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#addAndGet(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int AddAndGet(int arg0)
        {
            return IExecute<int>("addAndGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#compareAndExchange(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareAndExchange(int arg0, int arg1)
        {
            return IExecute<int>("compareAndExchange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#compareAndExchangeAcquire(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareAndExchangeAcquire(int arg0, int arg1)
        {
            return IExecute<int>("compareAndExchangeAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#compareAndExchangeRelease(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareAndExchangeRelease(int arg0, int arg1)
        {
            return IExecute<int>("compareAndExchangeRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#decrementAndGet()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int DecrementAndGet()
        {
            return IExecute<int>("decrementAndGet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#get()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Get()
        {
            return IExecute<int>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getAndAccumulate(int,java.util.function.IntBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.IntBinaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndAccumulate(int arg0, Java.Util.Function.IntBinaryOperator arg1)
        {
            return IExecute<int>("getAndAccumulate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getAndAdd(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndAdd(int arg0)
        {
            return IExecute<int>("getAndAdd", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getAndSet(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndSet(int arg0)
        {
            return IExecute<int>("getAndSet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#getAndUpdate(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetAndUpdate(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecute<int>("getAndUpdate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#incrementAndGet()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int IncrementAndGet()
        {
            return IExecute<int>("incrementAndGet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#updateAndGet(java.util.function.IntUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntUnaryOperator"/></param>
        /// <returns><see cref="int"/></returns>
        public int UpdateAndGet(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecute<int>("updateAndGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#lazySet(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void LazySet(int arg0)
        {
            IExecute("lazySet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#set(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Set(int arg0)
        {
            IExecute("set", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicInteger.html#setRelease(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetRelease(int arg0)
        {
            IExecute("setRelease", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}