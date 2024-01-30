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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Net.Ssl
{
    #region HttpsURLConnection
    public partial class HttpsURLConnection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getDefaultSSLSocketFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#setDefaultSSLSocketFactory(javax.net.ssl.SSLSocketFactory)"/>
        /// </summary>
        public static Javax.Net.Ssl.SSLSocketFactory DefaultSSLSocketFactory
        {
            get { return SExecute<Javax.Net.Ssl.SSLSocketFactory>(LocalBridgeClazz, "getDefaultSSLSocketFactory"); } set { SExecute(LocalBridgeClazz, "setDefaultSSLSocketFactory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getDefaultHostnameVerifier()"/> 
        /// </summary>
        public static Javax.Net.Ssl.HostnameVerifier GetDefaultHostnameVerifier
        {
            get { return SExecute<Javax.Net.Ssl.HostnameVerifier>(LocalBridgeClazz, "getDefaultHostnameVerifier"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#setDefaultHostnameVerifier(javax.net.ssl.HostnameVerifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.HostnameVerifier"/></param>
        public static void SetDefaultHostnameVerifier(Javax.Net.Ssl.HostnameVerifier arg0)
        {
            SExecute(LocalBridgeClazz, "setDefaultHostnameVerifier", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getCipherSuite()"/> 
        /// </summary>
        public string CipherSuite
        {
            get { return IExecute<string>("getCipherSuite"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getHostnameVerifier()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#setHostnameVerifier(javax.net.ssl.HostnameVerifier)"/>
        /// </summary>
        public Javax.Net.Ssl.HostnameVerifier HostnameVerifier
        {
            get { return IExecute<Javax.Net.Ssl.HostnameVerifier>("getHostnameVerifier"); } set { IExecute("setHostnameVerifier", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getLocalCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] LocalCertificates
        {
            get { return IExecuteArray<Java.Security.Cert.Certificate>("getLocalCertificates"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getLocalPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal LocalPrincipal
        {
            get { return IExecute<Java.Security.Principal>("getLocalPrincipal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getPeerPrincipal()"/> 
        /// </summary>
        public Java.Security.Principal PeerPrincipal
        {
            get { return IExecute<Java.Security.Principal>("getPeerPrincipal"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getServerCertificates()"/> 
        /// </summary>
        public Java.Security.Cert.Certificate[] ServerCertificates
        {
            get { return IExecuteArray<Java.Security.Cert.Certificate>("getServerCertificates"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#getSSLSocketFactory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/HttpsURLConnection.html#setSSLSocketFactory(javax.net.ssl.SSLSocketFactory)"/>
        /// </summary>
        public Javax.Net.Ssl.SSLSocketFactory SSLSocketFactory
        {
            get { return IExecute<Javax.Net.Ssl.SSLSocketFactory>("getSSLSocketFactory"); } set { IExecute("setSSLSocketFactory", value); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}