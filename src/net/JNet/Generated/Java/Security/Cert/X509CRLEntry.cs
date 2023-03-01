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
    #region X509CRLEntry
    public partial class X509CRLEntry
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.X509CRLEntry"/> to <see cref="Java.Security.Cert.X509Extension"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.X509Extension(Java.Security.Cert.X509CRLEntry t) => t.Cast<Java.Security.Cert.X509Extension>();
        
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
            get { return IExecute<Javax.Security.Auth.X500.X500Principal>("getCertificateIssuer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteArray<byte>("getEncoded"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getRevocationDate()"/> 
        /// </summary>
        public Java.Util.Date RevocationDate
        {
            get { return IExecute<Java.Util.Date>("getRevocationDate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getRevocationReason()"/> 
        /// </summary>
        public Java.Security.Cert.CRLReason RevocationReason
        {
            get { return IExecute<Java.Security.Cert.CRLReason>("getRevocationReason"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#getSerialNumber()"/> 
        /// </summary>
        public Java.Math.BigInteger SerialNumber
        {
            get { return IExecute<Java.Math.BigInteger>("getSerialNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CRLEntry.html#hasExtensions()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasExtensions()
        {
            return IExecute<bool>("hasExtensions");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}