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

namespace Java.Nio.File.Attribute
{
    #region AclEntryType
    public partial class AclEntryType
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#ALARM"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryType ALARM { get { if (!_ALARMReady) { _ALARMContent = SGetField<Java.Nio.File.Attribute.AclEntryType>(LocalBridgeClazz, "ALARM"); _ALARMReady = true; } return _ALARMContent; } }
        private static Java.Nio.File.Attribute.AclEntryType _ALARMContent = default;
        private static bool _ALARMReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#ALLOW"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryType ALLOW { get { if (!_ALLOWReady) { _ALLOWContent = SGetField<Java.Nio.File.Attribute.AclEntryType>(LocalBridgeClazz, "ALLOW"); _ALLOWReady = true; } return _ALLOWContent; } }
        private static Java.Nio.File.Attribute.AclEntryType _ALLOWContent = default;
        private static bool _ALLOWReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#AUDIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryType AUDIT { get { if (!_AUDITReady) { _AUDITContent = SGetField<Java.Nio.File.Attribute.AclEntryType>(LocalBridgeClazz, "AUDIT"); _AUDITReady = true; } return _AUDITContent; } }
        private static Java.Nio.File.Attribute.AclEntryType _AUDITContent = default;
        private static bool _AUDITReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#DENY"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryType DENY { get { if (!_DENYReady) { _DENYContent = SGetField<Java.Nio.File.Attribute.AclEntryType>(LocalBridgeClazz, "DENY"); _DENYReady = true; } return _DENYContent; } }
        private static Java.Nio.File.Attribute.AclEntryType _DENYContent = default;
        private static bool _DENYReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryType"/></returns>
        public static Java.Nio.File.Attribute.AclEntryType ValueOf(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.Attribute.AclEntryType>(LocalBridgeClazz, "valueOf", "(Ljava/lang/String;)Ljava/nio/file/attribute/AclEntryType;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryType.html#values()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryType"/></returns>
        public static Java.Nio.File.Attribute.AclEntryType[] Values()
        {
            return SExecuteWithSignatureArray<Java.Nio.File.Attribute.AclEntryType>(LocalBridgeClazz, "values", "()[Ljava/nio/file/attribute/AclEntryType;");
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