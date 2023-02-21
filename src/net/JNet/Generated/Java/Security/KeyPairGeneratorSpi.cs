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

namespace Java.Security
{
    #region KeyPairGeneratorSpi
    public partial class KeyPairGeneratorSpi
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGeneratorSpi.html#generateKeyPair()
        /// </summary>
        public Java.Security.KeyPair GenerateKeyPair()
        {
            return IExecute<Java.Security.KeyPair>("generateKeyPair");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGeneratorSpi.html#initialize(int,java.security.SecureRandom)
        /// </summary>
        public void Initialize(int arg0, Java.Security.SecureRandom arg1)
        {
            IExecute("initialize", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyPairGeneratorSpi.html#initialize(java.security.spec.AlgorithmParameterSpec,java.security.SecureRandom) throws java.security.InvalidAlgorithmParameterException
        /// </summary>
        public void Initialize(Java.Security.Spec.AlgorithmParameterSpec arg0, Java.Security.SecureRandom arg1)
        {
            IExecute("initialize", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}