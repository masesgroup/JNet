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

namespace Javax.Swing.Table
{
    #region DefaultTableColumnModel
    public partial class DefaultTableColumnModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableColumnModel"/> to <see cref="Javax.Swing.Table.TableColumnModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.Table.TableColumnModel(Javax.Swing.Table.DefaultTableColumnModel t) => t.Cast<Javax.Swing.Table.TableColumnModel>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableColumnModel"/> to <see cref="Java.Beans.PropertyChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Table.DefaultTableColumnModel t) => t.Cast<Java.Beans.PropertyChangeListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableColumnModel"/> to <see cref="Javax.Swing.Event.ListSelectionListener"/>
        /// </summary>
        public static implicit operator Javax.Swing.Event.ListSelectionListener(Javax.Swing.Table.DefaultTableColumnModel t) => t.Cast<Javax.Swing.Event.ListSelectionListener>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Table.DefaultTableColumnModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Table.DefaultTableColumnModel t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnCount()"/> 
        /// </summary>
        public int ColumnCount
        {
            get { return IExecute<int>("getColumnCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnMargin()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#setColumnMargin(int)"/>
        /// </summary>
        public int ColumnMargin
        {
            get { return IExecute<int>("getColumnMargin"); } set { IExecute("setColumnMargin", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnModelListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.TableColumnModelListener[] ColumnModelListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.TableColumnModelListener>("getColumnModelListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumns()"/> 
        /// </summary>
        public Java.Util.Enumeration Columns
        {
            get { return IExecute<Java.Util.Enumeration>("getColumns"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnSelectionAllowed()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#setColumnSelectionAllowed(boolean)"/>
        /// </summary>
        public bool ColumnSelectionAllowed
        {
            get { return IExecute<bool>("getColumnSelectionAllowed"); } set { IExecute("setColumnSelectionAllowed", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getSelectedColumnCount()"/> 
        /// </summary>
        public int SelectedColumnCount
        {
            get { return IExecute<int>("getSelectedColumnCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getSelectedColumns()"/> 
        /// </summary>
        public int[] SelectedColumns
        {
            get { return IExecuteArray<int>("getSelectedColumns"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#setSelectionModel(javax.swing.ListSelectionModel)"/>
        /// </summary>
        public Javax.Swing.ListSelectionModel SelectionModel
        {
            get { return IExecute<Javax.Swing.ListSelectionModel>("getSelectionModel"); } set { IExecute("setSelectionModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getTotalColumnWidth()"/> 
        /// </summary>
        public int TotalColumnWidth
        {
            get { return IExecute<int>("getTotalColumnWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getListeners(java.lang.Class%3CT%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Util.EventListener"/></returns>
        public Java.Util.EventListener[] GetListeners(Java.Lang.Class arg0)
        {
            return IExecuteArray<Java.Util.EventListener>("getListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnIndex(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetColumnIndex(object arg0)
        {
            return IExecute<int>("getColumnIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumnIndexAtX(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetColumnIndexAtX(int arg0)
        {
            return IExecute<int>("getColumnIndexAtX", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#getColumn(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Table.TableColumn"/></returns>
        public Javax.Swing.Table.TableColumn GetColumn(int arg0)
        {
            return IExecute<Javax.Swing.Table.TableColumn>("getColumn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#addColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        public void AddColumn(Javax.Swing.Table.TableColumn arg0)
        {
            IExecute("addColumn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#addColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        public void AddColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0)
        {
            IExecute("addColumnModelListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#moveColumn(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void MoveColumn(int arg0, int arg1)
        {
            IExecute("moveColumn", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#propertyChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecute("propertyChange", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#removeColumn(javax.swing.table.TableColumn)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Table.TableColumn"/></param>
        public void RemoveColumn(Javax.Swing.Table.TableColumn arg0)
        {
            IExecute("removeColumn", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#removeColumnModelListener(javax.swing.event.TableColumnModelListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelListener"/></param>
        public void RemoveColumnModelListener(Javax.Swing.Event.TableColumnModelListener arg0)
        {
            IExecute("removeColumnModelListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/table/DefaultTableColumnModel.html#valueChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        public void ValueChanged(Javax.Swing.Event.ListSelectionEvent arg0)
        {
            IExecute("valueChanged", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}