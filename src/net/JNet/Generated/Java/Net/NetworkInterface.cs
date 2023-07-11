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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region NetworkInterface
    public partial class NetworkInterface
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getByIndex(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.NetworkInterface"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Net.NetworkInterface GetByIndex(int arg0)
        {
            return SExecute<Java.Net.NetworkInterface>(LocalBridgeClazz, "getByIndex", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getByInetAddress(java.net.InetAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <returns><see cref="Java.Net.NetworkInterface"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Net.NetworkInterface GetByInetAddress(Java.Net.InetAddress arg0)
        {
            return SExecute<Java.Net.NetworkInterface>(LocalBridgeClazz, "getByInetAddress", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getByName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Net.NetworkInterface"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Net.NetworkInterface GetByName(string arg0)
        {
            return SExecute<Java.Net.NetworkInterface>(LocalBridgeClazz, "getByName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getNetworkInterfaces()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Util.Enumeration<Java.Net.NetworkInterface> GetNetworkInterfaces()
        {
            return SExecute<Java.Util.Enumeration<Java.Net.NetworkInterface>>(LocalBridgeClazz, "getNetworkInterfaces");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#networkInterfaces()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public static Java.Util.Stream.Stream<Java.Net.NetworkInterface> NetworkInterfaces()
        {
            return SExecute<Java.Util.Stream.Stream<Java.Net.NetworkInterface>>(LocalBridgeClazz, "networkInterfaces");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getDisplayName()"/> 
        /// </summary>
        public string DisplayName
        {
            get { return IExecute<string>("getDisplayName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getHardwareAddress()"/> 
        /// </summary>
        public byte[] HardwareAddress
        {
            get { return IExecuteArray<byte>("getHardwareAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getIndex()"/> 
        /// </summary>
        public int Index
        {
            get { return IExecute<int>("getIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getInterfaceAddresses()"/> 
        /// </summary>
        public Java.Util.List<Java.Net.InterfaceAddress> InterfaceAddresses
        {
            get { return IExecute<Java.Util.List<Java.Net.InterfaceAddress>>("getInterfaceAddresses"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getMTU()"/> 
        /// </summary>
        public int MTU
        {
            get { return IExecute<int>("getMTU"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getParent()"/> 
        /// </summary>
        public Java.Net.NetworkInterface Parent
        {
            get { return IExecute<Java.Net.NetworkInterface>("getParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#isLoopback()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool IsLoopback()
        {
            return IExecute<bool>("isLoopback");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#isPointToPoint()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool IsPointToPoint()
        {
            return IExecute<bool>("isPointToPoint");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#isUp()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool IsUp()
        {
            return IExecute<bool>("isUp");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#isVirtual()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsVirtual()
        {
            return IExecute<bool>("isVirtual");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#supportsMulticast()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Net.SocketException"/>
        public bool SupportsMulticast()
        {
            return IExecute<bool>("supportsMulticast");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getInetAddresses()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Net.InetAddress> GetInetAddresses()
        {
            return IExecute<Java.Util.Enumeration<Java.Net.InetAddress>>("getInetAddresses");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#getSubInterfaces()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Enumeration"/></returns>
        public Java.Util.Enumeration<Java.Net.NetworkInterface> GetSubInterfaces()
        {
            return IExecute<Java.Util.Enumeration<Java.Net.NetworkInterface>>("getSubInterfaces");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#inetAddresses()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Net.InetAddress> InetAddresses()
        {
            return IExecute<Java.Util.Stream.Stream<Java.Net.InetAddress>>("inetAddresses");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/NetworkInterface.html#subInterfaces()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<Java.Net.NetworkInterface> SubInterfaces()
        {
            return IExecute<Java.Util.Stream.Stream<Java.Net.NetworkInterface>>("subInterfaces");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}