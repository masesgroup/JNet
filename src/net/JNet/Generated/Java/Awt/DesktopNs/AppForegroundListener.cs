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

namespace Java.Awt.DesktopNs
{
    #region IAppForegroundListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.desktop.AppForegroundListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html"/>
    /// </summary>
    public partial interface IAppForegroundListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appMovedToBackground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        void AppMovedToBackground(Java.Awt.DesktopNs.AppForegroundEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appRaisedToForeground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        void AppRaisedToForeground(Java.Awt.DesktopNs.AppForegroundEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region AppForegroundListener
    public partial class AppForegroundListener : Java.Awt.DesktopNs.IAppForegroundListener
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
        /// Handlers initializer for <see cref="AppForegroundListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("appMovedToBackground", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.AppForegroundEvent>>>(AppMovedToBackgroundEventHandler));
            AddEventHandler("appRaisedToForeground", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.AppForegroundEvent>>>(AppRaisedToForegroundEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appMovedToBackground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAppMovedToBackground"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.DesktopNs.AppForegroundEvent> OnAppMovedToBackground { get; set; } = null;

        void AppMovedToBackgroundEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.AppForegroundEvent>> data)
        {
            var methodToExecute = (OnAppMovedToBackground != null) ? OnAppMovedToBackground : AppMovedToBackground;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appMovedToBackground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        public virtual void AppMovedToBackground(Java.Awt.DesktopNs.AppForegroundEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appRaisedToForeground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnAppRaisedToForeground"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.DesktopNs.AppForegroundEvent> OnAppRaisedToForeground { get; set; } = null;

        void AppRaisedToForegroundEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.AppForegroundEvent>> data)
        {
            var methodToExecute = (OnAppRaisedToForeground != null) ? OnAppRaisedToForeground : AppRaisedToForeground;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/AppForegroundListener.html#appRaisedToForeground(java.awt.desktop.AppForegroundEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AppForegroundEvent"/></param>
        public virtual void AppRaisedToForeground(Java.Awt.DesktopNs.AppForegroundEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}