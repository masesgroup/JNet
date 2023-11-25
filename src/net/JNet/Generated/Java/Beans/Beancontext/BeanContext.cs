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

namespace Java.Beans.Beancontext
{
    #region IBeanContext
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBeanContext
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#getResourceAsStream(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        Java.Io.InputStream GetResourceAsStream(string arg0, Java.Beans.Beancontext.BeanContextChild arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#instantiateChild(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        object InstantiateChild(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#getResource(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        Java.Net.URL GetResource(string arg0, Java.Beans.Beancontext.BeanContextChild arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#addBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        void AddBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#removeBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        void RemoveBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BeanContext
    public partial class BeanContext : Java.Beans.Beancontext.IBeanContext
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContext"/> to <see cref="Java.Beans.Beancontext.BeanContextChild"/>
        /// </summary>
        public static implicit operator Java.Beans.Beancontext.BeanContextChild(Java.Beans.Beancontext.BeanContext t) => t.Cast<Java.Beans.Beancontext.BeanContextChild>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContext"/> to <see cref="Java.Util.Collection"/>
        /// </summary>
        public static implicit operator Java.Util.Collection(Java.Beans.Beancontext.BeanContext t) => t.Cast<Java.Util.Collection>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContext"/> to <see cref="Java.Beans.DesignMode"/>
        /// </summary>
        public static implicit operator Java.Beans.DesignMode(Java.Beans.Beancontext.BeanContext t) => t.Cast<Java.Beans.DesignMode>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContext"/> to <see cref="Java.Beans.Visibility"/>
        /// </summary>
        public static implicit operator Java.Beans.Visibility(Java.Beans.Beancontext.BeanContext t) => t.Cast<Java.Beans.Visibility>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#globalHierarchyLock"/>
        /// </summary>
        public static object globalHierarchyLock { get { return SGetField(LocalBridgeClazz, "globalHierarchyLock"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#getResourceAsStream(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Io.InputStream GetResourceAsStream(string arg0, Java.Beans.Beancontext.BeanContextChild arg1)
        {
            return IExecute<Java.Io.InputStream>("getResourceAsStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#instantiateChild(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public object InstantiateChild(string arg0)
        {
            return IExecute("instantiateChild", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#getResource(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Net.URL GetResource(string arg0, Java.Beans.Beancontext.BeanContextChild arg1)
        {
            return IExecute<Java.Net.URL>("getResource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#addBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        public void AddBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0)
        {
            IExecute("addBeanContextMembershipListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContext.html#removeBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        public void RemoveBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0)
        {
            IExecute("removeBeanContextMembershipListener", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}