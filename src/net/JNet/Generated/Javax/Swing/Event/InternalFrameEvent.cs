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

namespace Javax.Swing.Event
{
    #region InternalFrameEvent
    public partial class InternalFrameEvent
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#%3Cinit%3E(javax.swing.JInternalFrame,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JInternalFrame"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public InternalFrameEvent(Javax.Swing.JInternalFrame arg0, int arg1)
            : base(arg0, arg1)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_ACTIVATED"/>
        /// </summary>
        public static int INTERNAL_FRAME_ACTIVATED { get { if (!_INTERNAL_FRAME_ACTIVATEDReady) { _INTERNAL_FRAME_ACTIVATEDContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_ACTIVATED"); _INTERNAL_FRAME_ACTIVATEDReady = true; } return _INTERNAL_FRAME_ACTIVATEDContent; } }
        private static int _INTERNAL_FRAME_ACTIVATEDContent = default;
        private static bool _INTERNAL_FRAME_ACTIVATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_CLOSED"/>
        /// </summary>
        public static int INTERNAL_FRAME_CLOSED { get { if (!_INTERNAL_FRAME_CLOSEDReady) { _INTERNAL_FRAME_CLOSEDContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_CLOSED"); _INTERNAL_FRAME_CLOSEDReady = true; } return _INTERNAL_FRAME_CLOSEDContent; } }
        private static int _INTERNAL_FRAME_CLOSEDContent = default;
        private static bool _INTERNAL_FRAME_CLOSEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_CLOSING"/>
        /// </summary>
        public static int INTERNAL_FRAME_CLOSING { get { if (!_INTERNAL_FRAME_CLOSINGReady) { _INTERNAL_FRAME_CLOSINGContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_CLOSING"); _INTERNAL_FRAME_CLOSINGReady = true; } return _INTERNAL_FRAME_CLOSINGContent; } }
        private static int _INTERNAL_FRAME_CLOSINGContent = default;
        private static bool _INTERNAL_FRAME_CLOSINGReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_DEACTIVATED"/>
        /// </summary>
        public static int INTERNAL_FRAME_DEACTIVATED { get { if (!_INTERNAL_FRAME_DEACTIVATEDReady) { _INTERNAL_FRAME_DEACTIVATEDContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_DEACTIVATED"); _INTERNAL_FRAME_DEACTIVATEDReady = true; } return _INTERNAL_FRAME_DEACTIVATEDContent; } }
        private static int _INTERNAL_FRAME_DEACTIVATEDContent = default;
        private static bool _INTERNAL_FRAME_DEACTIVATEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_DEICONIFIED"/>
        /// </summary>
        public static int INTERNAL_FRAME_DEICONIFIED { get { if (!_INTERNAL_FRAME_DEICONIFIEDReady) { _INTERNAL_FRAME_DEICONIFIEDContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_DEICONIFIED"); _INTERNAL_FRAME_DEICONIFIEDReady = true; } return _INTERNAL_FRAME_DEICONIFIEDContent; } }
        private static int _INTERNAL_FRAME_DEICONIFIEDContent = default;
        private static bool _INTERNAL_FRAME_DEICONIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_FIRST"/>
        /// </summary>
        public static int INTERNAL_FRAME_FIRST { get { if (!_INTERNAL_FRAME_FIRSTReady) { _INTERNAL_FRAME_FIRSTContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_FIRST"); _INTERNAL_FRAME_FIRSTReady = true; } return _INTERNAL_FRAME_FIRSTContent; } }
        private static int _INTERNAL_FRAME_FIRSTContent = default;
        private static bool _INTERNAL_FRAME_FIRSTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_ICONIFIED"/>
        /// </summary>
        public static int INTERNAL_FRAME_ICONIFIED { get { if (!_INTERNAL_FRAME_ICONIFIEDReady) { _INTERNAL_FRAME_ICONIFIEDContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_ICONIFIED"); _INTERNAL_FRAME_ICONIFIEDReady = true; } return _INTERNAL_FRAME_ICONIFIEDContent; } }
        private static int _INTERNAL_FRAME_ICONIFIEDContent = default;
        private static bool _INTERNAL_FRAME_ICONIFIEDReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_LAST"/>
        /// </summary>
        public static int INTERNAL_FRAME_LAST { get { if (!_INTERNAL_FRAME_LASTReady) { _INTERNAL_FRAME_LASTContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_LAST"); _INTERNAL_FRAME_LASTReady = true; } return _INTERNAL_FRAME_LASTContent; } }
        private static int _INTERNAL_FRAME_LASTContent = default;
        private static bool _INTERNAL_FRAME_LASTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#INTERNAL_FRAME_OPENED"/>
        /// </summary>
        public static int INTERNAL_FRAME_OPENED { get { if (!_INTERNAL_FRAME_OPENEDReady) { _INTERNAL_FRAME_OPENEDContent = SGetField<int>(LocalBridgeClazz, "INTERNAL_FRAME_OPENED"); _INTERNAL_FRAME_OPENEDReady = true; } return _INTERNAL_FRAME_OPENEDContent; } }
        private static int _INTERNAL_FRAME_OPENEDContent = default;
        private static bool _INTERNAL_FRAME_OPENEDReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/event/InternalFrameEvent.html#getInternalFrame()"/> 
        /// </summary>
        public Javax.Swing.JInternalFrame InternalFrame
        {
            get { return IExecute<Javax.Swing.JInternalFrame>("getInternalFrame"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}