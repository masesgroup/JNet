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

namespace JavaX.Management
{
    public class AttributeChangeNotificationFilter : JVMBridgeBase<AttributeChangeNotificationFilter>
    {
        public override string ClassName => "javax.management.AttributeChangeNotificationFilter";

        public AttributeChangeNotificationFilter() { }

        protected AttributeChangeNotificationFilter(params object[] args) : base(args) { }
        /// <summary>
        /// Disables all the attribute names.
        /// </summary>
        public void DisableAllAttributes() => IExecute("disableAllAttributes");
        /// <summary>
        /// Disables all the attribute change notifications the attribute name of which equals the specified attribute name to be sent to the listener.
        /// </summary>
        public void DisableAttribute(string name) => IExecute("disableAttribute", name);
        /// <summary>
        /// Enables all the attribute change notifications the attribute name of which equals the specified name to be sent to the listener.
        /// </summary>
        public void EnableAttribute(string name) => IExecute("enableAttribute", name);
        /// <summary>
        /// Gets all the enabled attribute names for this filter.
        /// </summary>
        public Java.Util.Vector<string> EnabledAttributes => IExecute<Java.Util.Vector<string>>("getEnabledAttributes");
    }
}
