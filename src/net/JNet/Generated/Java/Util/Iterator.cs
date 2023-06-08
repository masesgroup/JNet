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
    #region Iterator
    public partial class Iterator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#hasNext()"/> 
        /// </summary>
        public bool HasNext
        {
            get { return IExecute<bool>("hasNext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#next()"/> 
        /// </summary>
        public object Next
        {
            get { return IExecute("next"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        public void ForEachRemaining(Java.Util.Function.Consumer arg0)
        {
            IExecute("forEachRemaining", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIterator<E>
    public partial interface IIterator<E>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#hasNext()"/> 
        /// </summary>
        bool HasNext { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#next()"/> 
        /// </summary>
        E Next { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        void ForEachRemaining<Arg0objectSuperE>(Java.Util.Function.Consumer<Arg0objectSuperE> arg0) where Arg0objectSuperE: E;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#remove()"/>
        /// </summary>
        void Remove();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Iterator<E>
    public partial class Iterator<E> : Java.Util.IIterator<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Iterator{E}"/> to <see cref="Java.Util.Iterator"/>
        /// </summary>
        public static implicit operator Java.Util.Iterator(Java.Util.Iterator<E> t) => t.Cast<Java.Util.Iterator>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#hasNext()"/> 
        /// </summary>
        public bool HasNext
        {
            get { return IExecute<bool>("hasNext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#next()"/> 
        /// </summary>
        public E Next
        {
            get { return IExecute<E>("next"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#forEachRemaining(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperE"><typeparamref name="E"/></typeparam>
        public void ForEachRemaining<Arg0objectSuperE>(Java.Util.Function.Consumer<Arg0objectSuperE> arg0) where Arg0objectSuperE: E
        {
            IExecute("forEachRemaining", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Iterator.html#remove()"/>
        /// </summary>
        public void Remove()
        {
            IExecute("remove");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}