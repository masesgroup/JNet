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

namespace Java.Awt.Event
{
    public class ItemEvent : AWTEvent
    {
        public override string ClassName => "java.awt.event.ItemEvent";
        /// <summary>
        /// Returns the item affected by the event.
        /// </summary>
        public Object Item => IExecute<Object>("getItem");
        /// <summary>
        /// Returns the originator of the event.
        /// </summary>
        public ItemSelectable ItemSelectable => IExecute<ItemSelectable>("getItemSelectable");
        /// <summary>
        /// Returns the type of state change(selected or deselected).
        /// </summary>
        public int StateChange => IExecute<int>("getStateChange");
    }
}
