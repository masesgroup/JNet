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

using Java.Awt.Datatransfer;
using Java.Awt.Event;
using Java.Lang;
using Java.Util;

namespace Java.Awt.Dnd
{
    public class DragGestureEvent : EventObject
    {
        public override string ClassName => "java.awt.dnd.DragGestureEvent";
        /// <summary>
        /// Returns an Iterator for the events comprising the gesture
        /// </summary>
        public static implicit operator Iterator<InputEvent>(DragGestureEvent e) { return e.IExecute<Iterator<InputEvent>>("iterator"); }
        /// <summary>
        /// Returns the Component associated with this DragGestureEvent.
        /// </summary>
        public Component Component => IExecute<Component>("getComponent");
        /// <summary>
        /// Returns an int representing the action selected by the user.
        /// </summary>
        public int DragAction => IExecute<int>("getDragAction");
        /// <summary>
        /// Returns a Point in the coordinates of the Component over which the drag originated.
        /// </summary>
        public Point DragOrigin => IExecute<Point>("getDragOrigin");
        /// <summary>
        /// Returns the <see cref="DragSource"/>.
        /// </summary>
        public DragSource DragSource => IExecute<DragSource>("getDragSource");
        /// <summary>
        /// Returns the source as a <see cref="DragGestureRecognizer"/>.
        /// </summary>
        public DragGestureRecognizer SourceAsDragGestureRecognizer => IExecute<DragGestureRecognizer>("getSourceAsDragGestureRecognizer");
        /// <summary>
        /// Returns the initial event that triggered the gesture.
        /// </summary>
        public InputEvent TriggerEvent => IExecute<InputEvent>("getTriggerEvent");
        /// <summary>
        /// Start the drag given the initial Cursor to display, a drag Image, the offset of the Image, the Transferable object, and the DragSourceListener to use.
        /// </summary>
        /// <param name="dragCursor">The initial Cursor for this drag operation or null for the default cursor handling; see DragSourceContext for more details on the cursor handling mechanism during drag and drop</param>
        /// <param name="dragImage">The source's dragImage</param>
        /// <param name="imageOffset">The dragImage's offset</param>
        /// <param name="transferable">The source's Transferable</param>
        /// <param name="dsl">The source's DragSourceListener </param>
        /// <remarks>Can throw InvalidDnDOperationException</remarks>
        public void StartDrag(Cursor dragCursor, Image dragImage, Point imageOffset, Transferable transferable, DragSourceListener dsl) => IExecute("startDrag", dragCursor, dragImage, imageOffset, transferable, dsl);
        /// <summary>
        /// Starts the drag operation given the Cursor for this drag operation and the Transferable representing the source data for this drag operation.
        /// </summary>
        /// <param name="dragCursor">The initial Cursor for this drag operation or null for the default cursor handling; see DragSourceContext for more details on the cursor handling mechanism during drag and drop</param>
        /// <param name="transferable">The Transferable representing the source data for this drag operation.</param>
        /// <remarks>Can throw InvalidDnDOperationException</remarks>
        public void StartDrag(Cursor dragCursor, Transferable transferable) => IExecute("startDrag", dragCursor, transferable);
        /// <summary>
        /// Starts the drag given the initial Cursor to display, the Transferable object, and the DragSourceListener to use.
        /// </summary>
        /// <param name="dragCursor">The initial Cursor for this drag operation or null for the default cursor handling; see DragSourceContext for more details on the cursor handling mechanism during drag and drop</param>
        /// <param name="transferable">The source's Transferable</param>
        /// <param name="dsl">The source's DragSourceListener </param>
        /// <remarks>Can throw InvalidDnDOperationException</remarks>
        public void StartDrag(Cursor dragCursor, Transferable transferable, DragSourceListener dsl) => IExecute("startDrag", dragCursor, transferable, dsl);
        /// <summary>
        /// Returns an Object array of the events comprising the drag gesture.
        /// </summary>
        /// <returns>an array of the events comprising the gesture</returns>
        public dynamic ToArray() { return IExecute("toArray"); }
        /// <summary>
        /// Returns an array of the events comprising the drag gesture.
        /// </summary>
        /// <param name="array">the array of EventObject sub(types)</param>
        /// <returns>an array of the events comprising the gesture</returns>
        public dynamic ToArray(Object[] array) { return IExecute("toArray", array); }
    }
}
