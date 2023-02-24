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

namespace Javax.Sql
{
    #region StatementEvent
    public partial class StatementEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html#%3Cinit%3E(javax.sql.PooledConnection,java.sql.PreparedStatement,java.sql.SQLException)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.PooledConnection"/></param>
        /// <param name="arg1"><see cref="Java.Sql.PreparedStatement"/></param>
        /// <param name="arg2"><see cref="Java.Sql.SQLException"/></param>
        public StatementEvent(Javax.Sql.PooledConnection arg0, Java.Sql.PreparedStatement arg1, Java.Sql.SQLException arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html#%3Cinit%3E(javax.sql.PooledConnection,java.sql.PreparedStatement)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.PooledConnection"/></param>
        /// <param name="arg1"><see cref="Java.Sql.PreparedStatement"/></param>
        public StatementEvent(Javax.Sql.PooledConnection arg0, Java.Sql.PreparedStatement arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html#getSQLException()"/> 
        /// </summary>
        public Java.Sql.SQLException SQLException
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getSQLException"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Sql.SQLException>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/StatementEvent.html#getStatement()"/> 
        /// </summary>
        public Java.Sql.PreparedStatement Statement
        {
            get { return IExecute<Java.Sql.PreparedStatement>("getStatement"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}