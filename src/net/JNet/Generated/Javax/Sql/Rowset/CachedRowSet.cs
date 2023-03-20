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

namespace Javax.Sql.Rowset
{
    #region CachedRowSet
    public partial class CachedRowSet
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.CachedRowSet"/> to <see cref="Javax.Sql.RowSet"/>
        /// </summary>
        public static implicit operator Javax.Sql.RowSet(Javax.Sql.Rowset.CachedRowSet t) => t.Cast<Javax.Sql.RowSet>();
        /// <summary>
        /// Converter from <see cref="Javax.Sql.Rowset.CachedRowSet"/> to <see cref="Javax.Sql.Rowset.Joinable"/>
        /// </summary>
        public static implicit operator Javax.Sql.Rowset.Joinable(Javax.Sql.Rowset.CachedRowSet t) => t.Cast<Javax.Sql.Rowset.Joinable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getKeyColumns()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setKeyColumns(int[])"/>
        /// </summary>
        public int[] KeyColumns
        {
            get { return IExecuteArray<int>("getKeyColumns"); } set { IExecute("setKeyColumns", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getOriginal()"/> 
        /// </summary>
        public Java.Sql.ResultSet Original
        {
            get { return IExecute<Java.Sql.ResultSet>("getOriginal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getOriginalRow()"/> 
        /// </summary>
        public Java.Sql.ResultSet OriginalRow
        {
            get { return IExecute<Java.Sql.ResultSet>("getOriginalRow"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getPageSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setPageSize(int)"/>
        /// </summary>
        public int PageSize
        {
            get { return IExecute<int>("getPageSize"); } set { IExecute("setPageSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getRowSetWarnings()"/> 
        /// </summary>
        public Javax.Sql.Rowset.RowSetWarning RowSetWarnings
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getRowSetWarnings"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Javax.Sql.Rowset.RowSetWarning>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getShowDeleted()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setShowDeleted(boolean)"/>
        /// </summary>
        public bool ShowDeleted
        {
            get { return IExecute<bool>("getShowDeleted"); } set { IExecute("setShowDeleted", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getSyncProvider()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setSyncProvider(java.lang.String)"/>
        /// </summary>
        public Javax.Sql.Rowset.Spi.SyncProvider SyncProvider
        {
            get { return IExecute<Javax.Sql.Rowset.Spi.SyncProvider>("getSyncProvider"); } set { IExecute("setSyncProvider", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#getTableName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setTableName(java.lang.String)"/>
        /// </summary>
        public string TableName
        {
            get { return IExecute<string>("getTableName"); } set { IExecute("setTableName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#columnUpdated(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool ColumnUpdated(int arg0)
        {
            return IExecute<bool>("columnUpdated", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#columnUpdated(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool ColumnUpdated(string arg0)
        {
            return IExecute<bool>("columnUpdated", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#nextPage()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool NextPage()
        {
            return IExecute<bool>("nextPage");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#previousPage()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool PreviousPage()
        {
            return IExecute<bool>("previousPage");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#size()"/>
        /// </summary>
        
        /// <returns><see cref="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Util.Collection ToCollection()
        {
            return IExecute<Java.Util.Collection>("toCollection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Util.Collection ToCollection(int arg0)
        {
            return IExecute<Java.Util.Collection>("toCollection", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#toCollection(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Util.Collection ToCollection(string arg0)
        {
            return IExecute<Java.Util.Collection>("toCollection", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createShared()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Sql.RowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.RowSet CreateShared()
        {
            return IExecute<Javax.Sql.RowSet>("createShared");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopy()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet CreateCopy()
        {
            return IExecute<Javax.Sql.Rowset.CachedRowSet>("createCopy");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopyNoConstraints()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet CreateCopyNoConstraints()
        {
            return IExecute<Javax.Sql.Rowset.CachedRowSet>("createCopyNoConstraints");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#createCopySchema()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Sql.Rowset.CachedRowSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Javax.Sql.Rowset.CachedRowSet CreateCopySchema()
        {
            return IExecute<Javax.Sql.Rowset.CachedRowSet>("createCopySchema");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#acceptChanges()"/>
        /// </summary>
        
        /// <exception cref="Javax.Sql.Rowset.Spi.SyncProviderException"/>
        public void AcceptChanges()
        {
            IExecute("acceptChanges");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#acceptChanges(java.sql.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Connection"/></param>
        /// <exception cref="Javax.Sql.Rowset.Spi.SyncProviderException"/>
        public void AcceptChanges(Java.Sql.Connection arg0)
        {
            IExecute("acceptChanges", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#commit()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void Commit()
        {
            IExecute("commit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#execute(java.sql.Connection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Connection"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Execute(Java.Sql.Connection arg0)
        {
            IExecute("execute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#populate(java.sql.ResultSet,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Populate(Java.Sql.ResultSet arg0, int arg1)
        {
            IExecute("populate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#populate(java.sql.ResultSet)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.ResultSet"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Populate(Java.Sql.ResultSet arg0)
        {
            IExecute("populate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#release()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void Release()
        {
            IExecute("release");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#restoreOriginal()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void RestoreOriginal()
        {
            IExecute("restoreOriginal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rollback()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback()
        {
            IExecute("rollback");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rollback(java.sql.Savepoint)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Savepoint"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void Rollback(Java.Sql.Savepoint arg0)
        {
            IExecute("rollback", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#rowSetPopulated(javax.sql.RowSetEvent,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetEvent"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void RowSetPopulated(Javax.Sql.RowSetEvent arg0, int arg1)
        {
            IExecute("rowSetPopulated", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setMetaData(javax.sql.RowSetMetaData)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Sql.RowSetMetaData"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetMetaData(Javax.Sql.RowSetMetaData arg0)
        {
            IExecute("setMetaData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#setOriginalRow()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetOriginalRow()
        {
            IExecute("setOriginalRow");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoDelete()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void UndoDelete()
        {
            IExecute("undoDelete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoInsert()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void UndoInsert()
        {
            IExecute("undoInsert");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/CachedRowSet.html#undoUpdate()"/>
        /// </summary>
        
        /// <exception cref="Java.Sql.SQLException"/>
        public void UndoUpdate()
        {
            IExecute("undoUpdate");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}