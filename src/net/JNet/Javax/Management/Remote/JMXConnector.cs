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
using Javax.Security.Auth;
using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Remote
{
    public class JMXConnector : JVMBridgeBase<JMXConnector>
    {
        public override bool IsInterface => true;
        public override bool IsCloseable => true;

        public override string ClassName => "javax.management.remote.JMXConnector";
        /// <summary>
        /// Name of the attribute that specifies the credentials to send to the connector server during connection.
        /// </summary>
        public static string CREDENTIALS => Clazz.GetField<string>("CREDENTIALS");

        /// <summary>
        /// Adds a listener to be informed of changes in connection status.
        /// </summary>
        public void AddConnectionNotificationListener(NotificationListener listener, NotificationFilter filter, object handback) => IExecute("addConnectionNotificationListener", listener, filter, handback);
        /// <summary>
        /// Establishes the connection to the connector server.
        /// </summary>
        public void Connect() => IExecute("connect");
        /// <summary>
        /// Establishes the connection to the connector server.
        /// </summary>
        /// <param name="env"></param>
        public void Connect(Map<string, object> env) => IExecute("connect", env);
        /// <summary>
        /// Gets this connection's ID from the connector server.
        /// </summary>
        /// <returns></returns>
        public string ConnectionId => IExecute<string>("getConnectionId");
        /// <summary>
        /// Returns an <see cref="MBeanServerConnection"/> object representing a remote MBean server.
        /// </summary>
        public MBeanServerConnection MBeanServerConnection => IExecute<MBeanServerConnection>("getMBeanServerConnection");
        /// <summary>
        /// Returns an <see cref="MBeanServerConnection"/> object representing a remote MBean server on which operations are performed on behalf of the supplied delegation subject.
        /// </summary>
        public MBeanServerConnection GetMBeanServerConnection(Subject delegationSubject) => IExecute<MBeanServerConnection>("getMBeanServerConnection", delegationSubject);
        /// <summary>
        /// Removes a listener from the list to be informed of changes in status.
        /// </summary>
        public void RemoveConnectionNotificationListener(NotificationListener listener) => IExecute<MBeanServerConnection>("removeConnectionNotificationListener", listener);
        /// <summary>
        /// Removes a listener from the list to be informed of changes in status.
        /// </summary>
        public void RemoveConnectionNotificationListener(NotificationListener l, NotificationFilter f, object handback) => IExecute<MBeanServerConnection>("removeConnectionNotificationListener", l, f, handback);
    }
}
