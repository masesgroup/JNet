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

namespace Javax.Swing.Tree
{
    #region DefaultMutableTreeNode
    public partial class DefaultMutableTreeNode
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#%3Cinit%3E(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public DefaultMutableTreeNode(object arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public DefaultMutableTreeNode(object arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Swing.Tree.DefaultMutableTreeNode t) => t.Cast<Java.Lang.Cloneable>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/> to <see cref="Javax.Swing.Tree.MutableTreeNode"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.MutableTreeNode(Javax.Swing.Tree.DefaultMutableTreeNode t) => t.Cast<Javax.Swing.Tree.MutableTreeNode>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Tree.DefaultMutableTreeNode t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#EMPTY_ENUMERATION"/>
        /// </summary>
        public static Java.Util.Enumeration EMPTY_ENUMERATION => Clazz.GetField<Java.Util.Enumeration>("EMPTY_ENUMERATION");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getAllowsChildren()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#setAllowsChildren(boolean)"/>
        /// </summary>
        public bool AllowsChildren
        {
            get { return IExecute<bool>("getAllowsChildren"); } set { IExecute("setAllowsChildren", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getChildCount()"/> 
        /// </summary>
        public int ChildCount
        {
            get { return IExecute<int>("getChildCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getDepth()"/> 
        /// </summary>
        public int Depth
        {
            get { return IExecute<int>("getDepth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getFirstChild()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode FirstChild
        {
            get { return IExecute<Javax.Swing.Tree.TreeNode>("getFirstChild"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getFirstLeaf()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode FirstLeaf
        {
            get { return IExecute<Javax.Swing.Tree.DefaultMutableTreeNode>("getFirstLeaf"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getLastChild()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode LastChild
        {
            get { return IExecute<Javax.Swing.Tree.TreeNode>("getLastChild"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getLastLeaf()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode LastLeaf
        {
            get { return IExecute<Javax.Swing.Tree.DefaultMutableTreeNode>("getLastLeaf"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getLeafCount()"/> 
        /// </summary>
        public int LeafCount
        {
            get { return IExecute<int>("getLeafCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getLevel()"/> 
        /// </summary>
        public int Level
        {
            get { return IExecute<int>("getLevel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getNextLeaf()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode NextLeaf
        {
            get { return IExecute<Javax.Swing.Tree.DefaultMutableTreeNode>("getNextLeaf"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getNextNode()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode NextNode
        {
            get { return IExecute<Javax.Swing.Tree.DefaultMutableTreeNode>("getNextNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getNextSibling()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode NextSibling
        {
            get { return IExecute<Javax.Swing.Tree.DefaultMutableTreeNode>("getNextSibling"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getParent()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#setParent(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        public Javax.Swing.Tree.TreeNode Parent
        {
            get { return IExecute<Javax.Swing.Tree.TreeNode>("getParent"); } set { IExecute("setParent", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode[] Path
        {
            get { return IExecuteArray<Javax.Swing.Tree.TreeNode>("getPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getPreviousLeaf()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode PreviousLeaf
        {
            get { return IExecute<Javax.Swing.Tree.DefaultMutableTreeNode>("getPreviousLeaf"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getPreviousNode()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode PreviousNode
        {
            get { return IExecute<Javax.Swing.Tree.DefaultMutableTreeNode>("getPreviousNode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getPreviousSibling()"/> 
        /// </summary>
        public Javax.Swing.Tree.DefaultMutableTreeNode PreviousSibling
        {
            get { return IExecute<Javax.Swing.Tree.DefaultMutableTreeNode>("getPreviousSibling"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getRoot()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreeNode Root
        {
            get { return IExecute<Javax.Swing.Tree.TreeNode>("getRoot"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getSiblingCount()"/> 
        /// </summary>
        public int SiblingCount
        {
            get { return IExecute<int>("getSiblingCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getUserObject()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#setUserObject(java.lang.Object)"/>
        /// </summary>
        public object UserObject
        {
            get { return IExecute("getUserObject"); } set { IExecute("setUserObject", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getUserObjectPath()"/> 
        /// </summary>
        public object[] UserObjectPath
        {
            get { return IExecuteArray<object>("getUserObjectPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isLeaf()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsLeaf()
        {
            return IExecute<bool>("isLeaf");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeAncestor(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsNodeAncestor(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<bool>("isNodeAncestor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeChild(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsNodeChild(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<bool>("isNodeChild", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeDescendant(javax.swing.tree.DefaultMutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsNodeDescendant(Javax.Swing.Tree.DefaultMutableTreeNode arg0)
        {
            return IExecute<bool>("isNodeDescendant", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeRelated(javax.swing.tree.DefaultMutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsNodeRelated(Javax.Swing.Tree.DefaultMutableTreeNode arg0)
        {
            return IExecute<bool>("isNodeRelated", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isNodeSibling(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsNodeSibling(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<bool>("isNodeSibling", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#isRoot()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsRoot()
        {
            return IExecute<bool>("isRoot");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getIndex(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetIndex(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<int>("getIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#breadthFirstEnumeration()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration BreadthFirstEnumerationMethod()
        {
            return IExecute<Java.Util.Enumeration>("breadthFirstEnumeration");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#children()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration Children()
        {
            return IExecute<Java.Util.Enumeration>("children");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#depthFirstEnumeration()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration DepthFirstEnumeration()
        {
            return IExecute<Java.Util.Enumeration>("depthFirstEnumeration");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#pathFromAncestorEnumeration(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration PathFromAncestorEnumeration(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<Java.Util.Enumeration>("pathFromAncestorEnumeration", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#postorderEnumeration()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration PostorderEnumerationMethod()
        {
            return IExecute<Java.Util.Enumeration>("postorderEnumeration");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#preorderEnumeration()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration PreorderEnumerationMethod()
        {
            return IExecute<Java.Util.Enumeration>("preorderEnumeration");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getChildAfter(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildAfter(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<Javax.Swing.Tree.TreeNode>("getChildAfter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getChildAt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildAt(int arg0)
        {
            return IExecute<Javax.Swing.Tree.TreeNode>("getChildAt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getChildBefore(javax.swing.tree.TreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreeNode"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetChildBefore(Javax.Swing.Tree.TreeNode arg0)
        {
            return IExecute<Javax.Swing.Tree.TreeNode>("getChildBefore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#getSharedAncestor(javax.swing.tree.DefaultMutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.DefaultMutableTreeNode"/></param>
        /// <returns><see cref="Javax.Swing.Tree.TreeNode"/></returns>
        public Javax.Swing.Tree.TreeNode GetSharedAncestor(Javax.Swing.Tree.DefaultMutableTreeNode arg0)
        {
            return IExecute<Javax.Swing.Tree.TreeNode>("getSharedAncestor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#add(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        public void Add(Javax.Swing.Tree.MutableTreeNode arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#insert(javax.swing.tree.MutableTreeNode,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Javax.Swing.Tree.MutableTreeNode arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#remove(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        public void Remove(Javax.Swing.Tree.MutableTreeNode arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#removeAllChildren()"/>
        /// </summary>
        public void RemoveAllChildren()
        {
            IExecute("removeAllChildren");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultMutableTreeNode.html#removeFromParent()"/>
        /// </summary>
        public void RemoveFromParent()
        {
            IExecute("removeFromParent");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}