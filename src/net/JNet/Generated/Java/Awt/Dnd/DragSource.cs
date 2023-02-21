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
    #region DragSource
    public partial class DragSource
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Io.Serializable(Java.Awt.Dnd.DragSource t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultCopyDrop
        /// </summary>
        public static Java.Awt.Cursor DefaultCopyDrop => Clazz.GetField<Java.Awt.Cursor>("DefaultCopyDrop");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultMoveDrop
        /// </summary>
        public static Java.Awt.Cursor DefaultMoveDrop => Clazz.GetField<Java.Awt.Cursor>("DefaultMoveDrop");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultLinkDrop
        /// </summary>
        public static Java.Awt.Cursor DefaultLinkDrop => Clazz.GetField<Java.Awt.Cursor>("DefaultLinkDrop");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultCopyNoDrop
        /// </summary>
        public static Java.Awt.Cursor DefaultCopyNoDrop => Clazz.GetField<Java.Awt.Cursor>("DefaultCopyNoDrop");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultMoveNoDrop
        /// </summary>
        public static Java.Awt.Cursor DefaultMoveNoDrop => Clazz.GetField<Java.Awt.Cursor>("DefaultMoveNoDrop");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#DefaultLinkNoDrop
        /// </summary>
        public static Java.Awt.Cursor DefaultLinkNoDrop => Clazz.GetField<Java.Awt.Cursor>("DefaultLinkNoDrop");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getDefaultDragSource() 
        /// </summary>
        public static Java.Awt.Dnd.DragSource DefaultDragSource
        {
            get { return SExecute<Java.Awt.Dnd.DragSource>("getDefaultDragSource"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getDragThreshold() 
        /// </summary>
        public static int DragThreshold
        {
            get { return SExecute<int>("getDragThreshold"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#isDragImageSupported()
        /// </summary>
        public static bool IsDragImageSupported()
        {
            return SExecute<bool>("isDragImageSupported");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getDragSourceListeners() 
        /// </summary>
        public Java.Awt.Dnd.DragSourceListener[] DragSourceListeners
        {
            get { return IExecuteArray<Java.Awt.Dnd.DragSourceListener>("getDragSourceListeners"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getDragSourceMotionListeners() 
        /// </summary>
        public Java.Awt.Dnd.DragSourceMotionListener[] DragSourceMotionListeners
        {
            get { return IExecuteArray<Java.Awt.Dnd.DragSourceMotionListener>("getDragSourceMotionListeners"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#getFlavorMap() 
        /// </summary>
        public Java.Awt.Datatransfer.FlavorMap FlavorMap
        {
            get { return IExecute<Java.Awt.Datatransfer.FlavorMap>("getFlavorMap"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#createDefaultDragGestureRecognizer(java.awt.Component,int,java.awt.dnd.DragGestureListener)
        /// </summary>
        public Java.Awt.Dnd.DragGestureRecognizer CreateDefaultDragGestureRecognizer(Java.Awt.Component arg0, int arg1, Java.Awt.Dnd.DragGestureListener arg2)
        {
            return IExecute<Java.Awt.Dnd.DragGestureRecognizer>("createDefaultDragGestureRecognizer", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#addDragSourceListener(java.awt.dnd.DragSourceListener)
        /// </summary>
        public void AddDragSourceListener(Java.Awt.Dnd.DragSourceListener arg0)
        {
            IExecute("addDragSourceListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#addDragSourceMotionListener(java.awt.dnd.DragSourceMotionListener)
        /// </summary>
        public void AddDragSourceMotionListener(Java.Awt.Dnd.DragSourceMotionListener arg0)
        {
            IExecute("addDragSourceMotionListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#removeDragSourceListener(java.awt.dnd.DragSourceListener)
        /// </summary>
        public void RemoveDragSourceListener(Java.Awt.Dnd.DragSourceListener arg0)
        {
            IExecute("removeDragSourceListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#removeDragSourceMotionListener(java.awt.dnd.DragSourceMotionListener)
        /// </summary>
        public void RemoveDragSourceMotionListener(Java.Awt.Dnd.DragSourceMotionListener arg0)
        {
            IExecute("removeDragSourceMotionListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#startDrag(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener,java.awt.datatransfer.FlavorMap) throws java.awt.dnd.InvalidDnDOperationException
        /// </summary>
        public void StartDrag(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Datatransfer.Transferable arg2, Java.Awt.Dnd.DragSourceListener arg3, Java.Awt.Datatransfer.FlavorMap arg4)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#startDrag(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener) throws java.awt.dnd.InvalidDnDOperationException
        /// </summary>
        public void StartDrag(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Datatransfer.Transferable arg2, Java.Awt.Dnd.DragSourceListener arg3)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#startDrag(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.Image,java.awt.Point,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener,java.awt.datatransfer.FlavorMap) throws java.awt.dnd.InvalidDnDOperationException
        /// </summary>
        public void StartDrag(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Image arg2, Java.Awt.Point arg3, Java.Awt.Datatransfer.Transferable arg4, Java.Awt.Dnd.DragSourceListener arg5, Java.Awt.Datatransfer.FlavorMap arg6)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSource.html#startDrag(java.awt.dnd.DragGestureEvent,java.awt.Cursor,java.awt.Image,java.awt.Point,java.awt.datatransfer.Transferable,java.awt.dnd.DragSourceListener) throws java.awt.dnd.InvalidDnDOperationException
        /// </summary>
        public void StartDrag(Java.Awt.Dnd.DragGestureEvent arg0, Java.Awt.Cursor arg1, Java.Awt.Image arg2, Java.Awt.Point arg3, Java.Awt.Datatransfer.Transferable arg4, Java.Awt.Dnd.DragSourceListener arg5)
        {
            IExecute("startDrag", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}