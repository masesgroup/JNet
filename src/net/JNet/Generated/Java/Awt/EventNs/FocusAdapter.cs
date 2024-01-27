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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.EventNs
{
    #region FocusAdapter
    public partial class FocusAdapter
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
        /// Handlers initializer for <see cref="FocusAdapter"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("focusGained", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.FocusEvent>>>(FocusGainedEventHandler));
            AddEventHandler("focusLost", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.FocusEvent>>>(FocusLostEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnFocusGained"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.FocusEvent> OnFocusGained { get; set; } = null;

        void FocusGainedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.FocusEvent>> data)
        {
            var methodToExecute = (OnFocusGained != null) ? OnFocusGained : FocusGained;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusGained(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public virtual void FocusGained(Java.Awt.EventNs.FocusEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnFocusLost"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.EventNs.FocusEvent> OnFocusLost { get; set; } = null;

        void FocusLostEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.EventNs.FocusEvent>> data)
        {
            var methodToExecute = (OnFocusLost != null) ? OnFocusLost : FocusLost;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/FocusAdapter.html#focusLost(java.awt.event.FocusEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.FocusEvent"/></param>
        public virtual void FocusLost(Java.Awt.EventNs.FocusEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}