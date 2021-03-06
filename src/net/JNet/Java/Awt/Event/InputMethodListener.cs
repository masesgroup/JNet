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
    public interface IInputMethodListener : IJVMBridgeBase
    {
        void InputMethodTextChanged(InputMethodEvent e);

        void CaretPositionChanged(InputMethodEvent e);
    }

    /// <summary>
    /// Listener for InputMethodListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IInputMethodListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public class InputMethodListener : JVMBridgeListener, IInputMethodListener
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetInputMethodListener";

        readonly Action<InputMethodEvent> inputMethodTextChangedFunction = null;
        readonly Action<InputMethodEvent> caretPositionChangedFunction = null;
        /// <summary>
        /// The <see cref="Action{InputMethodEvent}"/> to be executed on InputMethodTextChanged
        /// </summary>
        public virtual Action<InputMethodEvent> OnInputMethodTextChanged { get { return inputMethodTextChangedFunction; } }
        /// <summary>
        /// The <see cref="Action{InputMethodEvent}"/> to be executed on CaretPositionChanged
        /// </summary>
        public virtual Action<InputMethodEvent> OnCaretPositionChanged { get { return caretPositionChangedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="InputMethodListener"/>
        /// </summary>
        /// <param name="inputMethodTextChanged">The <see cref="Action{InputMethodEvent}"/> to be executed on InputMethodTextChanged</param>
        /// <param name="caretPositionChanged">The <see cref="Action{InputMethodEvent}"/> to be executed on CaretPositionChanged</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public InputMethodListener(Action<InputMethodEvent> inputMethodTextChanged = null,
                                   Action<InputMethodEvent> caretPositionChanged = null,
                                   bool attachEventHandler = true)
        {
            if (inputMethodTextChanged != null) inputMethodTextChangedFunction = inputMethodTextChanged;
            else inputMethodTextChangedFunction = InputMethodTextChanged;
            if (caretPositionChanged != null) caretPositionChangedFunction = caretPositionChanged;
            else caretPositionChangedFunction = CaretPositionChanged;

            if (attachEventHandler)
            {
                AddEventHandler("inputMethodTextChanged", new EventHandler<CLRListenerEventArgs<CLREventData<InputMethodEvent>>>(EventHandlerInputMethodTextChanged));
                AddEventHandler("caretPositionChanged", new EventHandler<CLRListenerEventArgs<CLREventData<InputMethodEvent>>>(EventHandlerCaretPositionChanged));
            }
        }

        void EventHandlerInputMethodTextChanged(object sender, CLRListenerEventArgs<CLREventData<InputMethodEvent>> data)
        {
            OnInputMethodTextChanged(data.EventData.TypedEventData);
        }

        void EventHandlerCaretPositionChanged(object sender, CLRListenerEventArgs<CLREventData<InputMethodEvent>> data)
        {
            OnCaretPositionChanged(data.EventData.TypedEventData);
        }

        public void InputMethodTextChanged(InputMethodEvent e)
        {

        }

        public void CaretPositionChanged(InputMethodEvent e)
        {

        }
    }
}
