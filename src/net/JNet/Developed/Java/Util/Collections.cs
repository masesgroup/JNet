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

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    public partial class Collections
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collections.html#singletonList(T)"/>
        /// </summary>
        public static List<E> SingletonList<E>(E element)
        {
            return SExecute<List<E>>("singleton", element);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collections.html#singletonMap(K,V)"/>
        /// </summary>
        public static Map<K, V> SingletonMap<K, V>(K key, V value)
        {
            return SExecute<Map<K, V>>("singletonMap", key, value);
        }
        /// <summary>
        /// Returns an iterator that has no elements.
        /// </summary>
        public static Iterator<T> EmptyIterator<T>() => SExecute<Iterator<T>>("emptyIterator");
        /// <summary>
        /// Returns an empty list(immutable).
        /// </summary>
        public static List<T> EmptyList<T>() => SExecute<List<T>>("emptyList");
        /// <summary>
        ///  Returns a list iterator that has no elements.
        /// </summary>
        public static ListIterator<T> EmptyListIterator<T>() => SExecute<ListIterator<T>>("emptyListIterator");
        /// <summary>
        /// Returns an empty map(immutable).
        /// </summary>
        public static Map<K, V> EmptyMap<K, V>() => SExecute<Map<K, V>>("emptyMap");
        /// <summary>
        /// Returns an empty set(immutable).
        /// </summary>
        public static Set<T> EmptySet<T>() => SExecute<Set<T>>("emptySet");
    }
}
