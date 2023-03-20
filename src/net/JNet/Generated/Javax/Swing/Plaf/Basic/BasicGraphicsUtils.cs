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
*  This file is generated by MASES.JNetReflector (ver. 1.5.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Swing.Plaf.Basic
{
    #region BasicGraphicsUtils
    public partial class BasicGraphicsUtils
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#getEtchedInsets()"/> 
        /// </summary>
        public static Java.Awt.Insets EtchedInsets
        {
            get { return SExecute<Java.Awt.Insets>("getEtchedInsets"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#getGrooveInsets()"/> 
        /// </summary>
        public static Java.Awt.Insets GrooveInsets
        {
            get { return SExecute<Java.Awt.Insets>("getGrooveInsets"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#getStringWidth(javax.swing.JComponent,java.awt.FontMetrics,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <returns><see cref="float"/></returns>
        public static float GetStringWidth(Javax.Swing.JComponent arg0, Java.Awt.FontMetrics arg1, string arg2)
        {
            return SExecute<float>("getStringWidth", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#getPreferredButtonSize(javax.swing.AbstractButton,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.AbstractButton"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public static Java.Awt.Dimension GetPreferredButtonSize(Javax.Swing.AbstractButton arg0, int arg1)
        {
            return SExecute<Java.Awt.Dimension>("getPreferredButtonSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#getClippedString(javax.swing.JComponent,java.awt.FontMetrics,java.lang.String,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.FontMetrics"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="string"/></returns>
        public static string GetClippedString(Javax.Swing.JComponent arg0, Java.Awt.FontMetrics arg1, string arg2, int arg3)
        {
            return SExecute<string>("getClippedString", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawBezel(java.awt.Graphics,int,int,int,int,boolean,boolean,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <param name="arg7"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg9"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg10"><see cref="Java.Awt.Color"/></param>
        public static void DrawBezel(Java.Awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, bool arg5, bool arg6, Java.Awt.Color arg7, Java.Awt.Color arg8, Java.Awt.Color arg9, Java.Awt.Color arg10)
        {
            SExecute("drawBezel", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawDashedRect(java.awt.Graphics,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void DrawDashedRect(Java.Awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4)
        {
            SExecute("drawDashedRect", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawEtchedRect(java.awt.Graphics,int,int,int,int,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg7"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Color"/></param>
        public static void DrawEtchedRect(Java.Awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, Java.Awt.Color arg5, Java.Awt.Color arg6, Java.Awt.Color arg7, Java.Awt.Color arg8)
        {
            SExecute("drawEtchedRect", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawGroove(java.awt.Graphics,int,int,int,int,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Color"/></param>
        public static void DrawGroove(Java.Awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, Java.Awt.Color arg5, Java.Awt.Color arg6)
        {
            SExecute("drawGroove", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawLoweredBezel(java.awt.Graphics,int,int,int,int,java.awt.Color,java.awt.Color,java.awt.Color,java.awt.Color)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg7"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg8"><see cref="Java.Awt.Color"/></param>
        public static void DrawLoweredBezel(Java.Awt.Graphics arg0, int arg1, int arg2, int arg3, int arg4, Java.Awt.Color arg5, Java.Awt.Color arg6, Java.Awt.Color arg7, Java.Awt.Color arg8)
        {
            SExecute("drawLoweredBezel", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawString(java.awt.Graphics,java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void DrawString(Java.Awt.Graphics arg0, string arg1, int arg2, int arg3, int arg4)
        {
            SExecute("drawString", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawString(javax.swing.JComponent,java.awt.Graphics2D,java.lang.String,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        public static void DrawString(Javax.Swing.JComponent arg0, Java.Awt.Graphics2D arg1, string arg2, float arg3, float arg4)
        {
            SExecute("drawString", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawStringUnderlineCharAt(java.awt.Graphics,java.lang.String,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public static void DrawStringUnderlineCharAt(Java.Awt.Graphics arg0, string arg1, int arg2, int arg3, int arg4)
        {
            SExecute("drawStringUnderlineCharAt", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/plaf/basic/BasicGraphicsUtils.html#drawStringUnderlineCharAt(javax.swing.JComponent,java.awt.Graphics2D,java.lang.String,int,float,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Swing.JComponent"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics2D"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        public static void DrawStringUnderlineCharAt(Javax.Swing.JComponent arg0, Java.Awt.Graphics2D arg1, string arg2, int arg3, float arg4, float arg5)
        {
            SExecute("drawStringUnderlineCharAt", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}