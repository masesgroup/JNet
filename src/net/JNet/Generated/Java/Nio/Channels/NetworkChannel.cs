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
    #region NetworkChannel
    public partial class NetworkChannel
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Nio.Channels.Channel(Java.Nio.Channels.NetworkChannel t) => t.Cast<Java.Nio.Channels.Channel>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/NetworkChannel.html#getLocalAddress() throws java.io.IOException 
        /// </summary>
        public Java.Net.SocketAddress LocalAddress
        {
            get { return IExecute<Java.Net.SocketAddress>("getLocalAddress"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/NetworkChannel.html#bind(java.net.SocketAddress) throws java.io.IOException
        /// </summary>
        public Java.Nio.Channels.NetworkChannel Bind(Java.Net.SocketAddress arg0)
        {
            return IExecute<Java.Nio.Channels.NetworkChannel>("bind", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}