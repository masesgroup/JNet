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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Management.Relation
{
    #region RelationNotification
    public partial class RelationNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#%3Cinit%3E(java.lang.String,java.lang.Object,long,long,java.lang.String,java.lang.String,java.lang.String,javax.management.ObjectName,java.lang.String,java.util.List,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="string"/></param>
        /// <param name="arg7"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg8"><see cref="string"/></param>
        /// <param name="arg9"><see cref="Java.Util.List"/></param>
        /// <param name="arg10"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RelationNotification(string arg0, object arg1, long arg2, long arg3, string arg4, string arg5, string arg6, Javax.Management.ObjectName arg7, string arg8, Java.Util.List<Javax.Management.ObjectName> arg9, Java.Util.List<Javax.Management.ObjectName> arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#%3Cinit%3E(java.lang.String,java.lang.Object,long,long,java.lang.String,java.lang.String,java.lang.String,javax.management.ObjectName,java.util.List)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="long"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="string"/></param>
        /// <param name="arg7"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg8"><see cref="Java.Util.List"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public RelationNotification(string arg0, object arg1, long arg2, long arg3, string arg4, string arg5, string arg6, Javax.Management.ObjectName arg7, Java.Util.List<Javax.Management.ObjectName> arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_BASIC_CREATION"/>
        /// </summary>
        public static string RELATION_BASIC_CREATION { get { if (!_RELATION_BASIC_CREATIONReady) { _RELATION_BASIC_CREATIONContent = SGetField<string>(LocalBridgeClazz, "RELATION_BASIC_CREATION"); _RELATION_BASIC_CREATIONReady = true; } return _RELATION_BASIC_CREATIONContent; } }
        private static string _RELATION_BASIC_CREATIONContent = default;
        private static bool _RELATION_BASIC_CREATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_BASIC_REMOVAL"/>
        /// </summary>
        public static string RELATION_BASIC_REMOVAL { get { if (!_RELATION_BASIC_REMOVALReady) { _RELATION_BASIC_REMOVALContent = SGetField<string>(LocalBridgeClazz, "RELATION_BASIC_REMOVAL"); _RELATION_BASIC_REMOVALReady = true; } return _RELATION_BASIC_REMOVALContent; } }
        private static string _RELATION_BASIC_REMOVALContent = default;
        private static bool _RELATION_BASIC_REMOVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_BASIC_UPDATE"/>
        /// </summary>
        public static string RELATION_BASIC_UPDATE { get { if (!_RELATION_BASIC_UPDATEReady) { _RELATION_BASIC_UPDATEContent = SGetField<string>(LocalBridgeClazz, "RELATION_BASIC_UPDATE"); _RELATION_BASIC_UPDATEReady = true; } return _RELATION_BASIC_UPDATEContent; } }
        private static string _RELATION_BASIC_UPDATEContent = default;
        private static bool _RELATION_BASIC_UPDATEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_MBEAN_CREATION"/>
        /// </summary>
        public static string RELATION_MBEAN_CREATION { get { if (!_RELATION_MBEAN_CREATIONReady) { _RELATION_MBEAN_CREATIONContent = SGetField<string>(LocalBridgeClazz, "RELATION_MBEAN_CREATION"); _RELATION_MBEAN_CREATIONReady = true; } return _RELATION_MBEAN_CREATIONContent; } }
        private static string _RELATION_MBEAN_CREATIONContent = default;
        private static bool _RELATION_MBEAN_CREATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_MBEAN_REMOVAL"/>
        /// </summary>
        public static string RELATION_MBEAN_REMOVAL { get { if (!_RELATION_MBEAN_REMOVALReady) { _RELATION_MBEAN_REMOVALContent = SGetField<string>(LocalBridgeClazz, "RELATION_MBEAN_REMOVAL"); _RELATION_MBEAN_REMOVALReady = true; } return _RELATION_MBEAN_REMOVALContent; } }
        private static string _RELATION_MBEAN_REMOVALContent = default;
        private static bool _RELATION_MBEAN_REMOVALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#RELATION_MBEAN_UPDATE"/>
        /// </summary>
        public static string RELATION_MBEAN_UPDATE { get { if (!_RELATION_MBEAN_UPDATEReady) { _RELATION_MBEAN_UPDATEContent = SGetField<string>(LocalBridgeClazz, "RELATION_MBEAN_UPDATE"); _RELATION_MBEAN_UPDATEReady = true; } return _RELATION_MBEAN_UPDATEContent; } }
        private static string _RELATION_MBEAN_UPDATEContent = default;
        private static bool _RELATION_MBEAN_UPDATEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getMBeansToUnregister()"/> 
        /// </summary>
        public Java.Util.List<Javax.Management.ObjectName> MBeansToUnregister
        {
            get { return IExecute<Java.Util.List<Javax.Management.ObjectName>>("getMBeansToUnregister"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getNewRoleValue()"/> 
        /// </summary>
        public Java.Util.List<Javax.Management.ObjectName> NewRoleValue
        {
            get { return IExecute<Java.Util.List<Javax.Management.ObjectName>>("getNewRoleValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getObjectName()"/> 
        /// </summary>
        public Javax.Management.ObjectName ObjectName
        {
            get { return IExecute<Javax.Management.ObjectName>("getObjectName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getOldRoleValue()"/> 
        /// </summary>
        public Java.Util.List<Javax.Management.ObjectName> OldRoleValue
        {
            get { return IExecute<Java.Util.List<Javax.Management.ObjectName>>("getOldRoleValue"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getRelationId()"/> 
        /// </summary>
        public string RelationId
        {
            get { return IExecute<string>("getRelationId"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getRelationTypeName()"/> 
        /// </summary>
        public string RelationTypeName
        {
            get { return IExecute<string>("getRelationTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/relation/RelationNotification.html#getRoleName()"/> 
        /// </summary>
        public string RoleName
        {
            get { return IExecute<string>("getRoleName"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}