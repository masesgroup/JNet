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

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/javax/management/ReflectionException.html"/>
    /// </summary>
    public partial class ReflectionException
    {
        // can be extended with methods not reflected or not available in Java;

        /// <summary>
        /// Return the actual <see cref="Java.Lang.Exception"/> thrown.
        /// </summary>
        public Java.Lang.Exception TargetException => IExecute<Java.Lang.Exception>("getTargetException");
    }
}
