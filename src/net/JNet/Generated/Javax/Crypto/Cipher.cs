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
    #region Cipher
    public partial class Cipher
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#DECRYPT_MODE"/>
        /// </summary>
        public static int DECRYPT_MODE => Clazz.GetField<int>("DECRYPT_MODE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#ENCRYPT_MODE"/>
        /// </summary>
        public static int ENCRYPT_MODE => Clazz.GetField<int>("ENCRYPT_MODE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#PRIVATE_KEY"/>
        /// </summary>
        public static int PRIVATE_KEY => Clazz.GetField<int>("PRIVATE_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#PUBLIC_KEY"/>
        /// </summary>
        public static int PUBLIC_KEY => Clazz.GetField<int>("PUBLIC_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#SECRET_KEY"/>
        /// </summary>
        public static int SECRET_KEY => Clazz.GetField<int>("SECRET_KEY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#UNWRAP_MODE"/>
        /// </summary>
        public static int UNWRAP_MODE => Clazz.GetField<int>("UNWRAP_MODE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#WRAP_MODE"/>
        /// </summary>
        public static int WRAP_MODE => Clazz.GetField<int>("WRAP_MODE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getMaxAllowedKeyLength(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static int GetMaxAllowedKeyLength(string arg0)
        {
            return SExecute<int>("getMaxAllowedKeyLength", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getMaxAllowedParameterSpec(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public static Java.Security.Spec.AlgorithmParameterSpec GetMaxAllowedParameterSpec(string arg0)
        {
            return SExecute<Java.Security.Spec.AlgorithmParameterSpec>("getMaxAllowedParameterSpec", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Crypto.Cipher"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        /// <exception cref="Javax.Crypto.NoSuchPaddingException"/>
        public static Javax.Crypto.Cipher GetInstance(string arg0, string arg1)
        {
            return SExecute<Javax.Crypto.Cipher>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Crypto.Cipher"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Javax.Crypto.NoSuchPaddingException"/>
        public static Javax.Crypto.Cipher GetInstance(string arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Crypto.Cipher>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Crypto.Cipher"/></returns>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        /// <exception cref="Javax.Crypto.NoSuchPaddingException"/>
        public static Javax.Crypto.Cipher GetInstance(string arg0)
        {
            return SExecute<Javax.Crypto.Cipher>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getAlgorithm()"/> 
        /// </summary>
        public string Algorithm
        {
            get { return IExecute<string>("getAlgorithm"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getBlockSize()"/> 
        /// </summary>
        public int BlockSize
        {
            get { return IExecute<int>("getBlockSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getExemptionMechanism()"/> 
        /// </summary>
        public Javax.Crypto.ExemptionMechanism ExemptionMechanism
        {
            get { return IExecute<Javax.Crypto.ExemptionMechanism>("getExemptionMechanism"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getIV()"/> 
        /// </summary>
        public byte[] IV
        {
            get { return IExecuteArray<byte>("getIV"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getParameters()"/> 
        /// </summary>
        public Java.Security.AlgorithmParameters Parameters
        {
            get { return IExecute<Java.Security.AlgorithmParameters>("getParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecute<Java.Security.Provider>("getProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal()"/>
        /// </summary>
        
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public byte[] DoFinal()
        {
            return IExecuteArray<byte>("doFinal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public byte[] DoFinal(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("doFinal", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public byte[] DoFinal(byte[] arg0)
        {
            return IExecuteArray<byte>("doFinal", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Update(byte[] arg0, int arg1, int arg2)
        {
            return IExecuteArray<byte>("update", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="byte"/></returns>
        public byte[] Update(byte[] arg0)
        {
            return IExecuteArray<byte>("update", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#wrap(java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Key"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public byte[] Wrap(Java.Security.Key arg0)
        {
            return IExecuteArray<byte>("wrap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[],int,int,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public int DoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
        {
            return IExecute<int>("doFinal", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[],int,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public int DoFinal(byte[] arg0, int arg1, int arg2, byte[] arg3)
        {
            return IExecute<int>("doFinal", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public int DoFinal(byte[] arg0, int arg1)
        {
            return IExecute<int>("doFinal", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#doFinal(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        /// <exception cref="Javax.Crypto.IllegalBlockSizeException"/>
        /// <exception cref="Javax.Crypto.BadPaddingException"/>
        public int DoFinal(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<int>("doFinal", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#getOutputSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetOutputSize(int arg0)
        {
            return IExecute<int>("getOutputSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(byte[],int,int,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        public int Update(byte[] arg0, int arg1, int arg2, byte[] arg3, int arg4)
        {
            return IExecute<int>("update", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(byte[],int,int,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="byte"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        public int Update(byte[] arg0, int arg1, int arg2, byte[] arg3)
        {
            return IExecute<int>("update", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#update(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Javax.Crypto.ShortBufferException"/>
        public int Update(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<int>("update", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#unwrap(byte[],java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Security.Key"/></returns>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.NoSuchAlgorithmException"/>
        public Java.Security.Key Unwrap(byte[] arg0, string arg1, int arg2)
        {
            return IExecute<Java.Security.Key>("unwrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.cert.Certificate,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <param name="arg2"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(int arg0, Java.Security.Cert.Certificate arg1, Java.Security.SecureRandom arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.cert.Certificate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Cert.Certificate"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(int arg0, Java.Security.Cert.Certificate arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.AlgorithmParameters,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <param name="arg3"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.AlgorithmParameters arg2, Java.Security.SecureRandom arg3)
        {
            IExecute("init", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.AlgorithmParameters)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.AlgorithmParameters"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.AlgorithmParameters arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.SecureRandom arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.spec.AlgorithmParameterSpec,java.security.SecureRandom)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <param name="arg3"><see cref="Java.Security.SecureRandom"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.Spec.AlgorithmParameterSpec arg2, Java.Security.SecureRandom arg3)
        {
            IExecute("init", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key,java.security.spec.AlgorithmParameterSpec)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <param name="arg2"><see cref="Java.Security.Spec.AlgorithmParameterSpec"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        /// <exception cref="Java.Security.InvalidAlgorithmParameterException"/>
        public void Init(int arg0, Java.Security.Key arg1, Java.Security.Spec.AlgorithmParameterSpec arg2)
        {
            IExecute("init", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#init(int,java.security.Key)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Security.Key"/></param>
        /// <exception cref="Java.Security.InvalidKeyException"/>
        public void Init(int arg0, Java.Security.Key arg1)
        {
            IExecute("init", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#updateAAD(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void UpdateAAD(byte[] arg0, int arg1, int arg2)
        {
            IExecute("updateAAD", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#updateAAD(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void UpdateAAD(byte[] arg0)
        {
            IExecute("updateAAD", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/crypto/Cipher.html#updateAAD(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void UpdateAAD(Java.Nio.ByteBuffer arg0)
        {
            IExecute("updateAAD", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}