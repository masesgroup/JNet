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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Event
{
    #region PrintJobAdapter
    public partial class PrintJobAdapter
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
        /// Handlers initializer for <see cref="PrintJobAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("printDataTransferCompleted", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintDataTransferCompletedEventHandler)); OnPrintDataTransferCompleted = PrintDataTransferCompleted;
            AddEventHandler("printJobCanceled", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobCanceledEventHandler)); OnPrintJobCanceled = PrintJobCanceled;
            AddEventHandler("printJobCompleted", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobCompletedEventHandler)); OnPrintJobCompleted = PrintJobCompleted;
            AddEventHandler("printJobFailed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobFailedEventHandler)); OnPrintJobFailed = PrintJobFailed;
            AddEventHandler("printJobNoMoreEvents", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobNoMoreEventsEventHandler)); OnPrintJobNoMoreEvents = PrintJobNoMoreEvents;
            AddEventHandler("printJobRequiresAttention", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobRequiresAttentionEventHandler)); OnPrintJobRequiresAttention = PrintJobRequiresAttention;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintDataTransferCompleted { get; set; }

        void PrintDataTransferCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            if (OnPrintDataTransferCompleted != null) OnPrintDataTransferCompleted.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintDataTransferCompleted(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobCanceled { get; set; }

        void PrintJobCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            if (OnPrintJobCanceled != null) OnPrintJobCanceled.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobCanceled(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobCompleted { get; set; }

        void PrintJobCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            if (OnPrintJobCompleted != null) OnPrintJobCompleted.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobCompleted(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobFailed { get; set; }

        void PrintJobFailedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            if (OnPrintJobFailed != null) OnPrintJobFailed.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobFailed(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobNoMoreEvents { get; set; }

        void PrintJobNoMoreEventsEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            if (OnPrintJobNoMoreEvents != null) OnPrintJobNoMoreEvents.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobNoMoreEvents(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobRequiresAttention { get; set; }

        void PrintJobRequiresAttentionEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            if (OnPrintJobRequiresAttention != null) OnPrintJobRequiresAttention.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobAdapter.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobRequiresAttention(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}