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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region URL
    public partial class URL
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#%3Cinit%3E(java.lang.String,java.lang.String,int,java.lang.String,java.net.URLStreamHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Java.Net.URLStreamHandler"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(string arg0, string arg1, int arg2, string arg3, Java.Net.URLStreamHandler arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#%3Cinit%3E(java.lang.String,java.lang.String,int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(string arg0, string arg1, int arg2, string arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(string arg0, string arg1, string arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#%3Cinit%3E(java.net.URL,java.lang.String,java.net.URLStreamHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Net.URLStreamHandler"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(Java.Net.URL arg0, string arg1, Java.Net.URLStreamHandler arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#%3Cinit%3E(java.net.URL,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Net.MalformedURLException"/>
        public URL(Java.Net.URL arg0, string arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#setURLStreamHandlerFactory(java.net.URLStreamHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URLStreamHandlerFactory"/></param>
        public static void SetURLStreamHandlerFactory(Java.Net.URLStreamHandlerFactory arg0)
        {
            SExecute(LocalBridgeClazz, "setURLStreamHandlerFactory", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getAuthority()"/> 
        /// </summary>
        public string Authority
        {
            get { return IExecute<string>("getAuthority"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getContent()"/> 
        /// </summary>
        public object Content
        {
            get { return IExecute("getContent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getDefaultPort()"/> 
        /// </summary>
        public int DefaultPort
        {
            get { return IExecute<int>("getDefaultPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getFile()"/> 
        /// </summary>
        public string File
        {
            get { return IExecute<string>("getFile"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getHost()"/> 
        /// </summary>
        public string Host
        {
            get { return IExecute<string>("getHost"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getPath()"/> 
        /// </summary>
        public string Path
        {
            get { return IExecute<string>("getPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getPort()"/> 
        /// </summary>
        public int Port
        {
            get { return IExecute<int>("getPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getProtocol()"/> 
        /// </summary>
        public string Protocol
        {
            get { return IExecute<string>("getProtocol"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getQuery()"/> 
        /// </summary>
        public string Query
        {
            get { return IExecute<string>("getQuery"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getRef()"/> 
        /// </summary>
        public string Ref
        {
            get { return IExecute<string>("getRef"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getUserInfo()"/> 
        /// </summary>
        public string UserInfo
        {
            get { return IExecute<string>("getUserInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#sameFile(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SameFile(Java.Net.URL arg0)
        {
            return IExecute<bool>("sameFile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#openStream()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.InputStream OpenStream()
        {
            return IExecute<Java.Io.InputStream>("openStream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#getContent(java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetContent(Java.Lang.Class[] arg0)
        {
            return IExecute("getContent", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#toExternalForm()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string ToExternalForm()
        {
            return IExecute<string>("toExternalForm");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#toURI()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        /// <exception cref="Java.Net.URISyntaxException"/>
        public Java.Net.URI ToURI()
        {
            return IExecute<Java.Net.URI>("toURI");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#openConnection()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URLConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.URLConnection OpenConnection()
        {
            return IExecute<Java.Net.URLConnection>("openConnection");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URL.html#openConnection(java.net.Proxy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Proxy"/></param>
        /// <returns><see cref="Java.Net.URLConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.URLConnection OpenConnection(Java.Net.Proxy arg0)
        {
            return IExecute<Java.Net.URLConnection>("openConnection", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}