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

namespace JavaX.Management
{
    public class MBeanServerNotification : Notification
    {
        public override string ClassName => "javax.management.MBeanServerNotification";

        public MBeanServerNotification() { }

        protected MBeanServerNotification(params object[] args) : base(args) { }
        /// <summary>
        /// Creates an <see cref="MBeanServerNotification"/> object specifying object names of the MBeans that caused the notification and the specified notification type.
        /// </summary>
        public MBeanServerNotification(string type, object source, long sequenceNumber, ObjectName objectName)
            : base(type, source, sequenceNumber, objectName) { }
        /// <summary>
        /// Notification type denoting that an MBean has been registered.
        /// </summary>
        public static string REGISTRATION_NOTIFICATION => Clazz.GetField<string>("REGISTRATION_NOTIFICATION");
        /// <summary>
        /// Notification type denoting that an MBean has been unregistered.
        /// </summary>
        public static string UNREGISTRATION_NOTIFICATION => Clazz.GetField<string>("UNREGISTRATION_NOTIFICATION");
        /// <summary>
        /// Returns the object name of the MBean that caused the notification.
        /// </summary>
        public ObjectName MBeanName => IExecute<ObjectName>("getMBeanName");
    }
}
