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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region KeyFactory
    public partial class KeyFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.KeyFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Java.Security.KeyFactory GetInstance(string arg0, string arg1)
        {
            return SExecute<Java.Security.KeyFactory>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Java.Security.KeyFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.KeyFactory GetInstance(string arg0, Java.Security.Provider arg1)
        {
            return SExecute<Java.Security.KeyFactory>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.KeyFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.KeyFactory GetInstance(string arg0)
        {
            return SExecute<Java.Security.KeyFactory>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#getAlgorithm()"/> 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecute<Java.Security.Provider>("getProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#getKeySpec(java.security.Key,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Security.Spec.KeySpec"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidKeySpecException"/>
        public Java.Security.Spec.KeySpec GetKeySpec(Java.Security.Key arg0, Java.Lang.Class arg1)
        {
            return IExecute<Java.Security.Spec.KeySpec>("getKeySpec", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#translateKey(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="Java.Security.Key"/></returns>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Java.Security.Key TranslateKey(Java.Security.Key arg0)
        {
            return IExecute<Java.Security.Key>("translateKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#generatePrivate(java.security.spec.KeySpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.KeySpec"/></param>
        /// <returns><see cref="Java.Security.PrivateKey"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidKeySpecException"/>
        public Java.Security.PrivateKey GeneratePrivate(Java.Security.Spec.KeySpec arg0)
        {
            return IExecute<Java.Security.PrivateKey>("generatePrivate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/KeyFactory.html#generatePublic(java.security.spec.KeySpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Spec.KeySpec"/></param>
        /// <returns><see cref="Java.Security.PublicKey"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidKeySpecException"/>
        public Java.Security.PublicKey GeneratePublic(Java.Security.Spec.KeySpec arg0)
        {
            return IExecute<Java.Security.PublicKey>("generatePublic", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}