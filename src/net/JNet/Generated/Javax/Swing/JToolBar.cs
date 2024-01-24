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

namespace Javax.Swing
{
    #region JToolBar
    public partial class JToolBar
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public JToolBar(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public JToolBar(string arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public JToolBar(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JToolBar"/> to <see cref="Javax.Swing.SwingConstants"/>
        /// </summary>
        public static implicit operator Javax.Swing.SwingConstants(Javax.Swing.JToolBar t) => t.Cast<Javax.Swing.SwingConstants>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JToolBar"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JToolBar t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#getMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#setMargin(java.awt.Insets)"/>
        /// </summary>
        public Java.Awt.Insets Margin
        {
            get { return IExecute<Java.Awt.Insets>("getMargin"); } set { IExecute("setMargin", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#getOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#setOrientation(int)"/>
        /// </summary>
        public int Orientation
        {
            get { return IExecute<int>("getOrientation"); } set { IExecute("setOrientation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#isBorderPainted()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsBorderPainted()
        {
            return IExecute<bool>("isBorderPainted");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#isFloatable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFloatable()
        {
            return IExecute<bool>("isFloatable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#isRollover()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRollover()
        {
            return IExecute<bool>("isRollover");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#getComponentIndex(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetComponentIndex(Java.Awt.Component arg0)
        {
            return IExecute<int>("getComponentIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#getComponentAtIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetComponentAtIndex(int arg0)
        {
            return IExecute<Java.Awt.Component>("getComponentAtIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#add(javax.swing.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Action"/></param>
        /// <returns><see cref="Javax.Swing.JButton"/></returns>
        public Javax.Swing.JButton Add(Javax.Swing.Action arg0)
        {
            return IExecute<Javax.Swing.JButton>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#addSeparator()"/>
        /// </summary>
        public void AddSeparator()
        {
            IExecute("addSeparator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#addSeparator(java.awt.Dimension)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
        public void AddSeparator(Java.Awt.Dimension arg0)
        {
            IExecute("addSeparator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#setBorderPainted(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetBorderPainted(bool arg0)
        {
            IExecute("setBorderPainted", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#setFloatable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetFloatable(bool arg0)
        {
            IExecute("setFloatable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#setRollover(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRollover(bool arg0)
        {
            IExecute("setRollover", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.html#setUI(javax.swing.plaf.ToolBarUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.ToolBarUI"/></param>
        public void SetUI(Javax.Swing.Plaf.ToolBarUI arg0)
        {
            IExecute("setUI", arg0);
        }

        #endregion

        #region Nested classes
        #region Separator
        public partial class Separator
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.Separator.html#%3Cinit%3E(java.awt.Dimension)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Dimension"/></param>
            public Separator(Java.Awt.Dimension arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.Separator.html#getSeparatorSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JToolBar.Separator.html#setSeparatorSize(java.awt.Dimension)"/>
            /// </summary>
            public Java.Awt.Dimension SeparatorSize
            {
                get { return IExecute<Java.Awt.Dimension>("getSeparatorSize"); } set { IExecute("setSeparatorSize", value); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}