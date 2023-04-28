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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Table
{
    #region TableColumnModel
    public partial class TableColumnModel
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnCount()"/> 
        /// </summary>
        public int ColumnCount
        {
            get { return IExecute<int>("getColumnCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setColumnMargin(int)"/>
        /// </summary>
        public int ColumnMargin
        {
            get { return IExecute<int>("getColumnMargin"); } set { IExecute("setColumnMargin", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumns()"/> 
        /// </summary>
        public Java.Util.Enumeration<Javax.Swing.Table.TableColumn> Columns
        {
            get { return IExecute<Java.Util.Enumeration<Javax.Swing.Table.TableColumn>>("getColumns"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnSelectionAllowed()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setColumnSelectionAllowed(boolean)"/>
        /// </summary>
        public bool ColumnSelectionAllowed
        {
            get { return IExecute<bool>("getColumnSelectionAllowed"); } set { IExecute("setColumnSelectionAllowed", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectedColumnCount()"/> 
        /// </summary>
        public int SelectedColumnCount
        {
            get { return IExecute<int>("getSelectedColumnCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectedColumns()"/> 
        /// </summary>
        public int[] SelectedColumns
        {
            get { return IExecuteArray<int>("getSelectedColumns"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#setSelectionModel(javax.swing.ListSelectionModel)"/>
        /// </summary>
        public Javax.Swing.ListSelectionModel SelectionModel
        {
            get { return IExecute<Javax.Swing.ListSelectionModel>("getSelectionModel"); } set { IExecute("setSelectionModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getTotalColumnWidth()"/> 
        /// </summary>
        public int TotalColumnWidth
        {
            get { return IExecute<int>("getTotalColumnWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnIndex(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnIndex(object arg0)
        {
            return IExecute<int>("getColumnIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumnIndexAtX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetColumnIndexAtX(int arg0)
        {
            return IExecute<int>("getColumnIndexAtX", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#getColumn(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Table.TableColumn"/></returns>
        public Javax.Swing.Table.TableColumn GetColumn(int arg0)
        {
            return IExecute<Javax.Swing.Table.TableColumn>("getColumn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#addColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        public void AddColumn(Javax.Swing.Table.TableColumn arg0)
        {
            IExecute("addColumn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#addColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        public void AddColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0)
        {
            IExecute("addColumnModelListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#moveColumn(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void MoveColumn(int arg0, int arg1)
        {
            IExecute("moveColumn", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#removeColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        public void RemoveColumn(Javax.Swing.Table.TableColumn arg0)
        {
            IExecute("removeColumn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/TableColumnModel.html#removeColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        public void RemoveColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0)
        {
            IExecute("removeColumnModelListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}