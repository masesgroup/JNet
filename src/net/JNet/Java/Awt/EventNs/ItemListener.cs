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

using MASES.JCOBridge.C2JBridge;
using System;

namespace Java.Awt.EventNs
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemListener.html"/>
    /// </summary>
    public interface IItemListener : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemListener.html#itemStateChanged(java.awt.event.ItemEvent)"/>
        /// </summary>
        void ItemStateChanged(ItemEvent e);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/ItemListener.html"/>. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IItemListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class ItemListener : IItemListener
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetItemListener";

        readonly Action<ItemEvent> itemStateChangedFunction = null;
        /// <summary>
        /// The <see cref="Action{ItemEvent}"/> to be executed on ItemStateChanged
        /// </summary>
        public virtual Action<ItemEvent> OnItemStateChanged { get { return itemStateChangedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="ItemListener"/>
        /// </summary>
        /// <param name="itemStateChanged">The <see cref="Action{ItemEvent}"/> to be executed on ItemStateChanged</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public ItemListener(Action<ItemEvent> itemStateChanged = null, bool attachEventHandler = true)
        {
            if (itemStateChanged != null) itemStateChangedFunction = itemStateChanged;
            else itemStateChangedFunction = ItemStateChanged;

            if (attachEventHandler)
            {
                AddEventHandler("itemStateChanged", new EventHandler<CLRListenerEventArgs<CLREventData<ItemEvent>>>(EventHandlerItemStateChanged));
            }
        }

        void EventHandlerItemStateChanged(object sender, CLRListenerEventArgs<CLREventData<ItemEvent>> data)
        {
            OnItemStateChanged(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="IItemListener.ItemStateChanged(ItemEvent)"/>
        public void ItemStateChanged(ItemEvent e)
        {
            throw new NotImplementedException();
        }
    }
}
