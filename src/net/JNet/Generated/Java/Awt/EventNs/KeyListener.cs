/*
*  Copyright 2024 MASES s.r.l.
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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region IKeyListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.KeyListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html"/>
    /// </summary>
    public partial interface IKeyListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyPressed(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        void KeyPressed(Java.Awt.EventNs.KeyEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyReleased(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        void KeyReleased(Java.Awt.EventNs.KeyEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyTyped(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        void KeyTyped(Java.Awt.EventNs.KeyEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region KeyListener
    public partial class KeyListener : Java.Awt.EventNs.IKeyListener
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="KeyListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("keyPressed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>>>(KeyPressedEventHandler));
            AddEventHandler("keyReleased", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>>>(KeyReleasedEventHandler));
            AddEventHandler("keyTyped", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>>>(KeyTypedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyPressed(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnKeyPressed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.KeyEvent> OnKeyPressed { get; set; } = null;

        void KeyPressedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>> data)
        {
            var methodToExecute = (OnKeyPressed != null) ? OnKeyPressed : KeyPressed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyPressed(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public virtual void KeyPressed(Java.Awt.EventNs.KeyEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyReleased(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnKeyReleased"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.KeyEvent> OnKeyReleased { get; set; } = null;

        void KeyReleasedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>> data)
        {
            var methodToExecute = (OnKeyReleased != null) ? OnKeyReleased : KeyReleased;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyReleased(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public virtual void KeyReleased(Java.Awt.EventNs.KeyEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyTyped(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnKeyTyped"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.KeyEvent> OnKeyTyped { get; set; } = null;

        void KeyTypedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.KeyEvent>> data)
        {
            var methodToExecute = (OnKeyTyped != null) ? OnKeyTyped : KeyTyped;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/KeyListener.html#keyTyped(java.awt.event.KeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.KeyEvent"/></param>
        public virtual void KeyTyped(Java.Awt.EventNs.KeyEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}