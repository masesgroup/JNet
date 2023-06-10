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

namespace Java.Awt.Dnd
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureListener.html"/>
    /// </summary>
    public partial interface IDragGestureListener : IJVMBridgeBase
    {

    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/dnd/DragGestureListener.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>, implements <see cref="IDragGestureListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class DragGestureListener : IDragGestureListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.awt.dnd.JNetDragGestureListener";

        readonly Action<DragGestureEvent> DragGestureRecognizedFunction = null;
        /// <summary>
        /// The <see cref="Action{DragGestureEvent}"/> to be executed on DragGestureRecognized
        /// </summary>
        public virtual Action<DragGestureEvent> OnDragGestureRecognized { get { return DragGestureRecognizedFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="DragGestureListener"/>
        /// </summary>
        /// <param name="dragGestureRecognized">The <see cref="Action{DragGestureEvent}"/> to be executed on DragGestureRecognized</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public DragGestureListener(Action<DragGestureEvent> dragGestureRecognized = null, bool attachEventHandler = true)
        {
            if (dragGestureRecognized != null) DragGestureRecognizedFunction = dragGestureRecognized;
            else DragGestureRecognizedFunction = DragGestureRecognized;

            if (attachEventHandler)
            {
                AddEventHandler("dragGestureRecognized", new EventHandler<CLRListenerEventArgs<CLREventData<DragGestureEvent>>>(EventHandlerDragGestureRecognized));
            }
        }

        void EventHandlerDragGestureRecognized(object sender, CLRListenerEventArgs<CLREventData<DragGestureEvent>> data)
        {
            OnDragGestureRecognized(data.EventData.TypedEventData);
        }
    }
}
