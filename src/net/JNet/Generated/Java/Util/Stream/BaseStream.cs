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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Stream
{
    #region BaseStream
    public partial class BaseStream
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#isParallel()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsParallel()
        {
            return IExecute<bool>("isParallel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecute<Java.Util.Iterator>("iterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#spliterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator Spliterator()
        {
            return IExecute<Java.Util.Spliterator>("spliterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#onClose(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream OnClose(Java.Lang.Runnable arg0)
        {
            return IExecute<Java.Util.Stream.BaseStream>("onClose", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#parallel()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Parallel()
        {
            return IExecute<Java.Util.Stream.BaseStream>("parallel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#sequential()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Sequential()
        {
            return IExecute<Java.Util.Stream.BaseStream>("sequential");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#unordered()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.BaseStream"/></returns>
        public Java.Util.Stream.BaseStream Unordered()
        {
            return IExecute<Java.Util.Stream.BaseStream>("unordered");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IBaseStream<T, S>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBaseStream<T, S> : Java.Lang.IAutoCloseable
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#isParallel()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsParallel();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<T> Iterator();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#spliterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        Java.Util.Spliterator<T> Spliterator();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#onClose(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><typeparamref name="S"/></returns>
        S OnClose(Java.Lang.Runnable arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#parallel()"/>
        /// </summary>

        /// <returns><typeparamref name="S"/></returns>
        S Parallel();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#sequential()"/>
        /// </summary>

        /// <returns><typeparamref name="S"/></returns>
        S Sequential();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#unordered()"/>
        /// </summary>

        /// <returns><typeparamref name="S"/></returns>
        S Unordered();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#close()"/>
        /// </summary>
        void Close();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BaseStream<T, S>
    public partial class BaseStream<T, S> : Java.Util.Stream.IBaseStream<T, S>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Stream.BaseStream{T, S}"/> to <see cref="Java.Util.Stream.BaseStream"/>
        /// </summary>
        public static implicit operator Java.Util.Stream.BaseStream(Java.Util.Stream.BaseStream<T, S> t) => t.Cast<Java.Util.Stream.BaseStream>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#isParallel()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsParallel()
        {
            return IExecute<bool>("isParallel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<T> Iterator()
        {
            return IExecute<Java.Util.Iterator<T>>("iterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#spliterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public Java.Util.Spliterator<T> Spliterator()
        {
            return IExecute<Java.Util.Spliterator<T>>("spliterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#onClose(java.lang.Runnable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Runnable"/></param>
        /// <returns><typeparamref name="S"/></returns>
        public S OnClose(Java.Lang.Runnable arg0)
        {
            return IExecute<S>("onClose", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#parallel()"/>
        /// </summary>

        /// <returns><typeparamref name="S"/></returns>
        public S Parallel()
        {
            return IExecute<S>("parallel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#sequential()"/>
        /// </summary>

        /// <returns><typeparamref name="S"/></returns>
        public S Sequential()
        {
            return IExecute<S>("sequential");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#unordered()"/>
        /// </summary>

        /// <returns><typeparamref name="S"/></returns>
        public S Unordered()
        {
            return IExecute<S>("unordered");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/BaseStream.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}