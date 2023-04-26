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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Remote
{
    #region JMXConnector
    public partial class JMXConnector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#CREDENTIALS"/>
        /// </summary>
        public static string CREDENTIALS => LocalClazz.GetField<string>("CREDENTIALS");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#getConnectionId()"/> 
        /// </summary>
        public string ConnectionId
        {
            get { return IExecute<string>("getConnectionId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#getMBeanServerConnection()"/> 
        /// </summary>
        public Javax.Management.MBeanServerConnection MBeanServerConnection
        {
            get { return IExecute<Javax.Management.MBeanServerConnection>("getMBeanServerConnection"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#getMBeanServerConnection(javax.security.auth.Subject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Security.Auth.Subject"/></param>
        /// <returns><see cref="Javax.Management.MBeanServerConnection"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.MBeanServerConnection GetMBeanServerConnection(Javax.Security.Auth.Subject arg0)
        {
            return IExecute<Javax.Management.MBeanServerConnection>("getMBeanServerConnection", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#addConnectionNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void AddConnectionNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("addConnectionNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#close()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void Close()
        {
            IExecute("close");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#connect()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void Connect()
        {
            IExecute("connect");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#connect(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Connect<Arg0Extendsobject>(Java.Util.Map<string, Arg0Extendsobject> arg0)
        {
            IExecute("connect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#removeConnectionNotificationListener(javax.management.NotificationListener,javax.management.NotificationFilter,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <param name="arg1"><see cref="Javax.Management.NotificationFilter"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveConnectionNotificationListener(Javax.Management.NotificationListener arg0, Javax.Management.NotificationFilter arg1, object arg2)
        {
            IExecute("removeConnectionNotificationListener", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnector.html#removeConnectionNotificationListener(javax.management.NotificationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.NotificationListener"/></param>
        /// <exception cref="Javax.Management.ListenerNotFoundException"/>
        public void RemoveConnectionNotificationListener(Javax.Management.NotificationListener arg0)
        {
            IExecute("removeConnectionNotificationListener", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}