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

namespace Javax.Management
{
    #region MBeanServerNotification
    public partial class MBeanServerNotification
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#%3Cinit%3E(java.lang.String,java.lang.Object,long,javax.management.ObjectName)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="Javax.Management.ObjectName"/></param>
        public MBeanServerNotification(string arg0, object arg1, long arg2, Javax.Management.ObjectName arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#REGISTRATION_NOTIFICATION"/>
        /// </summary>
        public static string REGISTRATION_NOTIFICATION { get { if (!_REGISTRATION_NOTIFICATIONReady) { _REGISTRATION_NOTIFICATIONContent = SGetField<string>(LocalBridgeClazz, "REGISTRATION_NOTIFICATION"); _REGISTRATION_NOTIFICATIONReady = true; } return _REGISTRATION_NOTIFICATIONContent; } }
        private static string _REGISTRATION_NOTIFICATIONContent = default;
        private static bool _REGISTRATION_NOTIFICATIONReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#UNREGISTRATION_NOTIFICATION"/>
        /// </summary>
        public static string UNREGISTRATION_NOTIFICATION { get { if (!_UNREGISTRATION_NOTIFICATIONReady) { _UNREGISTRATION_NOTIFICATIONContent = SGetField<string>(LocalBridgeClazz, "UNREGISTRATION_NOTIFICATION"); _UNREGISTRATION_NOTIFICATIONReady = true; } return _UNREGISTRATION_NOTIFICATIONContent; } }
        private static string _UNREGISTRATION_NOTIFICATIONContent = default;
        private static bool _UNREGISTRATION_NOTIFICATIONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#getMBeanName()"/> 
        /// </summary>
        public Javax.Management.ObjectName MBeanName
        {
            get { return IExecute<Javax.Management.ObjectName>("getMBeanName"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}