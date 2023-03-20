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
    #region Relation
    public partial class Relation
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getAllRoles()"/> 
        /// </summary>
        public Javax.Management.Relation.RoleResult AllRoles
        {
            get { return IExecute<Javax.Management.Relation.RoleResult>("getAllRoles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getReferencedMBeans()"/> 
        /// </summary>
        public Java.Util.Map ReferencedMBeans
        {
            get { return IExecute<Java.Util.Map>("getReferencedMBeans"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationId()"/> 
        /// </summary>
        public string RelationId
        {
            get { return IExecute<string>("getRelationId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationServiceName()"/> 
        /// </summary>
        public Javax.Management.ObjectName RelationServiceName
        {
            get { return IExecute<Javax.Management.ObjectName>("getRelationServiceName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRelationTypeName()"/> 
        /// </summary>
        public string RelationTypeName
        {
            get { return IExecute<string>("getRelationTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRoleCardinality(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        public int? GetRoleCardinality(string arg0)
        {
            return IExecute<int?>("getRoleCardinality", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRole(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public Java.Util.List GetRole(string arg0)
        {
            return IExecute<Java.Util.List>("getRole", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#retrieveAllRoles()"/>
        /// </summary>
        
        /// <returns><see cref="Javax.Management.Relation.RoleList"/></returns>
        public Javax.Management.Relation.RoleList RetrieveAllRoles()
        {
            return IExecute<Javax.Management.Relation.RoleList>("retrieveAllRoles");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#getRoles(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public Javax.Management.Relation.RoleResult GetRoles(string[] arg0)
        {
            return IExecute<Javax.Management.Relation.RoleResult>("getRoles", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#setRoles(javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public Javax.Management.Relation.RoleResult SetRoles(Javax.Management.Relation.RoleList arg0)
        {
            return IExecute<Javax.Management.Relation.RoleResult>("setRoles", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#handleMBeanUnregistration(javax.management.ObjectName,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void HandleMBeanUnregistration(Javax.Management.ObjectName arg0, string arg1)
        {
            IExecute("handleMBeanUnregistration", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Relation.html#setRole(javax.management.relation.Role)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Relation.Role"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationTypeNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        /// <exception cref="Javax.Management.Relation.RelationNotFoundException"/>
        public void SetRole(Javax.Management.Relation.Role arg0)
        {
            IExecute("setRole", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}