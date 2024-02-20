/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region PseudoColumnUsage
    public partial class PseudoColumnUsage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#NO_USAGE_RESTRICTIONS"/>
        /// </summary>
        public static Java.Sql.PseudoColumnUsage NO_USAGE_RESTRICTIONS { get { if (!_NO_USAGE_RESTRICTIONSReady) { _NO_USAGE_RESTRICTIONSContent = SGetField<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "NO_USAGE_RESTRICTIONS"); _NO_USAGE_RESTRICTIONSReady = true; } return _NO_USAGE_RESTRICTIONSContent; } }
        private static Java.Sql.PseudoColumnUsage _NO_USAGE_RESTRICTIONSContent = default;
        private static bool _NO_USAGE_RESTRICTIONSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#SELECT_LIST_ONLY"/>
        /// </summary>
        public static Java.Sql.PseudoColumnUsage SELECT_LIST_ONLY { get { if (!_SELECT_LIST_ONLYReady) { _SELECT_LIST_ONLYContent = SGetField<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "SELECT_LIST_ONLY"); _SELECT_LIST_ONLYReady = true; } return _SELECT_LIST_ONLYContent; } }
        private static Java.Sql.PseudoColumnUsage _SELECT_LIST_ONLYContent = default;
        private static bool _SELECT_LIST_ONLYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#USAGE_UNKNOWN"/>
        /// </summary>
        public static Java.Sql.PseudoColumnUsage USAGE_UNKNOWN { get { if (!_USAGE_UNKNOWNReady) { _USAGE_UNKNOWNContent = SGetField<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "USAGE_UNKNOWN"); _USAGE_UNKNOWNReady = true; } return _USAGE_UNKNOWNContent; } }
        private static Java.Sql.PseudoColumnUsage _USAGE_UNKNOWNContent = default;
        private static bool _USAGE_UNKNOWNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#WHERE_CLAUSE_ONLY"/>
        /// </summary>
        public static Java.Sql.PseudoColumnUsage WHERE_CLAUSE_ONLY { get { if (!_WHERE_CLAUSE_ONLYReady) { _WHERE_CLAUSE_ONLYContent = SGetField<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "WHERE_CLAUSE_ONLY"); _WHERE_CLAUSE_ONLYReady = true; } return _WHERE_CLAUSE_ONLYContent; } }
        private static Java.Sql.PseudoColumnUsage _WHERE_CLAUSE_ONLYContent = default;
        private static bool _WHERE_CLAUSE_ONLYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Sql.PseudoColumnUsage"/></returns>
        public static Java.Sql.PseudoColumnUsage ValueOf(Java.Lang.String arg0)
        {
            return SExecute<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Sql.PseudoColumnUsage"/></returns>
        public static Java.Sql.PseudoColumnUsage[] Values()
        {
            return SExecuteArray<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "values");
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