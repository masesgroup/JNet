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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Sql.Rowset.Spi
{
    #region ISyncResolver
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISyncResolver : Javax.Sql.IRowSet
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#getStatus()"/> 
        /// </summary>
        int Status { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#nextConflict()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool NextConflict();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#previousConflict()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        bool PreviousConflict();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#getConflictValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        object GetConflictValue(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#getConflictValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        object GetConflictValue(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#setResolvedValue(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void SetResolvedValue(int arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#setResolvedValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        void SetResolvedValue(string arg0, object arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SyncResolver
    public partial class SyncResolver : Javax.Sql.Rowset.Spi.ISyncResolver
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#DELETE_ROW_CONFLICT"/>
        /// </summary>
        public static int DELETE_ROW_CONFLICT { get { if (!_DELETE_ROW_CONFLICTReady) { _DELETE_ROW_CONFLICTContent = SGetField<int>(LocalBridgeClazz, "DELETE_ROW_CONFLICT"); _DELETE_ROW_CONFLICTReady = true; } return _DELETE_ROW_CONFLICTContent; } }
        private static int _DELETE_ROW_CONFLICTContent = default;
        private static bool _DELETE_ROW_CONFLICTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#INSERT_ROW_CONFLICT"/>
        /// </summary>
        public static int INSERT_ROW_CONFLICT { get { if (!_INSERT_ROW_CONFLICTReady) { _INSERT_ROW_CONFLICTContent = SGetField<int>(LocalBridgeClazz, "INSERT_ROW_CONFLICT"); _INSERT_ROW_CONFLICTReady = true; } return _INSERT_ROW_CONFLICTContent; } }
        private static int _INSERT_ROW_CONFLICTContent = default;
        private static bool _INSERT_ROW_CONFLICTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#NO_ROW_CONFLICT"/>
        /// </summary>
        public static int NO_ROW_CONFLICT { get { if (!_NO_ROW_CONFLICTReady) { _NO_ROW_CONFLICTContent = SGetField<int>(LocalBridgeClazz, "NO_ROW_CONFLICT"); _NO_ROW_CONFLICTReady = true; } return _NO_ROW_CONFLICTContent; } }
        private static int _NO_ROW_CONFLICTContent = default;
        private static bool _NO_ROW_CONFLICTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#UPDATE_ROW_CONFLICT"/>
        /// </summary>
        public static int UPDATE_ROW_CONFLICT { get { if (!_UPDATE_ROW_CONFLICTReady) { _UPDATE_ROW_CONFLICTContent = SGetField<int>(LocalBridgeClazz, "UPDATE_ROW_CONFLICT"); _UPDATE_ROW_CONFLICTReady = true; } return _UPDATE_ROW_CONFLICTContent; } }
        private static int _UPDATE_ROW_CONFLICTContent = default;
        private static bool _UPDATE_ROW_CONFLICTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#getStatus()"/> 
        /// </summary>
        public int Status
        {
            get { return IExecute<int>("getStatus"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#nextConflict()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool NextConflict()
        {
            return IExecute<bool>("nextConflict");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#previousConflict()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public bool PreviousConflict()
        {
            return IExecute<bool>("previousConflict");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#getConflictValue(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object GetConflictValue(int arg0)
        {
            return IExecute("getConflictValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#getConflictValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Sql.SQLException"/>
        public object GetConflictValue(string arg0)
        {
            return IExecute("getConflictValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#setResolvedValue(int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetResolvedValue(int arg0, object arg1)
        {
            IExecute("setResolvedValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.sql.rowset/javax/sql/rowset/spi/SyncResolver.html#setResolvedValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <exception cref="Java.Sql.SQLException"/>
        public void SetResolvedValue(string arg0, object arg1)
        {
            IExecute("setResolvedValue", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}