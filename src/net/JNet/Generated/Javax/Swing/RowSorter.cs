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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region RowSorter
    public partial class RowSorter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getModel()"/> 
        /// </summary>
        public object Model
        {
            get { return IExecute("getModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getModelRowCount()"/> 
        /// </summary>
        public int ModelRowCount
        {
            get { return IExecute<int>("getModelRowCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getSortKeys()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#setSortKeys(java.util.List)"/>
        /// </summary>
        public Java.Util.List SortKeys
        {
            get { return IExecute<Java.Util.List>("getSortKeys"); } set { IExecute("setSortKeys", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getViewRowCount()"/> 
        /// </summary>
        public int ViewRowCount
        {
            get { return IExecute<int>("getViewRowCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#convertRowIndexToModel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertRowIndexToModel(int arg0)
        {
            return IExecute<int>("convertRowIndexToModel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#convertRowIndexToView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertRowIndexToView(int arg0)
        {
            return IExecute<int>("convertRowIndexToView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#allRowsChanged()"/>
        /// </summary>
        public void AllRowsChanged()
        {
            IExecute("allRowsChanged");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#modelStructureChanged()"/>
        /// </summary>
        public void ModelStructureChanged()
        {
            IExecute("modelStructureChanged");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsDeleted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsDeleted(int arg0, int arg1)
        {
            IExecute("rowsDeleted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsInserted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsInserted(int arg0, int arg1)
        {
            IExecute("rowsInserted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsUpdated(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void RowsUpdated(int arg0, int arg1, int arg2)
        {
            IExecute("rowsUpdated", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsUpdated(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsUpdated(int arg0, int arg1)
        {
            IExecute("rowsUpdated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#toggleSortOrder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ToggleSortOrder(int arg0)
        {
            IExecute("toggleSortOrder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#addRowSorterListener(javax.swing.event.RowSorterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.RowSorterListener"/></param>
        public void AddRowSorterListener(Javax.Swing.Event.RowSorterListener arg0)
        {
            IExecute("addRowSorterListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#removeRowSorterListener(javax.swing.event.RowSorterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.RowSorterListener"/></param>
        public void RemoveRowSorterListener(Javax.Swing.Event.RowSorterListener arg0)
        {
            IExecute("removeRowSorterListener", arg0);
        }

        #endregion

        #region Nested classes
        #region SortKey
        public partial class SortKey
        {
            #region Constructors
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.SortKey.html#%3Cinit%3E(int,javax.swing.SortOrder)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <param name="arg1"><see cref="Javax.Swing.SortOrder"/></param>
            public SortKey(int arg0, Javax.Swing.SortOrder arg1)
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
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.SortKey.html#getColumn()"/> 
            /// </summary>
            public int Column
            {
                get { return IExecute<int>("getColumn"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.SortKey.html#getSortOrder()"/> 
            /// </summary>
            public Javax.Swing.SortOrder SortOrder
            {
                get { return IExecute<Javax.Swing.SortOrder>("getSortOrder"); }
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

    #region RowSorter<M>
    public partial class RowSorter<M>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.RowSorter{M}"/> to <see cref="Javax.Swing.RowSorter"/>
        /// </summary>
        public static implicit operator Javax.Swing.RowSorter(Javax.Swing.RowSorter<M> t) => t.Cast<Javax.Swing.RowSorter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getModel()"/> 
        /// </summary>
        public M Model
        {
            get { return IExecute<M>("getModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getModelRowCount()"/> 
        /// </summary>
        public int ModelRowCount
        {
            get { return IExecute<int>("getModelRowCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getSortKeys()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#setSortKeys(java.util.List)"/>
        /// </summary>
        public Java.Util.List SortKeys
        {
            get { return IExecute<Java.Util.List>("getSortKeys"); } set { IExecute("setSortKeys", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#getViewRowCount()"/> 
        /// </summary>
        public int ViewRowCount
        {
            get { return IExecute<int>("getViewRowCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#convertRowIndexToModel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertRowIndexToModel(int arg0)
        {
            return IExecute<int>("convertRowIndexToModel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#convertRowIndexToView(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int ConvertRowIndexToView(int arg0)
        {
            return IExecute<int>("convertRowIndexToView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#allRowsChanged()"/>
        /// </summary>
        public void AllRowsChanged()
        {
            IExecute("allRowsChanged");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#modelStructureChanged()"/>
        /// </summary>
        public void ModelStructureChanged()
        {
            IExecute("modelStructureChanged");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsDeleted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsDeleted(int arg0, int arg1)
        {
            IExecute("rowsDeleted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsInserted(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsInserted(int arg0, int arg1)
        {
            IExecute("rowsInserted", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsUpdated(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void RowsUpdated(int arg0, int arg1, int arg2)
        {
            IExecute("rowsUpdated", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#rowsUpdated(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void RowsUpdated(int arg0, int arg1)
        {
            IExecute("rowsUpdated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#toggleSortOrder(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ToggleSortOrder(int arg0)
        {
            IExecute("toggleSortOrder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#addRowSorterListener(javax.swing.event.RowSorterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.RowSorterListener"/></param>
        public void AddRowSorterListener(Javax.Swing.Event.RowSorterListener arg0)
        {
            IExecute("addRowSorterListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/RowSorter.html#removeRowSorterListener(javax.swing.event.RowSorterListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.RowSorterListener"/></param>
        public void RemoveRowSorterListener(Javax.Swing.Event.RowSorterListener arg0)
        {
            IExecute("removeRowSorterListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}