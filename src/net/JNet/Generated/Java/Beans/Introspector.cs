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

namespace Java.Beans
{
    #region Introspector
    public partial class Introspector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#IGNORE_ALL_BEANINFO"/>
        /// </summary>
        public static int IGNORE_ALL_BEANINFO => Clazz.GetField<int>("IGNORE_ALL_BEANINFO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#IGNORE_IMMEDIATE_BEANINFO"/>
        /// </summary>
        public static int IGNORE_IMMEDIATE_BEANINFO => Clazz.GetField<int>("IGNORE_IMMEDIATE_BEANINFO");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#USE_ALL_BEANINFO"/>
        /// </summary>
        public static int USE_ALL_BEANINFO => Clazz.GetField<int>("USE_ALL_BEANINFO");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfoSearchPath()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#setBeanInfoSearchPath(java.lang.String[])"/>
        /// </summary>
        public static string[] BeanInfoSearchPath
        {
            get { return SExecuteArray<string>("getBeanInfoSearchPath"); } set { SExecute("setBeanInfoSearchPath", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfo(java.lang.Class%3C?%3E,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Beans.BeanInfo"/></returns>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public static Java.Beans.BeanInfo GetBeanInfo(Java.Lang.Class arg0, int arg1)
        {
            return SExecute<Java.Beans.BeanInfo>("getBeanInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfo(java.lang.Class%3C?%3E,java.lang.Class%3C?%3E,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Beans.BeanInfo"/></returns>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public static Java.Beans.BeanInfo GetBeanInfo(Java.Lang.Class arg0, Java.Lang.Class arg1, int arg2)
        {
            return SExecute<Java.Beans.BeanInfo>("getBeanInfo", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfo(java.lang.Class%3C?%3E,java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Beans.BeanInfo"/></returns>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public static Java.Beans.BeanInfo GetBeanInfo(Java.Lang.Class arg0, Java.Lang.Class arg1)
        {
            return SExecute<Java.Beans.BeanInfo>("getBeanInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#getBeanInfo(java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="Java.Beans.BeanInfo"/></returns>
        /// <exception cref="Java.Beans.IntrospectionException"/>
        public static Java.Beans.BeanInfo GetBeanInfo(Java.Lang.Class arg0)
        {
            return SExecute<Java.Beans.BeanInfo>("getBeanInfo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#decapitalize(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="string"/></returns>
        public static string Decapitalize(string arg0)
        {
            return SExecute<string>("decapitalize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#flushCaches()"/>
        /// </summary>
        public static void FlushCaches()
        {
            SExecute("flushCaches");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/Introspector.html#flushFromCaches(java.lang.Class%3C?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        public static void FlushFromCaches(Java.Lang.Class arg0)
        {
            SExecute("flushFromCaches", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}