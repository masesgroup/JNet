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
    #region DriverManager
    public partial class DriverManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getLoginTimeout() https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#setLoginTimeout(int)
        /// </summary>
        public static int LoginTimeout
        {
            get { return SExecute<int>("getLoginTimeout"); } set { SExecute("setLoginTimeout", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getLogWriter() https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#setLogWriter(java.io.PrintWriter)
        /// </summary>
        public static Java.Io.PrintWriter LogWriter
        {
            get { return SExecute<Java.Io.PrintWriter>("getLogWriter"); } set { SExecute("setLogWriter", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getConnection(java.lang.String,java.lang.String,java.lang.String) throws java.sql.SQLException
        /// </summary>
        public static Java.Sql.Connection GetConnection(string arg0, string arg1, string arg2)
        {
            return SExecute<Java.Sql.Connection>("getConnection", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getConnection(java.lang.String) throws java.sql.SQLException
        /// </summary>
        public static Java.Sql.Connection GetConnection(string arg0)
        {
            return SExecute<Java.Sql.Connection>("getConnection", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getDriver(java.lang.String) throws java.sql.SQLException
        /// </summary>
        public static Java.Sql.Driver GetDriver(string arg0)
        {
            return SExecute<Java.Sql.Driver>("getDriver", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#deregisterDriver(java.sql.Driver) throws java.sql.SQLException
        /// </summary>
        public static void DeregisterDriver(Java.Sql.Driver arg0)
        {
            SExecute("deregisterDriver", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#println(java.lang.String)
        /// </summary>
        public static void Println(string arg0)
        {
            SExecute("println", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#registerDriver(java.sql.Driver,java.sql.DriverAction) throws java.sql.SQLException
        /// </summary>
        public static void RegisterDriver(Java.Sql.Driver arg0, Java.Sql.DriverAction arg1)
        {
            SExecute("registerDriver", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#registerDriver(java.sql.Driver) throws java.sql.SQLException
        /// </summary>
        public static void RegisterDriver(Java.Sql.Driver arg0)
        {
            SExecute("registerDriver", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}