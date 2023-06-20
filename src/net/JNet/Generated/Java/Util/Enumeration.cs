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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region Enumeration
    public partial class Enumeration
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#hasMoreElements()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasMoreElements()
        {
            return IExecute<bool>("hasMoreElements");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#nextElement()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object NextElement()
        {
            return IExecute("nextElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#asIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator AsIterator()
        {
            return IExecute<Java.Util.Iterator>("asIterator");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IEnumeration<E>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IEnumeration<E>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#hasMoreElements()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool HasMoreElements();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#nextElement()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E NextElement();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#asIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<E> AsIterator();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Enumeration<E>
    public partial class Enumeration<E> : Java.Util.IEnumeration<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Enumeration{E}"/> to <see cref="Java.Util.Enumeration"/>
        /// </summary>
        public static implicit operator Java.Util.Enumeration(Java.Util.Enumeration<E> t) => t.Cast<Java.Util.Enumeration>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#hasMoreElements()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasMoreElements()
        {
            return IExecute<bool>("hasMoreElements");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#nextElement()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E NextElement()
        {
            return IExecute<E>("nextElement");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Enumeration.html#asIterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<E> AsIterator()
        {
            return IExecute<Java.Util.Iterator<E>>("asIterator");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}