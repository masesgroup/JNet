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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
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
            AddEventHandler("internalFrameActivated", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameActivatedEventHandler)); OnInternalFrameActivated = InternalFrameActivated;
            AddEventHandler("internalFrameClosed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameClosedEventHandler)); OnInternalFrameClosed = InternalFrameClosed;
            AddEventHandler("internalFrameClosing", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameClosingEventHandler)); OnInternalFrameClosing = InternalFrameClosing;
            AddEventHandler("internalFrameDeactivated", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameDeactivatedEventHandler)); OnInternalFrameDeactivated = InternalFrameDeactivated;
            AddEventHandler("internalFrameDeiconified", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameDeiconifiedEventHandler)); OnInternalFrameDeiconified = InternalFrameDeiconified;
            AddEventHandler("internalFrameIconified", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameIconifiedEventHandler)); OnInternalFrameIconified = InternalFrameIconified;
            AddEventHandler("internalFrameOpened", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>>>(InternalFrameOpenedEventHandler)); OnInternalFrameOpened = InternalFrameOpened;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameListener.html#internalFrameActivated(javax.swing.event.InternalFrameEvent)"/>
        /// </summary>
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameActivated { get; set; }

        void InternalFrameActivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            if (OnInternalFrameActivated != null) OnInternalFrameActivated.Invoke(data.EventData.TypedEventData);
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
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameClosed { get; set; }

        void InternalFrameClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            if (OnInternalFrameClosed != null) OnInternalFrameClosed.Invoke(data.EventData.TypedEventData);
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
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameClosing { get; set; }

        void InternalFrameClosingEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            if (OnInternalFrameClosing != null) OnInternalFrameClosing.Invoke(data.EventData.TypedEventData);
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
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameDeactivated { get; set; }

        void InternalFrameDeactivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            if (OnInternalFrameDeactivated != null) OnInternalFrameDeactivated.Invoke(data.EventData.TypedEventData);
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
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameDeiconified { get; set; }

        void InternalFrameDeiconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            if (OnInternalFrameDeiconified != null) OnInternalFrameDeiconified.Invoke(data.EventData.TypedEventData);
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
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameIconified { get; set; }

        void InternalFrameIconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            if (OnInternalFrameIconified != null) OnInternalFrameIconified.Invoke(data.EventData.TypedEventData);
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
        public System.Action<Javax.Swing.Event.InternalFrameEvent> OnInternalFrameOpened { get; set; }

        void InternalFrameOpenedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.InternalFrameEvent>> data)
        {
            if (OnInternalFrameOpened != null) OnInternalFrameOpened.Invoke(data.EventData.TypedEventData);
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