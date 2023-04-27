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
    #region JMXConnectorServerMBean
    public partial class JMXConnectorServerMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAddress()"/> 
        /// </summary>
        public Javax.Management.Remote.JMXServiceURL Address
        {
            get { return IExecute<Javax.Management.Remote.JMXServiceURL>("getAddress"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getAttributes()"/> 
        /// </summary>
        public Java.Util.Map Attributes
        {
            get { return IExecute<Java.Util.Map>("getAttributes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#getConnectionIds()"/> 
        /// </summary>
        public string[] ConnectionIds
        {
            get { return IExecuteArray<string>("getConnectionIds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#isActive()"/> 
        /// </summary>
        public bool IsActive
        {
            get { return IExecute<bool>("isActive"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#toJMXConnector(java.util.Map)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Javax.Management.Remote.JMXConnector"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Management.Remote.JMXConnector ToJMXConnector<Arg0Extendsobject>(Java.Util.Map<string, Arg0Extendsobject> arg0)
        {
            return IExecute<Javax.Management.Remote.JMXConnector>("toJMXConnector", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#setMBeanServerForwarder(javax.management.remote.MBeanServerForwarder)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Remote.MBeanServerForwarder"/></param>
        public void SetMBeanServerForwarder(Javax.Management.Remote.MBeanServerForwarder arg0)
        {
            IExecute("setMBeanServerForwarder", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#start()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/remote/JMXConnectorServerMBean.html#stop()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Stop()
        {
            IExecute("stop");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}