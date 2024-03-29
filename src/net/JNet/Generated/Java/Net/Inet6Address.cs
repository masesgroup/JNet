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
    #region Inet6Address
    public partial class Inet6Address
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Inet6Address.html#getByAddress(java.lang.String,byte[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Net.Inet6Address"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.Inet6Address GetByAddress(Java.Lang.String arg0, byte[] arg1, int arg2)
        {
            return SExecute<Java.Net.Inet6Address>(LocalBridgeClazz, "getByAddress", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Inet6Address.html#getByAddress(java.lang.String,byte[],java.net.NetworkInterface)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="byte"/></param>
        /// <param name="arg2"><see cref="Java.Net.NetworkInterface"/></param>
        /// <returns><see cref="Java.Net.Inet6Address"/></returns>
        /// <exception cref="Java.Net.UnknownHostException"/>
        public static Java.Net.Inet6Address GetByAddress(Java.Lang.String arg0, byte[] arg1, Java.Net.NetworkInterface arg2)
        {
            return SExecute<Java.Net.Inet6Address>(LocalBridgeClazz, "getByAddress", arg0, arg1, arg2);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Inet6Address.html#getScopedInterface()"/> 
        /// </summary>
        public Java.Net.NetworkInterface ScopedInterface
        {
            get { return IExecuteWithSignature<Java.Net.NetworkInterface>("getScopedInterface", "()Ljava/net/NetworkInterface;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Inet6Address.html#getScopeId()"/> 
        /// </summary>
        public int ScopeId
        {
            get { return IExecuteWithSignature<int>("getScopeId", "()I"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Inet6Address.html#isIPv4CompatibleAddress()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsIPv4CompatibleAddress()
        {
            return IExecuteWithSignature<bool>("isIPv4CompatibleAddress", "()Z");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}