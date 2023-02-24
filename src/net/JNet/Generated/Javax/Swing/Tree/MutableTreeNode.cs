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
    #region MutableTreeNode
    public partial class MutableTreeNode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.MutableTreeNode"/> to <see cref="Javax.Swing.Tree.TreeNode"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.TreeNode(Javax.Swing.Tree.MutableTreeNode t) => t.Cast<Javax.Swing.Tree.TreeNode>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/MutableTreeNode.html#insert(javax.swing.tree.MutableTreeNode,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Insert(Javax.Swing.Tree.MutableTreeNode arg0, int arg1)
        {
            IExecute("insert", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/MutableTreeNode.html#remove(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void Remove(int arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/MutableTreeNode.html#remove(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        public void Remove(Javax.Swing.Tree.MutableTreeNode arg0)
        {
            IExecute("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/MutableTreeNode.html#removeFromParent()"/>
        /// </summary>
        public void RemoveFromParent()
        {
            IExecute("removeFromParent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/MutableTreeNode.html#setParent(javax.swing.tree.MutableTreeNode)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.MutableTreeNode"/></param>
        public void SetParent(Javax.Swing.Tree.MutableTreeNode arg0)
        {
            IExecute("setParent", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/MutableTreeNode.html#setUserObject(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void SetUserObject(object arg0)
        {
            IExecute("setUserObject", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}