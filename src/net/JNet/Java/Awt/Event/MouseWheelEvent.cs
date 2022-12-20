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

namespace Java.Awt.Event
{
    public class MouseWheelEvent : MouseEvent
    {
        public override string ClassName => "java.awt.event.MouseWheelEvent";
        /// <summary>
        /// Returns the number of "clicks" the mouse wheel was rotated, as a double.
        /// </summary>
        public double PreciseWheelRotation => IExecute<double>("getPreciseWheelRotation");
        /// <summary>
        /// Returns the number of units that should be scrolled per click of mouse wheel rotation.
        /// </summary>
        public int ScrollAmount => IExecute<int>("getScrollAmount");
        /// <summary>
        /// Returns the type of scrolling that should take place in response to this event.
        /// </summary>
        public int ScrollType => IExecute<int>("getScrollType");
        /// <summary>
        /// This is a convenience method to aid in the implementation of the common-case MouseWheelListener - to scroll a ScrollPane or JScrollPane by an amount which conforms to the platform settings.
        /// </summary>
        public int UnitsToScroll => IExecute<int>("getUnitsToScroll");
        /// <summary>
        /// Returns the number of "clicks" the mouse wheel was rotated, as an integer.
        /// </summary>
        public int WheelRotation => IExecute<int>("getWheelRotation");
    }
}
