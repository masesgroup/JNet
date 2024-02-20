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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RelationTypeSupport
    public partial class RelationTypeSupport
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationTypeSupport.html#%3Cinit%3E(java.lang.String,javax.management.relation.RoleInfo[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Javax.Management.Relation.RoleInfo"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.InvalidRelationTypeException"/>
        public RelationTypeSupport(Java.Lang.String arg0, Javax.Management.Relation.RoleInfo[] arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationTypeSupport.html#getRelationTypeName()"/> 
        /// </summary>
        public Java.Lang.String RelationTypeName
        {
            get { return IExecute<Java.Lang.String>("getRelationTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationTypeSupport.html#getRoleInfos()"/> 
        /// </summary>
        public Java.Util.List<Javax.Management.Relation.RoleInfo> RoleInfos
        {
            get { return IExecute<Java.Util.List<Javax.Management.Relation.RoleInfo>>("getRoleInfos"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationTypeSupport.html#getRoleInfo(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Javax.Management.Relation.RoleInfo"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        /// <exception cref="Javax.Management.Relation.RoleInfoNotFoundException"/>
        public Javax.Management.Relation.RoleInfo GetRoleInfo(Java.Lang.String arg0)
        {
            return IExecute<Javax.Management.Relation.RoleInfo>("getRoleInfo", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}