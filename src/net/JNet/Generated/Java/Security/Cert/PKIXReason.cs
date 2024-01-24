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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region PKIXReason
    public partial class PKIXReason
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#INVALID_KEY_USAGE"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason INVALID_KEY_USAGE { get { if (!_INVALID_KEY_USAGEReady) { _INVALID_KEY_USAGEContent = SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "INVALID_KEY_USAGE"); _INVALID_KEY_USAGEReady = true; } return _INVALID_KEY_USAGEContent; } }
        private static Java.Security.Cert.PKIXReason _INVALID_KEY_USAGEContent = default;
        private static bool _INVALID_KEY_USAGEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#INVALID_NAME"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason INVALID_NAME { get { if (!_INVALID_NAMEReady) { _INVALID_NAMEContent = SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "INVALID_NAME"); _INVALID_NAMEReady = true; } return _INVALID_NAMEContent; } }
        private static Java.Security.Cert.PKIXReason _INVALID_NAMEContent = default;
        private static bool _INVALID_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#INVALID_POLICY"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason INVALID_POLICY { get { if (!_INVALID_POLICYReady) { _INVALID_POLICYContent = SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "INVALID_POLICY"); _INVALID_POLICYReady = true; } return _INVALID_POLICYContent; } }
        private static Java.Security.Cert.PKIXReason _INVALID_POLICYContent = default;
        private static bool _INVALID_POLICYReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#NAME_CHAINING"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason NAME_CHAINING { get { if (!_NAME_CHAININGReady) { _NAME_CHAININGContent = SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "NAME_CHAINING"); _NAME_CHAININGReady = true; } return _NAME_CHAININGContent; } }
        private static Java.Security.Cert.PKIXReason _NAME_CHAININGContent = default;
        private static bool _NAME_CHAININGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#NO_TRUST_ANCHOR"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason NO_TRUST_ANCHOR { get { if (!_NO_TRUST_ANCHORReady) { _NO_TRUST_ANCHORContent = SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "NO_TRUST_ANCHOR"); _NO_TRUST_ANCHORReady = true; } return _NO_TRUST_ANCHORContent; } }
        private static Java.Security.Cert.PKIXReason _NO_TRUST_ANCHORContent = default;
        private static bool _NO_TRUST_ANCHORReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#NOT_CA_CERT"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason NOT_CA_CERT { get { if (!_NOT_CA_CERTReady) { _NOT_CA_CERTContent = SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "NOT_CA_CERT"); _NOT_CA_CERTReady = true; } return _NOT_CA_CERTContent; } }
        private static Java.Security.Cert.PKIXReason _NOT_CA_CERTContent = default;
        private static bool _NOT_CA_CERTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#PATH_TOO_LONG"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason PATH_TOO_LONG { get { if (!_PATH_TOO_LONGReady) { _PATH_TOO_LONGContent = SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "PATH_TOO_LONG"); _PATH_TOO_LONGReady = true; } return _PATH_TOO_LONGContent; } }
        private static Java.Security.Cert.PKIXReason _PATH_TOO_LONGContent = default;
        private static bool _PATH_TOO_LONGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#UNRECOGNIZED_CRIT_EXT"/>
        /// </summary>
        public static Java.Security.Cert.PKIXReason UNRECOGNIZED_CRIT_EXT { get { if (!_UNRECOGNIZED_CRIT_EXTReady) { _UNRECOGNIZED_CRIT_EXTContent = SGetField<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "UNRECOGNIZED_CRIT_EXT"); _UNRECOGNIZED_CRIT_EXTReady = true; } return _UNRECOGNIZED_CRIT_EXTContent; } }
        private static Java.Security.Cert.PKIXReason _UNRECOGNIZED_CRIT_EXTContent = default;
        private static bool _UNRECOGNIZED_CRIT_EXTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Cert.PKIXReason"/></returns>
        public static Java.Security.Cert.PKIXReason ValueOf(string arg0)
        {
            return SExecute<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXReason.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Security.Cert.PKIXReason"/></returns>
        public static Java.Security.Cert.PKIXReason[] Values()
        {
            return SExecuteArray<Java.Security.Cert.PKIXReason>(LocalBridgeClazz, "values");
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