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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Beans
{
    #region IVetoableChangeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.beans.VetoableChangeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeListener.html"/>
    /// </summary>
    public partial interface IVetoableChangeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeListener.html#vetoableChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        void VetoableChange(Java.Beans.PropertyChangeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region VetoableChangeListener
    public partial class VetoableChangeListener : Java.Beans.IVetoableChangeListener
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
        /// Handlers initializer for <see cref="VetoableChangeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("vetoableChange", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeEvent>>>(VetoableChangeEventHandler)); OnVetoableChange = VetoableChange;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeListener.html#vetoableChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        public System.Action<Java.Beans.PropertyChangeEvent> OnVetoableChange { get; set; }

        void VetoableChangeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Beans.PropertyChangeEvent>> data)
        {
            if (OnVetoableChange != null) OnVetoableChange.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/beans/VetoableChangeListener.html#vetoableChange(java.beans.PropertyChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Beans.PropertyChangeEvent"/></param>
        /// <exception cref="Java.Beans.PropertyVetoException"/>
        public virtual void VetoableChange(Java.Beans.PropertyChangeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}