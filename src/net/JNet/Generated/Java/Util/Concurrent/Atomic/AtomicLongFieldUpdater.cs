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
    #region AtomicLongFieldUpdater
    public partial class AtomicLongFieldUpdater
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#newUpdater(java.lang.Class%3CU%3E,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater"/></returns>
        public static Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater NewUpdater(Java.Lang.Class arg0, string arg1)
        {
            return SExecute<Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater>("newUpdater", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#compareAndSet(T,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool CompareAndSet(object arg0, long arg1, long arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#weakCompareAndSet(T,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool WeakCompareAndSet(object arg0, long arg1, long arg2)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#get(T)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="long"/></returns>
        public long Get(object arg0)
        {
            return IExecute<long>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#lazySet(T,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void LazySet(object arg0, long arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#set(T,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Set(object arg0, long arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#accumulateAndGet(T,long,java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see langword="long"/></returns>
        public long AccumulateAndGet(object arg0, long arg1, Java.Util.Function.LongBinaryOperator arg2)
        {
            return IExecute<long>("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndAccumulate(T,long,java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetAndAccumulate(object arg0, long arg1, Java.Util.Function.LongBinaryOperator arg2)
        {
            return IExecute<long>("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndUpdate(T,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetAndUpdate(object arg0, Java.Util.Function.LongUnaryOperator arg1)
        {
            return IExecute<long>("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#updateAndGet(T,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see langword="long"/></returns>
        public long UpdateAndGet(object arg0, Java.Util.Function.LongUnaryOperator arg1)
        {
            return IExecute<long>("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#addAndGet(T,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see langword="long"/></returns>
        public long AddAndGet(object arg0, long arg1)
        {
            return IExecute<long>("addAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#decrementAndGet(T)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="long"/></returns>
        public long DecrementAndGet(object arg0)
        {
            return IExecute<long>("decrementAndGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndAdd(T,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetAndAdd(object arg0, long arg1)
        {
            return IExecute<long>("getAndAdd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndDecrement(T)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetAndDecrement(object arg0)
        {
            return IExecute<long>("getAndDecrement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndIncrement(T)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetAndIncrement(object arg0)
        {
            return IExecute<long>("getAndIncrement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndSet(T,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see langword="long"/></returns>
        public long GetAndSet(object arg0, long arg1)
        {
            return IExecute<long>("getAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#incrementAndGet(T)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="long"/></returns>
        public long IncrementAndGet(object arg0)
        {
            return IExecute<long>("incrementAndGet", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}