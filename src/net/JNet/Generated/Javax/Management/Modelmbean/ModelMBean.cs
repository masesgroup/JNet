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
    #region ModelMBean
    public partial class ModelMBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Management.DynamicMBean(Javax.Management.Modelmbean.ModelMBean t) => t.Cast<Javax.Management.DynamicMBean>();
        public static implicit operator Javax.Management.PersistentMBean(Javax.Management.Modelmbean.ModelMBean t) => t.Cast<Javax.Management.PersistentMBean>();
        public static implicit operator Javax.Management.Modelmbean.ModelMBeanNotificationBroadcaster(Javax.Management.Modelmbean.ModelMBean t) => t.Cast<Javax.Management.Modelmbean.ModelMBeanNotificationBroadcaster>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBean.html#setManagedResource(java.lang.Object,java.lang.String) throws javax.management.MBeanException,javax.management.RuntimeOperationsException,javax.management.InstanceNotFoundException,javax.management.modelmbean.InvalidTargetObjectTypeException
        /// </summary>
        public void SetManagedResource(object arg0, string arg1)
        {
            IExecute("setManagedResource", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/modelmbean/ModelMBean.html#setModelMBeanInfo(javax.management.modelmbean.ModelMBeanInfo) throws javax.management.MBeanException,javax.management.RuntimeOperationsException
        /// </summary>
        public void SetModelMBeanInfo(Javax.Management.Modelmbean.ModelMBeanInfo arg0)
        {
            IExecute("setModelMBeanInfo", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}