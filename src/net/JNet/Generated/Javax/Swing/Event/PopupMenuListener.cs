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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region IPopupMenuListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.PopupMenuListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html"/>
    /// </summary>
    public partial interface IPopupMenuListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuCanceled(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        void PopupMenuCanceled(Javax.Swing.Event.PopupMenuEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeInvisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        void PopupMenuWillBecomeInvisible(Javax.Swing.Event.PopupMenuEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeVisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        void PopupMenuWillBecomeVisible(Javax.Swing.Event.PopupMenuEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PopupMenuListener
    public partial class PopupMenuListener : Javax.Swing.Event.IPopupMenuListener
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
        /// Handlers initializer for <see cref="PopupMenuListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("popupMenuCanceled", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.PopupMenuEvent>>>(PopupMenuCanceledEventHandler));
            AddEventHandler("popupMenuWillBecomeInvisible", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.PopupMenuEvent>>>(PopupMenuWillBecomeInvisibleEventHandler));
            AddEventHandler("popupMenuWillBecomeVisible", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.PopupMenuEvent>>>(PopupMenuWillBecomeVisibleEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuCanceled(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPopupMenuCanceled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.PopupMenuEvent> OnPopupMenuCanceled { get; set; } = null;

        void PopupMenuCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.PopupMenuEvent>> data)
        {
            var methodToExecute = (OnPopupMenuCanceled != null) ? OnPopupMenuCanceled : PopupMenuCanceled;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuCanceled(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public virtual void PopupMenuCanceled(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeInvisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPopupMenuWillBecomeInvisible"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.PopupMenuEvent> OnPopupMenuWillBecomeInvisible { get; set; } = null;

        void PopupMenuWillBecomeInvisibleEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.PopupMenuEvent>> data)
        {
            var methodToExecute = (OnPopupMenuWillBecomeInvisible != null) ? OnPopupMenuWillBecomeInvisible : PopupMenuWillBecomeInvisible;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeInvisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public virtual void PopupMenuWillBecomeInvisible(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeVisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPopupMenuWillBecomeVisible"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.PopupMenuEvent> OnPopupMenuWillBecomeVisible { get; set; } = null;

        void PopupMenuWillBecomeVisibleEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.PopupMenuEvent>> data)
        {
            var methodToExecute = (OnPopupMenuWillBecomeVisible != null) ? OnPopupMenuWillBecomeVisible : PopupMenuWillBecomeVisible;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/PopupMenuListener.html#popupMenuWillBecomeVisible(javax.swing.event.PopupMenuEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.PopupMenuEvent"/></param>
        public virtual void PopupMenuWillBecomeVisible(Javax.Swing.Event.PopupMenuEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}