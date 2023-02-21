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

namespace Javax.Net
{
    #region ServerSocketFactory
    public partial class ServerSocketFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ServerSocketFactory.html#getDefault() 
        /// </summary>
        public static Javax.Net.ServerSocketFactory Default
        {
            get { return SExecute<Javax.Net.ServerSocketFactory>("getDefault"); }
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ServerSocketFactory.html#createServerSocket(int,int,java.net.InetAddress) throws java.io.IOException
        /// </summary>
        public Java.Net.ServerSocket CreateServerSocket(int arg0, int arg1, Java.Net.InetAddress arg2)
        {
            return IExecute<Java.Net.ServerSocket>("createServerSocket", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ServerSocketFactory.html#createServerSocket(int,int) throws java.io.IOException
        /// </summary>
        public Java.Net.ServerSocket CreateServerSocket(int arg0, int arg1)
        {
            return IExecute<Java.Net.ServerSocket>("createServerSocket", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ServerSocketFactory.html#createServerSocket(int) throws java.io.IOException
        /// </summary>
        public Java.Net.ServerSocket CreateServerSocket(int arg0)
        {
            return IExecute<Java.Net.ServerSocket>("createServerSocket", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/javax/net/ServerSocketFactory.html#createServerSocket() throws java.io.IOException
        /// </summary>
        public Java.Net.ServerSocket CreateServerSocket()
        {
            return IExecute<Java.Net.ServerSocket>("createServerSocket");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}