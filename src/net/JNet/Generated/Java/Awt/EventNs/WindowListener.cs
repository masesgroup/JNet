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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region IWindowListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.event.WindowListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html"/>
    /// </summary>
    public partial interface IWindowListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowActivated(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowClosed(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowClosing(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowDeactivated(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowDeiconified(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowIconified(Java.Awt.EventNs.WindowEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        void WindowOpened(Java.Awt.EventNs.WindowEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WindowListener
    public partial class WindowListener : Java.Awt.EventNs.IWindowListener
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
        /// Handlers initializer for <see cref="WindowListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("windowActivated", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowActivatedEventHandler)); OnWindowActivated = WindowActivated;
            AddEventHandler("windowClosed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowClosedEventHandler)); OnWindowClosed = WindowClosed;
            AddEventHandler("windowClosing", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowClosingEventHandler)); OnWindowClosing = WindowClosing;
            AddEventHandler("windowDeactivated", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowDeactivatedEventHandler)); OnWindowDeactivated = WindowDeactivated;
            AddEventHandler("windowDeiconified", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowDeiconifiedEventHandler)); OnWindowDeiconified = WindowDeiconified;
            AddEventHandler("windowIconified", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowIconifiedEventHandler)); OnWindowIconified = WindowIconified;
            AddEventHandler("windowOpened", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>>>(WindowOpenedEventHandler)); OnWindowOpened = WindowOpened;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.WindowEvent> OnWindowActivated { get; set; }

        void WindowActivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            if (OnWindowActivated != null) OnWindowActivated.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowActivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.WindowEvent> OnWindowClosed { get; set; }

        void WindowClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            if (OnWindowClosed != null) OnWindowClosed.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowClosed(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.WindowEvent> OnWindowClosing { get; set; }

        void WindowClosingEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            if (OnWindowClosing != null) OnWindowClosing.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowClosing(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.WindowEvent> OnWindowDeactivated { get; set; }

        void WindowDeactivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            if (OnWindowDeactivated != null) OnWindowDeactivated.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowDeactivated(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.WindowEvent> OnWindowDeiconified { get; set; }

        void WindowDeiconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            if (OnWindowDeiconified != null) OnWindowDeiconified.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowDeiconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.WindowEvent> OnWindowIconified { get; set; }

        void WindowIconifiedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            if (OnWindowIconified != null) OnWindowIconified.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowIconified(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.WindowEvent> OnWindowOpened { get; set; }

        void WindowOpenedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.WindowEvent>> data)
        {
            if (OnWindowOpened != null) OnWindowOpened.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowListener.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowEvent"/></param>
        public virtual void WindowOpened(Java.Awt.EventNs.WindowEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}