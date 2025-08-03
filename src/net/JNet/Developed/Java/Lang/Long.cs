/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
    public partial class Long : INativeConvertible<Long, long>
    {
        long INativeConvertible<Long, long>.ToCLR()
        {
            return LongValue();
        }
        /// <summary>
        /// Returns the <see cref="Long"/> from the <paramref name="clrValue"/> instance
        /// </summary>
        /// <param name="clrValue">The <see cref="long"/> of CLR</param>
        /// <returns>The converted <see cref="Long"/></returns>
        public static Long ToJVM(long clrValue)
        {
            return ValueOf(clrValue);
        }

        /// <summary>
        /// Converter from <see cref="Long"/> to <see cref="long"/>
        /// </summary>
        public static implicit operator long(Long b) => b != null ? b.LongValue() : default;
        /// <summary>
        /// Converter from <see cref="Long"/> to <see cref="Nullable{Int64}"/>
        /// </summary>
        public static implicit operator long?(Long b) => b != null ? b.LongValue() : null;
        /// <summary>
        /// Converter from <see cref="long"/> to <see cref="Long"/>
        /// </summary>
        public static implicit operator Long(long b) => ValueOf(b);
        /// <summary>
        /// Converter from <see cref="Nullable{Int64}"/> to <see cref="Long"/>
        /// </summary>
        public static implicit operator Long(long? b) => b.HasValue ? ValueOf(b.Value) : null;
    }
}
