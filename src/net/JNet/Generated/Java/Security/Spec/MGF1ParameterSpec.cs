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
    #region MGF1ParameterSpec
    public partial class MGF1ParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public MGF1ParameterSpec(string arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA1"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA1 { get { if (!_SHA1Ready) { _SHA1Content = SGetField<Java.Security.Spec.MGF1ParameterSpec>(LocalBridgeClazz, "SHA1"); _SHA1Ready = true; } return _SHA1Content; } }
        private static Java.Security.Spec.MGF1ParameterSpec _SHA1Content = default;
        private static bool _SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA224"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA224 { get { if (!_SHA224Ready) { _SHA224Content = SGetField<Java.Security.Spec.MGF1ParameterSpec>(LocalBridgeClazz, "SHA224"); _SHA224Ready = true; } return _SHA224Content; } }
        private static Java.Security.Spec.MGF1ParameterSpec _SHA224Content = default;
        private static bool _SHA224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA256"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA256 { get { if (!_SHA256Ready) { _SHA256Content = SGetField<Java.Security.Spec.MGF1ParameterSpec>(LocalBridgeClazz, "SHA256"); _SHA256Ready = true; } return _SHA256Content; } }
        private static Java.Security.Spec.MGF1ParameterSpec _SHA256Content = default;
        private static bool _SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA384"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA384 { get { if (!_SHA384Ready) { _SHA384Content = SGetField<Java.Security.Spec.MGF1ParameterSpec>(LocalBridgeClazz, "SHA384"); _SHA384Ready = true; } return _SHA384Content; } }
        private static Java.Security.Spec.MGF1ParameterSpec _SHA384Content = default;
        private static bool _SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA512"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA512 { get { if (!_SHA512Ready) { _SHA512Content = SGetField<Java.Security.Spec.MGF1ParameterSpec>(LocalBridgeClazz, "SHA512"); _SHA512Ready = true; } return _SHA512Content; } }
        private static Java.Security.Spec.MGF1ParameterSpec _SHA512Content = default;
        private static bool _SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA512_224"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA512_224 { get { if (!_SHA512_224Ready) { _SHA512_224Content = SGetField<Java.Security.Spec.MGF1ParameterSpec>(LocalBridgeClazz, "SHA512_224"); _SHA512_224Ready = true; } return _SHA512_224Content; } }
        private static Java.Security.Spec.MGF1ParameterSpec _SHA512_224Content = default;
        private static bool _SHA512_224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#SHA512_256"/>
        /// </summary>
        public static Java.Security.Spec.MGF1ParameterSpec SHA512_256 { get { if (!_SHA512_256Ready) { _SHA512_256Content = SGetField<Java.Security.Spec.MGF1ParameterSpec>(LocalBridgeClazz, "SHA512_256"); _SHA512_256Ready = true; } return _SHA512_256Content; } }
        private static Java.Security.Spec.MGF1ParameterSpec _SHA512_256Content = default;
        private static bool _SHA512_256Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/MGF1ParameterSpec.html#getDigestAlgorithm()"/> 
        /// </summary>
        public string DigestAlgorithm
        {
            get { return IExecute<string>("getDigestAlgorithm"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}