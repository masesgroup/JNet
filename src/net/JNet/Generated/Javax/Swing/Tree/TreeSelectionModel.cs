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

namespace Javax.Swing.Tree
{
    #region ITreeSelectionModel
    public partial interface ITreeSelectionModel
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isSelectionEmpty()"/> 
        /// </summary>
        bool IsSelectionEmpty { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getLeadSelectionPath()"/> 
        /// </summary>
        Javax.Swing.Tree.TreePath LeadSelectionPath { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getLeadSelectionRow()"/> 
        /// </summary>
        int LeadSelectionRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getMaxSelectionRow()"/> 
        /// </summary>
        int MaxSelectionRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getMinSelectionRow()"/> 
        /// </summary>
        int MinSelectionRow { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getRowMapper()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setRowMapper(javax.swing.tree.RowMapper)"/>
        /// </summary>
        Javax.Swing.Tree.RowMapper RowMapper { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionCount()"/> 
        /// </summary>
        int SelectionCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        int SelectionMode { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        Javax.Swing.Tree.TreePath SelectionPath { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionPaths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        Javax.Swing.Tree.TreePath[] SelectionPaths { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionRows()"/> 
        /// </summary>
        int[] SelectionRows { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isPathSelected(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsPathSelected(Javax.Swing.Tree.TreePath arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsRowSelected(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        void AddSelectionPath(Javax.Swing.Tree.TreePath arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        void AddSelectionPaths(Javax.Swing.Tree.TreePath[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        void AddTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#clearSelection()"/>
        /// </summary>
        void ClearSelection();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        void RemoveSelectionPath(Javax.Swing.Tree.TreePath arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        void RemoveSelectionPaths(Javax.Swing.Tree.TreePath[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        void RemoveTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#resetRowSelection()"/>
        /// </summary>
        void ResetRowSelection();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeSelectionModel
    public partial class TreeSelectionModel : Javax.Swing.Tree.ITreeSelectionModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#CONTIGUOUS_TREE_SELECTION"/>
        /// </summary>
        public static int CONTIGUOUS_TREE_SELECTION { get { return SGetField<int>(LocalBridgeClazz, "CONTIGUOUS_TREE_SELECTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#DISCONTIGUOUS_TREE_SELECTION"/>
        /// </summary>
        public static int DISCONTIGUOUS_TREE_SELECTION { get { return SGetField<int>(LocalBridgeClazz, "DISCONTIGUOUS_TREE_SELECTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#SINGLE_TREE_SELECTION"/>
        /// </summary>
        public static int SINGLE_TREE_SELECTION { get { return SGetField<int>(LocalBridgeClazz, "SINGLE_TREE_SELECTION"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isSelectionEmpty()"/> 
        /// </summary>
        public bool IsSelectionEmpty
        {
            get { return IExecute<bool>("isSelectionEmpty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getLeadSelectionPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath LeadSelectionPath
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getLeadSelectionPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getLeadSelectionRow()"/> 
        /// </summary>
        public int LeadSelectionRow
        {
            get { return IExecute<int>("getLeadSelectionRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getMaxSelectionRow()"/> 
        /// </summary>
        public int MaxSelectionRow
        {
            get { return IExecute<int>("getMaxSelectionRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getMinSelectionRow()"/> 
        /// </summary>
        public int MinSelectionRow
        {
            get { return IExecute<int>("getMinSelectionRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getRowMapper()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setRowMapper(javax.swing.tree.RowMapper)"/>
        /// </summary>
        public Javax.Swing.Tree.RowMapper RowMapper
        {
            get { return IExecute<Javax.Swing.Tree.RowMapper>("getRowMapper"); } set { IExecute("setRowMapper", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionCount()"/> 
        /// </summary>
        public int SelectionCount
        {
            get { return IExecute<int>("getSelectionCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        public int SelectionMode
        {
            get { return IExecute<int>("getSelectionMode"); } set { IExecute("setSelectionMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        public Javax.Swing.Tree.TreePath SelectionPath
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getSelectionPath"); } set { IExecute("setSelectionPath", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionPaths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#setSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        public Javax.Swing.Tree.TreePath[] SelectionPaths
        {
            get { return IExecuteArray<Javax.Swing.Tree.TreePath>("getSelectionPaths"); } set { IExecute("setSelectionPaths", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#getSelectionRows()"/> 
        /// </summary>
        public int[] SelectionRows
        {
            get { return IExecuteArray<int>("getSelectionRows"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isPathSelected(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPathSelected(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<bool>("isPathSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#isRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRowSelected(int arg0)
        {
            return IExecute<bool>("isRowSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void AddSelectionPath(Javax.Swing.Tree.TreePath arg0)
        {
            IExecute("addSelectionPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void AddSelectionPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            IExecute("addSelectionPaths", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#addTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        public void AddTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0)
        {
            IExecute("addTreeSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecute("clearSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("removePropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void RemoveSelectionPath(Javax.Swing.Tree.TreePath arg0)
        {
            IExecute("removeSelectionPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void RemoveSelectionPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            IExecute("removeSelectionPaths", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#removeTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        public void RemoveTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0)
        {
            IExecute("removeTreeSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeSelectionModel.html#resetRowSelection()"/>
        /// </summary>
        public void ResetRowSelection()
        {
            IExecute("resetRowSelection");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}