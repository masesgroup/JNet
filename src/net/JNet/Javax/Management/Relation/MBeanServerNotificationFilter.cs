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

namespace JavaX.Management.Relation
{
    public class MBeanServerNotificationFilter : NotificationFilterSupport
    {
        public override string ClassName => "javax.management.relation.MBeanServerNotificationFilter";

        public MBeanServerNotificationFilter() { }

        protected MBeanServerNotificationFilter(params object[] args) : base(args) { }

        /// <summary>
        /// Disables any <see cref="MBeanServerNotification"/>s(all <see cref="ObjectName"/>s are deselected).
        /// </summary>
        public void DisableAllObjectNames() => IExecute("disableAllObjectNames");
        /// <summary>
        /// Disables <see cref="MBeanServerNotification"/>s concerning given <see cref="ObjectName"/>.
        /// </summary>
        public void DisableObjectName(ObjectName objectName) => IExecute("disableObjectName", objectName);
        /// <summary>
        /// Enables all <see cref="MBeanServerNotification"/>s(all <see cref="ObjectName"/>s are selected).
        /// </summary>
        public void EnableAllObjectNames() => IExecute("enableAllObjectNames");
        /// <summary>
        /// Enables <see cref="MBeanServerNotification"/>s concerning given <see cref="ObjectName"/>.
        /// </summary>
        public void EnableObjectName(ObjectName objectName) => IExecute("enableObjectName", objectName);
        /// <summary>
        /// Gets all the <see cref="ObjectName"/>s disabled.
        /// </summary>
        public Vector<ObjectName> DisabledObjectNames => IExecute<Vector<ObjectName>>("getDisabledObjectNames");
        /// <summary>
        /// Gets all the <see cref="ObjectName"/>s enabled.
        /// </summary>
        public Vector<ObjectName> EnabledObjectNames => IExecute<Vector<ObjectName>>("getEnabledObjectNames");
    }
}
