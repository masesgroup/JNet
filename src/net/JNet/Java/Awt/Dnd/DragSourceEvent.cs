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

using Java.Util;

namespace Java.Awt.Dnd
{
    public class DragSourceEvent : EventObject
    {
        public override string ClassName => "java.awt.dnd.DragSourceEvent";
        /// <summary>
        /// This method returns the <see cref="DragSourceContext"/> that originated the event.
        /// </summary>
        public DragSourceContext DragSourceContext => IExecute<DragSourceContext>("getDragSourceContext");
        /// <summary>
        /// This method returns a Point indicating the cursor location in screen coordinates at the moment this event occured, or null if the cursor location is not specified for this event.
        /// </summary>
        public Point Location => IExecute<Point>("getLocation");
        /// <summary>
        /// This method returns the horizontal coordinate of the cursor location in screen coordinates at the moment this event occured, or zero if the cursor location is not specified for this event.
        /// </summary>
        public int X => IExecute<int>("getX");
        /// <summary>
        /// This method returns the vertical coordinate of the cursor location in screen coordinates at the moment this event occured, or zero if the cursor location is not specified for this event.
        /// </summary>
        public int Y => IExecute<int>("getY");
    }
}
