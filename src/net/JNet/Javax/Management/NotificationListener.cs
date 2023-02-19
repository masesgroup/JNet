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

namespace Javax.Management
{
    public interface INotificationListener : IJVMBridgeBase
    {
        /// <summary>
        /// Invoked when a JMX notification occurs.
        /// </summary>
        void HandleNotification(Notification notification, object handback);
    }

    public class NotificationListener : JVMBridgeListener, INotificationListener
    {
        public override bool IsInterface => true;

        public override string ClassName => "org.mases.jnet.management.JNetNotificationListener";

        readonly Action<Notification, object> handleNotificationFunction = null;
        /// <summary>
        /// The <see cref="Action{Notification, object}"/> to be executed on HandleNotification
        /// </summary>
        public virtual Action<Notification, object> OnHandleNotification { get { return handleNotificationFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="NotificationListener"/>
        /// </summary>
        /// <param name="handleNotification">The <see cref="Action{Notification, object}"/> to be executed on HandleNotification</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public NotificationListener(Action<Notification, object> handleNotification = null, bool attachEventHandler = true)
        {
            if (handleNotification != null) handleNotificationFunction = handleNotification;
            else handleNotificationFunction = HandleNotification;

            if (attachEventHandler)
            {
                AddEventHandler("handleNotification", new EventHandler<CLRListenerEventArgs<CLREventData<Notification>>>(EventHandlerHandleNotification));
            }
        }

        void EventHandlerHandleNotification(object sender, CLRListenerEventArgs<CLREventData<Notification>> data)
        {
            OnHandleNotification(data.EventData.TypedEventData, data.EventData.To<object>(0));
        }

        public virtual void HandleNotification(Notification notification, object handback)
        {

        }
    }
}
