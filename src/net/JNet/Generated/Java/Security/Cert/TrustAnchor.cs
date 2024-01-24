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

namespace Java.Security.Cert
{
    #region TrustAnchor
    public partial class TrustAnchor
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/TrustAnchor.html#%3Cinit%3E(java.lang.String,java.security.PublicKey,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public TrustAnchor(string arg0, Java.Security.PublicKey arg1, byte[] arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/TrustAnchor.html#%3Cinit%3E(java.security.cert.X509Certificate,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.X509Certificate"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        public TrustAnchor(Java.Security.Cert.X509Certificate arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/TrustAnchor.html#%3Cinit%3E(javax.security.auth.x500.X500Principal,java.security.PublicKey,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.X500.X500Principal"/></param>
        /// <param name="arg1"><see cref="Java.Security.PublicKey"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public TrustAnchor(Javax.Security.Auth.X500.X500Principal arg0, Java.Security.PublicKey arg1, byte[] arg2)
            : base(arg0, arg1, arg2)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/TrustAnchor.html#getCA()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal CA
        {
            get { return IExecute<Javax.Security.Auth.X500.X500Principal>("getCA"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/TrustAnchor.html#getCAName()"/> 
        /// </summary>
        public string CAName
        {
            get { return IExecute<string>("getCAName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/TrustAnchor.html#getCAPublicKey()"/> 
        /// </summary>
        public Java.Security.PublicKey CAPublicKey
        {
            get { return IExecute<Java.Security.PublicKey>("getCAPublicKey"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/TrustAnchor.html#getNameConstraints()"/> 
        /// </summary>
        public byte[] NameConstraints
        {
            get { return IExecuteArray<byte>("getNameConstraints"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/TrustAnchor.html#getTrustedCert()"/> 
        /// </summary>
        public Java.Security.Cert.X509Certificate TrustedCert
        {
            get { return IExecute<Java.Security.Cert.X509Certificate>("getTrustedCert"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}