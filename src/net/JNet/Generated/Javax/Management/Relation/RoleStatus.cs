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
    #region RoleStatus
    public partial class RoleStatus
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#LESS_THAN_MIN_ROLE_DEGREE"/>
        /// </summary>
        public static int LESS_THAN_MIN_ROLE_DEGREE => Clazz.GetField<int>("LESS_THAN_MIN_ROLE_DEGREE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#MORE_THAN_MAX_ROLE_DEGREE"/>
        /// </summary>
        public static int MORE_THAN_MAX_ROLE_DEGREE => Clazz.GetField<int>("MORE_THAN_MAX_ROLE_DEGREE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#NO_ROLE_WITH_NAME"/>
        /// </summary>
        public static int NO_ROLE_WITH_NAME => Clazz.GetField<int>("NO_ROLE_WITH_NAME");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#REF_MBEAN_NOT_REGISTERED"/>
        /// </summary>
        public static int REF_MBEAN_NOT_REGISTERED => Clazz.GetField<int>("REF_MBEAN_NOT_REGISTERED");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#REF_MBEAN_OF_INCORRECT_CLASS"/>
        /// </summary>
        public static int REF_MBEAN_OF_INCORRECT_CLASS => Clazz.GetField<int>("REF_MBEAN_OF_INCORRECT_CLASS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#ROLE_NOT_READABLE"/>
        /// </summary>
        public static int ROLE_NOT_READABLE => Clazz.GetField<int>("ROLE_NOT_READABLE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#ROLE_NOT_WRITABLE"/>
        /// </summary>
        public static int ROLE_NOT_WRITABLE => Clazz.GetField<int>("ROLE_NOT_WRITABLE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#isRoleStatus(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public static bool IsRoleStatus(int arg0)
        {
            return SExecute<bool>("isRoleStatus", arg0);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}