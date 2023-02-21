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

namespace Java.Awt.Dnd
{
    #region DragSourceContext
    public partial class DragSourceContext
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#<init>(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.Image,java.awt.Point,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener)
        /// </summary>
        public DragSourceContext(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Image arg2, Java.Awt.Point arg3, Java.Awt.Datatransfer.Transferable arg4, Java.Awt.Dnd.DragSourceListener arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Awt.Dnd.DragSourceListener(Java.Awt.Dnd.DragSourceContext t) => t.Cast<Java.Awt.Dnd.DragSourceListener>();
        public static implicit operator Java.Awt.Dnd.DragSourceMotionListener(Java.Awt.Dnd.DragSourceContext t) => t.Cast<Java.Awt.Dnd.DragSourceMotionListener>();
        public static implicit operator Java.Io.Serializable(Java.Awt.Dnd.DragSourceContext t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#getComponent() 
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecute<Java.Awt.Component>("getComponent"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#getCursor() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#setCursor(java.awt.Cursor)
        /// </summary>
        public Java.Awt.Cursor Cursor
        {
            get { return IExecute<Java.Awt.Cursor>("getCursor"); } set { IExecute("setCursor", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#getDragSource() 
        /// </summary>
        public Java.Awt.Dnd.DragSource DragSource
        {
            get { return IExecute<Java.Awt.Dnd.DragSource>("getDragSource"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#getSourceActions() 
        /// </summary>
        public int SourceActions
        {
            get { return IExecute<int>("getSourceActions"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#getTransferable() 
        /// </summary>
        public Java.Awt.Datatransfer.Transferable Transferable
        {
            get { return IExecute<Java.Awt.Datatransfer.Transferable>("getTransferable"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#getTrigger() 
        /// </summary>
        public Java.Awt.Dnd.DragGestureEvent Trigger
        {
            get { return IExecute<Java.Awt.Dnd.DragGestureEvent>("getTrigger"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#addDragSourceListener(java.awt.dnd.DragSourceListener) throws java.util.TooManyListenersException
        /// </summary>
        public void AddDragSourceListener(Java.Awt.Dnd.DragSourceListener arg0)
        {
            IExecute("addDragSourceListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#removeDragSourceListener(java.awt.dnd.DragSourceListener)
        /// </summary>
        public void RemoveDragSourceListener(Java.Awt.Dnd.DragSourceListener arg0)
        {
            IExecute("removeDragSourceListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#dragDropEnd(java.awt.dnd.DragSourceDropEvent)
        /// </summary>
        public void DragDropEnd(Java.Awt.Dnd.DragSourceDropEvent arg0)
        {
            IExecute("dragDropEnd", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#dragEnter(java.awt.dnd.DragSourceDragEvent)
        /// </summary>
        public void DragEnter(Java.Awt.Dnd.DragSourceDragEvent arg0)
        {
            IExecute("dragEnter", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#dragExit(java.awt.dnd.DragSourceEvent)
        /// </summary>
        public void DragExit(Java.Awt.Dnd.DragSourceEvent arg0)
        {
            IExecute("dragExit", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#dragMouseMoved(java.awt.dnd.DragSourceDragEvent)
        /// </summary>
        public void DragMouseMoved(Java.Awt.Dnd.DragSourceDragEvent arg0)
        {
            IExecute("dragMouseMoved", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#dragOver(java.awt.dnd.DragSourceDragEvent)
        /// </summary>
        public void DragOver(Java.Awt.Dnd.DragSourceDragEvent arg0)
        {
            IExecute("dragOver", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#dropActionChanged(java.awt.dnd.DragSourceDragEvent)
        /// </summary>
        public void DropActionChanged(Java.Awt.Dnd.DragSourceDragEvent arg0)
        {
            IExecute("dropActionChanged", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceContext.html#transferablesFlavorsChanged()
        /// </summary>
        public void TransferablesFlavorsChanged()
        {
            IExecute("transferablesFlavorsChanged");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}