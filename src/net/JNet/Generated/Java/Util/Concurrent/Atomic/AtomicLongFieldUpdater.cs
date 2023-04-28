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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#newUpdater(java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater"/></returns>
        public static Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater NewUpdater(Java.Lang.Class arg0, string arg1)
        {
            return SExecute<Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater>(LocalClazz, "newUpdater", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#compareAndSet(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(object arg0, long arg1, long arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#weakCompareAndSet(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(object arg0, long arg1, long arg2)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        public long Get(object arg0)
        {
            return IExecute<long>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#lazySet(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void LazySet(object arg0, long arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#set(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Set(object arg0, long arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#accumulateAndGet(java.lang.Object,long,java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long AccumulateAndGet(object arg0, long arg1, Java.Util.Function.LongBinaryOperator arg2)
        {
            return IExecute<long>("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndAccumulate(java.lang.Object,long,java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndAccumulate(object arg0, long arg1, Java.Util.Function.LongBinaryOperator arg2)
        {
            return IExecute<long>("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndUpdate(java.lang.Object,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndUpdate(object arg0, Java.Util.Function.LongUnaryOperator arg1)
        {
            return IExecute<long>("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#updateAndGet(java.lang.Object,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long UpdateAndGet(object arg0, Java.Util.Function.LongUnaryOperator arg1)
        {
            return IExecute<long>("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#addAndGet(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long AddAndGet(object arg0, long arg1)
        {
            return IExecute<long>("addAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#decrementAndGet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        public long DecrementAndGet(object arg0)
        {
            return IExecute<long>("decrementAndGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndAdd(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndAdd(object arg0, long arg1)
        {
            return IExecute<long>("getAndAdd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndDecrement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndDecrement(object arg0)
        {
            return IExecute<long>("getAndDecrement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndIncrement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndIncrement(object arg0)
        {
            return IExecute<long>("getAndIncrement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndSet(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndSet(object arg0, long arg1)
        {
            return IExecute<long>("getAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#incrementAndGet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="long"/></returns>
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

    #region AtomicLongFieldUpdater<T>
    public partial class AtomicLongFieldUpdater<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater{T}"/> to <see cref="Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater(Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater<T> t) => t.Cast<Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#newUpdater(java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater"/></returns>
        public static Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater<U> NewUpdater<U>(Java.Lang.Class arg0, string arg1)
        {
            return SExecute<Java.Util.Concurrent.Atomic.AtomicLongFieldUpdater<U>>(LocalClazz, "newUpdater", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#compareAndSet(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(T arg0, long arg1, long arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#weakCompareAndSet(java.lang.Object,long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(T arg0, long arg1, long arg2)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <returns><see cref="long"/></returns>
        public long Get(T arg0)
        {
            return IExecute<long>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#lazySet(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void LazySet(T arg0, long arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#set(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        public void Set(T arg0, long arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#accumulateAndGet(java.lang.Object,long,java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long AccumulateAndGet(T arg0, long arg1, Java.Util.Function.LongBinaryOperator arg2)
        {
            return IExecute<long>("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndAccumulate(java.lang.Object,long,java.util.function.LongBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.LongBinaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndAccumulate(T arg0, long arg1, Java.Util.Function.LongBinaryOperator arg2)
        {
            return IExecute<long>("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndUpdate(java.lang.Object,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndUpdate(T arg0, Java.Util.Function.LongUnaryOperator arg1)
        {
            return IExecute<long>("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#updateAndGet(java.lang.Object,java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="long"/></returns>
        public long UpdateAndGet(T arg0, Java.Util.Function.LongUnaryOperator arg1)
        {
            return IExecute<long>("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#addAndGet(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long AddAndGet(T arg0, long arg1)
        {
            return IExecute<long>("addAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#decrementAndGet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <returns><see cref="long"/></returns>
        public long DecrementAndGet(T arg0)
        {
            return IExecute<long>("decrementAndGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndAdd(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndAdd(T arg0, long arg1)
        {
            return IExecute<long>("getAndAdd", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndDecrement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndDecrement(T arg0)
        {
            return IExecute<long>("getAndDecrement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndIncrement(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndIncrement(T arg0)
        {
            return IExecute<long>("getAndIncrement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#getAndSet(java.lang.Object,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetAndSet(T arg0, long arg1)
        {
            return IExecute<long>("getAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicLongFieldUpdater.html#incrementAndGet(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="T"/></param>
        /// <returns><see cref="long"/></returns>
        public long IncrementAndGet(T arg0)
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