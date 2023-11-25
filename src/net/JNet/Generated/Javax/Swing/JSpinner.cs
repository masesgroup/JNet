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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region JSpinner
    public partial class JSpinner
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#%3Cinit%3E(javax.swing.SpinnerModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.SpinnerModel"/></param>
        public JSpinner(Javax.Swing.SpinnerModel arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.JSpinner"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Javax.Swing.JSpinner t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getChangeListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.ChangeListener[] ChangeListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.ChangeListener>("getChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getEditor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#setEditor(javax.swing.JComponent)"/>
        /// </summary>
        public Javax.Swing.JComponent Editor
        {
            get { return IExecute<Javax.Swing.JComponent>("getEditor"); } set { IExecute("setEditor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#setModel(javax.swing.SpinnerModel)"/>
        /// </summary>
        public Javax.Swing.SpinnerModel Model
        {
            get { return IExecute<Javax.Swing.SpinnerModel>("getModel"); } set { IExecute("setModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getNextValue()"/> 
        /// </summary>
        public object NextValue
        {
            get { return IExecute("getNextValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getPreviousValue()"/> 
        /// </summary>
        public object PreviousValue
        {
            get { return IExecute("getPreviousValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#getValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#setValue(java.lang.Object)"/>
        /// </summary>
        public object Value
        {
            get { return IExecute("getValue"); } set { IExecute("setValue", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#addChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void AddChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("addChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#commitEdit()"/>
        /// </summary>

        /// <exception cref="Java.Text.ParseException"/>
        public void CommitEdit()
        {
            IExecute("commitEdit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#removeChangeListener(javax.swing.event.ChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeListener"/></param>
        public void RemoveChangeListener(Javax.Swing.Event.ChangeListener arg0)
        {
            IExecute("removeChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.html#setUI(javax.swing.plaf.SpinnerUI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Plaf.SpinnerUI"/></param>
        public void SetUI(Javax.Swing.Plaf.SpinnerUI arg0)
        {
            IExecute("setUI", arg0);
        }

        #endregion

        #region Nested classes
        #region DateEditor
        public partial class DateEditor
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html#%3Cinit%3E(javax.swing.JSpinner,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            public DateEditor(Javax.Swing.JSpinner arg0, string arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html#%3Cinit%3E(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public DateEditor(Javax.Swing.JSpinner arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html#getFormat()"/> 
            /// </summary>
            public Java.Text.SimpleDateFormat Format
            {
                get { return IExecute<Java.Text.SimpleDateFormat>("getFormat"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DateEditor.html#getModel()"/> 
            /// </summary>
            public Javax.Swing.SpinnerDateModel Model
            {
                get { return IExecute<Javax.Swing.SpinnerDateModel>("getModel"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region DefaultEditor
        public partial class DefaultEditor
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#%3Cinit%3E(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public DefaultEditor(Javax.Swing.JSpinner arg0)
                : base(arg0)
            {
            }

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JSpinner.DefaultEditor"/> to <see cref="Javax.Swing.Event.ChangeListener"/>
            /// </summary>
            public static implicit operator Javax.Swing.Event.ChangeListener(Javax.Swing.JSpinner.DefaultEditor t) => t.Cast<Javax.Swing.Event.ChangeListener>();
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JSpinner.DefaultEditor"/> to <see cref="Java.Beans.PropertyChangeListener"/>
            /// </summary>
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.JSpinner.DefaultEditor t) => t.Cast<Java.Beans.PropertyChangeListener>();
            /// <summary>
            /// Converter from <see cref="Javax.Swing.JSpinner.DefaultEditor"/> to <see cref="Java.Awt.LayoutManager"/>
            /// </summary>
            public static implicit operator Java.Awt.LayoutManager(Javax.Swing.JSpinner.DefaultEditor t) => t.Cast<Java.Awt.LayoutManager>();

            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#getSpinner()"/> 
            /// </summary>
            public Javax.Swing.JSpinner Spinner
            {
                get { return IExecute<Javax.Swing.JSpinner>("getSpinner"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#getTextField()"/> 
            /// </summary>
            public Javax.Swing.JFormattedTextField TextField
            {
                get { return IExecute<Javax.Swing.JFormattedTextField>("getTextField"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#minimumLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension MinimumLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("minimumLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#preferredLayoutSize(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            /// <returns><see cref="Java.Awt.Dimension"/></returns>
            public Java.Awt.Dimension PreferredLayoutSize(Java.Awt.Container arg0)
            {
                return IExecute<Java.Awt.Dimension>("preferredLayoutSize", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#addLayoutComponent(java.lang.String,java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="Java.Awt.Component"/></param>
            public void AddLayoutComponent(string arg0, Java.Awt.Component arg1)
            {
                IExecute("addLayoutComponent", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#commitEdit()"/>
            /// </summary>

            /// <exception cref="Java.Text.ParseException"/>
            public void CommitEdit()
            {
                IExecute("commitEdit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#dismiss(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public void Dismiss(Javax.Swing.JSpinner arg0)
            {
                IExecute("dismiss", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#layoutContainer(java.awt.Container)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Container"/></param>
            public void LayoutContainer(Java.Awt.Container arg0)
            {
                IExecute("layoutContainer", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#propertyChange(java.beans.PropertyChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecute("propertyChange", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#removeLayoutComponent(java.awt.Component)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
            public void RemoveLayoutComponent(Java.Awt.Component arg0)
            {
                IExecute("removeLayoutComponent", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.DefaultEditor.html#stateChanged(javax.swing.event.ChangeEvent)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
            public void StateChanged(Javax.Swing.Event.ChangeEvent arg0)
            {
                IExecute("stateChanged", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region ListEditor
        public partial class ListEditor
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.ListEditor.html#%3Cinit%3E(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public ListEditor(Javax.Swing.JSpinner arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.ListEditor.html#getModel()"/> 
            /// </summary>
            public Javax.Swing.SpinnerListModel Model
            {
                get { return IExecute<Javax.Swing.SpinnerListModel>("getModel"); }
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region NumberEditor
        public partial class NumberEditor
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html#%3Cinit%3E(javax.swing.JSpinner,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            public NumberEditor(Javax.Swing.JSpinner arg0, string arg1)
                : base(arg0, arg1)
            {
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html#%3Cinit%3E(javax.swing.JSpinner)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.JSpinner"/></param>
            public NumberEditor(Javax.Swing.JSpinner arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html#getFormat()"/> 
            /// </summary>
            public Java.Text.DecimalFormat Format
            {
                get { return IExecute<Java.Text.DecimalFormat>("getFormat"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/JSpinner.NumberEditor.html#getModel()"/> 
            /// </summary>
            public Javax.Swing.SpinnerNumberModel Model
            {
                get { return IExecute<Javax.Swing.SpinnerNumberModel>("getModel"); }
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