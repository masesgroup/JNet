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
    public class JMXConnectorProvider : JVMBridgeBase<JMXConnectorProvider>
    {
        public override bool IsInterface => true;
        public override string ClassName => "javax.management.remote.JMXConnectorProvider";
        /// <summary>
        /// Creates a new connector client that is ready to connect to the connector server at the given address. Each successful call to this method produces a different <see cref="JMXConnector"/> object.
        /// </summary>
        public JMXConnector NewJMXConnector(JMXServiceURL serviceURL, Map<string, object> environment) => IExecute<JMXConnector>("newJMXConnector", serviceURL, environment);
    }
}
