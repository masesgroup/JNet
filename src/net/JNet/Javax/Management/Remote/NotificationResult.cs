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

namespace Javax.Management.Remote
{
    public class NotificationResult : JVMBridgeBase<NotificationResult>
    {
        public override string ClassName => "javax.management.remote.NotificationResult";

        public NotificationResult() { }
        /// <summary>
        /// Constructs a notification query result.
        /// </summary>
        public NotificationResult(long earliestSequenceNumber, long nextSequenceNumber, TargetedNotification[] targetedNotifications)
            : base(earliestSequenceNumber, nextSequenceNumber, targetedNotifications) { }
        /// <summary>
        /// Returns the sequence number of the earliest notification still in the buffer.
        /// </summary>
        public long EarliestSequenceNumber => IExecute<long>("getEarliestSequenceNumber");
        /// <summary>
        /// Returns the sequence number of the next notification available for querying.
        /// </summary>
        public long NextSequenceNumber => IExecute<long>("getNextSequenceNumber");
        /// <summary>
        /// Returns the notifications resulting from the query, and the listeners they correspond to.
        /// </summary>
        public TargetedNotification[] TargetedNotifications => IExecuteArray<TargetedNotification>("getTargetedNotifications");
    }
}
