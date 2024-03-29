/*
*  Copyright 2024 MASES s.r.l.
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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RelationService
    public partial class RelationService
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public RelationService(bool arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.RelationService"/> to <see cref="Javax.Management.Relation.RelationServiceMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Relation.RelationServiceMBean(Javax.Management.Relation.RelationService t) => t.Cast<Javax.Management.Relation.RelationServiceMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.RelationService"/> to <see cref="Javax.Management.MBeanRegistration"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Relation.RelationService t) => t.Cast<Javax.Management.MBeanRegistration>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.RelationService"/> to <see cref="Javax.Management.NotificationListener"/>
        /// </summary>
        public static implicit operator Javax.Management.NotificationListener(Javax.Management.Relation.RelationService t) => t.Cast<Javax.Management.NotificationListener>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getAllRelationIds()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> AllRelationIds
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getAllRelationIds", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getAllRelationTypeNames()"/> 
        /// </summary>
        public Java.Util.List<Java.Lang.String> AllRelationTypeNames
        {
            get { return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("getAllRelationTypeNames", "()Ljava/util/List;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getPurgeFlag()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#setPurgeFlag(boolean)"/>
        /// </summary>
        public bool PurgeFlag
        {
            get { return IExecuteWithSignature<bool>("getPurgeFlag", "()Z"); } set { IExecuteWithSignature("setPurgeFlag", "(Z)V", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#hasRelation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.Boolean HasRelation(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.Boolean>("hasRelation", "(Ljava/lang/String;)Ljava/lang/Boolean;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#checkRoleReading(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public Java.Lang.Integer CheckRoleReading(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.Integer>("checkRoleReading", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#checkRoleWriting(javax.management.relation.Role,java.lang.String,java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.Role"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Boolean"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public Java.Lang.Integer CheckRoleWriting(Javax.Management.Relation.Role arg0, Java.Lang.String arg1, Java.Lang.Boolean arg2)
        {
            return IExecute<Java.Lang.Integer>("checkRoleWriting", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getRoleCardinality(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        public Java.Lang.Integer GetRoleCardinality(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Lang.Integer>("getRoleCardinality", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getRelationTypeName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Java.Lang.String GetRelationTypeName(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("getRelationTypeName", "(Ljava/lang/String;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#isRelation(javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Lang.String IsRelation(Javax.Management.ObjectName arg0)
        {
            return IExecuteWithSignature<Java.Lang.String>("isRelation", "(Ljavax/management/ObjectName;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#findRelationsOfType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public Java.Util.List<Java.Lang.String> FindRelationsOfType(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Java.Lang.String>>("findRelationsOfType", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getRole(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        public Java.Util.List<Javax.Management.ObjectName> GetRole(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Java.Util.List<Javax.Management.ObjectName>>("getRole", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getRoleInfos(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public Java.Util.List<Javax.Management.Relation.RoleInfo> GetRoleInfos(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.List<Javax.Management.Relation.RoleInfo>>("getRoleInfos", "(Ljava/lang/String;)Ljava/util/List;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#findReferencingRelations(javax.management.ObjectName,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>> FindReferencingRelations(Javax.Management.ObjectName arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Java.Util.Map<Java.Lang.String, Java.Util.List<Java.Lang.String>>>("findReferencingRelations", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#findAssociatedMBeans(javax.management.ObjectName,java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>> FindAssociatedMBeans(Javax.Management.ObjectName arg0, Java.Lang.String arg1, Java.Lang.String arg2)
        {
            return IExecute<Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>>>("findAssociatedMBeans", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getReferencedMBeans(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Map"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>> GetReferencedMBeans(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<Java.Lang.String>>>("getReferencedMBeans", "(Ljava/lang/String;)Ljava/util/Map;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#isRelationMBean(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Javax.Management.ObjectName IsRelationMBean(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.ObjectName>("isRelationMBean", "(Ljava/lang/String;)Ljavax/management/ObjectName;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <returns><see cref="Javax.Management.ObjectName"/></returns>
        /// <exception cref="Java.Lang.Exception"/>
        public Javax.Management.ObjectName PreRegister(Javax.Management.MBeanServer arg0, Javax.Management.ObjectName arg1)
        {
            return IExecute<Javax.Management.ObjectName>("preRegister", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getRoleInfo(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleInfo"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleInfoNotFoundException"/>
        public Javax.Management.Relation.RoleInfo GetRoleInfo(Java.Lang.String arg0, Java.Lang.String arg1)
        {
            return IExecute<Javax.Management.Relation.RoleInfo>("getRoleInfo", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getAllRoles(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public Javax.Management.Relation.RoleResult GetAllRoles(Java.Lang.String arg0)
        {
            return IExecuteWithSignature<Javax.Management.Relation.RoleResult>("getAllRoles", "(Ljava/lang/String;)Ljavax/management/relation/RoleResult;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#getRoles(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Javax.Management.Relation.RoleResult GetRoles(Java.Lang.String arg0, Java.Lang.String[] arg1)
        {
            return IExecute<Javax.Management.Relation.RoleResult>("getRoles", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#setRoles(java.lang.String,javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Javax.Management.Relation.RoleResult SetRoles(Java.Lang.String arg0, Javax.Management.Relation.RoleList arg1)
        {
            return IExecute<Javax.Management.Relation.RoleResult>("setRoles", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#addRelation(javax.management.ObjectName)"/>
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
            IExecuteWithSignature("addRelation", "(Ljavax/management/ObjectName;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#addRelationType(javax.management.relation.RelationType)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RelationType"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationTypeException"/>
        public void AddRelationType(Javax.Management.Relation.RelationType arg0)
        {
            IExecuteWithSignature("addRelationType", "(Ljavax/management/relation/RelationType;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#createRelation(java.lang.String,java.lang.String,javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationIdException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        public void CreateRelation(Java.Lang.String arg0, Java.Lang.String arg1, Javax.Management.Relation.RoleList arg2)
        {
            IExecute("createRelation", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#createRelationType(java.lang.String,javax.management.relation.RoleInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleInfo"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationTypeException"/>
        public void CreateRelationType(Java.Lang.String arg0, Javax.Management.Relation.RoleInfo[] arg1)
        {
            IExecute("createRelationType", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#handleNotification(javax.management.Notification,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        public void HandleNotification(Javax.Management.Notification arg0, object arg1)
        {
            IExecute("handleNotification", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#isActive()"/>
        /// </summary>

        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public void IsActive()
        {
            IExecuteWithSignature("isActive", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecuteWithSignature("postDeregister", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        public void PostRegister(Java.Lang.Boolean arg0)
        {
            IExecuteWithSignature("postRegister", "(Ljava/lang/Boolean;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#preDeregister()"/>
        /// </summary>

        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecuteWithSignature("preDeregister", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#purgeRelations()"/>
        /// </summary>

        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public void PurgeRelations()
        {
            IExecuteWithSignature("purgeRelations", "()V");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#removeRelation(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void RemoveRelation(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeRelation", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#removeRelationType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        public void RemoveRelationType(Java.Lang.String arg0)
        {
            IExecuteWithSignature("removeRelationType", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#sendRelationCreationNotification(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void SendRelationCreationNotification(Java.Lang.String arg0)
        {
            IExecuteWithSignature("sendRelationCreationNotification", "(Ljava/lang/String;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#sendRelationRemovalNotification(java.lang.String,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void SendRelationRemovalNotification(Java.Lang.String arg0, Java.Util.List<Javax.Management.ObjectName> arg1)
        {
            IExecute("sendRelationRemovalNotification", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#sendRoleUpdateNotification(java.lang.String,javax.management.relation.Role,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.Role"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void SendRoleUpdateNotification(Java.Lang.String arg0, Javax.Management.Relation.Role arg1, Java.Util.List<Javax.Management.ObjectName> arg2)
        {
            IExecute("sendRoleUpdateNotification", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#setRole(java.lang.String,javax.management.relation.Role)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.Role"/></param>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        public void SetRole(Java.Lang.String arg0, Javax.Management.Relation.Role arg1)
        {
            IExecute("setRole", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationService.html#updateRoleMap(java.lang.String,javax.management.relation.Role,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.Role"/></param>
        /// <param name="arg2"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void UpdateRoleMap(Java.Lang.String arg0, Javax.Management.Relation.Role arg1, Java.Util.List<Javax.Management.ObjectName> arg2)
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