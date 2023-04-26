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

namespace Javax.Sql.Rowset.Spi
{
    #region SyncProvider
    public partial class SyncProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#DATASOURCE_DB_LOCK"/>
        /// </summary>
        public static int DATASOURCE_DB_LOCK => LocalClazz.GetField<int>("DATASOURCE_DB_LOCK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#DATASOURCE_NO_LOCK"/>
        /// </summary>
        public static int DATASOURCE_NO_LOCK => LocalClazz.GetField<int>("DATASOURCE_NO_LOCK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#DATASOURCE_ROW_LOCK"/>
        /// </summary>
        public static int DATASOURCE_ROW_LOCK => LocalClazz.GetField<int>("DATASOURCE_ROW_LOCK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#DATASOURCE_TABLE_LOCK"/>
        /// </summary>
        public static int DATASOURCE_TABLE_LOCK => LocalClazz.GetField<int>("DATASOURCE_TABLE_LOCK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_CHECK_ALL_AT_COMMIT"/>
        /// </summary>
        public static int GRADE_CHECK_ALL_AT_COMMIT => LocalClazz.GetField<int>("GRADE_CHECK_ALL_AT_COMMIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_CHECK_MODIFIED_AT_COMMIT"/>
        /// </summary>
        public static int GRADE_CHECK_MODIFIED_AT_COMMIT => LocalClazz.GetField<int>("GRADE_CHECK_MODIFIED_AT_COMMIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_LOCK_WHEN_LOADED"/>
        /// </summary>
        public static int GRADE_LOCK_WHEN_LOADED => LocalClazz.GetField<int>("GRADE_LOCK_WHEN_LOADED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_LOCK_WHEN_MODIFIED"/>
        /// </summary>
        public static int GRADE_LOCK_WHEN_MODIFIED => LocalClazz.GetField<int>("GRADE_LOCK_WHEN_MODIFIED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#GRADE_NONE"/>
        /// </summary>
        public static int GRADE_NONE => LocalClazz.GetField<int>("GRADE_NONE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#NONUPDATABLE_VIEW_SYNC"/>
        /// </summary>
        public static int NONUPDATABLE_VIEW_SYNC => LocalClazz.GetField<int>("NONUPDATABLE_VIEW_SYNC");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#UPDATABLE_VIEW_SYNC"/>
        /// </summary>
        public static int UPDATABLE_VIEW_SYNC => LocalClazz.GetField<int>("UPDATABLE_VIEW_SYNC");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getDataSourceLock()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#setDataSourceLock(int)"/>
        /// </summary>
        public int DataSourceLock
        {
            get { return IExecute<int>("getDataSourceLock"); } set { IExecute("setDataSourceLock", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getProviderGrade()"/> 
        /// </summary>
        public int ProviderGrade
        {
            get { return IExecute<int>("getProviderGrade"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getProviderID()"/> 
        /// </summary>
        public string ProviderID
        {
            get { return IExecute<string>("getProviderID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getRowSetReader()"/> 
        /// </summary>
        public Javax.Sql.RowSetReader RowSetReader
        {
            get { return IExecute<Javax.Sql.RowSetReader>("getRowSetReader"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getRowSetWriter()"/> 
        /// </summary>
        public Javax.Sql.RowSetWriter RowSetWriter
        {
            get { return IExecute<Javax.Sql.RowSetWriter>("getRowSetWriter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#supportsUpdatableView()"/> 
        /// </summary>
        public int SupportsUpdatableView
        {
            get { return IExecute<int>("supportsUpdatableView"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getVendor()"/> 
        /// </summary>
        public string Vendor
        {
            get { return IExecute<string>("getVendor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncProvider.html#getVersion()"/> 
        /// </summary>
        public string Version
        {
            get { return IExecute<string>("getVersion"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}