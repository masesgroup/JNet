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

namespace Javax.Sql.Rowset.Serial
{
    #region SerialRef
    public partial class SerialRef
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialRef.html#<init>(java.sql.Ref) throws javax.sql.rowset.serial.SerialException,java.sql.SQLException
        /// </summary>
        public SerialRef(Java.Sql.Ref arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Sql.Ref(Javax.Sql.Rowset.Serial.SerialRef t) => t.Cast<Java.Sql.Ref>();
        public static implicit operator Java.Io.Serializable(Javax.Sql.Rowset.Serial.SerialRef t) => t.Cast<Java.Io.Serializable>();
        public static implicit operator Java.Lang.Cloneable(Javax.Sql.Rowset.Serial.SerialRef t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialRef.html#getBaseTypeName() throws javax.sql.rowset.serial.SerialException 
        /// </summary>
        public string BaseTypeName
        {
            get { return IExecute<string>("getBaseTypeName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialRef.html#getObject() throws javax.sql.rowset.serial.SerialException https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/serial/SerialRef.html#setObject(java.lang.Object) throws javax.sql.rowset.serial.SerialException
        /// </summary>
        public object Object
        {
            get { return IExecute("getObject"); } set { IExecute("setObject", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}