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
    #region PKIXParameters
    public partial class PKIXParameters
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#<init>(java.security.KeyStore) throws java.security.KeyStoreException,java.security.InvalidAlgorithmParameterException
        /// </summary>
        public PKIXParameters(Java.Security.KeyStore arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Security.Cert.CertPathParameters(Java.Security.Cert.PKIXParameters t) => t.Cast<Java.Security.Cert.CertPathParameters>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getDate() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setDate(java.util.Date)
        /// </summary>
        public Java.Util.Date Date
        {
            get { return IExecute<Java.Util.Date>("getDate"); } set { IExecute("setDate", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getPolicyQualifiersRejected() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setPolicyQualifiersRejected(boolean)
        /// </summary>
        public bool PolicyQualifiersRejected
        {
            get { return IExecute<bool>("getPolicyQualifiersRejected"); } set { IExecute("setPolicyQualifiersRejected", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getSigProvider() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setSigProvider(java.lang.String)
        /// </summary>
        public string SigProvider
        {
            get { return IExecute<string>("getSigProvider"); } set { IExecute("setSigProvider", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getTargetCertConstraints() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setTargetCertConstraints(java.security.cert.CertSelector)
        /// </summary>
        public Java.Security.Cert.CertSelector TargetCertConstraints
        {
            get { return IExecute<Java.Security.Cert.CertSelector>("getTargetCertConstraints"); } set { IExecute("setTargetCertConstraints", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isAnyPolicyInhibited()
        /// </summary>
        public bool IsAnyPolicyInhibited()
        {
            return IExecute<bool>("isAnyPolicyInhibited");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isExplicitPolicyRequired()
        /// </summary>
        public bool IsExplicitPolicyRequired()
        {
            return IExecute<bool>("isExplicitPolicyRequired");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isPolicyMappingInhibited()
        /// </summary>
        public bool IsPolicyMappingInhibited()
        {
            return IExecute<bool>("isPolicyMappingInhibited");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isRevocationEnabled()
        /// </summary>
        public bool IsRevocationEnabled()
        {
            return IExecute<bool>("isRevocationEnabled");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#addCertPathChecker(java.security.cert.PKIXCertPathChecker)
        /// </summary>
        public void AddCertPathChecker(Java.Security.Cert.PKIXCertPathChecker arg0)
        {
            IExecute("addCertPathChecker", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#addCertStore(java.security.cert.CertStore)
        /// </summary>
        public void AddCertStore(Java.Security.Cert.CertStore arg0)
        {
            IExecute("addCertStore", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setAnyPolicyInhibited(boolean)
        /// </summary>
        public void SetAnyPolicyInhibited(bool arg0)
        {
            IExecute("setAnyPolicyInhibited", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setExplicitPolicyRequired(boolean)
        /// </summary>
        public void SetExplicitPolicyRequired(bool arg0)
        {
            IExecute("setExplicitPolicyRequired", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setPolicyMappingInhibited(boolean)
        /// </summary>
        public void SetPolicyMappingInhibited(bool arg0)
        {
            IExecute("setPolicyMappingInhibited", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setRevocationEnabled(boolean)
        /// </summary>
        public void SetRevocationEnabled(bool arg0)
        {
            IExecute("setRevocationEnabled", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}