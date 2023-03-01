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

using Java.Util.Function;
using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    public partial class Map
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/javase/8/docs/api/java/util/Map.Entry.html"/>
        /// </summary>
        public class Entry<K, V> : JVMBridgeBase<Entry<K, V>>
        {
            /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
            public override string ClassName => "java.util.Map$Entry";
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#comparingByKey()"/>
            /// </summary>
            public static Comparator<Map.Entry<K, V>> ComparingByKey() => SExecute<Comparator<Map.Entry<K, V>>>("comparingByKey");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#comparingByKey(java.util.Comparator)"/>
            /// </summary>
            public static Comparator<Map.Entry<K, V>> ComparingByKey<SuperK>(Comparator<SuperK> cmp) where SuperK : K => SExecute<Comparator<Map.Entry<K, V>>>("comparingByKey", cmp);
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#comparingByValue()"/>
            /// </summary>
            public static Comparator<Map.Entry<K, V>> ComparingByValue() => SExecute<Comparator<Map.Entry<K, V>>>("comparingByValue");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#comparingByValue(java.util.Comparator)"/>
            /// </summary>
            public static Comparator<Map.Entry<K, V>> ComparingByValue<SuperV>(Comparator<SuperV> cmp) where SuperV : V => SExecute<Comparator<Map.Entry<K, V>>>("comparingByValue", cmp);
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#getKey()"/>
            /// </summary>
            public K Key => IExecute<K>("getKey");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.Entry.html#getValue()"/>
            /// </summary>
            public V Value { get { return IExecute<V>("getValue"); } set { IExecute("setValue", value); } }
        }
    }
    /// <summary>
    /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html"/>
    /// </summary>
    public class Map<K, V> : Map
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Map()
        {
        }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        protected Map(params object[] args)
            : base(args)
        {
        }
        /// <summary>
        /// Converter from <see cref="Map{K, V}"/> to <see cref="Lang.Iterable{T}"/>
        /// </summary>
        public static implicit operator Lang.Iterable<Entry<K, V>>(Map<K, V> instance) => instance.EntrySet().Cast<Lang.Iterable<Entry<K, V>>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#entrySet()"/>
        /// </summary>
        public Set<Entry<K, V>> EntrySet2 => EntrySet().Cast<Set<Entry<K, V>>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#forEach(java.util.function.BiConsumer)"/>
        /// </summary>
        public void ForEach<SuperK, SuperV>(BiConsumer<SuperK, SuperV> action)
            where SuperK : K
            where SuperV : V
        {
            IExecute("forEach", action);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#getOrDefault(java.lang.Object,V)"/>
        /// </summary>
        public V GetOrDefault(object key, V defaultValue) => IExecute<V>("getOrDefault", key, defaultValue);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#get(java.lang.Object)"/>
        /// </summary>
        public virtual V Get​(K key) { return IExecute<V>("get", key); }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#keySet()"/>
        /// </summary>
        public Set<K> KeySet2 => KeySet().Cast<Set<K>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#merge(K,V,java.util.function.BiFunction)"/>
        /// </summary>
        public V Merge<SuperV, ExtendsV>(K key, V value, BiFunction<SuperV, SuperV, ExtendsV> remappingFunction)
            where SuperV : V
            where ExtendsV : V
        {
            return IExecute<V>("merge", key, value, remappingFunction);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#put(K,V)"/>
        /// </summary>
        public virtual V Put​(K key, V value)
        {
            return IExecute<V>("put", key, value);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#putAll(java.util.Map)"/>
        /// </summary>
        public void PutAll<ExtendsK, ExtendsV>(Map<ExtendsK, ExtendsV> m)
            where ExtendsK : K
            where ExtendsV : V
        {
            IExecute("putAll", m);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#putIfAbsent(K,V)"/>
        /// </summary>
        public V PutIfAbsent(K key, V value)
        {
            return IExecute<V>("putIfAbsent", key, value);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#remove(java.lang.Object)"/>
        /// </summary>
        public new V Remove(object key)
        {
            return IExecute<V>("remove", key);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#replace(K,V)"/>
        /// </summary>
        public virtual V Replace(K key, V value)
        {
            return IExecute<V>("replace", key, value);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#replace(K,V,V)"/>
        /// </summary>
        public virtual V Replace(K key, V oldValue, V newValue)
        {
            return IExecute<V>("replace", key, oldValue, newValue);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#replaceAll(java.util.function.BiFunction)"/>
        /// </summary>
        public void ReplaceAll<SuperK, SuperV, ExtendsV>(BiFunction<SuperK, SuperV, ExtendsV> function)
            where SuperK : K
            where SuperV : V
            where ExtendsV : V
        {
            IExecute("replaceAll", function);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Map.html#values()"/>
        /// </summary>
        public Collection<V> Values2 => Values().Cast<Collection<V>>();
    }
}