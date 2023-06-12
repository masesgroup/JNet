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

namespace Javax.Swing.Event
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ChangeListener.html"/>
    /// </summary>
    public partial interface IChangeListener : IJVMBridgeBase
    {

    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/ChangeListener.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>, implements <see cref="IChangeListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class ChangeListener : IChangeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.swing.event.JNetChangeListener";

        readonly Action<ChangeEvent> StateChangedFunction = null;
        /// <summary>
        /// The <see cref="Action{ChangeEvent}"/> to be executed on StateChanged
        /// </summary>
        public virtual Action<ChangeEvent> OnStateChanged { get { return StateChangedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="ChangeListener"/>
        /// </summary>
        /// <param name="stateChanged">The <see cref="Action{ChangeEvent}"/> to be executed on StateChanged</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public ChangeListener(Action<ChangeEvent> stateChanged = null, bool attachEventHandler = true)
        {
            if (stateChanged != null) StateChangedFunction = stateChanged;
            else StateChangedFunction = StateChanged;

            if (attachEventHandler)
            {
                AddEventHandler("stateChanged", new EventHandler<CLRListenerEventArgs<CLREventData<ChangeEvent>>>(EventHandlerStateChanged));
            }
        }

        void EventHandlerStateChanged(object sender, CLRListenerEventArgs<CLREventData<ChangeEvent>> data)
        {
            OnStateChanged(data.EventData.TypedEventData);
        }
    }
}
