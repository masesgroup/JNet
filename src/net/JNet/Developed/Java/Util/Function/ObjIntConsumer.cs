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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjIntConsumer.html"/>. Extends <see cref="BiConsumer{T, Int32}"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public interface IObjIntConsumer<T> : IBiConsumer<T, int>
    {
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjIntConsumer.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class ObjIntConsumer : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetObjIntConsumer";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjIntConsumer.html"/>. Extends <see cref="ObjIntConsumer"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public class ObjIntConsumer<T> : ObjIntConsumer, IObjIntConsumer<T>
    {
        /// <summary>
        /// The <see cref="Action{T, U}"/> to be executed
        /// </summary>
        public virtual Action<T, int> OnAccept { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="BiConsumer{T, U}"/>
        /// </summary>
        public ObjIntConsumer()
        {
            AddEventHandler("accept", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(AcceptEventHandler)); OnAccept = Accept;
        }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            OnAccept(data.EventData.TypedEventData, data.EventData.To<int>(0));
        }
        /// <summary>
        /// Executes the Consumer action in the CLR
        /// </summary>
        /// <param name="o1">The Consumer object</param>
        /// <param name="o2">The Consumer object</param>
        public virtual void Accept(T o1, int o2) { }
    }
}
