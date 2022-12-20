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

namespace Java.Awt.Event
{
    public interface IComponentListener : IJVMBridgeBase
    {
        void ComponentResized(ComponentEvent e);

        void ComponentMoved(ComponentEvent e);

        void ComponentShown(ComponentEvent e);

        void ComponentHidden(ComponentEvent e);
    }

    /// <summary>
    /// Listener for ComponentListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IComponentListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public class ComponentListener : JVMBridgeListener, IComponentListener
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.awt.event.JNetComponentListener";

        readonly Action<ComponentEvent> componentResizedFunction = null;
        readonly Action<ComponentEvent> componentMovedFunction = null;
        readonly Action<ComponentEvent> componentShownFunction = null;
        readonly Action<ComponentEvent> componentHiddenFunction = null;
        /// <summary>
        /// The <see cref="Action{ComponentEvent}"/> to be executed on ComponentResized
        /// </summary>
        public virtual Action<ComponentEvent> OnComponentResized { get { return componentResizedFunction; } }
        /// <summary>
        /// The <see cref="Action{ComponentEvent}"/> to be executed on ComponentMoved
        /// </summary>
        public virtual Action<ComponentEvent> OnComponentMoved { get { return componentMovedFunction; } }
        /// <summary>
        /// The <see cref="Action{ComponentEvent}"/> to be executed on ComponentShown
        /// </summary>
        public virtual Action<ComponentEvent> OnComponentShown { get { return componentShownFunction; } }
        /// <summary>
        /// The <see cref="Action{ComponentEvent}"/> to be executed on ComponentHidden
        /// </summary>
        public virtual Action<ComponentEvent> OnComponentHidden { get { return componentHiddenFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="ComponentListener"/>
        /// </summary>
        /// <param name="componentResized">The <see cref="Action{ComponentEvent}"/> to be executed on ComponentResized</param>
        /// <param name="componentMoved">The <see cref="Action{ComponentEvent}"/> to be executed on ComponentMoved</param>
        /// <param name="componentShown">The <see cref="Action{ComponentEvent}"/> to be executed on ComponentShown</param>
        /// <param name="componentHidden">The <see cref="Action{ComponentEvent}"/> to be executed on ComponentHidden</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public ComponentListener(Action<ComponentEvent> componentResized = null,
                                 Action<ComponentEvent> componentMoved = null,
                                 Action<ComponentEvent> componentShown = null,
                                 Action<ComponentEvent> componentHidden = null,
                                 bool attachEventHandler = true)
        {
            if (componentResized != null) componentResizedFunction = componentResized;
            else componentResizedFunction = ComponentResized;
            if (componentMoved != null) componentMovedFunction = componentMoved;
            else componentMovedFunction = ComponentMoved;
            if (componentShown != null) componentShownFunction = componentShown;
            else componentShownFunction = ComponentShown;
            if (componentHidden != null) componentHiddenFunction = componentHidden;
            else componentHiddenFunction = ComponentHidden;

            if (attachEventHandler)
            {
                AddEventHandler("componentResized", new EventHandler<CLRListenerEventArgs<CLREventData<ComponentEvent>>>(EventHandlerComponentResized));
                AddEventHandler("componentMoved", new EventHandler<CLRListenerEventArgs<CLREventData<ComponentEvent>>>(EventHandlerComponentMoved));
                AddEventHandler("componentShown", new EventHandler<CLRListenerEventArgs<CLREventData<ComponentEvent>>>(EventHandlerComponentShown));
                AddEventHandler("componentHidden", new EventHandler<CLRListenerEventArgs<CLREventData<ComponentEvent>>>(EventHandlerComponentHidden));
            }
        }

        void EventHandlerComponentResized(object sender, CLRListenerEventArgs<CLREventData<ComponentEvent>> data)
        {
            OnComponentResized(data.EventData.TypedEventData);
        }

        void EventHandlerComponentMoved(object sender, CLRListenerEventArgs<CLREventData<ComponentEvent>> data)
        {
            OnComponentMoved(data.EventData.TypedEventData);
        }

        void EventHandlerComponentShown(object sender, CLRListenerEventArgs<CLREventData<ComponentEvent>> data)
        {
            OnComponentShown(data.EventData.TypedEventData);
        }

        void EventHandlerComponentHidden(object sender, CLRListenerEventArgs<CLREventData<ComponentEvent>> data)
        {
            OnComponentHidden(data.EventData.TypedEventData);
        }

        public virtual void ComponentResized(ComponentEvent e)
        {

        }

        public virtual void ComponentMoved(ComponentEvent e)
        {

        }

        public virtual void ComponentShown(ComponentEvent e)
        {

        }

        public virtual void ComponentHidden(ComponentEvent e)
        {

        }
    }
}
