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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.FontNs
{
    #region GraphicAttribute
    public partial class GraphicAttribute
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#BOTTOM_ALIGNMENT"/>
        /// </summary>
        public static int BOTTOM_ALIGNMENT { get { return SGetField<int>(LocalBridgeClazz, "BOTTOM_ALIGNMENT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#CENTER_BASELINE"/>
        /// </summary>
        public static int CENTER_BASELINE { get { return SGetField<int>(LocalBridgeClazz, "CENTER_BASELINE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#HANGING_BASELINE"/>
        /// </summary>
        public static int HANGING_BASELINE { get { return SGetField<int>(LocalBridgeClazz, "HANGING_BASELINE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#ROMAN_BASELINE"/>
        /// </summary>
        public static int ROMAN_BASELINE { get { return SGetField<int>(LocalBridgeClazz, "ROMAN_BASELINE"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#TOP_ALIGNMENT"/>
        /// </summary>
        public static int TOP_ALIGNMENT { get { return SGetField<int>(LocalBridgeClazz, "TOP_ALIGNMENT"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getAdvance()"/> 
        /// </summary>
        public float Advance
        {
            get { return IExecute<float>("getAdvance"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getAlignment()"/> 
        /// </summary>
        public int Alignment
        {
            get { return IExecute<int>("getAlignment"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getAscent()"/> 
        /// </summary>
        public float Ascent
        {
            get { return IExecute<float>("getAscent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Geom.Rectangle2D Bounds
        {
            get { return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getDescent()"/> 
        /// </summary>
        public float Descent
        {
            get { return IExecute<float>("getDescent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getJustificationInfo()"/> 
        /// </summary>
        public Java.Awt.FontNs.GlyphJustificationInfo JustificationInfo
        {
            get { return IExecute<Java.Awt.FontNs.GlyphJustificationInfo>("getJustificationInfo"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#draw(java.awt.Graphics2D,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void Draw(Java.Awt.Graphics2D arg0, float arg1, float arg2)
        {
            IExecute("draw", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/font/GraphicAttribute.html#getOutline(java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        /// <returns><see cref="Java.Awt.Shape"/></returns>
        public Java.Awt.Shape GetOutline(Java.Awt.Geom.AffineTransform arg0)
        {
            return IExecute<Java.Awt.Shape>("getOutline", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}