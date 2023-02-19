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

namespace Javax.Management.Remote
{
    public class JMXConnectionNotification : Notification
    {
        public override string ClassName => "javax.management.remote.JMXConnectionNotification";

        public JMXConnectionNotification() { }

        protected JMXConnectionNotification(params object[] args) : base(args) { }
        /// <summary>
        /// Constructs a new connection notification.
        /// </summary>
        public JMXConnectionNotification(string type, object source, string connectionId, long sequenceNumber, string message, object userData)
            : base(type, source, connectionId, sequenceNumber, message, userData) { }
        /// <summary>
        /// Notification type string for a connection-closed notification.
        /// </summary>
        public static string CLOSED => Clazz.GetField<string>("CLOSED");
        /// <summary>
        /// Notification type string for a connection-failed notification.
        /// </summary>
        public static string FAILED => Clazz.GetField<string>("FAILED");
        /// <summary>
        /// Notification type string for a connection that has possibly lost notifications.
        /// </summary>
        public static string NOTIFS_LOST => Clazz.GetField<string>("NOTIFS_LOST");
        /// <summary>
        /// Notification type string for a connection-opened notification.
        /// </summary>
        public static string OPENED => Clazz.GetField<string>("OPENED");
        /// <summary>
        /// The connection ID to which this notification pertains.
        /// </summary>
        public string ConnectionId => IExecute<string>("getConnectionId");
    }
}
