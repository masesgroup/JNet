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

using MASES.JCOBridge.C2JBridge;
using System;

namespace Java.Awt.Dnd
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html"/>
    /// </summary>
    public interface IDropTargetListener : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragEnter(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        void DragEnter(DropTargetDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragOver(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        void DragOver(DropTargetDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dropActionChanged(java.awt.dnd.DropTargetDragEvent)"/>
        /// </summary>
        void DropActionChanged(DropTargetDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#dragExit(java.awt.dnd.DropTargetEvent)"/>
        /// </summary>
        void DragExit(DropTargetEvent dte);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html#drop(java.awt.dnd.DropTargetDropEvent)"/>
        /// </summary>
        void Drop(DropTargetDropEvent dtde);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DropTargetListener.html"/>. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IDropTargetListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class DropTargetListener : IDropTargetListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "org.mases.jnet.awt.dnd.JNetDropTargetListener";

        readonly Action<DropTargetDragEvent> DragEnterFunction = null;
        readonly Action<DropTargetDragEvent> DragOverFunction = null;
        readonly Action<DropTargetDragEvent> DropActionChangedFunction = null;
        readonly Action<DropTargetEvent> DragExitFunction = null;
        readonly Action<DropTargetDropEvent> DropFunction = null;
        /// <summary>
        /// The <see cref="Action{DropTargetDragEvent}"/> to be executed on DragEnter
        /// </summary>
        public virtual Action<DropTargetDragEvent> OnDragEnter { get { return DragEnterFunction; } }
        /// <summary>
        /// The <see cref="Action{DropTargetDragEvent}"/> to be executed on DragOver
        /// </summary>
        public virtual Action<DropTargetDragEvent> OnDragOver { get { return DragOverFunction; } }
        /// <summary>
        /// The <see cref="Action{DropTargetDragEvent}"/> to be executed on DropActionChanged
        /// </summary>
        public virtual Action<DropTargetDragEvent> OnDropActionChanged { get { return DropActionChangedFunction; } }
        /// <summary>
        /// The <see cref="Action{DropTargetEvent}"/> to be executed on DragExit
        /// </summary>
        public virtual Action<DropTargetEvent> OnDragExit { get { return DragExitFunction; } }
        /// <summary>
        /// The <see cref="Action{DropTargetDropEvent}"/> to be executed on Drop
        /// </summary>
        public virtual Action<DropTargetDropEvent> OnDrop { get { return DropFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="DropTargetListener"/>
        /// </summary>
        /// <param name="dragEnter">The <see cref="Action{DropTargetDragEvent}"/> to be executed on DragEnter</param>
        /// <param name="dragOver">The <see cref="Action{DropTargetDragEvent}"/> to be executed on DragOver</param>
        /// <param name="dropActionChanged">The <see cref="Action{DropTargetDragEvent}"/> to be executed on DropActionChanged</param>
        /// <param name="dragExit">The <see cref="Action{DropTargetEvent}"/> to be executed on DragExit</param>
        /// <param name="drop">The <see cref="Action{DropTargetDropEvent}"/> to be executed on Drop</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public DropTargetListener(Action<DropTargetDragEvent> dragEnter = null,
                                  Action<DropTargetDragEvent> dragOver = null,
                                  Action<DropTargetDragEvent> dropActionChanged = null,
                                  Action<DropTargetEvent> dragExit = null,
                                  Action<DropTargetDropEvent> drop = null,
                                  bool attachEventHandler = true)
        {
            if (dragEnter != null) DragEnterFunction = dragEnter;
            else DragEnterFunction = DragEnter;
            if (dragOver != null) DragOverFunction = dragOver;
            else DragOverFunction = DragOver;
            if (dropActionChanged != null) DropActionChangedFunction = dropActionChanged;
            else DropActionChangedFunction = DropActionChanged;
            if (dragExit != null) DragExitFunction = dragExit;
            else DragExitFunction = DragExit;
            if (drop != null) DropFunction = drop;
            else DropFunction = Drop;

            if (attachEventHandler)
            {
                AddEventHandler("dragEnter", new EventHandler<CLRListenerEventArgs<CLREventData<DropTargetDragEvent>>>(EventHandlerDragEnter));
                AddEventHandler("dragOver", new EventHandler<CLRListenerEventArgs<CLREventData<DropTargetDragEvent>>>(EventHandlerDragOver));
                AddEventHandler("dropActionChanged", new EventHandler<CLRListenerEventArgs<CLREventData<DropTargetDragEvent>>>(EventHandlerDropActionChanged));
                AddEventHandler("dragExit", new EventHandler<CLRListenerEventArgs<CLREventData<DropTargetEvent>>>(EventHandlerDragExit));
                AddEventHandler("drop", new EventHandler<CLRListenerEventArgs<CLREventData<DropTargetDropEvent>>>(EventHandlerDrop));
            }
        }

        void EventHandlerDragEnter(object sender, CLRListenerEventArgs<CLREventData<DropTargetDragEvent>> data)
        {
            OnDragEnter(data.EventData.TypedEventData);
        }

        void EventHandlerDragOver(object sender, CLRListenerEventArgs<CLREventData<DropTargetDragEvent>> data)
        {
            OnDragOver(data.EventData.TypedEventData);
        }

        void EventHandlerDropActionChanged(object sender, CLRListenerEventArgs<CLREventData<DropTargetDragEvent>> data)
        {
            OnDropActionChanged(data.EventData.TypedEventData);
        }

        void EventHandlerDragExit(object sender, CLRListenerEventArgs<CLREventData<DropTargetEvent>> data)
        {
            OnDragExit(data.EventData.TypedEventData);
        }

        void EventHandlerDrop(object sender, CLRListenerEventArgs<CLREventData<DropTargetDropEvent>> data)
        {
            OnDrop(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="IDropTargetListener.DragEnter(DropTargetDragEvent)"/>
        public virtual void DragEnter(DropTargetDragEvent dtde)
        {

        }
        /// <inheritdoc cref="IDropTargetListener.DragOver(DropTargetDragEvent)"/>
        public virtual void DragOver(DropTargetDragEvent dtde)
        {

        }
        /// <inheritdoc cref="IDropTargetListener.DropActionChanged(DropTargetDragEvent)"/>
        public virtual void DropActionChanged(DropTargetDragEvent dtde)
        {

        }
        /// <inheritdoc cref="IDropTargetListener.DragExit(DropTargetEvent)"/>
        public virtual void DragExit(DropTargetEvent dte)
        {

        }
        /// <inheritdoc cref="IDropTargetListener.Drop(DropTargetDropEvent)"/>
        public virtual void Drop(DropTargetDropEvent dtde)
        {

        }
    }
}
