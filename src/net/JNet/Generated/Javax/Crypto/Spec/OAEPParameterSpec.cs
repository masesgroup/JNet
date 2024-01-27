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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#%3Cinit%3E(java.lang.String,java.lang.String,java.security.spec.AlgorithmParameterSpec,javax.crypto.spec.PSource)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <param name="arg3"><see cref="Javax.Crypto.Spec.PSource"/></param>
        public OAEPParameterSpec(string arg0, string arg1, Java.Security.Spec.AlgorithmParameterSpec arg2, Javax.Crypto.Spec.PSource arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#DEFAULT"/>
        /// </summary>
        public static Javax.Crypto.Spec.OAEPParameterSpec DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<Javax.Crypto.Spec.OAEPParameterSpec>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static Javax.Crypto.Spec.OAEPParameterSpec _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#getDigestAlgorithm()"/> 
        /// </summary>
        public string DigestAlgorithm
        {
            get { return IExecute<string>("getDigestAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#getMGFAlgorithm()"/> 
        /// </summary>
        public string MGFAlgorithm
        {
            get { return IExecute<string>("getMGFAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#getMGFParameters()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec MGFParameters
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getMGFParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/spec/OAEPParameterSpec.html#getPSource()"/> 
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