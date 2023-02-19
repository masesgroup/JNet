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

using Java.Util;

namespace Javax.Management
{
    public class Notification : EventObject
    {
        public override string ClassName => "javax.management.Notification";

        public Notification() { }

        protected Notification(params object[] args) : base(args) { }

        /// <summary>
        /// Creates a <see cref="Notification"/> object.
        /// </summary>
        public Notification(string type, object source, long sequenceNumber) : base(type, source, sequenceNumber) { }
        /// <summary>
        /// Creates a <see cref="Notification"/> object.
        /// </summary>
        public Notification(string type, object source, long sequenceNumber, long timeStamp) : base(type, source, sequenceNumber, timeStamp) { }
        /// <summary>
        /// Creates a <see cref="Notification"/> object.
        /// </summary>
        public Notification(string type, object source, long sequenceNumber, long timeStamp, string message) : base(type, source, sequenceNumber, timeStamp, message) { }
        /// <summary>
        /// Creates a <see cref="Notification"/> object.
        /// </summary>
        public Notification(string type, object source, long sequenceNumber, string message) : base(type, source, sequenceNumber, message) { }
        /// <summary>
        /// Get the notification message.
        /// </summary>
        public string Message => IExecute<string>("getMessage");
        /// <summary>
        /// The notification sequence number.
        /// </summary>
        public long SequenceNumber
        {
            get { return IExecute<long>("getSequenceNumber"); }
            set { IExecute("setSequenceNumber", value); }
        }
        /// <summary>
        /// The notification timestamp.
        /// </summary>
        public long TimeStamp
        {
            get { return IExecute<long>("getTimeStamp"); }
            set { IExecute("setTimeStamp", value); }
        }
        /// <summary>
        /// Get the notification type.
        /// </summary>
        public string Type => IExecute<string>("getType");
        /// <summary>
        /// The user data.
        /// </summary>
        /// <returns></returns>
        public object UserData
        {
            get { return IExecute<long>("getUserData"); }
            set { IExecute("setUserData", value); }
        }
        /// <summary>
        /// The source.
        /// </summary>
        public new object Source
        {
            get { return IExecute("getSource"); }
            set { IExecute("setSource", value); }
        }
    }
}
