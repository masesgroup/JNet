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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region SSLServerSocket
    public partial class SSLServerSocket
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getEnabledCipherSuites()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] EnabledCipherSuites
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledCipherSuites", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setEnabledCipherSuites", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getEnabledProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#setEnabledProtocols(java.lang.String[])"/>
        /// </summary>
        public Java.Lang.String[] EnabledProtocols
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getEnabledProtocols", "()[Ljava/lang/String;"); } set { IExecuteWithSignature("setEnabledProtocols", "([Ljava/lang/String;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getEnableSessionCreation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#setEnableSessionCreation(boolean)"/>
        /// </summary>
        public bool EnableSessionCreation
        {
            get { return IExecuteWithSignature<bool>("getEnableSessionCreation", "()Z"); } set { IExecuteWithSignature("setEnableSessionCreation", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getNeedClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        public bool NeedClientAuth
        {
            get { return IExecuteWithSignature<bool>("getNeedClientAuth", "()Z"); } set { IExecuteWithSignature("setNeedClientAuth", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getSSLParameters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#setSSLParameters(javax.net.ssl.SSLParameters)"/>
        /// </summary>
        public Javax.Net.Ssl.SSLParameters SSLParameters
        {
            get { return IExecuteWithSignature<Javax.Net.Ssl.SSLParameters>("getSSLParameters", "()Ljavax/net/ssl/SSLParameters;"); } set { IExecuteWithSignature("setSSLParameters", "(Ljavax/net/ssl/SSLParameters;)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getSupportedCipherSuites()"/> 
        /// </summary>
        public Java.Lang.String[] SupportedCipherSuites
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedCipherSuites", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getSupportedProtocols()"/> 
        /// </summary>
        public Java.Lang.String[] SupportedProtocols
        {
            get { return IExecuteWithSignatureArray<Java.Lang.String>("getSupportedProtocols", "()[Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getUseClientMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#setUseClientMode(boolean)"/>
        /// </summary>
        public bool UseClientMode
        {
            get { return IExecuteWithSignature<bool>("getUseClientMode", "()Z"); } set { IExecuteWithSignature("setUseClientMode", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#getWantClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLServerSocket.html#setWantClientAuth(boolean)"/>
        /// </summary>
        public bool WantClientAuth
        {
            get { return IExecuteWithSignature<bool>("getWantClientAuth", "()Z"); } set { IExecuteWithSignature("setWantClientAuth", "(Z)V", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}