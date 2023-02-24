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

namespace Java.Util.Concurrent
{
    #region CopyOnWriteArrayList
    public partial class CopyOnWriteArrayList
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList"/> to <see cref="Java.Util.RandomAccess"/>
        /// </summary>
        public static implicit operator Java.Util.RandomAccess(Java.Util.Concurrent.CopyOnWriteArrayList t) => t.Cast<Java.Util.RandomAccess>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Concurrent.CopyOnWriteArrayList t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArrayList"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.CopyOnWriteArrayList t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#toArray(T[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(object[] arg0)
        {
            return IExecuteArray<object>("toArray", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#add(E)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#addIfAbsent(E)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool AddIfAbsent(object arg0)
        {
            return IExecute<bool>("addIfAbsent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#isEmpty()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="object"/></returns>
        public object Get(int arg0)
        {
            return IExecute("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="object"/></returns>
        public object Remove(int arg0)
        {
            return IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#set(int,E)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object Set(int arg0, object arg1)
        {
            return IExecute("set", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#indexOf(E,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int IndexOf(object arg0, int arg1)
        {
            return IExecute<int>("indexOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#indexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int IndexOf(object arg0)
        {
            return IExecute<int>("indexOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#lastIndexOf(E,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int LastIndexOf(object arg0, int arg1)
        {
            return IExecute<int>("lastIndexOf", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#lastIndexOf(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int LastIndexOf(object arg0)
        {
            return IExecute<int>("lastIndexOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#size()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#toArray()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteArray<object>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#add(int,E)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        public void Add(int arg0, object arg1)
        {
            IExecute("add", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArrayList.html#clear()"/>
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