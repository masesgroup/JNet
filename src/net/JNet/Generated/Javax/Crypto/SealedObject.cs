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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Crypto
{
    #region SealedObject
    public partial class SealedObject
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SealedObject.html#%3Cinit%3E(java.io.Serializable,javax.crypto.Cipher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.Serializable"/></param>
        /// <param name="arg1"><see cref="Javax.Crypto.Cipher"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        public SealedObject(Java.Io.Serializable arg0, Javax.Crypto.Cipher arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SealedObject.html#getAlgorithm()"/> 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SealedObject.html#getObject(java.security.Key,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public object GetObject(Java.Security.Key arg0, string arg1)
        {
            return IExecute("getObject", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SealedObject.html#getObject(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public object GetObject(Java.Security.Key arg0)
        {
            return IExecute("getObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/SealedObject.html#getObject(javax.crypto.Cipher)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Crypto.Cipher"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public object GetObject(Javax.Crypto.Cipher arg0)
        {
            return IExecute("getObject", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}