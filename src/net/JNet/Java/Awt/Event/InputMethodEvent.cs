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

using Java.Awt.Font;
using Java.Text;

namespace Java.Awt.Event
{
    public class InputMethodEvent : AWTEvent
    {
        public override string ClassName => "java.awt.event.InputMethodEvent";

        /// <summary>
        /// Consumes this event so that it will not be processed in the default manner by the source which originated it.
        /// </summary>
        public void Consume() { IExecute("consume"); }
        /// <summary>
        /// Gets the caret.
        /// </summary>
        public TextHitInfo Caret => IExecute<TextHitInfo>("getCaret");
        /// <summary>
        /// Gets the number of committed characters in the text.
        /// </summary>
        public int CommittedCharacterCount => IExecute<int>("getCommittedCharacterCount");
        /// <summary>
        /// Gets the combined committed and composed text.
        /// </summary>
        public AttributedCharacterIterator Text => IExecute<AttributedCharacterIterator>("getText");
        /// <summary>
        /// Gets the position that's most important to be visible.
        /// </summary>
        public TextHitInfo VisiblePosition => IExecute<TextHitInfo>("getVisiblePosition");
        /// <summary>
        /// Returns the time stamp of when this event occurred.
        /// </summary>
        public long When => IExecute<long>("getWhen");
        /// <summary>
        /// Returns whether or not this event has been consumed.
        /// </summary>
        public bool IsConsumed => IExecute<bool>("isConsumed");
    }
}
