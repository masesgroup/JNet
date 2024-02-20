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
    #region CertPathBuilderSpi
    public partial class CertPathBuilderSpi
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilderSpi.html#engineBuild(java.security.cert.CertPathParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertPathParameters"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPathBuilderResult"/></returns>
        /// <exception cref="Java.Security.Cert.CertPathBuilderException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Java.Security.Cert.CertPathBuilderResult EngineBuild(Java.Security.Cert.CertPathParameters arg0)
        {
            return IExecute<Java.Security.Cert.CertPathBuilderResult>("engineBuild", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathBuilderSpi.html#engineGetRevocationChecker()"/>
        /// </summary>

        /// <returns><see cref="Java.Security.Cert.CertPathChecker"/></returns>
        public Java.Security.Cert.CertPathChecker EngineGetRevocationChecker()
        {
            return IExecute<Java.Security.Cert.CertPathChecker>("engineGetRevocationChecker");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}