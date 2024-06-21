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
using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java DoubleConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleConsumer.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IDoubleConsumer : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the DoubleConsumer action in the CLR
        /// </summary>
        /// <param name="obj">The DoubleConsumer object</param>
        void Accept(double obj);
    }

    /// <summary>
    /// Listener for Java DoubleConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleConsumer.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class DoubleConsumer : JVMBridgeListener, IDoubleConsumer
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.DoubleConsumer";

        /// <summary>
        /// The <see cref="Action{Double}"/> to be executed
        /// </summary>
        public virtual Action<double> OnAccept { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleConsumer"/>
        /// </summary>
        public DoubleConsumer()
        {
            if (InitHandlers)
            {
                AddEventHandler("accept", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(AcceptEventHandler)); OnAccept = Accept;
            }
        }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            OnAccept(data.EventData.TypedEventData);
        }
        /// <summary>
        /// Executes the DoubleConsumer action in the CLR
        /// </summary>
        /// <param name="obj">The DoubleConsumer object</param>
        public virtual void Accept(double obj) { }
    }

    /// <summary>
    /// Direct override of <see cref="DoubleConsumer"/> or its generic type if there is one
    /// </summary>
    public partial class DoubleConsumerDirect : DoubleConsumer
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.DoubleConsumer";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleConsumer.html#accept(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        public override void Accept(double arg0)
        {
            IExecuteWithSignature("accept", "(D)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleConsumer.html#andThen(java.util.function.DoubleConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleConsumer"/></returns>
        public Java.Util.Function.DoubleConsumer AndThen(Java.Util.Function.DoubleConsumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoubleConsumerDirect, Java.Util.Function.DoubleConsumer>("andThen", "(Ljava/util/function/DoubleConsumer;)Ljava/util/function/DoubleConsumer;", arg0);
        }
    }
}
