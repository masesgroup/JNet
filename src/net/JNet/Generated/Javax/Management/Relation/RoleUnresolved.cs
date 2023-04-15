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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RoleUnresolved
    public partial class RoleUnresolved
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#%3Cinit%3E(java.lang.String,java.util.List,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RoleUnresolved(string arg0, Java.Util.List arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.RoleUnresolved"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Management.Relation.RoleUnresolved t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#getProblemType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#setProblemType(int)"/>
        /// </summary>
        public int ProblemType
        {
            get { return IExecute<int>("getProblemType"); } set { IExecute("setProblemType", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#getRoleName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#setRoleName(java.lang.String)"/>
        /// </summary>
        public string RoleName
        {
            get { return IExecute<string>("getRoleName"); } set { IExecute("setRoleName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#getRoleValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleUnresolved.html#setRoleValue(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Javax.Management.ObjectName> RoleValue
        {
            get { return IExecute<Java.Util.List<Javax.Management.ObjectName>>("getRoleValue"); } set { IExecute("setRoleValue", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}