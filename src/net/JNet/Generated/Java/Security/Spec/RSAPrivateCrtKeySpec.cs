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

namespace Java.Security.Spec
{
    #region RSAPrivateCrtKeySpec
    public partial class RSAPrivateCrtKeySpec
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPrivateCrtKeySpec.html#<init>(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger)
        /// </summary>
        public RSAPrivateCrtKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigInteger arg6, Java.Math.BigInteger arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPrivateCrtKeySpec.html#<init>(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.math.BigInteger,java.security.spec.AlgorithmParameterSpec)
        /// </summary>
        public RSAPrivateCrtKeySpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2, Java.Math.BigInteger arg3, Java.Math.BigInteger arg4, Java.Math.BigInteger arg5, Java.Math.BigInteger arg6, Java.Math.BigInteger arg7, Java.Security.Spec.AlgorithmParameterSpec arg8)
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPrivateCrtKeySpec.html#getCrtCoefficient() 
        /// </summary>
        public Java.Math.BigInteger CrtCoefficient
        {
            get { return IExecute<Java.Math.BigInteger>("getCrtCoefficient"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPrivateCrtKeySpec.html#getPrimeExponentP() 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentP
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeExponentP"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPrivateCrtKeySpec.html#getPrimeExponentQ() 
        /// </summary>
        public Java.Math.BigInteger PrimeExponentQ
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeExponentQ"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPrivateCrtKeySpec.html#getPrimeP() 
        /// </summary>
        public Java.Math.BigInteger PrimeP
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeP"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPrivateCrtKeySpec.html#getPrimeQ() 
        /// </summary>
        public Java.Math.BigInteger PrimeQ
        {
            get { return IExecute<Java.Math.BigInteger>("getPrimeQ"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/RSAPrivateCrtKeySpec.html#getPublicExponent() 
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