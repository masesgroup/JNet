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

namespace Javax.Management
{
    #region MBeanServerNotification
    public partial class MBeanServerNotification
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#<init>(java.lang.String,java.lang.Object,long,javax.management.ObjectName)
        /// </summary>
        public MBeanServerNotification(string arg0, object arg1, long arg2, Javax.Management.ObjectName arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#REGISTRATION_NOTIFICATION
        /// </summary>
        public static string REGISTRATION_NOTIFICATION => Clazz.GetField<string>("REGISTRATION_NOTIFICATION");
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#UNREGISTRATION_NOTIFICATION
        /// </summary>
        public static string UNREGISTRATION_NOTIFICATION => Clazz.GetField<string>("UNREGISTRATION_NOTIFICATION");
        
        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/MBeanServerNotification.html#getMBeanName() 
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