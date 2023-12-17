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
*  This file is generated by MASES.JNetReflector (ver. 2.1.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing
{
    #region DebugGraphics
    public partial class DebugGraphics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#%3Cinit%3E(java.awt.Graphics,javax.swing.JComponent)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.JComponent"/></param>
        public DebugGraphics(Java.Awt.Graphics arg0, Javax.Swing.JComponent arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#%3Cinit%3E(java.awt.Graphics)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        public DebugGraphics(Java.Awt.Graphics arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#BUFFERED_OPTION"/>
        /// </summary>
        public static int BUFFERED_OPTION { get { return SGetField<int>(LocalBridgeClazz, "BUFFERED_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#FLASH_OPTION"/>
        /// </summary>
        public static int FLASH_OPTION { get { return SGetField<int>(LocalBridgeClazz, "FLASH_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#LOG_OPTION"/>
        /// </summary>
        public static int LOG_OPTION { get { return SGetField<int>(LocalBridgeClazz, "LOG_OPTION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#NONE_OPTION"/>
        /// </summary>
        public static int NONE_OPTION { get { return SGetField<int>(LocalBridgeClazz, "NONE_OPTION"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#flashCount()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int FlashCount()
        {
            return SExecute<int>(LocalBridgeClazz, "flashCount");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#flashTime()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public static int FlashTime()
        {
            return SExecute<int>(LocalBridgeClazz, "flashTime");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#flashColor()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.Color"/></returns>
        public static Java.Awt.Color FlashColor()
        {
            return SExecute<Java.Awt.Color>(LocalBridgeClazz, "flashColor");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#logStream()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.PrintStream"/></returns>
        public static Java.Io.PrintStream LogStream()
        {
            return SExecute<Java.Io.PrintStream>(LocalBridgeClazz, "logStream");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#setFlashColor(java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Color"/></param>
        public static void SetFlashColor(Java.Awt.Color arg0)
        {
            SExecute(LocalBridgeClazz, "setFlashColor", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#setFlashCount(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void SetFlashCount(int arg0)
        {
            SExecute(LocalBridgeClazz, "setFlashCount", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#setFlashTime(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public static void SetFlashTime(int arg0)
        {
            SExecute(LocalBridgeClazz, "setFlashTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#setLogStream(java.io.PrintStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.PrintStream"/></param>
        public static void SetLogStream(Java.Io.PrintStream arg0)
        {
            SExecute(LocalBridgeClazz, "setLogStream", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#getDebugOptions()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#setDebugOptions(int)"/>
        /// </summary>
        public int DebugOptions
        {
            get { return IExecute<int>("getDebugOptions"); } set { IExecute("setDebugOptions", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/DebugGraphics.html#isDrawingBuffer()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDrawingBuffer()
        {
            return IExecute<bool>("isDrawingBuffer");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}