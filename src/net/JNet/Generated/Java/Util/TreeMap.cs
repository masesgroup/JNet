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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region TreeMap
    public partial class TreeMap
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public TreeMap(Java.Util.Map arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#%3Cinit%3E(java.util.SortedMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedMap"/></param>
        public TreeMap(Java.Util.SortedMap arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap"/> to <see cref="Java.Util.NavigableMap"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableMap(Java.Util.TreeMap t) => t.Cast<Java.Util.NavigableMap>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.TreeMap t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.TreeMap t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#ceilingEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry CeilingEntry(object arg0)
        {
            return IExecute<Java.Util.Map.Entry>("ceilingEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#firstEntry()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry FirstEntry()
        {
            return IExecute<Java.Util.Map.Entry>("firstEntry");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#floorEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry FloorEntry(object arg0)
        {
            return IExecute<Java.Util.Map.Entry>("floorEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#higherEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry HigherEntry(object arg0)
        {
            return IExecute<Java.Util.Map.Entry>("higherEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#lastEntry()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry LastEntry()
        {
            return IExecute<Java.Util.Map.Entry>("lastEntry");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#lowerEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry LowerEntry(object arg0)
        {
            return IExecute<Java.Util.Map.Entry>("lowerEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#pollFirstEntry()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry PollFirstEntry()
        {
            return IExecute<Java.Util.Map.Entry>("pollFirstEntry");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#pollLastEntry()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry PollLastEntry()
        {
            return IExecute<Java.Util.Map.Entry>("pollLastEntry");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#descendingMap()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap DescendingMap()
        {
            return IExecute<Java.Util.NavigableMap>("descendingMap");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap HeadMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap SubMapMethod(object arg0, bool arg1, object arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableMap>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap TailMap(object arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#descendingKeySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet DescendingKeySet()
        {
            return IExecute<Java.Util.NavigableSet>("descendingKeySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#navigableKeySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet NavigableKeySet()
        {
            return IExecute<Java.Util.NavigableSet>("navigableKeySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap HeadMap(object arg0)
        {
            return IExecute<Java.Util.SortedMap>("headMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap SubMapMethod(object arg0, object arg1)
        {
            return IExecute<Java.Util.SortedMap>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap TailMap(object arg0)
        {
            return IExecute<Java.Util.SortedMap>("tailMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#ceilingKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object CeilingKey(object arg0)
        {
            return IExecute("ceilingKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#firstKey()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object FirstKey()
        {
            return IExecute("firstKey");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#floorKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object FloorKey(object arg0)
        {
            return IExecute("floorKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#higherKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object HigherKey(object arg0)
        {
            return IExecute("higherKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#lastKey()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object LastKey()
        {
            return IExecute("lastKey");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#lowerKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object LowerKey(object arg0)
        {
            return IExecute("lowerKey", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeMap<K, V>
    public partial class TreeMap<K, V>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#%3Cinit%3E(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public TreeMap(Java.Util.Map<K, V> arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#%3Cinit%3E(java.util.SortedMap)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.SortedMap"/></param>
        public TreeMap(Java.Util.SortedMap<K, V> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap{K, V}"/> to <see cref="Java.Util.NavigableMap{K, V}"/>
        /// </summary>
        public static implicit operator Java.Util.NavigableMap<K, V>(Java.Util.TreeMap<K, V> t) => t.Cast<Java.Util.NavigableMap<K, V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap{K, V}"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.TreeMap<K, V> t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap{K, V}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.TreeMap<K, V> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.TreeMap{K, V}"/> to <see cref="Java.Util.TreeMap"/>
        /// </summary>
        public static implicit operator Java.Util.TreeMap(Java.Util.TreeMap<K, V> t) => t.Cast<Java.Util.TreeMap>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#ceilingEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> CeilingEntry(K arg0)
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("ceilingEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#firstEntry()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> FirstEntry()
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("firstEntry");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#floorEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> FloorEntry(K arg0)
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("floorEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#higherEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> HigherEntry(K arg0)
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("higherEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#lastEntry()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> LastEntry()
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("lastEntry");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#lowerEntry(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> LowerEntry(K arg0)
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("lowerEntry", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#pollFirstEntry()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> PollFirstEntry()
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("pollFirstEntry");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#pollLastEntry()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Map.Entry"/></returns>
        public Java.Util.Map.Entry<K, V> PollLastEntry()
        {
            return IExecute<Java.Util.Map.Entry<K, V>>("pollLastEntry");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#descendingMap()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> DescendingMap()
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("descendingMap");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#headMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> HeadMap(K arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("headMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#subMap(java.lang.Object,boolean,java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><typeparamref name="K"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> SubMapMethod(K arg0, bool arg1, K arg2, bool arg3)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("subMap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#tailMap(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.NavigableMap"/></returns>
        public Java.Util.NavigableMap<K, V> TailMap(K arg0, bool arg1)
        {
            return IExecute<Java.Util.NavigableMap<K, V>>("tailMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#descendingKeySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<K> DescendingKeySet()
        {
            return IExecute<Java.Util.NavigableSet<K>>("descendingKeySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#navigableKeySet()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.NavigableSet"/></returns>
        public Java.Util.NavigableSet<K> NavigableKeySet()
        {
            return IExecute<Java.Util.NavigableSet<K>>("navigableKeySet");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#headMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> HeadMap(K arg0)
        {
            return IExecute<Java.Util.SortedMap<K, V>>("headMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#subMap(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <param name="arg1"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> SubMapMethod(K arg0, K arg1)
        {
            return IExecute<Java.Util.SortedMap<K, V>>("subMap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#tailMap(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><see cref="Java.Util.SortedMap"/></returns>
        public Java.Util.SortedMap<K, V> TailMap(K arg0)
        {
            return IExecute<Java.Util.SortedMap<K, V>>("tailMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#ceilingKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K CeilingKey(K arg0)
        {
            return IExecute<K>("ceilingKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#firstKey()"/>
        /// </summary>

        /// <returns><typeparamref name="K"/></returns>
        public K FirstKey()
        {
            return IExecute<K>("firstKey");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#floorKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K FloorKey(K arg0)
        {
            return IExecute<K>("floorKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#higherKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K HigherKey(K arg0)
        {
            return IExecute<K>("higherKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#lastKey()"/>
        /// </summary>

        /// <returns><typeparamref name="K"/></returns>
        public K LastKey()
        {
            return IExecute<K>("lastKey");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/TreeMap.html#lowerKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="K"/></param>
        /// <returns><typeparamref name="K"/></returns>
        public K LowerKey(K arg0)
        {
            return IExecute<K>("lowerKey", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}