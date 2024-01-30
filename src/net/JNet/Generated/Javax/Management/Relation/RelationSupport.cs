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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RelationSupport
    public partial class RelationSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#%3Cinit%3E(java.lang.String,javax.management.ObjectName,java.lang.String,javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RelationSupport(string arg0, Javax.Management.ObjectName arg1, string arg2, Javax.Management.Relation.RoleList arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#%3Cinit%3E(java.lang.String,javax.management.ObjectName,javax.management.MBeanServer,java.lang.String,javax.management.relation.RoleList)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Javax.Management.MBeanServer"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="Javax.Management.Relation.RoleList"/></param>
        /// <exception cref="Javax.Management.Relation.InvalidRoleValueException"/>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RelationSupport(string arg0, Javax.Management.ObjectName arg1, Javax.Management.MBeanServer arg2, string arg3, Javax.Management.Relation.RoleList arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.RelationSupport"/> to <see cref="Javax.Management.Relation.RelationSupportMBean"/>
        /// </summary>
        public static implicit operator Javax.Management.Relation.RelationSupportMBean(Javax.Management.Relation.RelationSupport t) => t.Cast<Javax.Management.Relation.RelationSupportMBean>();
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.RelationSupport"/> to <see cref="Javax.Management.MBeanRegistration"/>
        /// </summary>
        public static implicit operator Javax.Management.MBeanRegistration(Javax.Management.Relation.RelationSupport t) => t.Cast<Javax.Management.MBeanRegistration>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getAllRoles()"/> 
        /// </summary>
        public Javax.Management.Relation.RoleResult AllRoles
        {
            get { return IExecute<Javax.Management.Relation.RoleResult>("getAllRoles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getReferencedMBeans()"/> 
        /// </summary>
        public Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<string>> ReferencedMBeans
        {
            get { return IExecute<Java.Util.Map<Javax.Management.ObjectName, Java.Util.List<string>>>("getReferencedMBeans"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRelationId()"/> 
        /// </summary>
        public string RelationId
        {
            get { return IExecute<string>("getRelationId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRelationServiceName()"/> 
        /// </summary>
        public Javax.Management.ObjectName RelationServiceName
        {
            get { return IExecute<Javax.Management.ObjectName>("getRelationServiceName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRelationTypeName()"/> 
        /// </summary>
        public string RelationTypeName
        {
            get { return IExecute<string>("getRelationTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#isInRelationService()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.Boolean"/></returns>
        public Java.Lang.Boolean IsInRelationService()
        {
            return IExecute<Java.Lang.Boolean>("isInRelationService");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRoleCardinality(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Integer"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        public Java.Lang.Integer GetRoleCardinality(string arg0)
        {
            return IExecute<Java.Lang.Integer>("getRoleCardinality", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRole(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.List"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleNotFoundException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public Java.Util.List<Javax.Management.ObjectName> GetRole(string arg0)
        {
            return IExecute<Java.Util.List<Javax.Management.ObjectName>>("getRole", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#preRegister(javax.management.MBeanServer,javax.management.ObjectName)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#retrieveAllRoles()"/>
        /// </summary>

        /// <returns><see cref="Javax.Management.Relation.RoleList"/></returns>
        public Javax.Management.Relation.RoleList RetrieveAllRoles()
        {
            return IExecute<Javax.Management.Relation.RoleList>("retrieveAllRoles");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#getRoles(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleResult"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RelationServiceNotRegisteredException"/>
        public Javax.Management.Relation.RoleResult GetRoles(string[] arg0)
        {
            return IExecute<Javax.Management.Relation.RoleResult>("getRoles", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#setRoles(javax.management.relation.RoleList)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#handleMBeanUnregistration(javax.management.ObjectName,java.lang.String)"/>
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#postDeregister()"/>
        /// </summary>
        public void PostDeregister()
        {
            IExecute("postDeregister");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#postRegister(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        public void PostRegister(Java.Lang.Boolean arg0)
        {
            IExecute("postRegister", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#preDeregister()"/>
        /// </summary>

        /// <exception cref="Java.Lang.Exception"/>
        public void PreDeregister()
        {
            IExecute("preDeregister");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#setRelationServiceManagementFlag(java.lang.Boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Boolean"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void SetRelationServiceManagementFlag(Java.Lang.Boolean arg0)
        {
            IExecute("setRelationServiceManagementFlag", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationSupport.html#setRole(javax.management.relation.Role)"/>
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