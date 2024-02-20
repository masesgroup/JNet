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
    #region DefaultTreeCellRenderer
    public partial class DefaultTreeCellRenderer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Tree.DefaultTreeCellRenderer"/> to <see cref="Javax.Swing.Tree.TreeCellRenderer"/>
        /// </summary>
        public static implicit operator Javax.Swing.Tree.TreeCellRenderer(Javax.Swing.Tree.DefaultTreeCellRenderer t) => t.Cast<Javax.Swing.Tree.TreeCellRenderer>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getBackgroundNonSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setBackgroundNonSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color BackgroundNonSelectionColor
        {
            get { return IExecute<Java.Awt.Color>("getBackgroundNonSelectionColor"); } set { IExecute("setBackgroundNonSelectionColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getBackgroundSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setBackgroundSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color BackgroundSelectionColor
        {
            get { return IExecute<Java.Awt.Color>("getBackgroundSelectionColor"); } set { IExecute("setBackgroundSelectionColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getBorderSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setBorderSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color BorderSelectionColor
        {
            get { return IExecute<Java.Awt.Color>("getBorderSelectionColor"); } set { IExecute("setBorderSelectionColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getClosedIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setClosedIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon ClosedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getClosedIcon"); } set { IExecute("setClosedIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getDefaultClosedIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon DefaultClosedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getDefaultClosedIcon"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getDefaultLeafIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon DefaultLeafIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getDefaultLeafIcon"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getDefaultOpenIcon()"/> 
        /// </summary>
        public Javax.Swing.Icon DefaultOpenIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getDefaultOpenIcon"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getLeafIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setLeafIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon LeafIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getLeafIcon"); } set { IExecute("setLeafIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getOpenIcon()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setOpenIcon(javax.swing.Icon)"/>
        /// </summary>
        public Javax.Swing.Icon OpenIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getOpenIcon"); } set { IExecute("setOpenIcon", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getTextNonSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setTextNonSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color TextNonSelectionColor
        {
            get { return IExecute<Java.Awt.Color>("getTextNonSelectionColor"); } set { IExecute("setTextNonSelectionColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getTextSelectionColor()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#setTextSelectionColor(java.awt.Color)"/>
        /// </summary>
        public Java.Awt.Color TextSelectionColor
        {
            get { return IExecute<Java.Awt.Color>("getTextSelectionColor"); } set { IExecute("setTextSelectionColor", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/tree/DefaultTreeCellRenderer.html#getTreeCellRendererComponent(javax.swing.JTree,java.lang.Object,boolean,boolean,boolean,int,boolean)"/>
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