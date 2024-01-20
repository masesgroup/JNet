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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JRootPane
    public partial class JRootPane
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JRootPane"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JRootPane t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#COLOR_CHOOSER_DIALOG"/>
        /// </summary>
        public static int COLOR_CHOOSER_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "COLOR_CHOOSER_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#ERROR_DIALOG"/>
        /// </summary>
        public static int ERROR_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "ERROR_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#FILE_CHOOSER_DIALOG"/>
        /// </summary>
        public static int FILE_CHOOSER_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "FILE_CHOOSER_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#FRAME"/>
        /// </summary>
        public static int FRAME { get { return SGetField<int>(LocalBridgeClazz, "FRAME"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#INFORMATION_DIALOG"/>
        /// </summary>
        public static int INFORMATION_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "INFORMATION_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#NONE"/>
        /// </summary>
        public static int NONE { get { return SGetField<int>(LocalBridgeClazz, "NONE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#PLAIN_DIALOG"/>
        /// </summary>
        public static int PLAIN_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "PLAIN_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#QUESTION_DIALOG"/>
        /// </summary>
        public static int QUESTION_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "QUESTION_DIALOG"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#WARNING_DIALOG"/>
        /// </summary>
        public static int WARNING_DIALOG { get { return SGetField<int>(LocalBridgeClazz, "WARNING_DIALOG"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getContentPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setContentPane(java.awt.Container)"/>
        /// </summary>
        public Java.Awt.Container ContentPane
        {
            get { return IExecute<Java.Awt.Container>("getContentPane"); } set { IExecute("setContentPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getDefaultButton()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setDefaultButton(javax.swing.JButton)"/>
        /// </summary>
        public Javax.Swing.JButton DefaultButton
        {
            get { return IExecute<Javax.Swing.JButton>("getDefaultButton"); } set { IExecute("setDefaultButton", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getGlassPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setGlassPane(java.awt.Component)"/>
        /// </summary>
        public Java.Awt.Component GlassPane
        {
            get { return IExecute<Java.Awt.Component>("getGlassPane"); } set { IExecute("setGlassPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getJMenuBar()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setJMenuBar(javax.swing.JMenuBar)"/>
        /// </summary>
        public Javax.Swing.JMenuBar JMenuBar
        {
            get { return IExecute<Javax.Swing.JMenuBar>("getJMenuBar"); } set { IExecute("setJMenuBar", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getLayeredPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setLayeredPane(javax.swing.JLayeredPane)"/>
        /// </summary>
        public Javax.Swing.JLayeredPane LayeredPane
        {
            get { return IExecute<Javax.Swing.JLayeredPane>("getLayeredPane"); } set { IExecute("setLayeredPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#getWindowDecorationStyle()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setWindowDecorationStyle(int)"/>
        /// </summary>
        public int WindowDecorationStyle
        {
            get { return IExecute<int>("getWindowDecorationStyle"); } set { IExecute("setWindowDecorationStyle", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JRootPane.html#setUI(javax.swing.plaf.RootPaneUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.RootPaneUI"/></param>
        public void SetUI(Javax.Swing.Plaf.RootPaneUI arg0)
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