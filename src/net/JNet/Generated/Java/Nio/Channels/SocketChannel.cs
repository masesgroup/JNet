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

namespace Java.Nio.Channels
{
    #region SocketChannel
    public partial class SocketChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.SocketChannel"/> to <see cref="Java.Nio.Channels.ByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.ByteChannel(Java.Nio.Channels.SocketChannel t) => t.Cast<Java.Nio.Channels.ByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.SocketChannel"/> to <see cref="Java.Nio.Channels.ScatteringByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.ScatteringByteChannel(Java.Nio.Channels.SocketChannel t) => t.Cast<Java.Nio.Channels.ScatteringByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.SocketChannel"/> to <see cref="Java.Nio.Channels.GatheringByteChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.GatheringByteChannel(Java.Nio.Channels.SocketChannel t) => t.Cast<Java.Nio.Channels.GatheringByteChannel>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.Channels.SocketChannel"/> to <see cref="Java.Nio.Channels.NetworkChannel"/>
        /// </summary>
        public static implicit operator Java.Nio.Channels.NetworkChannel(Java.Nio.Channels.SocketChannel t) => t.Cast<Java.Nio.Channels.NetworkChannel>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#open()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.SocketChannel Open()
        {
            return SExecute<Java.Nio.Channels.SocketChannel>("open");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#open(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.Channels.SocketChannel Open(Java.Net.SocketAddress arg0)
        {
            return SExecute<Java.Nio.Channels.SocketChannel>("open", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#getLocalAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress LocalAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getLocalAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#getRemoteAddress()"/> 
        /// </summary>
        public Java.Net.SocketAddress RemoteAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getRemoteAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#connect(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool Connect(Java.Net.SocketAddress arg0)
        {
            return IExecute<bool>("connect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#finishConnect()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool FinishConnect()
        {
            return IExecute<bool>("finishConnect");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#isConnected()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsConnected()
        {
            return IExecute<bool>("isConnected");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#isConnectionPending()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsConnectionPending()
        {
            return IExecute<bool>("isConnectionPending");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#read(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<int>("read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#write(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<int>("write", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#socket()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Net.Socket"/></returns>
        public Java.Net.Socket Socket()
        {
            return IExecute<Java.Net.Socket>("socket");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#shutdownInput()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SocketChannel ShutdownInput()
        {
            return IExecute<Java.Nio.Channels.SocketChannel>("shutdownInput");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#shutdownOutput()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SocketChannel ShutdownOutput()
        {
            return IExecute<Java.Nio.Channels.SocketChannel>("shutdownOutput");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#read(java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see langword="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2)
        {
            return IExecute<long>("read", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#write(java.nio.ByteBuffer[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see langword="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Write(Java.Nio.ByteBuffer[] arg0, int arg1, int arg2)
        {
            return IExecute<long>("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#read(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Read(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecute<long>("read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#write(java.nio.ByteBuffer[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long Write(Java.Nio.ByteBuffer[] arg0)
        {
            return IExecute<long>("write", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#bind(java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecute<Java.Nio.Channels.NetworkChannel>("bind", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/SocketChannel.html#setOption(java.net.SocketOption,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.SocketOption"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="Java.Nio.Channels.NetworkChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.NetworkChannel SetOption(Java.Net.SocketOption arg0, object arg1)
        {
            return IExecute<Java.Nio.Channels.NetworkChannel>("setOption", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}