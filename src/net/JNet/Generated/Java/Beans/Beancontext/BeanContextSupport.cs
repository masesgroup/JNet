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

namespace Java.Beans.Beancontext
{
    #region BeanContextSupport
    public partial class BeanContextSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContext,java.util.Locale,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContext"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        public BeanContextSupport(Java.Beans.Beancontext.BeanContext arg0, Java.Util.Locale arg1, bool arg2, bool arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContext,java.util.Locale,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContext"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public BeanContextSupport(Java.Beans.Beancontext.BeanContext arg0, Java.Util.Locale arg1, bool arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContext,java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContext"/></param>
        /// <param name="arg1"><see cref="Java.Util.Locale"/></param>
        public BeanContextSupport(Java.Beans.Beancontext.BeanContext arg0, Java.Util.Locale arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContext"/></param>
        public BeanContextSupport(Java.Beans.Beancontext.BeanContext arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextSupport"/> to <see cref="Java.Beans.Beancontext.BeanContext"/>
        /// </summary>
        public static implicit operator Java.Beans.Beancontext.BeanContext(Java.Beans.Beancontext.BeanContextSupport t) => t.Cast<Java.Beans.Beancontext.BeanContext>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextSupport"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Beans.Beancontext.BeanContextSupport t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextSupport"/> to <see cref="Java.Beans.PropertyChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.PropertyChangeListener(Java.Beans.Beancontext.BeanContextSupport t) => t.Cast<Java.Beans.PropertyChangeListener>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextSupport"/> to <see cref="Java.Beans.VetoableChangeListener"/>
        /// </summary>
        public static implicit operator Java.Beans.VetoableChangeListener(Java.Beans.Beancontext.BeanContextSupport t) => t.Cast<Java.Beans.VetoableChangeListener>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#getBeanContextPeer()"/> 
        /// </summary>
        public Java.Beans.Beancontext.BeanContext BeanContextPeer
        {
            get { return IExecute<Java.Beans.Beancontext.BeanContext>("getBeanContextPeer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#getLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#setLocale(java.util.Locale)"/>
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecute<Java.Util.Locale>("getLocale"); } set { IExecute("setLocale", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#add(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Add(object arg0)
        {
            return IExecute<bool>("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#addAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool AddAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("addAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#avoidingGui()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool AvoidingGui()
        {
            return IExecute<bool>("avoidingGui");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#contains(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Contains(object arg0)
        {
            return IExecute<bool>("contains", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#containsAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool ContainsAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("containsAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#containsKey(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool ContainsKey(object arg0)
        {
            return IExecute<bool>("containsKey", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#isEmpty()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsEmpty()
        {
            return IExecute<bool>("isEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#isSerializing()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsSerializing()
        {
            return IExecute<bool>("isSerializing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#remove(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool Remove(object arg0)
        {
            return IExecute<bool>("remove", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#removeAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool RemoveAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("removeAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#retainAll(java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool RetainAll(Java.Util.Collection arg0)
        {
            return IExecute<bool>("retainAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#readChildren(java.io.ObjectInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectInputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public void ReadChildren(Java.Io.ObjectInputStream arg0)
        {
            IExecute("readChildren", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#writeChildren(java.io.ObjectOutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.ObjectOutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteChildren(Java.Io.ObjectOutputStream arg0)
        {
            IExecute("writeChildren", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#size()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Size()
        {
            return IExecute<int>("size");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#getResourceAsStream(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Io.InputStream"/></returns>
        public Java.Io.InputStream GetResourceAsStream(string arg0, Java.Beans.Beancontext.BeanContextChild arg1)
        {
            return IExecute<Java.Io.InputStream>("getResourceAsStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#instantiateChild(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        /// <exception cref="Java.Lang.ClassNotFoundException"/>
        public object InstantiateChild(string arg0)
        {
            return IExecute("instantiateChild", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#toArray()"/>
        /// </summary>
        
        /// <returns><see cref="object"/></returns>
        public object[] ToArray()
        {
            return IExecuteArray<object>("toArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#toArray(java.lang.Object[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object[] ToArray(object[] arg0)
        {
            return IExecuteArray<object>("toArray", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#getResource(java.lang.String,java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        /// <returns><see cref="Java.Net.URL"/></returns>
        public Java.Net.URL GetResource(string arg0, Java.Beans.Beancontext.BeanContextChild arg1)
        {
            return IExecute<Java.Net.URL>("getResource", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#iterator()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator Iterator()
        {
            return IExecute<Java.Util.Iterator>("iterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#isDesignTime()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsDesignTime()
        {
            return IExecute<bool>("isDesignTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#needsGui()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool NeedsGui()
        {
            return IExecute<bool>("needsGui");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#dontUseGui()"/>
        /// </summary>
        public void DontUseGui()
        {
            IExecute("dontUseGui");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#okToUseGui()"/>
        /// </summary>
        public void OkToUseGui()
        {
            IExecute("okToUseGui");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#setDesignTime(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetDesignTime(bool arg0)
        {
            IExecute("setDesignTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#addBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        public void AddBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0)
        {
            IExecute("addBeanContextMembershipListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#propertyChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        public void PropertyChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecute("propertyChange", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#removeBeanContextMembershipListener(java.beans.beancontext.BeanContextMembershipListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextMembershipListener"/></param>
        public void RemoveBeanContextMembershipListener(Java.Beans.Beancontext.BeanContextMembershipListener arg0)
        {
            IExecute("removeBeanContextMembershipListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextSupport.html#vetoableChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void VetoableChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecute("vetoableChange", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}