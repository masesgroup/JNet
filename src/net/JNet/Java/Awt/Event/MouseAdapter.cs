/*
*  Copyright 2022 MASES s.r.l.
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

namespace Java.Awt.Event
{
    public interface IMouseAdapter : IJVMBridgeBase
    {
        void MouseClicked(MouseEvent e);

        void MouseEntered(MouseEvent e);

        void MouseExited(MouseEvent e);

        void MousePressed(MouseEvent e);

        void MouseReleased(MouseEvent e);

        void MouseDragged(MouseEvent e);

        void MouseMoved(MouseEvent e);

        void MouseWheelMoved(MouseWheelEvent e);
    }

    /// <summary>
    /// Listener for MouseAdapter. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IMouseAdapter"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public class MouseAdapter : JVMBridgeListener, IMouseAdapter
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetMouseAdapter";

        readonly Action<MouseEvent> MouseClickedFunction = null;
        readonly Action<MouseEvent> MouseEnteredFunction = null;
        readonly Action<MouseEvent> MouseExitedFunction = null;
        readonly Action<MouseEvent> MousePressedFunction = null;
        readonly Action<MouseEvent> MouseReleasedFunction = null;
        readonly Action<MouseEvent> MouseDraggedFunction = null;
        readonly Action<MouseEvent> MouseMovedFunction = null;
        readonly Action<MouseWheelEvent> MouseWheelMovedFunction = null;
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseClicked
        /// </summary>
        public virtual Action<MouseEvent> OnMouseClicked { get { return MouseClickedFunction; } }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseEntered
        /// </summary>
        public virtual Action<MouseEvent> OnMouseEntered { get { return MouseEnteredFunction; } }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseExited
        /// </summary>
        public virtual Action<MouseEvent> OnMouseExited { get { return MouseExitedFunction; } }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MousePressed
        /// </summary>
        public virtual Action<MouseEvent> OnMousePressed { get { return MousePressedFunction; } }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseReleased
        /// </summary>
        public virtual Action<MouseEvent> OnMouseReleased { get { return MouseReleasedFunction; } }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseDragged
        /// </summary>
        public virtual Action<MouseEvent> OnMouseDragged { get { return MouseDraggedFunction; } }
        /// <summary>
        /// The <see cref="Action{MouseEvent}"/> to be executed on MouseMoved
        /// </summary>
        public virtual Action<MouseEvent> OnMouseMoved { get { return MouseMovedFunction; } }
        /// <summary>
        /// The <see cref="Action{MouseWheelEvent}"/> to be executed on MouseWheelMoved
        /// </summary>
        public virtual Action<MouseWheelEvent> OnMouseWheelMoved { get { return MouseWheelMovedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="MouseAdapter"/>
        /// </summary>
        /// <param name="mouseClicked">The <see cref="Action{MouseEvent}"/> to be executed on MouseClicked</param>
        /// <param name="mouseEntered">The <see cref="Action{MouseEvent}"/> to be executed on MouseEntered</param>
        /// <param name="mouseExited">The <see cref="Action{MouseEvent}"/> to be executed on MouseExited</param>
        /// <param name="mousePressed">The <see cref="Action{MouseEvent}"/> to be executed on MousePressed</param>
        /// <param name="mouseReleased">The <see cref="Action{MouseEvent}"/> to be executed on MouseReleased</param>
        /// <param name="mouseDragged">The <see cref="Action{MouseEvent}"/> to be executed on MouseDragged</param>
        /// <param name="mouseMoved">The <see cref="Action{MouseEvent}"/> to be executed on MouseMoved</param>
        /// <param name="mouseWheelMoved">The <see cref="Action{MouseEvent}"/> to be executed on MouseWheelMoved</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public MouseAdapter(Action<MouseEvent> mouseClicked = null,
                            Action<MouseEvent> mouseEntered = null,
                            Action<MouseEvent> mouseExited = null,
                            Action<MouseEvent> mousePressed = null,
                            Action<MouseEvent> mouseReleased = null,
                            Action<MouseEvent> mouseDragged = null,
                            Action<MouseEvent> mouseMoved = null,
                            Action<MouseWheelEvent> mouseWheelMoved = null,
                            bool attachEventHandler = true)
        {
            if (mouseClicked != null) MouseClickedFunction = mouseClicked;
            else MouseClickedFunction = MouseClicked;
            if (mouseEntered != null) MouseEnteredFunction = mouseEntered;
            else MouseEnteredFunction = MouseEntered;
            if (mouseExited != null) MouseExitedFunction = mouseExited;
            else MouseExitedFunction = MouseExited;
            if (mousePressed != null) MousePressedFunction = mousePressed;
            else MousePressedFunction = MousePressed;
            if (mouseReleased != null) MouseReleasedFunction = mouseReleased;
            else MouseReleasedFunction = MouseReleased;
            if (mouseDragged != null) MouseDraggedFunction = mouseDragged;
            else MouseDraggedFunction = MouseDragged;
            if (mouseMoved != null) MouseMovedFunction = mouseMoved;
            else MouseMovedFunction = MouseMoved;
            if (mouseWheelMoved != null) MouseWheelMovedFunction = mouseWheelMoved;
            else MouseWheelMovedFunction = MouseWheelMoved;

            if (attachEventHandler)
            {
                AddEventHandler("mouseClicked", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseClicked));
                AddEventHandler("mouseEntered", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseEntered));
                AddEventHandler("mouseExited", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseExited));
                AddEventHandler("mousePressed", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMousePressed));
                AddEventHandler("mouseReleased", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseReleased));
                AddEventHandler("mouseDragged", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseDragged));
                AddEventHandler("mouseMoved", new EventHandler<CLRListenerEventArgs<CLREventData<MouseEvent>>>(EventHandlerMouseMoved));
                AddEventHandler("mouseWheelMoved", new EventHandler<CLRListenerEventArgs<CLREventData<MouseWheelEvent>>>(EventHandlerMouseWheelMoved));
            }
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

        public virtual void MouseClicked(MouseEvent e)
        {

        }

        public virtual void MouseEntered(MouseEvent e)
        {

        }

        public virtual void MouseExited(MouseEvent e)
        {

        }

        public virtual void MousePressed(MouseEvent e)
        {

        }

        public virtual void MouseReleased(MouseEvent e)
        {

        }

        public virtual void MouseDragged(MouseEvent e)
        {

        }

        public virtual void MouseMoved(MouseEvent e)
        {

        }

        public virtual void MouseWheelMoved(MouseWheelEvent e)
        {

        }
    }
}
