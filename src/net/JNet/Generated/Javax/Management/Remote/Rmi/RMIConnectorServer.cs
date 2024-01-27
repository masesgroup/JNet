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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Remote.Rmi
{
    #region RMIConnectorServer
    public partial class RMIConnectorServer
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectorServer.html#%3Cinit%3E(javax.management.remote.JMXServiceURL,java.util.Map,javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanServer"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public RMIConnectorServer(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<string, object> arg1, Javax.Management.MBeanServer arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectorServer.html#%3Cinit%3E(javax.management.remote.JMXServiceURL,java.util.Map,javax.management.remote.rmi.RMIServerImpl,javax.management.MBeanServer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Remote.Rmi.RMIServerImpl"/></param>
        /// <param name="arg3"><see cref="Javax.Management.MBeanServer"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public RMIConnectorServer(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<string, object> arg1, Javax.Management.Remote.Rmi.RMIServerImpl arg2, Javax.Management.MBeanServer arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectorServer.html#%3Cinit%3E(javax.management.remote.JMXServiceURL,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public RMIConnectorServer(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<string, object> arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectorServer.html#CREDENTIALS_FILTER_PATTERN"/>
        /// </summary>
        public static string CREDENTIALS_FILTER_PATTERN { get { if (!_CREDENTIALS_FILTER_PATTERNReady) { _CREDENTIALS_FILTER_PATTERNContent = SGetField<string>(LocalBridgeClazz, "CREDENTIALS_FILTER_PATTERN"); _CREDENTIALS_FILTER_PATTERNReady = true; } return _CREDENTIALS_FILTER_PATTERNContent; } }
        private static string _CREDENTIALS_FILTER_PATTERNContent = default;
        private static bool _CREDENTIALS_FILTER_PATTERNReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectorServer.html#JNDI_REBIND_ATTRIBUTE"/>
        /// </summary>
        public static string JNDI_REBIND_ATTRIBUTE { get { if (!_JNDI_REBIND_ATTRIBUTEReady) { _JNDI_REBIND_ATTRIBUTEContent = SGetField<string>(LocalBridgeClazz, "JNDI_REBIND_ATTRIBUTE"); _JNDI_REBIND_ATTRIBUTEReady = true; } return _JNDI_REBIND_ATTRIBUTEContent; } }
        private static string _JNDI_REBIND_ATTRIBUTEContent = default;
        private static bool _JNDI_REBIND_ATTRIBUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectorServer.html#RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTE"/>
        /// </summary>
        public static string RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTE { get { if (!_RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTEReady) { _RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTEContent = SGetField<string>(LocalBridgeClazz, "RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTE"); _RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTEReady = true; } return _RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTEContent; } }
        private static string _RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTEContent = default;
        private static bool _RMI_CLIENT_SOCKET_FACTORY_ATTRIBUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectorServer.html#RMI_SERVER_SOCKET_FACTORY_ATTRIBUTE"/>
        /// </summary>
        public static string RMI_SERVER_SOCKET_FACTORY_ATTRIBUTE { get { if (!_RMI_SERVER_SOCKET_FACTORY_ATTRIBUTEReady) { _RMI_SERVER_SOCKET_FACTORY_ATTRIBUTEContent = SGetField<string>(LocalBridgeClazz, "RMI_SERVER_SOCKET_FACTORY_ATTRIBUTE"); _RMI_SERVER_SOCKET_FACTORY_ATTRIBUTEReady = true; } return _RMI_SERVER_SOCKET_FACTORY_ATTRIBUTEContent; } }
        private static string _RMI_SERVER_SOCKET_FACTORY_ATTRIBUTEContent = default;
        private static bool _RMI_SERVER_SOCKET_FACTORY_ATTRIBUTEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management.rmi/javax/management/remote/rmi/RMIConnectorServer.html#SERIAL_FILTER_PATTERN"/>
        /// </summary>
        public static string SERIAL_FILTER_PATTERN { get { if (!_SERIAL_FILTER_PATTERNReady) { _SERIAL_FILTER_PATTERNContent = SGetField<string>(LocalBridgeClazz, "SERIAL_FILTER_PATTERN"); _SERIAL_FILTER_PATTERNReady = true; } return _SERIAL_FILTER_PATTERNContent; } }
        private static string _SERIAL_FILTER_PATTERNContent = default;
        private static bool _SERIAL_FILTER_PATTERNReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}