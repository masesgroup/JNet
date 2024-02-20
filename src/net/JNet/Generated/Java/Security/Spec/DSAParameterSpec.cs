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

namespace Java.Security.Spec
{
    #region DSAParameterSpec
    public partial class DSAParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/DSAParameterSpec.html#%3Cinit%3E(java.math.BigInteger,java.math.BigInteger,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        public DSAParameterSpec(Java.Math.BigInteger arg0, Java.Math.BigInteger arg1, Java.Math.BigInteger arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Security.Spec.DSAParameterSpec"/> to <see cref="Java.Security.Spec.AlgorithmParameterSpec"/>
        /// </summary>
        public static implicit operator Java.Security.Spec.AlgorithmParameterSpec(Java.Security.Spec.DSAParameterSpec t) => t.Cast<Java.Security.Spec.AlgorithmParameterSpec>();
        /// <summary>
        /// Converter from <see cref="Java.Security.Spec.DSAParameterSpec"/> to <see cref="Java.Security.Interfaces.DSAParams"/>
        /// </summary>
        public static implicit operator Java.Security.Interfaces.DSAParams(Java.Security.Spec.DSAParameterSpec t) => t.Cast<Java.Security.Interfaces.DSAParams>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/DSAParameterSpec.html#getG()"/> 
        /// </summary>
        public Java.Math.BigInteger G
        {
            get { return IExecute<Java.Math.BigInteger>("getG"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/DSAParameterSpec.html#getP()"/> 
        /// </summary>
        public Java.Math.BigInteger P
        {
            get { return IExecute<Java.Math.BigInteger>("getP"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/DSAParameterSpec.html#getQ()"/> 
        /// </summary>
        public Java.Math.BigInteger Q
        {
            get { return IExecute<Java.Math.BigInteger>("getQ"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}