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

namespace Javax.Sql
{
    #region IRowSetListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.sql.RowSetListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html"/>
    /// </summary>
    public partial interface IRowSetListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#cursorMoved(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        void CursorMoved(Javax.Sql.RowSetEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        void RowChanged(Javax.Sql.RowSetEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowSetChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        void RowSetChanged(Javax.Sql.RowSetEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RowSetListener
    public partial class RowSetListener : Javax.Sql.IRowSetListener
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
        /// Handlers initializer for <see cref="RowSetListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("cursorMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>>>(CursorMovedEventHandler));
            AddEventHandler("rowChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>>>(RowChangedEventHandler));
            AddEventHandler("rowSetChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>>>(RowSetChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#cursorMoved(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnCursorMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sql.RowSetEvent> OnCursorMoved { get; set; } = null;

        void CursorMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>> data)
        {
            var methodToExecute = (OnCursorMoved != null) ? OnCursorMoved : CursorMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#cursorMoved(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public virtual void CursorMoved(Javax.Sql.RowSetEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRowChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sql.RowSetEvent> OnRowChanged { get; set; } = null;

        void RowChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>> data)
        {
            var methodToExecute = (OnRowChanged != null) ? OnRowChanged : RowChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public virtual void RowChanged(Javax.Sql.RowSetEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowSetChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnRowSetChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sql.RowSetEvent> OnRowSetChanged { get; set; } = null;

        void RowSetChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.RowSetEvent>> data)
        {
            var methodToExecute = (OnRowSetChanged != null) ? OnRowSetChanged : RowSetChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/RowSetListener.html#rowSetChanged(javax.sql.RowSetEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        public virtual void RowSetChanged(Javax.Sql.RowSetEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}