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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DropMode
    public partial class DropMode
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#INSERT"/>
        /// </summary>
        public static Javax.Swing.DropMode INSERT { get { if (!_INSERTReady) { _INSERTContent = SGetField<Javax.Swing.DropMode>(LocalBridgeClazz, "INSERT"); _INSERTReady = true; } return _INSERTContent; } }
        private static Javax.Swing.DropMode _INSERTContent = default;
        private static bool _INSERTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#INSERT_COLS"/>
        /// </summary>
        public static Javax.Swing.DropMode INSERT_COLS { get { if (!_INSERT_COLSReady) { _INSERT_COLSContent = SGetField<Javax.Swing.DropMode>(LocalBridgeClazz, "INSERT_COLS"); _INSERT_COLSReady = true; } return _INSERT_COLSContent; } }
        private static Javax.Swing.DropMode _INSERT_COLSContent = default;
        private static bool _INSERT_COLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#INSERT_ROWS"/>
        /// </summary>
        public static Javax.Swing.DropMode INSERT_ROWS { get { if (!_INSERT_ROWSReady) { _INSERT_ROWSContent = SGetField<Javax.Swing.DropMode>(LocalBridgeClazz, "INSERT_ROWS"); _INSERT_ROWSReady = true; } return _INSERT_ROWSContent; } }
        private static Javax.Swing.DropMode _INSERT_ROWSContent = default;
        private static bool _INSERT_ROWSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#ON"/>
        /// </summary>
        public static Javax.Swing.DropMode ON { get { if (!_ONReady) { _ONContent = SGetField<Javax.Swing.DropMode>(LocalBridgeClazz, "ON"); _ONReady = true; } return _ONContent; } }
        private static Javax.Swing.DropMode _ONContent = default;
        private static bool _ONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#ON_OR_INSERT"/>
        /// </summary>
        public static Javax.Swing.DropMode ON_OR_INSERT { get { if (!_ON_OR_INSERTReady) { _ON_OR_INSERTContent = SGetField<Javax.Swing.DropMode>(LocalBridgeClazz, "ON_OR_INSERT"); _ON_OR_INSERTReady = true; } return _ON_OR_INSERTContent; } }
        private static Javax.Swing.DropMode _ON_OR_INSERTContent = default;
        private static bool _ON_OR_INSERTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#ON_OR_INSERT_COLS"/>
        /// </summary>
        public static Javax.Swing.DropMode ON_OR_INSERT_COLS { get { if (!_ON_OR_INSERT_COLSReady) { _ON_OR_INSERT_COLSContent = SGetField<Javax.Swing.DropMode>(LocalBridgeClazz, "ON_OR_INSERT_COLS"); _ON_OR_INSERT_COLSReady = true; } return _ON_OR_INSERT_COLSContent; } }
        private static Javax.Swing.DropMode _ON_OR_INSERT_COLSContent = default;
        private static bool _ON_OR_INSERT_COLSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#ON_OR_INSERT_ROWS"/>
        /// </summary>
        public static Javax.Swing.DropMode ON_OR_INSERT_ROWS { get { if (!_ON_OR_INSERT_ROWSReady) { _ON_OR_INSERT_ROWSContent = SGetField<Javax.Swing.DropMode>(LocalBridgeClazz, "ON_OR_INSERT_ROWS"); _ON_OR_INSERT_ROWSReady = true; } return _ON_OR_INSERT_ROWSContent; } }
        private static Javax.Swing.DropMode _ON_OR_INSERT_ROWSContent = default;
        private static bool _ON_OR_INSERT_ROWSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#USE_SELECTION"/>
        /// </summary>
        public static Javax.Swing.DropMode USE_SELECTION { get { if (!_USE_SELECTIONReady) { _USE_SELECTIONContent = SGetField<Javax.Swing.DropMode>(LocalBridgeClazz, "USE_SELECTION"); _USE_SELECTIONReady = true; } return _USE_SELECTIONContent; } }
        private static Javax.Swing.DropMode _USE_SELECTIONContent = default;
        private static bool _USE_SELECTIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Swing.DropMode"/></returns>
        public static Javax.Swing.DropMode ValueOf(string arg0)
        {
            return SExecute<Javax.Swing.DropMode>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DropMode.html#values()"/>
        /// </summary>

        /// <returns><see cref="Javax.Swing.DropMode"/></returns>
        public static Javax.Swing.DropMode[] Values()
        {
            return SExecuteArray<Javax.Swing.DropMode>(LocalBridgeClazz, "values");
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