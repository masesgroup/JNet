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
    public interface ITextListener : IJVMBridgeBase
    {
        void TextValueChanged(TextEvent e);
    }

    /// <summary>
    /// Listener for TextListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="ITextListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public class TextListener : JVMBridgeListener, ITextListener
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetTextListener";

        readonly Action<TextEvent> textValueChangedFunction = null;
        /// <summary>
        /// The <see cref="Action{TextEvent}"/> to be executed on TextValueChanged
        /// </summary>
        public virtual Action<TextEvent> OnTextValueChanged { get { return textValueChangedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="TextListener"/>
        /// </summary>
        /// <param name="textValueChanged">The <see cref="Action{TextEvent}"/> to be executed on TextValueChanged</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public TextListener(Action<TextEvent> textValueChanged = null, bool attachEventHandler = true)
        {
            if (textValueChanged != null) textValueChangedFunction = textValueChanged;
            else textValueChangedFunction = TextValueChanged;

            if (attachEventHandler)
            {
                AddEventHandler("textValueChanged", new EventHandler<CLRListenerEventArgs<CLREventData<TextEvent>>>(EventHandlerTextValueChanged));
            }
        }

        void EventHandlerTextValueChanged(object sender, CLRListenerEventArgs<CLREventData<TextEvent>> data)
        {
            OnTextValueChanged(data.EventData.TypedEventData);
        }

        public virtual void TextValueChanged(TextEvent e)
        {

        }
    }
}
