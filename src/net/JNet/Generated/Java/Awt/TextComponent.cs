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

namespace Java.Awt
{
    #region TextComponent
    public partial class TextComponent
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.TextComponent"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.TextComponent t) => t.Cast<Javax.Accessibility.Accessible>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#getCaretPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#setCaretPosition(int)"/>
        /// </summary>
        public int CaretPosition
        {
            get { return IExecute<int>("getCaretPosition"); } set { IExecute("setCaretPosition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#getSelectedText()"/> 
        /// </summary>
        public string SelectedText
        {
            get { return IExecute<string>("getSelectedText"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#getSelectionEnd()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#setSelectionEnd(int)"/>
        /// </summary>
        public int SelectionEnd
        {
            get { return IExecute<int>("getSelectionEnd"); } set { IExecute("setSelectionEnd", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#getSelectionStart()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#setSelectionStart(int)"/>
        /// </summary>
        public int SelectionStart
        {
            get { return IExecute<int>("getSelectionStart"); } set { IExecute("setSelectionStart", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#getText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#setText(java.lang.String)"/>
        /// </summary>
        public string Text
        {
            get { return IExecute<string>("getText"); } set { IExecute("setText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#getTextListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.TextListener[] TextListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.TextListener>("getTextListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#isEditable()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsEditable()
        {
            return IExecute<bool>("isEditable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#addTextListener(java.awt.event.TextListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.TextListener"/></param>
        public void AddTextListener(Java.Awt.EventNs.TextListener arg0)
        {
            IExecute("addTextListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#removeTextListener(java.awt.event.TextListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.TextListener"/></param>
        public void RemoveTextListener(Java.Awt.EventNs.TextListener arg0)
        {
            IExecute("removeTextListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#select(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Select(int arg0, int arg1)
        {
            IExecute("select", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#selectAll()"/>
        /// </summary>
        public void SelectAll()
        {
            IExecute("selectAll");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/TextComponent.html#setEditable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetEditable(bool arg0)
        {
            IExecute("setEditable", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}