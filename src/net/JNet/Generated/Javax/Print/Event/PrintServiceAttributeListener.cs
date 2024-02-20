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

namespace Javax.Print.Event
{
    #region IPrintServiceAttributeListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.javax.print.event.PrintServiceAttributeListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html"/>
    /// </summary>
    public partial interface IPrintServiceAttributeListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html#attributeUpdate(javax.print.event.PrintServiceAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeEvent"/></param>
        void AttributeUpdate(Javax.Print.Event.PrintServiceAttributeEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrintServiceAttributeListener
    public partial class PrintServiceAttributeListener : Javax.Print.Event.IPrintServiceAttributeListener
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
        /// Handlers initializer for <see cref="PrintServiceAttributeListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("attributeUpdate", new System.EventHandler<CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintServiceAttributeEvent>>>(AttributeUpdateEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html#attributeUpdate(javax.print.event.PrintServiceAttributeEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAttributeUpdate"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Javax.Print.Event.PrintServiceAttributeEvent> OnAttributeUpdate { get; set; } = null;

        void AttributeUpdateEventHandler(object sender, CLRListenerEventArgs<CLREventData<Javax.Print.Event.PrintServiceAttributeEvent>> data)
        {
            var methodToExecute = (OnAttributeUpdate != null) ? OnAttributeUpdate : AttributeUpdate;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/print/event/PrintServiceAttributeListener.html#attributeUpdate(javax.print.event.PrintServiceAttributeEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Print.Event.PrintServiceAttributeEvent"/></param>
        public virtual void AttributeUpdate(Javax.Print.Event.PrintServiceAttributeEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}