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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    #region Number
    public partial class Number
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Number.html#doubleValue()"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        public double DoubleValue()
        {
            return IExecute<double>("doubleValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Number.html#floatValue()"/>
        /// </summary>

        /// <returns><see cref="float"/></returns>
        public float FloatValue()
        {
            return IExecute<float>("floatValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Number.html#intValue()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int IntValue()
        {
            return IExecute<int>("intValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Number.html#longValue()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LongValue()
        {
            return IExecute<long>("longValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Number.html#byteValue()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        public byte ByteValue()
        {
            return IExecute<byte>("byteValue");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Number.html#shortValue()"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public short ShortValue()
        {
            return IExecute<short>("shortValue");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}