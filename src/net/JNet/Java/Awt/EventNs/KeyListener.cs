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

namespace Java.Awt.EventNs
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html"/>
    /// </summary>
    public interface IKeyListener : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyTyped(java.awt.event.KeyEvent)"/>
        /// </summary>
        void KeyTyped(KeyEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyPressed(java.awt.event.KeyEvent)"/>
        /// </summary>
        void KeyPressed(KeyEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyReleased(java.awt.event.KeyEvent)"/>
        /// </summary>
        void KeyReleased(KeyEvent e);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html"/>. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IKeyListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class KeyListener : IKeyListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetKeyListener";

        readonly Action<KeyEvent> KeyTypedFunction = null;
        readonly Action<KeyEvent> KeyPressedFunction = null;
        readonly Action<KeyEvent> KeyReleasedFunction = null;
        /// <summary>
        /// The <see cref="Action{KeyEvent}"/> to be executed on KeyTyped
        /// </summary>
        public virtual Action<KeyEvent> OnKeyTyped { get { return KeyTypedFunction; } }
        /// <summary>
        /// The <see cref="Action{KeyEvent}"/> to be executed on KeyPressed
        /// </summary>
        public virtual Action<KeyEvent> OnKeyPressed { get { return KeyPressedFunction; } }
        /// <summary>
        /// The <see cref="Action{KeyEvent}"/> to be executed on KeyReleased
        /// </summary>
        public virtual Action<KeyEvent> OnKeyReleased { get { return KeyReleasedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="KeyListener"/>
        /// </summary>
        /// <param name="keyTyped">The <see cref="Action{KeyEvent}"/> to be executed on KeyTyped</param>
        /// <param name="keyPressed">The <see cref="Action{KeyEvent}"/> to be executed on KeyPressed</param>
        /// <param name="keyReleased">The <see cref="Action{KeyEvent}"/> to be executed on KeyReleased</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public KeyListener(Action<KeyEvent> keyTyped = null,
                           Action<KeyEvent> keyPressed = null,
                           Action<KeyEvent> keyReleased = null,
                           bool attachEventHandler = true)
        {
            if (keyTyped != null) KeyTypedFunction = keyTyped;
            else KeyTypedFunction = KeyTyped;
            if (keyPressed != null) KeyPressedFunction = keyPressed;
            else KeyPressedFunction = KeyPressed;
            if (keyReleased != null) KeyReleasedFunction = keyReleased;
            else KeyReleasedFunction = KeyReleased;

            if (attachEventHandler)
            {
                AddEventHandler("keyTyped", new EventHandler<CLRListenerEventArgs<CLREventData<KeyEvent>>>(EventHandlerKeyTyped));
                AddEventHandler("keyPressed", new EventHandler<CLRListenerEventArgs<CLREventData<KeyEvent>>>(EventHandlerKeyPressed));
                AddEventHandler("keyReleased", new EventHandler<CLRListenerEventArgs<CLREventData<KeyEvent>>>(EventHandlerKeyReleased));
            }
        }

        void EventHandlerKeyTyped(object sender, CLRListenerEventArgs<CLREventData<KeyEvent>> data)
        {
            OnKeyTyped(data.EventData.TypedEventData);
        }

        void EventHandlerKeyPressed(object sender, CLRListenerEventArgs<CLREventData<KeyEvent>> data)
        {
            OnKeyPressed(data.EventData.TypedEventData);
        }

        void EventHandlerKeyReleased(object sender, CLRListenerEventArgs<CLREventData<KeyEvent>> data)
        {
            OnKeyReleased(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="IKeyListener.KeyTyped(KeyEvent)"/>
        public virtual void KeyTyped(KeyEvent e)
        {

        }
        /// <inheritdoc cref="IKeyListener.KeyPressed(KeyEvent)"/>
        public virtual void KeyPressed(KeyEvent e)
        {

        }
        /// <inheritdoc cref="IKeyListener.KeyReleased(KeyEvent)"/>
        public virtual void KeyReleased(KeyEvent e)
        {
            
        }
    }
}
