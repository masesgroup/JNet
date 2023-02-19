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

namespace Javax.Management
{
    public class NotificationFilterSupport : JVMBridgeBase<NotificationFilterSupport>
    {
        public override string ClassName => "javax.management.NotificationFilterSupport";

        public NotificationFilterSupport() { }

        protected NotificationFilterSupport(params object[] args) : base(args) { }
        /// <summary>
        /// Disables all notification types.
        /// </summary>
        public void DisableAllTypes() => IExecute("disableAllTypes");
        /// <summary>
        /// Removes the given prefix from the prefix list.
        /// </summary>
        public void DisableType(string name) => IExecute("disableType", name);
        /// <summary>
        /// Enables all the notifications the type of which starts with the specified prefix to be sent to the listener.
        /// </summary>
        public void EnableType(string name) => IExecute("enableType", name);
        /// <summary>
        /// Gets all the enabled notification types for this filter.
        /// </summary>
        public Java.Util.Vector<string> EnabledTypes => IExecute<Java.Util.Vector<string>>("getEnabledTypes");
    }
}
