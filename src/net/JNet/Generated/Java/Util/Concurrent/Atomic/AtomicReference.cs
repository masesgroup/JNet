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
    #region AtomicReference
    public partial class AtomicReference
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#%3Cinit%3E(V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public AtomicReference(object arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.Atomic.AtomicReference"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.Atomic.AtomicReference t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAcquire()"/> 
        /// </summary>
        public object Acquire
        {
            get { return IExecute("getAcquire"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getOpaque()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setOpaque(V)"/>
        /// </summary>
        public object Opaque
        {
            get { return IExecute("getOpaque"); } set { IExecute("setOpaque", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getPlain()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setPlain(V)"/>
        /// </summary>
        public object Plain
        {
            get { return IExecute("getPlain"); } set { IExecute("setPlain", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndSet(V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool CompareAndSet(object arg0, object arg1)
        {
            return IExecute<bool>("compareAndSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetAcquire(V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool WeakCompareAndSetAcquire(object arg0, object arg1)
        {
            return IExecute<bool>("weakCompareAndSetAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetPlain(V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool WeakCompareAndSetPlain(object arg0, object arg1)
        {
            return IExecute<bool>("weakCompareAndSetPlain", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetRelease(V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool WeakCompareAndSetRelease(object arg0, object arg1)
        {
            return IExecute<bool>("weakCompareAndSetRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#weakCompareAndSetVolatile(V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool WeakCompareAndSetVolatile(object arg0, object arg1)
        {
            return IExecute<bool>("weakCompareAndSetVolatile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#accumulateAndGet(V,java.util.function.BinaryOperator%3CV%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><see langword="object"/></returns>
        public object AccumulateAndGet(object arg0, Java.Util.Function.BinaryOperator arg1)
        {
            return IExecute("accumulateAndGet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchange(V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object CompareAndExchange(object arg0, object arg1)
        {
            return IExecute("compareAndExchange", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchangeAcquire(V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object CompareAndExchangeAcquire(object arg0, object arg1)
        {
            return IExecute("compareAndExchangeAcquire", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#compareAndExchangeRelease(V,V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object CompareAndExchangeRelease(object arg0, object arg1)
        {
            return IExecute("compareAndExchangeRelease", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#get()"/>
        /// </summary>
        
        /// <returns><see langword="object"/></returns>
        public object Get()
        {
            return IExecute("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndAccumulate(V,java.util.function.BinaryOperator%3CV%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <returns><see langword="object"/></returns>
        public object GetAndAccumulate(object arg0, Java.Util.Function.BinaryOperator arg1)
        {
            return IExecute("getAndAccumulate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndSet(V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object GetAndSet(object arg0)
        {
            return IExecute("getAndSet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#getAndUpdate(java.util.function.UnaryOperator%3CV%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see langword="object"/></returns>
        public object GetAndUpdate(Java.Util.Function.UnaryOperator arg0)
        {
            return IExecute("getAndUpdate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#updateAndGet(java.util.function.UnaryOperator%3CV%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.UnaryOperator"/></param>
        /// <returns><see langword="object"/></returns>
        public object UpdateAndGet(Java.Util.Function.UnaryOperator arg0)
        {
            return IExecute("updateAndGet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#lazySet(V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void LazySet(object arg0)
        {
            IExecute("lazySet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#set(V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Set(object arg0)
        {
            IExecute("set", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/atomic/AtomicReference.html#setRelease(V)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetRelease(object arg0)
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