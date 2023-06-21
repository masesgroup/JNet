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

namespace Java.Awt.EventNs
{
    #region ContainerAdapter
    public partial class ContainerAdapter
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
        /// <see cref="ContainerAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("componentAdded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ContainerEvent>>>(ComponentAddedEventHandler)); OnComponentAdded = ComponentAdded;
            AddEventHandler("componentRemoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ContainerEvent>>>(ComponentRemovedEventHandler)); OnComponentRemoved = ComponentRemoved;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerAdapter.html#componentAdded(java.awt.event.ContainerEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.ContainerEvent> OnComponentAdded { get; set; }

        void ComponentAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ContainerEvent>> data)
        {
            if (OnComponentAdded != null) OnComponentAdded.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerAdapter.html#componentAdded(java.awt.event.ContainerEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ContainerEvent"/></param>
        public virtual void ComponentAdded(Java.Awt.EventNs.ContainerEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerAdapter.html#componentRemoved(java.awt.event.ContainerEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.ContainerEvent> OnComponentRemoved { get; set; }

        void ComponentRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ContainerEvent>> data)
        {
            if (OnComponentRemoved != null) OnComponentRemoved.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ContainerAdapter.html#componentRemoved(java.awt.event.ContainerEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ContainerEvent"/></param>
        public virtual void ComponentRemoved(Java.Awt.EventNs.ContainerEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}