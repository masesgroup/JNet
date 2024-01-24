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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Tree
{
    #region ITreeNode
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITreeNode
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getAllowsChildren()"/> 
        /// </summary>
        bool AllowsChildren { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildCount()"/> 
        /// </summary>
        int ChildCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getParent()"/> 
        /// </summary>
        Javax.Swing.Tree.TreeNode Parent { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#isLeaf()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsLeaf();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getIndex(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="int"/></returns>
        int GetIndex(Javax.Swing.Tree.TreeNode arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#children()"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsJavax_Swing_Tree_TreeNode"><see cref="Javax.Swing.Tree.TreeNode"/></typeparam>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        Java.Util.Enumeration<ReturnExtendsJavax_Swing_Tree_TreeNode> Children<ReturnExtendsJavax_Swing_Tree_TreeNode>() where ReturnExtendsJavax_Swing_Tree_TreeNode: Javax.Swing.Tree.TreeNode;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        Javax.Swing.Tree.TreeNode GetChildAt(int arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeNode
    public partial class TreeNode : Javax.Swing.Tree.ITreeNode
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getAllowsChildren()"/> 
        /// </summary>
        public bool AllowsChildren
        {
            get { return IExecute<bool>("getAllowsChildren"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildCount()"/> 
        /// </summary>
        public int ChildCount
        {
            get { return IExecute<int>("getChildCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getParent()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode Parent
        {
            get { return IExecute<Javax.Swing.Tree.TreeNode>("getParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#isLeaf()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLeaf()
        {
            return IExecute<bool>("isLeaf");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getIndex(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetIndex(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<int>("getIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#children()"/>
        /// </summary>

        /// <typeparam name="ReturnExtendsJavax_Swing_Tree_TreeNode"><see cref="Javax.Swing.Tree.TreeNode"/></typeparam>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<ReturnExtendsJavax_Swing_Tree_TreeNode> Children<ReturnExtendsJavax_Swing_Tree_TreeNode>() where ReturnExtendsJavax_Swing_Tree_TreeNode: Javax.Swing.Tree.TreeNode
        {
            return IExecute<Java.Util.Enumeration<ReturnExtendsJavax_Swing_Tree_TreeNode>>("children");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeNode.html#getChildAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildAt(int arg0)
        {
            return IExecute<Javax.Swing.Tree.TreeNode>("getChildAt", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}