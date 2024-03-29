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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region IStatementEventListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.sql.StatementEventListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEventListener.html"/>
    /// </summary>
    public partial interface IStatementEventListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEventListener.html#statementClosed(javax.sql.StatementEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.StatementEvent"/></param>
        void StatementClosed(Javax.Sql.StatementEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEventListener.html#statementErrorOccurred(javax.sql.StatementEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.StatementEvent"/></param>
        void StatementErrorOccurred(Javax.Sql.StatementEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StatementEventListener
    public partial class StatementEventListener : Javax.Sql.IStatementEventListener
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
        /// Handlers initializer for <see cref="StatementEventListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("statementClosed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.StatementEvent>>>(StatementClosedEventHandler));
            AddEventHandler("statementErrorOccurred", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Sql.StatementEvent>>>(StatementErrorOccurredEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEventListener.html#statementClosed(javax.sql.StatementEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnStatementClosed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sql.StatementEvent> OnStatementClosed { get; set; } = null;

        void StatementClosedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.StatementEvent>> data)
        {
            var methodToExecute = (OnStatementClosed != null) ? OnStatementClosed : StatementClosed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEventListener.html#statementClosed(javax.sql.StatementEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.StatementEvent"/></param>
        public virtual void StatementClosed(Javax.Sql.StatementEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEventListener.html#statementErrorOccurred(javax.sql.StatementEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnStatementErrorOccurred"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Sql.StatementEvent> OnStatementErrorOccurred { get; set; } = null;

        void StatementErrorOccurredEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Sql.StatementEvent>> data)
        {
            var methodToExecute = (OnStatementErrorOccurred != null) ? OnStatementErrorOccurred : StatementErrorOccurred;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEventListener.html#statementErrorOccurred(javax.sql.StatementEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.StatementEvent"/></param>
        public virtual void StatementErrorOccurred(Javax.Sql.StatementEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}