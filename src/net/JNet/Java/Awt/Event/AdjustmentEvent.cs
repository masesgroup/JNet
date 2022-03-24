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
    public class AdjustmentEvent : AWTEvent
    {
        public override string ClassName => "java.awt.event.AdjustmentEvent";
        /// <summary>
        /// Returns the <see cref="Adjustable"/> object where this event originated.
        /// </summary>
        public Adjustable Adjustable => IExecute<Adjustable>("getAdjustable");
        /// <summary>
        /// Returns the type of adjustment which caused the value changed event.
        /// </summary>
        public int AdjustmentType => IExecute<int>("getAdjustmentType");
        /// <summary>
        /// Returns the current value in the adjustment event.
        /// </summary>
        public int Value => IExecute<int>("getValue");
        /// <summary>
        /// Returns true if this is one of multiple adjustment events.
        /// </summary>
        public bool ValueIsAdjusting => IExecute<bool>("getValueIsAdjusting");
    }
}
