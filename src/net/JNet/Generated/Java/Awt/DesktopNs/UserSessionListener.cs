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
*  This file is generated by MASES.JNetReflector (ver. 2.0.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.DesktopNs
{
    #region IUserSessionListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.desktop.UserSessionListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html"/>
    /// </summary>
    public partial interface IUserSessionListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionActivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        void UserSessionActivated(Java.Awt.DesktopNs.UserSessionEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionDeactivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        void UserSessionDeactivated(Java.Awt.DesktopNs.UserSessionEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region UserSessionListener
    public partial class UserSessionListener : Java.Awt.DesktopNs.IUserSessionListener
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// Handlers initializer for <see cref="UserSessionListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("userSessionActivated", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.UserSessionEvent>>>(UserSessionActivatedEventHandler));
            AddEventHandler("userSessionDeactivated", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.UserSessionEvent>>>(UserSessionDeactivatedEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionActivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.DesktopNs.UserSessionEvent> OnUserSessionActivated { get; set; }

        void UserSessionActivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.UserSessionEvent>> data)
        {
            var methodToExecute = (OnUserSessionActivated != null) ? OnUserSessionActivated : UserSessionActivated;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionActivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        public virtual void UserSessionActivated(Java.Awt.DesktopNs.UserSessionEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionDeactivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        public System.Action<Java.Awt.DesktopNs.UserSessionEvent> OnUserSessionDeactivated { get; set; }

        void UserSessionDeactivatedEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.UserSessionEvent>> data)
        {
            var methodToExecute = (OnUserSessionDeactivated != null) ? OnUserSessionDeactivated : UserSessionDeactivated;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/UserSessionListener.html#userSessionDeactivated(java.awt.desktop.UserSessionEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.UserSessionEvent"/></param>
        public virtual void UserSessionDeactivated(Java.Awt.DesktopNs.UserSessionEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}