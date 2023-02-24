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
    #region TreeSelectionEvent
    public partial class TreeSelectionEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#%3Cinit%3E(java.lang.Object,javax.swing.tree.TreePath,boolean,javax.swing.tree.TreePath,javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public TreeSelectionEvent(object arg0, Javax.Swing.Tree.TreePath arg1, bool arg2, Javax.Swing.Tree.TreePath arg3, Javax.Swing.Tree.TreePath arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#%3Cinit%3E(java.lang.Object,javax.swing.tree.TreePath[],boolean[],javax.swing.tree.TreePath,javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <param name="arg4"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public TreeSelectionEvent(object arg0, Javax.Swing.Tree.TreePath[] arg1, bool[] arg2, Javax.Swing.Tree.TreePath arg3, Javax.Swing.Tree.TreePath arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#getNewLeadSelectionPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath NewLeadSelectionPath
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getNewLeadSelectionPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#getOldLeadSelectionPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath OldLeadSelectionPath
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getOldLeadSelectionPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#getPath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath Path
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#getPaths()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath[] Paths
        {
            get { return IExecuteArray<Javax.Swing.Tree.TreePath>("getPaths"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#isAddedPath()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsAddedPath()
        {
            return IExecute<bool>("isAddedPath");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#isAddedPath(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsAddedPath(int arg0)
        {
            return IExecute<bool>("isAddedPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#isAddedPath(javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Tree.TreePath"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsAddedPath(Javax.Swing.Tree.TreePath arg0)
        {
            return IExecute<bool>("isAddedPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeSelectionEvent.html#cloneWithSource(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="object"/></returns>
        public object CloneWithSource(object arg0)
        {
            return IExecute("cloneWithSource", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}