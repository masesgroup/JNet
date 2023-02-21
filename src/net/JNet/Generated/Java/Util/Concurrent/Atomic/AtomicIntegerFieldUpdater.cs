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

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicIntegerFieldUpdater
    public partial class AtomicIntegerFieldUpdater
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#compareAndSet(T,int,int)
        /// </summary>
        public bool CompareAndSet(object arg0, int arg1, int arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#weakCompareAndSet(T,int,int)
        /// </summary>
        public bool WeakCompareAndSet(object arg0, int arg1, int arg2)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#get(T)
        /// </summary>
        public int Get(object arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#lazySet(T,int)
        /// </summary>
        public void LazySet(object arg0, int arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#set(T,int)
        /// </summary>
        public void Set(object arg0, int arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#accumulateAndGet(T,int,java.util.function.IntBinaryOperator)
        /// </summary>
        public int AccumulateAndGet(object arg0, int arg1, Java.Util.Function.IntBinaryOperator arg2)
        {
            return IExecute<int>("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndAccumulate(T,int,java.util.function.IntBinaryOperator)
        /// </summary>
        public int GetAndAccumulate(object arg0, int arg1, Java.Util.Function.IntBinaryOperator arg2)
        {
            return IExecute<int>("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndUpdate(T,java.util.function.IntUnaryOperator)
        /// </summary>
        public int GetAndUpdate(object arg0, Java.Util.Function.IntUnaryOperator arg1)
        {
            return IExecute<int>("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#updateAndGet(T,java.util.function.IntUnaryOperator)
        /// </summary>
        public int UpdateAndGet(object arg0, Java.Util.Function.IntUnaryOperator arg1)
        {
            return IExecute<int>("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#addAndGet(T,int)
        /// </summary>
        public int AddAndGet(object arg0, int arg1)
        {
            return IExecute<int>("addAndGet", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#decrementAndGet(T)
        /// </summary>
        public int DecrementAndGet(object arg0)
        {
            return IExecute<int>("decrementAndGet", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndAdd(T,int)
        /// </summary>
        public int GetAndAdd(object arg0, int arg1)
        {
            return IExecute<int>("getAndAdd", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndDecrement(T)
        /// </summary>
        public int GetAndDecrement(object arg0)
        {
            return IExecute<int>("getAndDecrement", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndIncrement(T)
        /// </summary>
        public int GetAndIncrement(object arg0)
        {
            return IExecute<int>("getAndIncrement", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#getAndSet(T,int)
        /// </summary>
        public int GetAndSet(object arg0, int arg1)
        {
            return IExecute<int>("getAndSet", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicIntegerFieldUpdater.html#incrementAndGet(T)
        /// </summary>
        public int IncrementAndGet(object arg0)
        {
            return IExecute<int>("incrementAndGet", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}