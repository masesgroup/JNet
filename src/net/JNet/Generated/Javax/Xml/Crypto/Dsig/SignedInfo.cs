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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Xml.Crypto.Dsig
{
    #region ISignedInfo
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISignedInfo : Javax.Xml.Crypto.IXMLStructure
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getCanonicalizationMethod()"/> 
        /// </summary>
        Javax.Xml.Crypto.Dsig.CanonicalizationMethod CanonicalizationMethod { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getCanonicalizedData()"/> 
        /// </summary>
        Java.Io.InputStream CanonicalizedData { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getId()"/> 
        /// </summary>
        string Id { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getReferences()"/> 
        /// </summary>
        Java.Util.List<Javax.Xml.Crypto.Dsig.Reference> References { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getSignatureMethod()"/> 
        /// </summary>
        Javax.Xml.Crypto.Dsig.SignatureMethod SignatureMethod { get; }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SignedInfo
    public partial class SignedInfo : Javax.Xml.Crypto.Dsig.ISignedInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getCanonicalizationMethod()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.CanonicalizationMethod CanonicalizationMethod
        {
            get { return IExecute<Javax.Xml.Crypto.Dsig.CanonicalizationMethod>("getCanonicalizationMethod"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getCanonicalizedData()"/> 
        /// </summary>
        public Java.Io.InputStream CanonicalizedData
        {
            get { return IExecute<Java.Io.InputStream>("getCanonicalizedData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getId()"/> 
        /// </summary>
        public string Id
        {
            get { return IExecute<string>("getId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getReferences()"/> 
        /// </summary>
        public Java.Util.List<Javax.Xml.Crypto.Dsig.Reference> References
        {
            get { return IExecute<Java.Util.List<Javax.Xml.Crypto.Dsig.Reference>>("getReferences"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.xml.crypto/javax/xml/crypto/dsig/SignedInfo.html#getSignatureMethod()"/> 
        /// </summary>
        public Javax.Xml.Crypto.Dsig.SignatureMethod SignatureMethod
        {
            get { return IExecute<Javax.Xml.Crypto.Dsig.SignatureMethod>("getSignatureMethod"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}