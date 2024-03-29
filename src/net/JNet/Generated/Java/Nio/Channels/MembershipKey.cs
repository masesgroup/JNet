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

namespace Java.Nio.Channels
{
    #region MembershipKey
    public partial class MembershipKey
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#isValid()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsValid()
        {
            return IExecuteWithSignature<bool>("isValid", "()Z");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#group()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress Group()
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("group", "()Ljava/net/InetAddress;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#sourceAddress()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress SourceAddress()
        {
            return IExecuteWithSignature<Java.Net.InetAddress>("sourceAddress", "()Ljava/net/InetAddress;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#networkInterface()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.NetworkInterface"/></returns>
        public Java.Net.NetworkInterface NetworkInterface()
        {
            return IExecuteWithSignature<Java.Net.NetworkInterface>("networkInterface", "()Ljava/net/NetworkInterface;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#block(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.MembershipKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.MembershipKey Block(Java.Net.InetAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.MembershipKey>("block", "(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#unblock(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.MembershipKey"/></returns>
        public Java.Nio.Channels.MembershipKey Unblock(Java.Net.InetAddress arg0)
        {
            return IExecuteWithSignature<Java.Nio.Channels.MembershipKey>("unblock", "(Ljava/net/InetAddress;)Ljava/nio/channels/MembershipKey;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#channel()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.MulticastChannel"/></returns>
        public Java.Nio.Channels.MulticastChannel Channel()
        {
            return IExecuteWithSignature<Java.Nio.Channels.MulticastChannel>("channel", "()Ljava/nio/channels/MulticastChannel;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#drop()"/>
        /// </summary>
        public void Drop()
        {
            IExecuteWithSignature("drop", "()V");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}