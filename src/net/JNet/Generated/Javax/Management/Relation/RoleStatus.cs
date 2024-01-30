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
        public static int LESS_THAN_MIN_ROLE_DEGREE { get { if (!_LESS_THAN_MIN_ROLE_DEGREEReady) { _LESS_THAN_MIN_ROLE_DEGREEContent = SGetField<int>(LocalBridgeClazz, "LESS_THAN_MIN_ROLE_DEGREE"); _LESS_THAN_MIN_ROLE_DEGREEReady = true; } return _LESS_THAN_MIN_ROLE_DEGREEContent; } }
        private static int _LESS_THAN_MIN_ROLE_DEGREEContent = default;
        private static bool _LESS_THAN_MIN_ROLE_DEGREEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#MORE_THAN_MAX_ROLE_DEGREE"/>
        /// </summary>
        public static int MORE_THAN_MAX_ROLE_DEGREE { get { if (!_MORE_THAN_MAX_ROLE_DEGREEReady) { _MORE_THAN_MAX_ROLE_DEGREEContent = SGetField<int>(LocalBridgeClazz, "MORE_THAN_MAX_ROLE_DEGREE"); _MORE_THAN_MAX_ROLE_DEGREEReady = true; } return _MORE_THAN_MAX_ROLE_DEGREEContent; } }
        private static int _MORE_THAN_MAX_ROLE_DEGREEContent = default;
        private static bool _MORE_THAN_MAX_ROLE_DEGREEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#NO_ROLE_WITH_NAME"/>
        /// </summary>
        public static int NO_ROLE_WITH_NAME { get { if (!_NO_ROLE_WITH_NAMEReady) { _NO_ROLE_WITH_NAMEContent = SGetField<int>(LocalBridgeClazz, "NO_ROLE_WITH_NAME"); _NO_ROLE_WITH_NAMEReady = true; } return _NO_ROLE_WITH_NAMEContent; } }
        private static int _NO_ROLE_WITH_NAMEContent = default;
        private static bool _NO_ROLE_WITH_NAMEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#REF_MBEAN_NOT_REGISTERED"/>
        /// </summary>
        public static int REF_MBEAN_NOT_REGISTERED { get { if (!_REF_MBEAN_NOT_REGISTEREDReady) { _REF_MBEAN_NOT_REGISTEREDContent = SGetField<int>(LocalBridgeClazz, "REF_MBEAN_NOT_REGISTERED"); _REF_MBEAN_NOT_REGISTEREDReady = true; } return _REF_MBEAN_NOT_REGISTEREDContent; } }
        private static int _REF_MBEAN_NOT_REGISTEREDContent = default;
        private static bool _REF_MBEAN_NOT_REGISTEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#REF_MBEAN_OF_INCORRECT_CLASS"/>
        /// </summary>
        public static int REF_MBEAN_OF_INCORRECT_CLASS { get { if (!_REF_MBEAN_OF_INCORRECT_CLASSReady) { _REF_MBEAN_OF_INCORRECT_CLASSContent = SGetField<int>(LocalBridgeClazz, "REF_MBEAN_OF_INCORRECT_CLASS"); _REF_MBEAN_OF_INCORRECT_CLASSReady = true; } return _REF_MBEAN_OF_INCORRECT_CLASSContent; } }
        private static int _REF_MBEAN_OF_INCORRECT_CLASSContent = default;
        private static bool _REF_MBEAN_OF_INCORRECT_CLASSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#ROLE_NOT_READABLE"/>
        /// </summary>
        public static int ROLE_NOT_READABLE { get { if (!_ROLE_NOT_READABLEReady) { _ROLE_NOT_READABLEContent = SGetField<int>(LocalBridgeClazz, "ROLE_NOT_READABLE"); _ROLE_NOT_READABLEReady = true; } return _ROLE_NOT_READABLEContent; } }
        private static int _ROLE_NOT_READABLEContent = default;
        private static bool _ROLE_NOT_READABLEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#ROLE_NOT_WRITABLE"/>
        /// </summary>
        public static int ROLE_NOT_WRITABLE { get { if (!_ROLE_NOT_WRITABLEReady) { _ROLE_NOT_WRITABLEContent = SGetField<int>(LocalBridgeClazz, "ROLE_NOT_WRITABLE"); _ROLE_NOT_WRITABLEReady = true; } return _ROLE_NOT_WRITABLEContent; } }
        private static int _ROLE_NOT_WRITABLEContent = default;
        private static bool _ROLE_NOT_WRITABLEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RoleStatus.html#isRoleStatus(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsRoleStatus(int arg0)
        {
            return SExecute<bool>(LocalBridgeClazz, "isRoleStatus", arg0);
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