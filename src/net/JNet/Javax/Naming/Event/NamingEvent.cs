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

namespace Javax.Naming.Event
{
    public class NamingEvent : EventObject
    {
        public override string ClassName => "javax.naming.event.NamingEvent";
        /// <summary>
        /// Invokes the appropriate listener method on this event. The default implementation of this method handles the following event types: OBJECT_ADDED, OBJECT_REMOVED, OBJECT_RENAMED, OBJECT_CHANGED.
        /// </summary>
        /// <param name="listener">The nonnull listener.</param>
        /// <remarks>The listener method is executed in the same thread as this method. See the package description for more information on threading issues.</remarks>
        public void Dispatch(NamingListener listener) => IExecute("dispatch", listener);
        /// <summary>
        /// Retrieves the change information for this event.
        /// </summary>
        public Object ChangeInfo => IExecute<Object>("getChangeInfo");
        /// <summary>
        /// Retrieves the event source that fired this event.
        /// </summary>
        public EventContext EventContext => IExecute<EventContext>("getEventContext");
        /// <summary>
        /// Retrieves the binding of the object after the change.
        /// </summary>
        public Binding NewBinding => IExecute<Binding>("getNewBinding");
        /// <summary>
        /// Retrieves the binding of the object before the change.
        /// </summary>
        public Binding OldBinding => IExecute<Binding>("getOldBinding");
        /// <summary>
        /// Returns the type of this event.
        /// </summary>
        public int Type => IExecute<int>("getType");
    }
}
