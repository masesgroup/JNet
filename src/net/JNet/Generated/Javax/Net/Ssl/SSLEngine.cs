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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region SSLEngine
    public partial class SSLEngine
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getApplicationProtocol()"/> 
        /// </summary>
        public string ApplicationProtocol
        {
            get { return IExecute<string>("getApplicationProtocol"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getDelegatedTask()"/> 
        /// </summary>
        public Java.Lang.Runnable DelegatedTask
        {
            get { return IExecute<Java.Lang.Runnable>("getDelegatedTask"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getEnabledCipherSuites()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setEnabledCipherSuites(java.lang.String[])"/>
        /// </summary>
        public string[] EnabledCipherSuites
        {
            get { return IExecuteArray<string>("getEnabledCipherSuites"); } set { IExecute("setEnabledCipherSuites", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getEnabledProtocols()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setEnabledProtocols(java.lang.String[])"/>
        /// </summary>
        public string[] EnabledProtocols
        {
            get { return IExecuteArray<string>("getEnabledProtocols"); } set { IExecute("setEnabledProtocols", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getEnableSessionCreation()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setEnableSessionCreation(boolean)"/>
        /// </summary>
        public bool EnableSessionCreation
        {
            get { return IExecute<bool>("getEnableSessionCreation"); } set { IExecute("setEnableSessionCreation", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getHandshakeApplicationProtocol()"/> 
        /// </summary>
        public string HandshakeApplicationProtocol
        {
            get { return IExecute<string>("getHandshakeApplicationProtocol"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getHandshakeApplicationProtocolSelector()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setHandshakeApplicationProtocolSelector(java.util.function.BiFunction)"/>
        /// </summary>
        public Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<string>, string> HandshakeApplicationProtocolSelector
        {
            get { return IExecute<Java.Util.Function.BiFunction<Javax.Net.Ssl.SSLEngine, Java.Util.List<string>, string>>("getHandshakeApplicationProtocolSelector"); } set { IExecute("setHandshakeApplicationProtocolSelector", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getHandshakeSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession HandshakeSession
        {
            get { return IExecute<Javax.Net.Ssl.SSLSession>("getHandshakeSession"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getHandshakeStatus()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLEngineResult.HandshakeStatus HandshakeStatus
        {
            get { return IExecute<Javax.Net.Ssl.SSLEngineResult.HandshakeStatus>("getHandshakeStatus"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getNeedClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setNeedClientAuth(boolean)"/>
        /// </summary>
        public bool NeedClientAuth
        {
            get { return IExecute<bool>("getNeedClientAuth"); } set { IExecute("setNeedClientAuth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getPeerHost()"/> 
        /// </summary>
        public string PeerHost
        {
            get { return IExecute<string>("getPeerHost"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getPeerPort()"/> 
        /// </summary>
        public int PeerPort
        {
            get { return IExecute<int>("getPeerPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getSession()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSession Session
        {
            get { return IExecute<Javax.Net.Ssl.SSLSession>("getSession"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getSSLParameters()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setSSLParameters(javax.net.ssl.SSLParameters)"/>
        /// </summary>
        public Javax.Net.Ssl.SSLParameters SSLParameters
        {
            get { return IExecute<Javax.Net.Ssl.SSLParameters>("getSSLParameters"); } set { IExecute("setSSLParameters", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getSupportedCipherSuites()"/> 
        /// </summary>
        public string[] SupportedCipherSuites
        {
            get { return IExecuteArray<string>("getSupportedCipherSuites"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getSupportedProtocols()"/> 
        /// </summary>
        public string[] SupportedProtocols
        {
            get { return IExecuteArray<string>("getSupportedProtocols"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getUseClientMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setUseClientMode(boolean)"/>
        /// </summary>
        public bool UseClientMode
        {
            get { return IExecute<bool>("getUseClientMode"); } set { IExecute("setUseClientMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#getWantClientAuth()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#setWantClientAuth(boolean)"/>
        /// </summary>
        public bool WantClientAuth
        {
            get { return IExecute<bool>("getWantClientAuth"); } set { IExecute("setWantClientAuth", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#isInboundDone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsInboundDone()
        {
            return IExecute<bool>("isInboundDone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#isOutboundDone()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOutboundDone()
        {
            return IExecute<bool>("isOutboundDone");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer[] arg1, int arg2, int arg3)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer[],int,int,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2, Java.Nio.ByteBuffer arg3)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#beginHandshake()"/>
        /// </summary>

        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public void BeginHandshake()
        {
            IExecute("beginHandshake");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#closeInbound()"/>
        /// </summary>

        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public void CloseInbound()
        {
            IExecute("closeInbound");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#closeOutbound()"/>
        /// </summary>
        public void CloseOutbound()
        {
            IExecute("closeOutbound");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#unwrap(java.nio.ByteBuffer,java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Unwrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer[] arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("unwrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLEngine.html#wrap(java.nio.ByteBuffer[],java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLEngineResult"/></returns>
        /// <exception cref="Javax.Net.Ssl.SSLException"/>
        public Javax.Net.Ssl.SSLEngineResult Wrap(Java.Nio.ByteBuffer[] arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<Javax.Net.Ssl.SSLEngineResult>("wrap", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}