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

namespace Java.Util.Function
{
    #region Function
    public partial class Function
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#identity()"/> 
        /// </summary>
        public static Java.Util.Function.Function Identity
        {
            get { return SExecute<Java.Util.Function.Function>(LocalBridgeClazz, "identity"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Apply(object arg0)
        {
            return IExecute("apply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function AndThen(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Function.Function>("andThen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function Compose(Java.Util.Function.Function arg0)
        {
            return IExecute<Java.Util.Function.Function>("compose", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Function<T, R>
    public partial class Function<T, R>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Function.Function{T, R}"/> to <see cref="Java.Util.Function.Function"/>
        /// </summary>
        public static implicit operator Java.Util.Function.Function(Java.Util.Function.Function<T, R> t) => t.Cast<Java.Util.Function.Function>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#identity()"/> 
        /// </summary>
        public static Java.Util.Function.Function<T, T> Identity
        {
            get { return SExecute<Java.Util.Function.Function<T, T>>(LocalBridgeClazz, "identity"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public R Apply(T arg0)
        {
            return IExecute<R>("apply", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="Arg0ExtendsV"></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function<T, V> AndThen<V, Arg0objectSuperR, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR: R
        {
            return IExecute<Java.Util.Function.Function<T, V>>("andThen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function<V, R> Compose<V, Arg0objectSuperV, Arg0ExtendsT>(Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT> arg0) where Arg0objectSuperV: V
        {
            return IExecute<Java.Util.Function.Function<V, R>>("compose", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}