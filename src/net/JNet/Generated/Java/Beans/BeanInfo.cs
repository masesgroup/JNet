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

namespace Java.Beans
{
    #region BeanInfo
    public partial class BeanInfo
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#ICON_COLOR_16x16"/>
        /// </summary>
        public static int ICON_COLOR_16x16 => Clazz.GetField<int>("ICON_COLOR_16x16");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#ICON_COLOR_32x32"/>
        /// </summary>
        public static int ICON_COLOR_32x32 => Clazz.GetField<int>("ICON_COLOR_32x32");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#ICON_MONO_16x16"/>
        /// </summary>
        public static int ICON_MONO_16x16 => Clazz.GetField<int>("ICON_MONO_16x16");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#ICON_MONO_32x32"/>
        /// </summary>
        public static int ICON_MONO_32x32 => Clazz.GetField<int>("ICON_MONO_32x32");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getAdditionalBeanInfo()"/> 
        /// </summary>
        public Java.Beans.BeanInfo[] AdditionalBeanInfo
        {
            get { return IExecuteArray<Java.Beans.BeanInfo>("getAdditionalBeanInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getBeanDescriptor()"/> 
        /// </summary>
        public Java.Beans.BeanDescriptor BeanDescriptor
        {
            get { return IExecute<Java.Beans.BeanDescriptor>("getBeanDescriptor"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getDefaultEventIndex()"/> 
        /// </summary>
        public int DefaultEventIndex
        {
            get { return IExecute<int>("getDefaultEventIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getDefaultPropertyIndex()"/> 
        /// </summary>
        public int DefaultPropertyIndex
        {
            get { return IExecute<int>("getDefaultPropertyIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getEventSetDescriptors()"/> 
        /// </summary>
        public Java.Beans.EventSetDescriptor[] EventSetDescriptors
        {
            get { return IExecuteArray<Java.Beans.EventSetDescriptor>("getEventSetDescriptors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getMethodDescriptors()"/> 
        /// </summary>
        public Java.Beans.MethodDescriptor[] MethodDescriptors
        {
            get { return IExecuteArray<Java.Beans.MethodDescriptor>("getMethodDescriptors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getPropertyDescriptors()"/> 
        /// </summary>
        public Java.Beans.PropertyDescriptor[] PropertyDescriptors
        {
            get { return IExecuteArray<Java.Beans.PropertyDescriptor>("getPropertyDescriptors"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/BeanInfo.html#getIcon(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Image"/></returns>
        public Java.Awt.Image GetIcon(int arg0)
        {
            return IExecute<Java.Awt.Image>("getIcon", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}