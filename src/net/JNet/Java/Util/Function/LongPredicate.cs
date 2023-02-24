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

using MASES.JCOBridge.C2JBridge;
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java LongPredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongPredicate.html"/>. Extends <see cref="Predicate{Int64}"/>
    /// </summary>
    public interface ILongPredicate : IPredicate<long>
    {
    }

    /// <summary>
    /// Listener for Java LongPredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongPredicate.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class LongPredicate : Predicate<long>, ILongPredicate
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetLongPredicate";

        /// <inheritdoc cref="Predicate{Int64}"/>
        /// <param name="func">The <see cref="Func{Int64, Boolean}"/> to be executed</param>
        public LongPredicate(Func<long, bool> func = null) : base(func) { }
    }
}
