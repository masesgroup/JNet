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

namespace Javax.Naming.Event
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html"/>
    /// </summary>
    public interface INamingListener : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/NamingListener.html#namingExceptionThrown(javax.naming.event.NamingExceptionEvent)"/>
        /// </summary>
        void NamingExceptionThrown(NamingExceptionEvent evt);
    }

    /// <summary>
    /// Listener for NamingListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="INamingListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class NamingListener : INamingListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "org.mases.jnet.naming.event.JNetNamingListener";

        readonly Action<NamingExceptionEvent> NamingExceptionThrownFunction = null;
        /// <summary>
        /// The <see cref="Action{NamingExceptionEvent}"/> to be executed on NamingExceptionThrown
        /// </summary>
        public virtual Action<NamingExceptionEvent> OnNamingExceptionThrown { get { return NamingExceptionThrownFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="NamingListener"/>
        /// </summary>
        /// <param name="namingExceptionThrown">The <see cref="Action{NamingExceptionEvent}"/> to be executed on NamingExceptionThrown</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public NamingListener(Action<NamingExceptionEvent> namingExceptionThrown = null, bool attachEventHandler = true)
        {
            if (namingExceptionThrown != null) NamingExceptionThrownFunction = namingExceptionThrown;
            else NamingExceptionThrownFunction = NamingExceptionThrown;

            if (attachEventHandler)
            {
                AddEventHandler("namingExceptionThrown", new EventHandler<CLRListenerEventArgs<CLREventData<NamingExceptionEvent>>>(EventHandlerNamingExceptionThrown));
            }
        }

        void EventHandlerNamingExceptionThrown(object sender, CLRListenerEventArgs<CLREventData<NamingExceptionEvent>> data)
        {
            OnNamingExceptionThrown(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="INamingListener.NamingExceptionThrown(NamingExceptionEvent)"/>
        public virtual void NamingExceptionThrown(NamingExceptionEvent evt)
        {

        }
    }
}
