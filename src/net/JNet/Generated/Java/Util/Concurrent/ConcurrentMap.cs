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

namespace Java.Util.Concurrent
{
    #region ConcurrentMap
    public partial class ConcurrentMap
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#remove(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0, object arg1)
        {
            return IExecute<bool>("remove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#replace(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Replace(object arg0, object arg1, object arg2)
        {
            return IExecute<bool>("replace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#putIfAbsent(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object PutIfAbsent(object arg0, object arg1)
        {
            return IExecute("putIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#replace(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Replace(object arg0, object arg1)
        {
            return IExecute("replace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#compute(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object Compute(object arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecute("compute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#computeIfAbsent(java.lang.Object,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="object"/></returns>
        public object ComputeIfAbsent(object arg0, Java.Util.Function.Function arg1)
        {
            return IExecute("computeIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#computeIfPresent(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object ComputeIfPresent(object arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecute("computeIfPresent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#getOrDefault(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetOrDefault(object arg0, object arg1)
        {
            return IExecute("getOrDefault", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#merge(java.lang.Object,java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object Merge(object arg0, object arg1, Java.Util.Function.BiFunction arg2)
        {
            return IExecute("merge", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#forEach(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        public void ForEach(Java.Util.Function.BiConsumer arg0)
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#replaceAll(java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        public void ReplaceAll(Java.Util.Function.BiFunction arg0)
        {
            IExecute("replaceAll", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ConcurrentMap<K, V>
    public partial class ConcurrentMap<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.ConcurrentMap{K, V}"/> to <see cref="Java.Util.Concurrent.ConcurrentMap"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.ConcurrentMap(Java.Util.Concurrent.ConcurrentMap<K, V> t) => t.Cast<Java.Util.Concurrent.ConcurrentMap>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#remove(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0, object arg1)
        {
            return IExecute<bool>("remove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#replace(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <param name="arg2"><see cref="V"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Replace(K arg0, V arg1, V arg2)
        {
            return IExecute<bool>("replace", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#putIfAbsent(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <returns><see cref="V"/></returns>
        public V PutIfAbsent(K arg0, V arg1)
        {
            return IExecute<V>("putIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#replace(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <returns><see cref="V"/></returns>
        public V Replace(K arg0, V arg1)
        {
            return IExecute<V>("replace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#compute(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="V"/></returns>
        public V Compute<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV>(K arg0, Java.Util.Function.BiFunction<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV> arg1) where Arg1objectSuperK: K
        {
            return IExecute<V>("compute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#computeIfAbsent(java.lang.Object,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="V"/></returns>
        public V ComputeIfAbsent<Arg1objectSuperK, Arg1ExtendsV>(K arg0, Java.Util.Function.Function<Arg1objectSuperK, Arg1ExtendsV> arg1) where Arg1objectSuperK: K
        {
            return IExecute<V>("computeIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#computeIfPresent(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="V"/></returns>
        public V ComputeIfPresent<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV>(K arg0, Java.Util.Function.BiFunction<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV> arg1) where Arg1objectSuperK: K
        {
            return IExecute<V>("computeIfPresent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#getOrDefault(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <returns><see cref="V"/></returns>
        public V GetOrDefault(object arg0, V arg1)
        {
            return IExecute<V>("getOrDefault", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#merge(java.lang.Object,java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="V"/></returns>
        public V Merge<Arg2objectSuperV, Arg2ExtendsV>(K arg0, V arg1, Java.Util.Function.BiFunction<Arg2objectSuperV, Arg2objectSuperV, Arg2ExtendsV> arg2) where Arg2objectSuperV: V where Arg2ExtendsV: V
        {
            return IExecute<V>("merge", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#forEach(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        public void ForEach<Arg0objectSuperK, Arg0objectSuperV>(Java.Util.Function.BiConsumer<Arg0objectSuperK, Arg0objectSuperV> arg0) where Arg0objectSuperK: K
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/ConcurrentMap.html#replaceAll(java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiFunction"/></param>
        public void ReplaceAll<Arg0objectSuperK, Arg0objectSuperV, Arg0ExtendsV>(Java.Util.Function.BiFunction<Arg0objectSuperK, Arg0objectSuperV, Arg0ExtendsV> arg0) where Arg0objectSuperK: K
        {
            IExecute("replaceAll", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}