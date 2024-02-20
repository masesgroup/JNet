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

namespace Javax.Swing.Tree
{
    #region ITreeCellRenderer
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ITreeCellRenderer
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeCellRenderer.html#getTreeCellRendererComponent(javax.swing.JTree,java.lang.Object,boolean,boolean,boolean,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        Java.Awt.Component GetTreeCellRendererComponent(Javax.Swing.JTree arg0, object arg1, bool arg2, bool arg3, bool arg4, int arg5, bool arg6);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeCellRenderer
    public partial class TreeCellRenderer : Javax.Swing.Tree.ITreeCellRenderer
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/TreeCellRenderer.html#getTreeCellRendererComponent(javax.swing.JTree,java.lang.Object,boolean,boolean,boolean,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JTree"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <param name="arg4"><see cref="bool"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <returns><see cref="Java.Awt.Component"/></returns>
        public Java.Awt.Component GetTreeCellRendererComponent(Javax.Swing.JTree arg0, object arg1, bool arg2, bool arg3, bool arg4, int arg5, bool arg6)
        {
            return IExecute<Java.Awt.Component>("getTreeCellRendererComponent", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}