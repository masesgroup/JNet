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

using Java.Util;
using System.Collections.Generic;

namespace MASES.JNet.Extensions
{
    public static class JavaUtilExtensions
    {
        #region List Extensions

        public static ICollection<T> ToCollection<T>(this Collection<T> set)
        {
            System.Collections.Generic.List<T> list = new ();
            if (set.IsEmpty) return list;
            foreach (var item in set)
            {
                list.Add(item);
            }
            return list;
        }

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

        public static Collection<T> ToJCollection<T>(this ICollection<T> collection)
        {
            ArrayList<T> list = new();
            if (collection.Count == 0) return list;
            foreach (var item in collection)
            {
                list.Add(item);
            }
            return list;
        }

        public static Java.Util.List<T> ToJList<T>(this ICollection<T> collection)
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

        public static Map<K, V> ToMap<K,V>(this IDictionary<K, V> dictionary)
        {
            HashMap<K, V> map = new();
            if (dictionary.Count == 0) return map;
            foreach (var item in dictionary)
            {
                map.Put(item.Key, item.Value);
            }
            return map;
        }

        #endregion
    }
}
