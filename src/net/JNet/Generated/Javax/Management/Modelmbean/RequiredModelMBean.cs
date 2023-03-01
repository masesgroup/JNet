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

namespace Javax.Management.Modelmbean
{
    #region RequiredModelMBean
    public partial class RequiredModelMBean
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#%3Cinit%3E(javax.management.modelmbean.ModelMBeanInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Modelmbean.ModelMBeanInfo"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public RequiredModelMBean(Javax.Management.Modelmbean.ModelMBeanInfo arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.RequiredModelMBean"/> to <see cref="Javax.Management.Modelmbean.ModelMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Modelmbean.ModelMBean(Javax.Management.Modelmbean.RequiredModelMBean t) => t.Cast<Javax.Management.Modelmbean.ModelMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.RequiredModelMBean"/> to <see cref="Javax.Management.MBeanRegistration"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Modelmbean.RequiredModelMBean t) => t.Cast<Javax.Management.MBeanRegistration>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Modelmbean.RequiredModelMBean"/> to <see cref="Javax.Management.NotificationEmitter"/>
        /// </summary>
        public static implicit operator Javax.Management.NotificationEmitter(Javax.Management.Modelmbean.RequiredModelMBean t) => t.Cast<Javax.Management.NotificationEmitter>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#getMBeanInfo()"/> 
        /// </summary>
        public Javax.Management.MBeanInfo MBeanInfo
        {
            get { return IExecute<Javax.Management.MBeanInfo>("getMBeanInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#getNotificationInfo()"/> 
        /// </summary>
        public Javax.Management.MBeanNotificationInfo[] NotificationInfo
        {
            get { return IExecuteArray<Javax.Management.MBeanNotificationInfo>("getNotificationInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="object"/></returns>
        /// <exception cref="Javax.Management.AttributeNotFoundException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        public object GetAttribute(string arg0)
        {
            return IExecute("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#invoke(java.lang.String,java.lang.Object[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see langword="object"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        public object Invoke(string arg0, object[] arg1, string[] arg2)
        {
            return IExecute("invoke", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#getAttributes(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.AttributeList"/></returns>
        public Javax.Management.AttributeList GetAttributes(string[] arg0)
        {
            return IExecute<Javax.Management.AttributeList>("getAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#setAttributes(javax.management.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeList"/></param>
        /// <returns><see cref="Javax.Management.AttributeList"/></returns>
        public Javax.Management.AttributeList SetAttributes(Javax.Management.AttributeList arg0)
        {
            return IExecute<Javax.Management.AttributeList>("setAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectName>("preRegister", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#addAttributeChangeNotificationListener(javax.management.NotificationListener,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void AddAttributeChangeNotificationListener(Javax.Management.NotificationListener arg0, string arg1, object arg2)
        {
            IExecute("addAttributeChangeNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#addNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void AddNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("addNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#load()"/>
        /// </summary>
        
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        public void Load()
        {
            IExecute("load");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecute("postDeregister");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void PostRegister(bool? arg0)
        {
            IExecute("postRegister", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#preDeregister()"/>
        /// </summary>
        
        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecute("preDeregister");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#removeAttributeChangeNotificationListener(javax.management.NotificationListener,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveAttributeChangeNotificationListener(Javax.Management.NotificationListener arg0, string arg1)
        {
            IExecute("removeAttributeChangeNotificationListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#removeNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("removeNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#removeNotificationListener(javax.management.NotificationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveNotificationListener(Javax.Management.NotificationListener arg0)
        {
            IExecute("removeNotificationListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#sendAttributeChangeNotification(javax.management.Attribute,javax.management.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Attribute"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Attribute"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SendAttributeChangeNotification(Javax.Management.Attribute arg0, Javax.Management.Attribute arg1)
        {
            IExecute("sendAttributeChangeNotification", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#sendAttributeChangeNotification(javax.management.AttributeChangeNotification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeChangeNotification"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SendAttributeChangeNotification(Javax.Management.AttributeChangeNotification arg0)
        {
            IExecute("sendAttributeChangeNotification", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#sendNotification(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SendNotification(string arg0)
        {
            IExecute("sendNotification", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#sendNotification(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SendNotification(Javax.Management.Notification arg0)
        {
            IExecute("sendNotification", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#setAttribute(javax.management.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Attribute"/></param>
        /// <exception cref="Javax.Management.AttributeNotFoundException"/>
        /// <exception cref="Javax.Management.InvalidAttributeValueException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        public void SetAttribute(Javax.Management.Attribute arg0)
        {
            IExecute("setAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#setManagedResource(java.lang.Object,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.Modelmbean.InvalidTargetObjectTypeException"/>
        public void SetManagedResource(object arg0, string arg1)
        {
            IExecute("setManagedResource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#setModelMBeanInfo(javax.management.modelmbean.ModelMBeanInfo)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Modelmbean.ModelMBeanInfo"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SetModelMBeanInfo(Javax.Management.Modelmbean.ModelMBeanInfo arg0)
        {
            IExecute("setModelMBeanInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/RequiredModelMBean.html#store()"/>
        /// </summary>
        
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        public void Store()
        {
            IExecute("store");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}