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

using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java IntConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntConsumer.html"/>. Extends <see cref="Consumer{Int32}"/>
    /// </summary>
    public interface IIntConsumer : IConsumer<int>
    {
    }

    /// <summary>
    /// Listener for Java IntConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntConsumer.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class IntConsumer : Consumer<int>, IIntConsumer
    {
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.IntConsumer";
    }

    /// <summary>
    /// Direct override of <see cref="IntConsumer"/> or its generic type if there is one
    /// </summary>
    public partial class IntConsumerDirect : IntConsumer
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.IntConsumer";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#accept(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public override void Accept(int arg0)
        {
            IExecuteWithSignature("accept", "(I)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntConsumer.html#andThen(java.util.function.IntConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.IntConsumer"/></returns>
        public Java.Util.Function.IntConsumer AndThen(Java.Util.Function.IntConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.IntConsumerDirect, Java.Util.Function.IntConsumer>("andThen", "(Ljava/util/function/IntConsumer;)Ljava/util/function/IntConsumer;", arg0);
        }
    }
}
