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
    #region SocketOptions
    public partial class SocketOptions
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#TCP_NODELAY
        /// </summary>
        public static int TCP_NODELAY => Clazz.GetField<int>("TCP_NODELAY");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_BINDADDR
        /// </summary>
        public static int SO_BINDADDR => Clazz.GetField<int>("SO_BINDADDR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_REUSEADDR
        /// </summary>
        public static int SO_REUSEADDR => Clazz.GetField<int>("SO_REUSEADDR");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_REUSEPORT
        /// </summary>
        public static int SO_REUSEPORT => Clazz.GetField<int>("SO_REUSEPORT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_BROADCAST
        /// </summary>
        public static int SO_BROADCAST => Clazz.GetField<int>("SO_BROADCAST");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#IP_MULTICAST_IF
        /// </summary>
        public static int IP_MULTICAST_IF => Clazz.GetField<int>("IP_MULTICAST_IF");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#IP_MULTICAST_IF2
        /// </summary>
        public static int IP_MULTICAST_IF2 => Clazz.GetField<int>("IP_MULTICAST_IF2");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#IP_MULTICAST_LOOP
        /// </summary>
        public static int IP_MULTICAST_LOOP => Clazz.GetField<int>("IP_MULTICAST_LOOP");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#IP_TOS
        /// </summary>
        public static int IP_TOS => Clazz.GetField<int>("IP_TOS");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_LINGER
        /// </summary>
        public static int SO_LINGER => Clazz.GetField<int>("SO_LINGER");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_TIMEOUT
        /// </summary>
        public static int SO_TIMEOUT => Clazz.GetField<int>("SO_TIMEOUT");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_SNDBUF
        /// </summary>
        public static int SO_SNDBUF => Clazz.GetField<int>("SO_SNDBUF");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_RCVBUF
        /// </summary>
        public static int SO_RCVBUF => Clazz.GetField<int>("SO_RCVBUF");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_KEEPALIVE
        /// </summary>
        public static int SO_KEEPALIVE => Clazz.GetField<int>("SO_KEEPALIVE");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#SO_OOBINLINE
        /// </summary>
        public static int SO_OOBINLINE => Clazz.GetField<int>("SO_OOBINLINE");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#getOption(int) throws java.net.SocketException
        /// </summary>
        public object GetOption(int arg0)
        {
            return IExecute("getOption", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/SocketOptions.html#setOption(int,java.lang.Object) throws java.net.SocketException
        /// </summary>
        public void SetOption(int arg0, object arg1)
        {
            IExecute("setOption", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}