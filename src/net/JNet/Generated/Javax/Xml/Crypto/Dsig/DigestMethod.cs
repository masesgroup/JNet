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

namespace Javax.Xml.Crypto.Dsig
{
    #region DigestMethod
    public partial class DigestMethod
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Xml.Crypto.XMLStructure(Javax.Xml.Crypto.Dsig.DigestMethod t) => t.Cast<Javax.Xml.Crypto.XMLStructure>();
        public static implicit operator Javax.Xml.Crypto.AlgorithmMethod(Javax.Xml.Crypto.Dsig.DigestMethod t) => t.Cast<Javax.Xml.Crypto.AlgorithmMethod>();
        
        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA1
        /// </summary>
        public static string SHA1 => Clazz.GetField<string>("SHA1");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA224
        /// </summary>
        public static string SHA224 => Clazz.GetField<string>("SHA224");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA256
        /// </summary>
        public static string SHA256 => Clazz.GetField<string>("SHA256");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA384
        /// </summary>
        public static string SHA384 => Clazz.GetField<string>("SHA384");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA512
        /// </summary>
        public static string SHA512 => Clazz.GetField<string>("SHA512");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#RIPEMD160
        /// </summary>
        public static string RIPEMD160 => Clazz.GetField<string>("RIPEMD160");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA3_224
        /// </summary>
        public static string SHA3_224 => Clazz.GetField<string>("SHA3_224");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA3_256
        /// </summary>
        public static string SHA3_256 => Clazz.GetField<string>("SHA3_256");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA3_384
        /// </summary>
        public static string SHA3_384 => Clazz.GetField<string>("SHA3_384");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#SHA3_512
        /// </summary>
        public static string SHA3_512 => Clazz.GetField<string>("SHA3_512");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/DigestMethod.html#getParameterSpec() 
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