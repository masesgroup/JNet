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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Print.Event
{
    #region IPrintJobListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.print.event.PrintJobListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html"/>
    /// </summary>
    public partial interface IPrintJobListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintDataTransferCompleted(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobCanceled(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobCompleted(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobFailed(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobNoMoreEvents(Javax.Print.Event.PrintJobEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        void PrintJobRequiresAttention(Javax.Print.Event.PrintJobEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintJobListener
    public partial class PrintJobListener : Javax.Print.Event.IPrintJobListener
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
        /// Handlers initializer for <see cref="PrintJobListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("printDataTransferCompleted", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintDataTransferCompletedEventHandler));
            AddEventHandler("printJobCanceled", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobCanceledEventHandler));
            AddEventHandler("printJobCompleted", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobCompletedEventHandler));
            AddEventHandler("printJobFailed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobFailedEventHandler));
            AddEventHandler("printJobNoMoreEvents", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobNoMoreEventsEventHandler));
            AddEventHandler("printJobRequiresAttention", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>>>(PrintJobRequiresAttentionEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintDataTransferCompleted"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintDataTransferCompleted { get; set; } = null;

        void PrintDataTransferCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            var methodToExecute = (OnPrintDataTransferCompleted != null) ? OnPrintDataTransferCompleted : PrintDataTransferCompleted;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printDataTransferCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintDataTransferCompleted(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobCanceled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobCanceled { get; set; } = null;

        void PrintJobCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            var methodToExecute = (OnPrintJobCanceled != null) ? OnPrintJobCanceled : PrintJobCanceled;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCanceled(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobCanceled(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobCompleted"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobCompleted { get; set; } = null;

        void PrintJobCompletedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            var methodToExecute = (OnPrintJobCompleted != null) ? OnPrintJobCompleted : PrintJobCompleted;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobCompleted(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobCompleted(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobFailed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobFailed { get; set; } = null;

        void PrintJobFailedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            var methodToExecute = (OnPrintJobFailed != null) ? OnPrintJobFailed : PrintJobFailed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobFailed(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobFailed(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobNoMoreEvents"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobNoMoreEvents { get; set; } = null;

        void PrintJobNoMoreEventsEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            var methodToExecute = (OnPrintJobNoMoreEvents != null) ? OnPrintJobNoMoreEvents : PrintJobNoMoreEvents;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobNoMoreEvents(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintJobEvent"/></param>
        public virtual void PrintJobNoMoreEvents(Javax.Print.Event.PrintJobEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnPrintJobRequiresAttention"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Print.Event.PrintJobEvent> OnPrintJobRequiresAttention { get; set; } = null;

        void PrintJobRequiresAttentionEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintJobEvent>> data)
        {
            var methodToExecute = (OnPrintJobRequiresAttention != null) ? OnPrintJobRequiresAttention : PrintJobRequiresAttention;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintJobListener.html#printJobRequiresAttention(javax.print.event.PrintJobEvent)"/>
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