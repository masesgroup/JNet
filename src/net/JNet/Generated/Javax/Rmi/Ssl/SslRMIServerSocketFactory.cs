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

namespace Javax.Rmi.Ssl
{
    #region SslRMIServerSocketFactory
    public partial class SslRMIServerSocketFactory
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/javax/rmi/ssl/SslRMIServerSocketFactory.html#%3Cinit%3E(java.lang.String[],java.lang.String[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public SslRMIServerSocketFactory(string[] arg0, string[] arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/javax/rmi/ssl/SslRMIServerSocketFactory.html#%3Cinit%3E(javax.net.ssl.SSLContext,java.lang.String[],java.lang.String[],boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLContext"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public SslRMIServerSocketFactory(Javax.Net.Ssl.SSLContext arg0, string[] arg1, string[] arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Rmi.Ssl.SslRMIServerSocketFactory"/> to <see cref="Java.Rmi.Server.RMIServerSocketFactory"/>
        /// </summary>
        public static implicit operator Java.Rmi.Server.RMIServerSocketFactory(Javax.Rmi.Ssl.SslRMIServerSocketFactory t) => t.Cast<Java.Rmi.Server.RMIServerSocketFactory>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/javax/rmi/ssl/SslRMIServerSocketFactory.html#getEnabledCipherSuites()"/> 
        /// </summary>
        public string[] EnabledCipherSuites
        {
            get { return IExecuteArray<string>("getEnabledCipherSuites"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/javax/rmi/ssl/SslRMIServerSocketFactory.html#getEnabledProtocols()"/> 
        /// </summary>
        public string[] EnabledProtocols
        {
            get { return IExecuteArray<string>("getEnabledProtocols"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/javax/rmi/ssl/SslRMIServerSocketFactory.html#getNeedClientAuth()"/> 
        /// </summary>
        public bool NeedClientAuth
        {
            get { return IExecute<bool>("getNeedClientAuth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/javax/rmi/ssl/SslRMIServerSocketFactory.html#createServerSocket(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.ServerSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.ServerSocket CreateServerSocket(int arg0)
        {
            return IExecute<Java.Net.ServerSocket>("createServerSocket", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}