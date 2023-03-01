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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Function
{
    #region BiPredicate
    public partial class BiPredicate
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(T,U)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Test(object arg0, object arg1)
        {
            return IExecute<bool>("test", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate%3C? super T, ? super U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate And(Java.Util.Function.BiPredicate arg0)
        {
            return IExecute<Java.Util.Function.BiPredicate>("and", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate Negate()
        {
            return IExecute<Java.Util.Function.BiPredicate>("negate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate%3C? super T, ? super U%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate Or(Java.Util.Function.BiPredicate arg0)
        {
            return IExecute<Java.Util.Function.BiPredicate>("or", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}