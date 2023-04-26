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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net.Http
{
    #region HttpClient
    public partial class HttpClient
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#newBuilder()"/> 
        /// </summary>
        public static Java.Net.Http.HttpClient.Builder NewBuilder
        {
            get { return SExecute<Java.Net.Http.HttpClient.Builder>(LocalClazz, "newBuilder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#newHttpClient()"/> 
        /// </summary>
        public static Java.Net.Http.HttpClient NewHttpClient
        {
            get { return SExecute<Java.Net.Http.HttpClient>(LocalClazz, "newHttpClient"); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#authenticator()"/> 
        /// </summary>
        public Java.Util.Optional<Java.Net.Authenticator> Authenticator
        {
            get { return IExecute<Java.Util.Optional<Java.Net.Authenticator>>("authenticator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#connectTimeout()"/> 
        /// </summary>
        public Java.Util.Optional<Java.Time.Duration> ConnectTimeout
        {
            get { return IExecute<Java.Util.Optional<Java.Time.Duration>>("connectTimeout"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#cookieHandler()"/> 
        /// </summary>
        public Java.Util.Optional<Java.Net.CookieHandler> CookieHandler
        {
            get { return IExecute<Java.Util.Optional<Java.Net.CookieHandler>>("cookieHandler"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#executor()"/> 
        /// </summary>
        public Java.Util.Optional<Java.Util.Concurrent.Executor> Executor
        {
            get { return IExecute<Java.Util.Optional<Java.Util.Concurrent.Executor>>("executor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#followRedirects()"/> 
        /// </summary>
        public Java.Net.Http.HttpClient.Redirect FollowRedirects
        {
            get { return IExecute<Java.Net.Http.HttpClient.Redirect>("followRedirects"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#newWebSocketBuilder()"/> 
        /// </summary>
        public Java.Net.Http.WebSocket.Builder NewWebSocketBuilder
        {
            get { return IExecute<Java.Net.Http.WebSocket.Builder>("newWebSocketBuilder"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#proxy()"/> 
        /// </summary>
        public Java.Util.Optional<Java.Net.ProxySelector> Proxy
        {
            get { return IExecute<Java.Util.Optional<Java.Net.ProxySelector>>("proxy"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#sslContext()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLContext SslContext
        {
            get { return IExecute<Javax.Net.Ssl.SSLContext>("sslContext"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#sslParameters()"/> 
        /// </summary>
        public Javax.Net.Ssl.SSLParameters SslParameters
        {
            get { return IExecute<Javax.Net.Ssl.SSLParameters>("sslParameters"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#send(java.net.http.HttpRequest,java.net.http.HttpResponse.BodyHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Http.HttpRequest"/></param>
        /// <param name="arg1"><see cref="Java.Net.Http.HttpResponse.BodyHandler"/></param>
        /// <returns><see cref="Java.Net.Http.HttpResponse"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public Java.Net.Http.HttpResponse<T> Send<T>(Java.Net.Http.HttpRequest arg0, Java.Net.Http.HttpResponse.BodyHandler<T> arg1)
        {
            return IExecute<Java.Net.Http.HttpResponse<T>>("send", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#sendAsync(java.net.http.HttpRequest,java.net.http.HttpResponse.BodyHandler,java.net.http.HttpResponse.PushPromiseHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Http.HttpRequest"/></param>
        /// <param name="arg1"><see cref="Java.Net.Http.HttpResponse.BodyHandler"/></param>
        /// <param name="arg2"><see cref="Java.Net.Http.HttpResponse.PushPromiseHandler"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.HttpResponse<T>> SendAsync<T>(Java.Net.Http.HttpRequest arg0, Java.Net.Http.HttpResponse.BodyHandler<T> arg1, Java.Net.Http.HttpResponse.PushPromiseHandler<T> arg2)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.HttpResponse<T>>>("sendAsync", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#sendAsync(java.net.http.HttpRequest,java.net.http.HttpResponse.BodyHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Http.HttpRequest"/></param>
        /// <param name="arg1"><see cref="Java.Net.Http.HttpResponse.BodyHandler"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture<Java.Net.Http.HttpResponse<T>> SendAsync<T>(Java.Net.Http.HttpRequest arg0, Java.Net.Http.HttpResponse.BodyHandler<T> arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture<Java.Net.Http.HttpResponse<T>>>("sendAsync", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.html#version()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Net.Http.HttpClient.Version"/></returns>
        public Java.Net.Http.HttpClient.Version VersionMethod()
        {
            return IExecute<Java.Net.Http.HttpClient.Version>("version");
        }
        
        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#NO_PROXY"/>
            /// </summary>
            public static Java.Net.ProxySelector NO_PROXY => LocalClazz.GetField<Java.Net.ProxySelector>("NO_PROXY");
            
            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#build()"/> 
            /// </summary>
            public Java.Net.Http.HttpClient Build
            {
                get { return IExecute<Java.Net.Http.HttpClient>("build"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#authenticator(java.net.Authenticator)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Authenticator"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder Authenticator(Java.Net.Authenticator arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("authenticator", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#connectTimeout(java.time.Duration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder ConnectTimeout(Java.Time.Duration arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("connectTimeout", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#cookieHandler(java.net.CookieHandler)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.CookieHandler"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder CookieHandler(Java.Net.CookieHandler arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("cookieHandler", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#executor(java.util.concurrent.Executor)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Concurrent.Executor"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder Executor(Java.Util.Concurrent.Executor arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("executor", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#followRedirects(java.net.http.HttpClient.Redirect)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.HttpClient.Redirect"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder FollowRedirects(Java.Net.Http.HttpClient.Redirect arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("followRedirects", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#priority(int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="int"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder Priority(int arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("priority", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#proxy(java.net.ProxySelector)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.ProxySelector"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder Proxy(Java.Net.ProxySelector arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("proxy", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#sslContext(javax.net.ssl.SSLContext)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLContext"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder SslContext(Javax.Net.Ssl.SSLContext arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("sslContext", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#sslParameters(javax.net.ssl.SSLParameters)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Javax.Net.Ssl.SSLParameters"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder SslParameters(Javax.Net.Ssl.SSLParameters arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("sslParameters", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Builder.html#version(java.net.http.HttpClient.Version)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.Http.HttpClient.Version"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Builder"/></returns>
            public Java.Net.Http.HttpClient.Builder VersionMethod(Java.Net.Http.HttpClient.Version arg0)
            {
                return IExecute<Java.Net.Http.HttpClient.Builder>("version", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Redirect
        public partial class Redirect
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#ALWAYS"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Redirect ALWAYS => LocalClazz.GetField<Java.Net.Http.HttpClient.Redirect>("ALWAYS");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#NEVER"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Redirect NEVER => LocalClazz.GetField<Java.Net.Http.HttpClient.Redirect>("NEVER");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#NORMAL"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Redirect NORMAL => LocalClazz.GetField<Java.Net.Http.HttpClient.Redirect>("NORMAL");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#values()"/> 
            /// </summary>
            public static Java.Net.Http.HttpClient.Redirect[] Values
            {
                get { return SExecuteArray<Java.Net.Http.HttpClient.Redirect>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Redirect.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Redirect"/></returns>
            public static Java.Net.Http.HttpClient.Redirect ValueOf(string arg0)
            {
                return SExecute<Java.Net.Http.HttpClient.Redirect>(LocalClazz, "valueOf", arg0);
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region Version
        public partial class Version
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Version.html#HTTP_1_1"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Version HTTP_1_1 => LocalClazz.GetField<Java.Net.Http.HttpClient.Version>("HTTP_1_1");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Version.html#HTTP_2"/>
            /// </summary>
            public static Java.Net.Http.HttpClient.Version HTTP_2 => LocalClazz.GetField<Java.Net.Http.HttpClient.Version>("HTTP_2");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Version.html#values()"/> 
            /// </summary>
            public static Java.Net.Http.HttpClient.Version[] Values
            {
                get { return SExecuteArray<Java.Net.Http.HttpClient.Version>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/HttpClient.Version.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Net.Http.HttpClient.Version"/></returns>
            public static Java.Net.Http.HttpClient.Version ValueOf(string arg0)
            {
                return SExecute<Java.Net.Http.HttpClient.Version>(LocalClazz, "valueOf", arg0);
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}