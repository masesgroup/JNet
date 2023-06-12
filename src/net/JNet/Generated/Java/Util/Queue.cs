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
    #region Queue
    public partial class Queue
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(object arg0)
        {
            return IExecute<bool>("offer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#element()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Element()
        {
            return IExecute("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#peek()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Peek()
        {
            return IExecute("peek");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#poll()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Poll()
        {
            return IExecute("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#remove()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Remove()
        {
            return IExecute("remove");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IQueue<E>
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html"/>
    /// </summary>
    public partial interface IQueue<E> : Java.Util.ICollection<E>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Add(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Offer(E arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#element()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Element();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#peek()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Peek();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#poll()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Poll();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#remove()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        E Remove();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Queue<E>
    public partial class Queue<E> : Java.Util.IQueue<E>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Queue{E}"/> to <see cref="Java.Util.Queue"/>
        /// </summary>
        public static implicit operator Java.Util.Queue(Java.Util.Queue<E> t) => t.Cast<Java.Util.Queue>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Add(E arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#offer(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="E"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Offer(E arg0)
        {
            return IExecute<bool>("offer", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#element()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Element()
        {
            return IExecute<E>("element");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#peek()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Peek()
        {
            return IExecute<E>("peek");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#poll()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Poll()
        {
            return IExecute<E>("poll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Queue.html#remove()"/>
        /// </summary>

        /// <returns><typeparamref name="E"/></returns>
        public E Remove()
        {
            return IExecute<E>("remove");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}