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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#<init>(boolean,int,int)
        /// </summary>
        public InputMethodHighlight(bool arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#<init>(boolean,int)
        /// </summary>
        public InputMethodHighlight(bool arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#RAW_TEXT
        /// </summary>
        public static int RAW_TEXT => Clazz.GetField<int>("RAW_TEXT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#CONVERTED_TEXT
        /// </summary>
        public static int CONVERTED_TEXT => Clazz.GetField<int>("CONVERTED_TEXT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#UNSELECTED_RAW_TEXT_HIGHLIGHT
        /// </summary>
        public static Java.Awt.Im.InputMethodHighlight UNSELECTED_RAW_TEXT_HIGHLIGHT => Clazz.GetField<Java.Awt.Im.InputMethodHighlight>("UNSELECTED_RAW_TEXT_HIGHLIGHT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#SELECTED_RAW_TEXT_HIGHLIGHT
        /// </summary>
        public static Java.Awt.Im.InputMethodHighlight SELECTED_RAW_TEXT_HIGHLIGHT => Clazz.GetField<Java.Awt.Im.InputMethodHighlight>("SELECTED_RAW_TEXT_HIGHLIGHT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#UNSELECTED_CONVERTED_TEXT_HIGHLIGHT
        /// </summary>
        public static Java.Awt.Im.InputMethodHighlight UNSELECTED_CONVERTED_TEXT_HIGHLIGHT => Clazz.GetField<Java.Awt.Im.InputMethodHighlight>("UNSELECTED_CONVERTED_TEXT_HIGHLIGHT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#SELECTED_CONVERTED_TEXT_HIGHLIGHT
        /// </summary>
        public static Java.Awt.Im.InputMethodHighlight SELECTED_CONVERTED_TEXT_HIGHLIGHT => Clazz.GetField<Java.Awt.Im.InputMethodHighlight>("SELECTED_CONVERTED_TEXT_HIGHLIGHT");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#getState() 
        /// </summary>
        public int State
        {
            get { return IExecute<int>("getState"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#getVariation() 
        /// </summary>
        public int Variation
        {
            get { return IExecute<int>("getVariation"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodHighlight.html#isSelected()
        /// </summary>
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