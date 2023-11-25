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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region StandardEmitterMBean
    public partial class StandardEmitterMBean
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardEmitterMBean.html#%3Cinit%3E(java.lang.Object,java.lang.Class,boolean,javax.management.NotificationEmitter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="Javax.Management.NotificationEmitter"/></param>
        public StandardEmitterMBean(object arg0, Java.Lang.Class arg1, bool arg2, Javax.Management.NotificationEmitter arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardEmitterMBean.html#%3Cinit%3E(java.lang.Object,java.lang.Class,javax.management.NotificationEmitter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="Javax.Management.NotificationEmitter"/></param>
        public StandardEmitterMBean(object arg0, Java.Lang.Class arg1, Javax.Management.NotificationEmitter arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.StandardEmitterMBean"/> to <see cref="Javax.Management.NotificationEmitter"/>
        /// </summary>
        public static implicit operator Javax.Management.NotificationEmitter(Javax.Management.StandardEmitterMBean t) => t.Cast<Javax.Management.NotificationEmitter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardEmitterMBean.html#getNotificationInfo()"/> 
        /// </summary>
        public Javax.Management.MBeanNotificationInfo[] NotificationInfo
        {
            get { return IExecuteArray<Javax.Management.MBeanNotificationInfo>("getNotificationInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardEmitterMBean.html#addNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void AddNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("addNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardEmitterMBean.html#removeNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardEmitterMBean.html#removeNotificationListener(javax.management.NotificationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveNotificationListener(Javax.Management.NotificationListener arg0)
        {
            IExecute("removeNotificationListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardEmitterMBean.html#sendNotification(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
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