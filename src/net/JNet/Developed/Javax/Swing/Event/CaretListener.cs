﻿/*
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

namespace Javax.Swing.Event
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CaretListener.html"/>
    /// </summary>
    public partial interface ICaretListener : IJVMBridgeBase
    {

    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/CaretListener.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>, implements <see cref="ICaretListener"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class CaretListener : ICaretListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.swing.event.JNetCaretListener";

        readonly Action<CaretEvent> CaretUpdateFunction = null;
        /// <summary>
        /// The <see cref="Action{CaretEvent}"/> to be executed on CaretUpdate
        /// </summary>
        public virtual Action<CaretEvent> OnCaretUpdate { get { return CaretUpdateFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="CaretListener"/>
        /// </summary>
        /// <param name="caretUpdate">The <see cref="Action{CaretEvent}"/> to be executed on CaretUpdate</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public CaretListener(Action<CaretEvent> caretUpdate = null, bool attachEventHandler = true)
        {
            if (caretUpdate != null) CaretUpdateFunction = caretUpdate;
            else CaretUpdateFunction = CaretUpdate;

            if (attachEventHandler)
            {
                AddEventHandler("caretUpdate", new EventHandler<CLRListenerEventArgs<CLREventData<CaretEvent>>>(EventHandlerCaretUpdate));
            }
        }

        void EventHandlerCaretUpdate(object sender, CLRListenerEventArgs<CLREventData<CaretEvent>> data)
        {
            OnCaretUpdate(data.EventData.TypedEventData);
        }
    }
}