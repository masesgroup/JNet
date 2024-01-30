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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management
{
    #region IDynamicMBean
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IDynamicMBean
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#getMBeanInfo()"/> 
        /// </summary>
        Javax.Management.MBeanInfo MBeanInfo { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Management.AttributeNotFoundException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        object GetAttribute(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#invoke(java.lang.String,java.lang.Object[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        object Invoke(string arg0, object[] arg1, string[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#getAttributes(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.AttributeList"/></returns>
        Javax.Management.AttributeList GetAttributes(string[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#setAttributes(javax.management.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeList"/></param>
        /// <returns><see cref="Javax.Management.AttributeList"/></returns>
        Javax.Management.AttributeList SetAttributes(Javax.Management.AttributeList arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#setAttribute(javax.management.Attribute)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Attribute"/></param>
        /// <exception cref="Javax.Management.AttributeNotFoundException"/>
        /// <exception cref="Javax.Management.InvalidAttributeValueException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        void SetAttribute(Javax.Management.Attribute arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region DynamicMBean
    public partial class DynamicMBean : Javax.Management.IDynamicMBean
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#getMBeanInfo()"/> 
        /// </summary>
        public Javax.Management.MBeanInfo MBeanInfo
        {
            get { return IExecute<Javax.Management.MBeanInfo>("getMBeanInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Management.AttributeNotFoundException"/>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        public object GetAttribute(string arg0)
        {
            return IExecute("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#invoke(java.lang.String,java.lang.Object[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Javax.Management.MBeanException"/>
        /// <exception cref="Javax.Management.ReflectionException"/>
        public object Invoke(string arg0, object[] arg1, string[] arg2)
        {
            return IExecute("invoke", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#getAttributes(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.AttributeList"/></returns>
        public Javax.Management.AttributeList GetAttributes(string[] arg0)
        {
            return IExecute<Javax.Management.AttributeList>("getAttributes", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#setAttributes(javax.management.AttributeList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.AttributeList"/></param>
        /// <returns><see cref="Javax.Management.AttributeList"/></returns>
        public Javax.Management.AttributeList SetAttributes(Javax.Management.AttributeList arg0)
        {
            return IExecute<Javax.Management.AttributeList>("setAttributes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/DynamicMBean.html#setAttribute(javax.management.Attribute)"/>
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

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}