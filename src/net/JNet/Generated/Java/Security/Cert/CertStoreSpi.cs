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
    #region CertStoreSpi
    public partial class CertStoreSpi
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStoreSpi.html#%3Cinit%3E(java.security.cert.CertStoreParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertStoreParameters"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public CertStoreSpi(Java.Security.Cert.CertStoreParameters arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStoreSpi.html#engineGetCertificates(java.security.cert.CertSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertSelector"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_Certificate"><see cref="Java.Security.Cert.Certificate"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertStoreException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate> EngineGetCertificates<ReturnExtendsJava_Security_Cert_Certificate>(Java.Security.Cert.CertSelector arg0) where ReturnExtendsJava_Security_Cert_Certificate: Java.Security.Cert.Certificate
        {
            return IExecute<Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate>>("engineGetCertificates", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStoreSpi.html#engineGetCRLs(java.security.cert.CRLSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CRLSelector"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_CRL"><see cref="Java.Security.Cert.CRL"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertStoreException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL> EngineGetCRLs<ReturnExtendsJava_Security_Cert_CRL>(Java.Security.Cert.CRLSelector arg0) where ReturnExtendsJava_Security_Cert_CRL: Java.Security.Cert.CRL
        {
            return IExecute<Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL>>("engineGetCRLs", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}