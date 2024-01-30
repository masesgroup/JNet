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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#%3Cinit%3E(java.security.KeyStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.KeyStore"/></param>
        /// <exception cref="Java.Security.KeyStoreException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public PKIXParameters(Java.Security.KeyStore arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#%3Cinit%3E(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public PKIXParameters(Java.Util.Set<Java.Security.Cert.TrustAnchor> arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getCertPathCheckers()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setCertPathCheckers(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Security.Cert.PKIXCertPathChecker> CertPathCheckers
        {
            get { return IExecute<Java.Util.List<Java.Security.Cert.PKIXCertPathChecker>>("getCertPathCheckers"); } set { IExecute("setCertPathCheckers", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getCertStores()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setCertStores(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Security.Cert.CertStore> CertStores
        {
            get { return IExecute<Java.Util.List<Java.Security.Cert.CertStore>>("getCertStores"); } set { IExecute("setCertStores", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getDate()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setDate(java.util.Date)"/>
        /// </summary>
        public Java.Util.Date Date
        {
            get { return IExecute<Java.Util.Date>("getDate"); } set { IExecute("setDate", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getInitialPolicies()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setInitialPolicies(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<string> InitialPolicies
        {
            get { return IExecute<Java.Util.Set<string>>("getInitialPolicies"); } set { IExecute("setInitialPolicies", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getPolicyQualifiersRejected()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setPolicyQualifiersRejected(boolean)"/>
        /// </summary>
        public bool PolicyQualifiersRejected
        {
            get { return IExecute<bool>("getPolicyQualifiersRejected"); } set { IExecute("setPolicyQualifiersRejected", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getSigProvider()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setSigProvider(java.lang.String)"/>
        /// </summary>
        public string SigProvider
        {
            get { return IExecute<string>("getSigProvider"); } set { IExecute("setSigProvider", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getTargetCertConstraints()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setTargetCertConstraints(java.security.cert.CertSelector)"/>
        /// </summary>
        public Java.Security.Cert.CertSelector TargetCertConstraints
        {
            get { return IExecute<Java.Security.Cert.CertSelector>("getTargetCertConstraints"); } set { IExecute("setTargetCertConstraints", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#getTrustAnchors()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setTrustAnchors(java.util.Set)"/>
        /// </summary>
        public Java.Util.Set<Java.Security.Cert.TrustAnchor> TrustAnchors
        {
            get { return IExecute<Java.Util.Set<Java.Security.Cert.TrustAnchor>>("getTrustAnchors"); } set { IExecute("setTrustAnchors", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isAnyPolicyInhibited()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAnyPolicyInhibited()
        {
            return IExecute<bool>("isAnyPolicyInhibited");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isExplicitPolicyRequired()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsExplicitPolicyRequired()
        {
            return IExecute<bool>("isExplicitPolicyRequired");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isPolicyMappingInhibited()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPolicyMappingInhibited()
        {
            return IExecute<bool>("isPolicyMappingInhibited");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#isRevocationEnabled()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsRevocationEnabled()
        {
            return IExecute<bool>("isRevocationEnabled");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#addCertPathChecker(java.security.cert.PKIXCertPathChecker)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.PKIXCertPathChecker"/></param>
        public void AddCertPathChecker(Java.Security.Cert.PKIXCertPathChecker arg0)
        {
            IExecute("addCertPathChecker", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#addCertStore(java.security.cert.CertStore)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertStore"/></param>
        public void AddCertStore(Java.Security.Cert.CertStore arg0)
        {
            IExecute("addCertStore", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setAnyPolicyInhibited(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAnyPolicyInhibited(bool arg0)
        {
            IExecute("setAnyPolicyInhibited", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setExplicitPolicyRequired(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetExplicitPolicyRequired(bool arg0)
        {
            IExecute("setExplicitPolicyRequired", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setPolicyMappingInhibited(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetPolicyMappingInhibited(bool arg0)
        {
            IExecute("setPolicyMappingInhibited", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXParameters.html#setRevocationEnabled(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
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