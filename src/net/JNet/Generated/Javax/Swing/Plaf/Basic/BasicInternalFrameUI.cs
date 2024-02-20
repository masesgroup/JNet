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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicInternalFrameUI
    public partial class BasicInternalFrameUI
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#%3Cinit%3E(javax.swing.JInternalFrame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        public BasicInternalFrameUI(Javax.Swing.JInternalFrame arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#getEastPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#setEastPane(javax.swing.JComponent)"/>
        /// </summary>
        public Javax.Swing.JComponent EastPane
        {
            get { return IExecute<Javax.Swing.JComponent>("getEastPane"); } set { IExecute("setEastPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#getNorthPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#setNorthPane(javax.swing.JComponent)"/>
        /// </summary>
        public Javax.Swing.JComponent NorthPane
        {
            get { return IExecute<Javax.Swing.JComponent>("getNorthPane"); } set { IExecute("setNorthPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#getSouthPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#setSouthPane(javax.swing.JComponent)"/>
        /// </summary>
        public Javax.Swing.JComponent SouthPane
        {
            get { return IExecute<Javax.Swing.JComponent>("getSouthPane"); } set { IExecute("setSouthPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#getWestPane()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#setWestPane(javax.swing.JComponent)"/>
        /// </summary>
        public Javax.Swing.JComponent WestPane
        {
            get { return IExecute<Javax.Swing.JComponent>("getWestPane"); } set { IExecute("setWestPane", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.html#isKeyBindingActive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsKeyBindingActive()
        {
            return IExecute<bool>("isKeyBindingActive");
        }

        #endregion

        #region Nested classes
        #region InternalFrameLayout
        public partial class InternalFrameLayout
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.InternalFrameLayout.html#%3Cinit%3E(javax.swing.plaf.basic.BasicInternalFrameUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicInternalFrameUI"/></param>
            public InternalFrameLayout(Javax.Swing.Plaf.Basic.BasicInternalFrameUI arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.InternalFrameLayout.html#minimumLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.InternalFrameLayout.html#preferredLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.InternalFrameLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            public void AddLayoutComponent(Java.Lang.String arg0, Java.Awt.Component arg1)
            {
                IExecute("addLayoutComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.InternalFrameLayout.html#layoutContainer(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            public void LayoutContainer(Java.Awt.Container arg0)
            {
                IExecute("layoutContainer", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicInternalFrameUI.InternalFrameLayout.html#removeLayoutComponent(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            public void RemoveLayoutComponent(Java.Awt.Component arg0)
            {
                IExecute("removeLayoutComponent", arg0);
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