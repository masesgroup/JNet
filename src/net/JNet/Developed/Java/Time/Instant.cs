﻿/*
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

namespace Java.Time
{
    public partial class Instant
    {
        // can be extended with methods not reflected or not available in Java; add a single method related to DateTime of .NET: Instant and DateTime are similar

        /// <summary>
        /// Converter from <see cref="System.DateTime"/> to <see cref="Instant"/>
        /// </summary>
        public static implicit operator Instant(System.DateTime dt)
        {
            var milli = new System.DateTimeOffset(dt).ToUnixTimeMilliseconds();
            return SExecute<Instant>("ofEpochMilli", milli);
        }
    }
}
