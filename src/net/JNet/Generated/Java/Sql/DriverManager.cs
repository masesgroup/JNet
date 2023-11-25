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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getLoginTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#setLoginTimeout(int)"/>
        /// </summary>
        public static int LoginTimeout
        {
            get { return SExecute<int>(LocalBridgeClazz, "getLoginTimeout"); } set { SExecute(LocalBridgeClazz, "setLoginTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getLogWriter()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#setLogWriter(java.io.PrintWriter)"/>
        /// </summary>
        public static Java.Io.PrintWriter LogWriter
        {
            get { return SExecute<Java.Io.PrintWriter>(LocalBridgeClazz, "getLogWriter"); } set { SExecute(LocalBridgeClazz, "setLogWriter", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getConnection(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(string arg0, string arg1, string arg2)
        {
            return SExecute<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getConnection(java.lang.String,java.util.Properties)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Properties"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(string arg0, Java.Util.Properties arg1)
        {
            return SExecute<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getConnection(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.Connection"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Connection GetConnection(string arg0)
        {
            return SExecute<Java.Sql.Connection>(LocalBridgeClazz, "getConnection", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getDriver(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.Driver"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public static Java.Sql.Driver GetDriver(string arg0)
        {
            return SExecute<Java.Sql.Driver>(LocalBridgeClazz, "getDriver", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#getDrivers()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public static Java.Util.Enumeration<Java.Sql.Driver> GetDrivers()
        {
            return SExecute<Java.Util.Enumeration<Java.Sql.Driver>>(LocalBridgeClazz, "getDrivers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#drivers()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public static Java.Util.Stream.Stream<Java.Sql.Driver> Drivers()
        {
            return SExecute<Java.Util.Stream.Stream<Java.Sql.Driver>>(LocalBridgeClazz, "drivers");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#deregisterDriver(java.sql.Driver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Driver"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public static void DeregisterDriver(Java.Sql.Driver arg0)
        {
            SExecute(LocalBridgeClazz, "deregisterDriver", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#println(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public static void Println(string arg0)
        {
            SExecute(LocalBridgeClazz, "println", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#registerDriver(java.sql.Driver,java.sql.DriverAction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Driver"/></param>
        /// <param name="arg1"><see cref="Java.Sql.DriverAction"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public static void RegisterDriver(Java.Sql.Driver arg0, Java.Sql.DriverAction arg1)
        {
            SExecute(LocalBridgeClazz, "registerDriver", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/DriverManager.html#registerDriver(java.sql.Driver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Sql.Driver"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public static void RegisterDriver(Java.Sql.Driver arg0)
        {
            SExecute(LocalBridgeClazz, "registerDriver", arg0);
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