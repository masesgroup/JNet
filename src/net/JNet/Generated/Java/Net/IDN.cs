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

namespace Java.Net
{
    #region IDN
    public partial class IDN
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/IDN.html#ALLOW_UNASSIGNED"/>
        /// </summary>
        public static int ALLOW_UNASSIGNED { get { if (!_ALLOW_UNASSIGNEDReady) { _ALLOW_UNASSIGNEDContent = SGetField<int>(LocalBridgeClazz, "ALLOW_UNASSIGNED"); _ALLOW_UNASSIGNEDReady = true; } return _ALLOW_UNASSIGNEDContent; } }
        private static int _ALLOW_UNASSIGNEDContent = default;
        private static bool _ALLOW_UNASSIGNEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/IDN.html#USE_STD3_ASCII_RULES"/>
        /// </summary>
        public static int USE_STD3_ASCII_RULES { get { if (!_USE_STD3_ASCII_RULESReady) { _USE_STD3_ASCII_RULESContent = SGetField<int>(LocalBridgeClazz, "USE_STD3_ASCII_RULES"); _USE_STD3_ASCII_RULESReady = true; } return _USE_STD3_ASCII_RULESContent; } }
        private static int _USE_STD3_ASCII_RULESContent = default;
        private static bool _USE_STD3_ASCII_RULESReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/IDN.html#toASCII(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToASCII(string arg0, int arg1)
        {
            return SExecute<string>(LocalBridgeClazz, "toASCII", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/IDN.html#toASCII(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToASCII(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toASCII", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/IDN.html#toUnicode(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToUnicode(string arg0, int arg1)
        {
            return SExecute<string>(LocalBridgeClazz, "toUnicode", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/IDN.html#toUnicode(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string ToUnicode(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "toUnicode", arg0);
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