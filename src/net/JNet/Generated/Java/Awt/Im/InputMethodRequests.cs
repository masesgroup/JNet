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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Im
{
    #region IInputMethodRequests
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IInputMethodRequests
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getCommittedTextLength()"/> 
        /// </summary>
        int CommittedTextLength { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getInsertPositionOffset()"/> 
        /// </summary>
        int InsertPositionOffset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getLocationOffset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        Java.Awt.FontNs.TextHitInfo GetLocationOffset(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getTextLocation(java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        Java.Awt.Rectangle GetTextLocation(Java.Awt.FontNs.TextHitInfo arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#cancelLatestCommittedText(java.text.AttributedCharacterIterator.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        Java.Text.AttributedCharacterIterator CancelLatestCommittedText(Java.Text.AttributedCharacterIterator.Attribute[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getCommittedText(int,int,java.text.AttributedCharacterIterator.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        Java.Text.AttributedCharacterIterator GetCommittedText(int arg0, int arg1, Java.Text.AttributedCharacterIterator.Attribute[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getSelectedText(java.text.AttributedCharacterIterator.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        Java.Text.AttributedCharacterIterator GetSelectedText(Java.Text.AttributedCharacterIterator.Attribute[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region InputMethodRequests
    public partial class InputMethodRequests : Java.Awt.Im.IInputMethodRequests
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getCommittedTextLength()"/> 
        /// </summary>
        public int CommittedTextLength
        {
            get { return IExecuteWithSignature<int>("getCommittedTextLength", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getInsertPositionOffset()"/> 
        /// </summary>
        public int InsertPositionOffset
        {
            get { return IExecuteWithSignature<int>("getInsertPositionOffset", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getLocationOffset(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.FontNs.TextHitInfo"/></returns>
        public Java.Awt.FontNs.TextHitInfo GetLocationOffset(int arg0, int arg1)
        {
            return IExecute<Java.Awt.FontNs.TextHitInfo>("getLocationOffset", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getTextLocation(java.awt.font.TextHitInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.FontNs.TextHitInfo"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetTextLocation(Java.Awt.FontNs.TextHitInfo arg0)
        {
            return IExecuteWithSignature<Java.Awt.Rectangle>("getTextLocation", "(Ljava/awt/font/TextHitInfo;)Ljava/awt/Rectangle;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#cancelLatestCommittedText(java.text.AttributedCharacterIterator.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        public Java.Text.AttributedCharacterIterator CancelLatestCommittedText(Java.Text.AttributedCharacterIterator.Attribute[] arg0)
        {
            return IExecuteWithSignature<Java.Text.AttributedCharacterIterator>("cancelLatestCommittedText", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getCommittedText(int,int,java.text.AttributedCharacterIterator.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        public Java.Text.AttributedCharacterIterator GetCommittedText(int arg0, int arg1, Java.Text.AttributedCharacterIterator.Attribute[] arg2)
        {
            return IExecute<Java.Text.AttributedCharacterIterator>("getCommittedText", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/im/InputMethodRequests.html#getSelectedText(java.text.AttributedCharacterIterator.Attribute[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Text.AttributedCharacterIterator.Attribute"/></param>
        /// <returns><see cref="Java.Text.AttributedCharacterIterator"/></returns>
        public Java.Text.AttributedCharacterIterator GetSelectedText(Java.Text.AttributedCharacterIterator.Attribute[] arg0)
        {
            return IExecuteWithSignature<Java.Text.AttributedCharacterIterator>("getSelectedText", "([Ljava/text/AttributedCharacterIterator$Attribute;)Ljava/text/AttributedCharacterIterator;", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}