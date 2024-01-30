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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicComboBoxUI
    public partial class BasicComboBoxUI
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.html#addEditor()"/>
        /// </summary>
        public void AddEditor()
        {
            IExecute("addEditor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.html#configureArrowButton()"/>
        /// </summary>
        public void ConfigureArrowButton()
        {
            IExecute("configureArrowButton");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.html#paintCurrentValue(java.awt.Graphics,java.awt.Rectangle,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void PaintCurrentValue(Java.Awt.Graphics arg0, Java.Awt.Rectangle arg1, bool arg2)
        {
            IExecute("paintCurrentValue", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.html#paintCurrentValueBackground(java.awt.Graphics,java.awt.Rectangle,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void PaintCurrentValueBackground(Java.Awt.Graphics arg0, Java.Awt.Rectangle arg1, bool arg2)
        {
            IExecute("paintCurrentValueBackground", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.html#removeEditor()"/>
        /// </summary>
        public void RemoveEditor()
        {
            IExecute("removeEditor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.html#unconfigureArrowButton()"/>
        /// </summary>
        public void UnconfigureArrowButton()
        {
            IExecute("unconfigureArrowButton");
        }

        #endregion

        #region Nested classes
        #region ComboBoxLayoutManager
        public partial class ComboBoxLayoutManager
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ComboBoxLayoutManager.html#%3Cinit%3E(javax.swing.plaf.basic.BasicComboBoxUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI"/></param>
            public ComboBoxLayoutManager(Javax.Swing.Plaf.Basic.BasicComboBoxUI arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ComboBoxLayoutManager.html#minimumLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ComboBoxLayoutManager.html#preferredLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ComboBoxLayoutManager.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
            {
                IExecute("addLayoutComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ComboBoxLayoutManager.html#layoutContainer(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            public void LayoutContainer(Java.Awt.Container arg0)
            {
                IExecute("layoutContainer", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ComboBoxLayoutManager.html#removeLayoutComponent(java.awt.Component)"/>
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

        #region FocusHandler
        public partial class FocusHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.FocusHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicComboBoxUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI"/></param>
            public FocusHandler(Javax.Swing.Plaf.Basic.BasicComboBoxUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI.FocusHandler"/> to <see cref="Java.Awt.EventNs.FocusListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.FocusListener(Javax.Swing.Plaf.Basic.BasicComboBoxUI.FocusHandler t) => t.Cast<Java.Awt.EventNs.FocusListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.FocusHandler.html#focusGained(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusGained", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.FocusHandler.html#focusLost(java.awt.event.FocusEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
            public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusLost", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ItemHandler
        public partial class ItemHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ItemHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicComboBoxUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI"/></param>
            public ItemHandler(Javax.Swing.Plaf.Basic.BasicComboBoxUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI.ItemHandler"/> to <see cref="Java.Awt.EventNs.ItemListener"/>
            /// </summary>
            public static implicit operator Java.Awt.EventNs.ItemListener(Javax.Swing.Plaf.Basic.BasicComboBoxUI.ItemHandler t) => t.Cast<Java.Awt.EventNs.ItemListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ItemHandler.html#itemStateChanged(java.awt.event.ItemEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.EventNs.ItemEvent"/></param>
            public void ItemStateChanged(Java.Awt.EventNs.ItemEvent arg0)
            {
                IExecute("itemStateChanged", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListDataHandler
        public partial class ListDataHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ListDataHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicComboBoxUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI"/></param>
            public ListDataHandler(Javax.Swing.Plaf.Basic.BasicComboBoxUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI.ListDataHandler"/> to <see cref="Javax.Swing.Event.ListDataListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.ListDataListener(Javax.Swing.Plaf.Basic.BasicComboBoxUI.ListDataHandler t) => t.Cast<Javax.Swing.Event.ListDataListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ListDataHandler.html#contentsChanged(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void ContentsChanged(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecute("contentsChanged", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ListDataHandler.html#intervalAdded(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void IntervalAdded(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecute("intervalAdded", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.ListDataHandler.html#intervalRemoved(javax.swing.event.ListDataEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ListDataEvent"/></param>
            public void IntervalRemoved(Javax.Swing.Event.ListDataEvent arg0)
            {
                IExecute("intervalRemoved", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PropertyChangeHandler
        public partial class PropertyChangeHandler
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.PropertyChangeHandler.html#%3Cinit%3E(javax.swing.plaf.basic.BasicComboBoxUI)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI"/></param>
            public PropertyChangeHandler(Javax.Swing.Plaf.Basic.BasicComboBoxUI arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.Plaf.Basic.BasicComboBoxUI.PropertyChangeHandler"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicComboBoxUI.PropertyChangeHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicComboBoxUI.PropertyChangeHandler.html#propertyChange(java.beans.PropertyChangeEvent)"/>
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