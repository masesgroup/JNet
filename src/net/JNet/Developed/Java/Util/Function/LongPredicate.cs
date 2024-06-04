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
using MASES.JCOBridge.C2JBridge.JVMInterop;
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
    /// Listener for Java LongPredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongPredicate.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class LongPredicate : Predicate<long>, ILongPredicate
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.LongPredicate";
    }

    /// <summary>
    /// Direct override of <see cref="LongPredicate"/> or its generic type if there is one
    /// </summary>
    public partial class LongPredicateDirect : LongPredicate
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.LongPredicate";
        private static readonly IJavaType LocalBridgeClazz = ClazzOf(_bridgeClassName);

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#test(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(long arg0)
        {
            return IExecuteWithSignature<bool>("test", "(J)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#and(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public Java.Util.Function.LongPredicate And(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicateDirect, Java.Util.Function.LongPredicate>("and", "(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public Java.Util.Function.LongPredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicateDirect, Java.Util.Function.LongPredicate>("negate", "()Ljava/util/function/LongPredicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongPredicate.html#or(java.util.function.LongPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.LongPredicate"/></returns>
        public Java.Util.Function.LongPredicate Or(Java.Util.Function.LongPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongPredicateDirect, Java.Util.Function.LongPredicate>("or", "(Ljava/util/function/LongPredicate;)Ljava/util/function/LongPredicate;", arg0);
        }
    }
}
