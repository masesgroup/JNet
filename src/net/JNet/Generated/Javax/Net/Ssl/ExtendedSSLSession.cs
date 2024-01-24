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

namespace Javax.Net.Ssl
{
    #region ExtendedSSLSession
    public partial class ExtendedSSLSession
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/ExtendedSSLSession.html#getLocalSupportedSignatureAlgorithms()"/> 
        /// </summary>
        public string[] LocalSupportedSignatureAlgorithms
        {
            get { return IExecuteArray<string>("getLocalSupportedSignatureAlgorithms"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/ExtendedSSLSession.html#getPeerSupportedSignatureAlgorithms()"/> 
        /// </summary>
        public string[] PeerSupportedSignatureAlgorithms
        {
            get { return IExecuteArray<string>("getPeerSupportedSignatureAlgorithms"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/ExtendedSSLSession.html#getRequestedServerNames()"/> 
        /// </summary>
        public Java.Util.List<Javax.Net.Ssl.SNIServerName> RequestedServerNames
        {
            get { return IExecute<Java.Util.List<Javax.Net.Ssl.SNIServerName>>("getRequestedServerNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/ExtendedSSLSession.html#getStatusResponses()"/> 
        /// </summary>
        public Java.Util.List<byte[]> StatusResponses
        {
            get { return IExecute<Java.Util.List<byte[]>>("getStatusResponses"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}