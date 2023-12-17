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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JTextPane
    public partial class JTextPane
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#%3Cinit%3E(javax.swing.text.StyledDocument)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.StyledDocument"/></param>
        public JTextPane(Javax.Swing.Text.StyledDocument arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getCharacterAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.AttributeSet CharacterAttributes
        {
            get { return IExecute<Javax.Swing.Text.AttributeSet>("getCharacterAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getInputAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.MutableAttributeSet InputAttributes
        {
            get { return IExecute<Javax.Swing.Text.MutableAttributeSet>("getInputAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getLogicalStyle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#setLogicalStyle(javax.swing.text.Style)"/>
        /// </summary>
        public Javax.Swing.Text.Style LogicalStyle
        {
            get { return IExecute<Javax.Swing.Text.Style>("getLogicalStyle"); } set { IExecute("setLogicalStyle", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getParagraphAttributes()"/> 
        /// </summary>
        public Javax.Swing.Text.AttributeSet ParagraphAttributes
        {
            get { return IExecute<Javax.Swing.Text.AttributeSet>("getParagraphAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getStyledDocument()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#setStyledDocument(javax.swing.text.StyledDocument)"/>
        /// </summary>
        public Javax.Swing.Text.StyledDocument StyledDocument
        {
            get { return IExecute<Javax.Swing.Text.StyledDocument>("getStyledDocument"); } set { IExecute("setStyledDocument", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#addStyle(java.lang.String,javax.swing.text.Style)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Text.Style"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style AddStyle(string arg0, Javax.Swing.Text.Style arg1)
        {
            return IExecute<Javax.Swing.Text.Style>("addStyle", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#getStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.Text.Style"/></returns>
        public Javax.Swing.Text.Style GetStyle(string arg0)
        {
            return IExecute<Javax.Swing.Text.Style>("getStyle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#insertComponent(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void InsertComponent(Java.Awt.Component arg0)
        {
            IExecute("insertComponent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#insertIcon(javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        public void InsertIcon(Javax.Swing.Icon arg0)
        {
            IExecute("insertIcon", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#removeStyle(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void RemoveStyle(string arg0)
        {
            IExecute("removeStyle", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#setCharacterAttributes(javax.swing.text.AttributeSet,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetCharacterAttributes(Javax.Swing.Text.AttributeSet arg0, bool arg1)
        {
            IExecute("setCharacterAttributes", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JTextPane.html#setParagraphAttributes(javax.swing.text.AttributeSet,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Text.AttributeSet"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetParagraphAttributes(Javax.Swing.Text.AttributeSet arg0, bool arg1)
        {
            IExecute("setParagraphAttributes", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}