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

namespace Javax.Swing.Event
{
    #region ICellEditorListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.CellEditorListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html"/>
    /// </summary>
    public partial interface ICellEditorListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingCanceled(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        void EditingCanceled(Javax.Swing.Event.ChangeEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingStopped(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        void EditingStopped(Javax.Swing.Event.ChangeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region CellEditorListener
    public partial class CellEditorListener : Javax.Swing.Event.ICellEditorListener
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
        /// Handlers initializer for <see cref="CellEditorListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("editingCanceled", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>>>(EditingCanceledEventHandler));
            AddEventHandler("editingStopped", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>>>(EditingStoppedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingCanceled(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEditingCanceled"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.ChangeEvent> OnEditingCanceled { get; set; } = null;

        void EditingCanceledEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>> data)
        {
            var methodToExecute = (OnEditingCanceled != null) ? OnEditingCanceled : EditingCanceled;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingCanceled(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public virtual void EditingCanceled(Javax.Swing.Event.ChangeEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingStopped(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnEditingStopped"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.ChangeEvent> OnEditingStopped { get; set; } = null;

        void EditingStoppedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.ChangeEvent>> data)
        {
            var methodToExecute = (OnEditingStopped != null) ? OnEditingStopped : EditingStopped;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CellEditorListener.html#editingStopped(javax.swing.event.ChangeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.ChangeEvent"/></param>
        public virtual void EditingStopped(Javax.Swing.Event.ChangeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}