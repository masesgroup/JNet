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

namespace Javax.Management
{
    #region JMX
    public partial class JMX
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#DEFAULT_VALUE_FIELD"/>
        /// </summary>
        public static string DEFAULT_VALUE_FIELD { get { return SGetField<string>(LocalClazz, "DEFAULT_VALUE_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#IMMUTABLE_INFO_FIELD"/>
        /// </summary>
        public static string IMMUTABLE_INFO_FIELD { get { return SGetField<string>(LocalClazz, "IMMUTABLE_INFO_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#INTERFACE_CLASS_NAME_FIELD"/>
        /// </summary>
        public static string INTERFACE_CLASS_NAME_FIELD { get { return SGetField<string>(LocalClazz, "INTERFACE_CLASS_NAME_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#LEGAL_VALUES_FIELD"/>
        /// </summary>
        public static string LEGAL_VALUES_FIELD { get { return SGetField<string>(LocalClazz, "LEGAL_VALUES_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#MAX_VALUE_FIELD"/>
        /// </summary>
        public static string MAX_VALUE_FIELD { get { return SGetField<string>(LocalClazz, "MAX_VALUE_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#MIN_VALUE_FIELD"/>
        /// </summary>
        public static string MIN_VALUE_FIELD { get { return SGetField<string>(LocalClazz, "MIN_VALUE_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#MXBEAN_FIELD"/>
        /// </summary>
        public static string MXBEAN_FIELD { get { return SGetField<string>(LocalClazz, "MXBEAN_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#OPEN_TYPE_FIELD"/>
        /// </summary>
        public static string OPEN_TYPE_FIELD { get { return SGetField<string>(LocalClazz, "OPEN_TYPE_FIELD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#ORIGINAL_TYPE_FIELD"/>
        /// </summary>
        public static string ORIGINAL_TYPE_FIELD { get { return SGetField<string>(LocalClazz, "ORIGINAL_TYPE_FIELD"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#newMBeanProxy(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="T"/></returns>
        public static T NewMBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2, bool arg3)
        {
            return SExecute<T>(LocalClazz, "newMBeanProxy", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#newMBeanProxy(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="T"/></returns>
        public static T NewMBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2)
        {
            return SExecute<T>(LocalClazz, "newMBeanProxy", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#newMXBeanProxy(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg3"><see cref="bool"/></param>
        /// <returns><see cref="T"/></returns>
        public static T NewMXBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2, bool arg3)
        {
            return SExecute<T>(LocalClazz, "newMXBeanProxy", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#newMXBeanProxy(javax.management.MBeanServerConnection,javax.management.ObjectName,java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.MBeanServerConnection"/></param>
        /// <param name="arg1"><see cref="Javax.Management.ObjectName"/></param>
        /// <param name="arg2"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="T"/></returns>
        public static T NewMXBeanProxy<T>(Javax.Management.MBeanServerConnection arg0, Javax.Management.ObjectName arg1, Java.Lang.Class arg2)
        {
            return SExecute<T>(LocalClazz, "newMXBeanProxy", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/JMX.html#isMXBeanInterface(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public static bool IsMXBeanInterface(Java.Lang.Class arg0)
        {
            return SExecute<bool>(LocalClazz, "isMXBeanInterface", arg0);
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