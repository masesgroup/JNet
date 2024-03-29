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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region ITreeWillExpandListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.TreeWillExpandListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeWillExpandListener.html"/>
    /// </summary>
    public partial interface ITreeWillExpandListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeWillExpandListener.html#treeWillCollapse(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
        /// <exception cref="Javax.Swing.Tree.ExpandVetoException"/>
        void TreeWillCollapse(Javax.Swing.Event.TreeExpansionEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeWillExpandListener.html#treeWillExpand(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
        /// <exception cref="Javax.Swing.Tree.ExpandVetoException"/>
        void TreeWillExpand(Javax.Swing.Event.TreeExpansionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TreeWillExpandListener
    public partial class TreeWillExpandListener : Javax.Swing.Event.ITreeWillExpandListener
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
        /// Handlers initializer for <see cref="TreeWillExpandListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("treeWillCollapse", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeExpansionEvent>>>(TreeWillCollapseEventHandler));
            AddEventHandler("treeWillExpand", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeExpansionEvent>>>(TreeWillExpandEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeWillExpandListener.html#treeWillCollapse(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTreeWillCollapse"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.TreeExpansionEvent> OnTreeWillCollapse { get; set; } = null;

        void TreeWillCollapseEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeExpansionEvent>> data)
        {
            var methodToExecute = (OnTreeWillCollapse != null) ? OnTreeWillCollapse : TreeWillCollapse;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeWillExpandListener.html#treeWillCollapse(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
        /// <exception cref="Javax.Swing.Tree.ExpandVetoException"/>
        public virtual void TreeWillCollapse(Javax.Swing.Event.TreeExpansionEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeWillExpandListener.html#treeWillExpand(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTreeWillExpand"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.TreeExpansionEvent> OnTreeWillExpand { get; set; } = null;

        void TreeWillExpandEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TreeExpansionEvent>> data)
        {
            var methodToExecute = (OnTreeWillExpand != null) ? OnTreeWillExpand : TreeWillExpand;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TreeWillExpandListener.html#treeWillExpand(javax.swing.event.TreeExpansionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TreeExpansionEvent"/></param>
        /// <exception cref="Javax.Swing.Tree.ExpandVetoException"/>
        public virtual void TreeWillExpand(Javax.Swing.Event.TreeExpansionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}