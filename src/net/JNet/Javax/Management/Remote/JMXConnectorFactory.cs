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

using Java.Util;
using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Remote
{
    public class JMXConnectorFactory : JVMBridgeBase<JMXConnectorFactory>
    {
        public override string ClassName => "javax.management.remote.JMXConnectorFactory";
        /// <summary>
        /// Name of the attribute that specifies the default class loader.
        /// </summary>
        public static string DEFAULT_CLASS_LOADER => Clazz.GetField<string>("DEFAULT_CLASS_LOADER");
        /// <summary>
        /// Name of the attribute that specifies the class loader for loading protocol providers.
        /// </summary>
        public static string PROTOCOL_PROVIDER_CLASS_LOADER => Clazz.GetField<string>("PROTOCOL_PROVIDER_CLASS_LOADER");
        /// <summary>
        /// Name of the attribute that specifies the provider packages that are consulted when looking for the handler for a protocol.
        /// </summary>
        public static string PROTOCOL_PROVIDER_PACKAGES => Clazz.GetField<string>("PROTOCOL_PROVIDER_PACKAGES");
        /// <summary>
        /// Creates a connection to the connector server at the given address.
        /// </summary>
        public static JMXConnector Connect(JMXServiceURL serviceURL) => SExecute<JMXConnector>("connect", serviceURL);
        /// <summary>
        /// Creates a connection to the connector server at the given address.
        /// </summary>
        public static JMXConnector Connect(JMXServiceURL serviceURL, Map<string, object> environment) => SExecute<JMXConnector>("connect", serviceURL, environment);
        /// <summary>
        /// Creates a connector client for the connector server at the given address.
        /// </summary>
        public static JMXConnector NewJMXConnector(JMXServiceURL serviceURL, Map<string, object> environment) => SExecute<JMXConnector>("newJMXConnector", serviceURL, environment);
    }
}
