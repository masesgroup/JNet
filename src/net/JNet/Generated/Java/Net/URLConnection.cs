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

namespace Java.Net
{
    #region URLConnection
    public partial class URLConnection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDefaultAllowUserInteraction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDefaultAllowUserInteraction(boolean)"/>
        /// </summary>
        public static bool DefaultAllowUserInteraction
        {
            get { return SExecute<bool>(LocalBridgeClazz, "getDefaultAllowUserInteraction"); } set { SExecute(LocalBridgeClazz, "setDefaultAllowUserInteraction", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getFileNameMap()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setFileNameMap(java.net.FileNameMap)"/>
        /// </summary>
        public static Java.Net.FileNameMap FileNameMap
        {
            get { return SExecute<Java.Net.FileNameMap>(LocalBridgeClazz, "getFileNameMap"); } set { SExecute(LocalBridgeClazz, "setFileNameMap", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDefaultUseCaches(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool GetDefaultUseCaches(string arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "getDefaultUseCaches", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#guessContentTypeFromName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public static string GuessContentTypeFromName(string arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "guessContentTypeFromName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#guessContentTypeFromStream(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static string GuessContentTypeFromStream(Java.Io.InputStream arg0)
        {
            return SExecute<string>(LocalBridgeClazz, "guessContentTypeFromStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setContentHandlerFactory(java.net.ContentHandlerFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ContentHandlerFactory"/></param>
        public static void SetContentHandlerFactory(Java.Net.ContentHandlerFactory arg0)
        {
            SExecute(LocalBridgeClazz, "setContentHandlerFactory", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDefaultUseCaches(java.lang.String,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public static void SetDefaultUseCaches(string arg0, bool arg1)
        {
            SExecute(LocalBridgeClazz, "setDefaultUseCaches", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getAllowUserInteraction()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setAllowUserInteraction(boolean)"/>
        /// </summary>
        public bool AllowUserInteraction
        {
            get { return IExecute<bool>("getAllowUserInteraction"); } set { IExecute("setAllowUserInteraction", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getConnectTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setConnectTimeout(int)"/>
        /// </summary>
        public int ConnectTimeout
        {
            get { return IExecute<int>("getConnectTimeout"); } set { IExecute("setConnectTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContent()"/> 
        /// </summary>
        public object Content
        {
            get { return IExecute("getContent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContentEncoding()"/> 
        /// </summary>
        public string ContentEncoding
        {
            get { return IExecute<string>("getContentEncoding"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContentLength()"/> 
        /// </summary>
        public int ContentLength
        {
            get { return IExecute<int>("getContentLength"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContentLengthLong()"/> 
        /// </summary>
        public long ContentLengthLong
        {
            get { return IExecute<long>("getContentLengthLong"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContentType()"/> 
        /// </summary>
        public string ContentType
        {
            get { return IExecute<string>("getContentType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDate()"/> 
        /// </summary>
        public long Date
        {
            get { return IExecute<long>("getDate"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDefaultUseCaches()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDefaultUseCaches(boolean)"/>
        /// </summary>
        public bool DefaultUseCaches
        {
            get { return IExecute<bool>("getDefaultUseCaches"); } set { IExecute("setDefaultUseCaches", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDoInput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDoInput(boolean)"/>
        /// </summary>
        public bool DoInput
        {
            get { return IExecute<bool>("getDoInput"); } set { IExecute("setDoInput", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getDoOutput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setDoOutput(boolean)"/>
        /// </summary>
        public bool DoOutput
        {
            get { return IExecute<bool>("getDoOutput"); } set { IExecute("setDoOutput", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getExpiration()"/> 
        /// </summary>
        public long Expiration
        {
            get { return IExecute<long>("getExpiration"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFields()"/> 
        /// </summary>
        public Java.Util.Map<string, Java.Util.List<string>> HeaderFields
        {
            get { return IExecute<Java.Util.Map<string, Java.Util.List<string>>>("getHeaderFields"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getIfModifiedSince()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setIfModifiedSince(long)"/>
        /// </summary>
        public long IfModifiedSince
        {
            get { return IExecute<long>("getIfModifiedSince"); } set { IExecute("setIfModifiedSince", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getInputStream()"/> 
        /// </summary>
        public Java.Io.InputStream InputStream
        {
            get { return IExecute<Java.Io.InputStream>("getInputStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getLastModified()"/> 
        /// </summary>
        public long LastModified
        {
            get { return IExecute<long>("getLastModified"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getOutputStream()"/> 
        /// </summary>
        public Java.Io.OutputStream OutputStream
        {
            get { return IExecute<Java.Io.OutputStream>("getOutputStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getPermission()"/> 
        /// </summary>
        public Java.Security.Permission Permission
        {
            get { return IExecute<Java.Security.Permission>("getPermission"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getReadTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setReadTimeout(int)"/>
        /// </summary>
        public int ReadTimeout
        {
            get { return IExecute<int>("getReadTimeout"); } set { IExecute("setReadTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getRequestProperties()"/> 
        /// </summary>
        public Java.Util.Map<string, Java.Util.List<string>> RequestProperties
        {
            get { return IExecute<Java.Util.Map<string, Java.Util.List<string>>>("getRequestProperties"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getURL()"/> 
        /// </summary>
        public Java.Net.URL URL
        {
            get { return IExecute<Java.Net.URL>("getURL"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getUseCaches()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setUseCaches(boolean)"/>
        /// </summary>
        public bool UseCaches
        {
            get { return IExecute<bool>("getUseCaches"); } set { IExecute("setUseCaches", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#connect()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecute("connect");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFieldInt(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetHeaderFieldInt(string arg0, int arg1)
        {
            return IExecute<int>("getHeaderFieldInt", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getContent(java.lang.Class[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetContent(Java.Lang.Class[] arg0)
        {
            return IExecute("getContent", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderField(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetHeaderField(int arg0)
        {
            return IExecute<string>("getHeaderField", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderField(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetHeaderField(string arg0)
        {
            return IExecute<string>("getHeaderField", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFieldKey(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetHeaderFieldKey(int arg0)
        {
            return IExecute<string>("getHeaderFieldKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getRequestProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetRequestProperty(string arg0)
        {
            return IExecute<string>("getRequestProperty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFieldDate(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetHeaderFieldDate(string arg0, long arg1)
        {
            return IExecute<long>("getHeaderFieldDate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#getHeaderFieldLong(java.lang.String,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public long GetHeaderFieldLong(string arg0, long arg1)
        {
            return IExecute<long>("getHeaderFieldLong", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#addRequestProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void AddRequestProperty(string arg0, string arg1)
        {
            IExecute("addRequestProperty", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/URLConnection.html#setRequestProperty(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public void SetRequestProperty(string arg0, string arg1)
        {
            IExecute("setRequestProperty", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}