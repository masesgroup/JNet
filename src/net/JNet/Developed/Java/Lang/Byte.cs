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
    public partial class Byte : INativeConvertible<Byte, byte>
    {
        byte INativeConvertible<Byte, byte>.ToCLR()
        {
            return ByteValue();
        }
        /// <summary>
        /// Returns the <see cref="Byte"/> from the <paramref name="clrValue"/> instance
        /// </summary>
        /// <param name="clrValue">The <see cref="byte"/> of CLR</param>
        /// <returns>The converted <see cref="Byte"/></returns>
        public static Byte ToJVM(byte clrValue)
        {
            return ValueOf(clrValue);
        }

        /// <summary>
        /// Converter from <see cref="Byte"/> to <see cref="byte"/>
        /// </summary>
        public static implicit operator byte(Byte b) => b != null ? b.ByteValue() : default;
        /// <summary>
        /// Converter from <see cref="Byte"/> to <see cref="Nullable{Byte}"/>
        /// </summary>
        public static implicit operator byte?(Byte b) => b != null ? b.ByteValue() : null;
        /// <summary>
        /// Converter from <see cref="byte"/> to <see cref="Byte"/>
        /// </summary>
        public static implicit operator Byte(byte b) => ValueOf(b);
        /// <summary>
        /// Converter from <see cref="Nullable{Byte}"/> to <see cref="Byte"/>
        /// </summary>
        public static implicit operator Byte(byte? b) => b.HasValue ? ValueOf(b.Value) : null;
    }
}
