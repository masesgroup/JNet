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

namespace Java.Security.Cert
{
    #region CertPath
    public partial class CertPath
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPath.html#getCertificates()"/> 
        /// </summary>
        public Java.Util.List Certificates
        {
            get { return IExecute<Java.Util.List>("getCertificates"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPath.html#getEncoded()"/> 
        /// </summary>
        public byte[] Encoded
        {
            get { return IExecuteArray<byte>("getEncoded"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPath.html#getEncodings()"/> 
        /// </summary>
        public Java.Util.Iterator<string> Encodings
        {
            get { return IExecute<Java.Util.Iterator<string>>("getEncodings"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPath.html#getType()"/> 
        /// </summary>
        public string Type
        {
            get { return IExecute<string>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/cert/CertPath.html#getEncoded(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Security.Cert.CertificateEncodingException"/>
        public byte[] GetEncoded(string arg0)
        {
            return IExecuteArray<byte>("getEncoded", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}