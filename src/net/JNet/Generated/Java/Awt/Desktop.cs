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

namespace Java.Awt
{
    #region Desktop
    public partial class Desktop
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#getDesktop()"/> 
        /// </summary>
        public static Java.Awt.Desktop GetDesktop
        {
            get { return SExecute<Java.Awt.Desktop>(LocalBridgeClazz, "getDesktop"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#isDesktopSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public static bool IsDesktopSupported()
        {
            return SExecute<bool>(LocalBridgeClazz, "isDesktopSupported");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#isSupported(java.awt.Desktop.Action)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Desktop.Action"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSupported(Java.Awt.Desktop.Action arg0)
        {
            return IExecute<bool>("isSupported", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#moveToTrash(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool MoveToTrash(Java.Io.File arg0)
        {
            return IExecute<bool>("moveToTrash", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#addAppEventListener(java.awt.desktop.SystemEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.SystemEventListener"/></param>
        public void AddAppEventListener(Java.Awt.DesktopNs.SystemEventListener arg0)
        {
            IExecute("addAppEventListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#browse(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Browse(Java.Net.URI arg0)
        {
            IExecute("browse", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#browseFileDirectory(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        public void BrowseFileDirectory(Java.Io.File arg0)
        {
            IExecute("browseFileDirectory", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#disableSuddenTermination()"/>
        /// </summary>
        public void DisableSuddenTermination()
        {
            IExecute("disableSuddenTermination");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#edit(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Edit(Java.Io.File arg0)
        {
            IExecute("edit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#enableSuddenTermination()"/>
        /// </summary>
        public void EnableSuddenTermination()
        {
            IExecute("enableSuddenTermination");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#mail()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void Mail()
        {
            IExecute("mail");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#mail(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Mail(Java.Net.URI arg0)
        {
            IExecute("mail", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#open(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Open(Java.Io.File arg0)
        {
            IExecute("open", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#openHelpViewer()"/>
        /// </summary>
        public void OpenHelpViewer()
        {
            IExecute("openHelpViewer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#print(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Print(Java.Io.File arg0)
        {
            IExecute("print", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#removeAppEventListener(java.awt.desktop.SystemEventListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.SystemEventListener"/></param>
        public void RemoveAppEventListener(Java.Awt.DesktopNs.SystemEventListener arg0)
        {
            IExecute("removeAppEventListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#requestForeground(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void RequestForeground(bool arg0)
        {
            IExecute("requestForeground", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#setAboutHandler(java.awt.desktop.AboutHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.AboutHandler"/></param>
        public void SetAboutHandler(Java.Awt.DesktopNs.AboutHandler arg0)
        {
            IExecute("setAboutHandler", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#setDefaultMenuBar(javax.swing.JMenuBar)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JMenuBar"/></param>
        public void SetDefaultMenuBar(Javax.Swing.JMenuBar arg0)
        {
            IExecute("setDefaultMenuBar", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#setOpenFileHandler(java.awt.desktop.OpenFilesHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.OpenFilesHandler"/></param>
        public void SetOpenFileHandler(Java.Awt.DesktopNs.OpenFilesHandler arg0)
        {
            IExecute("setOpenFileHandler", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#setOpenURIHandler(java.awt.desktop.OpenURIHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.OpenURIHandler"/></param>
        public void SetOpenURIHandler(Java.Awt.DesktopNs.OpenURIHandler arg0)
        {
            IExecute("setOpenURIHandler", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#setPreferencesHandler(java.awt.desktop.PreferencesHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.PreferencesHandler"/></param>
        public void SetPreferencesHandler(Java.Awt.DesktopNs.PreferencesHandler arg0)
        {
            IExecute("setPreferencesHandler", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#setPrintFileHandler(java.awt.desktop.PrintFilesHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.PrintFilesHandler"/></param>
        public void SetPrintFileHandler(Java.Awt.DesktopNs.PrintFilesHandler arg0)
        {
            IExecute("setPrintFileHandler", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#setQuitHandler(java.awt.desktop.QuitHandler)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.QuitHandler"/></param>
        public void SetQuitHandler(Java.Awt.DesktopNs.QuitHandler arg0)
        {
            IExecute("setQuitHandler", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.html#setQuitStrategy(java.awt.desktop.QuitStrategy)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.DesktopNs.QuitStrategy"/></param>
        public void SetQuitStrategy(Java.Awt.DesktopNs.QuitStrategy arg0)
        {
            IExecute("setQuitStrategy", arg0);
        }

        #endregion

        #region Nested classes
        #region Action
        public partial class Action
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_ABOUT"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_ABOUT { get { if (!_APP_ABOUTReady) { _APP_ABOUTContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_ABOUT"); _APP_ABOUTReady = true; } return _APP_ABOUTContent; } }
            private static Java.Awt.Desktop.Action _APP_ABOUTContent = default;
            private static bool _APP_ABOUTReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_EVENT_FOREGROUND"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_EVENT_FOREGROUND { get { if (!_APP_EVENT_FOREGROUNDReady) { _APP_EVENT_FOREGROUNDContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_EVENT_FOREGROUND"); _APP_EVENT_FOREGROUNDReady = true; } return _APP_EVENT_FOREGROUNDContent; } }
            private static Java.Awt.Desktop.Action _APP_EVENT_FOREGROUNDContent = default;
            private static bool _APP_EVENT_FOREGROUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_EVENT_HIDDEN"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_EVENT_HIDDEN { get { if (!_APP_EVENT_HIDDENReady) { _APP_EVENT_HIDDENContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_EVENT_HIDDEN"); _APP_EVENT_HIDDENReady = true; } return _APP_EVENT_HIDDENContent; } }
            private static Java.Awt.Desktop.Action _APP_EVENT_HIDDENContent = default;
            private static bool _APP_EVENT_HIDDENReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_EVENT_REOPENED"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_EVENT_REOPENED { get { if (!_APP_EVENT_REOPENEDReady) { _APP_EVENT_REOPENEDContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_EVENT_REOPENED"); _APP_EVENT_REOPENEDReady = true; } return _APP_EVENT_REOPENEDContent; } }
            private static Java.Awt.Desktop.Action _APP_EVENT_REOPENEDContent = default;
            private static bool _APP_EVENT_REOPENEDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_EVENT_SCREEN_SLEEP"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_EVENT_SCREEN_SLEEP { get { if (!_APP_EVENT_SCREEN_SLEEPReady) { _APP_EVENT_SCREEN_SLEEPContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_EVENT_SCREEN_SLEEP"); _APP_EVENT_SCREEN_SLEEPReady = true; } return _APP_EVENT_SCREEN_SLEEPContent; } }
            private static Java.Awt.Desktop.Action _APP_EVENT_SCREEN_SLEEPContent = default;
            private static bool _APP_EVENT_SCREEN_SLEEPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_EVENT_SYSTEM_SLEEP"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_EVENT_SYSTEM_SLEEP { get { if (!_APP_EVENT_SYSTEM_SLEEPReady) { _APP_EVENT_SYSTEM_SLEEPContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_EVENT_SYSTEM_SLEEP"); _APP_EVENT_SYSTEM_SLEEPReady = true; } return _APP_EVENT_SYSTEM_SLEEPContent; } }
            private static Java.Awt.Desktop.Action _APP_EVENT_SYSTEM_SLEEPContent = default;
            private static bool _APP_EVENT_SYSTEM_SLEEPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_EVENT_USER_SESSION"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_EVENT_USER_SESSION { get { if (!_APP_EVENT_USER_SESSIONReady) { _APP_EVENT_USER_SESSIONContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_EVENT_USER_SESSION"); _APP_EVENT_USER_SESSIONReady = true; } return _APP_EVENT_USER_SESSIONContent; } }
            private static Java.Awt.Desktop.Action _APP_EVENT_USER_SESSIONContent = default;
            private static bool _APP_EVENT_USER_SESSIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_HELP_VIEWER"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_HELP_VIEWER { get { if (!_APP_HELP_VIEWERReady) { _APP_HELP_VIEWERContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_HELP_VIEWER"); _APP_HELP_VIEWERReady = true; } return _APP_HELP_VIEWERContent; } }
            private static Java.Awt.Desktop.Action _APP_HELP_VIEWERContent = default;
            private static bool _APP_HELP_VIEWERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_MENU_BAR"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_MENU_BAR { get { if (!_APP_MENU_BARReady) { _APP_MENU_BARContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_MENU_BAR"); _APP_MENU_BARReady = true; } return _APP_MENU_BARContent; } }
            private static Java.Awt.Desktop.Action _APP_MENU_BARContent = default;
            private static bool _APP_MENU_BARReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_OPEN_FILE"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_OPEN_FILE { get { if (!_APP_OPEN_FILEReady) { _APP_OPEN_FILEContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_OPEN_FILE"); _APP_OPEN_FILEReady = true; } return _APP_OPEN_FILEContent; } }
            private static Java.Awt.Desktop.Action _APP_OPEN_FILEContent = default;
            private static bool _APP_OPEN_FILEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_OPEN_URI"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_OPEN_URI { get { if (!_APP_OPEN_URIReady) { _APP_OPEN_URIContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_OPEN_URI"); _APP_OPEN_URIReady = true; } return _APP_OPEN_URIContent; } }
            private static Java.Awt.Desktop.Action _APP_OPEN_URIContent = default;
            private static bool _APP_OPEN_URIReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_PREFERENCES"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_PREFERENCES { get { if (!_APP_PREFERENCESReady) { _APP_PREFERENCESContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_PREFERENCES"); _APP_PREFERENCESReady = true; } return _APP_PREFERENCESContent; } }
            private static Java.Awt.Desktop.Action _APP_PREFERENCESContent = default;
            private static bool _APP_PREFERENCESReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_PRINT_FILE"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_PRINT_FILE { get { if (!_APP_PRINT_FILEReady) { _APP_PRINT_FILEContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_PRINT_FILE"); _APP_PRINT_FILEReady = true; } return _APP_PRINT_FILEContent; } }
            private static Java.Awt.Desktop.Action _APP_PRINT_FILEContent = default;
            private static bool _APP_PRINT_FILEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_QUIT_HANDLER"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_QUIT_HANDLER { get { if (!_APP_QUIT_HANDLERReady) { _APP_QUIT_HANDLERContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_QUIT_HANDLER"); _APP_QUIT_HANDLERReady = true; } return _APP_QUIT_HANDLERContent; } }
            private static Java.Awt.Desktop.Action _APP_QUIT_HANDLERContent = default;
            private static bool _APP_QUIT_HANDLERReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_QUIT_STRATEGY"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_QUIT_STRATEGY { get { if (!_APP_QUIT_STRATEGYReady) { _APP_QUIT_STRATEGYContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_QUIT_STRATEGY"); _APP_QUIT_STRATEGYReady = true; } return _APP_QUIT_STRATEGYContent; } }
            private static Java.Awt.Desktop.Action _APP_QUIT_STRATEGYContent = default;
            private static bool _APP_QUIT_STRATEGYReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_REQUEST_FOREGROUND"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_REQUEST_FOREGROUND { get { if (!_APP_REQUEST_FOREGROUNDReady) { _APP_REQUEST_FOREGROUNDContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_REQUEST_FOREGROUND"); _APP_REQUEST_FOREGROUNDReady = true; } return _APP_REQUEST_FOREGROUNDContent; } }
            private static Java.Awt.Desktop.Action _APP_REQUEST_FOREGROUNDContent = default;
            private static bool _APP_REQUEST_FOREGROUNDReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#APP_SUDDEN_TERMINATION"/>
            /// </summary>
            public static Java.Awt.Desktop.Action APP_SUDDEN_TERMINATION { get { if (!_APP_SUDDEN_TERMINATIONReady) { _APP_SUDDEN_TERMINATIONContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "APP_SUDDEN_TERMINATION"); _APP_SUDDEN_TERMINATIONReady = true; } return _APP_SUDDEN_TERMINATIONContent; } }
            private static Java.Awt.Desktop.Action _APP_SUDDEN_TERMINATIONContent = default;
            private static bool _APP_SUDDEN_TERMINATIONReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#BROWSE"/>
            /// </summary>
            public static Java.Awt.Desktop.Action BROWSE { get { if (!_BROWSEReady) { _BROWSEContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "BROWSE"); _BROWSEReady = true; } return _BROWSEContent; } }
            private static Java.Awt.Desktop.Action _BROWSEContent = default;
            private static bool _BROWSEReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#BROWSE_FILE_DIR"/>
            /// </summary>
            public static Java.Awt.Desktop.Action BROWSE_FILE_DIR { get { if (!_BROWSE_FILE_DIRReady) { _BROWSE_FILE_DIRContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "BROWSE_FILE_DIR"); _BROWSE_FILE_DIRReady = true; } return _BROWSE_FILE_DIRContent; } }
            private static Java.Awt.Desktop.Action _BROWSE_FILE_DIRContent = default;
            private static bool _BROWSE_FILE_DIRReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#EDIT"/>
            /// </summary>
            public static Java.Awt.Desktop.Action EDIT { get { if (!_EDITReady) { _EDITContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "EDIT"); _EDITReady = true; } return _EDITContent; } }
            private static Java.Awt.Desktop.Action _EDITContent = default;
            private static bool _EDITReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#MAIL"/>
            /// </summary>
            public static Java.Awt.Desktop.Action MAIL { get { if (!_MAILReady) { _MAILContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "MAIL"); _MAILReady = true; } return _MAILContent; } }
            private static Java.Awt.Desktop.Action _MAILContent = default;
            private static bool _MAILReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#MOVE_TO_TRASH"/>
            /// </summary>
            public static Java.Awt.Desktop.Action MOVE_TO_TRASH { get { if (!_MOVE_TO_TRASHReady) { _MOVE_TO_TRASHContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "MOVE_TO_TRASH"); _MOVE_TO_TRASHReady = true; } return _MOVE_TO_TRASHContent; } }
            private static Java.Awt.Desktop.Action _MOVE_TO_TRASHContent = default;
            private static bool _MOVE_TO_TRASHReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#OPEN"/>
            /// </summary>
            public static Java.Awt.Desktop.Action OPEN { get { if (!_OPENReady) { _OPENContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "OPEN"); _OPENReady = true; } return _OPENContent; } }
            private static Java.Awt.Desktop.Action _OPENContent = default;
            private static bool _OPENReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#PRINT"/>
            /// </summary>
            public static Java.Awt.Desktop.Action PRINT { get { if (!_PRINTReady) { _PRINTContent = SGetField<Java.Awt.Desktop.Action>(LocalBridgeClazz, "PRINT"); _PRINTReady = true; } return _PRINTContent; } }
            private static Java.Awt.Desktop.Action _PRINTContent = default;
            private static bool _PRINTReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Awt.Desktop.Action"/></returns>
            public static Java.Awt.Desktop.Action ValueOf(Java.Lang.String arg0)
            {
                return SExecute<Java.Awt.Desktop.Action>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Desktop.Action.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Awt.Desktop.Action"/></returns>
            public static Java.Awt.Desktop.Action[] Values()
            {
                return SExecuteArray<Java.Awt.Desktop.Action>(LocalBridgeClazz, "values");
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}