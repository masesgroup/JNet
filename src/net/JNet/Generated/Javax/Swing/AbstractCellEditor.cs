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

namespace Javax.Swing
{
    #region AbstractCellEditor
    public partial class AbstractCellEditor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Swing.CellEditor(Javax.Swing.AbstractCellEditor t) => t.Cast<Javax.Swing.CellEditor>();
        public static implicit operator Java.Io.Serializable(Javax.Swing.AbstractCellEditor t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractCellEditor.html#getCellEditorListeners() 
        /// </summary>
        public Javax.Swing.Event.CellEditorListener[] CellEditorListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.CellEditorListener>("getCellEditorListeners"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractCellEditor.html#isCellEditable(java.util.EventObject)
        /// </summary>
        public bool IsCellEditable(Java.Util.EventObject arg0)
        {
            return IExecute<bool>("isCellEditable", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractCellEditor.html#shouldSelectCell(java.util.EventObject)
        /// </summary>
        public bool ShouldSelectCell(Java.Util.EventObject arg0)
        {
            return IExecute<bool>("shouldSelectCell", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractCellEditor.html#stopCellEditing()
        /// </summary>
        public bool StopCellEditing()
        {
            return IExecute<bool>("stopCellEditing");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractCellEditor.html#addCellEditorListener(javax.swing.event.CellEditorListener)
        /// </summary>
        public void AddCellEditorListener(Javax.Swing.Event.CellEditorListener arg0)
        {
            IExecute("addCellEditorListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractCellEditor.html#cancelCellEditing()
        /// </summary>
        public void CancelCellEditing()
        {
            IExecute("cancelCellEditing");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/AbstractCellEditor.html#removeCellEditorListener(javax.swing.event.CellEditorListener)
        /// </summary>
        public void RemoveCellEditorListener(Javax.Swing.Event.CellEditorListener arg0)
        {
            IExecute("removeCellEditorListener", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}