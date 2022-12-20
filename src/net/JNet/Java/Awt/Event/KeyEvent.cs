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
    public class KeyEvent : InputEvent
    {
        public override string ClassName => "java.awt.event.KeyEvent";
        /// <summary>
        ///  Returns an extended key code for the event.
        /// </summary>
        public int ExtendedKeyCode => IExecute<int>("getExtendedKeyCode");
        /// <summary>
        ///   Returns the character associated with the key in this event.
        /// </summary>
        public char KeyChar => IExecute<char>("getKeyChar");
        /// <summary>
        ///  Returns the integer keyCode associated with the key in this event.
        /// </summary>
        public int KeyCode => IExecute<int>("getKeyCode");
        /// <summary>
        ///  Returns the location of the key that originated this key event.
        /// </summary>
        public int KeyLocation => IExecute<int>("getKeyLocation");
        /// <summary>
        ///  Returns whether the key in this event is an "action" key.
        /// </summary>
        public bool IsActionKey => IExecute<bool>("isActionKey");
        /// <summary>
        /// Set the keyChar value to indicate a logical character.
        /// </summary>
        /// <param name="keyChar">a char corresponding to to the combination of keystrokes that make up this event.</param>
        public void SetKeyChar(char keyChar) => IExecute("setKeyChar", keyChar);
        /// <summary>
        /// Set the keyCode value to indicate a physical key.
        /// </summary>
        /// <param name="keyCode">An integer corresponding to an actual key on the keyboard.</param>
        public void SetKeyCode(int keyCode) => IExecute("setKeyCode", keyCode);
    }
}
