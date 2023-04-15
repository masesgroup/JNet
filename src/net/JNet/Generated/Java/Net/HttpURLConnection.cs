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

namespace Java.Net
{
    #region HttpURLConnection
    public partial class HttpURLConnection
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_ACCEPTED"/>
        /// </summary>
        public static int HTTP_ACCEPTED => Clazz.GetField<int>("HTTP_ACCEPTED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_BAD_GATEWAY"/>
        /// </summary>
        public static int HTTP_BAD_GATEWAY => Clazz.GetField<int>("HTTP_BAD_GATEWAY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_BAD_METHOD"/>
        /// </summary>
        public static int HTTP_BAD_METHOD => Clazz.GetField<int>("HTTP_BAD_METHOD");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_BAD_REQUEST"/>
        /// </summary>
        public static int HTTP_BAD_REQUEST => Clazz.GetField<int>("HTTP_BAD_REQUEST");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_CLIENT_TIMEOUT"/>
        /// </summary>
        public static int HTTP_CLIENT_TIMEOUT => Clazz.GetField<int>("HTTP_CLIENT_TIMEOUT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_CONFLICT"/>
        /// </summary>
        public static int HTTP_CONFLICT => Clazz.GetField<int>("HTTP_CONFLICT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_CREATED"/>
        /// </summary>
        public static int HTTP_CREATED => Clazz.GetField<int>("HTTP_CREATED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_ENTITY_TOO_LARGE"/>
        /// </summary>
        public static int HTTP_ENTITY_TOO_LARGE => Clazz.GetField<int>("HTTP_ENTITY_TOO_LARGE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_FORBIDDEN"/>
        /// </summary>
        public static int HTTP_FORBIDDEN => Clazz.GetField<int>("HTTP_FORBIDDEN");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_GATEWAY_TIMEOUT"/>
        /// </summary>
        public static int HTTP_GATEWAY_TIMEOUT => Clazz.GetField<int>("HTTP_GATEWAY_TIMEOUT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_GONE"/>
        /// </summary>
        public static int HTTP_GONE => Clazz.GetField<int>("HTTP_GONE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_INTERNAL_ERROR"/>
        /// </summary>
        public static int HTTP_INTERNAL_ERROR => Clazz.GetField<int>("HTTP_INTERNAL_ERROR");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_LENGTH_REQUIRED"/>
        /// </summary>
        public static int HTTP_LENGTH_REQUIRED => Clazz.GetField<int>("HTTP_LENGTH_REQUIRED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_MOVED_PERM"/>
        /// </summary>
        public static int HTTP_MOVED_PERM => Clazz.GetField<int>("HTTP_MOVED_PERM");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_MOVED_TEMP"/>
        /// </summary>
        public static int HTTP_MOVED_TEMP => Clazz.GetField<int>("HTTP_MOVED_TEMP");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_MULT_CHOICE"/>
        /// </summary>
        public static int HTTP_MULT_CHOICE => Clazz.GetField<int>("HTTP_MULT_CHOICE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NO_CONTENT"/>
        /// </summary>
        public static int HTTP_NO_CONTENT => Clazz.GetField<int>("HTTP_NO_CONTENT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_ACCEPTABLE"/>
        /// </summary>
        public static int HTTP_NOT_ACCEPTABLE => Clazz.GetField<int>("HTTP_NOT_ACCEPTABLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_AUTHORITATIVE"/>
        /// </summary>
        public static int HTTP_NOT_AUTHORITATIVE => Clazz.GetField<int>("HTTP_NOT_AUTHORITATIVE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_FOUND"/>
        /// </summary>
        public static int HTTP_NOT_FOUND => Clazz.GetField<int>("HTTP_NOT_FOUND");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_IMPLEMENTED"/>
        /// </summary>
        public static int HTTP_NOT_IMPLEMENTED => Clazz.GetField<int>("HTTP_NOT_IMPLEMENTED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_NOT_MODIFIED"/>
        /// </summary>
        public static int HTTP_NOT_MODIFIED => Clazz.GetField<int>("HTTP_NOT_MODIFIED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_OK"/>
        /// </summary>
        public static int HTTP_OK => Clazz.GetField<int>("HTTP_OK");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_PARTIAL"/>
        /// </summary>
        public static int HTTP_PARTIAL => Clazz.GetField<int>("HTTP_PARTIAL");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_PAYMENT_REQUIRED"/>
        /// </summary>
        public static int HTTP_PAYMENT_REQUIRED => Clazz.GetField<int>("HTTP_PAYMENT_REQUIRED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_PRECON_FAILED"/>
        /// </summary>
        public static int HTTP_PRECON_FAILED => Clazz.GetField<int>("HTTP_PRECON_FAILED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_PROXY_AUTH"/>
        /// </summary>
        public static int HTTP_PROXY_AUTH => Clazz.GetField<int>("HTTP_PROXY_AUTH");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_REQ_TOO_LONG"/>
        /// </summary>
        public static int HTTP_REQ_TOO_LONG => Clazz.GetField<int>("HTTP_REQ_TOO_LONG");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_RESET"/>
        /// </summary>
        public static int HTTP_RESET => Clazz.GetField<int>("HTTP_RESET");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_SEE_OTHER"/>
        /// </summary>
        public static int HTTP_SEE_OTHER => Clazz.GetField<int>("HTTP_SEE_OTHER");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_UNAUTHORIZED"/>
        /// </summary>
        public static int HTTP_UNAUTHORIZED => Clazz.GetField<int>("HTTP_UNAUTHORIZED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_UNAVAILABLE"/>
        /// </summary>
        public static int HTTP_UNAVAILABLE => Clazz.GetField<int>("HTTP_UNAVAILABLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_UNSUPPORTED_TYPE"/>
        /// </summary>
        public static int HTTP_UNSUPPORTED_TYPE => Clazz.GetField<int>("HTTP_UNSUPPORTED_TYPE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_USE_PROXY"/>
        /// </summary>
        public static int HTTP_USE_PROXY => Clazz.GetField<int>("HTTP_USE_PROXY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#HTTP_VERSION"/>
        /// </summary>
        public static int HTTP_VERSION => Clazz.GetField<int>("HTTP_VERSION");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getFollowRedirects()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setFollowRedirects(boolean)"/>
        /// </summary>
        public static bool FollowRedirects
        {
            get { return SExecute<bool>(LocalClazz, "getFollowRedirects"); } set { SExecute(LocalClazz, "setFollowRedirects", value); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getErrorStream()"/> 
        /// </summary>
        public Java.Io.InputStream ErrorStream
        {
            get { return IExecute<Java.Io.InputStream>("getErrorStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getInstanceFollowRedirects()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setInstanceFollowRedirects(boolean)"/>
        /// </summary>
        public bool InstanceFollowRedirects
        {
            get { return IExecute<bool>("getInstanceFollowRedirects"); } set { IExecute("setInstanceFollowRedirects", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getRequestMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setRequestMethod(java.lang.String)"/>
        /// </summary>
        public string RequestMethod
        {
            get { return IExecute<string>("getRequestMethod"); } set { IExecute("setRequestMethod", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getResponseCode()"/> 
        /// </summary>
        public int ResponseCode
        {
            get { return IExecute<int>("getResponseCode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#getResponseMessage()"/> 
        /// </summary>
        public string ResponseMessage
        {
            get { return IExecute<string>("getResponseMessage"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#usingProxy()"/> 
        /// </summary>
        public bool UsingProxy
        {
            get { return IExecute<bool>("usingProxy"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecute("disconnect");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setAuthenticator(java.net.Authenticator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Authenticator"/></param>
        public void SetAuthenticator(Java.Net.Authenticator arg0)
        {
            IExecute("setAuthenticator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setChunkedStreamingMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetChunkedStreamingMode(int arg0)
        {
            IExecute("setChunkedStreamingMode", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/HttpURLConnection.html#setFixedLengthStreamingMode(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetFixedLengthStreamingMode(int arg0)
        {
            IExecute("setFixedLengthStreamingMode", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}