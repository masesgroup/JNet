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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region InterfaceAddress
    public partial class InterfaceAddress
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InterfaceAddress.html#getAddress()"/> 
        /// </summary>
        public Java.Net.InetAddress Address
        {
            get { return IExecuteWithSignature<Java.Net.InetAddress>("getAddress", "()Ljava/net/InetAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InterfaceAddress.html#getBroadcast()"/> 
        /// </summary>
        public Java.Net.InetAddress Broadcast
        {
            get { return IExecuteWithSignature<Java.Net.InetAddress>("getBroadcast", "()Ljava/net/InetAddress;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InterfaceAddress.html#getNetworkPrefixLength()"/> 
        /// </summary>
        public short NetworkPrefixLength
        {
            get { return IExecuteWithSignature<short>("getNetworkPrefixLength", "()S"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}