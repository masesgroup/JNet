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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region SystemTray
    public partial class SystemTray
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#getSystemTray()"/> 
        /// </summary>
        public static Java.Awt.SystemTray GetSystemTray
        {
            get { return SExecute<Java.Awt.SystemTray>(LocalBridgeClazz, "getSystemTray"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#isSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsSupported()
        {
            return SExecute<bool>(LocalBridgeClazz, "isSupported");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#getTrayIcons()"/> 
        /// </summary>
        public Java.Awt.TrayIcon[] TrayIcons
        {
            get { return IExecuteArray<Java.Awt.TrayIcon>("getTrayIcons"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#getTrayIconSize()"/> 
        /// </summary>
        public Java.Awt.Dimension TrayIconSize
        {
            get { return IExecute<Java.Awt.Dimension>("getTrayIconSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#getPropertyChangeListeners(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Beans.PropertyChangeListener"/></returns>
        public Java.Beans.PropertyChangeListener[] GetPropertyChangeListeners(string arg0)
        {
            return IExecuteArray<Java.Beans.PropertyChangeListener>("getPropertyChangeListeners", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#addPropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void AddPropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("addPropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#removePropertyChangeListener(java.lang.String,java.beans.PropertyChangeListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Beans.PropertyChangeListener"/></param>
        public void RemovePropertyChangeListener(string arg0, Java.Beans.PropertyChangeListener arg1)
        {
            IExecute("removePropertyChangeListener", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#add(java.awt.TrayIcon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.TrayIcon"/></param>
        /// <exception cref="Java.Awt.AWTException"/>
        public void Add(Java.Awt.TrayIcon arg0)
        {
            IExecute("add", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/SystemTray.html#remove(java.awt.TrayIcon)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.TrayIcon"/></param>
        public void Remove(Java.Awt.TrayIcon arg0)
        {
            IExecute("remove", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}