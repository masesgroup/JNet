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

using MASES.JCOBridge.C2JBridge;

namespace JavaX.Management
{
    public class MBeanInfo : JVMBridgeBase<MBeanInfo>
    {
        public override string ClassName => "javax.management.MBeanInfo";

        public MBeanInfo() { }

        protected MBeanInfo(params object[] args) : base(args) { }
        /// <summary>
        /// Constructs an <see cref="MBeanInfo"/>.
        /// </summary>
        public MBeanInfo(string className, string description, MBeanAttributeInfo[] attributes, MBeanConstructorInfo[] constructors, MBeanOperationInfo[] operations, MBeanNotificationInfo[] notifications)
            : base(className, description, attributes, constructors, operations, notifications) { }
        /// <summary>
        /// Constructs an <see cref="MBeanInfo"/>.
        /// </summary>
        public MBeanInfo(string className, string description, MBeanAttributeInfo[] attributes, MBeanConstructorInfo[] constructors, MBeanOperationInfo[] operations, MBeanNotificationInfo[] notifications, Descriptor descriptor)
            : base(className, description, attributes, constructors, operations, notifications, descriptor) { }
        /// <summary>
        /// Returns the list of attributes exposed for management.
        /// </summary>
        public MBeanAttributeInfo[] Attributes => IExecuteArray<MBeanAttributeInfo>("getAttributes");
        /// <summary>
        /// Returns the name of the Java class of the MBean described by this <see cref="MBeanInfo"/>.
        /// </summary>
        public string ClassNameJMX => IExecute<string>("getClassName");
        /// <summary>
        /// Returns the list of the public constructors of the MBean.
        /// </summary>
        public MBeanConstructorInfo[] Constructors => IExecuteArray<MBeanConstructorInfo>("getConstructors");
        /// <summary>
        /// Returns a human readable description of the MBean.
        /// </summary>
        public string Description => IExecute<string>("getDescription");
        /// <summary>
        /// Get the descriptor of this <see cref="MBeanInfo"/>.
        /// </summary>
        public Descriptor Descriptor => IExecute<Descriptor>("getDescriptor");
        /// <summary>
        /// Returns the list of the notifications emitted by the MBean.
        /// </summary>
        public MBeanNotificationInfo[] Notifications => IExecuteArray<MBeanNotificationInfo>("getNotifications");
        /// <summary>
        /// Returns the list of operations of the MBean.
        /// </summary>
        public MBeanOperationInfo[] Operations => IExecuteArray<MBeanOperationInfo>("getOperations");
    }
}
