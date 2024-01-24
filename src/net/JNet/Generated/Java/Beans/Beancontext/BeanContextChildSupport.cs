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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans.Beancontext
{
    #region BeanContextChildSupport
    public partial class BeanContextChildSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#%3Cinit%3E(java.beans.beancontext.BeanContextChild)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextChild"/></param>
        public BeanContextChildSupport(Java.Beans.Beancontext.BeanContextChild arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextChildSupport"/> to <see cref="Java.Beans.Beancontext.BeanContextChild"/>
        /// </summary>
        public static implicit operator Java.Beans.Beancontext.BeanContextChild(Java.Beans.Beancontext.BeanContextChildSupport t) => t.Cast<Java.Beans.Beancontext.BeanContextChild>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextChildSupport"/> to <see cref="Java.Beans.Beancontext.BeanContextServicesListener"/>
        /// </summary>
        public static implicit operator Java.Beans.Beancontext.BeanContextServicesListener(Java.Beans.Beancontext.BeanContextChildSupport t) => t.Cast<Java.Beans.Beancontext.BeanContextServicesListener>();
        /// <summary>
        /// Converter from <see cref="Java.Beans.Beancontext.BeanContextChildSupport"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Beans.Beancontext.BeanContextChildSupport t) => t.Cast<Java.Io.Serializable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#beanContextChildPeer"/>
        /// </summary>
        public Java.Beans.Beancontext.BeanContextChild beanContextChildPeer { get { return IGetField<Java.Beans.Beancontext.BeanContextChild>("beanContextChildPeer"); } set { ISetField("beanContextChildPeer", value); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#getBeanContext()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#setBeanContext(java.beans.beancontext.BeanContext)"/>
        /// </summary>
        public Java.Beans.Beancontext.BeanContext BeanContext
        {
            get { return IExecute<Java.Beans.Beancontext.BeanContext>("getBeanContext"); } set { IExecute("setBeanContext", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#getBeanContextChildPeer()"/> 
        /// </summary>
        public Java.Beans.Beancontext.BeanContextChild BeanContextChildPeer
        {
            get { return IExecute<Java.Beans.Beancontext.BeanContextChild>("getBeanContextChildPeer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#isDelegated()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDelegated()
        {
            return IExecute<bool>("isDelegated");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#validatePendingSetBeanContext(java.beans.beancontext.BeanContext)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContext"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool ValidatePendingSetBeanContext(Java.Beans.Beancontext.BeanContext arg0)
        {
            return IExecute<bool>("validatePendingSetBeanContext", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#addVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(string arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("addVetoableChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#firePropertyChange(java.lang.String,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void FirePropertyChange(string arg0, object arg1, object arg2)
        {
            IExecute("firePropertyChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#fireVetoableChange(java.lang.String,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void FireVetoableChange(string arg0, object arg1, object arg2)
        {
            IExecute("fireVetoableChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#removeVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(string arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("removeVetoableChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#serviceAvailable(java.beans.beancontext.BeanContextServiceAvailableEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServiceAvailableEvent"/></param>
        public void ServiceAvailable(Java.Beans.Beancontext.BeanContextServiceAvailableEvent arg0)
        {
            IExecute("serviceAvailable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/beancontext/BeanContextChildSupport.html#serviceRevoked(java.beans.beancontext.BeanContextServiceRevokedEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.Beancontext.BeanContextServiceRevokedEvent"/></param>
        public void ServiceRevoked(Java.Beans.Beancontext.BeanContextServiceRevokedEvent arg0)
        {
            IExecute("serviceRevoked", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}