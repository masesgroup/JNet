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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Tree
{
    #region DefaultTreeCellEditor
    public partial class DefaultTreeCellEditor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#%3Cinit%3E(javax.swing.JTree,javax.swing.tree.DefaultTreeCellRenderer,javax.swing.tree.TreeCellEditor)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.DefaultTreeCellRenderer"/></param>
        /// <param name="arg2"><see cref="Javax.Swing.Tree.TreeCellEditor"/></param>
        public DefaultTreeCellEditor(Javax.Swing.JTree arg0, Javax.Swing.Tree.DefaultTreeCellRenderer arg1, Javax.Swing.Tree.TreeCellEditor arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#%3Cinit%3E(javax.swing.JTree,javax.swing.tree.DefaultTreeCellRenderer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.DefaultTreeCellRenderer"/></param>
        public DefaultTreeCellEditor(Javax.Swing.JTree arg0, Javax.Swing.Tree.DefaultTreeCellRenderer arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeCellEditor"/> to <see cref="Java.Awt.EventNs.ActionListener"/>
        /// </summary>
        public static implicit operator Java.Awt.EventNs.ActionListener(Javax.Swing.Tree.DefaultTreeCellEditor t) => t.Cast<Java.Awt.EventNs.ActionListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeCellEditor"/> to <see cref="Javax.Swing.Tree.TreeCellEditor"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.TreeCellEditor(Javax.Swing.Tree.DefaultTreeCellEditor t) => t.Cast<Javax.Swing.Tree.TreeCellEditor>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeCellEditor"/> to <see cref="Javax.Swing.Event.TreeSelectionListener"/>
        /// </summary>
        public static implicit operator Javax.Swing.Event.TreeSelectionListener(Javax.Swing.Tree.DefaultTreeCellEditor t) => t.Cast<Javax.Swing.Event.TreeSelectionListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#getBorderSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#setBorderSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color BorderSelectionColor
        {
            get { return IExecute<Java.Awt.Color>("getBorderSelectionColor"); } set { IExecute("setBorderSelectionColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#getCellEditorListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.CellEditorListener[] CellEditorListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.CellEditorListener>("getCellEditorListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#getCellEditorValue()"/> 
        /// </summary>
        public object CellEditorValue
        {
            get { return IExecute("getCellEditorValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#getFont()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#setFont(java.awt.Font)"/>
        /// </summary>
        public Java.Awt.Font Font
        {
            get { return IExecute<Java.Awt.Font>("getFont"); } set { IExecute("setFont", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#isCellEditable(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCellEditable(Java.Util.EventObject arg0)
        {
            return IExecute<bool>("isCellEditable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#shouldSelectCell(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldSelectCell(Java.Util.EventObject arg0)
        {
            return IExecute<bool>("shouldSelectCell", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#stopCellEditing()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool StopCellEditing()
        {
            return IExecute<bool>("stopCellEditing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#getTreeCellEditorComponent(javax.swing.JTree,java.lang.Object,boolean,boolean,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetTreeCellEditorComponent(Javax.Swing.JTree arg0, object arg1, bool arg2, bool arg3, bool arg4, int arg5)
        {
            return IExecute<Java.Awt.Component>("getTreeCellEditorComponent", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#actionPerformed(java.awt.event.ActionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ActionEvent"/></param>
        public void ActionPerformed(Java.Awt.EventNs.ActionEvent arg0)
        {
            IExecute("actionPerformed", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#addCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        public void AddCellEditorListener(Javax.Swing.Event.CellEditorListener arg0)
        {
            IExecute("addCellEditorListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#cancelCellEditing()"/>
        /// </summary>
        public void CancelCellEditing()
        {
            IExecute("cancelCellEditing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#removeCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        public void RemoveCellEditorListener(Javax.Swing.Event.CellEditorListener arg0)
        {
            IExecute("removeCellEditorListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.html#valueChanged(javax.swing.event.TreeSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionEvent"/></param>
        public void ValueChanged(Javax.Swing.Event.TreeSelectionEvent arg0)
        {
            IExecute("valueChanged", arg0);
        }

        #endregion

        #region Nested classes
        #region DefaultTextField
        public partial class DefaultTextField
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.DefaultTextField.html#%3Cinit%3E(javax.swing.tree.DefaultTreeCellEditor,javax.swing.border.Border)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Tree.DefaultTreeCellEditor"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.Border.Border"/></param>
            public DefaultTextField(Javax.Swing.Tree.DefaultTreeCellEditor arg0, Javax.Swing.Border.Border arg1)
                : base(arg0, arg1)
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

        #region EditorContainer
        public partial class EditorContainer
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.EditorContainer.html#%3Cinit%3E(javax.swing.tree.DefaultTreeCellEditor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Swing.Tree.DefaultTreeCellEditor"/></param>
            public EditorContainer(Javax.Swing.Tree.DefaultTreeCellEditor arg0)
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellEditor.EditorContainer.html#EditorContainer()"/>
            /// </summary>
            public void EditorContainerMethod()
            {
                IExecute("EditorContainer");
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