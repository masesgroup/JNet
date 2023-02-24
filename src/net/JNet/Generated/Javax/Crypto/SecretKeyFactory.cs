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

namespace Javax.Crypto
{
    #region SecretKeyFactory
    public partial class SecretKeyFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SecretKeyFactory.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="string"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKeyFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Crypto.SecretKeyFactory GetInstance(string arg0, string arg1)
        {
            return SExecute<Javax.Crypto.SecretKeyFactory>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SecretKeyFactory.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKeyFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Javax.Crypto.SecretKeyFactory GetInstance(string arg0)
        {
            return SExecute<Javax.Crypto.SecretKeyFactory>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SecretKeyFactory.html#getAlgorithm()"/> 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SecretKeyFactory.html#generateSecret(java.security.spec.KeySpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.KeySpec"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKey"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidKeySpecException"/>
        public Javax.Crypto.SecretKey GenerateSecret(Java.Security.Spec.KeySpec arg0)
        {
            return IExecute<Javax.Crypto.SecretKey>("generateSecret", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SecretKeyFactory.html#translateKey(javax.crypto.SecretKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Crypto.SecretKey"/></param>
        /// <returns><see cref="Javax.Crypto.SecretKey"/></returns>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Javax.Crypto.SecretKey TranslateKey(Javax.Crypto.SecretKey arg0)
        {
            return IExecute<Javax.Crypto.SecretKey>("translateKey", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}