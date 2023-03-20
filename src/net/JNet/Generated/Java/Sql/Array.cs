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
    #region Array
    public partial class Array
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getBaseType()"/> 
        /// </summary>
        public int BaseType
        {
            get { return IExecute<int>("getBaseType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getBaseTypeName()"/> 
        /// </summary>
        public string BaseTypeName
        {
            get { return IExecute<string>("getBaseTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getResultSet()"/> 
        /// </summary>
        public Java.Sql.ResultSet ResultSet
        {
            get { return IExecute<Java.Sql.ResultSet>("getResultSet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getArray()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object GetArray()
        {
            return IExecute("getArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getArray(java.util.Map%3Cjava.lang.String, java.lang.Class%3C?%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object GetArray(Java.Util.Map arg0)
        {
            return IExecute("getArray", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getArray(long,int,java.util.Map%3Cjava.lang.String, java.lang.Class%3C?%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object GetArray(long arg0, int arg1, Java.Util.Map arg2)
        {
            return IExecute("getArray", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getArray(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object GetArray(long arg0, int arg1)
        {
            return IExecute("getArray", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getResultSet(java.util.Map%3Cjava.lang.String, java.lang.Class%3C?%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet GetResultSet(Java.Util.Map arg0)
        {
            return IExecute<Java.Sql.ResultSet>("getResultSet", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getResultSet(long,int,java.util.Map%3Cjava.lang.String, java.lang.Class%3C?%3E%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet GetResultSet(long arg0, int arg1, Java.Util.Map arg2)
        {
            return IExecute<Java.Sql.ResultSet>("getResultSet", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#getResultSet(long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet GetResultSet(long arg0, int arg1)
        {
            return IExecute<Java.Sql.ResultSet>("getResultSet", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Array.html#free()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void Free()
        {
            IExecute("free");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}