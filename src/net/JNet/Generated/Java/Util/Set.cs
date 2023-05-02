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
    #region Set
    public partial class Set
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#copyOf(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set CopyOf(Java.Util.Collection arg0)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "copyOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of()
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <param name="arg9"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8, object arg9)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <param name="arg8"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7, object arg8)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <param name="arg7"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6, object arg7)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <param name="arg6"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5, object arg6)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1, object arg2, object arg3, object arg4, object arg5)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1, object arg2, object arg3, object arg4)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1, object arg2, object arg3)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1, object arg2)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0, object arg1)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(params object[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Util.Set>(LocalBridgeClazz, "of"); else return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set Of(object arg0)
        {
            return SExecute<Java.Util.Set>(LocalBridgeClazz, "of", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#iterator()"/> 
        /// </summary>
        public Java.Util.Iterator Iterator
        {
            get { return IExecute<Java.Util.Iterator>("iterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#spliterator()"/> 
        /// </summary>
        public Java.Util.Spliterator Spliterator
        {
            get { return IExecute<Java.Util.Spliterator>("spliterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(object[] arg0)
        {
            return IExecuteArray<object>("toArray", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("containsAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("removeAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RetainAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("retainAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#toArray()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteArray<object>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Set<E>
    public partial class Set<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Set{E}"/> to <see cref="Java.Util.Set"/>
        /// </summary>
        public static implicit operator Java.Util.Set(Java.Util.Set<E> t) => t.Cast<Java.Util.Set>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#copyOf(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> CopyOf<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE: E
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "copyOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of()
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <param name="arg4"><typeparamref name="E"/></param>
        /// <param name="arg5"><typeparamref name="E"/></param>
        /// <param name="arg6"><typeparamref name="E"/></param>
        /// <param name="arg7"><typeparamref name="E"/></param>
        /// <param name="arg8"><typeparamref name="E"/></param>
        /// <param name="arg9"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1, E arg2, E arg3, E arg4, E arg5, E arg6, E arg7, E arg8, E arg9)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <param name="arg4"><typeparamref name="E"/></param>
        /// <param name="arg5"><typeparamref name="E"/></param>
        /// <param name="arg6"><typeparamref name="E"/></param>
        /// <param name="arg7"><typeparamref name="E"/></param>
        /// <param name="arg8"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1, E arg2, E arg3, E arg4, E arg5, E arg6, E arg7, E arg8)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <param name="arg4"><typeparamref name="E"/></param>
        /// <param name="arg5"><typeparamref name="E"/></param>
        /// <param name="arg6"><typeparamref name="E"/></param>
        /// <param name="arg7"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1, E arg2, E arg3, E arg4, E arg5, E arg6, E arg7)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <param name="arg4"><typeparamref name="E"/></param>
        /// <param name="arg5"><typeparamref name="E"/></param>
        /// <param name="arg6"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1, E arg2, E arg3, E arg4, E arg5, E arg6)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <param name="arg4"><typeparamref name="E"/></param>
        /// <param name="arg5"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1, E arg2, E arg3, E arg4, E arg5)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <param name="arg4"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1, E arg2, E arg3, E arg4)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <param name="arg3"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1, E arg2, E arg3)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <param name="arg2"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1, E arg2)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <param name="arg1"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0, E arg1)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(params E[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of"); else return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#of(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<E> Of(E arg0)
        {
            return SExecute<Java.Util.Set<E>>(LocalBridgeClazz, "of", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#isEmpty()"/> 
        /// </summary>
        public bool IsEmpty
        {
            get { return IExecute<bool>("isEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#iterator()"/> 
        /// </summary>
        public Java.Util.Iterator<E> Iterator
        {
            get { return IExecute<Java.Util.Iterator<E>>("iterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#size()"/> 
        /// </summary>
        public int Size
        {
            get { return IExecute<int>("size"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#spliterator()"/> 
        /// </summary>
        public Java.Util.Spliterator<E> Spliterator
        {
            get { return IExecute<Java.Util.Spliterator<E>>("spliterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        public T[] ToArray<T>(T[] arg0)
        {
            return IExecuteArray<T>("toArray", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(E arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0ExtendsE"><typeparamref name="E"/></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool AddAll<Arg0ExtendsE>(Java.Util.Collection<Arg0ExtendsE> arg0) where Arg0ExtendsE: E
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool ContainsAll<Arg0Extendsobject>(Java.Util.Collection<Arg0Extendsobject> arg0)
        {
            return IExecute<bool>("containsAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool RemoveAll<Arg0Extendsobject>(Java.Util.Collection<Arg0Extendsobject> arg0)
        {
            return IExecute<bool>("removeAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg0Extendsobject"></typeparam>
        /// <returns><see cref="bool"/></returns>
        public bool RetainAll<Arg0Extendsobject>(Java.Util.Collection<Arg0Extendsobject> arg0)
        {
            return IExecute<bool>("retainAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#toArray()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteArray<object>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Set.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}