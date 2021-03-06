/*
*  Copyright 2022 MASES s.r.l.
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

using MASES.JCOBridge.C2JBridge;

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Number.html"/>
    /// </summary>
    public class Number : JVMBridgeBase<Number>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.Number";
        /// <inheritdoc cref="JVMBridgeBase.IsAbstract"/>
        public override bool IsAbstract => true;
        /// <summary>
        /// Returns the value of the specified number as a <see cref="byte"/>, which may involve rounding or truncation.
        /// </summary>
        public byte ByteValue => IExecute<byte>("byteValue");
        /// <summary>
        /// Returns the value of the specified number as a <see cref="double"/>, which may involve rounding.
        /// </summary>
        public double DoubleValue => IExecute<byte>("doubleValue");
        /// <summary>
        /// Returns the value of the specified number as a <see cref="float"/>, which may involve rounding.
        /// </summary>
        public float FloatValue => IExecute<float>("floatValue");
        /// <summary>
        /// Returns the value of the specified number as an <see cref="int"/>, which may involve rounding or truncation.
        /// </summary>
        public int IntValue => IExecute<int>("intValue");
        /// <summary>
        /// Returns the value of the specified number as a <see cref="long"/>, which may involve rounding or truncation.
        /// </summary>
        public long LongValue => IExecute<long>("longValue");
        /// <summary>
        /// Returns the value of the specified number as a short, which may involve rounding or truncation.
        /// </summary>
        public short ShortValue => IExecute<short>("shortValue");
    }
}
