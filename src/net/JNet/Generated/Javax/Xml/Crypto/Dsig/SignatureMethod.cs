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

namespace Javax.Xml.Crypto.Dsig
{
    #region ISignatureMethod
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
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
        public static string DSA_SHA1 { get { if (!_DSA_SHA1Ready) { _DSA_SHA1Content = SGetField<string>(LocalBridgeClazz, "DSA_SHA1"); _DSA_SHA1Ready = true; } return _DSA_SHA1Content; } }
        private static string _DSA_SHA1Content = default;
        private static bool _DSA_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#DSA_SHA256"/>
        /// </summary>
        public static string DSA_SHA256 { get { if (!_DSA_SHA256Ready) { _DSA_SHA256Content = SGetField<string>(LocalBridgeClazz, "DSA_SHA256"); _DSA_SHA256Ready = true; } return _DSA_SHA256Content; } }
        private static string _DSA_SHA256Content = default;
        private static bool _DSA_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA1"/>
        /// </summary>
        public static string ECDSA_SHA1 { get { if (!_ECDSA_SHA1Ready) { _ECDSA_SHA1Content = SGetField<string>(LocalBridgeClazz, "ECDSA_SHA1"); _ECDSA_SHA1Ready = true; } return _ECDSA_SHA1Content; } }
        private static string _ECDSA_SHA1Content = default;
        private static bool _ECDSA_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA224"/>
        /// </summary>
        public static string ECDSA_SHA224 { get { if (!_ECDSA_SHA224Ready) { _ECDSA_SHA224Content = SGetField<string>(LocalBridgeClazz, "ECDSA_SHA224"); _ECDSA_SHA224Ready = true; } return _ECDSA_SHA224Content; } }
        private static string _ECDSA_SHA224Content = default;
        private static bool _ECDSA_SHA224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA256"/>
        /// </summary>
        public static string ECDSA_SHA256 { get { if (!_ECDSA_SHA256Ready) { _ECDSA_SHA256Content = SGetField<string>(LocalBridgeClazz, "ECDSA_SHA256"); _ECDSA_SHA256Ready = true; } return _ECDSA_SHA256Content; } }
        private static string _ECDSA_SHA256Content = default;
        private static bool _ECDSA_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA384"/>
        /// </summary>
        public static string ECDSA_SHA384 { get { if (!_ECDSA_SHA384Ready) { _ECDSA_SHA384Content = SGetField<string>(LocalBridgeClazz, "ECDSA_SHA384"); _ECDSA_SHA384Ready = true; } return _ECDSA_SHA384Content; } }
        private static string _ECDSA_SHA384Content = default;
        private static bool _ECDSA_SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#ECDSA_SHA512"/>
        /// </summary>
        public static string ECDSA_SHA512 { get { if (!_ECDSA_SHA512Ready) { _ECDSA_SHA512Content = SGetField<string>(LocalBridgeClazz, "ECDSA_SHA512"); _ECDSA_SHA512Ready = true; } return _ECDSA_SHA512Content; } }
        private static string _ECDSA_SHA512Content = default;
        private static bool _ECDSA_SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA1"/>
        /// </summary>
        public static string HMAC_SHA1 { get { if (!_HMAC_SHA1Ready) { _HMAC_SHA1Content = SGetField<string>(LocalBridgeClazz, "HMAC_SHA1"); _HMAC_SHA1Ready = true; } return _HMAC_SHA1Content; } }
        private static string _HMAC_SHA1Content = default;
        private static bool _HMAC_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA224"/>
        /// </summary>
        public static string HMAC_SHA224 { get { if (!_HMAC_SHA224Ready) { _HMAC_SHA224Content = SGetField<string>(LocalBridgeClazz, "HMAC_SHA224"); _HMAC_SHA224Ready = true; } return _HMAC_SHA224Content; } }
        private static string _HMAC_SHA224Content = default;
        private static bool _HMAC_SHA224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA256"/>
        /// </summary>
        public static string HMAC_SHA256 { get { if (!_HMAC_SHA256Ready) { _HMAC_SHA256Content = SGetField<string>(LocalBridgeClazz, "HMAC_SHA256"); _HMAC_SHA256Ready = true; } return _HMAC_SHA256Content; } }
        private static string _HMAC_SHA256Content = default;
        private static bool _HMAC_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA384"/>
        /// </summary>
        public static string HMAC_SHA384 { get { if (!_HMAC_SHA384Ready) { _HMAC_SHA384Content = SGetField<string>(LocalBridgeClazz, "HMAC_SHA384"); _HMAC_SHA384Ready = true; } return _HMAC_SHA384Content; } }
        private static string _HMAC_SHA384Content = default;
        private static bool _HMAC_SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#HMAC_SHA512"/>
        /// </summary>
        public static string HMAC_SHA512 { get { if (!_HMAC_SHA512Ready) { _HMAC_SHA512Content = SGetField<string>(LocalBridgeClazz, "HMAC_SHA512"); _HMAC_SHA512Ready = true; } return _HMAC_SHA512Content; } }
        private static string _HMAC_SHA512Content = default;
        private static bool _HMAC_SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA1"/>
        /// </summary>
        public static string RSA_SHA1 { get { if (!_RSA_SHA1Ready) { _RSA_SHA1Content = SGetField<string>(LocalBridgeClazz, "RSA_SHA1"); _RSA_SHA1Ready = true; } return _RSA_SHA1Content; } }
        private static string _RSA_SHA1Content = default;
        private static bool _RSA_SHA1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA224"/>
        /// </summary>
        public static string RSA_SHA224 { get { if (!_RSA_SHA224Ready) { _RSA_SHA224Content = SGetField<string>(LocalBridgeClazz, "RSA_SHA224"); _RSA_SHA224Ready = true; } return _RSA_SHA224Content; } }
        private static string _RSA_SHA224Content = default;
        private static bool _RSA_SHA224Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA256"/>
        /// </summary>
        public static string RSA_SHA256 { get { if (!_RSA_SHA256Ready) { _RSA_SHA256Content = SGetField<string>(LocalBridgeClazz, "RSA_SHA256"); _RSA_SHA256Ready = true; } return _RSA_SHA256Content; } }
        private static string _RSA_SHA256Content = default;
        private static bool _RSA_SHA256Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA384"/>
        /// </summary>
        public static string RSA_SHA384 { get { if (!_RSA_SHA384Ready) { _RSA_SHA384Content = SGetField<string>(LocalBridgeClazz, "RSA_SHA384"); _RSA_SHA384Ready = true; } return _RSA_SHA384Content; } }
        private static string _RSA_SHA384Content = default;
        private static bool _RSA_SHA384Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#RSA_SHA512"/>
        /// </summary>
        public static string RSA_SHA512 { get { if (!_RSA_SHA512Ready) { _RSA_SHA512Content = SGetField<string>(LocalBridgeClazz, "RSA_SHA512"); _RSA_SHA512Ready = true; } return _RSA_SHA512Content; } }
        private static string _RSA_SHA512Content = default;
        private static bool _RSA_SHA512Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA1_RSA_MGF1"/>
        /// </summary>
        public static string SHA1_RSA_MGF1 { get { if (!_SHA1_RSA_MGF1Ready) { _SHA1_RSA_MGF1Content = SGetField<string>(LocalBridgeClazz, "SHA1_RSA_MGF1"); _SHA1_RSA_MGF1Ready = true; } return _SHA1_RSA_MGF1Content; } }
        private static string _SHA1_RSA_MGF1Content = default;
        private static bool _SHA1_RSA_MGF1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA224_RSA_MGF1"/>
        /// </summary>
        public static string SHA224_RSA_MGF1 { get { if (!_SHA224_RSA_MGF1Ready) { _SHA224_RSA_MGF1Content = SGetField<string>(LocalBridgeClazz, "SHA224_RSA_MGF1"); _SHA224_RSA_MGF1Ready = true; } return _SHA224_RSA_MGF1Content; } }
        private static string _SHA224_RSA_MGF1Content = default;
        private static bool _SHA224_RSA_MGF1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA256_RSA_MGF1"/>
        /// </summary>
        public static string SHA256_RSA_MGF1 { get { if (!_SHA256_RSA_MGF1Ready) { _SHA256_RSA_MGF1Content = SGetField<string>(LocalBridgeClazz, "SHA256_RSA_MGF1"); _SHA256_RSA_MGF1Ready = true; } return _SHA256_RSA_MGF1Content; } }
        private static string _SHA256_RSA_MGF1Content = default;
        private static bool _SHA256_RSA_MGF1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA384_RSA_MGF1"/>
        /// </summary>
        public static string SHA384_RSA_MGF1 { get { if (!_SHA384_RSA_MGF1Ready) { _SHA384_RSA_MGF1Content = SGetField<string>(LocalBridgeClazz, "SHA384_RSA_MGF1"); _SHA384_RSA_MGF1Ready = true; } return _SHA384_RSA_MGF1Content; } }
        private static string _SHA384_RSA_MGF1Content = default;
        private static bool _SHA384_RSA_MGF1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignatureMethod.html#SHA512_RSA_MGF1"/>
        /// </summary>
        public static string SHA512_RSA_MGF1 { get { if (!_SHA512_RSA_MGF1Ready) { _SHA512_RSA_MGF1Content = SGetField<string>(LocalBridgeClazz, "SHA512_RSA_MGF1"); _SHA512_RSA_MGF1Ready = true; } return _SHA512_RSA_MGF1Content; } }
        private static string _SHA512_RSA_MGF1Content = default;
        private static bool _SHA512_RSA_MGF1Ready = false; // this is used because in case of generics 

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