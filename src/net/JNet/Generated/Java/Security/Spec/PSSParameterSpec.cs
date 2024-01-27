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

namespace Java.Security.Spec
{
    #region PSSParameterSpec
    public partial class PSSParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public PSSParameterSpec(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#%3Cinit%3E(java.lang.String,java.lang.String,java.security.spec.AlgorithmParameterSpec,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public PSSParameterSpec(string arg0, string arg1, Java.Security.Spec.AlgorithmParameterSpec arg2, int arg3, int arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#TRAILER_FIELD_BC"/>
        /// </summary>
        public static int TRAILER_FIELD_BC { get { if (!_TRAILER_FIELD_BCReady) { _TRAILER_FIELD_BCContent = SGetField<int>(LocalBridgeClazz, "TRAILER_FIELD_BC"); _TRAILER_FIELD_BCReady = true; } return _TRAILER_FIELD_BCContent; } }
        private static int _TRAILER_FIELD_BCContent = default;
        private static bool _TRAILER_FIELD_BCReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#DEFAULT"/>
        /// </summary>
        public static Java.Security.Spec.PSSParameterSpec DEFAULT { get { if (!_DEFAULTReady) { _DEFAULTContent = SGetField<Java.Security.Spec.PSSParameterSpec>(LocalBridgeClazz, "DEFAULT"); _DEFAULTReady = true; } return _DEFAULTContent; } }
        private static Java.Security.Spec.PSSParameterSpec _DEFAULTContent = default;
        private static bool _DEFAULTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getDigestAlgorithm()"/> 
        /// </summary>
        public string DigestAlgorithm
        {
            get { return IExecute<string>("getDigestAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getMGFAlgorithm()"/> 
        /// </summary>
        public string MGFAlgorithm
        {
            get { return IExecute<string>("getMGFAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getMGFParameters()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec MGFParameters
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getMGFParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getSaltLength()"/> 
        /// </summary>
        public int SaltLength
        {
            get { return IExecute<int>("getSaltLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/PSSParameterSpec.html#getTrailerField()"/> 
        /// </summary>
        public int TrailerField
        {
            get { return IExecute<int>("getTrailerField"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}