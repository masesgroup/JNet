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

namespace Javax.Net.Ssl
{
    #region ISSLSessionContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface ISSLSessionContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#getIds()"/> 
        /// </summary>
        Java.Util.Enumeration<byte[]> Ids { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#getSessionCacheSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#setSessionCacheSize(int)"/>
        /// </summary>
        int SessionCacheSize { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#getSessionTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#setSessionTimeout(int)"/>
        /// </summary>
        int SessionTimeout { get; set; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#getSession(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        Javax.Net.Ssl.SSLSession GetSession(byte[] arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SSLSessionContext
    public partial class SSLSessionContext : Javax.Net.Ssl.ISSLSessionContext
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#getIds()"/> 
        /// </summary>
        public Java.Util.Enumeration<byte[]> Ids
        {
            get { return IExecute<Java.Util.Enumeration<byte[]>>("getIds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#getSessionCacheSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#setSessionCacheSize(int)"/>
        /// </summary>
        public int SessionCacheSize
        {
            get { return IExecute<int>("getSessionCacheSize"); } set { IExecute("setSessionCacheSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#getSessionTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#setSessionTimeout(int)"/>
        /// </summary>
        public int SessionTimeout
        {
            get { return IExecute<int>("getSessionTimeout"); } set { IExecute("setSessionTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ssl/SSLSessionContext.html#getSession(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Javax.Net.Ssl.SSLSession"/></returns>
        public Javax.Net.Ssl.SSLSession GetSession(byte[] arg0)
        {
            return IExecute<Javax.Net.Ssl.SSLSession>("getSession", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}