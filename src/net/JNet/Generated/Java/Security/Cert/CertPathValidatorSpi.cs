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
    #region CertPathValidatorSpi
    public partial class CertPathValidatorSpi
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorSpi.html#engineValidate(java.security.cert.CertPath,java.security.cert.CertPathParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Cert.CertPath"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.CertPathParameters"/></param>
        /// <returns><see cref="Java.Security.Cert.CertPathValidatorResult"/></returns>
        /// <exception cref="Java.Security.Cert.CertPathValidatorException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public Java.Security.Cert.CertPathValidatorResult EngineValidate(Java.Security.Cert.CertPath arg0, Java.Security.Cert.CertPathParameters arg1)
        {
            return IExecute<Java.Security.Cert.CertPathValidatorResult>("engineValidate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPathValidatorSpi.html#engineGetRevocationChecker()"/>
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