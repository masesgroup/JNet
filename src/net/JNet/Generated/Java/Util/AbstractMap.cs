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
    #region AbstractMap
    public partial class AbstractMap
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractMap"/> to <see cref="Java.Util.Map"/>
        /// </summary>
        public static implicit operator Java.Util.Map(Java.Util.AbstractMap t) => t.Cast<Java.Util.Map>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#entrySet()"/> 
        /// </summary>
        public Java.Util.Set EntrySet
        {
            get { return IExecute<Java.Util.Set>("entrySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#keySet()"/> 
        /// </summary>
        public Java.Util.Set KeySet
        {
            get { return IExecute<Java.Util.Set>("keySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#values()"/> 
        /// </summary>
        public Java.Util.Collection Values
        {
            get { return IExecute<Java.Util.Collection>("values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Get(object arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#put(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Put(object arg0, object arg1)
        {
            return IExecute("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Remove(object arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#putAll(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void PutAll(Java.Util.Map arg0)
        {
            IExecute("putAll", arg0);
        }
        
        #endregion

        #region Nested classes
        #region SimpleEntry
        public partial class SimpleEntry
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#%3Cinit%3E(java.util.Map.Entry)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map.Entry"/></param>
            public SimpleEntry(Java.Util.Map.Entry arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#%3Cinit%3E(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public SimpleEntry(object arg0, object arg1)
                : base(arg0, arg1)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.AbstractMap.SimpleEntry"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Util.AbstractMap.SimpleEntry t) => t.Cast<Java.Io.Serializable>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#getKey()"/> 
            /// </summary>
            public object Key
            {
                get { return IExecute("getKey"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#getValue()"/> 
            /// </summary>
            public object Value
            {
                get { return IExecute("getValue"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#setValue(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object SetValue(object arg0)
            {
                return IExecute("setValue", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SimpleEntry<K, V>
        public partial class SimpleEntry<K, V>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#%3Cinit%3E(java.util.Map.Entry)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map.Entry"/></param>
            public SimpleEntry(Java.Util.Map.Entry arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#%3Cinit%3E(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="K"/></param>
            /// <param name="arg1"><see cref="V"/></param>
            public SimpleEntry(K arg0, V arg1)
                : base(arg0, arg1)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.AbstractMap.SimpleEntry{K, V}"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Util.AbstractMap.SimpleEntry<K, V> t) => t.Cast<Java.Io.Serializable>();
            /// <summary>
            /// Converter from <see cref="Java.Util.AbstractMap.SimpleEntry{K, V}"/> to <see cref="Java.Util.AbstractMap.SimpleEntry"/>
            /// </summary>
            public static implicit operator Java.Util.AbstractMap.SimpleEntry(Java.Util.AbstractMap.SimpleEntry<K, V> t) => t.Cast<Java.Util.AbstractMap.SimpleEntry>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#getKey()"/> 
            /// </summary>
            public K Key
            {
                get { return IExecute<K>("getKey"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#getValue()"/> 
            /// </summary>
            public V Value
            {
                get { return IExecute<V>("getValue"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleEntry.html#setValue(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="V"/></param>
            /// <returns><see cref="V"/></returns>
            public V SetValue(V arg0)
            {
                return IExecute<V>("setValue", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SimpleImmutableEntry
        public partial class SimpleImmutableEntry
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#%3Cinit%3E(java.util.Map.Entry)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map.Entry"/></param>
            public SimpleImmutableEntry(Java.Util.Map.Entry arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#%3Cinit%3E(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public SimpleImmutableEntry(object arg0, object arg1)
                : base(arg0, arg1)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.AbstractMap.SimpleImmutableEntry"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Util.AbstractMap.SimpleImmutableEntry t) => t.Cast<Java.Io.Serializable>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#getKey()"/> 
            /// </summary>
            public object Key
            {
                get { return IExecute("getKey"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#getValue()"/> 
            /// </summary>
            public object Value
            {
                get { return IExecute("getValue"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#setValue(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <returns><see cref="object"/></returns>
            public object SetValue(object arg0)
            {
                return IExecute("setValue", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SimpleImmutableEntry<K, V>
        public partial class SimpleImmutableEntry<K, V>
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#%3Cinit%3E(java.util.Map.Entry)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Map.Entry"/></param>
            public SimpleImmutableEntry(Java.Util.Map.Entry arg0)
                : base(arg0)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#%3Cinit%3E(java.lang.Object,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="K"/></param>
            /// <param name="arg1"><see cref="V"/></param>
            public SimpleImmutableEntry(K arg0, V arg1)
                : base(arg0, arg1)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.AbstractMap.SimpleImmutableEntry{K, V}"/> to <see cref="Java.Io.Serializable"/>
            /// </summary>
            public static implicit operator Java.Io.Serializable(Java.Util.AbstractMap.SimpleImmutableEntry<K, V> t) => t.Cast<Java.Io.Serializable>();
            /// <summary>
            /// Converter from <see cref="Java.Util.AbstractMap.SimpleImmutableEntry{K, V}"/> to <see cref="Java.Util.AbstractMap.SimpleImmutableEntry"/>
            /// </summary>
            public static implicit operator Java.Util.AbstractMap.SimpleImmutableEntry(Java.Util.AbstractMap.SimpleImmutableEntry<K, V> t) => t.Cast<Java.Util.AbstractMap.SimpleImmutableEntry>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#getKey()"/> 
            /// </summary>
            public K Key
            {
                get { return IExecute<K>("getKey"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#getValue()"/> 
            /// </summary>
            public V Value
            {
                get { return IExecute<V>("getValue"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.SimpleImmutableEntry.html#setValue(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="V"/></param>
            /// <returns><see cref="V"/></returns>
            public V SetValue(V arg0)
            {
                return IExecute<V>("setValue", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AbstractMap<K, V>
    public partial class AbstractMap<K, V>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractMap{K, V}"/> to <see cref="Java.Util.Map{K, V}"/>
        /// </summary>
        public static implicit operator Java.Util.Map<K, V>(Java.Util.AbstractMap<K, V> t) => t.Cast<Java.Util.Map<K, V>>();
        /// <summary>
        /// Converter from <see cref="Java.Util.AbstractMap{K, V}"/> to <see cref="Java.Util.AbstractMap"/>
        /// </summary>
        public static implicit operator Java.Util.AbstractMap(Java.Util.AbstractMap<K, V> t) => t.Cast<Java.Util.AbstractMap>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#entrySet()"/> 
        /// </summary>
        public Java.Util.Set<Java.Util.Map.Entry<K, V>> EntrySet
        {
            get { return IExecute<Java.Util.Set<Java.Util.Map.Entry<K, V>>>("entrySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#keySet()"/> 
        /// </summary>
        public Java.Util.Set<K> KeySet
        {
            get { return IExecute<Java.Util.Set<K>>("keySet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#values()"/> 
        /// </summary>
        public Java.Util.Collection<V> Values
        {
            get { return IExecute<Java.Util.Collection<V>>("values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#containsValue(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsValue(object arg0)
        {
            return IExecute<bool>("containsValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#get(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="V"/></returns>
        public V Get(object arg0)
        {
            return IExecute<V>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#put(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="K"/></param>
        /// <param name="arg1"><see cref="V"/></param>
        /// <returns><see cref="V"/></returns>
        public V Put(K arg0, V arg1)
        {
            return IExecute<V>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="V"/></returns>
        public V Remove(object arg0)
        {
            return IExecute<V>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractMap.html#putAll(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        public void PutAll<Arg0ExtendsK, Arg0ExtendsV>(Java.Util.Map<Arg0ExtendsK, Arg0ExtendsV> arg0) where Arg0ExtendsK: K where Arg0ExtendsV: V
        {
            IExecute("putAll", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}