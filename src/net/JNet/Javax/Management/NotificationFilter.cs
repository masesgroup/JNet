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
    public interface INotificationFilter : IJVMBridgeBase
    {
        /// <summary>
        /// Invoked before sending the specified notification to the listener.
        /// </summary>
        bool IsNotificationEnabled(Notification notification);
    }

    public class NotificationFilter : JVMBridgeListener, INotificationFilter
    {
        public override bool IsInterface => true;

        public override string ClassName => "org.mases.jnet.management.JNetNotificationFilter";

        readonly Func<Notification, bool> isNotificationEnabledFunction = null;
        /// <summary>
        /// The <see cref="Func{Notification, bool}"/> to be executed on IsNotificationEnabled
        /// </summary>
        public virtual Func<Notification, bool> OnIsNotificationEnabled { get { return isNotificationEnabledFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="NotificationFilter"/>
        /// </summary>
        /// <param name="isNotificationEnabled">The <see cref="Function{Notification, bool}"/> to be executed on IsNotificationEnabled</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public NotificationFilter(Func<Notification, bool> isNotificationEnabled = null, bool attachEventHandler = true)
        {
            if (isNotificationEnabled != null) isNotificationEnabledFunction = isNotificationEnabled;
            else isNotificationEnabledFunction = IsNotificationEnabled;

            if (attachEventHandler)
            {
                AddEventHandler("isNotificationEnabled", new EventHandler<CLRListenerEventArgs<CLREventData<Notification>>>(EventHandlerIsNotificationEnabled));
            }
        }

        void EventHandlerIsNotificationEnabled(object sender, CLRListenerEventArgs<CLREventData<Notification>> data)
        {
            bool result = OnIsNotificationEnabled(data.EventData.TypedEventData);
            data.SetReturnValue(result);
        }

        public virtual bool IsNotificationEnabled(Notification notification)
        {
            return false;
        }
    }
}
