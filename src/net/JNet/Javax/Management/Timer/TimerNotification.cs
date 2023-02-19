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

namespace Javax.Management.Timer
{
    public class TimerNotification : Notification
    {
        public override string ClassName => "javax.management.timer.TimerNotification";

        public TimerNotification() { }

        protected TimerNotification(params object[] args) : base(args) { }
        /// <summary>
        /// Creates a timer notification object.
        /// </summary>
        public TimerNotification(string type, object source, long sequenceNumber, long timeStamp, string msg, int id)
            : base(type, source, sequenceNumber, timeStamp, msg, id) { }
        /// <summary>
        /// Gets the identifier of this timer notification.
        /// </summary>
        public int NotificationID => IExecute<int>("getNotificationID");
    }
}
