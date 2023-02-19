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

namespace Javax.Management.Monitor
{
    public class MonitorNotification : Notification
    {
        public override string ClassName => "javax.management.monitor.MonitorNotification";

        public MonitorNotification() { }

        protected MonitorNotification(params object[] args) : base(args) { }
        /// <summary>
        /// Notification type denoting that the observed attribute is not contained in the observed object.
        /// </summary>
        public static string OBSERVED_ATTRIBUTE_ERROR => Clazz.GetField<string>("OBSERVED_ATTRIBUTE_ERROR");
        /// <summary>
        /// Notification type denoting that the type of the observed attribute is not correct.
        /// </summary>
        public static string OBSERVED_ATTRIBUTE_TYPE_ERROR => Clazz.GetField<string>("OBSERVED_ATTRIBUTE_TYPE_ERROR");
        /// <summary>
        /// Notification type denoting that the observed object is not registered in the MBean server.
        /// </summary>
        public static string OBSERVED_OBJECT_ERROR => Clazz.GetField<string>("OBSERVED_OBJECT_ERROR");
        /// <summary>
        /// Notification type denoting that a non-predefined error type has occurred when trying to get the value of the observed attribute.
        /// </summary>
        public static string RUNTIME_ERROR => Clazz.GetField<string>("RUNTIME_ERROR");
        /// <summary>
        /// Notification type denoting that the observed attribute has differed from the "string to compare" value.
        /// </summary>
        public static string STRING_TO_COMPARE_VALUE_DIFFERED => Clazz.GetField<string>("STRING_TO_COMPARE_VALUE_DIFFERED");
        /// <summary>
        /// Notification type denoting that the observed attribute has matched the "string to compare" value.
        /// </summary>
        public static string STRING_TO_COMPARE_VALUE_MATCHED => Clazz.GetField<string>("STRING_TO_COMPARE_VALUE_MATCHED");
        /// <summary>
        /// Notification type denoting that the type of the thresholds, offset or modulus is not correct.
        /// </summary>
        public static string THRESHOLD_ERROR => Clazz.GetField<string>("THRESHOLD_ERROR");
        /// <summary>
        /// Notification type denoting that the observed attribute has exceeded the threshold high value.
        /// </summary>
        public static string THRESHOLD_HIGH_VALUE_EXCEEDED => Clazz.GetField<string>("THRESHOLD_HIGH_VALUE_EXCEEDED");
        /// <summary>
        /// Notification type denoting that the observed attribute has exceeded the threshold low value.
        /// </summary>
        public static string THRESHOLD_LOW_VALUE_EXCEEDED => Clazz.GetField<string>("THRESHOLD_LOW_VALUE_EXCEEDED");
        /// <summary>
        /// Notification type denoting that the observed attribute has reached the threshold value.
        /// </summary>
        public static string THRESHOLD_VALUE_EXCEEDED => Clazz.GetField<string>("THRESHOLD_VALUE_EXCEEDED");
        /// <summary>
        /// Gets the derived gauge of this monitor notification.
        /// </summary>
        public object DerivedGauge => IExecute<object>("getDerivedGauge");
        /// <summary>
        /// Gets the observed attribute of this monitor notification.
        /// </summary>
        public string ObservedAttribute => IExecute<string>("getObservedAttribute");
        /// <summary>
        /// Gets the observed object of this monitor notification.
        /// </summary>
        public ObjectName ObservedObject => IExecute<ObjectName>("getObservedObject");
        /// <summary>
        /// Gets the threshold/string (depending on the monitor type) that triggered off this monitor notification.
        /// </summary>
        public object Trigger => IExecute<object>("getTrigger");
    }
}
