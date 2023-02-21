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

namespace Java.Net
{
    #region ProxySelector
    public partial class ProxySelector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#getDefault() https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#setDefault(java.net.ProxySelector)
        /// </summary>
        public static Java.Net.ProxySelector Default
        {
            get { return SExecute<Java.Net.ProxySelector>("getDefault"); } set { SExecute("setDefault", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#of(java.net.InetSocketAddress)
        /// </summary>
        public static Java.Net.ProxySelector Of(Java.Net.InetSocketAddress arg0)
        {
            return SExecute<Java.Net.ProxySelector>("of", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/ProxySelector.html#connectFailed(java.net.URI,java.net.SocketAddress,java.io.IOException)
        /// </summary>
        public void ConnectFailed(Java.Net.URI arg0, Java.Net.SocketAddress arg1, Java.Io.IOException arg2)
        {
            IExecute("connectFailed", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}