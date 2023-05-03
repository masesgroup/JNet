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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Text
{
    #region MaskFormatter
    public partial class MaskFormatter
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Text.ParseException"/>
        public MaskFormatter(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#getInvalidCharacters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#setInvalidCharacters(java.lang.String)"/>
        /// </summary>
        public string InvalidCharacters
        {
            get { return IExecute<string>("getInvalidCharacters"); } set { IExecute("setInvalidCharacters", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#getMask()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#setMask(java.lang.String)"/>
        /// </summary>
        public string Mask
        {
            get { return IExecute<string>("getMask"); } set { IExecute("setMask", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#getPlaceholder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#setPlaceholder(java.lang.String)"/>
        /// </summary>
        public string Placeholder
        {
            get { return IExecute<string>("getPlaceholder"); } set { IExecute("setPlaceholder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#getPlaceholderCharacter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#setPlaceholderCharacter(char)"/>
        /// </summary>
        public char PlaceholderCharacter
        {
            get { return IExecute<char>("getPlaceholderCharacter"); } set { IExecute("setPlaceholderCharacter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#getValidCharacters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#setValidCharacters(java.lang.String)"/>
        /// </summary>
        public string ValidCharacters
        {
            get { return IExecute<string>("getValidCharacters"); } set { IExecute("setValidCharacters", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#getValueContainsLiteralCharacters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/MaskFormatter.html#setValueContainsLiteralCharacters(boolean)"/>
        /// </summary>
        public bool ValueContainsLiteralCharacters
        {
            get { return IExecute<bool>("getValueContainsLiteralCharacters"); } set { IExecute("setValueContainsLiteralCharacters", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}