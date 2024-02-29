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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig.Keyinfo
{
    #region KeyInfoFactory
    public partial class KeyInfoFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#getInstance()"/> 
        /// </summary>
        public static Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory Instance
        {
            get { return SExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory>(LocalBridgeClazz, "getInstance", "()Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#getInstance(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory"/></returns>
        /// <exception cref="Java.Security.NoSuchProviderException"/>
        public static Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory GetInstance(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return SExecute<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#getInstance(java.lang.String,java.security.Provider)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Security.Provider"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory"/></returns>
        public static Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory GetInstance(Java.Lang.String arg0, Java.Security.Provider arg1)
        {
            return SExecute<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory>(LocalBridgeClazz, "getInstance", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#getInstance(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory"/></returns>
        public static Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory GetInstance(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfoFactory>(LocalBridgeClazz, "getInstance", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfoFactory;", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#getMechanismType()"/> 
        /// </summary>
        public Java.Lang.String MechanismType
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getMechanismType", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#getProvider()"/> 
        /// </summary>
        public Java.Security.Provider Provider
        {
            get { return IExecuteWithSignature<Java.Security.Provider>("getProvider", "()Ljava/security/Provider;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#getURIDereferencer()"/> 
        /// </summary>
        public Javax.Xml.Crypto.URIDereferencer URIDereferencer
        {
            get { return IExecuteWithSignature<Javax.Xml.Crypto.URIDereferencer>("getURIDereferencer", "()Ljavax/xml/crypto/URIDereferencer;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#isFeatureSupported(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsFeatureSupported(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<bool>("isFeatureSupported", "(Ljava/lang/String;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newKeyInfo(java.util.List,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Xml_Crypto_XMLStructure"><see cref="Javax.Xml.Crypto.XMLStructure"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo NewKeyInfo<Arg0ExtendsJavax_Xml_Crypto_XMLStructure>(Java.Util.List<Arg0ExtendsJavax_Xml_Crypto_XMLStructure> arg0, Java.Lang.String arg1) where Arg0ExtendsJavax_Xml_Crypto_XMLStructure: Javax.Xml.Crypto.XMLStructure
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo>("newKeyInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newKeyInfo(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <typeparam name="Arg0ExtendsJavax_Xml_Crypto_XMLStructure"><see cref="Javax.Xml.Crypto.XMLStructure"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo NewKeyInfo<Arg0ExtendsJavax_Xml_Crypto_XMLStructure>(Java.Util.List<Arg0ExtendsJavax_Xml_Crypto_XMLStructure> arg0) where Arg0ExtendsJavax_Xml_Crypto_XMLStructure: Javax.Xml.Crypto.XMLStructure
        {
            return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo>("newKeyInfo", "(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#unmarshalKeyInfo(javax.xml.crypto.XMLStructure)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Xml.Crypto.XMLStructure"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo"/></returns>
        /// <exception cref="Javax.Xml.Crypto.MarshalException"/>
        public Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo UnmarshalKeyInfo(Javax.Xml.Crypto.XMLStructure arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.KeyInfo>("unmarshalKeyInfo", "(Ljavax/xml/crypto/XMLStructure;)Ljavax/xml/crypto/dsig/keyinfo/KeyInfo;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newKeyName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyName"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.KeyName NewKeyName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.KeyName>("newKeyName", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/KeyName;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newKeyValue(java.security.PublicKey)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.PublicKey"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.KeyValue"/></returns>
        /// <exception cref="Java.Security.KeyException"/>
        public Javax.Xml.Crypto.Dsig.Keyinfo.KeyValue NewKeyValue(Java.Security.PublicKey arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.KeyValue>("newKeyValue", "(Ljava/security/PublicKey;)Ljavax/xml/crypto/dsig/keyinfo/KeyValue;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newPGPData(byte[],byte[],java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Crypto_XMLStructure"><see cref="Javax.Xml.Crypto.XMLStructure"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.PGPData"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.PGPData NewPGPData<Arg2ExtendsJavax_Xml_Crypto_XMLStructure>(byte[] arg0, byte[] arg1, Java.Util.List<Arg2ExtendsJavax_Xml_Crypto_XMLStructure> arg2) where Arg2ExtendsJavax_Xml_Crypto_XMLStructure: Javax.Xml.Crypto.XMLStructure
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Keyinfo.PGPData>("newPGPData", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newPGPData(byte[],java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <typeparam name="Arg1ExtendsJavax_Xml_Crypto_XMLStructure"><see cref="Javax.Xml.Crypto.XMLStructure"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.PGPData"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.PGPData NewPGPData<Arg1ExtendsJavax_Xml_Crypto_XMLStructure>(byte[] arg0, Java.Util.List<Arg1ExtendsJavax_Xml_Crypto_XMLStructure> arg1) where Arg1ExtendsJavax_Xml_Crypto_XMLStructure: Javax.Xml.Crypto.XMLStructure
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Keyinfo.PGPData>("newPGPData", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newPGPData(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.PGPData"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.PGPData NewPGPData(byte[] arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.PGPData>("newPGPData", "([B)Ljavax/xml/crypto/dsig/keyinfo/PGPData;", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newRetrievalMethod(java.lang.String,java.lang.String,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <typeparam name="Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform"><see cref="Javax.Xml.Crypto.Dsig.Transform"/></typeparam>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod NewRetrievalMethod<Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform>(Java.Lang.String arg0, Java.Lang.String arg1, Java.Util.List<Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform> arg2) where Arg2ExtendsJavax_Xml_Crypto_Dsig_Transform: Javax.Xml.Crypto.Dsig.Transform
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod>("newRetrievalMethod", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newRetrievalMethod(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod NewRetrievalMethod(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.RetrievalMethod>("newRetrievalMethod", "(Ljava/lang/String;)Ljavax/xml/crypto/dsig/keyinfo/RetrievalMethod;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newX509Data(java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.X509Data"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.X509Data NewX509Data(Java.Util.List<object> arg0)
        {
            return IExecuteWithSignature<Javax.Xml.Crypto.Dsig.Keyinfo.X509Data>("newX509Data", "(Ljava/util/List;)Ljavax/xml/crypto/dsig/keyinfo/X509Data;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/keyinfo/KeyInfoFactory.html#newX509IssuerSerial(java.lang.String,java.math.BigInteger)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Math.BigInteger"/></param>
        /// <returns><see cref="Javax.Xml.Crypto.Dsig.Keyinfo.X509IssuerSerial"/></returns>
        public Javax.Xml.Crypto.Dsig.Keyinfo.X509IssuerSerial NewX509IssuerSerial(Java.Lang.String arg0, Java.Math.BigInteger arg1)
        {
            return IExecute<Javax.Xml.Crypto.Dsig.Keyinfo.X509IssuerSerial>("newX509IssuerSerial", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}