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

using Java.Lang;
using Java.Util;

namespace Java.Awt
{
    public class AWTEvent : EventObject
    {
        public override string ClassName => "java.awt.AWTEvent";
        /// <summary>
        /// Returns the event type.
        /// </summary>
        /// <value>Returns the event type.</value>
        public int ID => IExecute<int>("getID");
        /// <summary>
        /// Returns a string representing the state of this Event. This method is intended to be used only for debugging purposes, and the content and format of the returned string may vary between implementations. The returned string may be empty but may not be null.
        /// </summary>
        /// <value>A string representation of this event.</value>
        public string ParamString => IExecute<string>("paramString");
        /// <summary>
        /// Retargets an event to a new source. This method is typically used to retarget an event to a lightweight child <see cref="Component"/> of the original heavyweight source. 
        /// </summary>
        /// <remarks>This method is intended to be used only by event targeting subsystems, such as client-defined KeyboardFocusManagers. It is not for general client use.</remarks>
        /// <param name="newSource">The new Object to which the event should be dispatched</param>
        public void SetSource(Object newSource) { IExecute("setSource", newSource); }
    }
}
