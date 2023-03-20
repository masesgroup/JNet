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
    #region DoubleUnaryOperator
    public partial class DoubleUnaryOperator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#identity()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        public static Java.Util.Function.DoubleUnaryOperator Identity()
        {
            return SExecute<Java.Util.Function.DoubleUnaryOperator>("identity");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#applyAsDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double ApplyAsDouble(double arg0)
        {
            return IExecute<double>("applyAsDouble", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#andThen(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        public Java.Util.Function.DoubleUnaryOperator AndThen(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecute<Java.Util.Function.DoubleUnaryOperator>("andThen", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#compose(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        public Java.Util.Function.DoubleUnaryOperator Compose(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecute<Java.Util.Function.DoubleUnaryOperator>("compose", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}