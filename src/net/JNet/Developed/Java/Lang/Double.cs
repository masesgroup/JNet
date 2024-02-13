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
using System;

namespace Java.Lang
{
    public partial class Double //: Number
    {
        /// <summary>
        /// Converter from <see cref="Double"/> to <see cref="double"/>
        /// </summary>
        public static implicit operator double(Double b) => b != null ? b.DoubleValue() : default;
        /// <summary>
        /// Converter from <see cref="Double"/> to <see cref="Nullable{Double}"/>
        /// </summary>
        public static implicit operator double?(Double b) => b != null ? b.DoubleValue() : null;
        /// <summary>
        /// Converter from <see cref="double"/> to <see cref="Boolean"/>
        /// </summary>
        public static implicit operator Double(double b) => ValueOf(b);
        /// <summary>
        /// Converter from <see cref="Nullable{Double}"/> to <see cref="Boolean"/>
        /// </summary>
        public static implicit operator Double(double? b) => b.HasValue ? ValueOf(b.Value) : null;
    }
}
