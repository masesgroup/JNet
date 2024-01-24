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
    #region ISSLSession
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISSLSession
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getApplicationBufferSize()"/> 
        /// </summary>
        int ApplicationBufferSize { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getCipherSuite()"/> 
        /// </summary>
        string CipherSuite { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getCreationTime()"/> 
        /// </summary>
        long CreationTime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getId()"/> 
        /// </summary>
        byte[] Id { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getLastAccessedTime()"/> 
        /// </summary>
        long LastAccessedTime { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getLocalCertificates()"/> 
        /// </summary>
        Java.Security.Cert.Certificate[] LocalCertificates { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getLocalPrincipal()"/> 
        /// </summary>
        Java.Security.Principal LocalPrincipal { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPacketBufferSize()"/> 
        /// </summary>
        int PacketBufferSize { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPeerCertificates()"/> 
        /// </summary>
        Java.Security.Cert.Certificate[] PeerCertificates { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPeerHost()"/> 
        /// </summary>
        string PeerHost { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPeerPort()"/> 
        /// </summary>
        int PeerPort { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPeerPrincipal()"/> 
        /// </summary>
        Java.Security.Principal PeerPrincipal { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getProtocol()"/> 
        /// </summary>
        string Protocol { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getSessionContext()"/> 
        /// </summary>
        Javax.Net.Ssl.SSLSessionContext SessionContext { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getValueNames()"/> 
        /// </summary>
        string[] ValueNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#isValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsValid();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetValue(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#invalidate()"/>
        /// </summary>
        void Invalidate();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        void PutValue(string arg0, object arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#removeValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        void RemoveValue(string arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SSLSession
    public partial class SSLSession : Javax.Net.Ssl.ISSLSession
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getApplicationBufferSize()"/> 
        /// </summary>
        public int ApplicationBufferSize
        {
            get { return IExecute<int>("getApplicationBufferSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getCipherSuite()"/> 
        /// </summary>
        public string CipherSuite
        {
            get { return IExecute<string>("getCipherSuite"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getCreationTime()"/> 
        /// </summary>
        public long CreationTime
        {
            get { return IExecute<long>("getCreationTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getId()"/> 
        /// </summary>
        public byte[] Id
        {
            get { return IExecuteArray<byte>("getId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getLastAccessedTime()"/> 
        /// </summary>
        public long LastAccessedTime
        {
            get { return IExecute<long>("getLastAccessedTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getLocalCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] LocalCertificates
        {
            get { return IExecuteArray<Java.Security.Cert.Certificate>("getLocalCertificates"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getLocalPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal LocalPrincipal
        {
            get { return IExecute<Java.Security.Principal>("getLocalPrincipal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPacketBufferSize()"/> 
        /// </summary>
        public int PacketBufferSize
        {
            get { return IExecute<int>("getPacketBufferSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPeerCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] PeerCertificates
        {
            get { return IExecuteArray<Java.Security.Cert.Certificate>("getPeerCertificates"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPeerHost()"/> 
        /// </summary>
        public string PeerHost
        {
            get { return IExecute<string>("getPeerHost"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPeerPort()"/> 
        /// </summary>
        public int PeerPort
        {
            get { return IExecute<int>("getPeerPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getPeerPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal PeerPrincipal
        {
            get { return IExecute<Java.Security.Principal>("getPeerPrincipal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getProtocol()"/> 
        /// </summary>
        public string Protocol
        {
            get { return IExecute<string>("getProtocol"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getSessionContext()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLSessionContext SessionContext
        {
            get { return IExecute<Javax.Net.Ssl.SSLSessionContext>("getSessionContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getValueNames()"/> 
        /// </summary>
        public string[] ValueNames
        {
            get { return IExecuteArray<string>("getValueNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#isValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecute<bool>("isValid");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#getValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetValue(string arg0)
        {
            return IExecute("getValue", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#invalidate()"/>
        /// </summary>
        public void Invalidate()
        {
            IExecute("invalidate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#putValue(java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void PutValue(string arg0, object arg1)
        {
            IExecute("putValue", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSession.html#removeValue(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void RemoveValue(string arg0)
        {
            IExecute("removeValue", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}