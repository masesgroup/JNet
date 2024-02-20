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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.Channels.Spi
{
    #region AsynchronousChannelProvider
    public partial class AsynchronousChannelProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/AsynchronousChannelProvider.html#provider()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.Spi.AsynchronousChannelProvider"/></returns>
        public static Java.Nio.Channels.Spi.AsynchronousChannelProvider Provider()
        {
            return SExecute<Java.Nio.Channels.Spi.AsynchronousChannelProvider>(LocalBridgeClazz, "provider");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/AsynchronousChannelProvider.html#openAsynchronousChannelGroup(int,java.util.concurrent.ThreadFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Util.Concurrent.ThreadFactory"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousChannelGroup OpenAsynchronousChannelGroup(int arg0, Java.Util.Concurrent.ThreadFactory arg1)
        {
            return IExecute<Java.Nio.Channels.AsynchronousChannelGroup>("openAsynchronousChannelGroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/AsynchronousChannelProvider.html#openAsynchronousChannelGroup(java.util.concurrent.ExecutorService,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Concurrent.ExecutorService"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousChannelGroup OpenAsynchronousChannelGroup(Java.Util.Concurrent.ExecutorService arg0, int arg1)
        {
            return IExecute<Java.Nio.Channels.AsynchronousChannelGroup>("openAsynchronousChannelGroup", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/AsynchronousChannelProvider.html#openAsynchronousServerSocketChannel(java.nio.channels.AsynchronousChannelGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousServerSocketChannel OpenAsynchronousServerSocketChannel(Java.Nio.Channels.AsynchronousChannelGroup arg0)
        {
            return IExecute<Java.Nio.Channels.AsynchronousServerSocketChannel>("openAsynchronousServerSocketChannel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/AsynchronousChannelProvider.html#openAsynchronousSocketChannel(java.nio.channels.AsynchronousChannelGroup)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.Channels.AsynchronousChannelGroup"/></param>
        /// <returns><see cref="Java.Nio.Channels.AsynchronousSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.AsynchronousSocketChannel OpenAsynchronousSocketChannel(Java.Nio.Channels.AsynchronousChannelGroup arg0)
        {
            return IExecute<Java.Nio.Channels.AsynchronousSocketChannel>("openAsynchronousSocketChannel", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}