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
    #region IInternalFrameListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.InternalFrameListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html"/>
    /// </summary>
    public partial interface IInternalFrameListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameActivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameActivated(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosed(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameClosed(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosing(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameClosing(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeactivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameDeactivated(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeiconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameDeiconified(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameIconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameIconified(Javax.Swing.Event.InternalFrameEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameOpened(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        void InternalFrameOpened(Javax.Swing.Event.InternalFrameEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InternalFrameListener
    public partial class InternalFrameListener : Javax.Swing.Event.IInternalFrameListener
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
        /// Handlers initializer for <see cref="InternalFrameListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("internalFrameActivated", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameActivatedEventHandler));
            AddEventHandler("internalFrameClosed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameClosedEventHandler));
            AddEventHandler("internalFrameClosing", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameClosingEventHandler));
            AddEventHandler("internalFrameDeactivated", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameDeactivatedEventHandler));
            AddEventHandler("internalFrameDeiconified", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameDeiconifiedEventHandler));
            AddEventHandler("internalFrameIconified", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameIconifiedEventHandler));
            AddEventHandler("internalFrameOpened", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameOpenedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameActivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameActivated"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameActivated { get; set; } = null;

        void InternalFrameActivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            var methodToExecute = (OnInternalFrameActivated != null) ? OnInternalFrameActivated : InternalFrameActivated;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameActivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameActivated(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosed(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameClosed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameClosed { get; set; } = null;

        void InternalFrameClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            var methodToExecute = (OnInternalFrameClosed != null) ? OnInternalFrameClosed : InternalFrameClosed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosed(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameClosed(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosing(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameClosing"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameClosing { get; set; } = null;

        void InternalFrameClosingEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            var methodToExecute = (OnInternalFrameClosing != null) ? OnInternalFrameClosing : InternalFrameClosing;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameClosing(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameClosing(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeactivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameDeactivated"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameDeactivated { get; set; } = null;

        void InternalFrameDeactivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            var methodToExecute = (OnInternalFrameDeactivated != null) ? OnInternalFrameDeactivated : InternalFrameDeactivated;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeactivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameDeactivated(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeiconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameDeiconified"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameDeiconified { get; set; } = null;

        void InternalFrameDeiconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            var methodToExecute = (OnInternalFrameDeiconified != null) ? OnInternalFrameDeiconified : InternalFrameDeiconified;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameDeiconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameDeiconified(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameIconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameIconified"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameIconified { get; set; } = null;

        void InternalFrameIconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            var methodToExecute = (OnInternalFrameIconified != null) ? OnInternalFrameIconified : InternalFrameIconified;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameIconified(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameIconified(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameOpened(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnInternalFrameOpened"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameOpened { get; set; } = null;

        void InternalFrameOpenedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            var methodToExecute = (OnInternalFrameOpened != null) ? OnInternalFrameOpened : InternalFrameOpened;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameOpened(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.InternalFrameEvent"/></param>
        public virtual void InternalFrameOpened(Javax.Swing.Event.InternalFrameEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}