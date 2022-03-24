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

namespace Java.Awt.Event
{
    public class WindowEvent : ComponentEvent
    {
        public override string ClassName => "java.awt.event.WindowEvent";

        /// <summary>
        /// For WINDOW_STATE_CHANGED events returns the new state of the window. The state is represented as a bitwise mask.
        /// NORMAL
        ///    
        /// Indicates that no state bits are set.
        ///   ICONIFIED
        ///   MAXIMIZED_HORIZ
        ///   MAXIMIZED_VERT
        ///   MAXIMIZED_BOTH
        /// Concatenates MAXIMIZED_HORIZ and MAXIMIZED_VERT.
        /// </summary>
        /// <value>A bitwise mask of the new window state</value>
        public int NewState => IExecute<int>("getNewState");
        /// <summary>
        /// For WINDOW_STATE_CHANGED events returns the new state of the window. The state is represented as a bitwise mask.
        /// NORMAL
        ///    
        /// Indicates that no state bits are set.
        ///   ICONIFIED
        ///   MAXIMIZED_HORIZ
        ///   MAXIMIZED_VERT
        ///   MAXIMIZED_BOTH
        /// Concatenates MAXIMIZED_HORIZ and MAXIMIZED_VERT.
        /// </summary>
        /// <value>A bitwise mask of the previous window state</value>
        public int OldState => IExecute<int>("getOldState");
        /// <summary>
        /// Returns the other Window involved in this focus or activation change. For a WINDOW_ACTIVATED or WINDOW_GAINED_FOCUS event, this is the Window that lost activation or focus. 
        /// For a WINDOW_DEACTIVATED or WINDOW_LOST_FOCUS event, this is the Window that gained activation or focus. For any other type of WindowEvent, or if the focus or activation change occurs with a native application, with a Java application in a different VM or context, or with no other Window, null is returned.
        /// </summary>
        /// <value>The other Window involved in the focus or activation change, or null</value>
        public Window OppositeWindow => IExecute<Window>("getOppositeWindow");
        /// <summary>
        /// Returns the originator of the event.
        /// </summary>
        /// <value>The Window object that originated the event</value>
        public Window Window => IExecute<Window>("getWindow");
    }
}
