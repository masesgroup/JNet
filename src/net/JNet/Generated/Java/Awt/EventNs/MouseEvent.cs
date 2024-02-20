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

namespace Java.Awt.EventNs
{
    #region MouseEvent
    public partial class MouseEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#%3Cinit%3E(java.awt.Component,int,long,int,int,int,int,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="bool"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        public MouseEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, bool arg7, int arg8)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#%3Cinit%3E(java.awt.Component,int,long,int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="bool"/></param>
        public MouseEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, bool arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#%3Cinit%3E(java.awt.Component,int,long,int,int,int,int,int,int,boolean,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="long"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        /// <param name="arg8"><see cref="int"/></param>
        /// <param name="arg9"><see cref="bool"/></param>
        /// <param name="arg10"><see cref="int"/></param>
        public MouseEvent(Java.Awt.Component arg0, int arg1, long arg2, int arg3, int arg4, int arg5, int arg6, int arg7, int arg8, bool arg9, int arg10)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#BUTTON1"/>
        /// </summary>
        public static int BUTTON1 { get { if (!_BUTTON1Ready) { _BUTTON1Content = SGetField<int>(LocalBridgeClazz, "BUTTON1"); _BUTTON1Ready = true; } return _BUTTON1Content; } }
        private static int _BUTTON1Content = default;
        private static bool _BUTTON1Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#BUTTON2"/>
        /// </summary>
        public static int BUTTON2 { get { if (!_BUTTON2Ready) { _BUTTON2Content = SGetField<int>(LocalBridgeClazz, "BUTTON2"); _BUTTON2Ready = true; } return _BUTTON2Content; } }
        private static int _BUTTON2Content = default;
        private static bool _BUTTON2Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#BUTTON3"/>
        /// </summary>
        public static int BUTTON3 { get { if (!_BUTTON3Ready) { _BUTTON3Content = SGetField<int>(LocalBridgeClazz, "BUTTON3"); _BUTTON3Ready = true; } return _BUTTON3Content; } }
        private static int _BUTTON3Content = default;
        private static bool _BUTTON3Ready = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_CLICKED"/>
        /// </summary>
        public static int MOUSE_CLICKED { get { if (!_MOUSE_CLICKEDReady) { _MOUSE_CLICKEDContent = SGetField<int>(LocalBridgeClazz, "MOUSE_CLICKED"); _MOUSE_CLICKEDReady = true; } return _MOUSE_CLICKEDContent; } }
        private static int _MOUSE_CLICKEDContent = default;
        private static bool _MOUSE_CLICKEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_DRAGGED"/>
        /// </summary>
        public static int MOUSE_DRAGGED { get { if (!_MOUSE_DRAGGEDReady) { _MOUSE_DRAGGEDContent = SGetField<int>(LocalBridgeClazz, "MOUSE_DRAGGED"); _MOUSE_DRAGGEDReady = true; } return _MOUSE_DRAGGEDContent; } }
        private static int _MOUSE_DRAGGEDContent = default;
        private static bool _MOUSE_DRAGGEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_ENTERED"/>
        /// </summary>
        public static int MOUSE_ENTERED { get { if (!_MOUSE_ENTEREDReady) { _MOUSE_ENTEREDContent = SGetField<int>(LocalBridgeClazz, "MOUSE_ENTERED"); _MOUSE_ENTEREDReady = true; } return _MOUSE_ENTEREDContent; } }
        private static int _MOUSE_ENTEREDContent = default;
        private static bool _MOUSE_ENTEREDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_EXITED"/>
        /// </summary>
        public static int MOUSE_EXITED { get { if (!_MOUSE_EXITEDReady) { _MOUSE_EXITEDContent = SGetField<int>(LocalBridgeClazz, "MOUSE_EXITED"); _MOUSE_EXITEDReady = true; } return _MOUSE_EXITEDContent; } }
        private static int _MOUSE_EXITEDContent = default;
        private static bool _MOUSE_EXITEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_FIRST"/>
        /// </summary>
        public static int MOUSE_FIRST { get { if (!_MOUSE_FIRSTReady) { _MOUSE_FIRSTContent = SGetField<int>(LocalBridgeClazz, "MOUSE_FIRST"); _MOUSE_FIRSTReady = true; } return _MOUSE_FIRSTContent; } }
        private static int _MOUSE_FIRSTContent = default;
        private static bool _MOUSE_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_LAST"/>
        /// </summary>
        public static int MOUSE_LAST { get { if (!_MOUSE_LASTReady) { _MOUSE_LASTContent = SGetField<int>(LocalBridgeClazz, "MOUSE_LAST"); _MOUSE_LASTReady = true; } return _MOUSE_LASTContent; } }
        private static int _MOUSE_LASTContent = default;
        private static bool _MOUSE_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_MOVED"/>
        /// </summary>
        public static int MOUSE_MOVED { get { if (!_MOUSE_MOVEDReady) { _MOUSE_MOVEDContent = SGetField<int>(LocalBridgeClazz, "MOUSE_MOVED"); _MOUSE_MOVEDReady = true; } return _MOUSE_MOVEDContent; } }
        private static int _MOUSE_MOVEDContent = default;
        private static bool _MOUSE_MOVEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_PRESSED"/>
        /// </summary>
        public static int MOUSE_PRESSED { get { if (!_MOUSE_PRESSEDReady) { _MOUSE_PRESSEDContent = SGetField<int>(LocalBridgeClazz, "MOUSE_PRESSED"); _MOUSE_PRESSEDReady = true; } return _MOUSE_PRESSEDContent; } }
        private static int _MOUSE_PRESSEDContent = default;
        private static bool _MOUSE_PRESSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_RELEASED"/>
        /// </summary>
        public static int MOUSE_RELEASED { get { if (!_MOUSE_RELEASEDReady) { _MOUSE_RELEASEDContent = SGetField<int>(LocalBridgeClazz, "MOUSE_RELEASED"); _MOUSE_RELEASEDReady = true; } return _MOUSE_RELEASEDContent; } }
        private static int _MOUSE_RELEASEDContent = default;
        private static bool _MOUSE_RELEASEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#MOUSE_WHEEL"/>
        /// </summary>
        public static int MOUSE_WHEEL { get { if (!_MOUSE_WHEELReady) { _MOUSE_WHEELContent = SGetField<int>(LocalBridgeClazz, "MOUSE_WHEEL"); _MOUSE_WHEELReady = true; } return _MOUSE_WHEELContent; } }
        private static int _MOUSE_WHEELContent = default;
        private static bool _MOUSE_WHEELReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#NOBUTTON"/>
        /// </summary>
        public static int NOBUTTON { get { if (!_NOBUTTONReady) { _NOBUTTONContent = SGetField<int>(LocalBridgeClazz, "NOBUTTON"); _NOBUTTONReady = true; } return _NOBUTTONContent; } }
        private static int _NOBUTTONContent = default;
        private static bool _NOBUTTONReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getMouseModifiersText(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String GetMouseModifiersText(int arg0)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "getMouseModifiersText", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getButton()"/> 
        /// </summary>
        public int Button
        {
            get { return IExecute<int>("getButton"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getClickCount()"/> 
        /// </summary>
        public int ClickCount
        {
            get { return IExecute<int>("getClickCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getLocationOnScreen()"/> 
        /// </summary>
        public Java.Awt.Point LocationOnScreen
        {
            get { return IExecute<Java.Awt.Point>("getLocationOnScreen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getPoint()"/> 
        /// </summary>
        public Java.Awt.Point Point
        {
            get { return IExecute<Java.Awt.Point>("getPoint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getX()"/> 
        /// </summary>
        public int X
        {
            get { return IExecute<int>("getX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getXOnScreen()"/> 
        /// </summary>
        public int XOnScreen
        {
            get { return IExecute<int>("getXOnScreen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getY()"/> 
        /// </summary>
        public int Y
        {
            get { return IExecute<int>("getY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#getYOnScreen()"/> 
        /// </summary>
        public int YOnScreen
        {
            get { return IExecute<int>("getYOnScreen"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#isPopupTrigger()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsPopupTrigger()
        {
            return IExecute<bool>("isPopupTrigger");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/event/MouseEvent.html#translatePoint(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void TranslatePoint(int arg0, int arg1)
        {
            IExecute("translatePoint", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}