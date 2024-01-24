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

namespace Java.Rmi.Registry
{
    #region IRegistry
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRegistry : Java.Rmi.IRemote
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#list()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        string[] List();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.NotBoundException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        Java.Rmi.Remote Lookup(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#bind(java.lang.String,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.AlreadyBoundException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        void Bind(string arg0, Java.Rmi.Remote arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#rebind(java.lang.String,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        void Rebind(string arg0, Java.Rmi.Remote arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.NotBoundException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        void Unbind(string arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Registry
    public partial class Registry : Java.Rmi.Registry.IRegistry
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#REGISTRY_PORT"/>
        /// </summary>
        public static int REGISTRY_PORT { get { if (!_REGISTRY_PORTReady) { _REGISTRY_PORTContent = SGetField<int>(LocalBridgeClazz, "REGISTRY_PORT"); _REGISTRY_PORTReady = true; } return _REGISTRY_PORTContent; } }
        private static int _REGISTRY_PORTContent = default;
        private static bool _REGISTRY_PORTReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#list()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        public string[] List()
        {
            return IExecuteArray<string>("list");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#lookup(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Rmi.Remote"/></returns>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.NotBoundException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        public Java.Rmi.Remote Lookup(string arg0)
        {
            return IExecute<Java.Rmi.Remote>("lookup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#bind(java.lang.String,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.AlreadyBoundException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        public void Bind(string arg0, Java.Rmi.Remote arg1)
        {
            IExecute("bind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#rebind(java.lang.String,java.rmi.Remote)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Rmi.Remote"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        public void Rebind(string arg0, Java.Rmi.Remote arg1)
        {
            IExecute("rebind", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.rmi/java/rmi/registry/Registry.html#unbind(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Rmi.RemoteException"/>
        /// <exception cref="Java.Rmi.NotBoundException"/>
        /// <exception cref="Java.Rmi.AccessException"/>
        public void Unbind(string arg0)
        {
            IExecute("unbind", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}