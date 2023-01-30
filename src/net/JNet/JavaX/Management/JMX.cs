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
    public class JMX : JVMBridgeBase<JMX>
    {
        public override string ClassName => "javax.management.JMX";
        /// <summary>
        /// The name of the defaultValue field.
        /// </summary>
        public static string DEFAULT_VALUE_FIELD => Clazz.GetField<string>("DEFAULT_VALUE_FIELD");
        /// <summary>
        /// The name of the immutableInfo field.
        /// </summary>
        public static string IMMUTABLE_INFO_FIELD => Clazz.GetField<string>("IMMUTABLE_INFO_FIELD");
        /// <summary>
        /// The name of the interfaceClassName field.
        /// </summary>
        public static string INTERFACE_CLASS_NAME_FIELD => Clazz.GetField<string>("INTERFACE_CLASS_NAME_FIELD");
        /// <summary>
        /// The name of the legalValues field.
        /// </summary>
        public static string LEGAL_VALUES_FIELD => Clazz.GetField<string>("LEGAL_VALUES_FIELD");
        /// <summary>
        /// The name of the maxValue field.
        /// </summary>
        public static string MAX_VALUE_FIELD => Clazz.GetField<string>("MAX_VALUE_FIELD");
        /// <summary>
        /// The name of the minValue field.
        /// </summary>
        public static string MIN_VALUE_FIELD => Clazz.GetField<string>("MIN_VALUE_FIELD");
        /// <summary>
        /// The name of the mxbean field.
        /// </summary>
        public static string MXBEAN_FIELD => Clazz.GetField<string>("MXBEAN_FIELD");
        /// <summary>
        /// The name of the openType field.
        /// </summary>
        public static string OPEN_TYPE_FIELD => Clazz.GetField<string>("OPEN_TYPE_FIELD");
        /// <summary>
        /// The name of the originalType field.
        /// </summary>
        public static string ORIGINAL_TYPE_FIELD => Clazz.GetField<string>("ORIGINAL_TYPE_FIELD");
        /// <summary>
        /// Test whether an interface is an MXBean interface.
        /// </summary>
        public static bool IsMXBeanInterface(Java.Lang.Class interfaceClass) => SExecute<bool>("isMXBeanInterface", interfaceClass);
        /// <summary>
        /// Test whether an interface is an MXBean interface.
        /// </summary>
        public static bool IsMXBeanInterface<T>() where T : IJVMBridgeBase, new() => IsMXBeanInterface(Java.Lang.Class.Of<T>());
        /// <summary>
        /// Make a proxy for a Standard MBean in a local or remote MBean Server.
        /// </summary>
        public static T NewMBeanProxy<T>(MBeanServerConnection connection, ObjectName objectName, Java.Lang.Class<T> interfaceClass) where T : IJVMBridgeBase, new() => SExecute<T>("newMBeanProxy", connection, objectName, interfaceClass);
        /// <summary>
        /// Make a proxy for a Standard MBean in a local or remote MBean Server.
        /// </summary>
        public static T NewMBeanProxy<T>(MBeanServerConnection connection, ObjectName objectName) where T : IJVMBridgeBase, new() => NewMBeanProxy(connection, objectName, Java.Lang.Class.Of<T>());
        /// <summary>
        /// Make a proxy for a Standard MBean in a local or remote MBean Server that may also support the methods of <see cref="NotificationEmitter"/>.
        /// </summary>
        public static T NewMBeanProxy<T>(MBeanServerConnection connection, ObjectName objectName, Java.Lang.Class<T> interfaceClass, bool notificationEmitter) where T : IJVMBridgeBase, new() => SExecute<T>("newMBeanProxy", connection, objectName, interfaceClass, notificationEmitter);
        /// <summary>
        /// Make a proxy for a Standard MBean in a local or remote MBean Server that may also support the methods of <see cref="NotificationEmitter"/>.
        /// </summary>
        public static T NewMBeanProxy<T>(MBeanServerConnection connection, ObjectName objectName, bool notificationEmitter) where T : IJVMBridgeBase, new() => NewMBeanProxy(connection, objectName, Java.Lang.Class.Of<T>(), notificationEmitter);
        /// <summary>
        /// Make a proxy for an MXBean in a local or remote MBean Server.
        /// </summary>
        public static T NewMXBeanProxy<T>(MBeanServerConnection connection, ObjectName objectName, Java.Lang.Class<T> interfaceClass) where T : IJVMBridgeBase, new() => SExecute<T>("newMXBeanProxy", connection, objectName, interfaceClass);
        /// <summary>
        /// Make a proxy for an MXBean in a local or remote MBean Server.
        /// </summary>
        public static T NewMXBeanProxy<T>(MBeanServerConnection connection, ObjectName objectName) where T : IJVMBridgeBase, new() => NewMXBeanProxy(connection, objectName, Java.Lang.Class.Of<T>());
        /// <summary>
        /// Make a proxy for an MXBean in a local or remote MBean Server that may also support the methods of NotificationEmitter.
        /// </summary>
        public static T NewMXBeanProxy<T>(MBeanServerConnection connection, ObjectName objectName, Java.Lang.Class<T> interfaceClass, bool notificationEmitter) where T : IJVMBridgeBase, new() => SExecute<T>("newMXBeanProxy", connection, objectName, interfaceClass, notificationEmitter);
        /// <summary>
        /// Make a proxy for an MXBean in a local or remote MBean Server that may also support the methods of NotificationEmitter.
        /// </summary>
        public static T NewMXBeanProxy<T>(MBeanServerConnection connection, ObjectName objectName, bool notificationEmitter) where T : IJVMBridgeBase, new() => NewMXBeanProxy(connection, objectName, Java.Lang.Class.Of<T>(), notificationEmitter);
    }
}
