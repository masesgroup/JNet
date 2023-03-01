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

namespace Java.Net.Http
{
    #region WebSocket
    public partial class WebSocket
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#NORMAL_CLOSURE"/>
        /// </summary>
        public static int NORMAL_CLOSURE => Clazz.GetField<int>("NORMAL_CLOSURE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#getSubprotocol()"/> 
        /// </summary>
        public string Subprotocol
        {
            get { return IExecute<string>("getSubprotocol"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#isInputClosed()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsInputClosed()
        {
            return IExecute<bool>("isInputClosed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#isOutputClosed()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsOutputClosed()
        {
            return IExecute<bool>("isOutputClosed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendBinary(java.nio.ByteBuffer,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture SendBinary(Java.Nio.ByteBuffer arg0, bool arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture>("sendBinary", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendClose(int,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture SendClose(int arg0, string arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture>("sendClose", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendPing(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture SendPing(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture>("sendPing", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendPong(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture SendPong(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture>("sendPong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#sendText(java.lang.CharSequence,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.CharSequence"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
        public Java.Util.Concurrent.CompletableFuture SendText(Java.Lang.CharSequence arg0, bool arg1)
        {
            return IExecute<Java.Util.Concurrent.CompletableFuture>("sendText", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecute("abort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.html#request(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        public void Request(long arg0)
        {
            IExecute("request", arg0);
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

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Builder.html#connectTimeout(java.time.Duration)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Time.Duration"/></param>
            /// <returns><see cref="Java.Net.Http.WebSocket.Builder"/></returns>
            public Java.Net.Http.WebSocket.Builder ConnectTimeout(Java.Time.Duration arg0)
            {
                return IExecute<Java.Net.Http.WebSocket.Builder>("connectTimeout", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Builder.html#header(java.lang.String,java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <returns><see cref="Java.Net.Http.WebSocket.Builder"/></returns>
            public Java.Net.Http.WebSocket.Builder Header(string arg0, string arg1)
            {
                return IExecute<Java.Net.Http.WebSocket.Builder>("header", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Builder.html#subprotocols(java.lang.String,java.lang.String...)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <returns><see cref="Java.Net.Http.WebSocket.Builder"/></returns>
            public Java.Net.Http.WebSocket.Builder Subprotocols(string arg0, params string[] arg1)
            {
                if (arg1.Length == 0) return IExecute<Java.Net.Http.WebSocket.Builder>("subprotocols", arg0); else return IExecute<Java.Net.Http.WebSocket.Builder>("subprotocols", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.net.http/java/net/http/WebSocket.Builder.html#buildAsync(java.net.URI,java.net.http.WebSocket$Listener)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Net.URI"/></param>
            /// <param name="arg1"><see cref="Java.Net.Http.WebSocket.Listener"/></param>
            /// <returns><see cref="Java.Util.Concurrent.CompletableFuture"/></returns>
            public Java.Util.Concurrent.CompletableFuture BuildAsync(Java.Net.URI arg0, Java.Net.Http.WebSocket.Listener arg1)
            {
                return IExecute<Java.Util.Concurrent.CompletableFuture>("buildAsync", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}