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

/*
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RelationServiceMBean
    public partial class RelationServiceMBean
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getAllRelationIds()"/> 
        /// </summary>
        public Java.Util.List AllRelationIds
        {
            get { return IExecute<Java.Util.List>("getAllRelationIds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getAllRelationTypeNames()"/> 
        /// </summary>
        public Java.Util.List AllRelationTypeNames
        {
            get { return IExecute<Java.Util.List>("getAllRelationTypeNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getPurgeFlag()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#setPurgeFlag(boolean)"/>
        /// </summary>
        public bool PurgeFlag
        {
            get { return IExecute<bool>("getPurgeFlag"); } set { IExecute("setPurgeFlag", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#hasRelation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="bool?"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public bool? HasRelation(string arg0)
        {
            return IExecute<bool?>("hasRelation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#checkRoleReading(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see langword="int?"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public int? CheckRoleReading(string arg0, string arg1)
        {
            return IExecute<int?>("checkRoleReading", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#checkRoleWriting(javax.management.relation.Role,java.lang.String,java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.Role"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see langword="int?"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public int? CheckRoleWriting(Javax.Management.Relation.Role arg0, string arg1, bool? arg2)
        {
            return IExecute<int?>("checkRoleWriting", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getRoleCardinality(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see langword="int?"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        public int? GetRoleCardinality(string arg0, string arg1)
        {
            return IExecute<int?>("getRoleCardinality", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getRelationTypeName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public string GetRelationTypeName(string arg0)
        {
            return IExecute<string>("getRelationTypeName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#isRelation(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see langword="string"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public string IsRelation(Javax.Management.ObjectName arg0)
        {
            return IExecute<string>("isRelation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#findRelationsOfType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public Java.Util.List FindRelationsOfType(string arg0)
        {
            return IExecute<Java.Util.List>("findRelationsOfType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getRole(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        public Java.Util.List GetRole(string arg0, string arg1)
        {
            return IExecute<Java.Util.List>("getRole", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getRoleInfos(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public Java.Util.List GetRoleInfos(string arg0)
        {
            return IExecute<Java.Util.List>("getRoleInfos", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#findReferencingRelations(javax.management.ObjectName,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Util.Map FindReferencingRelations(Javax.Management.ObjectName arg0, string arg1, string arg2)
        {
            return IExecute<Java.Util.Map>("findReferencingRelations", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#findAssociatedMBeans(javax.management.ObjectName,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Util.Map FindAssociatedMBeans(Javax.Management.ObjectName arg0, string arg1, string arg2)
        {
            return IExecute<Java.Util.Map>("findAssociatedMBeans", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getReferencedMBeans(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Java.Util.Map GetReferencedMBeans(string arg0)
        {
            return IExecute<Java.Util.Map>("getReferencedMBeans", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#isRelationMBean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Javax.Management.ObjectName IsRelationMBean(string arg0)
        {
            return IExecute<Javax.Management.ObjectName>("isRelationMBean", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getRoleInfo(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleInfo"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleInfoNotFoundException"/>
        public Javax.Management.Relation.RoleInfo GetRoleInfo(string arg0, string arg1)
        {
            return IExecute<Javax.Management.Relation.RoleInfo>("getRoleInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getAllRoles(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public Javax.Management.Relation.RoleResult GetAllRoles(string arg0)
        {
            return IExecute<Javax.Management.Relation.RoleResult>("getAllRoles", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#getRoles(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Javax.Management.Relation.RoleResult GetRoles(string arg0, string[] arg1)
        {
            return IExecute<Javax.Management.Relation.RoleResult>("getRoles", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#setRoles(java.lang.String,javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Javax.Management.Relation.RoleResult SetRoles(string arg0, Javax.Management.Relation.RoleList arg1)
        {
            return IExecute<Javax.Management.Relation.RoleResult>("setRoles", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#addRelation(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.NoSuchMethodException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationIdException"/>
        /// <exception cref="Javax.Management.InstanceNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationServiceException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        public void AddRelation(Javax.Management.ObjectName arg0)
        {
            IExecute("addRelation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#addRelationType(javax.management.relation.RelationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RelationType"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationTypeException"/>
        public void AddRelationType(Javax.Management.Relation.RelationType arg0)
        {
            IExecute("addRelationType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#createRelation(java.lang.String,java.lang.String,javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationIdException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        public void CreateRelation(string arg0, string arg1, Javax.Management.Relation.RoleList arg2)
        {
            IExecute("createRelation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#createRelationType(java.lang.String,javax.management.relation.RoleInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleInfo"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationTypeException"/>
        public void CreateRelationType(string arg0, Javax.Management.Relation.RoleInfo[] arg1)
        {
            IExecute("createRelationType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#isActive()"/>
        /// </summary>
        
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public void IsActive()
        {
            IExecute("isActive");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#purgeRelations()"/>
        /// </summary>
        
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public void PurgeRelations()
        {
            IExecute("purgeRelations");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#removeRelation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void RemoveRelation(string arg0)
        {
            IExecute("removeRelation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#removeRelationType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public void RemoveRelationType(string arg0)
        {
            IExecute("removeRelationType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#sendRelationCreationNotification(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void SendRelationCreationNotification(string arg0)
        {
            IExecute("sendRelationCreationNotification", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#sendRelationRemovalNotification(java.lang.String,java.util.List%3Cjavax.management.ObjectName%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void SendRelationRemovalNotification(string arg0, Java.Util.List arg1)
        {
            IExecute("sendRelationRemovalNotification", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#sendRoleUpdateNotification(java.lang.String,javax.management.relation.Role,java.util.List%3Cjavax.management.ObjectName%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.Role"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void SendRoleUpdateNotification(string arg0, Javax.Management.Relation.Role arg1, Java.Util.List arg2)
        {
            IExecute("sendRoleUpdateNotification", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#setRole(java.lang.String,javax.management.relation.Role)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.Role"/></param>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public void SetRole(string arg0, Javax.Management.Relation.Role arg1)
        {
            IExecute("setRole", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationServiceMBean.html#updateRoleMap(java.lang.String,javax.management.relation.Role,java.util.List%3Cjavax.management.ObjectName%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.Role"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void UpdateRoleMap(string arg0, Javax.Management.Relation.Role arg1, Java.Util.List arg2)
        {
            IExecute("updateRoleMap", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}