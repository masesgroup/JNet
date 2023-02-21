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

namespace Javax.Management.Monitor
{
    #region Monitor
    public partial class Monitor
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Management.Monitor.MonitorMBean(Javax.Management.Monitor.Monitor t) => t.Cast<Javax.Management.Monitor.MonitorMBean>();
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Monitor.Monitor t) => t.Cast<Javax.Management.MBeanRegistration>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#getGranularityPeriod() https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#setGranularityPeriod(long) throws java.lang.IllegalArgumentException
        /// </summary>
        public long GranularityPeriod
        {
            get { return IExecute<long>("getGranularityPeriod"); } set { IExecute("setGranularityPeriod", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#getObservedAttribute() https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#setObservedAttribute(java.lang.String) throws java.lang.IllegalArgumentException
        /// </summary>
        public string ObservedAttribute
        {
            get { return IExecute<string>("getObservedAttribute"); } set { IExecute("setObservedAttribute", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#getObservedObjects() 
        /// </summary>
        public Javax.Management.ObjectName[] ObservedObjects
        {
            get { return IExecuteArray<Javax.Management.ObjectName>("getObservedObjects"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#start()
        /// </summary>
        public void Start()
        {
            IExecute("start");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#stop()
        /// </summary>
        public void Stop()
        {
            IExecute("stop");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName) throws java.lang.Exception
        /// </summary>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectName>("preRegister", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#containsObservedObject(javax.management.ObjectName)
        /// </summary>
        public bool ContainsObservedObject(Javax.Management.ObjectName arg0)
        {
            return IExecute<bool>("containsObservedObject", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#isActive()
        /// </summary>
        public bool IsActive()
        {
            return IExecute<bool>("isActive");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#addObservedObject(javax.management.ObjectName) throws java.lang.IllegalArgumentException
        /// </summary>
        public void AddObservedObject(Javax.Management.ObjectName arg0)
        {
            IExecute("addObservedObject", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#removeObservedObject(javax.management.ObjectName)
        /// </summary>
        public void RemoveObservedObject(Javax.Management.ObjectName arg0)
        {
            IExecute("removeObservedObject", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#postDeregister()
        /// </summary>
        public void PostDeregister()
        {
            IExecute("postDeregister");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#postRegister(java.lang.Boolean)
        /// </summary>
        public void PostRegister(bool arg0)
        {
            IExecute("postRegister", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/monitor/Monitor.html#preDeregister() throws java.lang.Exception
        /// </summary>
        public void PreDeregister()
        {
            IExecute("preDeregister");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}