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
    #region CertPathBuilder
    public partial class CertPathBuilder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilder.html#getDefaultType()"/> 
        /// </summary>
        public static string DefaultType
        {
            get { return SExecute<string>(LocalBridgeClazz, "getDefaultType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilder.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPathBuilder"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.Cert.CertPathBuilder GetInstance(string arg0, string arg1)
        {
            return SExecute<Java.Security.Cert.CertPathBuilder>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilder.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPathBuilder"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Cert.CertPathBuilder GetInstance(string arg0, Java.Security.Provider arg1)
        {
            return SExecute<Java.Security.Cert.CertPathBuilder>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilder.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPathBuilder"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Cert.CertPathBuilder GetInstance(string arg0)
        {
            return SExecute<Java.Security.Cert.CertPathBuilder>(LocalBridgeClazz, "getInstance", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilder.html#getAlgorithm()"/> 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilder.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecute<Java.Security.Provider>("getProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilder.html#getRevocationChecker()"/> 
        /// </summary>
        public Java.Security.Cert.CertPathChecker RevocationChecker
        {
            get { return IExecute<Java.Security.Cert.CertPathChecker>("getRevocationChecker"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilder.html#build(java.security.cert.CertPathParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertPathParameters"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPathBuilderResult"/></returns>
        /// <exception cref="Java.Security.Cert.CertPathBuilderException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Java.Security.Cert.CertPathBuilderResult Build(Java.Security.Cert.CertPathParameters arg0)
        {
            return IExecute<Java.Security.Cert.CertPathBuilderResult>("build", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}