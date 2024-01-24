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

namespace Javax.Swing.Event
{
    #region IAncestorListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.AncestorListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html"/>
    /// </summary>
    public partial interface IAncestorListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorAdded(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorEvent"/></param>
        void AncestorAdded(Javax.Swing.Event.AncestorEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorMoved(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorEvent"/></param>
        void AncestorMoved(Javax.Swing.Event.AncestorEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorRemoved(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorEvent"/></param>
        void AncestorRemoved(Javax.Swing.Event.AncestorEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AncestorListener
    public partial class AncestorListener : Javax.Swing.Event.IAncestorListener
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
        /// Handlers initializer for <see cref="AncestorListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("ancestorAdded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.AncestorEvent>>>(AncestorAddedEventHandler));
            AddEventHandler("ancestorMoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.AncestorEvent>>>(AncestorMovedEventHandler));
            AddEventHandler("ancestorRemoved", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.AncestorEvent>>>(AncestorRemovedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorAdded(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAncestorAdded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.AncestorEvent> OnAncestorAdded { get; set; } = null;

        void AncestorAddedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.AncestorEvent>> data)
        {
            var methodToExecute = (OnAncestorAdded != null) ? OnAncestorAdded : AncestorAdded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorAdded(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorEvent"/></param>
        public virtual void AncestorAdded(Javax.Swing.Event.AncestorEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorMoved(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAncestorMoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.AncestorEvent> OnAncestorMoved { get; set; } = null;

        void AncestorMovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.AncestorEvent>> data)
        {
            var methodToExecute = (OnAncestorMoved != null) ? OnAncestorMoved : AncestorMoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorMoved(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorEvent"/></param>
        public virtual void AncestorMoved(Javax.Swing.Event.AncestorEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorRemoved(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAncestorRemoved"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.AncestorEvent> OnAncestorRemoved { get; set; } = null;

        void AncestorRemovedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.AncestorEvent>> data)
        {
            var methodToExecute = (OnAncestorRemoved != null) ? OnAncestorRemoved : AncestorRemoved;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/AncestorListener.html#ancestorRemoved(javax.swing.event.AncestorEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.AncestorEvent"/></param>
        public virtual void AncestorRemoved(Javax.Swing.Event.AncestorEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}