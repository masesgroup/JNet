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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Dnd
{
    #region DropTargetAdapter
    public partial class DropTargetAdapter
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
        /// Handlers initializer for <see cref="DropTargetAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("drop", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDropEvent>>>(DropEventHandler)); OnDrop = Drop;
            AddEventHandler("dragEnter", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>>>(DragEnterEventHandler)); OnDragEnter = DragEnter;
            AddEventHandler("dragExit", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetEvent>>>(DragExitEventHandler)); OnDragExit = DragExit;
            AddEventHandler("dragOver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>>>(DragOverEventHandler)); OnDragOver = DragOver;
            AddEventHandler("dropActionChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>>>(DropActionChangedEventHandler)); OnDropActionChanged = DropActionChanged;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.Dnd.DropTargetDropEvent> OnDrop { get; set; }

        void DropEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDropEvent>> data)
        {
            if (OnDrop != null) OnDrop.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDropEvent"/></param>
        public virtual void Drop(Java.Awt.Dnd.DropTargetDropEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDragEnter { get; set; }

        void DragEnterEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>> data)
        {
            if (OnDragEnter != null) OnDragEnter.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DragEnter(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.Dnd.DropTargetEvent> OnDragExit { get; set; }

        void DragExitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetEvent>> data)
        {
            if (OnDragExit != null) OnDragExit.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetEvent"/></param>
        public virtual void DragExit(Java.Awt.Dnd.DropTargetEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDragOver { get; set; }

        void DragOverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>> data)
        {
            if (OnDragOver != null) OnDragOver.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DragOver(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.Dnd.DropTargetDragEvent> OnDropActionChanged { get; set; }

        void DropActionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DropTargetDragEvent>> data)
        {
            if (OnDropActionChanged != null) OnDropActionChanged.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetAdapter.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DropTargetDragEvent"/></param>
        public virtual void DropActionChanged(Java.Awt.Dnd.DropTargetDragEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}