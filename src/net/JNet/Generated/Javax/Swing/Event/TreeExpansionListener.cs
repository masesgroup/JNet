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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region ITreeExpansionListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.TreeExpansionListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeExpansionListener.html"/>
    /// </summary>
    public partial interface ITreeExpansionListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeExpansionListener.html#treeCollapsed(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
        void TreeCollapsed(Javax.Swing.Event.TreeExpansionEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeExpansionListener.html#treeExpanded(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
        void TreeExpanded(Javax.Swing.Event.TreeExpansionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeExpansionListener
    public partial class TreeExpansionListener : Javax.Swing.Event.ITreeExpansionListener
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
        /// Handlers initializer for <see cref="TreeExpansionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("treeCollapsed", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeExpansionEvent>>>(TreeCollapsedEventHandler));
            AddEventHandler("treeExpanded", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeExpansionEvent>>>(TreeExpandedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeExpansionListener.html#treeCollapsed(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTreeCollapsed"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.TreeExpansionEvent> OnTreeCollapsed { get; set; } = null;

        void TreeCollapsedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeExpansionEvent>> data)
        {
            var methodToExecute = (OnTreeCollapsed != null) ? OnTreeCollapsed : TreeCollapsed;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeExpansionListener.html#treeCollapsed(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
        public virtual void TreeCollapsed(Javax.Swing.Event.TreeExpansionEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeExpansionListener.html#treeExpanded(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTreeExpanded"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.TreeExpansionEvent> OnTreeExpanded { get; set; } = null;

        void TreeExpandedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeExpansionEvent>> data)
        {
            var methodToExecute = (OnTreeExpanded != null) ? OnTreeExpanded : TreeExpanded;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeExpansionListener.html#treeExpanded(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
        public virtual void TreeExpanded(Javax.Swing.Event.TreeExpansionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}