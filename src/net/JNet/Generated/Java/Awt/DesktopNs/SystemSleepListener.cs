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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.DesktopNs
{
    #region ISystemSleepListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.desktop.SystemSleepListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/SystemSleepListener.html"/>
    /// </summary>
    public partial interface ISystemSleepListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/SystemSleepListener.html#systemAboutToSleep(java.awt.desktop.SystemSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.SystemSleepEvent"/></param>
        void SystemAboutToSleep(Java.Awt.DesktopNs.SystemSleepEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/SystemSleepListener.html#systemAwoke(java.awt.desktop.SystemSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.SystemSleepEvent"/></param>
        void SystemAwoke(Java.Awt.DesktopNs.SystemSleepEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region SystemSleepListener
    public partial class SystemSleepListener : Java.Awt.DesktopNs.ISystemSleepListener
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
        /// Handlers initializer for <see cref="SystemSleepListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("systemAboutToSleep", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.SystemSleepEvent>>>(SystemAboutToSleepEventHandler));
            AddEventHandler("systemAwoke", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.SystemSleepEvent>>>(SystemAwokeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/SystemSleepListener.html#systemAboutToSleep(java.awt.desktop.SystemSleepEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSystemAboutToSleep"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.DesktopNs.SystemSleepEvent> OnSystemAboutToSleep { get; set; } = null;

        void SystemAboutToSleepEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.SystemSleepEvent>> data)
        {
            var methodToExecute = (OnSystemAboutToSleep != null) ? OnSystemAboutToSleep : SystemAboutToSleep;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/SystemSleepListener.html#systemAboutToSleep(java.awt.desktop.SystemSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.SystemSleepEvent"/></param>
        public virtual void SystemAboutToSleep(Java.Awt.DesktopNs.SystemSleepEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/SystemSleepListener.html#systemAwoke(java.awt.desktop.SystemSleepEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnSystemAwoke"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.DesktopNs.SystemSleepEvent> OnSystemAwoke { get; set; } = null;

        void SystemAwokeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.SystemSleepEvent>> data)
        {
            var methodToExecute = (OnSystemAwoke != null) ? OnSystemAwoke : SystemAwoke;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/SystemSleepListener.html#systemAwoke(java.awt.desktop.SystemSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.SystemSleepEvent"/></param>
        public virtual void SystemAwoke(Java.Awt.DesktopNs.SystemSleepEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}