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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Spec
{
    #region RSAPublicKeySpec
    public partial class RSAPublicKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPublicKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        public RSAPublicKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Security.Spec.AlgorithmParameterSpec arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPublicKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        public RSAPublicKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPublicKeySpec.html#getModulus()"/> 
        /// </summary>
        public Java.Math.BigInteger Modulus
        {
            get { return IExecute<Java.Math.BigInteger>("getModulus"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPublicKeySpec.html#getParams()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec Params
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getParams"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPublicKeySpec.html#getPublicExponent()"/> 
        /// </summary>
        public Java.Math.BigInteger PublicExponent
        {
            get { return IExecute<Java.Math.BigInteger>("getPublicExponent"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}