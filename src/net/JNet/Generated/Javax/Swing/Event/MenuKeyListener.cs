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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region IMenuKeyListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.MenuKeyListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html"/>
    /// </summary>
    public partial interface IMenuKeyListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyPressed(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyEvent"/></param>
        void MenuKeyPressed(Javax.Swing.Event.MenuKeyEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyReleased(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyEvent"/></param>
        void MenuKeyReleased(Javax.Swing.Event.MenuKeyEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyTyped(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyEvent"/></param>
        void MenuKeyTyped(Javax.Swing.Event.MenuKeyEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region MenuKeyListener
    public partial class MenuKeyListener : Javax.Swing.Event.IMenuKeyListener
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
        /// Handlers initializer for <see cref="MenuKeyListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("menuKeyPressed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuKeyEvent>>>(MenuKeyPressedEventHandler));
            AddEventHandler("menuKeyReleased", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuKeyEvent>>>(MenuKeyReleasedEventHandler));
            AddEventHandler("menuKeyTyped", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuKeyEvent>>>(MenuKeyTypedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyPressed(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuKeyPressed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.MenuKeyEvent> OnMenuKeyPressed { get; set; } = null;

        void MenuKeyPressedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuKeyEvent>> data)
        {
            var methodToExecute = (OnMenuKeyPressed != null) ? OnMenuKeyPressed : MenuKeyPressed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyPressed(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyEvent"/></param>
        public virtual void MenuKeyPressed(Javax.Swing.Event.MenuKeyEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyReleased(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuKeyReleased"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.MenuKeyEvent> OnMenuKeyReleased { get; set; } = null;

        void MenuKeyReleasedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuKeyEvent>> data)
        {
            var methodToExecute = (OnMenuKeyReleased != null) ? OnMenuKeyReleased : MenuKeyReleased;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyReleased(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyEvent"/></param>
        public virtual void MenuKeyReleased(Javax.Swing.Event.MenuKeyEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyTyped(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnMenuKeyTyped"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.MenuKeyEvent> OnMenuKeyTyped { get; set; } = null;

        void MenuKeyTypedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.MenuKeyEvent>> data)
        {
            var methodToExecute = (OnMenuKeyTyped != null) ? OnMenuKeyTyped : MenuKeyTyped;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MenuKeyListener.html#menuKeyTyped(javax.swing.event.MenuKeyEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.MenuKeyEvent"/></param>
        public virtual void MenuKeyTyped(Javax.Swing.Event.MenuKeyEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}