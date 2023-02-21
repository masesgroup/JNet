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

namespace Javax.Swing.Plaf.Basic
{
    #region BasicTreeUI
    public partial class BasicTreeUI
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getCollapsedIcon() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setCollapsedIcon(javax.swing.Icon)
        /// </summary>
        public Javax.Swing.Icon CollapsedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getCollapsedIcon"); } set { IExecute("setCollapsedIcon", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getExpandedIcon() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setExpandedIcon(javax.swing.Icon)
        /// </summary>
        public Javax.Swing.Icon ExpandedIcon
        {
            get { return IExecute<Javax.Swing.Icon>("getExpandedIcon"); } set { IExecute("setExpandedIcon", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getLeftChildIndent() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setLeftChildIndent(int)
        /// </summary>
        public int LeftChildIndent
        {
            get { return IExecute<int>("getLeftChildIndent"); } set { IExecute("setLeftChildIndent", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getPreferredMinSize() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setPreferredMinSize(java.awt.Dimension)
        /// </summary>
        public Java.Awt.Dimension PreferredMinSize
        {
            get { return IExecute<Java.Awt.Dimension>("getPreferredMinSize"); } set { IExecute("setPreferredMinSize", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getRightChildIndent() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#setRightChildIndent(int)
        /// </summary>
        public int RightChildIndent
        {
            get { return IExecute<int>("getRightChildIndent"); } set { IExecute("setRightChildIndent", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.html#getPreferredSize(javax.swing.JComponent,boolean)
        /// </summary>
        public Java.Awt.Dimension GetPreferredSize(Javax.Swing.JComponent arg0, bool arg1)
        {
            return IExecute<Java.Awt.Dimension>("getPreferredSize", arg0, arg1);
        }
        
        #endregion

        #region Nested classes
        #region NodeDimensionsHandler
        public partial class NodeDimensionsHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.NodeDimensionsHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI)
            /// </summary>
            public NodeDimensionsHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region PropertyChangeHandler
        public partial class PropertyChangeHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.PropertyChangeHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI)
            /// </summary>
            public PropertyChangeHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicTreeUI.PropertyChangeHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.PropertyChangeHandler.html#propertyChange(java.beans.PropertyChangeEvent)
            /// </summary>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecute("propertyChange", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeModelHandler
        public partial class TreeModelHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI)
            /// </summary>
            public TreeModelHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Javax.Swing.Event.TreeModelListener(Javax.Swing.Plaf.Basic.BasicTreeUI.TreeModelHandler t) => t.Cast<Javax.Swing.Event.TreeModelListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#treeNodesChanged(javax.swing.event.TreeModelEvent)
            /// </summary>
            public void TreeNodesChanged(Javax.Swing.Event.TreeModelEvent arg0)
            {
                IExecute("treeNodesChanged", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#treeNodesInserted(javax.swing.event.TreeModelEvent)
            /// </summary>
            public void TreeNodesInserted(Javax.Swing.Event.TreeModelEvent arg0)
            {
                IExecute("treeNodesInserted", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#treeNodesRemoved(javax.swing.event.TreeModelEvent)
            /// </summary>
            public void TreeNodesRemoved(Javax.Swing.Event.TreeModelEvent arg0)
            {
                IExecute("treeNodesRemoved", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeModelHandler.html#treeStructureChanged(javax.swing.event.TreeModelEvent)
            /// </summary>
            public void TreeStructureChanged(Javax.Swing.Event.TreeModelEvent arg0)
            {
                IExecute("treeStructureChanged", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreePageAction
        public partial class TreePageAction
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreePageAction.html#<init>(javax.swing.plaf.basic.BasicTreeUI,int,java.lang.String)
            /// </summary>
            public TreePageAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, int arg1, string arg2)
                : base(arg0, arg1, arg2)
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeIncrementAction
        public partial class TreeIncrementAction
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeIncrementAction.html#<init>(javax.swing.plaf.basic.BasicTreeUI,int,java.lang.String)
            /// </summary>
            public TreeIncrementAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, int arg1, string arg2)
                : base(arg0, arg1, arg2)
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region FocusHandler
        public partial class FocusHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.FocusHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI)
            /// </summary>
            public FocusHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Awt.EventNs.FocusListener(Javax.Swing.Plaf.Basic.BasicTreeUI.FocusHandler t) => t.Cast<Java.Awt.EventNs.FocusListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.FocusHandler.html#focusGained(java.awt.event.FocusEvent)
            /// </summary>
            public void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusGained", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.FocusHandler.html#focusLost(java.awt.event.FocusEvent)
            /// </summary>
            public void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
            {
                IExecute("focusLost", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeCancelEditingAction
        public partial class TreeCancelEditingAction
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeCancelEditingAction.html#<init>(javax.swing.plaf.basic.BasicTreeUI,java.lang.String)
            /// </summary>
            public TreeCancelEditingAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, string arg1)
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region CellEditorHandler
        public partial class CellEditorHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.CellEditorHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI)
            /// </summary>
            public CellEditorHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Javax.Swing.Event.CellEditorListener(Javax.Swing.Plaf.Basic.BasicTreeUI.CellEditorHandler t) => t.Cast<Javax.Swing.Event.CellEditorListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.CellEditorHandler.html#editingCanceled(javax.swing.event.ChangeEvent)
            /// </summary>
            public void EditingCanceled(Javax.Swing.Event.ChangeEvent arg0)
            {
                IExecute("editingCanceled", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.CellEditorHandler.html#editingStopped(javax.swing.event.ChangeEvent)
            /// </summary>
            public void EditingStopped(Javax.Swing.Event.ChangeEvent arg0)
            {
                IExecute("editingStopped", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeToggleAction
        public partial class TreeToggleAction
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeToggleAction.html#<init>(javax.swing.plaf.basic.BasicTreeUI,java.lang.String)
            /// </summary>
            public TreeToggleAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, string arg1)
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeSelectionHandler
        public partial class TreeSelectionHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeSelectionHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI)
            /// </summary>
            public TreeSelectionHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Javax.Swing.Event.TreeSelectionListener(Javax.Swing.Plaf.Basic.BasicTreeUI.TreeSelectionHandler t) => t.Cast<Javax.Swing.Event.TreeSelectionListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeSelectionHandler.html#valueChanged(javax.swing.event.TreeSelectionEvent)
            /// </summary>
            public void ValueChanged(Javax.Swing.Event.TreeSelectionEvent arg0)
            {
                IExecute("valueChanged", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region SelectionModelPropertyChangeHandler
        public partial class SelectionModelPropertyChangeHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.SelectionModelPropertyChangeHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI)
            /// </summary>
            public SelectionModelPropertyChangeHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Beans.PropertyChangeListener(Javax.Swing.Plaf.Basic.BasicTreeUI.SelectionModelPropertyChangeHandler t) => t.Cast<Java.Beans.PropertyChangeListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.SelectionModelPropertyChangeHandler.html#propertyChange(java.beans.PropertyChangeEvent)
            /// </summary>
            public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
            {
                IExecute("propertyChange", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeExpansionHandler
        public partial class TreeExpansionHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeExpansionHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI)
            /// </summary>
            public TreeExpansionHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0)
                : base(arg0)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Javax.Swing.Event.TreeExpansionListener(Javax.Swing.Plaf.Basic.BasicTreeUI.TreeExpansionHandler t) => t.Cast<Javax.Swing.Event.TreeExpansionListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeExpansionHandler.html#treeCollapsed(javax.swing.event.TreeExpansionEvent)
            /// </summary>
            public void TreeCollapsed(Javax.Swing.Event.TreeExpansionEvent arg0)
            {
                IExecute("treeCollapsed", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeExpansionHandler.html#treeExpanded(javax.swing.event.TreeExpansionEvent)
            /// </summary>
            public void TreeExpanded(Javax.Swing.Event.TreeExpansionEvent arg0)
            {
                IExecute("treeExpanded", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeTraverseAction
        public partial class TreeTraverseAction
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeTraverseAction.html#<init>(javax.swing.plaf.basic.BasicTreeUI,int,java.lang.String)
            /// </summary>
            public TreeTraverseAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, int arg1, string arg2)
                : base(arg0, arg1, arg2)
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region TreeHomeAction
        public partial class TreeHomeAction
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.TreeHomeAction.html#<init>(javax.swing.plaf.basic.BasicTreeUI,int,java.lang.String)
            /// </summary>
            public TreeHomeAction(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, int arg1, string arg2)
                : base(arg0, arg1, arg2)
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

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region MouseInputHandler
        public partial class MouseInputHandler
        {
            #region Constructors
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#<init>(javax.swing.plaf.basic.BasicTreeUI,java.awt.Component,java.awt.Component,java.awt.event.MouseEvent)
            /// </summary>
            public MouseInputHandler(Javax.Swing.Plaf.Basic.BasicTreeUI arg0, Java.Awt.Component arg1, Java.Awt.Component arg2, Java.Awt.EventNs.MouseEvent arg3)
                : base(arg0, arg1, arg2, arg3)
            {
            }
            
            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Javax.Swing.Event.MouseInputListener(Javax.Swing.Plaf.Basic.BasicTreeUI.MouseInputHandler t) => t.Cast<Javax.Swing.Event.MouseInputListener>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseClicked(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseClicked(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseClicked", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseDragged(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseDragged(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseDragged", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseEntered(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseEntered(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseEntered", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseExited(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseExited(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseExited", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseMoved(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseMoved(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseMoved", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mousePressed(java.awt.event.MouseEvent)
            /// </summary>
            public void MousePressed(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mousePressed", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicTreeUI.MouseInputHandler.html#mouseReleased(java.awt.event.MouseEvent)
            /// </summary>
            public void MouseReleased(Java.Awt.EventNs.MouseEvent arg0)
            {
                IExecute("mouseReleased", arg0);
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