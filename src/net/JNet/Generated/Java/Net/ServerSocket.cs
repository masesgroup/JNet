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

namespace Java.Net
{
    #region ServerSocket
    public partial class ServerSocket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#%3Cinit%3E(int,int,java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ServerSocket(int arg0, int arg1, Java.Net.InetAddress arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#%3Cinit%3E(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ServerSocket(int arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ServerSocket(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#setSocketFactory(java.net.SocketImplFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketImplFactory"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void SetSocketFactory(Java.Net.SocketImplFactory arg0)
        {
            SExecute(LocalBridgeClazz, "setSocketFactory", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#getChannel()"/> 
        /// </summary>
        public Java.Nio.Channels.ServerSocketChannel Channel
        {
            get { return IExecute<Java.Nio.Channels.ServerSocketChannel>("getChannel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#getInetAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress InetAddress
        {
            get { return IExecute<Java.Net.InetAddress>("getInetAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#getLocalPort()"/> 
        /// </summary>
        public int LocalPort
        {
            get { return IExecute<int>("getLocalPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#getLocalSocketAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalSocketAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getLocalSocketAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#getReceiveBufferSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#setReceiveBufferSize(int)"/>
        /// </summary>
        public int ReceiveBufferSize
        {
            get { return IExecute<int>("getReceiveBufferSize"); } set { IExecute("setReceiveBufferSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#getReuseAddress()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#setReuseAddress(boolean)"/>
        /// </summary>
        public bool ReuseAddress
        {
            get { return IExecute<bool>("getReuseAddress"); } set { IExecute("setReuseAddress", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#getSoTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#setSoTimeout(int)"/>
        /// </summary>
        public int SoTimeout
        {
            get { return IExecute<int>("getSoTimeout"); } set { IExecute("setSoTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Net.ServerSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.ServerSocket SetOption<T>(Java.Net.SocketOption<T> arg0, T arg1)
        {
            return IExecute<Java.Net.ServerSocket>("setOption", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#getOption(java.net.SocketOption)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><typeparamref name="T"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public T GetOption<T>(Java.Net.SocketOption<T> arg0)
        {
            return IExecute<T>("getOption", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#isBound()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsBound()
        {
            return IExecute<bool>("isBound");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#isClosed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecute<bool>("isClosed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#accept()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.Socket Accept()
        {
            return IExecute<Java.Net.Socket>("accept");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#supportedOptions()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Net.SocketOption<object>> SupportedOptions()
        {
            return IExecute<Java.Util.Set<Java.Net.SocketOption<object>>>("supportedOptions");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#bind(java.net.SocketAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Bind(Java.Net.SocketAddress arg0, int arg1)
        {
            IExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Bind(Java.Net.SocketAddress arg0)
        {
            IExecute("bind", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ServerSocket.html#setPerformancePreferences(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetPerformancePreferences(int arg0, int arg1, int arg2)
        {
            IExecute("setPerformancePreferences", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}