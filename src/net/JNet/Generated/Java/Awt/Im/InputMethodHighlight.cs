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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Im
{
    #region InputMethodHighlight
    public partial class InputMethodHighlight
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#%3Cinit%3E(boolean,int,int,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Util.Map"/></param>
        public InputMethodHighlight(bool arg0, int arg1, int arg2, Java.Util.Map<Java.Awt.FontNs.TextAttribute, object> arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#%3Cinit%3E(boolean,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public InputMethodHighlight(bool arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#%3Cinit%3E(boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public InputMethodHighlight(bool arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#CONVERTED_TEXT"/>
        /// </summary>
        public static int CONVERTED_TEXT { get { if (!_CONVERTED_TEXTReady) { _CONVERTED_TEXTContent = SGetField<int>(LocalBridgeClazz, "CONVERTED_TEXT"); _CONVERTED_TEXTReady = true; } return _CONVERTED_TEXTContent; } }
        private static int _CONVERTED_TEXTContent = default;
        private static bool _CONVERTED_TEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#RAW_TEXT"/>
        /// </summary>
        public static int RAW_TEXT { get { if (!_RAW_TEXTReady) { _RAW_TEXTContent = SGetField<int>(LocalBridgeClazz, "RAW_TEXT"); _RAW_TEXTReady = true; } return _RAW_TEXTContent; } }
        private static int _RAW_TEXTContent = default;
        private static bool _RAW_TEXTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#SELECTED_CONVERTED_TEXT_HIGHLIGHT"/>
        /// </summary>
        public static Java.Awt.Im.InputMethodHighlight SELECTED_CONVERTED_TEXT_HIGHLIGHT { get { if (!_SELECTED_CONVERTED_TEXT_HIGHLIGHTReady) { _SELECTED_CONVERTED_TEXT_HIGHLIGHTContent = SGetField<Java.Awt.Im.InputMethodHighlight>(LocalBridgeClazz, "SELECTED_CONVERTED_TEXT_HIGHLIGHT"); _SELECTED_CONVERTED_TEXT_HIGHLIGHTReady = true; } return _SELECTED_CONVERTED_TEXT_HIGHLIGHTContent; } }
        private static Java.Awt.Im.InputMethodHighlight _SELECTED_CONVERTED_TEXT_HIGHLIGHTContent = default;
        private static bool _SELECTED_CONVERTED_TEXT_HIGHLIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#SELECTED_RAW_TEXT_HIGHLIGHT"/>
        /// </summary>
        public static Java.Awt.Im.InputMethodHighlight SELECTED_RAW_TEXT_HIGHLIGHT { get { if (!_SELECTED_RAW_TEXT_HIGHLIGHTReady) { _SELECTED_RAW_TEXT_HIGHLIGHTContent = SGetField<Java.Awt.Im.InputMethodHighlight>(LocalBridgeClazz, "SELECTED_RAW_TEXT_HIGHLIGHT"); _SELECTED_RAW_TEXT_HIGHLIGHTReady = true; } return _SELECTED_RAW_TEXT_HIGHLIGHTContent; } }
        private static Java.Awt.Im.InputMethodHighlight _SELECTED_RAW_TEXT_HIGHLIGHTContent = default;
        private static bool _SELECTED_RAW_TEXT_HIGHLIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#UNSELECTED_CONVERTED_TEXT_HIGHLIGHT"/>
        /// </summary>
        public static Java.Awt.Im.InputMethodHighlight UNSELECTED_CONVERTED_TEXT_HIGHLIGHT { get { if (!_UNSELECTED_CONVERTED_TEXT_HIGHLIGHTReady) { _UNSELECTED_CONVERTED_TEXT_HIGHLIGHTContent = SGetField<Java.Awt.Im.InputMethodHighlight>(LocalBridgeClazz, "UNSELECTED_CONVERTED_TEXT_HIGHLIGHT"); _UNSELECTED_CONVERTED_TEXT_HIGHLIGHTReady = true; } return _UNSELECTED_CONVERTED_TEXT_HIGHLIGHTContent; } }
        private static Java.Awt.Im.InputMethodHighlight _UNSELECTED_CONVERTED_TEXT_HIGHLIGHTContent = default;
        private static bool _UNSELECTED_CONVERTED_TEXT_HIGHLIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#UNSELECTED_RAW_TEXT_HIGHLIGHT"/>
        /// </summary>
        public static Java.Awt.Im.InputMethodHighlight UNSELECTED_RAW_TEXT_HIGHLIGHT { get { if (!_UNSELECTED_RAW_TEXT_HIGHLIGHTReady) { _UNSELECTED_RAW_TEXT_HIGHLIGHTContent = SGetField<Java.Awt.Im.InputMethodHighlight>(LocalBridgeClazz, "UNSELECTED_RAW_TEXT_HIGHLIGHT"); _UNSELECTED_RAW_TEXT_HIGHLIGHTReady = true; } return _UNSELECTED_RAW_TEXT_HIGHLIGHTContent; } }
        private static Java.Awt.Im.InputMethodHighlight _UNSELECTED_RAW_TEXT_HIGHLIGHTContent = default;
        private static bool _UNSELECTED_RAW_TEXT_HIGHLIGHTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#getState()"/> 
        /// </summary>
        public int State
        {
            get { return IExecute<int>("getState"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#getStyle()"/> 
        /// </summary>
        public Java.Util.Map<Java.Awt.FontNs.TextAttribute, object> Style
        {
            get { return IExecute<Java.Util.Map<Java.Awt.FontNs.TextAttribute, object>>("getStyle"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#getVariation()"/> 
        /// </summary>
        public int Variation
        {
            get { return IExecute<int>("getVariation"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#isSelected()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSelected()
        {
            return IExecute<bool>("isSelected");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}