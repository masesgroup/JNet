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

namespace Java.Security.Spec
{
    #region ECParameterSpec
    public partial class ECParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECParameterSpec.html#%3Cinit%3E(java.security.spec.EllipticCurve,java.security.spec.ECPoint,java.math.BigInteger,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.EllipticCurve"/></param>
        /// <param name="arg1"><see cref="Java.Security.Spec.ECPoint"/></param>
        /// <param name="arg2"><see cref="Java.Math.BigInteger"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public ECParameterSpec(Java.Security.Spec.EllipticCurve arg0, Java.Security.Spec.ECPoint arg1, Java.Math.BigInteger arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECParameterSpec.html#getCofactor()"/> 
        /// </summary>
        public int Cofactor
        {
            get { return IExecute<int>("getCofactor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECParameterSpec.html#getCurve()"/> 
        /// </summary>
        public Java.Security.Spec.EllipticCurve Curve
        {
            get { return IExecute<Java.Security.Spec.EllipticCurve>("getCurve"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECParameterSpec.html#getGenerator()"/> 
        /// </summary>
        public Java.Security.Spec.ECPoint Generator
        {
            get { return IExecute<Java.Security.Spec.ECPoint>("getGenerator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/ECParameterSpec.html#getOrder()"/> 
        /// </summary>
        public Java.Math.BigInteger Order
        {
            get { return IExecute<Java.Math.BigInteger>("getOrder"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}