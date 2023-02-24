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

namespace Javax.Naming.Ldap
{
    #region UnsolicitedNotificationEvent
    public partial class UnsolicitedNotificationEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationEvent.html#%3Cinit%3E(java.lang.Object,javax.naming.ldap.UnsolicitedNotification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="Javax.Naming.Ldap.UnsolicitedNotification"/></param>
        public UnsolicitedNotificationEvent(object arg0, Javax.Naming.Ldap.UnsolicitedNotification arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationEvent.html#getNotification()"/> 
        /// </summary>
        public Javax.Naming.Ldap.UnsolicitedNotification Notification
        {
            get { return IExecute<Javax.Naming.Ldap.UnsolicitedNotification>("getNotification"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.naming/javax/naming/ldap/UnsolicitedNotificationEvent.html#dispatch(javax.naming.ldap.UnsolicitedNotificationListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Naming.Ldap.UnsolicitedNotificationListener"/></param>
        public void Dispatch(Javax.Naming.Ldap.UnsolicitedNotificationListener arg0)
        {
            IExecute("dispatch", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}