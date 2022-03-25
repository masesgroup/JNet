/*
*  Copyright 2022 MASES s.r.l.
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
    /// Listener for Java DoubleConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleConsumer.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class DoubleConsumer : JVMBridgeListener, IDoubleConsumer
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName=> "org.mases.jnet.util.function.JNetDoubleConsumer";

        Action<double> executionFunction = null;
        /// <summary>
        /// The <see cref="Action{Double}"/> to be executed
        /// </summary>
        public virtual Action<double> OnAccept { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleConsumer"/>
        /// </summary>
        /// <param name="action">The <see cref="Action{Double}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public DoubleConsumer(Action<double> action = null, bool attachEventHandler = true)
        {
            if (action != null) executionFunction = action;
            else executionFunction = Accept;

            if (attachEventHandler)
            {
                AddEventHandler("accept", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
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
