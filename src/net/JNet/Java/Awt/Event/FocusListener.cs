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

namespace Java.Awt.Event
{
    public interface IFocusListener : IJVMBridgeBase
    {
        void FocusGained(FocusEvent e);

        void FocusLost(FocusEvent e);
    }

    /// <summary>
    /// Listener for FocusListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IFocusListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public class FocusListener : JVMBridgeListener, IFocusListener
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetFocusListener";

        readonly Action<FocusEvent> focusGainedFunction = null;
        readonly Action<FocusEvent> focusLostFunction = null;
        /// <summary>
        /// The <see cref="Action{FocusEvent}"/> to be executed on ComponentResized
        /// </summary>
        public virtual Action<FocusEvent> OnFocusGained { get { return focusGainedFunction; } }
        /// <summary>
        /// The <see cref="Action{FocusEvent}"/> to be executed on ComponentMoved
        /// </summary>
        public virtual Action<FocusEvent> OnFocusLost { get { return focusLostFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="FocusListener"/>
        /// </summary>
        /// <param name="focusGained">The <see cref="Action{FocusEvent}"/> to be executed on FocusGained</param>
        /// <param name="focusLost">The <see cref="Action{FocusEvent}"/> to be executed on FocusLost</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public FocusListener(Action<FocusEvent> focusGained = null,
                             Action<FocusEvent> focusLost = null,
                             bool attachEventHandler = true)
        {
            if (focusGained != null) focusGainedFunction = focusGained;
            else focusGainedFunction = FocusGained;
            if (focusLost != null) focusLostFunction = focusLost;
            else focusLostFunction = FocusLost;

            if (attachEventHandler)
            {
                AddEventHandler("focusGained", new EventHandler<CLRListenerEventArgs<CLREventData<FocusEvent>>>(EventHandlerFocusGained));
                AddEventHandler("focusLost", new EventHandler<CLRListenerEventArgs<CLREventData<FocusEvent>>>(EventHandlerFocusLost));
            }
        }

        void EventHandlerFocusGained(object sender, CLRListenerEventArgs<CLREventData<FocusEvent>> data)
        {
            OnFocusGained(data.EventData.TypedEventData);
        }

        void EventHandlerFocusLost(object sender, CLRListenerEventArgs<CLREventData<FocusEvent>> data)
        {
            OnFocusLost(data.EventData.TypedEventData);
        }

        public virtual void FocusGained(FocusEvent e)
        {

        }

        public virtual void FocusLost(FocusEvent e)
        {

        }
    }
}
