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
    #region Statement
    public partial class Statement
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Sql.Statement"/> to <see cref="Java.Sql.Wrapper"/>
        /// </summary>
        public static implicit operator Java.Sql.Wrapper(Java.Sql.Statement t) => t.Cast<Java.Sql.Wrapper>();
        /// <summary>
        /// Converter from <see cref="Java.Sql.Statement"/> to <see cref="Java.Lang.AutoCloseable"/>
        /// </summary>
        public static implicit operator Java.Lang.AutoCloseable(Java.Sql.Statement t) => t.Cast<Java.Lang.AutoCloseable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#CLOSE_ALL_RESULTS"/>
        /// </summary>
        public static int CLOSE_ALL_RESULTS { get { return LocalClazz.GetField<int>("CLOSE_ALL_RESULTS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#CLOSE_CURRENT_RESULT"/>
        /// </summary>
        public static int CLOSE_CURRENT_RESULT { get { return LocalClazz.GetField<int>("CLOSE_CURRENT_RESULT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#EXECUTE_FAILED"/>
        /// </summary>
        public static int EXECUTE_FAILED { get { return LocalClazz.GetField<int>("EXECUTE_FAILED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#KEEP_CURRENT_RESULT"/>
        /// </summary>
        public static int KEEP_CURRENT_RESULT { get { return LocalClazz.GetField<int>("KEEP_CURRENT_RESULT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#NO_GENERATED_KEYS"/>
        /// </summary>
        public static int NO_GENERATED_KEYS { get { return LocalClazz.GetField<int>("NO_GENERATED_KEYS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#RETURN_GENERATED_KEYS"/>
        /// </summary>
        public static int RETURN_GENERATED_KEYS { get { return LocalClazz.GetField<int>("RETURN_GENERATED_KEYS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#SUCCESS_NO_INFO"/>
        /// </summary>
        public static int SUCCESS_NO_INFO { get { return LocalClazz.GetField<int>("SUCCESS_NO_INFO"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getConnection()"/> 
        /// </summary>
        public Java.Sql.Connection Connection
        {
            get { return IExecute<Java.Sql.Connection>("getConnection"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeBatch()"/> 
        /// </summary>
        public int[] ExecuteBatch
        {
            get { return IExecuteArray<int>("executeBatch"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeLargeBatch()"/> 
        /// </summary>
        public long[] ExecuteLargeBatch
        {
            get { return IExecuteArray<long>("executeLargeBatch"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getFetchDirection()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setFetchDirection(int)"/>
        /// </summary>
        public int FetchDirection
        {
            get { return IExecute<int>("getFetchDirection"); } set { IExecute("setFetchDirection", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getFetchSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setFetchSize(int)"/>
        /// </summary>
        public int FetchSize
        {
            get { return IExecute<int>("getFetchSize"); } set { IExecute("setFetchSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getGeneratedKeys()"/> 
        /// </summary>
        public Java.Sql.ResultSet GeneratedKeys
        {
            get { return IExecute<Java.Sql.ResultSet>("getGeneratedKeys"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#isClosed()"/> 
        /// </summary>
        public bool IsClosed
        {
            get { return IExecute<bool>("isClosed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#isCloseOnCompletion()"/> 
        /// </summary>
        public bool IsCloseOnCompletion
        {
            get { return IExecute<bool>("isCloseOnCompletion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#isPoolable()"/> 
        /// </summary>
        public bool IsPoolable
        {
            get { return IExecute<bool>("isPoolable"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getLargeMaxRows()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setLargeMaxRows(long)"/>
        /// </summary>
        public long LargeMaxRows
        {
            get { return IExecute<long>("getLargeMaxRows"); } set { IExecute("setLargeMaxRows", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getLargeUpdateCount()"/> 
        /// </summary>
        public long LargeUpdateCount
        {
            get { return IExecute<long>("getLargeUpdateCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getMaxFieldSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setMaxFieldSize(int)"/>
        /// </summary>
        public int MaxFieldSize
        {
            get { return IExecute<int>("getMaxFieldSize"); } set { IExecute("setMaxFieldSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getMaxRows()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setMaxRows(int)"/>
        /// </summary>
        public int MaxRows
        {
            get { return IExecute<int>("getMaxRows"); } set { IExecute("setMaxRows", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getMoreResults()"/> 
        /// </summary>
        public bool MoreResults
        {
            get { return IExecute<bool>("getMoreResults"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getQueryTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setQueryTimeout(int)"/>
        /// </summary>
        public int QueryTimeout
        {
            get { return IExecute<int>("getQueryTimeout"); } set { IExecute("setQueryTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getResultSet()"/> 
        /// </summary>
        public Java.Sql.ResultSet ResultSet
        {
            get { return IExecute<Java.Sql.ResultSet>("getResultSet"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getResultSetConcurrency()"/> 
        /// </summary>
        public int ResultSetConcurrency
        {
            get { return IExecute<int>("getResultSetConcurrency"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getResultSetHoldability()"/> 
        /// </summary>
        public int ResultSetHoldability
        {
            get { return IExecute<int>("getResultSetHoldability"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getResultSetType()"/> 
        /// </summary>
        public int ResultSetType
        {
            get { return IExecute<int>("getResultSetType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getUpdateCount()"/> 
        /// </summary>
        public int UpdateCount
        {
            get { return IExecute<int>("getUpdateCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getWarnings()"/> 
        /// </summary>
        public Java.Sql.SQLWarning Warnings
        {
            get { var obj = IExecute<MASES.JCOBridge.C2JBridge.JVMInterop.IJavaObject>("getWarnings"); return MASES.JCOBridge.C2JBridge.JVMBridgeException.New<Java.Sql.SQLWarning>(obj); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#execute(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute(string arg0, int arg1)
        {
            return IExecute<bool>("execute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#execute(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute(string arg0, int[] arg1)
        {
            return IExecute<bool>("execute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#execute(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute(string arg0, string[] arg1)
        {
            return IExecute<bool>("execute", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#execute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool Execute(string arg0)
        {
            return IExecute<bool>("execute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#getMoreResults(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool GetMoreResults(int arg0)
        {
            return IExecute<bool>("getMoreResults", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeUpdate(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate(string arg0, int arg1)
        {
            return IExecute<int>("executeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeUpdate(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate(string arg0, int[] arg1)
        {
            return IExecute<int>("executeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeUpdate(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate(string arg0, string[] arg1)
        {
            return IExecute<int>("executeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeUpdate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public int ExecuteUpdate(string arg0)
        {
            return IExecute<int>("executeUpdate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeQuery(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.ResultSet"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public Java.Sql.ResultSet ExecuteQuery(string arg0)
        {
            return IExecute<Java.Sql.ResultSet>("executeQuery", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#addBatch(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void AddBatch(string arg0)
        {
            IExecute("addBatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#cancel()"/>
        /// </summary>

        /// <exception cref="Java.Sql.SQLException"/>
        public void Cancel()
        {
            IExecute("cancel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#clearBatch()"/>
        /// </summary>

        /// <exception cref="Java.Sql.SQLException"/>
        public void ClearBatch()
        {
            IExecute("clearBatch");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#clearWarnings()"/>
        /// </summary>

        /// <exception cref="Java.Sql.SQLException"/>
        public void ClearWarnings()
        {
            IExecute("clearWarnings");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Sql.SQLException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#closeOnCompletion()"/>
        /// </summary>

        /// <exception cref="Java.Sql.SQLException"/>
        public void CloseOnCompletion()
        {
            IExecute("closeOnCompletion");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setCursorName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetCursorName(string arg0)
        {
            IExecute("setCursorName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setEscapeProcessing(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetEscapeProcessing(bool arg0)
        {
            IExecute("setEscapeProcessing", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#setPoolable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetPoolable(bool arg0)
        {
            IExecute("setPoolable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#isSimpleIdentifier(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool IsSimpleIdentifier(string arg0)
        {
            return IExecute<bool>("isSimpleIdentifier", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#enquoteIdentifier(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string EnquoteIdentifier(string arg0, bool arg1)
        {
            return IExecute<string>("enquoteIdentifier", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#enquoteLiteral(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string EnquoteLiteral(string arg0)
        {
            return IExecute<string>("enquoteLiteral", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#enquoteNCharLiteral(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public string EnquoteNCharLiteral(string arg0)
        {
            return IExecute<string>("enquoteNCharLiteral", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeLargeUpdate(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate(string arg0, int arg1)
        {
            return IExecute<long>("executeLargeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeLargeUpdate(java.lang.String,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate(string arg0, int[] arg1)
        {
            return IExecute<long>("executeLargeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeLargeUpdate(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate(string arg0, string[] arg1)
        {
            return IExecute<long>("executeLargeUpdate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Statement.html#executeLargeUpdate(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public long ExecuteLargeUpdate(string arg0)
        {
            return IExecute<long>("executeLargeUpdate", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}