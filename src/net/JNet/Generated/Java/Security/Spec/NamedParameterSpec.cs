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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security.Spec
{
    #region NamedParameterSpec
    public partial class NamedParameterSpec
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/NamedParameterSpec.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        public NamedParameterSpec(Java.Lang.String arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/NamedParameterSpec.html#X25519"/>
        /// </summary>
        public static Java.Security.Spec.NamedParameterSpec X25519 { get { if (!_X25519Ready) { _X25519Content = SGetField<Java.Security.Spec.NamedParameterSpec>(LocalBridgeClazz, "X25519"); _X25519Ready = true; } return _X25519Content; } }
        private static Java.Security.Spec.NamedParameterSpec _X25519Content = default;
        private static bool _X25519Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/NamedParameterSpec.html#X448"/>
        /// </summary>
        public static Java.Security.Spec.NamedParameterSpec X448 { get { if (!_X448Ready) { _X448Content = SGetField<Java.Security.Spec.NamedParameterSpec>(LocalBridgeClazz, "X448"); _X448Ready = true; } return _X448Content; } }
        private static Java.Security.Spec.NamedParameterSpec _X448Content = default;
        private static bool _X448Ready = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/spec/NamedParameterSpec.html#getName()"/> 
        /// </summary>
        public Java.Lang.String Name
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getName", "()Ljava/lang/String;"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}