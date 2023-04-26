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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Rmi.Server
{
    #region RemoteRef
    public partial class RemoteRef
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteRef.html#packagePrefix"/>
        /// </summary>
        public static string packagePrefix { get { return LocalClazz.GetField<string>("packagePrefix"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteRef.html#serialVersionUID"/>
        /// </summary>
        public static long serialVersionUID { get { return LocalClazz.GetField<long>("serialVersionUID"); } }
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteRef.html#remoteHashCode()"/> 
        /// </summary>
        public int RemoteHashCode
        {
            get { return IExecute<int>("remoteHashCode"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteRef.html#remoteToString()"/> 
        /// </summary>
        public string RemoteToString
        {
            get { return IExecute<string>("remoteToString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteRef.html#remoteEquals(java.rmi.server.RemoteRef)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Server.RemoteRef"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RemoteEquals(Java.Rmi.Server.RemoteRef arg0)
        {
            return IExecute<bool>("remoteEquals", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteRef.html#invoke(java.rmi.Remote,java.lang.reflect.Method,java.lang.Object[],long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Rmi.Remote"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Reflect.Method"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public object Invoke(Java.Rmi.Remote arg0, Java.Lang.Reflect.Method arg1, object[] arg2, long arg3)
        {
            return IExecute("invoke", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/server/RemoteRef.html#getRefClass(java.io.ObjectOutput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutput"/></param>
        /// <returns><see cref="string"/></returns>
        public string GetRefClass(Java.Io.ObjectOutput arg0)
        {
            return IExecute<string>("getRefClass", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}