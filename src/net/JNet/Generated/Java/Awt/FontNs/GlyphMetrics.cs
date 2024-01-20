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

namespace Java.Awt.FontNs
{
    #region GlyphMetrics
    public partial class GlyphMetrics
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#%3Cinit%3E(boolean,float,float,java.awt.geom.Rectangle2D,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg4"><see cref="byte"/></param>
        public GlyphMetrics(bool arg0, float arg1, float arg2, Java.Awt.Geom.Rectangle2D arg3, byte arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#%3Cinit%3E(float,java.awt.geom.Rectangle2D,byte)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg2"><see cref="byte"/></param>
        public GlyphMetrics(float arg0, Java.Awt.Geom.Rectangle2D arg1, byte arg2)
            : base(arg0, arg1, arg2)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#COMBINING"/>
        /// </summary>
        public static byte COMBINING { get { return SGetField<byte>(LocalBridgeClazz, "COMBINING"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#COMPONENT"/>
        /// </summary>
        public static byte COMPONENT { get { return SGetField<byte>(LocalBridgeClazz, "COMPONENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#LIGATURE"/>
        /// </summary>
        public static byte LIGATURE { get { return SGetField<byte>(LocalBridgeClazz, "LIGATURE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#STANDARD"/>
        /// </summary>
        public static byte STANDARD { get { return SGetField<byte>(LocalBridgeClazz, "STANDARD"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#WHITESPACE"/>
        /// </summary>
        public static byte WHITESPACE { get { return SGetField<byte>(LocalBridgeClazz, "WHITESPACE"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getAdvance()"/> 
        /// </summary>
        public float Advance
        {
            get { return IExecute<float>("getAdvance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getAdvanceX()"/> 
        /// </summary>
        public float AdvanceX
        {
            get { return IExecute<float>("getAdvanceX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getAdvanceY()"/> 
        /// </summary>
        public float AdvanceY
        {
            get { return IExecute<float>("getAdvanceY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getBounds2D()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D Bounds2D
        {
            get { return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds2D"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getLSB()"/> 
        /// </summary>
        public float LSB
        {
            get { return IExecute<float>("getLSB"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getRSB()"/> 
        /// </summary>
        public float RSB
        {
            get { return IExecute<float>("getRSB"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#getType()"/> 
        /// </summary>
        public int Type
        {
            get { return IExecute<int>("getType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isCombining()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsCombining()
        {
            return IExecute<bool>("isCombining");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isComponent()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsComponent()
        {
            return IExecute<bool>("isComponent");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isLigature()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsLigature()
        {
            return IExecute<bool>("isLigature");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isStandard()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsStandard()
        {
            return IExecute<bool>("isStandard");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GlyphMetrics.html#isWhitespace()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsWhitespace()
        {
            return IExecute<bool>("isWhitespace");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}