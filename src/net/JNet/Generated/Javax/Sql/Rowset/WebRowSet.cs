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

namespace Javax.Sql.Rowset
{
    #region IWebRowSet
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IWebRowSet : Javax.Sql.Rowset.ICachedRowSet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#readXml(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        void ReadXml(Java.Io.InputStream arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#readXml(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void ReadXml(Java.Io.Reader arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        void WriteXml(Java.Io.OutputStream arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void WriteXml(Java.Io.Writer arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.sql.ResultSet,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        void WriteXml(Java.Sql.ResultSet arg0, Java.Io.OutputStream arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.sql.ResultSet,java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void WriteXml(Java.Sql.ResultSet arg0, Java.Io.Writer arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region WebRowSet
    public partial class WebRowSet : Javax.Sql.Rowset.IWebRowSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#PUBLIC_XML_SCHEMA"/>
        /// </summary>
        public static string PUBLIC_XML_SCHEMA { get { return SGetField<string>(LocalBridgeClazz, "PUBLIC_XML_SCHEMA"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#SCHEMA_SYSTEM_ID"/>
        /// </summary>
        public static string SCHEMA_SYSTEM_ID { get { return SGetField<string>(LocalBridgeClazz, "SCHEMA_SYSTEM_ID"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#readXml(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadXml(Java.Io.InputStream arg0)
        {
            IExecute("readXml", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#readXml(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void ReadXml(Java.Io.Reader arg0)
        {
            IExecute("readXml", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteXml(Java.Io.OutputStream arg0)
        {
            IExecute("writeXml", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteXml(Java.Io.Writer arg0)
        {
            IExecute("writeXml", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.sql.ResultSet,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteXml(Java.Sql.ResultSet arg0, Java.Io.OutputStream arg1)
        {
            IExecute("writeXml", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/WebRowSet.html#writeXml(java.sql.ResultSet,java.io.Writer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="Java.Io.Writer"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteXml(Java.Sql.ResultSet arg0, Java.Io.Writer arg1)
        {
            IExecute("writeXml", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}