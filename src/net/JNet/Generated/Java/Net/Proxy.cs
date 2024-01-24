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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region Proxy
    public partial class Proxy
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.html#%3Cinit%3E(java.net.Proxy.Type,java.net.SocketAddress)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Proxy.Type"/></param>
        /// <param name="arg1"><see cref="Java.Net.SocketAddress"/></param>
        public Proxy(Java.Net.Proxy.Type arg0, Java.Net.SocketAddress arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.html#NO_PROXY"/>
        /// </summary>
        public static Java.Net.Proxy NO_PROXY { get { if (!_NO_PROXYReady) { _NO_PROXYContent = SGetField<Java.Net.Proxy>(LocalBridgeClazz, "NO_PROXY"); _NO_PROXYReady = true; } return _NO_PROXYContent; } }
        private static Java.Net.Proxy _NO_PROXYContent = default;
        private static bool _NO_PROXYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.html#type()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.Proxy.Type"/></returns>
        public Java.Net.Proxy.Type TypeMethod()
        {
            return IExecute<Java.Net.Proxy.Type>("type");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.html#address()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.SocketAddress"/></returns>
        public Java.Net.SocketAddress Address()
        {
            return IExecute<Java.Net.SocketAddress>("address");
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.Type.html#DIRECT"/>
            /// </summary>
            public static Java.Net.Proxy.Type DIRECT { get { if (!_DIRECTReady) { _DIRECTContent = SGetField<Java.Net.Proxy.Type>(LocalBridgeClazz, "DIRECT"); _DIRECTReady = true; } return _DIRECTContent; } }
            private static Java.Net.Proxy.Type _DIRECTContent = default;
            private static bool _DIRECTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.Type.html#HTTP"/>
            /// </summary>
            public static Java.Net.Proxy.Type HTTP { get { if (!_HTTPReady) { _HTTPContent = SGetField<Java.Net.Proxy.Type>(LocalBridgeClazz, "HTTP"); _HTTPReady = true; } return _HTTPContent; } }
            private static Java.Net.Proxy.Type _HTTPContent = default;
            private static bool _HTTPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.Type.html#SOCKS"/>
            /// </summary>
            public static Java.Net.Proxy.Type SOCKS { get { if (!_SOCKSReady) { _SOCKSContent = SGetField<Java.Net.Proxy.Type>(LocalBridgeClazz, "SOCKS"); _SOCKSReady = true; } return _SOCKSContent; } }
            private static Java.Net.Proxy.Type _SOCKSContent = default;
            private static bool _SOCKSReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.Type.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Net.Proxy.Type"/></returns>
            public static Java.Net.Proxy.Type ValueOf(string arg0)
            {
                return SExecute<Java.Net.Proxy.Type>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Proxy.Type.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Net.Proxy.Type"/></returns>
            public static Java.Net.Proxy.Type[] Values()
            {
                return SExecuteArray<Java.Net.Proxy.Type>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}