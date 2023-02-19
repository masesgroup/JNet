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
    public class RelationNotification : Notification
    {
        public override string ClassName => "javax.management.relation.RelationNotification";

        public RelationNotification() { }

        protected RelationNotification(params object[] args) : base(args) { }
        /// <summary>
        /// Creates a notification for a role update in a relation.
        /// </summary>
        public RelationNotification(string notifType, object sourceObj, long sequence, long timeStamp, string message, string id, string typeName, ObjectName objectName, string name, List<ObjectName> newValue, List<ObjectName> oldValue)
            : base(notifType, sourceObj, sequence, timeStamp, message, id, typeName, objectName, name, newValue, oldValue) { }
        /// <summary>
        /// Creates a notification for either a relation creation(RelationSupport object created internally in the Relation Service, or an MBean added as a relation) or for a relation removal from the Relation Service.
        /// </summary>
        public RelationNotification(string notifType, object sourceObj, long sequence, long timeStamp, string message, string id, string typeName, ObjectName objectName, List<ObjectName> unregMBeanList)
            : base(notifType, sourceObj, sequence, timeStamp, message, id, typeName, objectName, unregMBeanList) { }

        /// <summary>
        /// Type for the creation of an internal relation.
        /// </summary>
        public static string RELATION_BASIC_CREATION => Clazz.GetField<string>("RELATION_BASIC_CREATION");
        /// <summary>
        /// Type for the removal from the Relation Service of an internal relation.
        /// </summary>
        public static string RELATION_BASIC_REMOVAL => Clazz.GetField<string>("RELATION_BASIC_REMOVAL");
        /// <summary>
        /// Type for an update of an internal relation.
        /// </summary>
        public static string RELATION_BASIC_UPDATE => Clazz.GetField<string>("RELATION_BASIC_UPDATE");
        /// <summary>
        /// Type for the relation MBean added into the Relation Service.
        /// </summary>
        public static string RELATION_MBEAN_CREATION => Clazz.GetField<string>("RELATION_MBEAN_CREATION");
        /// <summary>
        /// Type for the removal from the Relation Service of a relation MBean.
        /// </summary>
        public static string RELATION_MBEAN_REMOVAL => Clazz.GetField<string>("RELATION_MBEAN_REMOVAL");
        /// <summary>
        /// Type for the update of a relation MBean.
        /// </summary>
        public static string RELATION_MBEAN_UPDATE => Clazz.GetField<string>("RELATION_MBEAN_UPDATE");
        /// <summary>
        /// Returns the list of ObjectNames of MBeans expected to be unregistered due to a relation removal(only for relation removal).
        /// </summary>
        public List<ObjectName> MBeansToUnregister => IExecute<List<ObjectName>>("getMBeansToUnregister");
        /// <summary>
        /// Returns new value of updated role(only for role update).
        /// </summary>
        public List<ObjectName> NewRoleValue => IExecute<List<ObjectName>>("getNewRoleValue");
        /// <summary>
        /// Returns the ObjectName of the created/removed/updated relation.
        /// </summary>
        public ObjectName ObjectName => IExecute<ObjectName>("getObjectName");
        /// <summary>
        /// Returns old value of updated role (only for role update).
        /// </summary>
        public List<ObjectName> OldRoleValue => IExecute<List<ObjectName>>("getOldRoleValue");
        /// <summary>
        /// Returns the relation identifier of created/removed/updated relation.
        /// </summary>
        public string RelationId => IExecute<string>("getRelationId");
        /// <summary>
        /// Returns the relation type name of created/removed/updated relation.
        /// </summary>
        public string RelationTypeName => IExecute<string>("getRelationTypeName");
        /// <summary>
        /// Returns name of updated role of updated relation (only for role update).
        /// </summary>
        public string RoleName => IExecute<string>("getRoleName");
    }
}
