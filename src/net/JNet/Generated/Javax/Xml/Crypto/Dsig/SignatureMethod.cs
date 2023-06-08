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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig
{
    #region ISignatureMethod
    public partial interface ISignatureMethod
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#getParameterSpec()"/> 
        /// </summary>
        Java.Security.Spec.AlgorithmParameterSpec ParameterSpec { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SignatureMethod
    public partial class SignatureMethod : Javax.Xml.Crypto.Dsig.ISignatureMethod
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.SignatureMethod"/> to <see cref="Javax.Xml.Crypto.XMLStructure"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.XMLStructure(Javax.Xml.Crypto.Dsig.SignatureMethod t) => t.Cast<Javax.Xml.Crypto.XMLStructure>();
        /// <summary>
        /// Converter from <see cref="Javax.Xml.Crypto.Dsig.SignatureMethod"/> to <see cref="Javax.Xml.Crypto.AlgorithmMethod"/>
        /// </summary>
        public static implicit operator Javax.Xml.Crypto.AlgorithmMethod(Javax.Xml.Crypto.Dsig.SignatureMethod t) => t.Cast<Javax.Xml.Crypto.AlgorithmMethod>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#DSA_SHA1"/>
        /// </summary>
        public static string DSA_SHA1 { get { return SGetField<string>(LocalBridgeClazz, "DSA_SHA1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#DSA_SHA256"/>
        /// </summary>
        public static string DSA_SHA256 { get { return SGetField<string>(LocalBridgeClazz, "DSA_SHA256"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA1"/>
        /// </summary>
        public static string ECDSA_SHA1 { get { return SGetField<string>(LocalBridgeClazz, "ECDSA_SHA1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA224"/>
        /// </summary>
        public static string ECDSA_SHA224 { get { return SGetField<string>(LocalBridgeClazz, "ECDSA_SHA224"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA256"/>
        /// </summary>
        public static string ECDSA_SHA256 { get { return SGetField<string>(LocalBridgeClazz, "ECDSA_SHA256"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA384"/>
        /// </summary>
        public static string ECDSA_SHA384 { get { return SGetField<string>(LocalBridgeClazz, "ECDSA_SHA384"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA512"/>
        /// </summary>
        public static string ECDSA_SHA512 { get { return SGetField<string>(LocalBridgeClazz, "ECDSA_SHA512"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA1"/>
        /// </summary>
        public static string HMAC_SHA1 { get { return SGetField<string>(LocalBridgeClazz, "HMAC_SHA1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA224"/>
        /// </summary>
        public static string HMAC_SHA224 { get { return SGetField<string>(LocalBridgeClazz, "HMAC_SHA224"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA256"/>
        /// </summary>
        public static string HMAC_SHA256 { get { return SGetField<string>(LocalBridgeClazz, "HMAC_SHA256"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA384"/>
        /// </summary>
        public static string HMAC_SHA384 { get { return SGetField<string>(LocalBridgeClazz, "HMAC_SHA384"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA512"/>
        /// </summary>
        public static string HMAC_SHA512 { get { return SGetField<string>(LocalBridgeClazz, "HMAC_SHA512"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA1"/>
        /// </summary>
        public static string RSA_SHA1 { get { return SGetField<string>(LocalBridgeClazz, "RSA_SHA1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA224"/>
        /// </summary>
        public static string RSA_SHA224 { get { return SGetField<string>(LocalBridgeClazz, "RSA_SHA224"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA256"/>
        /// </summary>
        public static string RSA_SHA256 { get { return SGetField<string>(LocalBridgeClazz, "RSA_SHA256"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA384"/>
        /// </summary>
        public static string RSA_SHA384 { get { return SGetField<string>(LocalBridgeClazz, "RSA_SHA384"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA512"/>
        /// </summary>
        public static string RSA_SHA512 { get { return SGetField<string>(LocalBridgeClazz, "RSA_SHA512"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA1_RSA_MGF1"/>
        /// </summary>
        public static string SHA1_RSA_MGF1 { get { return SGetField<string>(LocalBridgeClazz, "SHA1_RSA_MGF1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA224_RSA_MGF1"/>
        /// </summary>
        public static string SHA224_RSA_MGF1 { get { return SGetField<string>(LocalBridgeClazz, "SHA224_RSA_MGF1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA256_RSA_MGF1"/>
        /// </summary>
        public static string SHA256_RSA_MGF1 { get { return SGetField<string>(LocalBridgeClazz, "SHA256_RSA_MGF1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA384_RSA_MGF1"/>
        /// </summary>
        public static string SHA384_RSA_MGF1 { get { return SGetField<string>(LocalBridgeClazz, "SHA384_RSA_MGF1"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA512_RSA_MGF1"/>
        /// </summary>
        public static string SHA512_RSA_MGF1 { get { return SGetField<string>(LocalBridgeClazz, "SHA512_RSA_MGF1"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#getParameterSpec()"/> 
        /// </summary>
        public Java.Security.Spec.AlgorithmParameterSpec ParameterSpec
        {
            get { return IExecute<Java.Security.Spec.AlgorithmParameterSpec>("getParameterSpec"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}