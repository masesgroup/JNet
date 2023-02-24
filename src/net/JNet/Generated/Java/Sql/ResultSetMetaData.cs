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
    #region ResultSetMetaData
    public partial class ResultSetMetaData
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Sql.ResultSetMetaData"/> to <see cref="Java.Sql.Wrapper"/>
        /// </summary>
        public static implicit operator Java.Sql.Wrapper(Java.Sql.ResultSetMetaData t) => t.Cast<Java.Sql.Wrapper>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#columnNoNulls"/>
        /// </summary>
        public static int columnNoNulls => Clazz.GetField<int>("columnNoNulls");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#columnNullable"/>
        /// </summary>
        public static int columnNullable => Clazz.GetField<int>("columnNullable");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#columnNullableUnknown"/>
        /// </summary>
        public static int columnNullableUnknown => Clazz.GetField<int>("columnNullableUnknown");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnCount()"/> 
        /// </summary>
        public int ColumnCount
        {
            get { return IExecute<int>("getColumnCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isAutoIncrement(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsAutoIncrement(int arg0)
        {
            return IExecute<bool>("isAutoIncrement", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isCaseSensitive(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsCaseSensitive(int arg0)
        {
            return IExecute<bool>("isCaseSensitive", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isCurrency(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsCurrency(int arg0)
        {
            return IExecute<bool>("isCurrency", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isDefinitelyWritable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsDefinitelyWritable(int arg0)
        {
            return IExecute<bool>("isDefinitelyWritable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isReadOnly(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsReadOnly(int arg0)
        {
            return IExecute<bool>("isReadOnly", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isSearchable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSearchable(int arg0)
        {
            return IExecute<bool>("isSearchable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isSigned(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSigned(int arg0)
        {
            return IExecute<bool>("isSigned", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isWritable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsWritable(int arg0)
        {
            return IExecute<bool>("isWritable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnDisplaySize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetColumnDisplaySize(int arg0)
        {
            return IExecute<int>("getColumnDisplaySize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetColumnType(int arg0)
        {
            return IExecute<int>("getColumnType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getPrecision(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetPrecision(int arg0)
        {
            return IExecute<int>("getPrecision", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getScale(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int GetScale(int arg0)
        {
            return IExecute<int>("getScale", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#isNullable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int IsNullable(int arg0)
        {
            return IExecute<int>("isNullable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getCatalogName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string GetCatalogName(int arg0)
        {
            return IExecute<string>("getCatalogName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnClassName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string GetColumnClassName(int arg0)
        {
            return IExecute<string>("getColumnClassName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnLabel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string GetColumnLabel(int arg0)
        {
            return IExecute<string>("getColumnLabel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string GetColumnName(int arg0)
        {
            return IExecute<string>("getColumnName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getColumnTypeName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string GetColumnTypeName(int arg0)
        {
            return IExecute<string>("getColumnTypeName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getSchemaName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string GetSchemaName(int arg0)
        {
            return IExecute<string>("getSchemaName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ResultSetMetaData.html#getTableName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string GetTableName(int arg0)
        {
            return IExecute<string>("getTableName", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}