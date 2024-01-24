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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt
{
    #region Window
    public partial class Window
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#%3Cinit%3E(java.awt.Frame)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Frame"/></param>
        public Window(Java.Awt.Frame arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#%3Cinit%3E(java.awt.Window,java.awt.GraphicsConfiguration)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        /// <param name="arg1"><see cref="Java.Awt.GraphicsConfiguration"/></param>
        public Window(Java.Awt.Window arg0, Java.Awt.GraphicsConfiguration arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#%3Cinit%3E(java.awt.Window)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window"/></param>
        public Window(Java.Awt.Window arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.Window"/> to <see cref="Javax.Accessibility.Accessible"/>
        /// </summary>
        public static implicit operator Javax.Accessibility.Accessible(Java.Awt.Window t) => t.Cast<Javax.Accessibility.Accessible>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getOwnerlessWindows()"/> 
        /// </summary>
        public static Java.Awt.Window[] OwnerlessWindows
        {
            get { return SExecuteArray<Java.Awt.Window>(LocalBridgeClazz, "getOwnerlessWindows"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWindows()"/> 
        /// </summary>
        public static Java.Awt.Window[] Windows
        {
            get { return SExecuteArray<Java.Awt.Window>(LocalBridgeClazz, "getWindows"); }
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getBufferStrategy()"/> 
        /// </summary>
        public Java.Awt.ImageNs.BufferStrategy BufferStrategy
        {
            get { return IExecute<Java.Awt.ImageNs.BufferStrategy>("getBufferStrategy"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getFocusableWindowState()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setFocusableWindowState(boolean)"/>
        /// </summary>
        public bool FocusableWindowState
        {
            get { return IExecute<bool>("getFocusableWindowState"); } set { IExecute("setFocusableWindowState", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component FocusOwner
        {
            get { return IExecute<Java.Awt.Component>("getFocusOwner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getType()"/> 
        /// </summary>
        public Java.Awt.Window.Type GetType
        {
            get { return IExecute<Java.Awt.Window.Type>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getIconImages()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setIconImages(java.util.List)"/>
        /// </summary>
        public Java.Util.List<Java.Awt.Image> IconImages
        {
            get { return IExecute<Java.Util.List<Java.Awt.Image>>("getIconImages"); } set { IExecute("setIconImages", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getModalExclusionType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setModalExclusionType(java.awt.Dialog.ModalExclusionType)"/>
        /// </summary>
        public Java.Awt.Dialog.ModalExclusionType ModalExclusionType
        {
            get { return IExecute<Java.Awt.Dialog.ModalExclusionType>("getModalExclusionType"); } set { IExecute("setModalExclusionType", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getMostRecentFocusOwner()"/> 
        /// </summary>
        public Java.Awt.Component MostRecentFocusOwner
        {
            get { return IExecute<Java.Awt.Component>("getMostRecentFocusOwner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getOpacity()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setOpacity(float)"/>
        /// </summary>
        public float Opacity
        {
            get { return IExecute<float>("getOpacity"); } set { IExecute("setOpacity", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getOwnedWindows()"/> 
        /// </summary>
        public Java.Awt.Window[] OwnedWindows
        {
            get { return IExecuteArray<Java.Awt.Window>("getOwnedWindows"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getOwner()"/> 
        /// </summary>
        public Java.Awt.Window Owner
        {
            get { return IExecute<Java.Awt.Window>("getOwner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getShape()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setShape(java.awt.Shape)"/>
        /// </summary>
        public Java.Awt.Shape Shape
        {
            get { return IExecute<Java.Awt.Shape>("getShape"); } set { IExecute("setShape", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWarningString()"/> 
        /// </summary>
        public string WarningString
        {
            get { return IExecute<string>("getWarningString"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWindowFocusListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.WindowFocusListener[] WindowFocusListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.WindowFocusListener>("getWindowFocusListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWindowListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.WindowListener[] WindowListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.WindowListener>("getWindowListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#getWindowStateListeners()"/> 
        /// </summary>
        public Java.Awt.EventNs.WindowStateListener[] WindowStateListeners
        {
            get { return IExecuteArray<Java.Awt.EventNs.WindowStateListener>("getWindowStateListeners"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isActive()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsActive()
        {
            return IExecute<bool>("isActive");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isAlwaysOnTopSupported()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAlwaysOnTopSupported()
        {
            return IExecute<bool>("isAlwaysOnTopSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isAutoRequestFocus()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAutoRequestFocus()
        {
            return IExecute<bool>("isAutoRequestFocus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isFocused()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFocused()
        {
            return IExecute<bool>("isFocused");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isLocationByPlatform()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLocationByPlatform()
        {
            return IExecute<bool>("isLocationByPlatform");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isAlwaysOnTop()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAlwaysOnTop()
        {
            return IExecute<bool>("isAlwaysOnTop");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#isFocusableWindow()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFocusableWindow()
        {
            return IExecute<bool>("isFocusableWindow");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setAlwaysOnTop(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Lang.SecurityException"/>
        public void SetAlwaysOnTop(bool arg0)
        {
            IExecute("setAlwaysOnTop", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#addWindowFocusListener(java.awt.event.WindowFocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowFocusListener"/></param>
        public void AddWindowFocusListener(Java.Awt.EventNs.WindowFocusListener arg0)
        {
            IExecute("addWindowFocusListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#addWindowListener(java.awt.event.WindowListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowListener"/></param>
        public void AddWindowListener(Java.Awt.EventNs.WindowListener arg0)
        {
            IExecute("addWindowListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#addWindowStateListener(java.awt.event.WindowStateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowStateListener"/></param>
        public void AddWindowStateListener(Java.Awt.EventNs.WindowStateListener arg0)
        {
            IExecute("addWindowStateListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#removeWindowFocusListener(java.awt.event.WindowFocusListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowFocusListener"/></param>
        public void RemoveWindowFocusListener(Java.Awt.EventNs.WindowFocusListener arg0)
        {
            IExecute("removeWindowFocusListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#removeWindowListener(java.awt.event.WindowListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowListener"/></param>
        public void RemoveWindowListener(Java.Awt.EventNs.WindowListener arg0)
        {
            IExecute("removeWindowListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#removeWindowStateListener(java.awt.event.WindowStateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.EventNs.WindowStateListener"/></param>
        public void RemoveWindowStateListener(Java.Awt.EventNs.WindowStateListener arg0)
        {
            IExecute("removeWindowStateListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#createBufferStrategy(int,java.awt.BufferCapabilities)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.BufferCapabilities"/></param>
        /// <exception cref="Java.Awt.AWTException"/>
        public void CreateBufferStrategy(int arg0, Java.Awt.BufferCapabilities arg1)
        {
            IExecute("createBufferStrategy", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#createBufferStrategy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void CreateBufferStrategy(int arg0)
        {
            IExecute("createBufferStrategy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecute("dispose");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#pack()"/>
        /// </summary>
        public void Pack()
        {
            IExecute("pack");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setAutoRequestFocus(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetAutoRequestFocus(bool arg0)
        {
            IExecute("setAutoRequestFocus", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setIconImage(java.awt.Image)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        public void SetIconImage(Java.Awt.Image arg0)
        {
            IExecute("setIconImage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setLocationByPlatform(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public void SetLocationByPlatform(bool arg0)
        {
            IExecute("setLocationByPlatform", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setLocationRelativeTo(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        public void SetLocationRelativeTo(Java.Awt.Component arg0)
        {
            IExecute("setLocationRelativeTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#setType(java.awt.Window.Type)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Window.Type"/></param>
        public void SetType(Java.Awt.Window.Type arg0)
        {
            IExecute("setType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#toBack()"/>
        /// </summary>
        public void ToBack()
        {
            IExecute("toBack");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.html#toFront()"/>
        /// </summary>
        public void ToFront()
        {
            IExecute("toFront");
        }

        #endregion

        #region Nested classes
        #region Type
        public partial class Type
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#NORMAL"/>
            /// </summary>
            public static Java.Awt.Window.Type NORMAL { get { if (!_NORMALReady) { _NORMALContent = SGetField<Java.Awt.Window.Type>(LocalBridgeClazz, "NORMAL"); _NORMALReady = true; } return _NORMALContent; } }
            private static Java.Awt.Window.Type _NORMALContent = default;
            private static bool _NORMALReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#POPUP"/>
            /// </summary>
            public static Java.Awt.Window.Type POPUP { get { if (!_POPUPReady) { _POPUPContent = SGetField<Java.Awt.Window.Type>(LocalBridgeClazz, "POPUP"); _POPUPReady = true; } return _POPUPContent; } }
            private static Java.Awt.Window.Type _POPUPContent = default;
            private static bool _POPUPReady = false; // this is used because in case of generics 
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#UTILITY"/>
            /// </summary>
            public static Java.Awt.Window.Type UTILITY { get { if (!_UTILITYReady) { _UTILITYContent = SGetField<Java.Awt.Window.Type>(LocalBridgeClazz, "UTILITY"); _UTILITYReady = true; } return _UTILITYContent; } }
            private static Java.Awt.Window.Type _UTILITYContent = default;
            private static bool _UTILITYReady = false; // this is used because in case of generics 

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Awt.Window.Type"/></returns>
            public static Java.Awt.Window.Type ValueOf(string arg0)
            {
                return SExecute<Java.Awt.Window.Type>(LocalBridgeClazz, "valueOf", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/Window.Type.html#values()"/>
            /// </summary>

            /// <returns><see cref="Java.Awt.Window.Type"/></returns>
            public static Java.Awt.Window.Type[] Values()
            {
                return SExecuteArray<Java.Awt.Window.Type>(LocalBridgeClazz, "values");
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