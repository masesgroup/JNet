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

namespace Java.Util.Function
{
    #region Consumer
    public partial class Consumer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Accept(object arg0)
        {
            IExecute("accept", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        public Java.Util.Function.Consumer AndThen(Java.Util.Function.Consumer arg0)
        {
            return IExecute<Java.Util.Function.Consumer>("andThen", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IConsumer<T>
    public partial interface IConsumer<T>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        void Accept(T arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        Java.Util.Function.Consumer<T> AndThen<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT: T;

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Consumer<T>
    public partial class Consumer<T> : Java.Util.Function.IConsumer<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Function.Consumer{T}"/> to <see cref="Java.Util.Function.Consumer"/>
        /// </summary>
        public static implicit operator Java.Util.Function.Consumer(Java.Util.Function.Consumer<T> t) => t.Cast<Java.Util.Function.Consumer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public void Accept(T arg0)
        {
            IExecute("accept", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        public Java.Util.Function.Consumer<T> AndThen<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecute<Java.Util.Function.Consumer<T>>("andThen", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}