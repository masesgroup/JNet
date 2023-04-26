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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region JDBCType
    public partial class JDBCType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Sql.JDBCType"/> to <see cref="Java.Sql.SQLType"/>
        /// </summary>
        public static implicit operator Java.Sql.SQLType(Java.Sql.JDBCType t) => t.Cast<Java.Sql.SQLType>();
        
        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#ARRAY"/>
        /// </summary>
        public static Java.Sql.JDBCType ARRAY => LocalClazz.GetField<Java.Sql.JDBCType>("ARRAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BIGINT"/>
        /// </summary>
        public static Java.Sql.JDBCType BIGINT => LocalClazz.GetField<Java.Sql.JDBCType>("BIGINT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType BINARY => LocalClazz.GetField<Java.Sql.JDBCType>("BINARY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BIT"/>
        /// </summary>
        public static Java.Sql.JDBCType BIT => LocalClazz.GetField<Java.Sql.JDBCType>("BIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType BLOB => LocalClazz.GetField<Java.Sql.JDBCType>("BLOB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BOOLEAN"/>
        /// </summary>
        public static Java.Sql.JDBCType BOOLEAN => LocalClazz.GetField<Java.Sql.JDBCType>("BOOLEAN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#CHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType CHAR => LocalClazz.GetField<Java.Sql.JDBCType>("CHAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#CLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType CLOB => LocalClazz.GetField<Java.Sql.JDBCType>("CLOB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DATALINK"/>
        /// </summary>
        public static Java.Sql.JDBCType DATALINK => LocalClazz.GetField<Java.Sql.JDBCType>("DATALINK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DATE"/>
        /// </summary>
        public static Java.Sql.JDBCType DATE => LocalClazz.GetField<Java.Sql.JDBCType>("DATE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DECIMAL"/>
        /// </summary>
        public static Java.Sql.JDBCType DECIMAL => LocalClazz.GetField<Java.Sql.JDBCType>("DECIMAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DISTINCT"/>
        /// </summary>
        public static Java.Sql.JDBCType DISTINCT => LocalClazz.GetField<Java.Sql.JDBCType>("DISTINCT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DOUBLE"/>
        /// </summary>
        public static Java.Sql.JDBCType DOUBLE => LocalClazz.GetField<Java.Sql.JDBCType>("DOUBLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#FLOAT"/>
        /// </summary>
        public static Java.Sql.JDBCType FLOAT => LocalClazz.GetField<Java.Sql.JDBCType>("FLOAT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#INTEGER"/>
        /// </summary>
        public static Java.Sql.JDBCType INTEGER => LocalClazz.GetField<Java.Sql.JDBCType>("INTEGER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#JAVA_OBJECT"/>
        /// </summary>
        public static Java.Sql.JDBCType JAVA_OBJECT => LocalClazz.GetField<Java.Sql.JDBCType>("JAVA_OBJECT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGNVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGNVARCHAR => LocalClazz.GetField<Java.Sql.JDBCType>("LONGNVARCHAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGVARBINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGVARBINARY => LocalClazz.GetField<Java.Sql.JDBCType>("LONGVARBINARY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType LONGVARCHAR => LocalClazz.GetField<Java.Sql.JDBCType>("LONGVARCHAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType NCHAR => LocalClazz.GetField<Java.Sql.JDBCType>("NCHAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NCLOB"/>
        /// </summary>
        public static Java.Sql.JDBCType NCLOB => LocalClazz.GetField<Java.Sql.JDBCType>("NCLOB");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NULL"/>
        /// </summary>
        public static Java.Sql.JDBCType NULL => LocalClazz.GetField<Java.Sql.JDBCType>("NULL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NUMERIC"/>
        /// </summary>
        public static Java.Sql.JDBCType NUMERIC => LocalClazz.GetField<Java.Sql.JDBCType>("NUMERIC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NVARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType NVARCHAR => LocalClazz.GetField<Java.Sql.JDBCType>("NVARCHAR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#OTHER"/>
        /// </summary>
        public static Java.Sql.JDBCType OTHER => LocalClazz.GetField<Java.Sql.JDBCType>("OTHER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REAL"/>
        /// </summary>
        public static Java.Sql.JDBCType REAL => LocalClazz.GetField<Java.Sql.JDBCType>("REAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REF"/>
        /// </summary>
        public static Java.Sql.JDBCType REF => LocalClazz.GetField<Java.Sql.JDBCType>("REF");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REF_CURSOR"/>
        /// </summary>
        public static Java.Sql.JDBCType REF_CURSOR => LocalClazz.GetField<Java.Sql.JDBCType>("REF_CURSOR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#ROWID"/>
        /// </summary>
        public static Java.Sql.JDBCType ROWID => LocalClazz.GetField<Java.Sql.JDBCType>("ROWID");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#SMALLINT"/>
        /// </summary>
        public static Java.Sql.JDBCType SMALLINT => LocalClazz.GetField<Java.Sql.JDBCType>("SMALLINT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#SQLXML"/>
        /// </summary>
        public static Java.Sql.JDBCType SQLXML => LocalClazz.GetField<Java.Sql.JDBCType>("SQLXML");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#STRUCT"/>
        /// </summary>
        public static Java.Sql.JDBCType STRUCT => LocalClazz.GetField<Java.Sql.JDBCType>("STRUCT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIME"/>
        /// </summary>
        public static Java.Sql.JDBCType TIME => LocalClazz.GetField<Java.Sql.JDBCType>("TIME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIME_WITH_TIMEZONE"/>
        /// </summary>
        public static Java.Sql.JDBCType TIME_WITH_TIMEZONE => LocalClazz.GetField<Java.Sql.JDBCType>("TIME_WITH_TIMEZONE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIMESTAMP"/>
        /// </summary>
        public static Java.Sql.JDBCType TIMESTAMP => LocalClazz.GetField<Java.Sql.JDBCType>("TIMESTAMP");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIMESTAMP_WITH_TIMEZONE"/>
        /// </summary>
        public static Java.Sql.JDBCType TIMESTAMP_WITH_TIMEZONE => LocalClazz.GetField<Java.Sql.JDBCType>("TIMESTAMP_WITH_TIMEZONE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TINYINT"/>
        /// </summary>
        public static Java.Sql.JDBCType TINYINT => LocalClazz.GetField<Java.Sql.JDBCType>("TINYINT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#VARBINARY"/>
        /// </summary>
        public static Java.Sql.JDBCType VARBINARY => LocalClazz.GetField<Java.Sql.JDBCType>("VARBINARY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#VARCHAR"/>
        /// </summary>
        public static Java.Sql.JDBCType VARCHAR => LocalClazz.GetField<Java.Sql.JDBCType>("VARCHAR");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#values()"/> 
        /// </summary>
        public static Java.Sql.JDBCType[] Values
        {
            get { return SExecuteArray<Java.Sql.JDBCType>(LocalClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#valueOf(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Sql.JDBCType"/></returns>
        public static Java.Sql.JDBCType ValueOf(int arg0)
        {
            return SExecute<Java.Sql.JDBCType>(LocalClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.JDBCType"/></returns>
        public static Java.Sql.JDBCType ValueOf(string arg0)
        {
            return SExecute<Java.Sql.JDBCType>(LocalClazz, "valueOf", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getVendor()"/> 
        /// </summary>
        public string Vendor
        {
            get { return IExecute<string>("getVendor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getVendorTypeNumber()"/> 
        /// </summary>
        public int? VendorTypeNumber
        {
            get { return IExecute<int?>("getVendorTypeNumber"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}