/*
*  Copyright 2022 MASES s.r.l.
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
using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace Java.Util
{
    public class Map : JVMBridgeBase<Map>
    {
        public override string ClassName => "java.util.Map";

        public Map()
        {
        }

        public Map(params object[] args)
            : base(args)
        {
        }

        public void Clear() => IExecute("clear");

        public bool ContainsKey(object key) => IExecute<bool>("containsKey", key);

        public bool ContainsValue(object value) => IExecute<bool>("containsValue", value);

        public bool Remove(object key, object value) => IExecute<bool>("remove", key, value);
    }

    public class Map<K, V> : Map
    {
        public Map()
        {
        }

        public Map(params object[] args)
            : base(args)
        {
        }

        public void ForEach<SuperK, SuperV>(BiConsumer<SuperK, SuperV> action)
            where SuperK : K
            where SuperV : V
        {
            IExecute("forEach", action);
        }

        public V GetOrDefault(object key, V defaultValue) => IExecute<V>("getOrDefault", key, defaultValue);

        public virtual V Get​(K key) { return IExecute<V>("get", key); }

        public bool IsEmpty => IExecute<bool>("isEmpty");

        public Set<K> KeySet => IExecute<Set<K>>("keySet");

        public V Merge<SuperV, ExtendsV>(K key, V value, BiFunction<SuperV, SuperV, ExtendsV> remappingFunction)
            where SuperV : V
            where ExtendsV : V
        {
            return IExecute<V>("merge", key, value, remappingFunction);
        }

        public virtual V Put​(K key, V value)
        {
            return IExecute<V>("put", key, value);
        }

        public void PutAll<ExtendsK, ExtendsV>(Map<ExtendsK, ExtendsV> m)
            where ExtendsK : K
            where ExtendsV : V
        {
            IExecute("putAll", m);
        }

        public V PutIfAbsent(K key, V value)
        {
            return IExecute<V>("putIfAbsent", key, value);
        }

        public V Remove(object key)
        {
            return IExecute<V>("remove", key);
        }

        public virtual V Replace(K key, V value)
        {
            return IExecute<V>("replace", key, value);
        }

        public virtual V Replace(K key, V oldValue, V newValue)
        {
            return IExecute<V>("replace", key, oldValue, newValue);
        }

        public void ReplaceAll<SuperK, SuperV, ExtendsV>(BiFunction<SuperK, SuperV, ExtendsV> function)
            where SuperK : K
            where SuperV : V
            where ExtendsV : V
        {
            IExecute("replaceAll", function);
        }

        public int Size => IExecute<int>("size");

        public Collection<V> Values => IExecute<Collection<V>>("values");
    }
}