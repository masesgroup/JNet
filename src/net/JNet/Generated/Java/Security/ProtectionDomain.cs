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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Security
{
    #region ProtectionDomain
    public partial class ProtectionDomain
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/ProtectionDomain.html#%3Cinit%3E(java.security.CodeSource,java.security.PermissionCollection,java.lang.ClassLoader,java.security.Principal[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.CodeSource"/></param>
        /// <param name="arg1"><see cref="Java.Security.PermissionCollection"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <param name="arg3"><see cref="Java.Security.Principal"/></param>
        public ProtectionDomain(Java.Security.CodeSource arg0, Java.Security.PermissionCollection arg1, Java.Lang.ClassLoader arg2, Java.Security.Principal[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/ProtectionDomain.html#%3Cinit%3E(java.security.CodeSource,java.security.PermissionCollection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.CodeSource"/></param>
        /// <param name="arg1"><see cref="Java.Security.PermissionCollection"/></param>
        public ProtectionDomain(Java.Security.CodeSource arg0, Java.Security.PermissionCollection arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/ProtectionDomain.html#getClassLoader()"/> 
        /// </summary>
        public Java.Lang.ClassLoader ClassLoader
        {
            get { return IExecute<Java.Lang.ClassLoader>("getClassLoader"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/ProtectionDomain.html#getCodeSource()"/> 
        /// </summary>
        public Java.Security.CodeSource CodeSource
        {
            get { return IExecute<Java.Security.CodeSource>("getCodeSource"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/ProtectionDomain.html#getPermissions()"/> 
        /// </summary>
        public Java.Security.PermissionCollection Permissions
        {
            get { return IExecute<Java.Security.PermissionCollection>("getPermissions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/ProtectionDomain.html#getPrincipals()"/> 
        /// </summary>
        public Java.Security.Principal[] Principals
        {
            get { return IExecuteArray<Java.Security.Principal>("getPrincipals"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/ProtectionDomain.html#implies(java.security.Permission)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Security.Permission"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Implies(Java.Security.Permission arg0)
        {
            return IExecute<bool>("implies", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/security/ProtectionDomain.html#staticPermissionsOnly()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool StaticPermissionsOnly()
        {
            return IExecute<bool>("staticPermissionsOnly");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}