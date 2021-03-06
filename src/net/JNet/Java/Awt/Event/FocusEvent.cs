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
    public class FocusEvent : ComponentEvent
    {
        public override string ClassName => "java.awt.event.FocusEvent";

        /// <summary>
        /// Returns the other <see cref="Component"/> involved in this focus change.
        /// </summary>
        public Component OppositeComponent => IExecute<Component>("getOppositeComponent");
        /// <summary>
        /// Identifies the focus change event as temporary or permanent.
        /// </summary>
        public bool IsTemporary => IExecute<bool>("isTemporary");
    }
}
