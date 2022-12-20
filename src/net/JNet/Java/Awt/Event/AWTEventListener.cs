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

namespace Java.Awt.Event
{
    public interface IAWTEventListener : IJVMBridgeBase
    {
        void EventDispatched(AWTEvent e);
    }

    /// <summary>
    /// Listener for AWTEventListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IAWTEventListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public class AWTEventListener : JVMBridgeListener, IAWTEventListener
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetAWTEventListener";

        readonly Action<AWTEvent> eventDispatchedFunction = null;
        /// <summary>
        /// The <see cref="Action{AWTEvent}"/> to be executed on EventDispatched
        /// </summary>
        public virtual Action<AWTEvent> OnEventDispatched { get { return eventDispatchedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="AWTEventListener"/>
        /// </summary>
        /// <param name="eventDispatched">The <see cref="Action{AWTEvent}"/> to be executed on EventDispatched</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public AWTEventListener(Action<AWTEvent> eventDispatched = null, bool attachEventHandler = true)
        {
            if (eventDispatched != null) eventDispatchedFunction = eventDispatched;
            else eventDispatchedFunction = EventDispatched;

            if (attachEventHandler)
            {
                AddEventHandler("eventDispatched", new EventHandler<CLRListenerEventArgs<CLREventData<AWTEvent>>>(EventHandlerEventDispatched));
            }
        }

        void EventHandlerEventDispatched(object sender, CLRListenerEventArgs<CLREventData<AWTEvent>> data)
        {
            OnEventDispatched(data.EventData.TypedEventData);
        }

        public virtual void EventDispatched(AWTEvent e)
        {

        }
    }
}
