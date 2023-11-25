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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region PKIXRevocationChecker
    public partial class PKIXRevocationChecker
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOcspExtensions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOcspExtensions(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Security.Cert.Extension> OcspExtensions
        {
            get { return IExecute<Java.Util.List<Java.Security.Cert.Extension>>("getOcspExtensions"); } set { IExecute("setOcspExtensions", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOcspResponder()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOcspResponder(java.net.URI)"/>
        /// </summary>
        public Java.Net.URI OcspResponder
        {
            get { return IExecute<Java.Net.URI>("getOcspResponder"); } set { IExecute("setOcspResponder", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOcspResponderCert()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOcspResponderCert(java.security.cert.X509Certificate)"/>
        /// </summary>
        public Java.Security.Cert.X509Certificate OcspResponderCert
        {
            get { return IExecute<Java.Security.Cert.X509Certificate>("getOcspResponderCert"); } set { IExecute("setOcspResponderCert", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOcspResponses()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOcspResponses(java.util.Map)"/>
        /// </summary>
        public Java.Util.Map<Java.Security.Cert.X509Certificate, byte[]> OcspResponses
        {
            get { return IExecute<Java.Util.Map<Java.Security.Cert.X509Certificate, byte[]>>("getOcspResponses"); } set { IExecute("setOcspResponses", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getOptions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#setOptions(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<Java.Security.Cert.PKIXRevocationChecker.Option> Options
        {
            get { return IExecute<Java.Util.Set<Java.Security.Cert.PKIXRevocationChecker.Option>>("getOptions"); } set { IExecute("setOptions", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.html#getSoftFailExceptions()"/> 
        /// </summary>
        public Java.Util.List<Java.Security.Cert.CertPathValidatorException> SoftFailExceptions
        {
            get { return IExecute<Java.Util.List<Java.Security.Cert.CertPathValidatorException>>("getSoftFailExceptions"); }
        }

        #endregion

        #region Nested classes
        #region Option
        public partial class Option
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#NO_FALLBACK"/>
            /// </summary>
            public static Java.Security.Cert.PKIXRevocationChecker.Option NO_FALLBACK { get { return SGetField<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "NO_FALLBACK"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#ONLY_END_ENTITY"/>
            /// </summary>
            public static Java.Security.Cert.PKIXRevocationChecker.Option ONLY_END_ENTITY { get { return SGetField<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "ONLY_END_ENTITY"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#PREFER_CRLS"/>
            /// </summary>
            public static Java.Security.Cert.PKIXRevocationChecker.Option PREFER_CRLS { get { return SGetField<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "PREFER_CRLS"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#SOFT_FAIL"/>
            /// </summary>
            public static Java.Security.Cert.PKIXRevocationChecker.Option SOFT_FAIL { get { return SGetField<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "SOFT_FAIL"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Security.Cert.PKIXRevocationChecker.Option"/></returns>
            public static Java.Security.Cert.PKIXRevocationChecker.Option ValueOf(string arg0)
            {
                return SExecute<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXRevocationChecker.Option.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Security.Cert.PKIXRevocationChecker.Option"/></returns>
            public static Java.Security.Cert.PKIXRevocationChecker.Option[] Values()
            {
                return SExecuteArray<Java.Security.Cert.PKIXRevocationChecker.Option>(LocalBridgeClazz, "values");
            }

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