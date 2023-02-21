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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getDefaultType() 
        /// </summary>
        public static string DefaultType
        {
            get { return SExecute<string>("getDefaultType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getInstance(java.lang.String,java.security.cert.CertStoreParameters,java.lang.String) throws java.security.InvalidAlgorithmParameterException,java.security.NoSuchAlgorithmException,java.security.NoSuchProviderException
        /// </summary>
        public static Java.Security.Cert.CertStore GetInstance(string arg0, Java.Security.Cert.CertStoreParameters arg1, string arg2)
        {
            return SExecute<Java.Security.Cert.CertStore>("getInstance", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getInstance(java.lang.String,java.security.cert.CertStoreParameters) throws java.security.InvalidAlgorithmParameterException,java.security.NoSuchAlgorithmException
        /// </summary>
        public static Java.Security.Cert.CertStore GetInstance(string arg0, Java.Security.Cert.CertStoreParameters arg1)
        {
            return SExecute<Java.Security.Cert.CertStore>("getInstance", arg0, arg1);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getCertStoreParameters() 
        /// </summary>
        public Java.Security.Cert.CertStoreParameters CertStoreParameters
        {
            get { return IExecute<Java.Security.Cert.CertStoreParameters>("getCertStoreParameters"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertStore.html#getType() 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}