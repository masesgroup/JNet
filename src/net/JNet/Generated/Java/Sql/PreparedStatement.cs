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

namespace Java.Sql
{
    #region PreparedStatement
    public partial class PreparedStatement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Sql.Statement(Java.Sql.PreparedStatement t) => t.Cast<Java.Sql.Statement>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#getMetaData() throws java.sql.SQLException 
        /// </summary>
        public Java.Sql.ResultSetMetaData MetaData
        {
            get { return IExecute<Java.Sql.ResultSetMetaData>("getMetaData"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#getParameterMetaData() throws java.sql.SQLException 
        /// </summary>
        public Java.Sql.ParameterMetaData ParameterMetaData
        {
            get { return IExecute<Java.Sql.ParameterMetaData>("getParameterMetaData"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#execute() throws java.sql.SQLException
        /// </summary>
        public bool Execute()
        {
            return IExecute<bool>("execute");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#executeUpdate() throws java.sql.SQLException
        /// </summary>
        public int ExecuteUpdate()
        {
            return IExecute<int>("executeUpdate");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#executeQuery() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.ResultSet ExecuteQuery()
        {
            return IExecute<Java.Sql.ResultSet>("executeQuery");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#addBatch() throws java.sql.SQLException
        /// </summary>
        public void AddBatch()
        {
            IExecute("addBatch");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#clearParameters() throws java.sql.SQLException
        /// </summary>
        public void ClearParameters()
        {
            IExecute("clearParameters");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setArray(int,java.sql.Array) throws java.sql.SQLException
        /// </summary>
        public void SetArray(int arg0, Java.Sql.Array arg1)
        {
            IExecute("setArray", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setAsciiStream(int,java.io.InputStream,int) throws java.sql.SQLException
        /// </summary>
        public void SetAsciiStream(int arg0, Java.Io.InputStream arg1, int arg2)
        {
            IExecute("setAsciiStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setAsciiStream(int,java.io.InputStream,long) throws java.sql.SQLException
        /// </summary>
        public void SetAsciiStream(int arg0, Java.Io.InputStream arg1, long arg2)
        {
            IExecute("setAsciiStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setAsciiStream(int,java.io.InputStream) throws java.sql.SQLException
        /// </summary>
        public void SetAsciiStream(int arg0, Java.Io.InputStream arg1)
        {
            IExecute("setAsciiStream", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBigDecimal(int,java.math.BigDecimal) throws java.sql.SQLException
        /// </summary>
        public void SetBigDecimal(int arg0, Java.Math.BigDecimal arg1)
        {
            IExecute("setBigDecimal", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBinaryStream(int,java.io.InputStream,int) throws java.sql.SQLException
        /// </summary>
        public void SetBinaryStream(int arg0, Java.Io.InputStream arg1, int arg2)
        {
            IExecute("setBinaryStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBinaryStream(int,java.io.InputStream,long) throws java.sql.SQLException
        /// </summary>
        public void SetBinaryStream(int arg0, Java.Io.InputStream arg1, long arg2)
        {
            IExecute("setBinaryStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBinaryStream(int,java.io.InputStream) throws java.sql.SQLException
        /// </summary>
        public void SetBinaryStream(int arg0, Java.Io.InputStream arg1)
        {
            IExecute("setBinaryStream", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBlob(int,java.io.InputStream,long) throws java.sql.SQLException
        /// </summary>
        public void SetBlob(int arg0, Java.Io.InputStream arg1, long arg2)
        {
            IExecute("setBlob", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBlob(int,java.io.InputStream) throws java.sql.SQLException
        /// </summary>
        public void SetBlob(int arg0, Java.Io.InputStream arg1)
        {
            IExecute("setBlob", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBlob(int,java.sql.Blob) throws java.sql.SQLException
        /// </summary>
        public void SetBlob(int arg0, Java.Sql.Blob arg1)
        {
            IExecute("setBlob", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBoolean(int,boolean) throws java.sql.SQLException
        /// </summary>
        public void SetBoolean(int arg0, bool arg1)
        {
            IExecute("setBoolean", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setByte(int,byte) throws java.sql.SQLException
        /// </summary>
        public void SetByte(int arg0, byte arg1)
        {
            IExecute("setByte", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setBytes(int,byte[]) throws java.sql.SQLException
        /// </summary>
        public void SetBytes(int arg0, byte[] arg1)
        {
            IExecute("setBytes", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setCharacterStream(int,java.io.Reader,int) throws java.sql.SQLException
        /// </summary>
        public void SetCharacterStream(int arg0, Java.Io.Reader arg1, int arg2)
        {
            IExecute("setCharacterStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setCharacterStream(int,java.io.Reader,long) throws java.sql.SQLException
        /// </summary>
        public void SetCharacterStream(int arg0, Java.Io.Reader arg1, long arg2)
        {
            IExecute("setCharacterStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setCharacterStream(int,java.io.Reader) throws java.sql.SQLException
        /// </summary>
        public void SetCharacterStream(int arg0, Java.Io.Reader arg1)
        {
            IExecute("setCharacterStream", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setClob(int,java.io.Reader,long) throws java.sql.SQLException
        /// </summary>
        public void SetClob(int arg0, Java.Io.Reader arg1, long arg2)
        {
            IExecute("setClob", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setClob(int,java.io.Reader) throws java.sql.SQLException
        /// </summary>
        public void SetClob(int arg0, Java.Io.Reader arg1)
        {
            IExecute("setClob", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setClob(int,java.sql.Clob) throws java.sql.SQLException
        /// </summary>
        public void SetClob(int arg0, Java.Sql.Clob arg1)
        {
            IExecute("setClob", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setDate(int,java.sql.Date,java.util.Calendar) throws java.sql.SQLException
        /// </summary>
        public void SetDate(int arg0, Java.Sql.Date arg1, Java.Util.Calendar arg2)
        {
            IExecute("setDate", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setDate(int,java.sql.Date) throws java.sql.SQLException
        /// </summary>
        public void SetDate(int arg0, Java.Sql.Date arg1)
        {
            IExecute("setDate", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setDouble(int,double) throws java.sql.SQLException
        /// </summary>
        public void SetDouble(int arg0, double arg1)
        {
            IExecute("setDouble", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setFloat(int,float) throws java.sql.SQLException
        /// </summary>
        public void SetFloat(int arg0, float arg1)
        {
            IExecute("setFloat", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setInt(int,int) throws java.sql.SQLException
        /// </summary>
        public void SetInt(int arg0, int arg1)
        {
            IExecute("setInt", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setLong(int,long) throws java.sql.SQLException
        /// </summary>
        public void SetLong(int arg0, long arg1)
        {
            IExecute("setLong", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setNCharacterStream(int,java.io.Reader,long) throws java.sql.SQLException
        /// </summary>
        public void SetNCharacterStream(int arg0, Java.Io.Reader arg1, long arg2)
        {
            IExecute("setNCharacterStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setNCharacterStream(int,java.io.Reader) throws java.sql.SQLException
        /// </summary>
        public void SetNCharacterStream(int arg0, Java.Io.Reader arg1)
        {
            IExecute("setNCharacterStream", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setNClob(int,java.io.Reader,long) throws java.sql.SQLException
        /// </summary>
        public void SetNClob(int arg0, Java.Io.Reader arg1, long arg2)
        {
            IExecute("setNClob", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setNClob(int,java.io.Reader) throws java.sql.SQLException
        /// </summary>
        public void SetNClob(int arg0, Java.Io.Reader arg1)
        {
            IExecute("setNClob", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setNClob(int,java.sql.NClob) throws java.sql.SQLException
        /// </summary>
        public void SetNClob(int arg0, Java.Sql.NClob arg1)
        {
            IExecute("setNClob", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setNString(int,java.lang.String) throws java.sql.SQLException
        /// </summary>
        public void SetNString(int arg0, string arg1)
        {
            IExecute("setNString", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setNull(int,int,java.lang.String) throws java.sql.SQLException
        /// </summary>
        public void SetNull(int arg0, int arg1, string arg2)
        {
            IExecute("setNull", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setNull(int,int) throws java.sql.SQLException
        /// </summary>
        public void SetNull(int arg0, int arg1)
        {
            IExecute("setNull", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setObject(int,java.lang.Object,int,int) throws java.sql.SQLException
        /// </summary>
        public void SetObject(int arg0, object arg1, int arg2, int arg3)
        {
            IExecute("setObject", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setObject(int,java.lang.Object,int) throws java.sql.SQLException
        /// </summary>
        public void SetObject(int arg0, object arg1, int arg2)
        {
            IExecute("setObject", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setObject(int,java.lang.Object) throws java.sql.SQLException
        /// </summary>
        public void SetObject(int arg0, object arg1)
        {
            IExecute("setObject", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setRef(int,java.sql.Ref) throws java.sql.SQLException
        /// </summary>
        public void SetRef(int arg0, Java.Sql.Ref arg1)
        {
            IExecute("setRef", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setRowId(int,java.sql.RowId) throws java.sql.SQLException
        /// </summary>
        public void SetRowId(int arg0, Java.Sql.RowId arg1)
        {
            IExecute("setRowId", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setShort(int,short) throws java.sql.SQLException
        /// </summary>
        public void SetShort(int arg0, short arg1)
        {
            IExecute("setShort", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setSQLXML(int,java.sql.SQLXML) throws java.sql.SQLException
        /// </summary>
        public void SetSQLXML(int arg0, Java.Sql.SQLXML arg1)
        {
            IExecute("setSQLXML", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setString(int,java.lang.String) throws java.sql.SQLException
        /// </summary>
        public void SetString(int arg0, string arg1)
        {
            IExecute("setString", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setTime(int,java.sql.Time,java.util.Calendar) throws java.sql.SQLException
        /// </summary>
        public void SetTime(int arg0, Java.Sql.Time arg1, Java.Util.Calendar arg2)
        {
            IExecute("setTime", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setTime(int,java.sql.Time) throws java.sql.SQLException
        /// </summary>
        public void SetTime(int arg0, Java.Sql.Time arg1)
        {
            IExecute("setTime", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setTimestamp(int,java.sql.Timestamp,java.util.Calendar) throws java.sql.SQLException
        /// </summary>
        public void SetTimestamp(int arg0, Java.Sql.Timestamp arg1, Java.Util.Calendar arg2)
        {
            IExecute("setTimestamp", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setTimestamp(int,java.sql.Timestamp) throws java.sql.SQLException
        /// </summary>
        public void SetTimestamp(int arg0, Java.Sql.Timestamp arg1)
        {
            IExecute("setTimestamp", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setURL(int,java.net.URL) throws java.sql.SQLException
        /// </summary>
        public void SetURL(int arg0, Java.Net.URL arg1)
        {
            IExecute("setURL", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#executeLargeUpdate() throws java.sql.SQLException
        /// </summary>
        public long ExecuteLargeUpdate()
        {
            return IExecute<long>("executeLargeUpdate");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setObject(int,java.lang.Object,java.sql.SQLType,int) throws java.sql.SQLException
        /// </summary>
        public void SetObject(int arg0, object arg1, Java.Sql.SQLType arg2, int arg3)
        {
            IExecute("setObject", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PreparedStatement.html#setObject(int,java.lang.Object,java.sql.SQLType) throws java.sql.SQLException
        /// </summary>
        public void SetObject(int arg0, object arg1, Java.Sql.SQLType arg2)
        {
            IExecute("setObject", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}