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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Net
{
    #region Authenticator
    public partial class Authenticator
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.html#getDefault()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.html#setDefault(java.net.Authenticator)"/>
        /// </summary>
        public static Java.Net.Authenticator Default
        {
            get { return SExecute<Java.Net.Authenticator>("getDefault"); } set { SExecute("setDefault", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.html#requestPasswordAuthentication(java.lang.String,java.net.InetAddress,int,java.lang.String,java.lang.String,java.lang.String,java.net.URL,java.net.Authenticator.RequestorType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="Java.Net.URL"/></param>
        /// <param name="arg7"><see cref="Java.Net.Authenticator.RequestorType"/></param>
        /// <returns><see cref="Java.Net.PasswordAuthentication"/></returns>
        public static Java.Net.PasswordAuthentication RequestPasswordAuthentication(string arg0, Java.Net.InetAddress arg1, int arg2, string arg3, string arg4, string arg5, Java.Net.URL arg6, Java.Net.Authenticator.RequestorType arg7)
        {
            return SExecute<Java.Net.PasswordAuthentication>("requestPasswordAuthentication", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.html#requestPasswordAuthentication(java.lang.String,java.net.InetAddress,int,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <returns><see cref="Java.Net.PasswordAuthentication"/></returns>
        public static Java.Net.PasswordAuthentication RequestPasswordAuthentication(string arg0, Java.Net.InetAddress arg1, int arg2, string arg3, string arg4, string arg5)
        {
            return SExecute<Java.Net.PasswordAuthentication>("requestPasswordAuthentication", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.html#requestPasswordAuthentication(java.net.Authenticator,java.lang.String,java.net.InetAddress,int,java.lang.String,java.lang.String,java.lang.String,java.net.URL,java.net.Authenticator.RequestorType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.Authenticator"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="string"/></param>
        /// <param name="arg7"><see cref="Java.Net.URL"/></param>
        /// <param name="arg8"><see cref="Java.Net.Authenticator.RequestorType"/></param>
        /// <returns><see cref="Java.Net.PasswordAuthentication"/></returns>
        public static Java.Net.PasswordAuthentication RequestPasswordAuthentication(Java.Net.Authenticator arg0, string arg1, Java.Net.InetAddress arg2, int arg3, string arg4, string arg5, string arg6, Java.Net.URL arg7, Java.Net.Authenticator.RequestorType arg8)
        {
            return SExecute<Java.Net.PasswordAuthentication>("requestPasswordAuthentication", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.html#requestPasswordAuthentication(java.net.InetAddress,int,java.lang.String,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <returns><see cref="Java.Net.PasswordAuthentication"/></returns>
        public static Java.Net.PasswordAuthentication RequestPasswordAuthentication(Java.Net.InetAddress arg0, int arg1, string arg2, string arg3, string arg4)
        {
            return SExecute<Java.Net.PasswordAuthentication>("requestPasswordAuthentication", arg0, arg1, arg2, arg3, arg4);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.html#requestPasswordAuthenticationInstance(java.lang.String,java.net.InetAddress,int,java.lang.String,java.lang.String,java.lang.String,java.net.URL,java.net.Authenticator.RequestorType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Net.InetAddress"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="Java.Net.URL"/></param>
        /// <param name="arg7"><see cref="Java.Net.Authenticator.RequestorType"/></param>
        /// <returns><see cref="Java.Net.PasswordAuthentication"/></returns>
        public Java.Net.PasswordAuthentication RequestPasswordAuthenticationInstance(string arg0, Java.Net.InetAddress arg1, int arg2, string arg3, string arg4, string arg5, Java.Net.URL arg6, Java.Net.Authenticator.RequestorType arg7)
        {
            return IExecute<Java.Net.PasswordAuthentication>("requestPasswordAuthenticationInstance", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        
        #endregion

        #region Nested classes
        #region RequestorType
        public partial class RequestorType
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.RequestorType.html#PROXY"/>
            /// </summary>
            public static Java.Net.Authenticator.RequestorType PROXY => Clazz.GetField<Java.Net.Authenticator.RequestorType>("PROXY");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.RequestorType.html#SERVER"/>
            /// </summary>
            public static Java.Net.Authenticator.RequestorType SERVER => Clazz.GetField<Java.Net.Authenticator.RequestorType>("SERVER");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.RequestorType.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Net.Authenticator.RequestorType"/></returns>
            public static Java.Net.Authenticator.RequestorType ValueOf(string arg0)
            {
                return SExecute<Java.Net.Authenticator.RequestorType>("valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/net/Authenticator.RequestorType.html#values()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Net.Authenticator.RequestorType"/></returns>
            public static Java.Net.Authenticator.RequestorType[] Values()
            {
                return SExecuteArray<Java.Net.Authenticator.RequestorType>("values");
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}