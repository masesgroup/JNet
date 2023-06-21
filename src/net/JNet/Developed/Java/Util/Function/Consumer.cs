/*
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
    /// Listener for Java Consumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Consumer.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public interface IConsumer<TObject> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Consumer action in the CLR
        /// </summary>
        /// <param name="obj">The Consumer object</param>
        void Accept(TObject obj);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Consumer.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class Consumer : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetConsumer";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Consumer.html"/>. Extends <see cref="Consumer"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public class Consumer<TObject> : Consumer, IConsumer<TObject>
    {
        /// <summary>
        /// The <see cref="Action{TObject}"/> to be executed
        /// </summary>
        public virtual Action<TObject> OnAccept { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Consumer{TObject}"/>
        /// </summary>
        public Consumer()
        {
            AddEventHandler("accept", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(AcceptEventHandler)); OnAccept = Accept;
        }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            OnAccept(data.EventData.TypedEventData);
        }
        /// <summary>
        /// Executes the Consumer action in the CLR
        /// </summary>
        /// <param name="obj">The Consumer object</param>
        public virtual void Accept(TObject obj) { }
    }
}
