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
    public interface IActionListener : IJVMBridgeBase
    {
        void ActionPerformed(ActionEvent e);
    }

    /// <summary>
    /// Listener for ActionListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IActionListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public class ActionListener : JVMBridgeListener, IActionListener
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetActionListener";

        readonly Action<ActionEvent> actionPerformedFunction = null;
        /// <summary>
        /// The <see cref="Action{ActionEvent}"/> to be executed on ActionPerformed
        /// </summary>
        public virtual Action<ActionEvent> OnActionPerformed { get { return actionPerformedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="ActionListener"/>
        /// </summary>
        /// <param name="actionPerformed">The <see cref="Action{ActionEvent}"/> to be executed on ActionPerformed</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public ActionListener(Action<ActionEvent> actionPerformed = null, bool attachEventHandler = true)
        {
            if (actionPerformed != null) actionPerformedFunction = actionPerformed;
            else actionPerformedFunction = ActionPerformed;

            if (attachEventHandler)
            {
                AddEventHandler("actionPerformed", new EventHandler<CLRListenerEventArgs<CLREventData<ActionEvent>>>(EventHandlerActionPerformed));
            }
        }

        void EventHandlerActionPerformed(object sender, CLRListenerEventArgs<CLREventData<ActionEvent>> data)
        {
            OnActionPerformed(data.EventData.TypedEventData);
        }

        public virtual void ActionPerformed(ActionEvent e)
        {

        }
    }
}
