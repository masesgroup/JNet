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

namespace Javax.Swing.Tree
{
    #region AbstractLayoutCache
    public partial class AbstractLayoutCache
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.AbstractLayoutCache"/> to <see cref="Javax.Swing.Tree.RowMapper"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.RowMapper(Javax.Swing.Tree.AbstractLayoutCache t) => t.Cast<Javax.Swing.Tree.RowMapper>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getNodeDimensions()"/> 
        /// </summary>
        public Javax.Swing.Tree.AbstractLayoutCache.NodeDimensions GetNodeDimensions
        {
            get { return IExecute<Javax.Swing.Tree.AbstractLayoutCache.NodeDimensions>("getNodeDimensions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#isRootVisible()"/> 
        /// </summary>
        public bool IsRootVisible
        {
            get { return IExecute<bool>("isRootVisible"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setModel(javax.swing.tree.TreeModel)"/>
        /// </summary>
        public Javax.Swing.Tree.TreeModel Model
        {
            get { return IExecute<Javax.Swing.Tree.TreeModel>("getModel"); } set { IExecute("setModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getPreferredHeight()"/> 
        /// </summary>
        public int PreferredHeight
        {
            get { return IExecute<int>("getPreferredHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getRowCount()"/> 
        /// </summary>
        public int RowCount
        {
            get { return IExecute<int>("getRowCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getRowHeight()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setRowHeight(int)"/>
        /// </summary>
        public int RowHeight
        {
            get { return IExecute<int>("getRowHeight"); } set { IExecute("setRowHeight", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getSelectionModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setSelectionModel(javax.swing.tree.TreeSelectionModel)"/>
        /// </summary>
        public Javax.Swing.Tree.TreeSelectionModel SelectionModel
        {
            get { return IExecute<Javax.Swing.Tree.TreeSelectionModel>("getSelectionModel"); } set { IExecute("setSelectionModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getExpandedState(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool GetExpandedState(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<bool>("getExpandedState", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#isExpanded(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsExpanded(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<bool>("isExpanded", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getRowForPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetRowForPath(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<int>("getRowForPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getVisibleChildCount(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetVisibleChildCount(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<int>("getVisibleChildCount", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getBounds(javax.swing.tree.TreePath,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetBounds(Javax.Swing.Tree.TreePath arg0, Java.Awt.Rectangle arg1)
        {
            return IExecute<Java.Awt.Rectangle>("getBounds", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getVisiblePathsFrom(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Javax.Swing.Tree.TreePath> GetVisiblePathsFrom(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<Java.Util.Enumeration<Javax.Swing.Tree.TreePath>>("getVisiblePathsFrom", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getPathClosestTo(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreePath"/></returns>
        public Javax.Swing.Tree.TreePath GetPathClosestTo(int arg0, int arg1)
        {
            return IExecute<Javax.Swing.Tree.TreePath>("getPathClosestTo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getPathForRow(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreePath"/></returns>
        public Javax.Swing.Tree.TreePath GetPathForRow(int arg0)
        {
            return IExecute<Javax.Swing.Tree.TreePath>("getPathForRow", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#invalidatePathBounds(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public void InvalidatePathBounds(Javax.Swing.Tree.TreePath arg0)
        {
            IExecute("invalidatePathBounds", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#invalidateSizes()"/>
        /// </summary>
        public void InvalidateSizes()
        {
            IExecute("invalidateSizes");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setExpandedState(javax.swing.tree.TreePath,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetExpandedState(Javax.Swing.Tree.TreePath arg0, bool arg1)
        {
            IExecute("setExpandedState", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#treeNodesChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public void TreeNodesChanged(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecute("treeNodesChanged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#treeNodesInserted(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public void TreeNodesInserted(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecute("treeNodesInserted", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#treeNodesRemoved(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public void TreeNodesRemoved(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecute("treeNodesRemoved", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#treeStructureChanged(javax.swing.event.TreeModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeModelEvent"/></param>
        public void TreeStructureChanged(Javax.Swing.Event.TreeModelEvent arg0)
        {
            IExecute("treeStructureChanged", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getPreferredWidth(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetPreferredWidth(Java.Awt.Rectangle arg0)
        {
            return IExecute<int>("getPreferredWidth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#getRowsForPaths(javax.swing.tree.TreePath[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetRowsForPaths(Javax.Swing.Tree.TreePath[] arg0)
        {
            return IExecuteArray<int>("getRowsForPaths", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setNodeDimensions(javax.swing.tree.AbstractLayoutCache.NodeDimensions)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.AbstractLayoutCache.NodeDimensions"/></param>
        public void SetNodeDimensions(Javax.Swing.Tree.AbstractLayoutCache.NodeDimensions arg0)
        {
            IExecute("setNodeDimensions", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.html#setRootVisible(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetRootVisible(bool arg0)
        {
            IExecute("setRootVisible", arg0);
        }
        
        #endregion

        #region Nested classes
        #region NodeDimensions
        public partial class NodeDimensions
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/AbstractLayoutCache.NodeDimensions.html#getNodeDimensions(java.lang.Object,int,int,boolean,java.awt.Rectangle)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            /// <param name="arg2"><see cref="int"/></param>
            /// <param name="arg3"><see cref="bool"/></param>
            /// <param name="arg4"><see cref="Java.Awt.Rectangle"/></param>
            /// <returns><see cref="Java.Awt.Rectangle"/></returns>
            public Java.Awt.Rectangle GetNodeDimensions(object arg0, int arg1, int arg2, bool arg3, Java.Awt.Rectangle arg4)
            {
                return IExecute<Java.Awt.Rectangle>("getNodeDimensions", arg0, arg1, arg2, arg3, arg4);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}