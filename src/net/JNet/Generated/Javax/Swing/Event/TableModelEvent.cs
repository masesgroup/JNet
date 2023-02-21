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

namespace Javax.Swing.Event
{
    #region TableModelEvent
    public partial class TableModelEvent
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#<init>(javax.swing.table.TableModel,int,int,int,int)
        /// </summary>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0, int arg1, int arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#<init>(javax.swing.table.TableModel,int,int,int)
        /// </summary>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0, int arg1, int arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#<init>(javax.swing.table.TableModel,int,int)
        /// </summary>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#<init>(javax.swing.table.TableModel,int)
        /// </summary>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#<init>(javax.swing.table.TableModel)
        /// </summary>
        public TableModelEvent(Javax.Swing.Table.TableModel arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#INSERT
        /// </summary>
        public static int INSERT => Clazz.GetField<int>("INSERT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#UPDATE
        /// </summary>
        public static int UPDATE => Clazz.GetField<int>("UPDATE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#DELETE
        /// </summary>
        public static int DELETE => Clazz.GetField<int>("DELETE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#HEADER_ROW
        /// </summary>
        public static int HEADER_ROW => Clazz.GetField<int>("HEADER_ROW");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#ALL_COLUMNS
        /// </summary>
        public static int ALL_COLUMNS => Clazz.GetField<int>("ALL_COLUMNS");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getColumn() 
        /// </summary>
        public int Column
        {
            get { return IExecute<int>("getColumn"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getFirstRow() 
        /// </summary>
        public int FirstRow
        {
            get { return IExecute<int>("getFirstRow"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getLastRow() 
        /// </summary>
        public int LastRow
        {
            get { return IExecute<int>("getLastRow"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelEvent.html#getType() 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}