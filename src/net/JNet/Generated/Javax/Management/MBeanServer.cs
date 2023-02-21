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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region MBeanServer
    public partial class MBeanServer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Management.MBeanServerConnection(Javax.Management.MBeanServer t) => t.Cast<Javax.Management.MBeanServerConnection>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getClassLoaderRepository() 
        /// </summary>
        public Javax.Management.Loading.ClassLoaderRepository ClassLoaderRepository
        {
            get { return IExecute<Javax.Management.Loading.ClassLoaderRepository>("getClassLoaderRepository"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getDefaultDomain() 
        /// </summary>
        public string DefaultDomain
        {
            get { return IExecute<string>("getDefaultDomain"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getDomains() 
        /// </summary>
        public string[] Domains
        {
            get { return IExecuteArray<string>("getDomains"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getMBeanCount() 
        /// </summary>
        public int MBeanCount
        {
            get { return IExecute<int>("getMBeanCount"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#isInstanceOf(javax.management.ObjectName,java.lang.String) throws javax.management.InstanceNotFoundException
        /// </summary>
        public bool IsInstanceOf(Javax.Management.ObjectName arg0, string arg1)
        {
            return IExecute<bool>("isInstanceOf", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#isRegistered(javax.management.ObjectName)
        /// </summary>
        public bool IsRegistered(Javax.Management.ObjectName arg0)
        {
            return IExecute<bool>("isRegistered", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getClassLoader(javax.management.ObjectName) throws javax.management.InstanceNotFoundException
        /// </summary>
        public Java.Lang.ClassLoader GetClassLoader(Javax.Management.ObjectName arg0)
        {
            return IExecute<Java.Lang.ClassLoader>("getClassLoader", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getClassLoaderFor(javax.management.ObjectName) throws javax.management.InstanceNotFoundException
        /// </summary>
        public Java.Lang.ClassLoader GetClassLoaderFor(Javax.Management.ObjectName arg0)
        {
            return IExecute<Java.Lang.ClassLoader>("getClassLoaderFor", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getAttribute(javax.management.ObjectName,java.lang.String) throws javax.management.MBeanException,javax.management.AttributeNotFoundException,javax.management.InstanceNotFoundException,javax.management.ReflectionException
        /// </summary>
        public object GetAttribute(Javax.Management.ObjectName arg0, string arg1)
        {
            return IExecute("getAttribute", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#instantiate(java.lang.String,java.lang.Object[],java.lang.String[]) throws javax.management.ReflectionException,javax.management.MBeanException
        /// </summary>
        public object Instantiate(string arg0, object[] arg1, string[] arg2)
        {
            return IExecute("instantiate", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#instantiate(java.lang.String,javax.management.ObjectName,java.lang.Object[],java.lang.String[]) throws javax.management.ReflectionException,javax.management.MBeanException,javax.management.InstanceNotFoundException
        /// </summary>
        public object Instantiate(string arg0, Javax.Management.ObjectName arg1, object[] arg2, string[] arg3)
        {
            return IExecute("instantiate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#instantiate(java.lang.String,javax.management.ObjectName) throws javax.management.ReflectionException,javax.management.MBeanException,javax.management.InstanceNotFoundException
        /// </summary>
        public object Instantiate(string arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute("instantiate", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#instantiate(java.lang.String) throws javax.management.ReflectionException,javax.management.MBeanException
        /// </summary>
        public object Instantiate(string arg0)
        {
            return IExecute("instantiate", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#invoke(javax.management.ObjectName,java.lang.String,java.lang.Object[],java.lang.String[]) throws javax.management.InstanceNotFoundException,javax.management.MBeanException,javax.management.ReflectionException
        /// </summary>
        public object Invoke(Javax.Management.ObjectName arg0, string arg1, object[] arg2, string[] arg3)
        {
            return IExecute("invoke", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getMBeanInfo(javax.management.ObjectName) throws javax.management.InstanceNotFoundException,javax.management.IntrospectionException,javax.management.ReflectionException
        /// </summary>
        public Javax.Management.MBeanInfo GetMBeanInfo(Javax.Management.ObjectName arg0)
        {
            return IExecute<Javax.Management.MBeanInfo>("getMBeanInfo", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#createMBean(java.lang.String,javax.management.ObjectName,java.lang.Object[],java.lang.String[]) throws javax.management.ReflectionException,javax.management.InstanceAlreadyExistsException,javax.management.MBeanRegistrationException,javax.management.MBeanException,javax.management.NotCompliantMBeanException
        /// </summary>
        public Javax.Management.ObjectInstance CreateMBean(string arg0, Javax.Management.ObjectName arg1, object[] arg2, string[] arg3)
        {
            return IExecute<Javax.Management.ObjectInstance>("createMBean", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#createMBean(java.lang.String,javax.management.ObjectName,javax.management.ObjectName,java.lang.Object[],java.lang.String[]) throws javax.management.ReflectionException,javax.management.InstanceAlreadyExistsException,javax.management.MBeanRegistrationException,javax.management.MBeanException,javax.management.NotCompliantMBeanException,javax.management.InstanceNotFoundException
        /// </summary>
        public Javax.Management.ObjectInstance CreateMBean(string arg0, Javax.Management.ObjectName arg1, Javax.Management.ObjectName arg2, object[] arg3, string[] arg4)
        {
            return IExecute<Javax.Management.ObjectInstance>("createMBean", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#createMBean(java.lang.String,javax.management.ObjectName,javax.management.ObjectName) throws javax.management.ReflectionException,javax.management.InstanceAlreadyExistsException,javax.management.MBeanRegistrationException,javax.management.MBeanException,javax.management.NotCompliantMBeanException,javax.management.InstanceNotFoundException
        /// </summary>
        public Javax.Management.ObjectInstance CreateMBean(string arg0, Javax.Management.ObjectName arg1, Javax.Management.ObjectName arg2)
        {
            return IExecute<Javax.Management.ObjectInstance>("createMBean", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#createMBean(java.lang.String,javax.management.ObjectName) throws javax.management.ReflectionException,javax.management.InstanceAlreadyExistsException,javax.management.MBeanRegistrationException,javax.management.MBeanException,javax.management.NotCompliantMBeanException
        /// </summary>
        public Javax.Management.ObjectInstance CreateMBean(string arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectInstance>("createMBean", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#getObjectInstance(javax.management.ObjectName) throws javax.management.InstanceNotFoundException
        /// </summary>
        public Javax.Management.ObjectInstance GetObjectInstance(Javax.Management.ObjectName arg0)
        {
            return IExecute<Javax.Management.ObjectInstance>("getObjectInstance", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#registerMBean(java.lang.Object,javax.management.ObjectName) throws javax.management.InstanceAlreadyExistsException,javax.management.MBeanRegistrationException,javax.management.NotCompliantMBeanException
        /// </summary>
        public Javax.Management.ObjectInstance RegisterMBean(object arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectInstance>("registerMBean", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#addNotificationListener(javax.management.ObjectName,javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object) throws javax.management.InstanceNotFoundException
        /// </summary>
        public void AddNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.NotificationListener arg1, Javax.Management.NotificationFilter arg2, object arg3)
        {
            IExecute("addNotificationListener", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#addNotificationListener(javax.management.ObjectName,javax.management.ObjectName,javax.management.NotificationFilter,java.lang.Object) throws javax.management.InstanceNotFoundException
        /// </summary>
        public void AddNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.ObjectName arg1, Javax.Management.NotificationFilter arg2, object arg3)
        {
            IExecute("addNotificationListener", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#removeNotificationListener(javax.management.ObjectName,javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object) throws javax.management.InstanceNotFoundException,javax.management.ListenerNotFoundException
        /// </summary>
        public void RemoveNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.NotificationListener arg1, Javax.Management.NotificationFilter arg2, object arg3)
        {
            IExecute("removeNotificationListener", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#removeNotificationListener(javax.management.ObjectName,javax.management.NotificationListener) throws javax.management.InstanceNotFoundException,javax.management.ListenerNotFoundException
        /// </summary>
        public void RemoveNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.NotificationListener arg1)
        {
            IExecute("removeNotificationListener", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#removeNotificationListener(javax.management.ObjectName,javax.management.ObjectName,javax.management.NotificationFilter,java.lang.Object) throws javax.management.InstanceNotFoundException,javax.management.ListenerNotFoundException
        /// </summary>
        public void RemoveNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.ObjectName arg1, Javax.Management.NotificationFilter arg2, object arg3)
        {
            IExecute("removeNotificationListener", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#removeNotificationListener(javax.management.ObjectName,javax.management.ObjectName) throws javax.management.InstanceNotFoundException,javax.management.ListenerNotFoundException
        /// </summary>
        public void RemoveNotificationListener(Javax.Management.ObjectName arg0, Javax.Management.ObjectName arg1)
        {
            IExecute("removeNotificationListener", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#setAttribute(javax.management.ObjectName,javax.management.Attribute) throws javax.management.InstanceNotFoundException,javax.management.AttributeNotFoundException,javax.management.InvalidAttributeValueException,javax.management.MBeanException,javax.management.ReflectionException
        /// </summary>
        public void SetAttribute(Javax.Management.ObjectName arg0, Javax.Management.Attribute arg1)
        {
            IExecute("setAttribute", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServer.html#unregisterMBean(javax.management.ObjectName) throws javax.management.InstanceNotFoundException,javax.management.MBeanRegistrationException
        /// </summary>
        public void UnregisterMBean(Javax.Management.ObjectName arg0)
        {
            IExecute("unregisterMBean", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}