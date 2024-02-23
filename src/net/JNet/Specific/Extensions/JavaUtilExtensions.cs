/*
*  Copyright 2024 MASES s.r.l.
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
using System;
using System.Collections;
using System.Collections.Generic;

namespace MASES.JNet.Specific.Extensions
{
    /// <summary>
    /// Interface defining the .NET type corresponding to the JVM class implementing <see cref="INativeConvertible{TJVMType, TNetType}"/>
    /// </summary>
    /// <typeparam name="TJVMType">The JVM type</typeparam>
    /// <typeparam name="TNetType">The .NET type corresponding to <typeparamref name="TJVMType"/></typeparam>
    public interface INativeConvertible<TJVMType, TNetType>
    {
        /// <summary>
        /// Returns the <typeparamref name="TNetType"/> from this instance
        /// </summary>
        /// <returns>The converted <typeparamref name="TNetType"/></returns>
        TNetType ToCLR();
        /// <summary>
        /// Returns the <typeparamref name="TJVMType"/> from the <paramref name="clrValue"/> instance
        /// </summary>
        /// <param name="clrValue">The <typeparamref name="TNetType"/> of CLR</param>
        /// <returns>The converted <typeparamref name="TJVMType"/></returns>
        TJVMType ToJVM(TNetType clrValue);
    }

    /// <summary>
    /// Extension for Java.Util classes
    /// </summary>
    public static class JavaUtilExtensions
    {
        #region List Extensions
        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <typeparamref name="TJVMType"/> to an <typeparamref name="TEnumerableType"/> of <typeparamref name="TNetTypeInner"/>
        /// </summary>
        /// <typeparam name="TEnumerableType">A type implementing <see cref="System.Collections.Generic.IEnumerable{T}"/></typeparam>
        /// <typeparam name="TNetTypeInner">The expected .NET type</typeparam>
        /// <typeparam name="TJVMType">The original JVM type</typeparam>
        /// <param name="set">The <see cref="System.Collections.Generic.IEnumerable{T}"/> of <typeparamref name="TJVMType"/> to be converted</param>
        /// <param name="func">An <see cref="Func{T, TResult}"/> used to convert <typeparamref name="TJVMType"/> into <typeparamref name="TNetTypeInner"/></param>
        /// <returns>The converted <typeparamref name="TEnumerableType"/> of <typeparamref name="TNetTypeInner"/></returns>
        public static TEnumerableType ToNetCollectionType<TEnumerableType, TNetTypeInner, TJVMType>(this System.Collections.Generic.IEnumerable<TJVMType> set, Func<TJVMType, TNetTypeInner> func = null)
            where TEnumerableType : System.Collections.Generic.ICollection<TNetTypeInner>, new()
            where TJVMType : INativeConvertible<TJVMType, TNetTypeInner>
        {
            var tInstance = new TEnumerableType();
            foreach (var item in set)
            {
                tInstance.Add(func != null ? func(item) : item.ToCLR());
            }
            return tInstance;
        }

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to an array of <see cref="string"/>
        /// </summary>
        /// <param name="set">The <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="Java.Lang.String"/> to be converted</param>
        /// <returns>The converted array of <see cref="string"/></returns>
        public static TNetType[] ToNetArray<TNetType, TJVMType>(this System.Collections.Generic.IEnumerable<TJVMType> set)
            where TJVMType : INativeConvertible<TJVMType, TNetType>
        {
            var tmpEnum = ToNetCollectionType<System.Collections.Generic.List<TNetType>, TNetType, TJVMType>(set);
            return tmpEnum.ToArray();
        }

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <typeparamref name="TNetType"/> to an <typeparamref name="TIterableType"/> of <typeparamref name="TJVMTypeInner"/>
        /// </summary>
        /// <typeparam name="TIterableType">A type implementing <see cref="Java.Lang.Iterable{T}"/></typeparam>
        /// <typeparam name="TJVMTypeInner">The expected JVM type</typeparam>
        /// <typeparam name="TNetType">The original .NET type</typeparam>
        /// <param name="set">The <see cref="Java.Util.Collection{T}"/> of <typeparamref name="TJVMTypeInner"/> to be converted</param>
        /// <param name="func">An optional <see cref="Func{T, TResult}"/> used to return <typeparamref name="TJVMTypeInner"/> from data of <typeparamref name="TNetType"/> in <paramref name="set"/></param>
        /// <returns>The converted <typeparamref name="TIterableType"/> of <typeparamref name="TJVMTypeInner"/></returns>
        public static TIterableType ToJVMCollectionType<TIterableType, TJVMTypeInner, TNetType>(this System.Collections.Generic.IEnumerable<TNetType> set, Func<TNetType, TJVMTypeInner> func = null)
            where TIterableType : Java.Util.Collection<TJVMTypeInner>, new()
            where TJVMTypeInner : INativeConvertible<TJVMTypeInner, TNetType>, new()
        {
            TJVMTypeInner inner = default;
            if (func == null) inner = new TJVMTypeInner();
            var tInstance = new TIterableType();
            foreach (var item in set)
            {
                tInstance.Add(func != null ? func(item) : inner.ToJVM(item));
            }
            return tInstance;
        }

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to an <see cref="Java.Util.Collection{T}"/> of <see cref="Java.Lang.String"/>
        /// </summary>
        /// <param name="set">The <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to be converted</param>
        /// <param name="func">An optional <see cref="Func{T, TResult}"/> used to return <typeparamref name="TJVMType"/> from data of <typeparamref name="TNetType"/> in <paramref name="set"/></param>
        /// <returns>The converted <see cref="Java.Util.Collection{T}"/> of <see cref="Java.Lang.String"/></returns>
        public static Java.Util.Collection<TJVMType> ToJVMCollection<TJVMType, TNetType>(this System.Collections.Generic.IEnumerable<TNetType> set, Func<TNetType, TJVMType> func = null)
            where TJVMType : INativeConvertible<TJVMType, TNetType>, new()
        {
            return ToJVMCollectionType<ArrayList<TJVMType>, TJVMType, TNetType>(set, func);
        }

        /// <summary>
        /// Converts an <see cref="System.Collections.Generic.IEnumerable{T}"/> of <see cref="string"/> to an array of <see cref="Java.Lang.String"/>
        /// </summary>
        /// <param name="collection">The array of <typeparamref name="TNetType"/> to be converted</param>
        /// <param name="func">An optional <see cref="Func{T, TResult}"/> used to return <typeparamref name="TJVMType"/> from data of <typeparamref name="TNetType"/> in <paramref name="collection"/></param>
        /// <returns>The array of <typeparamref name="TJVMType"/></returns>
        public static TJVMType[] ToJVMArray<TJVMType, TNetType>(this TNetType[] collection, Func<TNetType, TJVMType> func = null)
            where TJVMType : INativeConvertible<TJVMType, TNetType>, new()
        {
            TJVMType inner = default;
            if (func == null) inner = new TJVMType();
            System.Collections.Generic.List<TJVMType> list = new();
            foreach (var item in collection)
            {
                list.Add(func != null ? func(item) : inner.ToJVM(item));
            }
            return list.ToArray();
        }

        #endregion

        #region Map/Dictionary Extensions
        /// <summary>
        /// Converts a <see cref="IDictionary{K, V}"/> to <see cref="Map{TJVMK, TJVMV}"/>
        /// </summary>
        /// <param name="keyConverter">Optional converter from <typeparamref name="TJVMK"/> to <typeparamref name="K"/></param>
        /// <param name="valueConverter">Optional converter from <typeparamref name="TJVMV"/> to <typeparamref name="V"/></param>
        /// <typeparam name="TDictionaryType">The <see cref="IDictionary{K, V}"/> over <typeparamref name="K"/> and <typeparamref name="V"/></typeparam>
        /// <typeparam name="K">.NET Key type</typeparam>
        /// <typeparam name="V">.NET Value</typeparam>
        /// <typeparam name="TJVMK">JVM key type</typeparam>
        /// <typeparam name="TJVMV">JVM value type</typeparam>
        /// <param name="map">The <see cref="Map{TJVMK, TJVMV}"/></param>
        /// <returns>The <see cref="IDictionary{K, V}"/></returns>
        public static TDictionaryType ToNetDictiony<TDictionaryType, K, V, TJVMK, TJVMV>(this Map<TJVMK, TJVMV> map, Func<TJVMK, K> keyConverter = null, Func<TJVMV, V> valueConverter = null)
            where TDictionaryType : IDictionary<K, V>, new()
            where TJVMK : INativeConvertible<TJVMK, K>, new()
            where TJVMV : INativeConvertible<TJVMV, V>, new()
        {
            if (map == null) throw new ArgumentNullException(nameof(map));
            var tInstance = new TDictionaryType();
            foreach (var key in map.KeySet())
            {
                var value = map.Get(key);
                tInstance.Add(keyConverter != null ? keyConverter(key) : key.ToCLR(), valueConverter != null ? valueConverter(value) : value.ToCLR());
            }
            return tInstance;
        }

        /// <summary>
        /// Converts a <see cref="IDictionary{K, V}"/> to <see cref="Map{TJVMK, TJVMV}"/>
        /// </summary>
        /// <param name="keyConverter">Optional converter from <typeparamref name="TJVMK"/> to <typeparamref name="K"/></param>
        /// <param name="valueConverter">Optional converter from <typeparamref name="TJVMV"/> to <typeparamref name="V"/></param>
        /// <typeparam name="K">.NET Key type</typeparam>
        /// <typeparam name="V">.NET Value</typeparam>
        /// <typeparam name="TJVMK">JVM key type</typeparam>
        /// <typeparam name="TJVMV">JVM value type</typeparam>
        /// <param name="map">The <see cref="Map{TJVMK, TJVMV}"/></param>
        /// <returns>The <see cref="IDictionary{K, V}"/></returns>
        public static IDictionary<K, V> ToNetDictiony<K, V, TJVMK, TJVMV>(this Map<TJVMK, TJVMV> map, Func<TJVMK, K> keyConverter = null, Func<TJVMV, V> valueConverter = null)
            where TJVMK : INativeConvertible<TJVMK, K>, new()
            where TJVMV : INativeConvertible<TJVMV, V>, new()
        {
            return ToNetDictiony<System.Collections.Generic.Dictionary<K, V>, K, V, TJVMK, TJVMV>(map, keyConverter, valueConverter);
        }

        /// <summary>
        /// Converts a <see cref="IDictionary{K, V}"/> to <typeparamref name="TMapType"/>
        /// </summary>
        /// <param name="keyConverter">Optional converter from <typeparamref name="K"/> to <typeparamref name="TJVMK"/></param>
        /// <param name="valueConverter">Optional converter from <typeparamref name="V"/> to <typeparamref name="TJVMV"/></param>
        /// <typeparam name="TMapType">The <see cref="Java.Util.Map{K, V}"/> over <typeparamref name="TJVMK"/> and <typeparamref name="TJVMV"/></typeparam>
        /// <typeparam name="K">.NET Key type</typeparam>
        /// <typeparam name="V">.NET Value</typeparam>
        /// <typeparam name="TJVMK">JVM key type</typeparam>
        /// <typeparam name="TJVMV">JVM value type</typeparam>
        /// <param name="dictionary">The <see cref="IDictionary{K, V}"/></param>
        /// <returns>The <typeparamref name="TMapType"/></returns>
        public static TMapType ToJVMMap<TMapType, TJVMK, TJVMV, K, V>(this IDictionary<K, V> dictionary, Func<K, TJVMK> keyConverter = null, Func<V, TJVMV> valueConverter = null)
            where TMapType : Java.Util.Map<TJVMK, TJVMV>, new()
            where TJVMK : INativeConvertible<TJVMK, K>, new()
            where TJVMV : INativeConvertible<TJVMV, V>, new()
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));
            TJVMK innerK = default;
            TJVMV innerV = default;
            if (keyConverter == null) innerK = new TJVMK();
            if (valueConverter == null) innerV = new TJVMV();
            var tInstance = new TMapType();
            foreach (var item in dictionary)
            {
                tInstance.Put(keyConverter != null ? keyConverter(item.Key) : innerK.ToJVM(item.Key), valueConverter != null ? valueConverter(item.Value) : innerV.ToJVM(item.Value));
            }
            return tInstance;
        }

        /// <summary>
        /// Converts a <see cref="IDictionary{K, V}"/> to <see cref="Map{TJVMK, TJVMV}"/>
        /// </summary>
        /// <param name="keyConverter">Converter from <typeparamref name="K"/> to <typeparamref name="TJVMK"/></param>
        /// <param name="valueConverter">Converter from <typeparamref name="V"/> to <typeparamref name="TJVMV"/></param>
        /// <typeparam name="K">.NET Key type</typeparam>
        /// <typeparam name="V">.NET Value</typeparam>
        /// <typeparam name="TJVMK">JVM key type</typeparam>
        /// <typeparam name="TJVMV">JVM value type</typeparam>
        /// <param name="dictionary">The <see cref="IDictionary{K, V}"/></param>
        /// <returns>The <see cref="Map{TJVMK, TJVMV}"/></returns>
        public static Map<TJVMK, TJVMV> ToJVMMap<TJVMK, TJVMV, K, V>(this IDictionary<K, V> dictionary, Func<K, TJVMK> keyConverter, Func<V, TJVMV> valueConverter)
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));
            if (keyConverter == null) throw new ArgumentNullException(nameof(keyConverter));
            if (valueConverter == null) throw new ArgumentNullException(nameof(valueConverter));
            var tInstance = new HashMap<TJVMK, TJVMV>();
            foreach (var item in dictionary)
            {
                tInstance.Put(keyConverter(item.Key), valueConverter(item.Value));
            }
            return tInstance;
        }

        /// <summary>
        /// Converts a <see cref="IDictionary{K, V}"/> to <typeparamref name="TDictionaryType"/>
        /// </summary>
        /// <param name="keyConverter">Optional converter from <typeparamref name="K"/> to <typeparamref name="TJVMK"/></param>
        /// <param name="valueConverter">Optional converter from <typeparamref name="V"/> to <typeparamref name="TJVMV"/></param>
        /// <typeparam name="TDictionaryType">The <see cref="Java.Util.Dictionary{K, V}"/> over <typeparamref name="TJVMK"/> and <typeparamref name="TJVMV"/></typeparam>
        /// <typeparam name="K">.NET Key type</typeparam>
        /// <typeparam name="V">.NET Value</typeparam>
        /// <typeparam name="TJVMK">JVM key type</typeparam>
        /// <typeparam name="TJVMV">JVM value type</typeparam>
        /// <param name="dictionary">The <see cref="IDictionary{K, V}"/></param>
        /// <returns>The <typeparamref name="TDictionaryType"/></returns>
        public static TDictionaryType ToJVMDictionary<TDictionaryType, TJVMK, TJVMV, K, V>(this IDictionary<K, V> dictionary, Func<K, TJVMK> keyConverter = null, Func<V, TJVMV> valueConverter = null)
            where TDictionaryType : Java.Util.Dictionary<TJVMK, TJVMV>, new()
            where TJVMK : INativeConvertible<TJVMK, K>, new()
            where TJVMV : INativeConvertible<TJVMV, V>, new()
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));
            TJVMK innerK = default;
            TJVMV innerV = default;
            if (keyConverter == null) innerK = new TJVMK();
            if (valueConverter == null) innerV = new TJVMV();
            var tInstance = new TDictionaryType();
            foreach (var item in dictionary)
            {
                tInstance.Put(keyConverter != null ? keyConverter(item.Key) : innerK.ToJVM(item.Key), valueConverter != null ? valueConverter(item.Value) : innerV.ToJVM(item.Value));
            }
            return tInstance;
        }

        /// <summary>
        /// Converts a <see cref="IDictionary{K, V}"/> to <see cref="Java.Util.Dictionary{TJVMK, TJVMV}"/>
        /// </summary>
        /// <param name="keyConverter">Converter from <typeparamref name="K"/> to <typeparamref name="TJVMK"/></param>
        /// <param name="valueConverter">Converter from <typeparamref name="V"/> to <typeparamref name="TJVMV"/></param>
        /// <typeparam name="K">.NET Key type</typeparam>
        /// <typeparam name="V">.NET Value</typeparam>
        /// <typeparam name="TJVMK">JVM key type</typeparam>
        /// <typeparam name="TJVMV">JVM value type</typeparam>
        /// <param name="dictionary">The <see cref="IDictionary{K, V}"/></param>
        /// <returns>The <see cref="Java.Util.Dictionary{TJVMK, TJVMV}"/></returns>
        public static Java.Util.Dictionary<TJVMK, TJVMV> ToJVMDictionary<TJVMK, TJVMV, K, V>(this IDictionary<K, V> dictionary, Func<K, TJVMK> keyConverter, Func<V, TJVMV> valueConverter)
        {
            if (dictionary == null) throw new ArgumentNullException(nameof(dictionary));
            if (keyConverter == null) throw new ArgumentNullException(nameof(keyConverter));
            if (valueConverter == null) throw new ArgumentNullException(nameof(valueConverter));
            var tInstance = new Hashtable<TJVMK, TJVMV>();
            foreach (var item in dictionary)
            {
                tInstance.Put(keyConverter(item.Key), valueConverter(item.Value));
            }
            return tInstance;
        }

        #endregion
    }
}
