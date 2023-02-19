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
    public class MBeanNotificationInfo : MBeanFeatureInfo
    {
        public override string ClassName => "javax.management.MBeanNotificationInfo";

        public MBeanNotificationInfo() { }

        protected MBeanNotificationInfo(params object[] args) : base(args) { }
        /// <summary>
        /// Constructs an <see cref="MBeanNotificationInfo"/> object.
        /// </summary>
        public MBeanNotificationInfo(string[] notifTypes, string name, string description)
            : base(notifTypes, name, description) { }
        /// <summary>
        /// Constructs an <see cref="MBeanNotificationInfo"/> object.
        /// </summary>
        public MBeanNotificationInfo(string[] notifTypes, string name, string description, Descriptor descriptor)
            : base(notifTypes, name, description, descriptor) { }
        /// <summary>
        /// Returns the array of strings(in dot notation) containing the notification types that the MBean may emit.
        /// </summary>
        public string[] NotifTypes => IExecuteArray<string>("getNotifTypes");
    }
}
