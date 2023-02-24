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
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html"/>
    /// </summary>
    public interface IWindowAdapter : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowActivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowActivated(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowClosed(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowClosed(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowClosing(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowClosing(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowDeactivated(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowDeactivated(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowDeiconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowDeiconified(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowGainedFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowGainedFocus(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowIconified(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowIconified(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowLostFocus(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowLostFocus(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowOpened(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowOpened(WindowEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html#windowStateChanged(java.awt.event.WindowEvent)"/>
        /// </summary>
        void WindowStateChanged(WindowEvent e);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html"/>. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IWindowAdapter"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class WindowAdapter : IWindowAdapter
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetWindowAdapter";

        readonly Action<WindowEvent> WindowActivatedFunction = null;
        readonly Action<WindowEvent> WindowClosedFunction = null;
        readonly Action<WindowEvent> WindowClosingFunction = null;
        readonly Action<WindowEvent> WindowDeactivatedFunction = null;
        readonly Action<WindowEvent> WindowDeiconifiedFunction = null;
        readonly Action<WindowEvent> WindowGainedFocusFunction = null;
        readonly Action<WindowEvent> WindowIconifiedFunction = null;
        readonly Action<WindowEvent> WindowLostFocusFunction = null;
        readonly Action<WindowEvent> WindowOpenedFunction = null;
        readonly Action<WindowEvent> WindowStateChangedFunction = null;
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowActivated
        /// </summary>
        public virtual Action<WindowEvent> OnWindowActivated { get { return WindowActivatedFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowClosed
        /// </summary>
        public virtual Action<WindowEvent> OnWindowClosed { get { return WindowClosedFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowClosing
        /// </summary>
        public virtual Action<WindowEvent> OnWindowClosing { get { return WindowClosingFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowDeactivated
        /// </summary>
        public virtual Action<WindowEvent> OnWindowDeactivated { get { return WindowDeactivatedFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowDeiconified
        /// </summary>
        public virtual Action<WindowEvent> OnWindowDeiconified { get { return WindowDeiconifiedFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowGainedFocus
        /// </summary>
        public virtual Action<WindowEvent> OnWindowGainedFocus { get { return WindowGainedFocusFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowIconified
        /// </summary>
        public virtual Action<WindowEvent> OnWindowIconified { get { return WindowIconifiedFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowLostFocus
        /// </summary>
        public virtual Action<WindowEvent> OnWindowLostFocus { get { return WindowLostFocusFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowOpened
        /// </summary>
        public virtual Action<WindowEvent> OnWindowOpened { get { return WindowOpenedFunction; } }
        /// <summary>
        /// The <see cref="Action{WindowEvent}"/> to be executed on WindowStateChanged
        /// </summary>
        public virtual Action<WindowEvent> OnWindowStateChanged { get { return WindowStateChangedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="WindowAdapter"/>
        /// </summary>
        /// <param name="windowActivated">The <see cref="Action{WindowEvent}"/> to be executed on WindowActivated</param>
        /// <param name="windowClosed">The <see cref="Action{WindowEvent}"/> to be executed on WindowClosed</param>
        /// <param name="windowClosing">The <see cref="Action{WindowEvent}"/> to be executed on WindowClosing</param>
        /// <param name="windowDeactivated">The <see cref="Action{WindowEvent}"/> to be executed on WindowDeactivated</param>
        /// <param name="windowDeiconified">The <see cref="Action{WindowEvent}"/> to be executed on WindowDeiconified</param>
        /// <param name="windowGainedFocus">The <see cref="Action{WindowEvent}"/> to be executed on WindowGainedFocus</param>
        /// <param name="windowIconified">The <see cref="Action{WindowEvent}"/> to be executed on WindowIconified</param>
        /// <param name="windowLostFocus">The <see cref="Action{WindowEvent}"/> to be executed on WindowLostFocus</param>
        /// <param name="windowOpened">The <see cref="Action{WindowEvent}"/> to be executed on WindowOpened</param>
        /// <param name="windowStateChanged">The <see cref="Action{WindowEvent}"/> to be executed on WindowStateChanged</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public WindowAdapter(Action<WindowEvent> windowActivated = null,
                             Action<WindowEvent> windowClosed = null,
                             Action<WindowEvent> windowClosing = null,
                             Action<WindowEvent> windowDeactivated = null,
                             Action<WindowEvent> windowDeiconified = null,
                             Action<WindowEvent> windowGainedFocus = null,
                             Action<WindowEvent> windowIconified = null,
                             Action<WindowEvent> windowLostFocus = null,
                             Action<WindowEvent> windowOpened = null,
                             Action<WindowEvent> windowStateChanged = null,
                             bool attachEventHandler = true)
        {
            if (windowActivated != null) WindowActivatedFunction = windowActivated;
            else WindowActivatedFunction = WindowActivated;
            if (windowClosed != null) WindowClosedFunction = windowClosed;
            else WindowClosedFunction = WindowClosed;
            if (windowClosing != null) WindowClosingFunction = windowClosing;
            else WindowClosingFunction = WindowClosing;
            if (windowDeactivated != null) WindowDeactivatedFunction = windowDeactivated;
            else WindowDeactivatedFunction = WindowDeactivated;
            if (windowDeiconified != null) WindowDeiconifiedFunction = windowDeiconified;
            else WindowDeiconifiedFunction = WindowDeiconified;
            if (windowGainedFocus != null) WindowGainedFocusFunction = windowGainedFocus;
            else WindowGainedFocusFunction = WindowGainedFocus;
            if (windowIconified != null) WindowIconifiedFunction = windowIconified;
            else WindowIconifiedFunction = WindowIconified;
            if (windowLostFocus != null) WindowLostFocusFunction = windowLostFocus;
            else WindowLostFocusFunction = WindowLostFocus;
            if (windowOpened != null) WindowOpenedFunction = windowOpened;
            else WindowOpenedFunction = WindowOpened;
            if (windowStateChanged != null) WindowStateChangedFunction = windowStateChanged;
            else WindowStateChangedFunction = WindowStateChanged;

            if (attachEventHandler)
            {
                AddEventHandler("windowActivated", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowActivated));
                AddEventHandler("windowClosed", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowClosed));
                AddEventHandler("windowClosing", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowClosing));
                AddEventHandler("windowDeactivated", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowDeactivated));
                AddEventHandler("windowDeiconified", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowDeiconified));
                AddEventHandler("windowGainedFocus", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowGainedFocus));
                AddEventHandler("windowIconified", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowIconified));
                AddEventHandler("windowLostFocus", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowLostFocus));
                AddEventHandler("windowOpened", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowOpened));
                AddEventHandler("windowStateChanged", new EventHandler<CLRListenerEventArgs<CLREventData<WindowEvent>>>(EventHandlerWindowStateChanged));
            }
        }

        void EventHandlerWindowActivated(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowActivated(data.EventData.TypedEventData);
        }

        void EventHandlerWindowClosed(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowClosed(data.EventData.TypedEventData);
        }

        void EventHandlerWindowClosing(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowClosing(data.EventData.TypedEventData);
        }

        void EventHandlerWindowDeactivated(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowDeactivated(data.EventData.TypedEventData);
        }

        void EventHandlerWindowDeiconified(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowDeiconified(data.EventData.TypedEventData);
        }

        void EventHandlerWindowGainedFocus(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowGainedFocus(data.EventData.TypedEventData);
        }

        void EventHandlerWindowIconified(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowIconified(data.EventData.TypedEventData);
        }

        void EventHandlerWindowLostFocus(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowLostFocus(data.EventData.TypedEventData);
        }

        void EventHandlerWindowOpened(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowOpened(data.EventData.TypedEventData);
        }

        void EventHandlerWindowStateChanged(object sender, CLRListenerEventArgs<CLREventData<WindowEvent>> data)
        {
            OnWindowStateChanged(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="IWindowAdapter.WindowActivated(WindowEvent)"/>
        public virtual void WindowActivated(WindowEvent e)
        {
        
        }
        /// <inheritdoc cref="IWindowAdapter.WindowClosed(WindowEvent)"/>
        public virtual void WindowClosed(WindowEvent e)
        {
            
        }
        /// <inheritdoc cref="IWindowAdapter.WindowClosing(WindowEvent)"/>
        public virtual void WindowClosing(WindowEvent e)
        {
           
        }
        /// <inheritdoc cref="IWindowAdapter.WindowDeactivated(WindowEvent)"/>
        public virtual void WindowDeactivated(WindowEvent e)
        {
 
        }
        /// <inheritdoc cref="IWindowAdapter.WindowDeiconified(WindowEvent)"/>
        public virtual void WindowDeiconified(WindowEvent e)
        {
        
        }
        /// <inheritdoc cref="IWindowAdapter.WindowGainedFocus(WindowEvent)"/>
        public virtual void WindowGainedFocus(WindowEvent e)
        {
     
        }
        /// <inheritdoc cref="IWindowAdapter.WindowIconified(WindowEvent)"/>
        public virtual void WindowIconified(WindowEvent e)
        {
            
        }
        /// <inheritdoc cref="IWindowAdapter.WindowLostFocus(WindowEvent)"/>
        public virtual void WindowLostFocus(WindowEvent e)
        {
          
        }
        /// <inheritdoc cref="IWindowAdapter.WindowOpened(WindowEvent)"/>
        public virtual void WindowOpened(WindowEvent e)
        {
           
        }
        /// <inheritdoc cref="IWindowAdapter.WindowStateChanged(WindowEvent)"/>
        public virtual void WindowStateChanged(WindowEvent e)
        {
         
        }
    }
}
