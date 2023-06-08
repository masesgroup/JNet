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

using Java.Util;
using System.Collections.Generic;

namespace MASES.JNet.Extensions
{
    /// <summary>
    /// Extension for Java.Util classes
    /// </summary>
    public static class JavaUtilExtensions
    {
        #region List Extensions
        /// <summary>
        /// Converts a <see cref="Collection{T}"/> to <see cref="ICollection{T}"/>
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="set">The <see cref="Collection{T}"/></param>
        /// <returns>The <see cref="ICollection{T}"/></returns>
        public static System.Collections.Generic.ICollection<T> ToCollection<T>(this Collection<T> set)
        {
            System.Collections.Generic.List<T> list = new();
            if (set.IsEmpty) return list;
            foreach (var item in set)
            {
                list.Add(item);
            }
            return list;
        }
        /// <summary>
        /// Converts a <see cref="Collection{T}"/> to <see cref="System.Collections.Generic.List{T}"/>
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="set">The <see cref="Collection{T}"/></param>
        /// <returns>The <see cref="System.Collections.Generic.List{T}"/></returns>
        public static System.Collections.Generic.List<T> ToList<T>(this Collection<T> set)
        {
            System.Collections.Generic.List<T> list = new();
            if (set.IsEmpty) return list;
            foreach (var item in set)
            {
                list.Add(item);
            }
            return list;
        }
        /// <summary>
        /// Converts a <see cref="ICollection{T}"/> to <see cref="Collection{T}"/>
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="collection">The <see cref="ICollection{T}"/></param>
        /// <returns>The <see cref="Collection{T}"/></returns>
        public static Collection<T> ToJCollection<T>(this System.Collections.Generic.ICollection<T> collection)
        {
            ArrayList<T> list = new();
            if (collection.Count == 0) return list.CastTo<Collection<T>>();
            foreach (var item in collection)
            {
                list.Add(item);
            }
            return list.CastTo<Collection<T>>();
        }
        /// <summary>
        /// Converts a <see cref="ICollection{T}"/> to <see cref="Java.Util.List{T}"/>
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <param name="collection">The <see cref="ICollection{T}"/></param>
        /// <returns>The <see cref="Java.Util.List{T}"/></returns>
        public static Java.Util.List<T> ToJList<T>(this System.Collections.Generic.ICollection<T> collection)
        {
            ArrayList<T> list = new();
            if (collection.Count == 0) return list;
            foreach (var item in collection)
            {
                list.Add(item);
            }
            return list;
        }

        #endregion

        #region Map/Dictionary Extensions
        /// <summary>
        /// Converts a <see cref="Map{K, V}"/> to <see cref="System.Collections.Generic.Dictionary{K, V}"/>
        /// </summary>
        /// <typeparam name="K">Key</typeparam>
        /// <typeparam name="V">Value</typeparam>
        /// <param name="map">The <see cref="Map{K, V}"/></param>
        /// <returns>The <see cref="System.Collections.Generic.Dictionary{K, V}"/></returns>
        public static System.Collections.Generic.Dictionary<K, V> ToDictiony<K, V>(this Map<K, V> map)
        {
            System.Collections.Generic.Dictionary<K, V> dictionary = new();
            if (map.IsEmpty) return dictionary;
            foreach (var item in map.EntrySet)
            {
                dictionary.Add(item.Key, item.Value);
            }
            return dictionary;
        }
        /// <summary>
        /// Converts a <see cref="IDictionary{K, V}"/> to <see cref="Map{K, V}"/>
        /// </summary>
        /// <typeparam name="K">Key</typeparam>
        /// <typeparam name="V">Value</typeparam>
        /// <param name="dictionary">The <see cref="IDictionary{K, V}"/></param>
        /// <returns>The <see cref="Map{K, V}"/></returns>
        public static Map<K, V> ToMap<K, V>(this IDictionary<K, V> dictionary)
        {
            HashMap<K, V> map = new();
            if (dictionary.Count == 0) return map;
            foreach (var item in dictionary)
            {
                map.Put(item.Key, item.Value);
            }
            return map;
        }
        /// <summary>
        /// Converts a <see cref="IDictionary{K, V}"/> to <see cref="Hashtable{K, V}"/>
        /// </summary>
        /// <typeparam name="K">Key</typeparam>
        /// <typeparam name="V">Value</typeparam>
        /// <param name="dictionary">The <see cref="IDictionary{K, V}"/></param>
        /// <returns>The <see cref="Hashtable{K, V}"/></returns>
        public static Hashtable<K, V> ToHashtable<K, V>(this IDictionary<K, V> dictionary)
        {
            Hashtable<K, V> hTable = new();
            if (dictionary.Count == 0) return hTable;
            foreach (var item in dictionary)
            {
                hTable.Put(item.Key, item.Value);
            }
            return hTable;
        }

        #endregion
    }
}
