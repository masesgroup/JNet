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

namespace Java.Util.Function
{
    #region LongUnaryOperator
    public partial class LongUnaryOperator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#identity()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public static Java.Util.Function.LongUnaryOperator Identity()
        {
            return SExecute<Java.Util.Function.LongUnaryOperator>("identity");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#applyAsLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long ApplyAsLong(long arg0)
        {
            return IExecute<long>("applyAsLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public Java.Util.Function.LongUnaryOperator AndThen(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecute<Java.Util.Function.LongUnaryOperator>("andThen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public Java.Util.Function.LongUnaryOperator Compose(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecute<Java.Util.Function.LongUnaryOperator>("compose", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}