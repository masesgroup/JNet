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

namespace Javax.Swing.Text
{
    #region TabStop
    public partial class TabStop
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#%3Cinit%3E(float,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public TabStop(float arg0, int arg1, int arg2)
            : base(arg0, arg1, arg2)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#%3Cinit%3E(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        public TabStop(float arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_BAR"/>
        /// </summary>
        public static int ALIGN_BAR { get { if (!_ALIGN_BARReady) { _ALIGN_BARContent = SGetField<int>(LocalBridgeClazz, "ALIGN_BAR"); _ALIGN_BARReady = true; } return _ALIGN_BARContent; } }
        private static int _ALIGN_BARContent = default;
        private static bool _ALIGN_BARReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_CENTER"/>
        /// </summary>
        public static int ALIGN_CENTER { get { if (!_ALIGN_CENTERReady) { _ALIGN_CENTERContent = SGetField<int>(LocalBridgeClazz, "ALIGN_CENTER"); _ALIGN_CENTERReady = true; } return _ALIGN_CENTERContent; } }
        private static int _ALIGN_CENTERContent = default;
        private static bool _ALIGN_CENTERReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_DECIMAL"/>
        /// </summary>
        public static int ALIGN_DECIMAL { get { if (!_ALIGN_DECIMALReady) { _ALIGN_DECIMALContent = SGetField<int>(LocalBridgeClazz, "ALIGN_DECIMAL"); _ALIGN_DECIMALReady = true; } return _ALIGN_DECIMALContent; } }
        private static int _ALIGN_DECIMALContent = default;
        private static bool _ALIGN_DECIMALReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_LEFT"/>
        /// </summary>
        public static int ALIGN_LEFT { get { if (!_ALIGN_LEFTReady) { _ALIGN_LEFTContent = SGetField<int>(LocalBridgeClazz, "ALIGN_LEFT"); _ALIGN_LEFTReady = true; } return _ALIGN_LEFTContent; } }
        private static int _ALIGN_LEFTContent = default;
        private static bool _ALIGN_LEFTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#ALIGN_RIGHT"/>
        /// </summary>
        public static int ALIGN_RIGHT { get { if (!_ALIGN_RIGHTReady) { _ALIGN_RIGHTContent = SGetField<int>(LocalBridgeClazz, "ALIGN_RIGHT"); _ALIGN_RIGHTReady = true; } return _ALIGN_RIGHTContent; } }
        private static int _ALIGN_RIGHTContent = default;
        private static bool _ALIGN_RIGHTReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_DOTS"/>
        /// </summary>
        public static int LEAD_DOTS { get { if (!_LEAD_DOTSReady) { _LEAD_DOTSContent = SGetField<int>(LocalBridgeClazz, "LEAD_DOTS"); _LEAD_DOTSReady = true; } return _LEAD_DOTSContent; } }
        private static int _LEAD_DOTSContent = default;
        private static bool _LEAD_DOTSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_EQUALS"/>
        /// </summary>
        public static int LEAD_EQUALS { get { if (!_LEAD_EQUALSReady) { _LEAD_EQUALSContent = SGetField<int>(LocalBridgeClazz, "LEAD_EQUALS"); _LEAD_EQUALSReady = true; } return _LEAD_EQUALSContent; } }
        private static int _LEAD_EQUALSContent = default;
        private static bool _LEAD_EQUALSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_HYPHENS"/>
        /// </summary>
        public static int LEAD_HYPHENS { get { if (!_LEAD_HYPHENSReady) { _LEAD_HYPHENSContent = SGetField<int>(LocalBridgeClazz, "LEAD_HYPHENS"); _LEAD_HYPHENSReady = true; } return _LEAD_HYPHENSContent; } }
        private static int _LEAD_HYPHENSContent = default;
        private static bool _LEAD_HYPHENSReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_NONE"/>
        /// </summary>
        public static int LEAD_NONE { get { if (!_LEAD_NONEReady) { _LEAD_NONEContent = SGetField<int>(LocalBridgeClazz, "LEAD_NONE"); _LEAD_NONEReady = true; } return _LEAD_NONEContent; } }
        private static int _LEAD_NONEContent = default;
        private static bool _LEAD_NONEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_THICKLINE"/>
        /// </summary>
        public static int LEAD_THICKLINE { get { if (!_LEAD_THICKLINEReady) { _LEAD_THICKLINEContent = SGetField<int>(LocalBridgeClazz, "LEAD_THICKLINE"); _LEAD_THICKLINEReady = true; } return _LEAD_THICKLINEContent; } }
        private static int _LEAD_THICKLINEContent = default;
        private static bool _LEAD_THICKLINEReady = false; // this is used because in case of generics 
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#LEAD_UNDERLINE"/>
        /// </summary>
        public static int LEAD_UNDERLINE { get { if (!_LEAD_UNDERLINEReady) { _LEAD_UNDERLINEContent = SGetField<int>(LocalBridgeClazz, "LEAD_UNDERLINE"); _LEAD_UNDERLINEReady = true; } return _LEAD_UNDERLINEContent; } }
        private static int _LEAD_UNDERLINEContent = default;
        private static bool _LEAD_UNDERLINEReady = false; // this is used because in case of generics 

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#getAlignment()"/> 
        /// </summary>
        public int Alignment
        {
            get { return IExecute<int>("getAlignment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#getLeader()"/> 
        /// </summary>
        public int Leader
        {
            get { return IExecute<int>("getLeader"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/text/TabStop.html#getPosition()"/> 
        /// </summary>
        public float Position
        {
            get { return IExecute<float>("getPosition"); }
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}