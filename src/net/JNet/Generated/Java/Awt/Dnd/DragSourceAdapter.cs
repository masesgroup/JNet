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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.Dnd
{
    #region DragSourceAdapter
    public partial class DragSourceAdapter
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
        /// Handlers initializer for <see cref="DragSourceAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("dragDropEnd", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDropEvent>>>(DragDropEndEventHandler));
            AddEventHandler("dragEnter", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDragEvent>>>(DragEnterEventHandler));
            AddEventHandler("dragExit", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceEvent>>>(DragExitEventHandler));
            AddEventHandler("dragMouseMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDragEvent>>>(DragMouseMovedEventHandler));
            AddEventHandler("dragOver", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDragEvent>>>(DragOverEventHandler));
            AddEventHandler("dropActionChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDragEvent>>>(DropActionChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragDropEnd(java.awt.dnd.DragSourceDropEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragDropEnd"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.Dnd.DragSourceDropEvent> OnDragDropEnd { get; set; } = null;

        void DragDropEndEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDropEvent>> data)
        {
            var methodToExecute = (OnDragDropEnd != null) ? OnDragDropEnd : DragDropEnd;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragDropEnd(java.awt.dnd.DragSourceDropEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceDropEvent"/></param>
        public virtual void DragDropEnd(Java.Awt.Dnd.DragSourceDropEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragEnter(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragEnter"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.Dnd.DragSourceDragEvent> OnDragEnter { get; set; } = null;

        void DragEnterEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDragEvent>> data)
        {
            var methodToExecute = (OnDragEnter != null) ? OnDragEnter : DragEnter;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragEnter(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceDragEvent"/></param>
        public virtual void DragEnter(Java.Awt.Dnd.DragSourceDragEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragExit(java.awt.dnd.DragSourceEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragExit"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.Dnd.DragSourceEvent> OnDragExit { get; set; } = null;

        void DragExitEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceEvent>> data)
        {
            var methodToExecute = (OnDragExit != null) ? OnDragExit : DragExit;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragExit(java.awt.dnd.DragSourceEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceEvent"/></param>
        public virtual void DragExit(Java.Awt.Dnd.DragSourceEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragMouseMoved(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragMouseMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.Dnd.DragSourceDragEvent> OnDragMouseMoved { get; set; } = null;

        void DragMouseMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDragEvent>> data)
        {
            var methodToExecute = (OnDragMouseMoved != null) ? OnDragMouseMoved : DragMouseMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragMouseMoved(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceDragEvent"/></param>
        public virtual void DragMouseMoved(Java.Awt.Dnd.DragSourceDragEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragOver(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDragOver"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.Dnd.DragSourceDragEvent> OnDragOver { get; set; } = null;

        void DragOverEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDragEvent>> data)
        {
            var methodToExecute = (OnDragOver != null) ? OnDragOver : DragOver;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dragOver(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceDragEvent"/></param>
        public virtual void DragOver(Java.Awt.Dnd.DragSourceDragEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dropActionChanged(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnDropActionChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.Dnd.DragSourceDragEvent> OnDropActionChanged { get; set; } = null;

        void DropActionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.Dnd.DragSourceDragEvent>> data)
        {
            var methodToExecute = (OnDropActionChanged != null) ? OnDropActionChanged : DropActionChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceAdapter.html#dropActionChanged(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Dnd.DragSourceDragEvent"/></param>
        public virtual void DropActionChanged(Java.Awt.Dnd.DragSourceDragEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}