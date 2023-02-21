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
    #region OAEPParameterSpec
    public partial class OAEPParameterSpec
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#<init>(java.lang.String,java.lang.String,java.security.spec.AlgorithmParameterSpec,javax.crypto.spec.PSource)
        /// </summary>
        public OAEPParameterSpec(string arg0, string arg1, Java.Security.Spec.AlgorithmParameterSpec arg2, Javax.Crypto.Spec.PSource arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Security.Spec.AlgorithmParameterSpec(Javax.Crypto.Spec.OAEPParameterSpec t) => t.Cast<Java.Security.Spec.AlgorithmParameterSpec>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#DEFAULT
        /// </summary>
        public static Javax.Crypto.Spec.OAEPParameterSpec DEFAULT => Clazz.GetField<Javax.Crypto.Spec.OAEPParameterSpec>("DEFAULT");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#getDigestAlgorithm() 
        /// </summary>
        public string DigestAlgorithm
        {
            get { return IExecute<string>("getDigestAlgorithm"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#getMGFAlgorithm() 
        /// </summary>
        public string MGFAlgorithm
        {
            get { return IExecute<string>("getMGFAlgorithm"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#getMGFParameters() 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec MGFParameters
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getMGFParameters"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#getPSource() 
        /// </summary>
        public Javax.Crypto.Spec.PSource PSource
        {
            get { return IExecute<Javax.Crypto.Spec.PSource>("getPSource"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}