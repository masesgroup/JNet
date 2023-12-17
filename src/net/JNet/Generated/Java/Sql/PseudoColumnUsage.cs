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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
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
        public static Java.Sql.PseudoColumnUsage NO_USAGE_RESTRICTIONS { get { return SGetField<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "NO_USAGE_RESTRICTIONS"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#SELECT_LIST_ONLY"/>
        /// </summary>
        public static Java.Sql.PseudoColumnUsage SELECT_LIST_ONLY { get { return SGetField<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "SELECT_LIST_ONLY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#USAGE_UNKNOWN"/>
        /// </summary>
        public static Java.Sql.PseudoColumnUsage USAGE_UNKNOWN { get { return SGetField<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "USAGE_UNKNOWN"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#WHERE_CLAUSE_ONLY"/>
        /// </summary>
        public static Java.Sql.PseudoColumnUsage WHERE_CLAUSE_ONLY { get { return SGetField<Java.Sql.PseudoColumnUsage>(LocalBridgeClazz, "WHERE_CLAUSE_ONLY"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/PseudoColumnUsage.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.PseudoColumnUsage"/></returns>
        public static Java.Sql.PseudoColumnUsage ValueOf(string arg0)
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