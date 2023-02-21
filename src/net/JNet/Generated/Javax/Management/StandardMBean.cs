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
    #region StandardMBean
    public partial class StandardMBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Javax.Management.DynamicMBean(Javax.Management.StandardMBean t) => t.Cast<Javax.Management.DynamicMBean>();
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.StandardMBean t) => t.Cast<Javax.Management.MBeanRegistration>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#getImplementation() https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#setImplementation(java.lang.Object) throws javax.management.NotCompliantMBeanException
        /// </summary>
        public object Implementation
        {
            get { return IExecute("getImplementation"); } set { IExecute("setImplementation", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#getMBeanInfo() 
        /// </summary>
        public Javax.Management.MBeanInfo MBeanInfo
        {
            get { return IExecute<Javax.Management.MBeanInfo>("getMBeanInfo"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#getAttribute(java.lang.String) throws javax.management.AttributeNotFoundException,javax.management.MBeanException,javax.management.ReflectionException
        /// </summary>
        public object GetAttribute(string arg0)
        {
            return IExecute("getAttribute", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#invoke(java.lang.String,java.lang.Object[],java.lang.String[]) throws javax.management.MBeanException,javax.management.ReflectionException
        /// </summary>
        public object Invoke(string arg0, object[] arg1, string[] arg2)
        {
            return IExecute("invoke", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName) throws java.lang.Exception
        /// </summary>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectName>("preRegister", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#postDeregister()
        /// </summary>
        public void PostDeregister()
        {
            IExecute("postDeregister");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#postRegister(java.lang.Boolean)
        /// </summary>
        public void PostRegister(bool arg0)
        {
            IExecute("postRegister", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#preDeregister() throws java.lang.Exception
        /// </summary>
        public void PreDeregister()
        {
            IExecute("preDeregister");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/StandardMBean.html#setAttribute(javax.management.Attribute) throws javax.management.AttributeNotFoundException,javax.management.InvalidAttributeValueException,javax.management.MBeanException,javax.management.ReflectionException
        /// </summary>
        public void SetAttribute(Javax.Management.Attribute arg0)
        {
            IExecute("setAttribute", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}