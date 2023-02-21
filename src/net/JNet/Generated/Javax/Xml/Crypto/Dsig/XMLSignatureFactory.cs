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
    #region XMLSignatureFactory
    public partial class XMLSignatureFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getInstance()
        /// </summary>
        public static Javax.Xml.Crypto.Dsig.XMLSignatureFactory GetInstance()
        {
            return SExecute<Javax.Xml.Crypto.Dsig.XMLSignatureFactory>("getInstance");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getInstance(java.lang.String,java.lang.String) throws java.security.NoSuchProviderException
        /// </summary>
        public static Javax.Xml.Crypto.Dsig.XMLSignatureFactory GetInstance(string arg0, string arg1)
        {
            return SExecute<Javax.Xml.Crypto.Dsig.XMLSignatureFactory>("getInstance", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getInstance(java.lang.String)
        /// </summary>
        public static Javax.Xml.Crypto.Dsig.XMLSignatureFactory GetInstance(string arg0)
        {
            return SExecute<Javax.Xml.Crypto.Dsig.XMLSignatureFactory>("getInstance", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getKeyInfoFactory() 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory KeyInfoFactory
        {
            get { return IExecute<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory>("getKeyInfoFactory"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getMechanismType() 
        /// </summary>
        public string MechanismType
        {
            get { return IExecute<string>("getMechanismType"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#getURIDereferencer() 
        /// </summary>
        public Javax.Xml.Crypto.URIDereferencer URIDereferencer
        {
            get { return IExecute<Javax.Xml.Crypto.URIDereferencer>("getURIDereferencer"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#isFeatureSupported(java.lang.String)
        /// </summary>
        public bool IsFeatureSupported(string arg0)
        {
            return IExecute<bool>("isFeatureSupported", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newCanonicalizationMethod(java.lang.String,javax.xml.crypto.dsig.spec.C14NMethodParameterSpec) throws java.security.NoSuchAlgorithmException,java.security.InvalidAlgorithmParameterException
        /// </summary>
        public Javax.Xml.Crypto.Dsig.CanonicalizationMethod NewCanonicalizationMethod(string arg0, Javax.Xml.Crypto.Dsig.Spec.C14NMethodParameterSpec arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.CanonicalizationMethod>("newCanonicalizationMethod", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newCanonicalizationMethod(java.lang.String,javax.xml.crypto.XMLStructure) throws java.security.NoSuchAlgorithmException,java.security.InvalidAlgorithmParameterException
        /// </summary>
        public Javax.Xml.Crypto.Dsig.CanonicalizationMethod NewCanonicalizationMethod(string arg0, Javax.Xml.Crypto.XMLStructure arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.CanonicalizationMethod>("newCanonicalizationMethod", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newDigestMethod(java.lang.String,javax.xml.crypto.dsig.spec.DigestMethodParameterSpec) throws java.security.NoSuchAlgorithmException,java.security.InvalidAlgorithmParameterException
        /// </summary>
        public Javax.Xml.Crypto.Dsig.DigestMethod NewDigestMethod(string arg0, Javax.Xml.Crypto.Dsig.Spec.DigestMethodParameterSpec arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.DigestMethod>("newDigestMethod", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newReference(java.lang.String,javax.xml.crypto.dsig.DigestMethod)
        /// </summary>
        public Javax.Xml.Crypto.Dsig.Reference NewReference(string arg0, Javax.Xml.Crypto.Dsig.DigestMethod arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Reference>("newReference", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newSignatureMethod(java.lang.String,javax.xml.crypto.dsig.spec.SignatureMethodParameterSpec) throws java.security.NoSuchAlgorithmException,java.security.InvalidAlgorithmParameterException
        /// </summary>
        public Javax.Xml.Crypto.Dsig.SignatureMethod NewSignatureMethod(string arg0, Javax.Xml.Crypto.Dsig.Spec.SignatureMethodParameterSpec arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.SignatureMethod>("newSignatureMethod", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newTransform(java.lang.String,javax.xml.crypto.dsig.spec.TransformParameterSpec) throws java.security.NoSuchAlgorithmException,java.security.InvalidAlgorithmParameterException
        /// </summary>
        public Javax.Xml.Crypto.Dsig.Transform NewTransform(string arg0, Javax.Xml.Crypto.Dsig.Spec.TransformParameterSpec arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Transform>("newTransform", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newTransform(java.lang.String,javax.xml.crypto.XMLStructure) throws java.security.NoSuchAlgorithmException,java.security.InvalidAlgorithmParameterException
        /// </summary>
        public Javax.Xml.Crypto.Dsig.Transform NewTransform(string arg0, Javax.Xml.Crypto.XMLStructure arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Transform>("newTransform", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#newXMLSignature(javax.xml.crypto.dsig.SignedInfo,javax.xml.crypto.dsig.keyinfo.KeyInfo)
        /// </summary>
        public Javax.Xml.Crypto.Dsig.XMLSignature NewXMLSignature(Javax.Xml.Crypto.Dsig.SignedInfo arg0, Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.XMLSignature>("newXMLSignature", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#unmarshalXMLSignature(javax.xml.crypto.dsig.XMLValidateContext) throws javax.xml.crypto.MarshalException
        /// </summary>
        public Javax.Xml.Crypto.Dsig.XMLSignature UnmarshalXMLSignature(Javax.Xml.Crypto.Dsig.XMLValidateContext arg0)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.XMLSignature>("unmarshalXMLSignature", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/XMLSignatureFactory.html#unmarshalXMLSignature(javax.xml.crypto.XMLStructure) throws javax.xml.crypto.MarshalException
        /// </summary>
        public Javax.Xml.Crypto.Dsig.XMLSignature UnmarshalXMLSignature(Javax.Xml.Crypto.XMLStructure arg0)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.XMLSignature>("unmarshalXMLSignature", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}