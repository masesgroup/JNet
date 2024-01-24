/*
*  Copyright 2024 MASES s.r.l.
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

/*
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region InputMethodEvent
    public partial class InputMethodEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#%3Cinit%3E(java.awt.Component,int,java.awt.font.TextHitInfo,java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg3"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        public InputMethodEvent(Java.Awt.Component arg0, int arg1, Java.Awt.FontNs.TextHitInfo arg2, Java.Awt.FontNs.TextHitInfo arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#%3Cinit%3E(java.awt.Component,int,java.text.AttributedCharacterIterator,int,java.awt.font.TextHitInfo,java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg5"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        public InputMethodEvent(Java.Awt.Component arg0, int arg1, Java.Text.AttributedCharacterIterator arg2, int arg3, Java.Awt.FontNs.TextHitInfo arg4, Java.Awt.FontNs.TextHitInfo arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#%3Cinit%3E(java.awt.Component,int,long,java.text.AttributedCharacterIterator,int,java.awt.font.TextHitInfo,java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Java.Text.AttributedCharacterIterator"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <param name="arg6"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        public InputMethodEvent(Java.Awt.Component arg0, int arg1, long arg2, Java.Text.AttributedCharacterIterator arg3, int arg4, Java.Awt.FontNs.TextHitInfo arg5, Java.Awt.FontNs.TextHitInfo arg6)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#CARET_POSITION_CHANGED"/>
        /// </summary>
        public static int CARET_POSITION_CHANGED { get { if (!_CARET_POSITION_CHANGEDReady) { _CARET_POSITION_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "CARET_POSITION_CHANGED"); _CARET_POSITION_CHANGEDReady = true; } return _CARET_POSITION_CHANGEDContent; } }
        private static int _CARET_POSITION_CHANGEDContent = default;
        private static bool _CARET_POSITION_CHANGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#INPUT_METHOD_FIRST"/>
        /// </summary>
        public static int INPUT_METHOD_FIRST { get { if (!_INPUT_METHOD_FIRSTReady) { _INPUT_METHOD_FIRSTContent = SGetField<int>(LocalBridgeClazz, "INPUT_METHOD_FIRST"); _INPUT_METHOD_FIRSTReady = true; } return _INPUT_METHOD_FIRSTContent; } }
        private static int _INPUT_METHOD_FIRSTContent = default;
        private static bool _INPUT_METHOD_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#INPUT_METHOD_LAST"/>
        /// </summary>
        public static int INPUT_METHOD_LAST { get { if (!_INPUT_METHOD_LASTReady) { _INPUT_METHOD_LASTContent = SGetField<int>(LocalBridgeClazz, "INPUT_METHOD_LAST"); _INPUT_METHOD_LASTReady = true; } return _INPUT_METHOD_LASTContent; } }
        private static int _INPUT_METHOD_LASTContent = default;
        private static bool _INPUT_METHOD_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#INPUT_METHOD_TEXT_CHANGED"/>
        /// </summary>
        public static int INPUT_METHOD_TEXT_CHANGED { get { if (!_INPUT_METHOD_TEXT_CHANGEDReady) { _INPUT_METHOD_TEXT_CHANGEDContent = SGetField<int>(LocalBridgeClazz, "INPUT_METHOD_TEXT_CHANGED"); _INPUT_METHOD_TEXT_CHANGEDReady = true; } return _INPUT_METHOD_TEXT_CHANGEDContent; } }
        private static int _INPUT_METHOD_TEXT_CHANGEDContent = default;
        private static bool _INPUT_METHOD_TEXT_CHANGEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#getCaret()"/> 
        /// </summary>
        public Java.Awt.FontNs.TextHitInfo Caret
        {
            get { return IExecute<Java.Awt.FontNs.TextHitInfo>("getCaret"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#getCommittedCharacterCount()"/> 
        /// </summary>
        public int CommittedCharacterCount
        {
            get { return IExecute<int>("getCommittedCharacterCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#getText()"/> 
        /// </summary>
        public Java.Text.AttributedCharacterIterator Text
        {
            get { return IExecute<Java.Text.AttributedCharacterIterator>("getText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#getVisiblePosition()"/> 
        /// </summary>
        public Java.Awt.FontNs.TextHitInfo VisiblePosition
        {
            get { return IExecute<Java.Awt.FontNs.TextHitInfo>("getVisiblePosition"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#getWhen()"/> 
        /// </summary>
        public long When
        {
            get { return IExecute<long>("getWhen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#isConsumed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsConsumed()
        {
            return IExecute<bool>("isConsumed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/InputMethodEvent.html#consume()"/>
        /// </summary>
        public void Consume()
        {
            IExecute("consume");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}