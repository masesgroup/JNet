/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/WindowAdapter.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>, implements <see cref="IWindowAdapter"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class WindowAdapter : IWindowAdapter
    {

    }
}
