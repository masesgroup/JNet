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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JLabel
    public partial class JLabel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JLabel(string arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#%3Cinit%3E(java.lang.String,javax.swing.Icon,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public JLabel(string arg0, Javax.Swing.Icon arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public JLabel(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#%3Cinit%3E(javax.swing.Icon,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JLabel(Javax.Swing.Icon arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#%3Cinit%3E(javax.swing.Icon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Icon"/></param>
        public JLabel(Javax.Swing.Icon arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLabel"/> to <see cref="Javax.Swing.SwingConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.SwingConstants(Javax.Swing.JLabel t) => t.Cast<Javax.Swing.SwingConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JLabel"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JLabel t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getDisabledIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setDisabledIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon DisabledIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getDisabledIcon"); } set { IExecute("setDisabledIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getDisplayedMnemonic()"/> 
        /// </summary>
        public int DisplayedMnemonic
        {
            get { return IExecute<int>("getDisplayedMnemonic"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getDisplayedMnemonicIndex()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setDisplayedMnemonicIndex(int)"/>
        /// </summary>
        public int DisplayedMnemonicIndex
        {
            get { return IExecute<int>("getDisplayedMnemonicIndex"); } set { IExecute("setDisplayedMnemonicIndex", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getHorizontalAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setHorizontalAlignment(int)"/>
        /// </summary>
        public int HorizontalAlignment
        {
            get { return IExecute<int>("getHorizontalAlignment"); } set { IExecute("setHorizontalAlignment", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getHorizontalTextPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setHorizontalTextPosition(int)"/>
        /// </summary>
        public int HorizontalTextPosition
        {
            get { return IExecute<int>("getHorizontalTextPosition"); } set { IExecute("setHorizontalTextPosition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon Icon
        {
            get { return IExecute<Javax.Swing.Icon>("getIcon"); } set { IExecute("setIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getIconTextGap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setIconTextGap(int)"/>
        /// </summary>
        public int IconTextGap
        {
            get { return IExecute<int>("getIconTextGap"); } set { IExecute("setIconTextGap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getLabelFor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setLabelFor(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component LabelFor
        {
            get { return IExecute<Java.Awt.Component>("getLabelFor"); } set { IExecute("setLabelFor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getText()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setText(java.lang.String)"/>
        /// </summary>
        public string Text
        {
            get { return IExecute<string>("getText"); } set { IExecute("setText", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getVerticalAlignment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setVerticalAlignment(int)"/>
        /// </summary>
        public int VerticalAlignment
        {
            get { return IExecute<int>("getVerticalAlignment"); } set { IExecute("setVerticalAlignment", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#getVerticalTextPosition()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setVerticalTextPosition(int)"/>
        /// </summary>
        public int VerticalTextPosition
        {
            get { return IExecute<int>("getVerticalTextPosition"); } set { IExecute("setVerticalTextPosition", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setDisplayedMnemonic(char)"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        public void SetDisplayedMnemonic(char arg0)
        {
            IExecute("setDisplayedMnemonic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setDisplayedMnemonic(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetDisplayedMnemonic(int arg0)
        {
            IExecute("setDisplayedMnemonic", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JLabel.html#setUI(javax.swing.plaf.LabelUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.LabelUI"/></param>
        public void SetUI(Javax.Swing.Plaf.LabelUI arg0)
        {
            IExecute("setUI", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}