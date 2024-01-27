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
*  This file is generated by MASES.JNetReflector (ver. 2.2.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.DesktopNs
{
    #region IScreenSleepListener
    /// <summary>
    /// .NET interface for org.mases.jnet.generated.java.awt.desktop.ScreenSleepListener implementing <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html"/>
    /// </summary>
    public partial interface IScreenSleepListener
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAboutToSleep(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        void ScreenAboutToSleep(Java.Awt.DesktopNs.ScreenSleepEvent arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAwoke(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        void ScreenAwoke(Java.Awt.DesktopNs.ScreenSleepEvent arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region ScreenSleepListener
    public partial class ScreenSleepListener : Java.Awt.DesktopNs.IScreenSleepListener
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
        /// Handlers initializer for <see cref="ScreenSleepListener"/>
        /// </summary>
        protected virtual void InitializeHandlers()
        {
            AddEventHandler("screenAboutToSleep", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.ScreenSleepEvent>>>(ScreenAboutToSleepEventHandler));
            AddEventHandler("screenAwoke", new System.EventHandler<CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.ScreenSleepEvent>>>(ScreenAwokeEventHandler));

        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAboutToSleep(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnScreenAboutToSleep"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.DesktopNs.ScreenSleepEvent> OnScreenAboutToSleep { get; set; } = null;

        void ScreenAboutToSleepEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.ScreenSleepEvent>> data)
        {
            var methodToExecute = (OnScreenAboutToSleep != null) ? OnScreenAboutToSleep : ScreenAboutToSleep;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAboutToSleep(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        public virtual void ScreenAboutToSleep(Java.Awt.DesktopNs.ScreenSleepEvent arg0)
        {
            
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAwoke(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <remarks>If <see cref="OnScreenAwoke"/> has a value it takes precedence over corresponding class method</remarks>
        public System.Action<Java.Awt.DesktopNs.ScreenSleepEvent> OnScreenAwoke { get; set; } = null;

        void ScreenAwokeEventHandler(object sender, CLRListenerEventArgs<CLREventData<Java.Awt.DesktopNs.ScreenSleepEvent>> data)
        {
            var methodToExecute = (OnScreenAwoke != null) ? OnScreenAwoke : ScreenAwoke;
            methodToExecute.Invoke(data.EventData.TypedEventData);
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/desktop/ScreenSleepListener.html#screenAwoke(java.awt.desktop.ScreenSleepEvent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.ScreenSleepEvent"/></param>
        public virtual void ScreenAwoke(Java.Awt.DesktopNs.ScreenSleepEvent arg0)
        {
            
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}