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
    public class MouseEvent : InputEvent
    {
        public override string ClassName => "java.awt.event.MouseEvent";
        /// <summary>
        /// Returns a <see cref="string"/> instance describing the modifier keys and mouse buttons that were down during the event, such as "Shift", or "Ctrl+Shift". These strings can be localized by changing the awt.properties file. 
        /// </summary>
        /// <param name="modifiers">A modifier mask describing the modifier keys and mouse buttons that were down during the event</param>
        /// <returns>string string text description of the combination of modifier keys and mouse buttons that were down during the event</returns>
        public static string GetMouseModifiersText(int modifiers) => SExecute<string>("getMouseModifiersText", modifiers);
        /// <summary>
        /// Returns which, if any, of the mouse buttons has changed state.
        /// </summary>
        public int Button => IExecute<int>("getButton");
        /// <summary>
        /// Returns the number of mouse clicks associated with this event.
        /// </summary>
        public int ClickCount=> IExecute<int>("getClickCount");
        /// <summary>
        /// Returns the absolute x, y position of the event.
        /// </summary>
        public Point LocationOnScreen => IExecute<Point>("getLocationOnScreen");
        /// <summary>
        /// Returns the x,y position of the event relative to the source component.
        /// </summary>
        public Point Point => IExecute<Point>("getPoint");
        /// <summary>
        /// Returns the horizontal x position of the event relative to the source component.
        /// </summary>
        public int X => IExecute<int>("getX");
        /// <summary>
        /// Returns the absolute horizontal x position of the event.
        /// </summary>
        public int XOnScreen => IExecute<int>("getXOnScreen");
        /// <summary>
        /// Returns the vertical y position of the event relative to the source component.
        /// </summary>
        public int Y => IExecute<int>("getY");
        /// <summary>
        /// Returns the absolute vertical y position of the event.
        /// </summary>
        public int YOnScreen => IExecute<int>("getYOnScreen");
        /// <summary>
        /// Returns whether or not this mouse event is the popup menu trigger event for the platform.
        /// </summary>
        public bool IsPopupTrigger => IExecute<bool>("isPopupTrigger");
        /// <summary>
        /// Translates the event's coordinates to a new position by adding specified x (horizontal) and y (vertical) offsets.
        /// </summary>
        /// <param name="x">The horizontal x value to add to the current x coordinate position</param>
        /// <param name="y">The vertical y value to add to the current y coordinate position</param>
        public void TranslatePoint(int x, int y) => IExecute("translatePoint", x, y);
    }
}
