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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBoolean()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool ReadBoolean()
        {
            return IExecute<bool>("readBoolean");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#wasNull()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool WasNull()
        {
            return IExecute<bool>("wasNull");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readByte()"/>
        /// </summary>
        
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public byte ReadByte()
        {
            return IExecute<byte>("readByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBytes()"/>
        /// </summary>
        
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public byte[] ReadBytes()
        {
            return IExecuteArray<byte>("readBytes");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readDouble()"/>
        /// </summary>
        
        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public double ReadDouble()
        {
            return IExecute<double>("readDouble");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readFloat()"/>
        /// </summary>
        
        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public float ReadFloat()
        {
            return IExecute<float>("readFloat");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readInt()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ReadInt()
        {
            return IExecute<int>("readInt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readAsciiStream()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.InputStream ReadAsciiStream()
        {
            return IExecute<Java.Io.InputStream>("readAsciiStream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBinaryStream()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.InputStream ReadBinaryStream()
        {
            return IExecute<Java.Io.InputStream>("readBinaryStream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readCharacterStream()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.Reader ReadCharacterStream()
        {
            return IExecute<Java.Io.Reader>("readCharacterStream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readObject()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object ReadObject()
        {
            return IExecute("readObject");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readNString()"/>
        /// </summary>
        
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string ReadNString()
        {
            return IExecute<string>("readNString");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readString()"/>
        /// </summary>
        
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string ReadString()
        {
            return IExecute<string>("readString");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBigDecimal()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Math.BigDecimal"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Math.BigDecimal ReadBigDecimal()
        {
            return IExecute<Java.Math.BigDecimal>("readBigDecimal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readURL()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Net.URL"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Net.URL ReadURL()
        {
            return IExecute<Java.Net.URL>("readURL");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readArray()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Array"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Array ReadArray()
        {
            return IExecute<Java.Sql.Array>("readArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readBlob()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Blob"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Blob ReadBlob()
        {
            return IExecute<Java.Sql.Blob>("readBlob");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readClob()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Clob"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Clob ReadClob()
        {
            return IExecute<Java.Sql.Clob>("readClob");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readDate()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Date"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Date ReadDate()
        {
            return IExecute<Java.Sql.Date>("readDate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readNClob()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.NClob"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.NClob ReadNClob()
        {
            return IExecute<Java.Sql.NClob>("readNClob");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readRef()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Ref"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Ref ReadRef()
        {
            return IExecute<Java.Sql.Ref>("readRef");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readRowId()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.RowId"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.RowId ReadRowId()
        {
            return IExecute<Java.Sql.RowId>("readRowId");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readSQLXML()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.SQLXML"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.SQLXML ReadSQLXML()
        {
            return IExecute<Java.Sql.SQLXML>("readSQLXML");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readTime()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Time"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Time ReadTime()
        {
            return IExecute<Java.Sql.Time>("readTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readTimestamp()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Sql.Timestamp"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.Timestamp ReadTimestamp()
        {
            return IExecute<Java.Sql.Timestamp>("readTimestamp");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readLong()"/>
        /// </summary>
        
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ReadLong()
        {
            return IExecute<long>("readLong");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readShort()"/>
        /// </summary>
        
        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public short ReadShort()
        {
            return IExecute<short>("readShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/SQLInput.html#readObject(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object ReadObject(Java.Lang.Class arg0)
        {
            return IExecute("readObject", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}