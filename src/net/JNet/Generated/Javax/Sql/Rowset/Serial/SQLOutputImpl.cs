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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset.Serial
{
    #region SQLOutputImpl
    public partial class SQLOutputImpl
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#%3Cinit%3E(java.util.Vector,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Vector"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public SQLOutputImpl(Java.Util.Vector<object> arg0, Java.Util.Map<string, object> arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeArray(java.sql.Array)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Array"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteArray(Java.Sql.Array arg0)
        {
            IExecute("writeArray", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeAsciiStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteAsciiStream(Java.Io.InputStream arg0)
        {
            IExecute("writeAsciiStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeBigDecimal(java.math.BigDecimal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigDecimal"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteBigDecimal(Java.Math.BigDecimal arg0)
        {
            IExecute("writeBigDecimal", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeBinaryStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteBinaryStream(Java.Io.InputStream arg0)
        {
            IExecute("writeBinaryStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeBlob(java.sql.Blob)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Blob"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteBlob(Java.Sql.Blob arg0)
        {
            IExecute("writeBlob", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeBoolean(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteBoolean(bool arg0)
        {
            IExecute("writeBoolean", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeByte(byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteByte(byte arg0)
        {
            IExecute("writeByte", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeBytes(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteBytes(byte[] arg0)
        {
            IExecute("writeBytes", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeCharacterStream(java.io.Reader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Reader"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteCharacterStream(Java.Io.Reader arg0)
        {
            IExecute("writeCharacterStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeClob(java.sql.Clob)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Clob"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteClob(Java.Sql.Clob arg0)
        {
            IExecute("writeClob", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeDate(java.sql.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Date"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteDate(Java.Sql.Date arg0)
        {
            IExecute("writeDate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteDouble(double arg0)
        {
            IExecute("writeDouble", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeFloat(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteFloat(float arg0)
        {
            IExecute("writeFloat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteInt(int arg0)
        {
            IExecute("writeInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteLong(long arg0)
        {
            IExecute("writeLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeNClob(java.sql.NClob)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.NClob"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteNClob(Java.Sql.NClob arg0)
        {
            IExecute("writeNClob", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeNString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteNString(string arg0)
        {
            IExecute("writeNString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeObject(java.sql.SQLData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.SQLData"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteObject(Java.Sql.SQLData arg0)
        {
            IExecute("writeObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeRef(java.sql.Ref)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Ref"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteRef(Java.Sql.Ref arg0)
        {
            IExecute("writeRef", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeRowId(java.sql.RowId)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.RowId"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteRowId(Java.Sql.RowId arg0)
        {
            IExecute("writeRowId", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeShort(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteShort(short arg0)
        {
            IExecute("writeShort", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeSQLXML(java.sql.SQLXML)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.SQLXML"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteSQLXML(Java.Sql.SQLXML arg0)
        {
            IExecute("writeSQLXML", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteString(string arg0)
        {
            IExecute("writeString", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeStruct(java.sql.Struct)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Struct"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteStruct(Java.Sql.Struct arg0)
        {
            IExecute("writeStruct", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeTime(java.sql.Time)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Time"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteTime(Java.Sql.Time arg0)
        {
            IExecute("writeTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeTimestamp(java.sql.Timestamp)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Timestamp"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteTimestamp(Java.Sql.Timestamp arg0)
        {
            IExecute("writeTimestamp", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SQLOutputImpl.html#writeURL(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void WriteURL(Java.Net.URL arg0)
        {
            IExecute("writeURL", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}