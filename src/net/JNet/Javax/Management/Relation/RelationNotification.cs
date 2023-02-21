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

namespace Javax.Management.Relation
{
    public partial class RelationNotification
    {
        // can be extended with methods not reflected or not available in Java;

        /// <summary>
        /// Returns the list of ObjectNames of MBeans expected to be unregistered due to a relation removal(only for relation removal).
        /// </summary>
        public List<ObjectName> MBeansToUnregister => IExecute<List<ObjectName>>("getMBeansToUnregister");
        /// <summary>
        /// Returns new value of updated role(only for role update).
        /// </summary>
        public List<ObjectName> NewRoleValue => IExecute<List<ObjectName>>("getNewRoleValue");
        /// <summary>
        /// Returns old value of updated role (only for role update).
        /// </summary>
        public List<ObjectName> OldRoleValue => IExecute<List<ObjectName>>("getOldRoleValue");
    }
}
