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
    #region TreeModelEvent
    public partial class TreeModelEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelEvent.html#%3Cinit%3E(java.lang.Object,javax.swing.tree.TreePath)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Tree.TreePath"/></param>
        public TreeModelEvent(object arg0, Javax.Swing.Tree.TreePath arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelEvent.html#getChildIndices()"/> 
        /// </summary>
        public int[] ChildIndices
        {
            get { return IExecuteArray<int>("getChildIndices"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelEvent.html#getChildren()"/> 
        /// </summary>
        public object[] Children
        {
            get { return IExecuteArray<object>("getChildren"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelEvent.html#getPath()"/> 
        /// </summary>
        public object[] Path
        {
            get { return IExecuteArray<object>("getPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeModelEvent.html#getTreePath()"/> 
        /// </summary>
        public Javax.Swing.Tree.TreePath TreePath
        {
            get { return IExecute<Javax.Swing.Tree.TreePath>("getTreePath"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}