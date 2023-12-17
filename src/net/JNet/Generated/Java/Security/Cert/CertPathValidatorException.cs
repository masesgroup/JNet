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

namespace Java.Security.Cert
{
    #region CertPathValidatorException
    public partial class CertPathValidatorException
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

        #endregion

        #region Nested classes
        #region BasicReason
        public partial class BasicReason
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#ALGORITHM_CONSTRAINED"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason ALGORITHM_CONSTRAINED { get { return SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "ALGORITHM_CONSTRAINED"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#EXPIRED"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason EXPIRED { get { return SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "EXPIRED"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#INVALID_SIGNATURE"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason INVALID_SIGNATURE { get { return SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "INVALID_SIGNATURE"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#NOT_YET_VALID"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason NOT_YET_VALID { get { return SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "NOT_YET_VALID"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#REVOKED"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason REVOKED { get { return SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "REVOKED"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#UNDETERMINED_REVOCATION_STATUS"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason UNDETERMINED_REVOCATION_STATUS { get { return SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "UNDETERMINED_REVOCATION_STATUS"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#UNSPECIFIED"/>
            /// </summary>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason UNSPECIFIED { get { return SGetField<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "UNSPECIFIED"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Security.Cert.CertPathValidatorException.BasicReason"/></returns>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason ValueOf(string arg0)
            {
                return SExecute<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorException.BasicReason.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Security.Cert.CertPathValidatorException.BasicReason"/></returns>
            public static Java.Security.Cert.CertPathValidatorException.BasicReason[] Values()
            {
                return SExecuteArray<Java.Security.Cert.CertPathValidatorException.BasicReason>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Reason
        public partial class Reason
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

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}