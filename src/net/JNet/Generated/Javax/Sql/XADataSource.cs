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

namespace Javax.Sql
{
    #region IXADataSource
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IXADataSource : Javax.Sql.ICommonDataSource
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        int LoginTimeout { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        Java.Io.PrintWriter LogWriter { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#getXAConnection()"/> 
        /// </summary>
        Javax.Sql.XAConnection XAConnection { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#getXAConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Sql.XAConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.XAConnection GetXAConnection(string arg0, string arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#createXAConnectionBuilder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        Javax.Sql.XAConnectionBuilder CreateXAConnectionBuilder();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region XADataSource
    public partial class XADataSource : Javax.Sql.IXADataSource
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#setLoginTimeout(int)"/>
        /// </summary>
        public int LoginTimeout
        {
            get { return IExecute<int>("getLoginTimeout"); } set { IExecute("setLoginTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        public Java.Io.PrintWriter LogWriter
        {
            get { return IExecute<Java.Io.PrintWriter>("getLogWriter"); } set { IExecute("setLogWriter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#getXAConnection()"/> 
        /// </summary>
        public Javax.Sql.XAConnection XAConnection
        {
            get { return IExecute<Javax.Sql.XAConnection>("getXAConnection"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#getXAConnection(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Sql.XAConnection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.XAConnection GetXAConnection(string arg0, string arg1)
        {
            return IExecute<Javax.Sql.XAConnection>("getXAConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/javax/sql/XADataSource.html#createXAConnectionBuilder()"/>
        /// </summary>

        /// <returns><see cref="Javax.Sql.XAConnectionBuilder"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.XAConnectionBuilder CreateXAConnectionBuilder()
        {
            return IExecute<Javax.Sql.XAConnectionBuilder>("createXAConnectionBuilder");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}