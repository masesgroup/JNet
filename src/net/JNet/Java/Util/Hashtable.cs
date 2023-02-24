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

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html"/>
    /// </summary>
    public class Hashtable<K, V> : Dictionary<K, V>
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        public override bool IsAbstract => false;
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "java.util.Hashtable";
        /// <summary>
        /// Converter from <see cref="Hashtable{K, V}"/> to <see cref="Map{K, V}"/>
        /// </summary>
        public static implicit operator Map<K, V>(Hashtable<K, V> table) { return Wraps<Map<K, V>>(table.Instance); }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#get(java.lang.Object)"/>
        /// </summary>
        public V Get(object key) => IExecute<V>("get", key);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Hashtable.html#put(K,V)"/>
        /// </summary>
        public void Put(K key, V value) => IExecute("put", key, value);
    }
}