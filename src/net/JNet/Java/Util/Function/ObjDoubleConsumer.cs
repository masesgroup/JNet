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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjDoubleConsumer.html"/>. Extends <see cref="BiConsumer{T, Double}"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public interface IObjDoubleConsumer<T> : IBiConsumer<T, double>
    {
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjDoubleConsumer.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public abstract class ObjDoubleConsumer : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "org.mases.jnet.util.function.JNetObjDoubleConsumer";
    }

    /// <summary>
    /// Listener for Java ObjDoubleConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjDoubleConsumer.html"/>. Extends <see cref="ObjDoubleConsumer"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public class ObjDoubleConsumer<T> : ObjDoubleConsumer, IObjDoubleConsumer<T>
    {
        Action<T, double> executionFunction = null;
        /// <summary>
        /// The <see cref="Action{T, U}"/> to be executed
        /// </summary>
        public virtual Action<T, double> OnAccept { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="BiConsumer{T, U}"/>
        /// </summary>
        /// <param name="action">The <see cref="Action{T, U}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public ObjDoubleConsumer(Action<T, double> action = null, bool attachEventHandler = true)
        {
            if (action != null) executionFunction = action;
            else executionFunction = Accept;

            if (attachEventHandler)
            {
                AddEventHandler("accept", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            OnAccept(data.EventData.TypedEventData, data.EventData.To<double>(0));
        }
        /// <summary>
        /// Executes the Consumer action in the CLR
        /// </summary>
        /// <param name="o1">The Consumer object</param>
        /// <param name="o2">The Consumer object</param>
        public virtual void Accept(T o1, double o2) { }
    }
}
