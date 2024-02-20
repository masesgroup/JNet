/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Modelmbean
{
    #region IModelMBeanNotificationBroadcaster
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IModelMBeanNotificationBroadcaster : Javax.Management.INotificationBroadcaster
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#addAttributeChangeNotificationListener(javax.management.NotificationListener,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        void AddAttributeChangeNotificationListener(Javax.Management.NotificationListener arg0, Java.Lang.String arg1, object arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#removeAttributeChangeNotificationListener(javax.management.NotificationListener,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        void RemoveAttributeChangeNotificationListener(Javax.Management.NotificationListener arg0, Java.Lang.String arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#sendAttributeChangeNotification(javax.management.Attribute,javax.management.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Attribute"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Attribute"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        void SendAttributeChangeNotification(Javax.Management.Attribute arg0, Javax.Management.Attribute arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#sendAttributeChangeNotification(javax.management.AttributeChangeNotification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeChangeNotification"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        void SendAttributeChangeNotification(Javax.Management.AttributeChangeNotification arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#sendNotification(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        void SendNotification(Java.Lang.String arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#sendNotification(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        void SendNotification(Javax.Management.Notification arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ModelMBeanNotificationBroadcaster
    public partial class ModelMBeanNotificationBroadcaster : Javax.Management.Modelmbean.IModelMBeanNotificationBroadcaster
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#addAttributeChangeNotificationListener(javax.management.NotificationListener,java.lang.String,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void AddAttributeChangeNotificationListener(Javax.Management.NotificationListener arg0, Java.Lang.String arg1, object arg2)
        {
            IExecute("addAttributeChangeNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#removeAttributeChangeNotificationListener(javax.management.NotificationListener,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveAttributeChangeNotificationListener(Javax.Management.NotificationListener arg0, Java.Lang.String arg1)
        {
            IExecute("removeAttributeChangeNotificationListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#sendAttributeChangeNotification(javax.management.Attribute,javax.management.Attribute)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#sendAttributeChangeNotification(javax.management.AttributeChangeNotification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeChangeNotification"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SendAttributeChangeNotification(Javax.Management.AttributeChangeNotification arg0)
        {
            IExecute("sendAttributeChangeNotification", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#sendNotification(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SendNotification(Java.Lang.String arg0)
        {
            IExecute("sendNotification", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBeanNotificationBroadcaster.html#sendNotification(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.RuntimeOperationsException"/>
        public void SendNotification(Javax.Management.Notification arg0)
        {
            IExecute("sendNotification", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}