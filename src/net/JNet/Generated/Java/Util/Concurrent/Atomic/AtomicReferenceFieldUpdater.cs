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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Concurrent.Atomic
{
    #region AtomicReferenceFieldUpdater
    public partial class AtomicReferenceFieldUpdater
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#newUpdater(java.lang.Class,java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater"/></returns>
        public static Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater NewUpdater(Java.Lang.Class arg0, Java.Lang.Class arg1, Java.Lang.String arg2)
        {
            return SExecute<Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater>(LocalBridgeClazz, "newUpdater", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#compareAndSet(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(object arg0, object arg1, object arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#weakCompareAndSet(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(object arg0, object arg1, object arg2)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecuteWithSignature("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#lazySet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void LazySet(object arg0, object arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#set(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void Set(object arg0, object arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#accumulateAndGet(java.lang.Object,java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object AccumulateAndGet(object arg0, object arg1, Java.Util.Function.BinaryOperator arg2)
        {
            return IExecute("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#getAndAccumulate(java.lang.Object,java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndAccumulate(object arg0, object arg1, Java.Util.Function.BinaryOperator arg2)
        {
            return IExecute("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#getAndUpdate(java.lang.Object,java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndUpdate(object arg0, Java.Util.Function.UnaryOperator arg1)
        {
            return IExecute("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#updateAndGet(java.lang.Object,java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see cref="object"/></returns>
        public object UpdateAndGet(object arg0, Java.Util.Function.UnaryOperator arg1)
        {
            return IExecute("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#getAndSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetAndSet(object arg0, object arg1)
        {
            return IExecute("getAndSet", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AtomicReferenceFieldUpdater<T, V>
    public partial class AtomicReferenceFieldUpdater<T, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater{T, V}"/> to <see cref="Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater(Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater<T, V> t) => t.Cast<Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#newUpdater(java.lang.Class,java.lang.Class,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="W"></typeparam>
        /// <returns><see cref="Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater"/></returns>
        public static Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater<U, W> NewUpdater<U, W>(Java.Lang.Class arg0, Java.Lang.Class arg1, Java.Lang.String arg2)
        {
            return SExecute<Java.Util.Concurrent.Atomic.AtomicReferenceFieldUpdater<U, W>>(LocalBridgeClazz, "newUpdater", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#compareAndSet(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><typeparamref name="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CompareAndSet(T arg0, V arg1, V arg2)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#weakCompareAndSet(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><typeparamref name="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool WeakCompareAndSet(T arg0, V arg1, V arg2)
        {
            return IExecute<bool>("weakCompareAndSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V Get(T arg0)
        {
            return IExecuteWithSignature<V>("get", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#lazySet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        public void LazySet(T arg0, V arg1)
        {
            IExecute("lazySet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#set(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        public void Set(T arg0, V arg1)
        {
            IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#accumulateAndGet(java.lang.Object,java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V AccumulateAndGet(T arg0, V arg1, Java.Util.Function.BinaryOperator<V> arg2)
        {
            return IExecute<V>("accumulateAndGet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#getAndAccumulate(java.lang.Object,java.lang.Object,java.util.function.BinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V GetAndAccumulate(T arg0, V arg1, Java.Util.Function.BinaryOperator<V> arg2)
        {
            return IExecute<V>("getAndAccumulate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#getAndUpdate(java.lang.Object,java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V GetAndUpdate(T arg0, Java.Util.Function.UnaryOperator<V> arg1)
        {
            return IExecute<V>("getAndUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#updateAndGet(java.lang.Object,java.util.function.UnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V UpdateAndGet(T arg0, Java.Util.Function.UnaryOperator<V> arg1)
        {
            return IExecute<V>("updateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReferenceFieldUpdater.html#getAndSet(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="V"/></param>
        /// <returns><typeparamref name="V"/></returns>
        public V GetAndSet(T arg0, V arg1)
        {
            return IExecute<V>("getAndSet", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}