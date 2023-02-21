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
    #region XECPublicKeySpec
    public partial class XECPublicKeySpec
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/XECPublicKeySpec.html#<init>(java.security.spec.AlgorithmParameterSpec,java.math.BigInteger)
        /// </summary>
        public XECPublicKeySpec(Java.Security.Spec.AlgorithmParameterSpec arg0, Java.Math.BigInteger arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Security.Spec.KeySpec(Java.Security.Spec.XECPublicKeySpec t) => t.Cast<Java.Security.Spec.KeySpec>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/XECPublicKeySpec.html#getParams() 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec Params
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getParams"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/XECPublicKeySpec.html#getU() 
        /// </summary>
        public Java.Math.BigInteger U
        {
            get { return IExecute<Java.Math.BigInteger>("getU"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}