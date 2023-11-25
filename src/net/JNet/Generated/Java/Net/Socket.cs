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
    #region Socket
    public partial class Socket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.lang.String,int,java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Socket(string arg0, int arg1, Java.Net.InetAddress arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Net.UnknownHostException"/>
        /// <exception cref="Java.Io.IOException"/>
        public Socket(string arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.net.InetAddress,int,java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Socket(Java.Net.InetAddress arg0, int arg1, Java.Net.InetAddress arg2, int arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public Socket(Java.Net.InetAddress arg0, int arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#%3Cinit%3E(java.net.Proxy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Proxy"/></param>
        public Socket(Java.Net.Proxy arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setSocketImplFactory(java.net.SocketImplFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketImplFactory"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void SetSocketImplFactory(Java.Net.SocketImplFactory arg0)
        {
            SExecute(LocalBridgeClazz, "setSocketImplFactory", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getChannel()"/> 
        /// </summary>
        public Java.Nio.Channels.SocketChannel Channel
        {
            get { return IExecute<Java.Nio.Channels.SocketChannel>("getChannel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getInetAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress InetAddress
        {
            get { return IExecute<Java.Net.InetAddress>("getInetAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getInputStream()"/> 
        /// </summary>
        public Java.Io.InputStream InputStream
        {
            get { return IExecute<Java.Io.InputStream>("getInputStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getKeepAlive()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setKeepAlive(boolean)"/>
        /// </summary>
        public bool KeepAlive
        {
            get { return IExecute<bool>("getKeepAlive"); } set { IExecute("setKeepAlive", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress LocalAddress
        {
            get { return IExecute<Java.Net.InetAddress>("getLocalAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getLocalPort()"/> 
        /// </summary>
        public int LocalPort
        {
            get { return IExecute<int>("getLocalPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getLocalSocketAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalSocketAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getLocalSocketAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getOOBInline()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setOOBInline(boolean)"/>
        /// </summary>
        public bool OOBInline
        {
            get { return IExecute<bool>("getOOBInline"); } set { IExecute("setOOBInline", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getOutputStream()"/> 
        /// </summary>
        public Java.Io.OutputStream OutputStream
        {
            get { return IExecute<Java.Io.OutputStream>("getOutputStream"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getPort()"/> 
        /// </summary>
        public int Port
        {
            get { return IExecute<int>("getPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getReceiveBufferSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setReceiveBufferSize(int)"/>
        /// </summary>
        public int ReceiveBufferSize
        {
            get { return IExecute<int>("getReceiveBufferSize"); } set { IExecute("setReceiveBufferSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getRemoteSocketAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress RemoteSocketAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getRemoteSocketAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getReuseAddress()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setReuseAddress(boolean)"/>
        /// </summary>
        public bool ReuseAddress
        {
            get { return IExecute<bool>("getReuseAddress"); } set { IExecute("setReuseAddress", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getSendBufferSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setSendBufferSize(int)"/>
        /// </summary>
        public int SendBufferSize
        {
            get { return IExecute<int>("getSendBufferSize"); } set { IExecute("setSendBufferSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getSoLinger()"/> 
        /// </summary>
        public int SoLinger
        {
            get { return IExecute<int>("getSoLinger"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getSoTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setSoTimeout(int)"/>
        /// </summary>
        public int SoTimeout
        {
            get { return IExecute<int>("getSoTimeout"); } set { IExecute("setSoTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getTcpNoDelay()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setTcpNoDelay(boolean)"/>
        /// </summary>
        public bool TcpNoDelay
        {
            get { return IExecute<bool>("getTcpNoDelay"); } set { IExecute("setTcpNoDelay", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getTrafficClass()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setTrafficClass(int)"/>
        /// </summary>
        public int TrafficClass
        {
            get { return IExecute<int>("getTrafficClass"); } set { IExecute("setTrafficClass", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Net.Socket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.Socket SetOption<T>(Java.Net.SocketOption<T> arg0, T arg1)
        {
            return IExecute<Java.Net.Socket>("setOption", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#getOption(java.net.SocketOption)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isBound()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsBound()
        {
            return IExecute<bool>("isBound");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isClosed()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecute<bool>("isClosed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isConnected()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecute<bool>("isConnected");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isInputShutdown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsInputShutdown()
        {
            return IExecute<bool>("isInputShutdown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#isOutputShutdown()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsOutputShutdown()
        {
            return IExecute<bool>("isOutputShutdown");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#supportedOptions()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Net.SocketOption<object>> SupportedOptions()
        {
            return IExecute<Java.Util.Set<Java.Net.SocketOption<object>>>("supportedOptions");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#close()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Bind(Java.Net.SocketAddress arg0)
        {
            IExecute("bind", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#connect(java.net.SocketAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect(Java.Net.SocketAddress arg0, int arg1)
        {
            IExecute("connect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect(Java.Net.SocketAddress arg0)
        {
            IExecute("connect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#sendUrgentData(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SendUrgentData(int arg0)
        {
            IExecute("sendUrgentData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setPerformancePreferences(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetPerformancePreferences(int arg0, int arg1, int arg2)
        {
            IExecute("setPerformancePreferences", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#setSoLinger(boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void SetSoLinger(bool arg0, int arg1)
        {
            IExecute("setSoLinger", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#shutdownInput()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void ShutdownInput()
        {
            IExecute("shutdownInput");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Socket.html#shutdownOutput()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void ShutdownOutput()
        {
            IExecute("shutdownOutput");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}