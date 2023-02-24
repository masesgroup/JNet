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
    #region EncryptedPrivateKeyInfo
    public partial class EncryptedPrivateKeyInfo
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#%3Cinit%3E(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public EncryptedPrivateKeyInfo(byte[] arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#%3Cinit%3E(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public EncryptedPrivateKeyInfo(string arg0, byte[] arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#%3Cinit%3E(java.security.AlgorithmParameters,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public EncryptedPrivateKeyInfo(Java.Security.AlgorithmParameters arg0, byte[] arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getAlgName()"/> 
        /// </summary>
        public string AlgName
        {
            get { return IExecute<string>("getAlgName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getAlgParameters()"/> 
        /// </summary>
        public Java.Security.AlgorithmParameters AlgParameters
        {
            get { return IExecute<Java.Security.AlgorithmParameters>("getAlgParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteArray<byte>("getEncoded"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getEncryptedData()"/> 
        /// </summary>
        public byte[] EncryptedData
        {
            get { return IExecuteArray<byte>("getEncryptedData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getKeySpec(java.security.Key,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Spec.PKCS8EncodedKeySpec"/></returns>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(Java.Security.Key arg0, string arg1)
        {
            return IExecute<Java.Security.Spec.PKCS8EncodedKeySpec>("getKeySpec", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getKeySpec(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="Java.Security.Spec.PKCS8EncodedKeySpec"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(Java.Security.Key arg0)
        {
            return IExecute<Java.Security.Spec.PKCS8EncodedKeySpec>("getKeySpec", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/EncryptedPrivateKeyInfo.html#getKeySpec(javax.crypto.Cipher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Crypto.Cipher"/></param>
        /// <returns><see cref="Java.Security.Spec.PKCS8EncodedKeySpec"/></returns>
        /// <exception cref="Java.Security.Spec.InvalidKeySpecException"/>
        public Java.Security.Spec.PKCS8EncodedKeySpec GetKeySpec(Javax.Crypto.Cipher arg0)
        {
            return IExecute<Java.Security.Spec.PKCS8EncodedKeySpec>("getKeySpec", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}