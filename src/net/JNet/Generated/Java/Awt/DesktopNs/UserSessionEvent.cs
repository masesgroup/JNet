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

namespace Java.Awt.DesktopNs
{
    #region UserSessionEvent
    public partial class UserSessionEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.html#%3Cinit%3E(java.awt.desktop.UserSessionEvent.Reason)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent.Reason"/></param>
        public UserSessionEvent(Java.Awt.DesktopNs.UserSessionEvent.Reason arg0)
            : base(arg0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.html#getReason()"/> 
        /// </summary>
        public Java.Awt.DesktopNs.UserSessionEvent.Reason GetReason
        {
            get { return IExecute<Java.Awt.DesktopNs.UserSessionEvent.Reason>("getReason"); }
        }
        
        #endregion

        #region Nested classes
        #region Reason
        public partial class Reason
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#CONSOLE"/>
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason CONSOLE => Clazz.GetField<Java.Awt.DesktopNs.UserSessionEvent.Reason>("CONSOLE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#LOCK"/>
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason LOCK => Clazz.GetField<Java.Awt.DesktopNs.UserSessionEvent.Reason>("LOCK");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#REMOTE"/>
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason REMOTE => Clazz.GetField<Java.Awt.DesktopNs.UserSessionEvent.Reason>("REMOTE");
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#UNSPECIFIED"/>
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason UNSPECIFIED => Clazz.GetField<Java.Awt.DesktopNs.UserSessionEvent.Reason>("UNSPECIFIED");
            
            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#values()"/> 
            /// </summary>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason[] Values
            {
                get { return SExecuteArray<Java.Awt.DesktopNs.UserSessionEvent.Reason>(LocalClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionEvent.Reason.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Awt.DesktopNs.UserSessionEvent.Reason"/></returns>
            public static Java.Awt.DesktopNs.UserSessionEvent.Reason ValueOf(string arg0)
            {
                return SExecute<Java.Awt.DesktopNs.UserSessionEvent.Reason>(LocalClazz, "valueOf", arg0);
            }
            
            #endregion

            #region Instance methods

            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}