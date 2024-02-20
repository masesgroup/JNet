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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset.Serial
{
    #region SerialClob
    public partial class SerialClob
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#%3Cinit%3E(char[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="char"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public SerialClob(char[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#%3Cinit%3E(java.sql.Clob)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Clob"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public SerialClob(Java.Sql.Clob arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialClob"/> to <see cref="Java.Sql.Clob"/>
        /// </summary>
        public static implicit operator Java.Sql.Clob(Javax.Sql.Rowset.Serial.SerialClob t) => t.Cast<Java.Sql.Clob>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialClob"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Sql.Rowset.Serial.SerialClob t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.Serial.SerialClob"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Javax.Sql.Rowset.Serial.SerialClob t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#getAsciiStream()"/> 
        /// </summary>
        public Java.Io.InputStream AsciiStream
        {
            get { return IExecute<Java.Io.InputStream>("getAsciiStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#getCharacterStream()"/> 
        /// </summary>
        public Java.Io.Reader CharacterStream
        {
            get { return IExecute<Java.Io.Reader>("getCharacterStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#setString(long,java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public int SetString(long arg0, Java.Lang.String arg1, int arg2, int arg3)
        {
            return IExecute<int>("setString", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#setString(long,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public int SetString(long arg0, Java.Lang.String arg1)
        {
            return IExecute<int>("setString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#setAsciiStream(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Io.OutputStream"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.OutputStream SetAsciiStream(long arg0)
        {
            return IExecute<Java.Io.OutputStream>("setAsciiStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#getCharacterStream(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Io.Reader"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.Reader GetCharacterStream(long arg0, long arg1)
        {
            return IExecute<Java.Io.Reader>("getCharacterStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#setCharacterStream(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Io.Writer"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Io.Writer SetCharacterStream(long arg0)
        {
            return IExecute<Java.Io.Writer>("setCharacterStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#getSubString(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public Java.Lang.String GetSubString(long arg0, int arg1)
        {
            return IExecute<Java.Lang.String>("getSubString", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#length()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public long Length()
        {
            return IExecute<long>("length");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#position(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public long Position(Java.Lang.String arg0, long arg1)
        {
            return IExecute<long>("position", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#position(java.sql.Clob,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Clob"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        /// <exception cref="Java.Sql.SQLException"/>
        public long Position(Java.Sql.Clob arg0, long arg1)
        {
            return IExecute<long>("position", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#free()"/>
        /// </summary>

        /// <exception cref="Java.Sql.SQLException"/>
        public void Free()
        {
            IExecute("free");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialClob.html#truncate(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Javax.Sql.Rowset.Serial.SerialException"/>
        public void Truncate(long arg0)
        {
            IExecute("truncate", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}