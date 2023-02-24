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
    #region X509Certificate
    public partial class X509Certificate
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Cert.X509Certificate"/> to <see cref="Java.Security.Cert.X509Extension"/>
        /// </summary>
        public static implicit operator Java.Security.Cert.X509Extension(Java.Security.Cert.X509Certificate t) => t.Cast<Java.Security.Cert.X509Extension>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getBasicConstraints()"/> 
        /// </summary>
        public int BasicConstraints
        {
            get { return IExecute<int>("getBasicConstraints"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getIssuerDN()"/> 
        /// </summary>
        public Java.Security.Principal IssuerDN
        {
            get { return IExecute<Java.Security.Principal>("getIssuerDN"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getIssuerUniqueID()"/> 
        /// </summary>
        public bool[] IssuerUniqueID
        {
            get { return IExecuteArray<bool>("getIssuerUniqueID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getIssuerX500Principal()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal IssuerX500Principal
        {
            get { return IExecute<Javax.Security.Auth.X500.X500Principal>("getIssuerX500Principal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getKeyUsage()"/> 
        /// </summary>
        public bool[] KeyUsage
        {
            get { return IExecuteArray<bool>("getKeyUsage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getNotAfter()"/> 
        /// </summary>
        public Java.Util.Date NotAfter
        {
            get { return IExecute<Java.Util.Date>("getNotAfter"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getNotBefore()"/> 
        /// </summary>
        public Java.Util.Date NotBefore
        {
            get { return IExecute<Java.Util.Date>("getNotBefore"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getSerialNumber()"/> 
        /// </summary>
        public Java.Math.BigInteger SerialNumber
        {
            get { return IExecute<Java.Math.BigInteger>("getSerialNumber"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getSigAlgName()"/> 
        /// </summary>
        public string SigAlgName
        {
            get { return IExecute<string>("getSigAlgName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getSigAlgOID()"/> 
        /// </summary>
        public string SigAlgOID
        {
            get { return IExecute<string>("getSigAlgOID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getSigAlgParams()"/> 
        /// </summary>
        public byte[] SigAlgParams
        {
            get { return IExecuteArray<byte>("getSigAlgParams"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getSignature()"/> 
        /// </summary>
        public byte[] Signature
        {
            get { return IExecuteArray<byte>("getSignature"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getSubjectDN()"/> 
        /// </summary>
        public Java.Security.Principal SubjectDN
        {
            get { return IExecute<Java.Security.Principal>("getSubjectDN"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getSubjectUniqueID()"/> 
        /// </summary>
        public bool[] SubjectUniqueID
        {
            get { return IExecuteArray<bool>("getSubjectUniqueID"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getSubjectX500Principal()"/> 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal SubjectX500Principal
        {
            get { return IExecute<Javax.Security.Auth.X500.X500Principal>("getSubjectX500Principal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getTBSCertificate()"/> 
        /// </summary>
        public byte[] TBSCertificate
        {
            get { return IExecuteArray<byte>("getTBSCertificate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#getVersion()"/> 
        /// </summary>
        public int Version
        {
            get { return IExecute<int>("getVersion"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#checkValidity()"/>
        /// </summary>
        
        /// <exception cref="Java.Security.Cert.CertificateExpiredException"/>
        /// <exception cref="Java.Security.Cert.CertificateNotYetValidException"/>
        public void CheckValidity()
        {
            IExecute("checkValidity");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509Certificate.html#checkValidity(java.util.Date)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Date"/></param>
        /// <exception cref="Java.Security.Cert.CertificateExpiredException"/>
        /// <exception cref="Java.Security.Cert.CertificateNotYetValidException"/>
        public void CheckValidity(Java.Util.Date arg0)
        {
            IExecute("checkValidity", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}