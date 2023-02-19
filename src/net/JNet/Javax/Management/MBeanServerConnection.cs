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
using System;

namespace Javax.Management
{
    public class MBeanServerConnection : JVMBridgeBase<MBeanServerConnection>
    {
        public override bool IsInterface => true;
        public override string ClassName => "javax.management.MBeanServerConnection";
        /// <summary>
        /// Adds a listener to a registered MBean.
        /// </summary>
        public void AddNotificationListener(ObjectName name, NotificationListener listener, NotificationFilter filter, object handback) => IExecute("addNotificationListener", name, listener, filter, handback);
        /// <summary>
        /// Adds a listener to a registered MBean.
        /// </summary>
        public void AddNotificationListener(ObjectName name, ObjectName listener, NotificationFilter filter, object handback) => IExecute("addNotificationListener", name, listener, filter, handback);
        /// <summary>
        /// Instantiates and registers an MBean in the MBean server.
        /// </summary>
        public ObjectInstance CreateMBean(string className, ObjectName name) => IExecute<ObjectInstance>("createMBean", className, name);
        /// <summary>
        /// Instantiates and registers an MBean in the MBean server.
        /// </summary>
        public ObjectInstance CreateMBean(string className, ObjectName name, object[] parameters, string[] signature) => IExecute<ObjectInstance>("createMBean", className, name, parameters, signature);
        /// <summary>
        /// Instantiates and registers an MBean in the MBean server.
        /// </summary>
        public ObjectInstance CreateMBean(string className, ObjectName name, ObjectName loaderName) => IExecute<ObjectInstance>("createMBean", className, name, loaderName);
        /// <summary>
        /// Instantiates and registers an MBean in the MBean server.
        /// </summary>
        public ObjectInstance CreateMBean(String className, ObjectName name, ObjectName loaderName, object[] parameters, string[] signature) => IExecute<ObjectInstance>("createMBean", className, name, loaderName, parameters, signature);
        /// <summary>
        /// Gets the value of a specific attribute of a named MBean.
        /// </summary>
        public object GetAttribute(ObjectName name, string attribute) => IExecute("getAttribute", name, attribute);
        /// <summary>
        /// Retrieves the values of several attributes of a named MBean.
        /// </summary>
        public AttributeList GetAttributes(ObjectName name, string[] attributes) => IExecute<AttributeList>("getAttributes", name, attributes);
        /// <summary>
        /// Returns the default domain used for naming the MBean.
        /// </summary>
        public string DefaultDomain => IExecute<string>("getDefaultDomain");
        /// <summary>
        /// Returns the list of domains in which any MBean is currently registered.
        /// </summary>
        public string[] Domains => IExecuteArray<string>("getDomains");
        /// <summary>
        /// Returns the number of MBeans registered in the MBean server.
        /// </summary>
        public int MBeanCount => IExecute<int>("getMBeanCount");
        /// <summary>
        /// This method discovers the attributes and operations that an MBean exposes for management.
        /// </summary>
        public MBeanInfo GetMBeanInfo(ObjectName name) => IExecute<MBeanInfo>("getMBeanInfo", name);
        /// <summary>
        /// Gets the ObjectInstance for a given MBean registered with the MBean server.
        /// </summary>
        public ObjectInstance GetObjectInstance(ObjectName name) => IExecute<ObjectInstance>("getObjectInstance", name);
        /// <summary>
        /// Invokes an operation on an MBean.
        /// </summary>
        public object Invoke(ObjectName name, string operationName, object[] parameters, string[] signature) => IExecute("invoke", name, operationName, parameters, signature);
        /// <summary>
        /// Returns true if the MBean specified is an instance of the specified class, false otherwise.
        /// </summary>
        public bool IsInstanceOf(ObjectName name, string className) => IExecute<bool>("isInstanceOf", name, className);
        /// <summary>
        /// Checks whether an MBean, identified by its object name, is already registered with the MBean server.
        /// </summary>
        public bool IsRegistered(ObjectName name) => IExecute<bool>("isRegistered", name);
        /// <summary>
        /// Gets MBeans controlled by the MBean server.
        /// </summary>
        public Set<ObjectInstance> QueryMBeans(ObjectName name, QueryExp query) => IExecute<Set<ObjectInstance>>("queryMBeans", name, query);
        /// <summary>
        /// Gets the names of MBeans controlled by the MBean server.
        /// </summary>
        public Set<ObjectName> QueryNames(ObjectName name, QueryExp query) => IExecute<Set<ObjectName>>("queryNames", name, query);
        /// <summary>
        /// Removes a listener from a registered MBean.
        /// </summary>
        public void RemoveNotificationListener(ObjectName name, NotificationListener listener) => IExecute("removeNotificationListener", name, listener);
        /// <summary>
        /// Removes a listener from a registered MBean.
        /// </summary>
        public void RemoveNotificationListener(ObjectName name, NotificationListener listener, NotificationFilter filter, object handback) => IExecute("removeNotificationListener", name, listener, filter, handback);
        /// <summary>
        /// Removes a listener from a registered MBean.
        /// </summary>
        public void RemoveNotificationListener(ObjectName name, ObjectName listener) => IExecute("removeNotificationListener", name, listener);
        /// <summary>
        /// Removes a listener from a registered MBean.
        /// </summary>
        public void RemoveNotificationListener(ObjectName name, ObjectName listener, NotificationFilter filter, object handback) => IExecute("removeNotificationListener", name, listener, filter, handback);
        /// <summary>
        /// Sets the value of a specific attribute of a named MBean.
        /// </summary>
        public void SetAttribute(ObjectName name, Attribute attribute) => IExecute("setAttribute", name, attribute);
        /// <summary>
        /// Sets the values of several attributes of a named MBean.
        /// </summary>
        public AttributeList SetAttributes(ObjectName name, AttributeList attributes) => IExecute<AttributeList>("setAttributes", name, attributes);
        /// <summary>
        /// Unregisters an MBean from the MBean server.
        /// </summary>
        public void UnregisterMBean(ObjectName name) => IExecute("unregisterMBean", name);
    }
}
