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
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceListener.html"/>
    /// </summary>
    public interface IDragSourceListener : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceListener.html#dragEnter(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        void DragEnter(DragSourceDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceListener.html#dragOver(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        void DragOver(DragSourceDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceListener.html#dropActionChanged(java.awt.dnd.DragSourceDragEvent)"/>
        /// </summary>
        void DropActionChanged(DragSourceDragEvent dtde);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceListener.html#dragExit(java.awt.dnd.DragSourceEvent)"/>
        /// </summary>
        void DragExit(DragSourceEvent dte);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceListener.html#dragDropEnd(java.awt.dnd.DragSourceDropEvent)"/>
        /// </summary>
        void DragDropEnd(DragSourceDropEvent dsde);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragSourceListener.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>, implements <see cref="IDragSourceListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class DragSourceListener : IDragSourceListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.awt.dnd.JNetDragSourceAdapter"; // <-- the implementing class is this one

        readonly Action<DragSourceDragEvent> DragEnterFunction = null;
        readonly Action<DragSourceDragEvent> DragOverFunction = null;
        readonly Action<DragSourceDragEvent> DropActionChangedFunction = null;
        readonly Action<DragSourceEvent> DragExitFunction = null;
        readonly Action<DragSourceDropEvent> DragDropEndFunction = null;
        /// <summary>
        /// The <see cref="Action{DragSourceDragEvent}"/> to be executed on DragEnter
        /// </summary>
        public virtual Action<DragSourceDragEvent> OnDragEnter { get { return DragEnterFunction; } }
        /// <summary>
        /// The <see cref="Action{DragSourceDragEvent}"/> to be executed on DragOver
        /// </summary>
        public virtual Action<DragSourceDragEvent> OnDragOver { get { return DragOverFunction; } }
        /// <summary>
        /// The <see cref="Action{DragSourceDragEvent}"/> to be executed on DropActionChanged
        /// </summary>
        public virtual Action<DragSourceDragEvent> OnDropActionChanged { get { return DropActionChangedFunction; } }
        /// <summary>
        /// The <see cref="Action{DragSourceEvent}"/> to be executed on DragExit
        /// </summary>
        public virtual Action<DragSourceEvent> OnDragExit { get { return DragExitFunction; } }
        /// <summary>
        /// The <see cref="Action{DragSourceDropEvent}"/> to be executed on DragDropEnd
        /// </summary>
        public virtual Action<DragSourceDropEvent> OnDragDropEnd { get { return DragDropEndFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="DragSourceListener"/>
        /// </summary>
        /// <param name="dragEnter">The <see cref="Action{DragSourceDragEvent}"/> to be executed on DragEnter</param>
        /// <param name="dragOver">The <see cref="Action{DragSourceDragEvent}"/> to be executed on DragOver</param>
        /// <param name="dropActionChanged">The <see cref="Action{DragSourceDragEvent}"/> to be executed on DropActionChanged</param>
        /// <param name="dragExit">The <see cref="Action{DragSourceEvent}"/> to be executed on DragExit</param>
        /// <param name="dragDropEnd">The <see cref="Action{DragSourceDropEvent}"/> to be executed on DragDropEnd</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public DragSourceListener(Action<DragSourceDragEvent> dragEnter = null,
                                 Action<DragSourceDragEvent> dragOver = null,
                                 Action<DragSourceDragEvent> dropActionChanged = null,
                                 Action<DragSourceEvent> dragExit = null,
                                 Action<DragSourceDropEvent> dragDropEnd = null,
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
            if (dragDropEnd != null) DragDropEndFunction = dragDropEnd;
            else DragDropEndFunction = DragDropEnd;

            if (attachEventHandler)
            {
                AddEventHandler("dragEnter", new EventHandler<CLRListenerEventArgs<CLREventData<DragSourceDragEvent>>>(EventHandlerDragEnter));
                AddEventHandler("dragOver", new EventHandler<CLRListenerEventArgs<CLREventData<DragSourceDragEvent>>>(EventHandlerDragOver));
                AddEventHandler("dropActionChanged", new EventHandler<CLRListenerEventArgs<CLREventData<DragSourceDragEvent>>>(EventHandlerDropActionChanged));
                AddEventHandler("dragExit", new EventHandler<CLRListenerEventArgs<CLREventData<DragSourceEvent>>>(EventHandlerDragExit));
                AddEventHandler("dragDropEnd", new EventHandler<CLRListenerEventArgs<CLREventData<DragSourceDropEvent>>>(EventHandlerDragDropEnd));
            }
        }

        void EventHandlerDragEnter(object sender, CLRListenerEventArgs<CLREventData<DragSourceDragEvent>> data)
        {
            OnDragEnter(data.EventData.TypedEventData);
        }

        void EventHandlerDragOver(object sender, CLRListenerEventArgs<CLREventData<DragSourceDragEvent>> data)
        {
            OnDragOver(data.EventData.TypedEventData);
        }

        void EventHandlerDropActionChanged(object sender, CLRListenerEventArgs<CLREventData<DragSourceDragEvent>> data)
        {
            OnDropActionChanged(data.EventData.TypedEventData);
        }

        void EventHandlerDragExit(object sender, CLRListenerEventArgs<CLREventData<DragSourceEvent>> data)
        {
            OnDragExit(data.EventData.TypedEventData);
        }

        void EventHandlerDragDropEnd(object sender, CLRListenerEventArgs<CLREventData<DragSourceDropEvent>> data)
        {
            OnDragDropEnd(data.EventData.TypedEventData);
        }

        /// <inheritdoc cref="IDragSourceListener.DragEnter(DragSourceDragEvent)"/>
        public virtual void DragEnter(DragSourceDragEvent dtde)
        {

        }
        /// <inheritdoc cref="IDragSourceListener.DragOver(DragSourceDragEvent)"/>
        public virtual void DragOver(DragSourceDragEvent dtde)
        {

        }
        /// <inheritdoc cref="IDragSourceListener.DropActionChanged(DragSourceDragEvent)"/>
        public virtual void DropActionChanged(DragSourceDragEvent dtde)
        {

        }
        /// <inheritdoc cref="IDragSourceListener.DragExit(DragSourceEvent)"/>
        public virtual void DragExit(DragSourceEvent dte)
        {

        }
        /// <inheritdoc cref="IDragSourceListener.DragDropEnd(DragSourceDropEvent)"/>
        public virtual void DragDropEnd(DragSourceDropEvent dsde)
        {

        }
    }
}
