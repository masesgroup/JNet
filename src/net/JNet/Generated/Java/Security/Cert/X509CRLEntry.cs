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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Cert
{
    #region X509CRLEntry
    public partial class X509CRLEntry
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getCertificateIssuer()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal CertificateIssuer
        {
            get { return IExecuteWithSignature<Javax.Security.Auth.X500.X500Principal>("getCertificateIssuer", "()Ljavax/security/auth/x500/X500Principal;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteWithSignatureArray<byte>("getEncoded", "()[B"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getRevocationDate()"/> 
        /// </summary>
        public Java.Util.Date RevocationDate
        {
            get { return IExecuteWithSignature<Java.Util.Date>("getRevocationDate", "()Ljava/util/Date;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getRevocationReason()"/> 
        /// </summary>
        public Java.Security.Cert.CRLReason RevocationReason
        {
            get { return IExecuteWithSignature<Java.Security.Cert.CRLReason>("getRevocationReason", "()Ljava/security/cert/CRLReason;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getSerialNumber()"/> 
        /// </summary>
        public Java.Math.BigInteger SerialNumber
        {
            get { return IExecuteWithSignature<Java.Math.BigInteger>("getSerialNumber", "()Ljava/math/BigInteger;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#hasExtensions()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasExtensions()
        {
            return IExecuteWithSignature<bool>("hasExtensions", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}