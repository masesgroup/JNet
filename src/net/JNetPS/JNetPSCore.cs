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

using MASES.JNet;
using System;

namespace MASES.JNetPS
{
    /// <summary>
    /// Concrete implementation of <see cref="JNetCore{T}"/>
    /// </summary>
    public class JNetPSCore : JNetCore<JNetPSCore>
    {
#if NET6_0_OR_GREATER
        public static void Main(string[] args) { } // used in conjunction with project of executable type to produce artifacts with all needed assemblies
#endif
    }
}