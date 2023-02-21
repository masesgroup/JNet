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

namespace Javax.Crypto.Spec
{
    #region DHParameterSpec
    public partial class DHParameterSpec
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHParameterSpec.html#<init>(java.math.BigInteger,java.math.BigInteger)
        /// </summary>
        public DHParameterSpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHParameterSpec.html#<init>(java.math.BigInteger,java.math.BigInteger,int)
        /// </summary>
        public DHParameterSpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Security.Spec.AlgorithmParameterSpec(Javax.Crypto.Spec.DHParameterSpec t) => t.Cast<Java.Security.Spec.AlgorithmParameterSpec>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHParameterSpec.html#getG() 
        /// </summary>
        public Java.Math.BigInteger G
        {
            get { return IExecute<Java.Math.BigInteger>("getG"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHParameterSpec.html#getL() 
        /// </summary>
        public int L
        {
            get { return IExecute<int>("getL"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/DHParameterSpec.html#getP() 
        /// </summary>
        public Java.Math.BigInteger P
        {
            get { return IExecute<Java.Math.BigInteger>("getP"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}