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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Sql
{
    #region RowIdLifetime
    public partial class RowIdLifetime
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/RowIdLifetime.html#ROWID_UNSUPPORTED"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_UNSUPPORTED { get { return SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_UNSUPPORTED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/RowIdLifetime.html#ROWID_VALID_FOREVER"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_VALID_FOREVER { get { return SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_VALID_FOREVER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/RowIdLifetime.html#ROWID_VALID_OTHER"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_VALID_OTHER { get { return SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_VALID_OTHER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/RowIdLifetime.html#ROWID_VALID_SESSION"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_VALID_SESSION { get { return SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_VALID_SESSION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/RowIdLifetime.html#ROWID_VALID_TRANSACTION"/>
        /// </summary>
        public static Java.Sql.RowIdLifetime ROWID_VALID_TRANSACTION { get { return SGetField<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "ROWID_VALID_TRANSACTION"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/RowIdLifetime.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Sql.RowIdLifetime"/></returns>
        public static Java.Sql.RowIdLifetime ValueOf(string arg0)
        {
            return SExecute<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql/java/sql/RowIdLifetime.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Sql.RowIdLifetime"/></returns>
        public static Java.Sql.RowIdLifetime[] Values()
        {
            return SExecuteArray<Java.Sql.RowIdLifetime>(LocalBridgeClazz, "values");
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