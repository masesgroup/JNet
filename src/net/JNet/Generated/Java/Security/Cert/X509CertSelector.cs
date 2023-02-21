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
    #region X509CertSelector
    public partial class X509CertSelector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Security.Cert.CertSelector(Java.Security.Cert.X509CertSelector t) => t.Cast<Java.Security.Cert.CertSelector>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getAuthorityKeyIdentifier() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setAuthorityKeyIdentifier(byte[])
        /// </summary>
        public byte[] AuthorityKeyIdentifier
        {
            get { return IExecuteArray<byte>("getAuthorityKeyIdentifier"); } set { IExecute("setAuthorityKeyIdentifier", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getBasicConstraints() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setBasicConstraints(int)
        /// </summary>
        public int BasicConstraints
        {
            get { return IExecute<int>("getBasicConstraints"); } set { IExecute("setBasicConstraints", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getCertificate() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setCertificate(java.security.cert.X509Certificate)
        /// </summary>
        public Java.Security.Cert.X509Certificate Certificate
        {
            get { return IExecute<Java.Security.Cert.X509Certificate>("getCertificate"); } set { IExecute("setCertificate", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getCertificateValid() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setCertificateValid(java.util.Date)
        /// </summary>
        public Java.Util.Date CertificateValid
        {
            get { return IExecute<Java.Util.Date>("getCertificateValid"); } set { IExecute("setCertificateValid", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuer() 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal Issuer
        {
            get { return IExecute<Javax.Security.Auth.X500.X500Principal>("getIssuer"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuerAsBytes() throws java.io.IOException 
        /// </summary>
        public byte[] IssuerAsBytes
        {
            get { return IExecuteArray<byte>("getIssuerAsBytes"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getIssuerAsString() 
        /// </summary>
        public string IssuerAsString
        {
            get { return IExecute<string>("getIssuerAsString"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getKeyUsage() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setKeyUsage(boolean[])
        /// </summary>
        public bool[] KeyUsage
        {
            get { return IExecuteArray<bool>("getKeyUsage"); } set { IExecute("setKeyUsage", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getMatchAllSubjectAltNames() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setMatchAllSubjectAltNames(boolean)
        /// </summary>
        public bool MatchAllSubjectAltNames
        {
            get { return IExecute<bool>("getMatchAllSubjectAltNames"); } set { IExecute("setMatchAllSubjectAltNames", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getNameConstraints() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setNameConstraints(byte[]) throws java.io.IOException
        /// </summary>
        public byte[] NameConstraints
        {
            get { return IExecuteArray<byte>("getNameConstraints"); } set { IExecute("setNameConstraints", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getPrivateKeyValid() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setPrivateKeyValid(java.util.Date)
        /// </summary>
        public Java.Util.Date PrivateKeyValid
        {
            get { return IExecute<Java.Util.Date>("getPrivateKeyValid"); } set { IExecute("setPrivateKeyValid", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSerialNumber() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSerialNumber(java.math.BigInteger)
        /// </summary>
        public Java.Math.BigInteger SerialNumber
        {
            get { return IExecute<Java.Math.BigInteger>("getSerialNumber"); } set { IExecute("setSerialNumber", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubject() 
        /// </summary>
        public Javax.Security.Auth.X500.X500Principal Subject
        {
            get { return IExecute<Javax.Security.Auth.X500.X500Principal>("getSubject"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectAsBytes() throws java.io.IOException 
        /// </summary>
        public byte[] SubjectAsBytes
        {
            get { return IExecuteArray<byte>("getSubjectAsBytes"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectAsString() 
        /// </summary>
        public string SubjectAsString
        {
            get { return IExecute<string>("getSubjectAsString"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectKeyIdentifier() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectKeyIdentifier(byte[])
        /// </summary>
        public byte[] SubjectKeyIdentifier
        {
            get { return IExecuteArray<byte>("getSubjectKeyIdentifier"); } set { IExecute("setSubjectKeyIdentifier", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectPublicKey() 
        /// </summary>
        public Java.Security.PublicKey SubjectPublicKey
        {
            get { return IExecute<Java.Security.PublicKey>("getSubjectPublicKey"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#getSubjectPublicKeyAlgID() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKeyAlgID(java.lang.String) throws java.io.IOException
        /// </summary>
        public string SubjectPublicKeyAlgID
        {
            get { return IExecute<string>("getSubjectPublicKeyAlgID"); } set { IExecute("setSubjectPublicKeyAlgID", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#match(java.security.cert.Certificate)
        /// </summary>
        public bool Match(Java.Security.Cert.Certificate arg0)
        {
            return IExecute<bool>("match", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addPathToName(int,byte[]) throws java.io.IOException
        /// </summary>
        public void AddPathToName(int arg0, byte[] arg1)
        {
            IExecute("addPathToName", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addPathToName(int,java.lang.String) throws java.io.IOException
        /// </summary>
        public void AddPathToName(int arg0, string arg1)
        {
            IExecute("addPathToName", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addSubjectAlternativeName(int,byte[]) throws java.io.IOException
        /// </summary>
        public void AddSubjectAlternativeName(int arg0, byte[] arg1)
        {
            IExecute("addSubjectAlternativeName", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#addSubjectAlternativeName(int,java.lang.String) throws java.io.IOException
        /// </summary>
        public void AddSubjectAlternativeName(int arg0, string arg1)
        {
            IExecute("addSubjectAlternativeName", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(byte[]) throws java.io.IOException
        /// </summary>
        public void SetIssuer(byte[] arg0)
        {
            IExecute("setIssuer", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(java.lang.String) throws java.io.IOException
        /// </summary>
        public void SetIssuer(string arg0)
        {
            IExecute("setIssuer", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setIssuer(javax.security.auth.x500.X500Principal)
        /// </summary>
        public void SetIssuer(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecute("setIssuer", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(byte[]) throws java.io.IOException
        /// </summary>
        public void SetSubject(byte[] arg0)
        {
            IExecute("setSubject", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(java.lang.String) throws java.io.IOException
        /// </summary>
        public void SetSubject(string arg0)
        {
            IExecute("setSubject", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubject(javax.security.auth.x500.X500Principal)
        /// </summary>
        public void SetSubject(Javax.Security.Auth.X500.X500Principal arg0)
        {
            IExecute("setSubject", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKey(byte[]) throws java.io.IOException
        /// </summary>
        public void SetSubjectPublicKey(byte[] arg0)
        {
            IExecute("setSubjectPublicKey", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/X509CertSelector.html#setSubjectPublicKey(java.security.PublicKey)
        /// </summary>
        public void SetSubjectPublicKey(Java.Security.PublicKey arg0)
        {
            IExecute("setSubjectPublicKey", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}