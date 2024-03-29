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

namespace MASES.JNet.Specific.Extensions
{
    /// <summary>
    /// Extension class
    /// </summary>
    public static class JNetCoreExtensions
    {
        /// <summary>
        /// Retrieve the <see cref="Java.Lang.Class{TClass}"/> from the <typeparamref name="TClass"/>
        /// </summary>
        /// <typeparam name="TClass">A class extending <see cref="IJVMBridgeBase"/></typeparam>
        /// <returns>The <see cref="Java.Lang.Class{TClass}"/></returns>
        public static Java.Lang.Class<TClass> Class<TClass>(this TClass _) where TClass : IJVMBridgeBase, new()
        {
            return Java.Lang.Class.Of<TClass>();
        }
    }
}
