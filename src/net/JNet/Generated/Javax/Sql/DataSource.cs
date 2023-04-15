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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql
{
    #region DataSource
    public partial class DataSource
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.DataSource"/> to <see cref="Javax.Sql.CommonDataSource"/>
        /// </summary>
        public static implicit operator Javax.Sql.CommonDataSource(Javax.Sql.DataSource t) => t.Cast<Javax.Sql.CommonDataSource>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.DataSource"/> to <see cref="Java.Sql.Wrapper"/>
        /// </summary>
        public static implicit operator Java.Sql.Wrapper(Javax.Sql.DataSource t) => t.Cast<Java.Sql.Wrapper>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/DataSource.html#getConnection()"/> 
        /// </summary>
        public Java.Sql.Connection Connection
        {
            get { return IExecute<Java.Sql.Connection>("getConnection"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/DataSource.html#createConnectionBuilder()"/> 
        /// </summary>
        public Java.Sql.ConnectionBuilder CreateConnectionBuilder
        {
            get { return IExecute<Java.Sql.ConnectionBuilder>("createConnectionBuilder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/DataSource.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/DataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        public int LoginTimeout
        {
            get { return IExecute<int>("getLoginTimeout"); } set { IExecute("setLoginTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/DataSource.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/DataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        public Java.Io.PrintWriter LogWriter
        {
            get { return IExecute<Java.Io.PrintWriter>("getLogWriter"); } set { IExecute("setLogWriter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/DataSource.html#getConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Connection GetConnection(string arg0, string arg1)
        {
            return IExecute<Java.Sql.Connection>("getConnection", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}