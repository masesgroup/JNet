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
    #region PKIXBuilderParameters
    public partial class PKIXBuilderParameters
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXBuilderParameters.html#<init>(java.security.KeyStore,java.security.cert.CertSelector) throws java.security.KeyStoreException,java.security.InvalidAlgorithmParameterException
        /// </summary>
        public PKIXBuilderParameters(Java.Security.KeyStore arg0, Java.Security.Cert.CertSelector arg1)
            : base(arg0, arg1)
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXBuilderParameters.html#getMaxPathLength() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/PKIXBuilderParameters.html#setMaxPathLength(int)
        /// </summary>
        public int MaxPathLength
        {
            get { return IExecute<int>("getMaxPathLength"); } set { IExecute("setMaxPathLength", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}