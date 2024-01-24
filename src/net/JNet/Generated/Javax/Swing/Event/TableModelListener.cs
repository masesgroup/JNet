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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Event
{
    #region ITableModelListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.swing.event.TableModelListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html"/>
    /// </summary>
    public partial interface ITableModelListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html#tableChanged(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        void TableChanged(Javax.Swing.Event.TableModelEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region TableModelListener
    public partial class TableModelListener : Javax.Swing.Event.ITableModelListener
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
        /// Handlers initializer for <see cref="TableModelListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("tableChanged", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableModelEvent>>>(TableChangedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html#tableChanged(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnTableChanged"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Swing.Event.TableModelEvent> OnTableChanged { get; set; } = null;

        void TableChangedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Swing.Event.TableModelEvent>> data)
        {
            var methodToExecute = (OnTableChanged != null) ? OnTableChanged : TableChanged;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/TableModelListener.html#tableChanged(javax.swing.event.TableModelEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.Event.TableModelEvent"/></param>
        public virtual void TableChanged(Javax.Swing.Event.TableModelEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}