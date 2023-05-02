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
    #region Predicate
    public partial class Predicate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#isEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public static Java.Util.Function.Predicate IsEqual(object arg0)
        {
            return SExecute<Java.Util.Function.Predicate>(LocalBridgeClazz, "isEqual", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#not(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public static Java.Util.Function.Predicate Not(Java.Util.Function.Predicate arg0)
        {
            return SExecute<Java.Util.Function.Predicate>(LocalBridgeClazz, "not", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/> 
        /// </summary>
        public Java.Util.Function.Predicate Negate
        {
            get { return IExecute<Java.Util.Function.Predicate>("negate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(object arg0)
        {
            return IExecute<bool>("test", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate And(Java.Util.Function.Predicate arg0)
        {
            return IExecute<Java.Util.Function.Predicate>("and", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate Or(Java.Util.Function.Predicate arg0)
        {
            return IExecute<Java.Util.Function.Predicate>("or", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Predicate<T>
    public partial class Predicate<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Function.Predicate{T}"/> to <see cref="Java.Util.Function.Predicate"/>
        /// </summary>
        public static implicit operator Java.Util.Function.Predicate(Java.Util.Function.Predicate<T> t) => t.Cast<Java.Util.Function.Predicate>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#isEqual(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public static Java.Util.Function.Predicate<T> IsEqual(object arg0)
        {
            return SExecute<Java.Util.Function.Predicate<T>>(LocalBridgeClazz, "isEqual", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#not(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public static Java.Util.Function.Predicate<T> Not<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return SExecute<Java.Util.Function.Predicate<T>>(LocalBridgeClazz, "not", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/> 
        /// </summary>
        public Java.Util.Function.Predicate<T> Negate
        {
            get { return IExecute<Java.Util.Function.Predicate<T>>("negate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(T arg0)
        {
            return IExecute<bool>("test", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<T> And<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecute<Java.Util.Function.Predicate<T>>("and", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<T> Or<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return IExecute<Java.Util.Function.Predicate<T>>("or", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}