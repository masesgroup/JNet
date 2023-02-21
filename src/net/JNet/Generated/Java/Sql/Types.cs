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
    #region Types
    public partial class Types
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#BIT
        /// </summary>
        public static int BIT => Clazz.GetField<int>("BIT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#TINYINT
        /// </summary>
        public static int TINYINT => Clazz.GetField<int>("TINYINT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#SMALLINT
        /// </summary>
        public static int SMALLINT => Clazz.GetField<int>("SMALLINT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#INTEGER
        /// </summary>
        public static int INTEGER => Clazz.GetField<int>("INTEGER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#BIGINT
        /// </summary>
        public static int BIGINT => Clazz.GetField<int>("BIGINT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#FLOAT
        /// </summary>
        public static int FLOAT => Clazz.GetField<int>("FLOAT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#REAL
        /// </summary>
        public static int REAL => Clazz.GetField<int>("REAL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#DOUBLE
        /// </summary>
        public static int DOUBLE => Clazz.GetField<int>("DOUBLE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#NUMERIC
        /// </summary>
        public static int NUMERIC => Clazz.GetField<int>("NUMERIC");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#DECIMAL
        /// </summary>
        public static int DECIMAL => Clazz.GetField<int>("DECIMAL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#CHAR
        /// </summary>
        public static int CHAR => Clazz.GetField<int>("CHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#VARCHAR
        /// </summary>
        public static int VARCHAR => Clazz.GetField<int>("VARCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#LONGVARCHAR
        /// </summary>
        public static int LONGVARCHAR => Clazz.GetField<int>("LONGVARCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#DATE
        /// </summary>
        public static int DATE => Clazz.GetField<int>("DATE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#TIME
        /// </summary>
        public static int TIME => Clazz.GetField<int>("TIME");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#TIMESTAMP
        /// </summary>
        public static int TIMESTAMP => Clazz.GetField<int>("TIMESTAMP");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#BINARY
        /// </summary>
        public static int BINARY => Clazz.GetField<int>("BINARY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#VARBINARY
        /// </summary>
        public static int VARBINARY => Clazz.GetField<int>("VARBINARY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#LONGVARBINARY
        /// </summary>
        public static int LONGVARBINARY => Clazz.GetField<int>("LONGVARBINARY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#NULL
        /// </summary>
        public static int NULL => Clazz.GetField<int>("NULL");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#OTHER
        /// </summary>
        public static int OTHER => Clazz.GetField<int>("OTHER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#JAVA_OBJECT
        /// </summary>
        public static int JAVA_OBJECT => Clazz.GetField<int>("JAVA_OBJECT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#DISTINCT
        /// </summary>
        public static int DISTINCT => Clazz.GetField<int>("DISTINCT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#STRUCT
        /// </summary>
        public static int STRUCT => Clazz.GetField<int>("STRUCT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#ARRAY
        /// </summary>
        public static int ARRAY => Clazz.GetField<int>("ARRAY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#BLOB
        /// </summary>
        public static int BLOB => Clazz.GetField<int>("BLOB");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#CLOB
        /// </summary>
        public static int CLOB => Clazz.GetField<int>("CLOB");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#REF
        /// </summary>
        public static int REF => Clazz.GetField<int>("REF");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#DATALINK
        /// </summary>
        public static int DATALINK => Clazz.GetField<int>("DATALINK");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#BOOLEAN
        /// </summary>
        public static int BOOLEAN => Clazz.GetField<int>("BOOLEAN");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#ROWID
        /// </summary>
        public static int ROWID => Clazz.GetField<int>("ROWID");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#NCHAR
        /// </summary>
        public static int NCHAR => Clazz.GetField<int>("NCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#NVARCHAR
        /// </summary>
        public static int NVARCHAR => Clazz.GetField<int>("NVARCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#LONGNVARCHAR
        /// </summary>
        public static int LONGNVARCHAR => Clazz.GetField<int>("LONGNVARCHAR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#NCLOB
        /// </summary>
        public static int NCLOB => Clazz.GetField<int>("NCLOB");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#SQLXML
        /// </summary>
        public static int SQLXML => Clazz.GetField<int>("SQLXML");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#REF_CURSOR
        /// </summary>
        public static int REF_CURSOR => Clazz.GetField<int>("REF_CURSOR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#TIME_WITH_TIMEZONE
        /// </summary>
        public static int TIME_WITH_TIMEZONE => Clazz.GetField<int>("TIME_WITH_TIMEZONE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Types.html#TIMESTAMP_WITH_TIMEZONE
        /// </summary>
        public static int TIMESTAMP_WITH_TIMEZONE => Clazz.GetField<int>("TIMESTAMP_WITH_TIMEZONE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}