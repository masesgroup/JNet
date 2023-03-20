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
    #region Role
    public partial class Role
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Role.html#%3Cinit%3E(java.lang.String,java.util.List%3Cjavax.management.ObjectName%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public Role(string arg0, Java.Util.List arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.Relation.Role"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Management.Relation.Role t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Role.html#roleValueToString(java.util.List%3Cjavax.management.ObjectName%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.List"/></param>
        /// <returns><see cref="string"/></returns>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public static string RoleValueToString(Java.Util.List arg0)
        {
            return SExecute<string>("roleValueToString", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Role.html#getRoleName()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Role.html#setRoleName(java.lang.String)"/>
        /// </summary>
        public string RoleName
        {
            get { return IExecute<string>("getRoleName"); } set { IExecute("setRoleName", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Role.html#getRoleValue()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/Role.html#setRoleValue(java.util.List%3Cjavax.management.ObjectName%3E)"/>
        /// </summary>
        public Java.Util.List RoleValue
        {
            get { return IExecute<Java.Util.List>("getRoleValue"); } set { IExecute("setRoleValue", value); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}