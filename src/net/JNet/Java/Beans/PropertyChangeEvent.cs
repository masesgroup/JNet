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

using Java.Lang;
using Java.Util;

namespace Java.Beans
{
    public class PropertyChangeEvent : EventObject
    {
        public override string ClassName => "java.beans.PropertyChangeEvent";
        /// <summary>
        /// Gets the programmatic name of the property that was changed.
        /// </summary>
        /// <value>The programmatic name of the property that was changed. May be null if multiple properties have changed.</value>
        public string PropertyName => IExecute<string>("getPropertyName");
        /// <summary>
        /// Gets the new value for the property, expressed as an <see cref="object"/>.
        /// </summary>
        /// <value>The new value for the property, expressed as an <see cref="object"/>. May be null if multiple properties have changed.</value>
        public Object NewValue => IExecute<Object>("getNewValue");
        /// <summary>
        /// Gets the old value for the property, expressed as an <see cref="object"/>.
        /// </summary>
        /// <value>The old value for the property, expressed as an <see cref="object"/>. May be null if multiple properties have changed.</value>
        public Object OldValue => IExecute<Object>("getOldValue");
        /// <summary>
        /// Gets/Sets the propagationId <see cref="object"/> for the event..
        /// </summary>
        /// <value>The propagationId <see cref="object"/> associated with a bound/constrained property update.</value>
        /// <remarks>The "propagationId" field is reserved for future use. In Beans 1.0 the sole requirement is that if a listener catches a PropertyChangeEvent and then fires a PropertyChangeEvent of its own, then it should make sure that it propagates the propagationId field from its incoming event to its outgoing event.</remarks>
        public Object PropagationId
        {
            get { return IExecute<Object>("getPropagationId"); }
            set { IExecute<Object>("setPropagationId", value); }
        }
    }
}
