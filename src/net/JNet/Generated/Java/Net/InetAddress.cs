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

namespace Java.Net
{
    #region InetAddress
    public partial class InetAddress
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getLocalHost()"/> 
        /// </summary>
        public static Java.Net.InetAddress LocalHost
        {
            get { return SExecute<Java.Net.InetAddress>(LocalBridgeClazz, "getLocalHost"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getLoopbackAddress()"/> 
        /// </summary>
        public static Java.Net.InetAddress LoopbackAddress
        {
            get { return SExecute<Java.Net.InetAddress>(LocalBridgeClazz, "getLoopbackAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getByAddress(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.InetAddress GetByAddress(byte[] arg0)
        {
            return SExecute<Java.Net.InetAddress>(LocalBridgeClazz, "getByAddress", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getByAddress(java.lang.String,byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.InetAddress GetByAddress(string arg0, byte[] arg1)
        {
            return SExecute<Java.Net.InetAddress>(LocalBridgeClazz, "getByAddress", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.InetAddress GetByName(string arg0)
        {
            return SExecute<Java.Net.InetAddress>(LocalBridgeClazz, "getByName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getAllByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Net.InetAddress"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.InetAddress[] GetAllByName(string arg0)
        {
            return SExecuteArray<Java.Net.InetAddress>(LocalBridgeClazz, "getAllByName", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getAddress()"/> 
        /// </summary>
        public byte[] Address
        {
            get { return IExecuteArray<byte>("getAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getCanonicalHostName()"/> 
        /// </summary>
        public string CanonicalHostName
        {
            get { return IExecute<string>("getCanonicalHostName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getHostAddress()"/> 
        /// </summary>
        public string HostAddress
        {
            get { return IExecute<string>("getHostAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#getHostName()"/> 
        /// </summary>
        public string HostName
        {
            get { return IExecute<string>("getHostName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isAnyLocalAddress()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAnyLocalAddress()
        {
            return IExecute<bool>("isAnyLocalAddress");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isLinkLocalAddress()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLinkLocalAddress()
        {
            return IExecute<bool>("isLinkLocalAddress");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isLoopbackAddress()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLoopbackAddress()
        {
            return IExecute<bool>("isLoopbackAddress");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCGlobal()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMCGlobal()
        {
            return IExecute<bool>("isMCGlobal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCLinkLocal()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMCLinkLocal()
        {
            return IExecute<bool>("isMCLinkLocal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCNodeLocal()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMCNodeLocal()
        {
            return IExecute<bool>("isMCNodeLocal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCOrgLocal()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMCOrgLocal()
        {
            return IExecute<bool>("isMCOrgLocal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMCSiteLocal()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMCSiteLocal()
        {
            return IExecute<bool>("isMCSiteLocal");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isMulticastAddress()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsMulticastAddress()
        {
            return IExecute<bool>("isMulticastAddress");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isReachable(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsReachable(int arg0)
        {
            return IExecute<bool>("isReachable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isReachable(java.net.NetworkInterface,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.NetworkInterface"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsReachable(Java.Net.NetworkInterface arg0, int arg1, int arg2)
        {
            return IExecute<bool>("isReachable", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/InetAddress.html#isSiteLocalAddress()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsSiteLocalAddress()
        {
            return IExecute<bool>("isSiteLocalAddress");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}