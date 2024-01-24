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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
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
            return IExecute<bool>("isValid");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#group()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress Group()
        {
            return IExecute<Java.Net.InetAddress>("group");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#sourceAddress()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        public Java.Net.InetAddress SourceAddress()
        {
            return IExecute<Java.Net.InetAddress>("sourceAddress");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#networkInterface()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.NetworkInterface"/></returns>
        public Java.Net.NetworkInterface NetworkInterface()
        {
            return IExecute<Java.Net.NetworkInterface>("networkInterface");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#block(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.MembershipKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.Channels.MembershipKey Block(Java.Net.InetAddress arg0)
        {
            return IExecute<Java.Nio.Channels.MembershipKey>("block", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#unblock(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Java.Nio.Channels.MembershipKey"/></returns>
        public Java.Nio.Channels.MembershipKey Unblock(Java.Net.InetAddress arg0)
        {
            return IExecute<Java.Nio.Channels.MembershipKey>("unblock", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#channel()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Channels.MulticastChannel"/></returns>
        public Java.Nio.Channels.MulticastChannel Channel()
        {
            return IExecute<Java.Nio.Channels.MulticastChannel>("channel");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/channels/MembershipKey.html#drop()"/>
        /// </summary>
        public void Drop()
        {
            IExecute("drop");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}