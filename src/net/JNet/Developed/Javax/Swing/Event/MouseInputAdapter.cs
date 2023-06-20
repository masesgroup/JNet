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

using Java.Awt.EventNs;
using MASES.JCOBridge.C2JBridge;
using System;

namespace Javax.Swing.Event
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MouseInputAdapter.html"/>
    /// </summary>
    public interface IMouseInputAdapter : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseClicked(java.awt.event.MouseEvent)"/>
        /// </summary>
        public void MouseClicked(MouseEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseEntered(java.awt.event.MouseEvent)"/>
        /// </summary>
        public void MouseEntered(MouseEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseExited(java.awt.event.MouseEvent)"/>
        /// </summary>
        public void MouseExited(MouseEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mousePressed(java.awt.event.MouseEvent)"/>
        /// </summary>
        public void MousePressed(MouseEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseListener.html#mouseReleased(java.awt.event.MouseEvent)"/>
        /// </summary>
        public void MouseReleased(MouseEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseDragged(java.awt.event.MouseEvent)"/>
        /// </summary>
        public void MouseDragged(MouseEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseMoved(java.awt.event.MouseEvent)"/>
        /// </summary>
        public void MouseMoved(MouseEvent e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseAdapter.html#mouseWheelMoved(java.awt.event.MouseWheelEvent)"/>
        /// </summary>
        public void MouseWheelMoved(MouseWheelEvent e);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/MouseInputAdapter.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>, implements <see cref="IMouseInputAdapter"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class MouseInputAdapter : IMouseInputAdapter
    {
        ///// <summary>
        ///// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        ///// </summary>
        //public override string BridgeClassName => "org.mases.jnet.awt.event.JNetMouseInputAdapter";

        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseClicked
        /// </summary>
        public virtual Action<MouseEvent> OnMouseClicked { get; set; }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseEntered
        /// </summary>
        public virtual Action<MouseEvent> OnMouseEntered { get; set; }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseExited
        /// </summary>
        public virtual Action<MouseEvent> OnMouseExited { get; set; }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MousePressed
        /// </summary>
        public virtual Action<MouseEvent> OnMousePressed { get; set; }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseReleased
        /// </summary>
        public virtual Action<MouseEvent> OnMouseReleased { get; set; }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseDragged
        /// </summary>
        public virtual Action<MouseEvent> OnMouseDragged { get; set; }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseMoved
        /// </summary>
        public virtual Action<MouseEvent> OnMouseMoved { get; set; }
        /// <summary>
        /// The <see cref="Action{MouseWheelEvent}"/> to be executed on MouseWheelMoved
        /// </summary>
        public virtual Action<MouseWheelEvent> OnMouseWheelMoved { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="MouseInputAdapter"/>
        /// </summary>
        public MouseInputAdapter(bool isManualVersion) // put it here for compilation: JNetReflector miss generation of methods of this class
        {
            AddEventHandler("mouseClicked", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseClicked)); OnMouseClicked = MouseClicked;
            AddEventHandler("mouseEntered", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseEntered)); OnMouseEntered = MouseEntered;
            AddEventHandler("mouseExited", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseExited)); OnMouseExited = MouseExited;
            AddEventHandler("mousePressed", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMousePressed)); OnMousePressed = MousePressed;
            AddEventHandler("mouseReleased", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseReleased)); OnMouseReleased = MouseReleased;
            AddEventHandler("mouseDragged", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseDragged)); OnMouseDragged = MouseDragged;
            AddEventHandler("mouseMoved", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseMoved)); OnMouseMoved = MouseMoved;
            AddEventHandler("mouseWheelMoved", new EventHandler<CLRListenerEventArgs<CLREventData<MouseWheelEvent>>>(EventHandlerMouseWheelMoved)); OnMouseWheelMoved = MouseWheelMoved;
        }

        void EventHandlerMouseClicked(object sender, CLRListenerEventArgs<CLREventData<MouseEvent>> data)
        {
            OnMouseClicked(data.EventData.TypedEventData);
        }

        void EventHandlerMouseEntered(object sender, CLRListenerEventArgs<CLREventData<MouseEvent>> data)
        {
            OnMouseEntered(data.EventData.TypedEventData);
        }

        void EventHandlerMouseExited(object sender, CLRListenerEventArgs<CLREventData<MouseEvent>> data)
        {
            OnMouseExited(data.EventData.TypedEventData);
        }

        void EventHandlerMousePressed(object sender, CLRListenerEventArgs<CLREventData<MouseEvent>> data)
        {
            OnMousePressed(data.EventData.TypedEventData);
        }

        void EventHandlerMouseReleased(object sender, CLRListenerEventArgs<CLREventData<MouseEvent>> data)
        {
            OnMouseReleased(data.EventData.TypedEventData);
        }

        void EventHandlerMouseDragged(object sender, CLRListenerEventArgs<CLREventData<MouseEvent>> data)
        {
            OnMouseDragged(data.EventData.TypedEventData);
        }

        void EventHandlerMouseMoved(object sender, CLRListenerEventArgs<CLREventData<MouseEvent>> data)
        {
            OnMouseMoved(data.EventData.TypedEventData);
        }

        void EventHandlerMouseWheelMoved(object sender, CLRListenerEventArgs<CLREventData<MouseWheelEvent>> data)
        {
            OnMouseWheelMoved(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="IMouseInputAdapter.MouseClicked(MouseEvent)"/>
        public virtual void MouseClicked(MouseEvent e)
        {

        }
        /// <inheritdoc cref="IMouseInputAdapter.MouseEntered(MouseEvent)"/>
        public virtual void MouseEntered(MouseEvent e)
        {

        }
        /// <inheritdoc cref="IMouseInputAdapter.MouseExited(MouseEvent)"/>
        public virtual void MouseExited(MouseEvent e)
        {

        }
        /// <inheritdoc cref="IMouseInputAdapter.MousePressed(MouseEvent)"/>
        public virtual void MousePressed(MouseEvent e)
        {

        }
        /// <inheritdoc cref="IMouseInputAdapter.MouseReleased(MouseEvent)"/>
        public virtual void MouseReleased(MouseEvent e)
        {

        }
        /// <inheritdoc cref="IMouseInputAdapter.MouseDragged(MouseEvent)"/>
        public virtual void MouseDragged(MouseEvent e)
        {

        }
        /// <inheritdoc cref="IMouseInputAdapter.MouseMoved(MouseEvent)"/>
        public virtual void MouseMoved(MouseEvent e)
        {

        }
        /// <inheritdoc cref="IMouseInputAdapter.MouseWheelMoved(MouseWheelEvent)"/>
        public virtual void MouseWheelMoved(MouseWheelEvent e)
        {

        }
    }
}
