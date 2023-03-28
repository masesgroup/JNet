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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region ListIterator
    public partial class ListIterator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#hasNext()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#hasPrevious()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool HasPrevious()
        {
            return IExecute<bool>("hasPrevious");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#next()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object Next()
        {
            return IExecute("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#previous()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object Previous()
        {
            return IExecute("previous");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#nextIndex()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int NextIndex()
        {
            return IExecute<int>("nextIndex");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#previousIndex()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int PreviousIndex()
        {
            return IExecute<int>("previousIndex");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Add(object arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#set(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Set(object arg0)
        {
            IExecute("set", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ListIterator<E>
    public partial class ListIterator<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.ListIterator{E}"/> to <see cref="Java.Util.ListIterator"/>
        /// </summary>
        public static implicit operator Java.Util.ListIterator(Java.Util.ListIterator<E> t) => t.Cast<Java.Util.ListIterator>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#hasNext()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool HasNext()
        {
            return IExecute<bool>("hasNext");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#hasPrevious()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool HasPrevious()
        {
            return IExecute<bool>("hasPrevious");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#next()"/>
        /// </summary>
        
        /// <returns><see cref="E"/></returns>
        public E Next()
        {
            return IExecute<E>("next");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#previous()"/>
        /// </summary>
        
        /// <returns><see cref="E"/></returns>
        public E Previous()
        {
            return IExecute<E>("previous");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#nextIndex()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int NextIndex()
        {
            return IExecute<int>("nextIndex");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#previousIndex()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int PreviousIndex()
        {
            return IExecute<int>("previousIndex");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="E"/></param>
        public void Add(E arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ListIterator.html#set(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="E"/></param>
        public void Set(E arg0)
        {
            IExecute("set", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}