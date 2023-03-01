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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Collection
    public partial class Collection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Collection"/> to <see cref="Java.Lang.Iterable"/>
        /// </summary>
        public static implicit operator Java.Lang.Iterable(Java.Util.Collection t) => t.Cast<Java.Lang.Iterable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#toArray(T[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(object[] arg0)
        {
            return IExecuteArray<object>("toArray", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#add(E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#addAll(java.util.Collection%3C? extends E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool AddAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#containsAll(java.util.Collection%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("containsAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#isEmpty()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#removeAll(java.util.Collection%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("removeAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#retainAll(java.util.Collection%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool RetainAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("retainAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#size()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#toArray()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteArray<object>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#iterator()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecute<Java.Util.Iterator>("iterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#toArray(java.util.function.IntFunction%3CT[]%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntFunction"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(Java.Util.Function.IntFunction arg0)
        {
            return IExecuteArray<object>("toArray", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#removeIf(java.util.function.Predicate%3C? super E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool RemoveIf(Java.Util.Function.Predicate arg0)
        {
            return IExecute<bool>("removeIf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#spliterator()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator Spliterator()
        {
            return IExecute<Java.Util.Spliterator>("spliterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#parallelStream()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream ParallelStream()
        {
            return IExecute<Java.Util.Stream.Stream>("parallelStream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#stream.Stream%3CE%3E java.util.Collection.stream()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream Stream()
        {
            return IExecute<Java.Util.Stream.Stream>("stream");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}