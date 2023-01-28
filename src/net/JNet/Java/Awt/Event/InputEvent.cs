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
    public class InputEvent : ComponentEvent
    {
        public override string ClassName => "java.awt.event.InputEvent";
        /// <summary>
        /// A method to obtain a mask for any existing mouse button
        /// </summary>
        /// <param name="button">is a number to represent a button starting from 1.</param>
        /// <returns></returns>
        public static int GetMaskForButton(int button) => SExecute<int>("getMaskForButton", button);
        /// <summary>
        /// Returns a String describing the extended modifier keys and mouse buttons, such as "Shift", "Button1", or "Ctrl+Shift". These strings can be localized by changing the awt.properties file. 
        /// </summary>
        /// <param name="modifiers">a modifier mask describing the extended modifier keys and mouse buttons for the event</param>
        /// <returns>a text description of the combination of extended modifier keys and mouse buttons that were held down during the event.</returns>
        public static string GetModifiersExText(int modifiers) => SExecute<string>("getModifiersExText", modifiers);
        /// <summary>
        /// Consumes this event so that it will not be processed in the default manner by the source which originated it.
        /// </summary>
        public void Consume() => IExecute("consume");
        /// <summary>
        /// Returns the modifier mask for this event.
        /// </summary>
        public int Modifiers => IExecute<int>("getModifiers");
        /// <summary>
        /// Returns the extended modifier mask for this event.
        /// </summary>
        public int ModifiersEx => IExecute<int>("getModifiersEx");
        /// <summary>
        /// Returns the difference in milliseconds between the timestamp of when this event occurred and midnight, January 1, 1970 UTC.
        /// </summary>
        public long When => IExecute<long>("getWhen");
        /// <summary>
        /// Returns whether or not the Alt modifier is down on this event.
        /// </summary>
        /// <returns></returns>
        public bool AltDown => IExecute<bool>("isAltDown");
        /// <summary>
        /// Returns whether or not the AltGraph modifier is down on this event.
        /// </summary>
        public bool AltGraphDown => IExecute<bool>("isAltGraphDown");
        /// <summary>
        ///  Returns whether or not this event has been consumed.
        /// </summary>
        public bool Consumed => IExecute<bool>("isConsumed");
        /// <summary>
        /// Returns whether or not the Control modifier is down on this event.
        /// </summary>
        public bool ControlDown => IExecute<bool>("isControlDown");
        /// <summary>
        /// Returns whether or not the Meta modifier is down on this event.
        /// </summary>
        public bool MetaDown => IExecute<bool>("isMetaDown");
        /// <summary>
        ///  Returns whether or not the Shift modifier is down on this event.
        /// </summary>
        public bool ShiftDown => IExecute<bool>("isShiftDown");
    }
}
