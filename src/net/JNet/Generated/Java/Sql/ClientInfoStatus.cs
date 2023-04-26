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
    #region ClientInfoStatus
    public partial class ClientInfoStatus
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#REASON_UNKNOWN"/>
        /// </summary>
        public static Java.Sql.ClientInfoStatus REASON_UNKNOWN => LocalClazz.GetField<Java.Sql.ClientInfoStatus>("REASON_UNKNOWN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#REASON_UNKNOWN_PROPERTY"/>
        /// </summary>
        public static Java.Sql.ClientInfoStatus REASON_UNKNOWN_PROPERTY => LocalClazz.GetField<Java.Sql.ClientInfoStatus>("REASON_UNKNOWN_PROPERTY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#REASON_VALUE_INVALID"/>
        /// </summary>
        public static Java.Sql.ClientInfoStatus REASON_VALUE_INVALID => LocalClazz.GetField<Java.Sql.ClientInfoStatus>("REASON_VALUE_INVALID");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#REASON_VALUE_TRUNCATED"/>
        /// </summary>
        public static Java.Sql.ClientInfoStatus REASON_VALUE_TRUNCATED => LocalClazz.GetField<Java.Sql.ClientInfoStatus>("REASON_VALUE_TRUNCATED");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#values()"/> 
        /// </summary>
        public static Java.Sql.ClientInfoStatus[] Values
        {
            get { return SExecuteArray<Java.Sql.ClientInfoStatus>(LocalClazz, "values"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/ClientInfoStatus.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.ClientInfoStatus"/></returns>
        public static Java.Sql.ClientInfoStatus ValueOf(string arg0)
        {
            return SExecute<Java.Sql.ClientInfoStatus>(LocalClazz, "valueOf", arg0);
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