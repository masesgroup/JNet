/*
*  Copyright 2025 MASES s.r.l.
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
        /// <inheritdoc cref="SingletonListMethod"/>
        public static List<E> SingletonList<E>(E element) => SingletonListMethod<E>(element);
        /// <inheritdoc cref="SingletonMapMethod"/>
        public static Map<K, V> SingletonMap<K, V>(K key, V value) => SingletonMapMethod<K, V>(key, value);
        /// <inheritdoc cref="EmptyIteratorMethod"/>
        public static Iterator<T> EmptyIterator<T>() => EmptyIteratorMethod<T>();
        /// <inheritdoc cref="EmptyListMethod"/>
        public static List<T> EmptyList<T>() => EmptyListMethod<T>();
        /// <inheritdoc cref="EmptyListIteratorMethod"/>
        public static ListIterator<T> EmptyListIterator<T>() => EmptyListIteratorMethod<T>();
        /// <inheritdoc cref="EmptyMapMethod"/>
        public static Map<K, V> EmptyMap<K, V>() => EmptyMapMethod<K, V>();
        /// <inheritdoc cref="EmptySetMethod"/>
        public static Set<T> EmptySet<T>() => EmptySetMethod<T>();
    }
}
