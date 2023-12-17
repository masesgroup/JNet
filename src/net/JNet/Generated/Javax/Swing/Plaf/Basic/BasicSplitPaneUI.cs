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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicSplitPaneUI
    public partial class BasicSplitPaneUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#getDivider()"/> 
        /// </summary>
        public Javax.Swing.Plaf.Basic.BasicSplitPaneDivider Divider
        {
            get { return IExecute<Javax.Swing.Plaf.Basic.BasicSplitPaneDivider>("getDivider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#getLastDragLocation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#setLastDragLocation(int)"/>
        /// </summary>
        public int LastDragLocation
        {
            get { return IExecute<int>("getLastDragLocation"); } set { IExecute("setLastDragLocation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#getNonContinuousLayoutDivider()"/> 
        /// </summary>
        public Java.Awt.Component NonContinuousLayoutDivider
        {
            get { return IExecute<Java.Awt.Component>("getNonContinuousLayoutDivider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#getOrientation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#setOrientation(int)"/>
        /// </summary>
        public int Orientation
        {
            get { return IExecute<int>("getOrientation"); } set { IExecute("setOrientation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#getSplitPane()"/> 
        /// </summary>
        public Javax.Swing.JSplitPane SplitPane
        {
            get { return IExecute<Javax.Swing.JSplitPane>("getSplitPane"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#isContinuousLayout()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsContinuousLayout()
        {
            return IExecute<bool>("isContinuousLayout");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#getInsets(javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetInsets(Javax.Swing.JComponent arg0)
        {
            return IExecute<Java.Awt.Insets>("getInsets", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#createDefaultDivider()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneDivider"/></returns>
        public Javax.Swing.Plaf.Basic.BasicSplitPaneDivider CreateDefaultDivider()
        {
            return IExecute<Javax.Swing.Plaf.Basic.BasicSplitPaneDivider>("createDefaultDivider");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.html#setContinuousLayout(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetContinuousLayout(bool arg0)
        {
            IExecute("setContinuousLayout", arg0);
        }

        #endregion

        #region Nested classes
        #region BasicHorizontalLayoutManager
        public partial class BasicHorizontalLayoutManager
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#getLayoutAlignmentX(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetLayoutAlignmentX(Java.Awt.Container arg0)
            {
                return IExecute<float>("getLayoutAlignmentX", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#getLayoutAlignmentY(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="float"/></returns>
            public float GetLayoutAlignmentY(Java.Awt.Container arg0)
            {
                return IExecute<float>("getLayoutAlignmentY", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#maximumLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension MaximumLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("maximumLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#minimumLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#preferredLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#addLayoutComponent(java.awt.Component,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public void AddLayoutComponent(Java.Awt.Component arg0, object arg1)
            {
                IExecute("addLayoutComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
            {
                IExecute("addLayoutComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#invalidateLayout(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            public void InvalidateLayout(Java.Awt.Container arg0)
            {
                IExecute("invalidateLayout", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#layoutContainer(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            public void LayoutContainer(Java.Awt.Container arg0)
            {
                IExecute("layoutContainer", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#removeLayoutComponent(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            public void RemoveLayoutComponent(Java.Awt.Component arg0)
            {
                IExecute("removeLayoutComponent", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicHorizontalLayoutManager.html#resetToPreferredSizes()"/>
            /// </summary>
            public void ResetToPreferredSizes()
            {
                IExecute("resetToPreferredSizes");
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region BasicVerticalLayoutManager
        public partial class BasicVerticalLayoutManager
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.BasicVerticalLayoutManager.html#%3Cinit%3E(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI"/></param>
            public BasicVerticalLayoutManager(Javax.Swing.Plaf.Basic.BasicSplitPaneUI arg0)
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyboardDownRightHandler
        public partial class KeyboardDownRightHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardDownRightHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI"/></param>
            public KeyboardDownRightHandler(Javax.Swing.Plaf.Basic.BasicSplitPaneUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardDownRightHandler"/> to <see cref="Java.Awt.EventNs.ActionListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.ActionListener(Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardDownRightHandler t) => t.Cast<Java.Awt.EventNs.ActionListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardDownRightHandler.html#actionPerformed(java.awt.event.ActionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
            public void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
            {
                IExecute("actionPerformed", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyboardEndHandler
        public partial class KeyboardEndHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardEndHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI"/></param>
            public KeyboardEndHandler(Javax.Swing.Plaf.Basic.BasicSplitPaneUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardEndHandler"/> to <see cref="Java.Awt.EventNs.ActionListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.ActionListener(Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardEndHandler t) => t.Cast<Java.Awt.EventNs.ActionListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardEndHandler.html#actionPerformed(java.awt.event.ActionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
            public void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
            {
                IExecute("actionPerformed", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyboardHomeHandler
        public partial class KeyboardHomeHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardHomeHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI"/></param>
            public KeyboardHomeHandler(Javax.Swing.Plaf.Basic.BasicSplitPaneUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardHomeHandler"/> to <see cref="Java.Awt.EventNs.ActionListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.ActionListener(Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardHomeHandler t) => t.Cast<Java.Awt.EventNs.ActionListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardHomeHandler.html#actionPerformed(java.awt.event.ActionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
            public void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
            {
                IExecute("actionPerformed", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyboardResizeToggleHandler
        public partial class KeyboardResizeToggleHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardResizeToggleHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI"/></param>
            public KeyboardResizeToggleHandler(Javax.Swing.Plaf.Basic.BasicSplitPaneUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardResizeToggleHandler"/> to <see cref="Java.Awt.EventNs.ActionListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.ActionListener(Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardResizeToggleHandler t) => t.Cast<Java.Awt.EventNs.ActionListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardResizeToggleHandler.html#actionPerformed(java.awt.event.ActionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
            public void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
            {
                IExecute("actionPerformed", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region KeyboardUpLeftHandler
        public partial class KeyboardUpLeftHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardUpLeftHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI"/></param>
            public KeyboardUpLeftHandler(Javax.Swing.Plaf.Basic.BasicSplitPaneUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardUpLeftHandler"/> to <see cref="Java.Awt.EventNs.ActionListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.ActionListener(Javax.Swing.Plaf.Basic.BasicSplitPaneUI.KeyboardUpLeftHandler t) => t.Cast<Java.Awt.EventNs.ActionListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.KeyboardUpLeftHandler.html#actionPerformed(java.awt.event.ActionEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
            public void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
            {
                IExecute("actionPerformed", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PropertyHandler
        public partial class PropertyHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.PropertyHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicSplitPaneUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI"/></param>
            public PropertyHandler(Javax.Swing.Plaf.Basic.BasicSplitPaneUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicSplitPaneUI.PropertyHandler"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicSplitPaneUI.PropertyHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicSplitPaneUI.PropertyHandler.html#propertyChange(java.beans.PropertyChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecute("propertyChange", arg0);
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