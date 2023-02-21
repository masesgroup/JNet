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
    #region JDBCType
    public partial class JDBCType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Sql.SQLType(Java.Sql.JDBCType t) => t.Cast<Java.Sql.SQLType>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BIT
        /// </summary>
        public static Java.Sql.JDBCType BIT => Clazz.GetField<Java.Sql.JDBCType>("BIT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TINYINT
        /// </summary>
        public static Java.Sql.JDBCType TINYINT => Clazz.GetField<Java.Sql.JDBCType>("TINYINT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#SMALLINT
        /// </summary>
        public static Java.Sql.JDBCType SMALLINT => Clazz.GetField<Java.Sql.JDBCType>("SMALLINT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#INTEGER
        /// </summary>
        public static Java.Sql.JDBCType INTEGER => Clazz.GetField<Java.Sql.JDBCType>("INTEGER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BIGINT
        /// </summary>
        public static Java.Sql.JDBCType BIGINT => Clazz.GetField<Java.Sql.JDBCType>("BIGINT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#FLOAT
        /// </summary>
        public static Java.Sql.JDBCType FLOAT => Clazz.GetField<Java.Sql.JDBCType>("FLOAT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REAL
        /// </summary>
        public static Java.Sql.JDBCType REAL => Clazz.GetField<Java.Sql.JDBCType>("REAL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DOUBLE
        /// </summary>
        public static Java.Sql.JDBCType DOUBLE => Clazz.GetField<Java.Sql.JDBCType>("DOUBLE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NUMERIC
        /// </summary>
        public static Java.Sql.JDBCType NUMERIC => Clazz.GetField<Java.Sql.JDBCType>("NUMERIC");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DECIMAL
        /// </summary>
        public static Java.Sql.JDBCType DECIMAL => Clazz.GetField<Java.Sql.JDBCType>("DECIMAL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#CHAR
        /// </summary>
        public static Java.Sql.JDBCType CHAR => Clazz.GetField<Java.Sql.JDBCType>("CHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#VARCHAR
        /// </summary>
        public static Java.Sql.JDBCType VARCHAR => Clazz.GetField<Java.Sql.JDBCType>("VARCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGVARCHAR
        /// </summary>
        public static Java.Sql.JDBCType LONGVARCHAR => Clazz.GetField<Java.Sql.JDBCType>("LONGVARCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DATE
        /// </summary>
        public static Java.Sql.JDBCType DATE => Clazz.GetField<Java.Sql.JDBCType>("DATE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIME
        /// </summary>
        public static Java.Sql.JDBCType TIME => Clazz.GetField<Java.Sql.JDBCType>("TIME");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIMESTAMP
        /// </summary>
        public static Java.Sql.JDBCType TIMESTAMP => Clazz.GetField<Java.Sql.JDBCType>("TIMESTAMP");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BINARY
        /// </summary>
        public static Java.Sql.JDBCType BINARY => Clazz.GetField<Java.Sql.JDBCType>("BINARY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#VARBINARY
        /// </summary>
        public static Java.Sql.JDBCType VARBINARY => Clazz.GetField<Java.Sql.JDBCType>("VARBINARY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGVARBINARY
        /// </summary>
        public static Java.Sql.JDBCType LONGVARBINARY => Clazz.GetField<Java.Sql.JDBCType>("LONGVARBINARY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NULL
        /// </summary>
        public static Java.Sql.JDBCType NULL => Clazz.GetField<Java.Sql.JDBCType>("NULL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#OTHER
        /// </summary>
        public static Java.Sql.JDBCType OTHER => Clazz.GetField<Java.Sql.JDBCType>("OTHER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#JAVA_OBJECT
        /// </summary>
        public static Java.Sql.JDBCType JAVA_OBJECT => Clazz.GetField<Java.Sql.JDBCType>("JAVA_OBJECT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DISTINCT
        /// </summary>
        public static Java.Sql.JDBCType DISTINCT => Clazz.GetField<Java.Sql.JDBCType>("DISTINCT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#STRUCT
        /// </summary>
        public static Java.Sql.JDBCType STRUCT => Clazz.GetField<Java.Sql.JDBCType>("STRUCT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#ARRAY
        /// </summary>
        public static Java.Sql.JDBCType ARRAY => Clazz.GetField<Java.Sql.JDBCType>("ARRAY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BLOB
        /// </summary>
        public static Java.Sql.JDBCType BLOB => Clazz.GetField<Java.Sql.JDBCType>("BLOB");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#CLOB
        /// </summary>
        public static Java.Sql.JDBCType CLOB => Clazz.GetField<Java.Sql.JDBCType>("CLOB");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REF
        /// </summary>
        public static Java.Sql.JDBCType REF => Clazz.GetField<Java.Sql.JDBCType>("REF");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#DATALINK
        /// </summary>
        public static Java.Sql.JDBCType DATALINK => Clazz.GetField<Java.Sql.JDBCType>("DATALINK");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#BOOLEAN
        /// </summary>
        public static Java.Sql.JDBCType BOOLEAN => Clazz.GetField<Java.Sql.JDBCType>("BOOLEAN");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#ROWID
        /// </summary>
        public static Java.Sql.JDBCType ROWID => Clazz.GetField<Java.Sql.JDBCType>("ROWID");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NCHAR
        /// </summary>
        public static Java.Sql.JDBCType NCHAR => Clazz.GetField<Java.Sql.JDBCType>("NCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NVARCHAR
        /// </summary>
        public static Java.Sql.JDBCType NVARCHAR => Clazz.GetField<Java.Sql.JDBCType>("NVARCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#LONGNVARCHAR
        /// </summary>
        public static Java.Sql.JDBCType LONGNVARCHAR => Clazz.GetField<Java.Sql.JDBCType>("LONGNVARCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#NCLOB
        /// </summary>
        public static Java.Sql.JDBCType NCLOB => Clazz.GetField<Java.Sql.JDBCType>("NCLOB");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#SQLXML
        /// </summary>
        public static Java.Sql.JDBCType SQLXML => Clazz.GetField<Java.Sql.JDBCType>("SQLXML");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#REF_CURSOR
        /// </summary>
        public static Java.Sql.JDBCType REF_CURSOR => Clazz.GetField<Java.Sql.JDBCType>("REF_CURSOR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIME_WITH_TIMEZONE
        /// </summary>
        public static Java.Sql.JDBCType TIME_WITH_TIMEZONE => Clazz.GetField<Java.Sql.JDBCType>("TIME_WITH_TIMEZONE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#TIMESTAMP_WITH_TIMEZONE
        /// </summary>
        public static Java.Sql.JDBCType TIMESTAMP_WITH_TIMEZONE => Clazz.GetField<Java.Sql.JDBCType>("TIMESTAMP_WITH_TIMEZONE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#values()
        /// </summary>
        public static Java.Sql.JDBCType[] Values()
        {
            return SExecuteArray<Java.Sql.JDBCType>("values");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getName() 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getVendor() 
        /// </summary>
        public string Vendor
        {
            get { return IExecute<string>("getVendor"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/JDBCType.html#getVendorTypeNumber() 
        /// </summary>
        public int VendorTypeNumber
        {
            get { return IExecute<int>("getVendorTypeNumber"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}