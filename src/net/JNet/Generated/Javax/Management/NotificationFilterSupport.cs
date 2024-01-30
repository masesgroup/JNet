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
    #region NotificationFilterSupport
    public partial class NotificationFilterSupport
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Management.NotificationFilterSupport"/> to <see cref="Javax.Management.NotificationFilter"/>
        /// </summary>
        public static implicit operator Javax.Management.NotificationFilter(Javax.Management.NotificationFilterSupport t) => t.Cast<Javax.Management.NotificationFilter>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilterSupport.html#getEnabledTypes()"/> 
        /// </summary>
        public Java.Util.Vector<string> EnabledTypes
        {
            get { return IExecute<Java.Util.Vector<string>>("getEnabledTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilterSupport.html#isNotificationEnabled(javax.management.Notification)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Management.Notification"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsNotificationEnabled(Javax.Management.Notification arg0)
        {
            return IExecute<bool>("isNotificationEnabled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilterSupport.html#disableAllTypes()"/>
        /// </summary>
        public void DisableAllTypes()
        {
            IExecute("disableAllTypes");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilterSupport.html#disableType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public void DisableType(string arg0)
        {
            IExecute("disableType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.management/javax/management/NotificationFilterSupport.html#enableType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Lang.IllegalArgumentException"/>
        public void EnableType(string arg0)
        {
            IExecute("enableType", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}