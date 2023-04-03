﻿/*
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

using Java.Util;
using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    public partial class ObjectName
    {
        // can be extended with methods not reflected or not available in Java;

        /// <summary>
        /// Converter from <see cref="ObjectName"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static explicit operator Java.Lang.Comparable<ObjectName>(ObjectName o) => o.Cast<Java.Lang.Comparable<ObjectName>>();

    }
}
