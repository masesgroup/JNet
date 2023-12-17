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
    #region CertStore
    public partial class CertStore
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getDefaultType()"/> 
        /// </summary>
        public static string DefaultType
        {
            get { return SExecute<string>(LocalBridgeClazz, "getDefaultType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getInstance(java.lang.String,java.security.cert.CertStoreParameters,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.CertStoreParameters"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Cert.CertStore"/></returns>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.Cert.CertStore GetInstance(string arg0, Java.Security.Cert.CertStoreParameters arg1, string arg2)
        {
            return SExecute<Java.Security.Cert.CertStore>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getInstance(java.lang.String,java.security.cert.CertStoreParameters,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.CertStoreParameters"/></param>
        /// <param name="arg2"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.Cert.CertStore"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public static Java.Security.Cert.CertStore GetInstance(string arg0, Java.Security.Cert.CertStoreParameters arg1, Java.Security.Provider arg2)
        {
            return SExecute<Java.Security.Cert.CertStore>(LocalBridgeClazz, "getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getInstance(java.lang.String,java.security.cert.CertStoreParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.CertStoreParameters"/></param>
        /// <returns><see cref="Java.Security.Cert.CertStore"/></returns>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Cert.CertStore GetInstance(string arg0, Java.Security.Cert.CertStoreParameters arg1)
        {
            return SExecute<Java.Security.Cert.CertStore>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getCertStoreParameters()"/> 
        /// </summary>
        public Java.Security.Cert.CertStoreParameters CertStoreParameters
        {
            get { return IExecute<Java.Security.Cert.CertStoreParameters>("getCertStoreParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecute<Java.Security.Provider>("getProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getType()"/> 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getCertificates(java.security.cert.CertSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertSelector"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_Certificate"><see cref="Java.Security.Cert.Certificate"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertStoreException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate> GetCertificates<ReturnExtendsJava_Security_Cert_Certificate>(Java.Security.Cert.CertSelector arg0) where ReturnExtendsJava_Security_Cert_Certificate: Java.Security.Cert.Certificate
        {
            return IExecute<Java.Util.Collection<ReturnExtendsJava_Security_Cert_Certificate>>("getCertificates", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getCRLs(java.security.cert.CRLSelector)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CRLSelector"/></param>
        /// <typeparam name="ReturnExtendsJava_Security_Cert_CRL"><see cref="Java.Security.Cert.CRL"/></typeparam>
        /// <returns><see cref="Java.Util.Collection"/></returns>
        /// <exception cref="Java.Security.Cert.CertStoreException"/>
        public Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL> GetCRLs<ReturnExtendsJava_Security_Cert_CRL>(Java.Security.Cert.CRLSelector arg0) where ReturnExtendsJava_Security_Cert_CRL: Java.Security.Cert.CRL
        {
            return IExecute<Java.Util.Collection<ReturnExtendsJava_Security_Cert_CRL>>("getCRLs", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}