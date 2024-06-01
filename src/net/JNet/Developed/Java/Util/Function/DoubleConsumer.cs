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
            AddEventHandler("accept", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(AcceptEventHandler)); OnAccept = Accept;
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
}
