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
    #region BinaryOperator
    public partial class BinaryOperator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html#maxBy(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        public static Java.Util.Function.BinaryOperator MaxBy(Java.Util.Comparator arg0)
        {
            return SExecute<Java.Util.Function.BinaryOperator>("maxBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html#minBy(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        public static Java.Util.Function.BinaryOperator MinBy(Java.Util.Comparator arg0)
        {
            return SExecute<Java.Util.Function.BinaryOperator>("minBy", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BinaryOperator<T>
    public partial class BinaryOperator<T>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html#maxBy(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        public static Java.Util.Function.BinaryOperator<T> MaxBy<Arg0objectSuperT>(Java.Util.Comparator<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return SExecute<Java.Util.Function.BinaryOperator<T>>("maxBy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BinaryOperator.html#minBy(java.util.Comparator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Comparator"/></param>
        /// <returns><see cref="Java.Util.Function.BinaryOperator"/></returns>
        public static Java.Util.Function.BinaryOperator<T> MinBy<Arg0objectSuperT>(Java.Util.Comparator<Arg0objectSuperT> arg0) where Arg0objectSuperT: T
        {
            return SExecute<Java.Util.Function.BinaryOperator<T>>("minBy", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}