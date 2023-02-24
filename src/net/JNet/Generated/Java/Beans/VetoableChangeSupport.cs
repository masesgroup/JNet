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
    #region VetoableChangeSupport
    public partial class VetoableChangeSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#%3Cinit%3E(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        public VetoableChangeSupport(object arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Beans.VetoableChangeSupport"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Beans.VetoableChangeSupport t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#getVetoableChangeListeners()"/> 
        /// </summary>
        public Java.Beans.VetoableChangeListener[] VetoableChangeListeners
        {
            get { return IExecuteArray<Java.Beans.VetoableChangeListener>("getVetoableChangeListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#hasListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool HasListeners(string arg0)
        {
            return IExecute<bool>("hasListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#getVetoableChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Java.Beans.VetoableChangeListener"/></returns>
        public Java.Beans.VetoableChangeListener[] GetVetoableChangeListeners(string arg0)
        {
            return IExecuteArray<Java.Beans.VetoableChangeListener>("getVetoableChangeListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#addVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecute("addVetoableChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#addVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void AddVetoableChangeListener(string arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("addVetoableChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#fireVetoableChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void FireVetoableChange(Java.Beans.PropertyChangeEvent arg0)
        {
            IExecute("fireVetoableChange", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#fireVetoableChange(java.lang.String,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="bool"/></param>
        /// <param name="arg2"><see langword="bool"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void FireVetoableChange(string arg0, bool arg1, bool arg2)
        {
            IExecute("fireVetoableChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#fireVetoableChange(java.lang.String,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void FireVetoableChange(string arg0, int arg1, int arg2)
        {
            IExecute("fireVetoableChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#fireVetoableChange(java.lang.String,java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see langword="object"/></param>
        /// <param name="arg2"><see langword="object"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public void FireVetoableChange(string arg0, object arg1, object arg2)
        {
            IExecute("fireVetoableChange", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#removeVetoableChangeListener(java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(Java.Beans.VetoableChangeListener arg0)
        {
            IExecute("removeVetoableChangeListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeSupport.html#removeVetoableChangeListener(java.lang.String,java.beans.VetoableChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.VetoableChangeListener"/></param>
        public void RemoveVetoableChangeListener(string arg0, Java.Beans.VetoableChangeListener arg1)
        {
            IExecute("removeVetoableChangeListener", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}