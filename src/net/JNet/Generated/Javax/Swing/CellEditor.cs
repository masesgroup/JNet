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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region ICellEditor
    public partial interface ICellEditor
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#getCellEditorValue()"/> 
        /// </summary>
        object CellEditorValue { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#stopCellEditing()"/> 
        /// </summary>
        bool StopCellEditing { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#isCellEditable(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsCellEditable(Java.Util.EventObject arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#shouldSelectCell(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        bool ShouldSelectCell(Java.Util.EventObject arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#addCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        void AddCellEditorListener(Javax.Swing.Event.CellEditorListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#cancelCellEditing()"/>
        /// </summary>
        void CancelCellEditing();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#removeCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        void RemoveCellEditorListener(Javax.Swing.Event.CellEditorListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CellEditor
    public partial class CellEditor : Javax.Swing.ICellEditor
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#getCellEditorValue()"/> 
        /// </summary>
        public object CellEditorValue
        {
            get { return IExecute("getCellEditorValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#stopCellEditing()"/> 
        /// </summary>
        public bool StopCellEditing
        {
            get { return IExecute<bool>("stopCellEditing"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#isCellEditable(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCellEditable(Java.Util.EventObject arg0)
        {
            return IExecute<bool>("isCellEditable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#shouldSelectCell(java.util.EventObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.EventObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ShouldSelectCell(Java.Util.EventObject arg0)
        {
            return IExecute<bool>("shouldSelectCell", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#addCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
        public void AddCellEditorListener(Javax.Swing.Event.CellEditorListener arg0)
        {
            IExecute("addCellEditorListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#cancelCellEditing()"/>
        /// </summary>
        public void CancelCellEditing()
        {
            IExecute("cancelCellEditing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/CellEditor.html#removeCellEditorListener(javax.swing.event.CellEditorListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.CellEditorListener"/></param>
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