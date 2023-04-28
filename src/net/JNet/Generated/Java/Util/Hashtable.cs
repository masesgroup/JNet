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

namespace Java.Util
{
    #region Hashtable
    public partial class Hashtable
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#%3Cinit%3E(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public Hashtable(int arg0, float arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Hashtable(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public Hashtable(Java.Util.Map arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable"/> to <see cref="Java.Util.Map"/>
        /// </summary>
        public static implicit operator Java.Util.Map(Java.Util.Hashtable t) => t.Cast<Java.Util.Map>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Hashtable t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Hashtable t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#values()"/> 
        /// </summary>
        public Java.Util.Collection Values
        {
            get { return IExecute<Java.Util.Collection>("values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#entrySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set EntrySetMethod()
        {
            return IExecute<Java.Util.Set>("entrySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#keySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set KeySetMethod()
        {
            return IExecute<Java.Util.Set>("keySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#remove(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0, object arg1)
        {
            return IExecute<bool>("remove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#replace(java.lang.Object,java.lang.Object,java.lang.Object)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#compute(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object Compute(object arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecute("compute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#computeIfAbsent(java.lang.Object,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="object"/></returns>
        public object ComputeIfAbsent(object arg0, Java.Util.Function.Function arg1)
        {
            return IExecute("computeIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#computeIfPresent(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object ComputeIfPresent(object arg0, Java.Util.Function.BiFunction arg1)
        {
            return IExecute("computeIfPresent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#getOrDefault(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetOrDefault(object arg0, object arg1)
        {
            return IExecute("getOrDefault", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#merge(java.lang.Object,java.lang.Object,java.util.function.BiFunction)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#putIfAbsent(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object PutIfAbsent(object arg0, object arg1)
        {
            return IExecute("putIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#replace(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Replace(object arg0, object arg1)
        {
            return IExecute("replace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#forEach(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        public void ForEach(Java.Util.Function.BiConsumer arg0)
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#putAll(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void PutAll(Java.Util.Map arg0)
        {
            IExecute("putAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#replaceAll(java.util.function.BiFunction)"/>
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

    #region Hashtable<K, V>
    public partial class Hashtable<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#%3Cinit%3E(int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        public Hashtable(int arg0, float arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Hashtable(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public Hashtable(Java.Util.Map arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable{K, V}"/> to <see cref="Java.Util.Map{K, V}"/>
        /// </summary>
        public static implicit operator Java.Util.Map<K, V>(Java.Util.Hashtable<K, V> t) => t.Cast<Java.Util.Map<K, V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable{K, V}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Hashtable<K, V> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable{K, V}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Hashtable<K, V> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Hashtable{K, V}"/> to <see cref="Java.Util.Hashtable"/>
        /// </summary>
        public static implicit operator Java.Util.Hashtable(Java.Util.Hashtable<K, V> t) => t.Cast<Java.Util.Hashtable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#values()"/> 
        /// </summary>
        public Java.Util.Collection<V> Values
        {
            get { return IExecute<Java.Util.Collection<V>>("values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#entrySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Util.Map.Entry<K, V>> EntrySetMethod()
        {
            return IExecute<Java.Util.Set<Java.Util.Map.Entry<K, V>>>("entrySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#keySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<K> KeySetMethod()
        {
            return IExecute<Java.Util.Set<K>>("keySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#remove(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0, object arg1)
        {
            return IExecute<bool>("remove", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#replace(java.lang.Object,java.lang.Object,java.lang.Object)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#compute(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="V"/></returns>
        public V Compute<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV>(K arg0, Java.Util.Function.BiFunction<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV> arg1) where Arg1objectSuperK: K
        {
            return IExecute<V>("compute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#computeIfAbsent(java.lang.Object,java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="V"/></returns>
        public V ComputeIfAbsent<Arg1objectSuperK, Arg1ExtendsV>(K arg0, Java.Util.Function.Function<Arg1objectSuperK, Arg1ExtendsV> arg1) where Arg1objectSuperK: K
        {
            return IExecute<V>("computeIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#computeIfPresent(java.lang.Object,java.util.function.BiFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiFunction"/></param>
        /// <returns><see cref="V"/></returns>
        public V ComputeIfPresent<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV>(K arg0, Java.Util.Function.BiFunction<Arg1objectSuperK, Arg1objectSuperV, Arg1ExtendsV> arg1) where Arg1objectSuperK: K
        {
            return IExecute<V>("computeIfPresent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#getOrDefault(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <returns><see cref="V"/></returns>
        public V GetOrDefault(object arg0, V arg1)
        {
            return IExecute<V>("getOrDefault", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#merge(java.lang.Object,java.lang.Object,java.util.function.BiFunction)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#putIfAbsent(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <returns><see cref="V"/></returns>
        public V PutIfAbsent(K arg0, V arg1)
        {
            return IExecute<V>("putIfAbsent", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#replace(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <returns><see cref="V"/></returns>
        public V Replace(K arg0, V arg1)
        {
            return IExecute<V>("replace", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#forEach(java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiConsumer"/></param>
        public void ForEach<Arg0objectSuperK, Arg0objectSuperV>(Java.Util.Function.BiConsumer<Arg0objectSuperK, Arg0objectSuperV> arg0) where Arg0objectSuperK: K
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#putAll(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void PutAll<Arg0ExtendsK, Arg0ExtendsV>(Java.Util.Map<Arg0ExtendsK, Arg0ExtendsV> arg0) where Arg0ExtendsK: K where Arg0ExtendsV: V
        {
            IExecute("putAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#replaceAll(java.util.function.BiFunction)"/>
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