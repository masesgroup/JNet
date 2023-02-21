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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicOptionPaneUI
    public partial class BasicOptionPaneUI
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.html#MinimumWidth
        /// </summary>
        public static int MinimumWidth => Clazz.GetField<int>("MinimumWidth");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.html#MinimumHeight
        /// </summary>
        public static int MinimumHeight => Clazz.GetField<int>("MinimumHeight");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.html#getMinimumOptionPaneSize() 
        /// </summary>
        public Java.Awt.Dimension MinimumOptionPaneSize
        {
            get { return IExecute<Java.Awt.Dimension>("getMinimumOptionPaneSize"); }
        }
        
        #endregion

        #region Nested classes
        #region ButtonAreaLayout
        public partial class ButtonAreaLayout
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#<init>(boolean,int)
            /// </summary>
            public ButtonAreaLayout(bool arg0, int arg1)
                : base(arg0, arg1)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Awt.LayoutManager(Javax.Swing.Plaf.Basic.BasicOptionPaneUI.ButtonAreaLayout t) => t.Cast<Java.Awt.LayoutManager>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#getCentersChildren() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#setCentersChildren(boolean)
            /// </summary>
            public bool CentersChildren
            {
                get { return IExecute<bool>("getCentersChildren"); } set { IExecute("setCentersChildren", value); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#getPadding() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#setPadding(int)
            /// </summary>
            public int Padding
            {
                get { return IExecute<int>("getPadding"); } set { IExecute("setPadding", value); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#getSyncAllWidths() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#setSyncAllWidths(boolean)
            /// </summary>
            public bool SyncAllWidths
            {
                get { return IExecute<bool>("getSyncAllWidths"); } set { IExecute("setSyncAllWidths", value); }
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#minimumLayoutSize(java.awt.Container)
            /// </summary>
            public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#preferredLayoutSize(java.awt.Container)
            /// </summary>
            public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#addLayoutComponent(java.lang.String,java.awt.Component)
            /// </summary>
            public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
            {
                IExecute("addLayoutComponent", arg0, arg1);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#layoutContainer(java.awt.Container)
            /// </summary>
            public void LayoutContainer(Java.Awt.Container arg0)
            {
                IExecute("layoutContainer", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.ButtonAreaLayout.html#removeLayoutComponent(java.awt.Component)
            /// </summary>
            public void RemoveLayoutComponent(Java.Awt.Component arg0)
            {
                IExecute("removeLayoutComponent", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PropertyChangeHandler
        public partial class PropertyChangeHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.PropertyChangeHandler.html#<init>(javax.swing.plaf.basic.BasicOptionPaneUI)
            /// </summary>
            public PropertyChangeHandler(Javax.Swing.Plaf.Basic.BasicOptionPaneUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicOptionPaneUI.PropertyChangeHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicOptionPaneUI.PropertyChangeHandler.html#propertyChange(java.beans.PropertyChangeEvent)
            /// </summary>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecute("propertyChange", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}