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

namespace JavaX.Management
{
    public class AttributeChangeNotification : Notification
    {
        public override string ClassName => "javax.management.AttributeChangeNotification";

        public AttributeChangeNotification() { }

        protected AttributeChangeNotification(params object[] args) : base(args) { }
        /// <summary>
        /// Constructs an attribute change notification object.
        /// </summary>
        public AttributeChangeNotification(object source, long sequenceNumber, long timeStamp, string msg, string attributeName, string attributeType, object oldValue, object newValue)
            : base(source, sequenceNumber, timeStamp, msg, attributeName, attributeType, oldValue, newValue) { }

        /// <summary>
        /// Notification type which indicates that the observed MBean attribute value has changed.
        /// </summary>
        public static string ATTRIBUTE_CHANGE => Clazz.GetField<string>("ATTRIBUTE_CHANGE");
        /// <summary>
        /// Gets the name of the attribute which has changed.
        /// </summary>
        public string AttributeName => IExecute<string>("getAttributeName");
        /// <summary>
        /// Gets the type of the attribute which has changed.
        /// </summary>
        public string AttributeType => IExecute<string>("getAttributeType");
        /// <summary>
        /// Gets the new value of the attribute which has changed.
        /// </summary>
        public object NewValue => IExecute("getNewValue");
        /// <summary>
        /// Gets the old value of the attribute which has changed.
        /// </summary>
        public object OldValue => IExecute("getOldValue");
    }
}
