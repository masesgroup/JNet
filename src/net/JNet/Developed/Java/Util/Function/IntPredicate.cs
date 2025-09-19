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

using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java IntPredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntPredicate.html"/>. Extends <see cref="Predicate{Int32}"/>
    /// </summary>
    public interface IIntPredicate : IPredicate<int>
    {
    }

    /// <summary>
    /// Listener for Java IntPredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntPredicate.html"/>. Extends <see cref="Predicate{Int32}"/>
    /// </summary>
    public class IntPredicate : Predicate<int>, IIntPredicate
    {
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.IntPredicate";
    }

    /// <summary>
    /// Direct override of <see cref="IntPredicate"/> or its generic type if there is one
    /// </summary>
    public partial class IntPredicateDirect : IntPredicate
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.IntPredicate";
        private static readonly global::System.Exception _LocalBridgeClazzException = null;
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName, out _LocalBridgeClazzException, false);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw _LocalBridgeClazzException ?? new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <inheritdoc />
        public override string BridgeClassName => _bridgeClassName;
        /// <inheritdoc />
        public override bool IsBridgeAbstract => true;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#test(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(int arg0)
        {
            return IExecuteWithSignature<bool>("test", "(I)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#and(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public Java.Util.Function.IntPredicate And(Java.Util.Function.IntPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicateDirect, Java.Util.Function.IntPredicate>("and", "(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public Java.Util.Function.IntPredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicateDirect, Java.Util.Function.IntPredicate>("negate", "()Ljava/util/function/IntPredicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntPredicate.html#or(java.util.function.IntPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.IntPredicate"/></returns>
        public Java.Util.Function.IntPredicate Or(Java.Util.Function.IntPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntPredicateDirect, Java.Util.Function.IntPredicate>("or", "(Ljava/util/function/IntPredicate;)Ljava/util/function/IntPredicate;", arg0);
        }
    }
}
