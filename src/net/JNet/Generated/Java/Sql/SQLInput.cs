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
    #region SQLInput
    public partial class SQLInput
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBoolean() throws java.sql.SQLException
        /// </summary>
        public bool ReadBoolean()
        {
            return IExecute<bool>("readBoolean");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#wasNull() throws java.sql.SQLException
        /// </summary>
        public bool WasNull()
        {
            return IExecute<bool>("wasNull");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readByte() throws java.sql.SQLException
        /// </summary>
        public byte ReadByte()
        {
            return IExecute<byte>("readByte");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBytes() throws java.sql.SQLException
        /// </summary>
        public byte[] ReadBytes()
        {
            return IExecuteArray<byte>("readBytes");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readDouble() throws java.sql.SQLException
        /// </summary>
        public double ReadDouble()
        {
            return IExecute<double>("readDouble");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readFloat() throws java.sql.SQLException
        /// </summary>
        public float ReadFloat()
        {
            return IExecute<float>("readFloat");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readInt() throws java.sql.SQLException
        /// </summary>
        public int ReadInt()
        {
            return IExecute<int>("readInt");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readAsciiStream() throws java.sql.SQLException
        /// </summary>
        public Java.Io.InputStream ReadAsciiStream()
        {
            return IExecute<Java.Io.InputStream>("readAsciiStream");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBinaryStream() throws java.sql.SQLException
        /// </summary>
        public Java.Io.InputStream ReadBinaryStream()
        {
            return IExecute<Java.Io.InputStream>("readBinaryStream");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readCharacterStream() throws java.sql.SQLException
        /// </summary>
        public Java.Io.Reader ReadCharacterStream()
        {
            return IExecute<Java.Io.Reader>("readCharacterStream");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readObject() throws java.sql.SQLException
        /// </summary>
        public object ReadObject()
        {
            return IExecute("readObject");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readNString() throws java.sql.SQLException
        /// </summary>
        public string ReadNString()
        {
            return IExecute<string>("readNString");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readString() throws java.sql.SQLException
        /// </summary>
        public string ReadString()
        {
            return IExecute<string>("readString");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBigDecimal() throws java.sql.SQLException
        /// </summary>
        public Java.Math.BigDecimal ReadBigDecimal()
        {
            return IExecute<Java.Math.BigDecimal>("readBigDecimal");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readURL() throws java.sql.SQLException
        /// </summary>
        public Java.Net.URL ReadURL()
        {
            return IExecute<Java.Net.URL>("readURL");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readArray() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.Array ReadArray()
        {
            return IExecute<Java.Sql.Array>("readArray");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBlob() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.Blob ReadBlob()
        {
            return IExecute<Java.Sql.Blob>("readBlob");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readClob() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.Clob ReadClob()
        {
            return IExecute<Java.Sql.Clob>("readClob");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readDate() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.Date ReadDate()
        {
            return IExecute<Java.Sql.Date>("readDate");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readNClob() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.NClob ReadNClob()
        {
            return IExecute<Java.Sql.NClob>("readNClob");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readRef() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.Ref ReadRef()
        {
            return IExecute<Java.Sql.Ref>("readRef");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readRowId() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.RowId ReadRowId()
        {
            return IExecute<Java.Sql.RowId>("readRowId");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readSQLXML() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.SQLXML ReadSQLXML()
        {
            return IExecute<Java.Sql.SQLXML>("readSQLXML");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readTime() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.Time ReadTime()
        {
            return IExecute<Java.Sql.Time>("readTime");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readTimestamp() throws java.sql.SQLException
        /// </summary>
        public Java.Sql.Timestamp ReadTimestamp()
        {
            return IExecute<Java.Sql.Timestamp>("readTimestamp");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readLong() throws java.sql.SQLException
        /// </summary>
        public long ReadLong()
        {
            return IExecute<long>("readLong");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readShort() throws java.sql.SQLException
        /// </summary>
        public short ReadShort()
        {
            return IExecute<short>("readShort");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}