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

namespace Javax.Naming.Event
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/ObjectChangeListener.html"/>
    /// </summary>
    public interface IObjectChangeListener : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/event/ObjectChangeListener.html#objectChanged(javax.naming.event.NamingEvent)"/>
        /// </summary>
        void ObjectChanged(NamingEvent evt);
    }

    /// <summary>
    /// Listener for ObjectChangeListener. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IObjectChangeListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class ObjectChangeListener : IObjectChangeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public sealed override string ClassName => "org.mases.jnet.naming.event.JNetObjectChangeListener";

        readonly Action<NamingEvent> ObjectChangedFunction = null;
        /// <summary>
        /// The <see cref="Action{NamingEvent}"/> to be executed on ObjectChanged
        /// </summary>
        public virtual Action<NamingEvent> OnObjectChanged { get { return ObjectChangedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="ObjectChangeListener"/>
        /// </summary>
        /// <param name="objectChanged">The <see cref="Action{NamingEvent}"/> to be executed on ObjectChanged</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public ObjectChangeListener(Action<NamingEvent> objectChanged = null, bool attachEventHandler = true)
        {
            if (objectChanged != null) ObjectChangedFunction = objectChanged;
            else ObjectChangedFunction = ObjectChanged;

            if (attachEventHandler)
            {
                AddEventHandler("namingExceptionThrown", new EventHandler<CLRListenerEventArgs<CLREventData<NamingEvent>>>(EventHandlerObjectChanged));
            }
        }

        void EventHandlerObjectChanged(object sender, CLRListenerEventArgs<CLREventData<NamingEvent>> data)
        {
            OnObjectChanged(data.EventData.TypedEventData);
        }
        /// <inheritdoc cref="IObjectChangeListener.ObjectChanged(NamingEvent)"/>
        public virtual void ObjectChanged(NamingEvent evt)
        {

        }
    }
}
