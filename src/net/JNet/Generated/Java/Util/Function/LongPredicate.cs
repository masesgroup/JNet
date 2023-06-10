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
    #region ILongPredicate
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html"/>
    /// </summary>
    public partial interface ILongPredicate
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#test(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Test(long arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#and(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        Java.Util.Function.LongPredicate And(Java.Util.Function.LongPredicate arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        Java.Util.Function.LongPredicate Negate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#or(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        Java.Util.Function.LongPredicate Or(Java.Util.Function.LongPredicate arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region LongPredicate
    public partial class LongPredicate : Java.Util.Function.ILongPredicate
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#test(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public virtual bool Test(long arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#and(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public virtual Java.Util.Function.LongPredicate And(Java.Util.Function.LongPredicate arg0)
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#negate()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public virtual Java.Util.Function.LongPredicate Negate()
        {
            return default;
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#or(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public virtual Java.Util.Function.LongPredicate Or(Java.Util.Function.LongPredicate arg0)
        {
            return default;
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}