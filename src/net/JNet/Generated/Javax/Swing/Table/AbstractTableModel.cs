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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Table
{
    #region AbstractTableModel
    public partial class AbstractTableModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.AbstractTableModel"/> to <see cref="Javax.Swing.Table.TableModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.Table.TableModel(Javax.Swing.Table.AbstractTableModel t) => t.Cast<Javax.Swing.Table.TableModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.AbstractTableModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Table.AbstractTableModel t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#getTableModelListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.TableModelListener[] TableModelListeners
        {
            get { return IExecuteWithSignatureArray<Javax.Swing.Event.TableModelListener>("getTableModelListeners", "()[Ljavax/swing/event/TableModelListener;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#isCellEditable(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsCellEditable(int arg0, int arg1)
        {
            return IExecute<bool>("isCellEditable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#findColumn(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        public int FindColumn(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<int>("findColumn", "(Ljava/lang/String;)I", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#getColumnClass(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.Class"/></returns>
        public Java.Lang.Class GetColumnClass(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.Class>("getColumnClass", "(I)Ljava/lang/Class;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#getColumnName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public Java.Lang.String GetColumnName(int arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getColumnName", "(I)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#addTableModelListener(javax.swing.event.TableModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelListener"/></param>
        public void AddTableModelListener(Javax.Swing.Event.TableModelListener arg0)
        {
            IExecuteWithSignature("addTableModelListener", "(Ljavax/swing/event/TableModelListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#fireTableCellUpdated(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void FireTableCellUpdated(int arg0, int arg1)
        {
            IExecute("fireTableCellUpdated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#fireTableChanged(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        public void FireTableChanged(Javax.Swing.Event.TableModelEvent arg0)
        {
            IExecuteWithSignature("fireTableChanged", "(Ljavax/swing/event/TableModelEvent;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#fireTableDataChanged()"/>
        /// </summary>
        public void FireTableDataChanged()
        {
            IExecuteWithSignature("fireTableDataChanged", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#fireTableRowsDeleted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void FireTableRowsDeleted(int arg0, int arg1)
        {
            IExecute("fireTableRowsDeleted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#fireTableRowsInserted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void FireTableRowsInserted(int arg0, int arg1)
        {
            IExecute("fireTableRowsInserted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#fireTableRowsUpdated(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void FireTableRowsUpdated(int arg0, int arg1)
        {
            IExecute("fireTableRowsUpdated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#fireTableStructureChanged()"/>
        /// </summary>
        public void FireTableStructureChanged()
        {
            IExecuteWithSignature("fireTableStructureChanged", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#removeTableModelListener(javax.swing.event.TableModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelListener"/></param>
        public void RemoveTableModelListener(Javax.Swing.Event.TableModelListener arg0)
        {
            IExecuteWithSignature("removeTableModelListener", "(Ljavax/swing/event/TableModelListener;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/AbstractTableModel.html#setValueAt(java.lang.Object,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetValueAt(object arg0, int arg1, int arg2)
        {
            IExecute("setValueAt", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}