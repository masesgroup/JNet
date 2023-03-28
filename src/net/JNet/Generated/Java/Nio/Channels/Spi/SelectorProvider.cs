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

namespace Java.Nio.Channels.Spi
{
    #region SelectorProvider
    public partial class SelectorProvider
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#provider()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.Spi.SelectorProvider"/></returns>
        public static Java.Nio.Channels.Spi.SelectorProvider Provider()
        {
            return SExecute<Java.Nio.Channels.Spi.SelectorProvider>("provider");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openDatagramChannel()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.DatagramChannel OpenDatagramChannel()
        {
            return IExecute<Java.Nio.Channels.DatagramChannel>("openDatagramChannel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openDatagramChannel(java.net.ProtocolFamily)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.ProtocolFamily"/></param>
        /// <returns><see cref="Java.Nio.Channels.DatagramChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.DatagramChannel OpenDatagramChannel(Java.Net.ProtocolFamily arg0)
        {
            return IExecute<Java.Nio.Channels.DatagramChannel>("openDatagramChannel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openPipe()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.Pipe"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.Pipe OpenPipe()
        {
            return IExecute<Java.Nio.Channels.Pipe>("openPipe");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openServerSocketChannel()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.ServerSocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.ServerSocketChannel OpenServerSocketChannel()
        {
            return IExecute<Java.Nio.Channels.ServerSocketChannel>("openServerSocketChannel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openSocketChannel()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.SocketChannel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.SocketChannel OpenSocketChannel()
        {
            return IExecute<Java.Nio.Channels.SocketChannel>("openSocketChannel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#openSelector()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.Spi.AbstractSelector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.Spi.AbstractSelector OpenSelector()
        {
            return IExecute<Java.Nio.Channels.Spi.AbstractSelector>("openSelector");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/spi/SelectorProvider.html#inheritedChannel()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.Channels.Channel"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.Channel InheritedChannel()
        {
            return IExecute<Java.Nio.Channels.Channel>("inheritedChannel");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}