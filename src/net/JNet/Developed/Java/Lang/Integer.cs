/*
*  Copyright 2024 MASES s.r.l.
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
using MASES.JNet.Specific.Extensions;
using System;

namespace Java.Lang
{
    public partial class Integer : INativeConvertible<Integer, int>
    {
        int INativeConvertible<Integer, int>.ToCLR()
        {
            return IntValue();
        }

        Integer INativeConvertible<Integer, int>.ToJVM(int clrValue)
        {
            return ValueOf(clrValue);
        }

        /// <summary>
        /// Converter from <see cref="Integer"/> to <see cref="int"/>
        /// </summary>
        public static implicit operator int(Integer b) => b != null ? b.IntValue() : default;
        /// <summary>
        /// Converter from <see cref="Integer"/> to <see cref="Nullable{Int32}"/>
        /// </summary>
        public static implicit operator int?(Integer b) => b != null ? b.IntValue() : null;
        /// <summary>
        /// Converter from <see cref="int"/> to <see cref="Integer"/>
        /// </summary>
        public static implicit operator Integer(int b) => ValueOf(b);
        /// <summary>
        /// Converter from <see cref="Nullable{int32}"/> to <see cref="Integer"/>
        /// </summary>
        public static implicit operator Integer(int? b) => b.HasValue ? ValueOf(b.Value) : null;
    }
}
