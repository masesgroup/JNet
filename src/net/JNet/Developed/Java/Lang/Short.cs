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
    public partial class Short : INativeConvertible<Short, short>
    {
        short INativeConvertible<Short, short>.ToCLR()
        {
            return ShortValue();
        }

        Short INativeConvertible<Short, short>.ToJVM(short clrValue)
        {
            return ValueOf(clrValue);
        }

        /// <summary>
        /// Converter from <see cref="Short"/> to <see cref="short"/>
        /// </summary>
        public static implicit operator short(Short b) => b != null ? b.ShortValue() : default;
        /// <summary>
        /// Converter from <see cref="Short"/> to <see cref="Nullable{Int16}"/>
        /// </summary>
        public static implicit operator short?(Short b) => b != null ? b.ShortValue() : null;
        /// <summary>
        /// Converter from <see cref="short"/> to <see cref="Short"/>
        /// </summary>
        public static implicit operator Short(short b) => ValueOf(b);
        /// <summary>
        /// Converter from <see cref="Nullable{Int16}"/> to <see cref="Short"/>
        /// </summary>
        public static implicit operator Short(short? b) => b.HasValue ? ValueOf(b.Value) : null;
    }
}
