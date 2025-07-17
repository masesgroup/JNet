/*
*  Copyright 2025 MASES s.r.l.
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

using MASES.JNet.Specific.Extensions;
using System;

namespace Java.Lang
{
    public partial class Boolean : INativeConvertible<Boolean, bool>
    {
        bool INativeConvertible<Boolean, bool>.ToCLR()
        {
            return BooleanValue();
        }
        /// <summary>
        /// Returns the <see cref="Boolean"/> from the <paramref name="clrValue"/> instance
        /// </summary>
        /// <param name="clrValue">The <see cref="bool"/> of CLR</param>
        /// <returns>The converted <see cref="Boolean"/></returns>
        public static Boolean ToJVM(bool clrValue)
        {
            return ValueOf(clrValue);
        }

        /// <summary>
        /// Converter from <see cref="Boolean"/> to <see cref="bool"/>
        /// </summary>
        public static implicit operator bool(Boolean b) => b != null ? b.BooleanValue() : default;
        /// <summary>
        /// Converter from <see cref="Boolean"/> to <see cref="Nullable{Boolean}"/>
        /// </summary>
        public static implicit operator bool?(Boolean b) => b != null ? b.BooleanValue() : null;
        /// <summary>
        /// Converter from <see cref="bool"/> to <see cref="Boolean"/>
        /// </summary>
        public static implicit operator Boolean(bool b) => ValueOf(b);
        /// <summary>
        /// Converter from <see cref="Nullable{Boolean}"/> to <see cref="Boolean"/>
        /// </summary>
        public static implicit operator Boolean(bool? b) => b.HasValue ? ValueOf(b.Value) : null;
    }
}
