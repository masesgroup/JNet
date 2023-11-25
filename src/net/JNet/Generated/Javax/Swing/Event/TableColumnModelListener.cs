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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region ITableColumnModelListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.TableColumnModelListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html"/>
    /// </summary>
    public partial interface ITableColumnModelListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnAdded(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        void ColumnAdded(Javax.Swing.Event.TableColumnModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMarginChanged(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        void ColumnMarginChanged(Javax.Swing.Event.ChangeEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        void ColumnMoved(Javax.Swing.Event.TableColumnModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnRemoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        void ColumnRemoved(Javax.Swing.Event.TableColumnModelEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnSelectionChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        void ColumnSelectionChanged(Javax.Swing.Event.ListSelectionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableColumnModelListener
    public partial class TableColumnModelListener : Javax.Swing.Event.ITableColumnModelListener
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
        /// Handlers initializer for <see cref="TableColumnModelListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("columnAdded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableColumnModelEvent>>>(ColumnAddedEventHandler));
            AddEventHandler("columnMarginChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>>>(ColumnMarginChangedEventHandler));
            AddEventHandler("columnMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableColumnModelEvent>>>(ColumnMovedEventHandler));
            AddEventHandler("columnRemoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableColumnModelEvent>>>(ColumnRemovedEventHandler));
            AddEventHandler("columnSelectionChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListSelectionEvent>>>(ColumnSelectionChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnAdded(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.TableColumnModelEvent> OnColumnAdded { get; set; } = null;

        void ColumnAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableColumnModelEvent>> data)
        {
            var methodToExecute = (OnColumnAdded != null) ? OnColumnAdded : ColumnAdded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnAdded(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public virtual void ColumnAdded(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMarginChanged(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnMarginChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.ChangeEvent> OnColumnMarginChanged { get; set; } = null;

        void ColumnMarginChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>> data)
        {
            var methodToExecute = (OnColumnMarginChanged != null) ? OnColumnMarginChanged : ColumnMarginChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMarginChanged(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public virtual void ColumnMarginChanged(Javax.Swing.Event.ChangeEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.TableColumnModelEvent> OnColumnMoved { get; set; } = null;

        void ColumnMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableColumnModelEvent>> data)
        {
            var methodToExecute = (OnColumnMoved != null) ? OnColumnMoved : ColumnMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnMoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public virtual void ColumnMoved(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnRemoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.TableColumnModelEvent> OnColumnRemoved { get; set; } = null;

        void ColumnRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableColumnModelEvent>> data)
        {
            var methodToExecute = (OnColumnRemoved != null) ? OnColumnRemoved : ColumnRemoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnRemoved(javax.swing.event.TableColumnModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableColumnModelEvent"/></param>
        public virtual void ColumnRemoved(Javax.Swing.Event.TableColumnModelEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnSelectionChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnColumnSelectionChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.ListSelectionEvent> OnColumnSelectionChanged { get; set; } = null;

        void ColumnSelectionChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ListSelectionEvent>> data)
        {
            var methodToExecute = (OnColumnSelectionChanged != null) ? OnColumnSelectionChanged : ColumnSelectionChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableColumnModelListener.html#columnSelectionChanged(javax.swing.event.ListSelectionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ListSelectionEvent"/></param>
        public virtual void ColumnSelectionChanged(Javax.Swing.Event.ListSelectionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}