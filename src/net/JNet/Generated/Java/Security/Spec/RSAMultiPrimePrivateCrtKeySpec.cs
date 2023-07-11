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
    #region RSAMultiPrimePrivateCrtKeySpec
    public partial class RSAMultiPrimePrivateCrtKeySpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.security.spec.RSAOtherPrimeInfo[],java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg4"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg5"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg6"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg7"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg8"><see cref="Java.Security.Spec.RSAOtherPrimeInfo"/></param>
        /// <param name="arg9"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        public RSAMultiPrimePrivateCrtKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigInteger arg6, Java.Math.BigInteger arg7, Java.Security.Spec.RSAOtherPrimeInfo[] arg8, Java.Security.Spec.AlgorithmParameterSpec arg9)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.security.spec.RSAOtherPrimeInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg4"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg5"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg6"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg7"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg8"><see cref="Java.Security.Spec.RSAOtherPrimeInfo"/></param>
        public RSAMultiPrimePrivateCrtKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigInteger arg6, Java.Math.BigInteger arg7, Java.Security.Spec.RSAOtherPrimeInfo[] arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getCrtCoefficient()"/> 
        /// </summary>
        public Java.Math.BigInteger CrtCoefficient
        {
            get { return IExecute<Java.Math.BigInteger>("getCrtCoefficient"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getOtherPrimeInfo()"/> 
        /// </summary>
        public Java.Security.Spec.RSAOtherPrimeInfo[] OtherPrimeInfo
        {
            get { return IExecuteArray<Java.Security.Spec.RSAOtherPrimeInfo>("getOtherPrimeInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPrimeExponentP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentP
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeExponentP"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPrimeExponentQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentQ
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeExponentQ"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPrimeP()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeP
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeP"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPrimeQ()"/> 
        /// </summary>
        public Java.Math.BigInteger PrimeQ
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeQ"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAMultiPrimePrivateCrtKeySpec.html#getPublicExponent()"/> 
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