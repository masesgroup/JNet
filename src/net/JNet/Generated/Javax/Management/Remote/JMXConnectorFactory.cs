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

namespace Javax.Management.Remote
{
    #region JMXConnectorFactory
    public partial class JMXConnectorFactory
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorFactory.html#DEFAULT_CLASS_LOADER"/>
        /// </summary>
        public static string DEFAULT_CLASS_LOADER { get { return SGetField<string>(LocalBridgeClazz, "DEFAULT_CLASS_LOADER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorFactory.html#PROTOCOL_PROVIDER_CLASS_LOADER"/>
        /// </summary>
        public static string PROTOCOL_PROVIDER_CLASS_LOADER { get { return SGetField<string>(LocalBridgeClazz, "PROTOCOL_PROVIDER_CLASS_LOADER"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorFactory.html#PROTOCOL_PROVIDER_PACKAGES"/>
        /// </summary>
        public static string PROTOCOL_PROVIDER_PACKAGES { get { return SGetField<string>(LocalBridgeClazz, "PROTOCOL_PROVIDER_PACKAGES"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorFactory.html#connect(javax.management.remote.JMXServiceURL,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Management.Remote.JMXConnector Connect(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<string, object> arg1)
        {
            return SExecute<Javax.Management.Remote.JMXConnector>(LocalBridgeClazz, "connect", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorFactory.html#connect(javax.management.remote.JMXServiceURL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Management.Remote.JMXConnector Connect(Javax.Management.Remote.JMXServiceURL arg0)
        {
            return SExecute<Javax.Management.Remote.JMXConnector>(LocalBridgeClazz, "connect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorFactory.html#newJMXConnector(javax.management.remote.JMXServiceURL,java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.JMXServiceURL"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Management.Remote.JMXConnector NewJMXConnector(Javax.Management.Remote.JMXServiceURL arg0, Java.Util.Map<string, object> arg1)
        {
            return SExecute<Javax.Management.Remote.JMXConnector>(LocalBridgeClazz, "newJMXConnector", arg0, arg1);
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}