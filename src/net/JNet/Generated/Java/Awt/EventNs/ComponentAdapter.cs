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
    #region ComponentAdapter
    public partial class ComponentAdapter
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
        /// <see cref="ComponentAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("componentHidden", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ComponentEvent>>>(ComponentHiddenEventHandler)); OnComponentHidden = ComponentHidden;
            AddEventHandler("componentMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ComponentEvent>>>(ComponentMovedEventHandler)); OnComponentMoved = ComponentMoved;
            AddEventHandler("componentResized", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ComponentEvent>>>(ComponentResizedEventHandler)); OnComponentResized = ComponentResized;
            AddEventHandler("componentShown", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ComponentEvent>>>(ComponentShownEventHandler)); OnComponentShown = ComponentShown;

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentHidden(java.awt.event.ComponentEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.ComponentEvent> OnComponentHidden { get; set; }

        void ComponentHiddenEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ComponentEvent>> data)
        {
            if (OnComponentHidden != null) OnComponentHidden.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentHidden(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public virtual void ComponentHidden(Java.Awt.EventNs.ComponentEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentMoved(java.awt.event.ComponentEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.ComponentEvent> OnComponentMoved { get; set; }

        void ComponentMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ComponentEvent>> data)
        {
            if (OnComponentMoved != null) OnComponentMoved.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentMoved(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public virtual void ComponentMoved(Java.Awt.EventNs.ComponentEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentResized(java.awt.event.ComponentEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.ComponentEvent> OnComponentResized { get; set; }

        void ComponentResizedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ComponentEvent>> data)
        {
            if (OnComponentResized != null) OnComponentResized.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentResized(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public virtual void ComponentResized(Java.Awt.EventNs.ComponentEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentShown(java.awt.event.ComponentEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.EventNs.ComponentEvent> OnComponentShown { get; set; }

        void ComponentShownEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.ComponentEvent>> data)
        {
            if (OnComponentShown != null) OnComponentShown.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ComponentAdapter.html#componentShown(java.awt.event.ComponentEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.ComponentEvent"/></param>
        public virtual void ComponentShown(Java.Awt.EventNs.ComponentEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}