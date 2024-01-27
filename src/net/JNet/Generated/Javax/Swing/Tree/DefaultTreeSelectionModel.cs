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
    #region DefaultTreeSelectionModel
    public partial class DefaultTreeSelectionModel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeSelectionModel"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Tree.DefaultTreeSelectionModel t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeSelectionModel"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Tree.DefaultTreeSelectionModel t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeSelectionModel"/> to <see cref="Javax.Swing.Tree.TreeSelectionModel"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.TreeSelectionModel(Javax.Swing.Tree.DefaultTreeSelectionModel t) => t.Cast<Javax.Swing.Tree.TreeSelectionModel>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#SELECTION_MODE_PROPERTY"/>
        /// </summary>
        public static string SELECTION_MODE_PROPERTY { get { if (!_SELECTION_MODE_PROPERTYReady) { _SELECTION_MODE_PROPERTYContent = SGetField<string>(LocalBridgeClazz, "SELECTION_MODE_PROPERTY"); _SELECTION_MODE_PROPERTYReady = true; } return _SELECTION_MODE_PROPERTYContent; } }
        private static string _SELECTION_MODE_PROPERTYContent = default;
        private static bool _SELECTION_MODE_PROPERTYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getLeadSelectionPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath LeadSelectionPath
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getLeadSelectionPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getLeadSelectionRow()"/> 
        /// </summary>
        public int LeadSelectionRow
        {
            get { return IExecute<int>("getLeadSelectionRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getMaxSelectionRow()"/> 
        /// </summary>
        public int MaxSelectionRow
        {
            get { return IExecute<int>("getMaxSelectionRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getMinSelectionRow()"/> 
        /// </summary>
        public int MinSelectionRow
        {
            get { return IExecute<int>("getMinSelectionRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getPropertyChangeListeners()"/> 
        /// </summary>
        public Java.Beans.PropertyChangeListener[] PropertyChangeListeners
        {
            get { return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getRowMapper()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#setRowMapper(javax.swing.tree.RowMapper)"/>
        /// </summary>
        public Javax.Swing.Tree.RowMapper RowMapper
        {
            get { return IExecute<Javax.Swing.Tree.RowMapper>("getRowMapper"); } set { IExecute("setRowMapper", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionCount()"/> 
        /// </summary>
        public int SelectionCount
        {
            get { return IExecute<int>("getSelectionCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#setSelectionMode(int)"/>
        /// </summary>
        public int SelectionMode
        {
            get { return IExecute<int>("getSelectionMode"); } set { IExecute("setSelectionMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#setSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        public Javax.Swing.Tree.TreePath SelectionPath
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getSelectionPath"); } set { IExecute("setSelectionPath", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionPaths()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#setSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        public Javax.Swing.Tree.TreePath[] SelectionPaths
        {
            get { return IExecuteArray<Javax.Swing.Tree.TreePath>("getSelectionPaths"); } set { IExecute("setSelectionPaths", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getSelectionRows()"/> 
        /// </summary>
        public int[] SelectionRows
        {
            get { return IExecuteArray<int>("getSelectionRows"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#getTreeSelectionListeners()"/> 
        /// </summary>
        public Javax.Swing.Event.TreeSelectionListener[] TreeSelectionListeners
        {
            get { return IExecuteArray<Javax.Swing.Event.TreeSelectionListener>("getTreeSelectionListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#isPathSelected(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsPathSelected(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<bool>("isPathSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#isRowSelected(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsRowSelected(int arg0)
        {
            return IExecute<bool>("isRowSelected", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#isSelectionEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSelectionEmpty()
        {
            return IExecute<bool>("isSelectionEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#addPropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("addPropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#removePropertyChangeListener(java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(Java.Beans.PropertyChangeListener arg0)
        {
            IExecute("removePropertyChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#addSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void AddSelectionPath(Javax.Swing.Tree.TreePath arg0)
        {
            IExecute("addSelectionPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#addSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void AddSelectionPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            IExecute("addSelectionPaths", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#addTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        public void AddTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0)
        {
            IExecute("addTreeSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#clearSelection()"/>
        /// </summary>
        public void ClearSelection()
        {
            IExecute("clearSelection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#removeSelectionPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void RemoveSelectionPath(Javax.Swing.Tree.TreePath arg0)
        {
            IExecute("removeSelectionPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#removeSelectionPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void RemoveSelectionPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            IExecute("removeSelectionPaths", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#removeTreeSelectionListener(javax.swing.event.TreeSelectionListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeSelectionListener"/></param>
        public void RemoveTreeSelectionListener(Javax.Swing.Event.TreeSelectionListener arg0)
        {
            IExecute("removeTreeSelectionListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeSelectionModel.html#resetRowSelection()"/>
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