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
    #region DropTarget
    public partial class DropTarget
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#<init>(java.awt.Component,int,java.awt.dnd.DropTargetListener) throws java.awt.HeadlessException
        /// </summary>
        public DropTarget(Java.Awt.Component arg0, int arg1, Java.Awt.Dnd.DropTargetListener arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#<init>(java.awt.Component,java.awt.dnd.DropTargetListener) throws java.awt.HeadlessException
        /// </summary>
        public DropTarget(Java.Awt.Component arg0, Java.Awt.Dnd.DropTargetListener arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#<init>(java.awt.Component,int,java.awt.dnd.DropTargetListener,boolean) throws java.awt.HeadlessException
        /// </summary>
        public DropTarget(Java.Awt.Component arg0, int arg1, Java.Awt.Dnd.DropTargetListener arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#<init>(java.awt.Component,int,java.awt.dnd.DropTargetListener,boolean,java.awt.datatransfer.FlavorMap) throws java.awt.HeadlessException
        /// </summary>
        public DropTarget(Java.Awt.Component arg0, int arg1, Java.Awt.Dnd.DropTargetListener arg2, bool arg3, Java.Awt.Datatransfer.FlavorMap arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Awt.Dnd.DropTargetListener(Java.Awt.Dnd.DropTarget t) => t.Cast<Java.Awt.Dnd.DropTargetListener>();
        public static implicit operator Java.Io.Serializable(Java.Awt.Dnd.DropTarget t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#getComponent() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#setComponent(java.awt.Component)
        /// </summary>
        public Java.Awt.Component Component
        {
            get { return IExecute<Java.Awt.Component>("getComponent"); } set { IExecute("setComponent", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#getDefaultActions() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#setDefaultActions(int)
        /// </summary>
        public int DefaultActions
        {
            get { return IExecute<int>("getDefaultActions"); } set { IExecute("setDefaultActions", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#getDropTargetContext() 
        /// </summary>
        public Java.Awt.Dnd.DropTargetContext DropTargetContext
        {
            get { return IExecute<Java.Awt.Dnd.DropTargetContext>("getDropTargetContext"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#getFlavorMap() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#setFlavorMap(java.awt.datatransfer.FlavorMap)
        /// </summary>
        public Java.Awt.Datatransfer.FlavorMap FlavorMap
        {
            get { return IExecute<Java.Awt.Datatransfer.FlavorMap>("getFlavorMap"); } set { IExecute("setFlavorMap", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#isActive()
        /// </summary>
        public bool IsActive()
        {
            return IExecute<bool>("isActive");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#addDropTargetListener(java.awt.dnd.DropTargetListener) throws java.util.TooManyListenersException
        /// </summary>
        public void AddDropTargetListener(Java.Awt.Dnd.DropTargetListener arg0)
        {
            IExecute("addDropTargetListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#dragEnter(java.awt.dnd.DropTargetDragEvent)
        /// </summary>
        public void DragEnter(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecute("dragEnter", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#dragExit(java.awt.dnd.DropTargetEvent)
        /// </summary>
        public void DragExit(Java.Awt.Dnd.DropTargetEvent arg0)
        {
            IExecute("dragExit", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#dragOver(java.awt.dnd.DropTargetDragEvent)
        /// </summary>
        public void DragOver(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecute("dragOver", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#drop(java.awt.dnd.DropTargetDropEvent)
        /// </summary>
        public void Drop(Java.Awt.Dnd.DropTargetDropEvent arg0)
        {
            IExecute("drop", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)
        /// </summary>
        public void DropActionChanged(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            IExecute("dropActionChanged", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#removeDropTargetListener(java.awt.dnd.DropTargetListener)
        /// </summary>
        public void RemoveDropTargetListener(Java.Awt.Dnd.DropTargetListener arg0)
        {
            IExecute("removeDropTargetListener", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#setActive(boolean)
        /// </summary>
        public void SetActive(bool arg0)
        {
            IExecute("setActive", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#addNotify()
        /// </summary>
        public void AddNotify()
        {
            IExecute("addNotify");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTarget.html#removeNotify()
        /// </summary>
        public void RemoveNotify()
        {
            IExecute("removeNotify");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}