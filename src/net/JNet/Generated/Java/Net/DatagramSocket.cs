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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region DatagramSocket
    public partial class DatagramSocket
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#%3Cinit%3E(int,java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Net.InetAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public DatagramSocket(int arg0, Java.Net.InetAddress arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public DatagramSocket(int arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#%3Cinit%3E(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public DatagramSocket(Java.Net.SocketAddress arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Net.DatagramSocket"/> to <see cref="Java.Io.Closeable"/>
        /// </summary>
        public static implicit operator Java.Io.Closeable(Java.Net.DatagramSocket t) => t.Cast<Java.Io.Closeable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#setDatagramSocketImplFactory(java.net.DatagramSocketImplFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramSocketImplFactory"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public static void SetDatagramSocketImplFactory(Java.Net.DatagramSocketImplFactory arg0)
        {
            SExecute("setDatagramSocketImplFactory", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getBroadcast()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#setBroadcast(boolean)"/>
        /// </summary>
        public bool Broadcast
        {
            get { return IExecute<bool>("getBroadcast"); } set { IExecute("setBroadcast", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getChannel()"/> 
        /// </summary>
        public Java.Nio.Channels.DatagramChannel Channel
        {
            get { return IExecute<Java.Nio.Channels.DatagramChannel>("getChannel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getInetAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress InetAddress
        {
            get { return IExecute<Java.Net.InetAddress>("getInetAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress LocalAddress
        {
            get { return IExecute<Java.Net.InetAddress>("getLocalAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getLocalPort()"/> 
        /// </summary>
        public int LocalPort
        {
            get { return IExecute<int>("getLocalPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getLocalSocketAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalSocketAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getLocalSocketAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getPort()"/> 
        /// </summary>
        public int Port
        {
            get { return IExecute<int>("getPort"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getReceiveBufferSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#setReceiveBufferSize(int)"/>
        /// </summary>
        public int ReceiveBufferSize
        {
            get { return IExecute<int>("getReceiveBufferSize"); } set { IExecute("setReceiveBufferSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getRemoteSocketAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress RemoteSocketAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getRemoteSocketAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getReuseAddress()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#setReuseAddress(boolean)"/>
        /// </summary>
        public bool ReuseAddress
        {
            get { return IExecute<bool>("getReuseAddress"); } set { IExecute("setReuseAddress", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getSendBufferSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#setSendBufferSize(int)"/>
        /// </summary>
        public int SendBufferSize
        {
            get { return IExecute<int>("getSendBufferSize"); } set { IExecute("setSendBufferSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getSoTimeout()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#setSoTimeout(int)"/>
        /// </summary>
        public int SoTimeout
        {
            get { return IExecute<int>("getSoTimeout"); } set { IExecute("setSoTimeout", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getTrafficClass()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#setTrafficClass(int)"/>
        /// </summary>
        public int TrafficClass
        {
            get { return IExecute<int>("getTrafficClass"); } set { IExecute("setTrafficClass", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Net.DatagramSocket"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Net.DatagramSocket SetOption(Java.Net.SocketOption arg0, object arg1)
        {
            return IExecute<Java.Net.DatagramSocket>("setOption", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#getOption(java.net.SocketOption)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetOption(Java.Net.SocketOption arg0)
        {
            return IExecute("getOption", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#isBound()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsBound()
        {
            return IExecute<bool>("isBound");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#isClosed()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsClosed()
        {
            return IExecute<bool>("isClosed");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#isConnected()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsConnected()
        {
            return IExecute<bool>("isConnected");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#supportedOptions()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set SupportedOptions()
        {
            return IExecute<Java.Util.Set>("supportedOptions");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void Bind(Java.Net.SocketAddress arg0)
        {
            IExecute("bind", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#receive(java.net.DatagramPacket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramPacket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Receive(Java.Net.DatagramPacket arg0)
        {
            IExecute("receive", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#close()"/>
        /// </summary>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#connect(java.net.InetAddress,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Connect(Java.Net.InetAddress arg0, int arg1)
        {
            IExecute("connect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <exception cref="Java.Net.SocketException"/>
        public void Connect(Java.Net.SocketAddress arg0)
        {
            IExecute("connect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#disconnect()"/>
        /// </summary>
        public void Disconnect()
        {
            IExecute("disconnect");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/DatagramSocket.html#send(java.net.DatagramPacket)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.DatagramPacket"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Send(Java.Net.DatagramPacket arg0)
        {
            IExecute("send", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}