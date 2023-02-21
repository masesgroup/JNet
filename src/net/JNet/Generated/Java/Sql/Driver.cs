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
    #region Driver
    public partial class Driver
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#getMajorVersion() 
        /// </summary>
        public int MajorVersion
        {
            get { return IExecute<int>("getMajorVersion"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#getMinorVersion() 
        /// </summary>
        public int MinorVersion
        {
            get { return IExecute<int>("getMinorVersion"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#getParentLogger() throws java.sql.SQLFeatureNotSupportedException 
        /// </summary>
        public Java.Util.Logging.Logger ParentLogger
        {
            get { return IExecute<Java.Util.Logging.Logger>("getParentLogger"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#acceptsURL(java.lang.String) throws java.sql.SQLException
        /// </summary>
        public bool AcceptsURL(string arg0)
        {
            return IExecute<bool>("acceptsURL", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/Driver.html#jdbcCompliant()
        /// </summary>
        public bool JdbcCompliant()
        {
            return IExecute<bool>("jdbcCompliant");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}