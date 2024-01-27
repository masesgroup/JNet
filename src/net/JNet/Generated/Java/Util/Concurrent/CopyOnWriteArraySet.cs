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

namespace Java.Util.Concurrent
{
    #region CopyOnWriteArraySet
    public partial class CopyOnWriteArraySet
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArraySet.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public CopyOnWriteArraySet(Java.Util.Collection arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArraySet"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.CopyOnWriteArraySet t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CopyOnWriteArraySet<E>
    public partial class CopyOnWriteArraySet<E>
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/concurrent/CopyOnWriteArraySet.html#%3Cinit%3E(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        public CopyOnWriteArraySet(Java.Util.Collection<E> arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArraySet{E}"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Util.Concurrent.CopyOnWriteArraySet<E> t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Util.Concurrent.CopyOnWriteArraySet{E}"/> to <see cref="Java.Util.Concurrent.CopyOnWriteArraySet"/>
        /// </summary>
        public static implicit operator Java.Util.Concurrent.CopyOnWriteArraySet(Java.Util.Concurrent.CopyOnWriteArraySet<E> t) => t.Cast<Java.Util.Concurrent.CopyOnWriteArraySet>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}