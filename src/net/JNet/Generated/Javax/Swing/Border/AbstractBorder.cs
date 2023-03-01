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

namespace Javax.Swing.Border
{
    #region AbstractBorder
    public partial class AbstractBorder
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Border.AbstractBorder"/> to <see cref="Javax.Swing.Border.Border"/>
        /// </summary>
        public static implicit operator Javax.Swing.Border.Border(Javax.Swing.Border.AbstractBorder t) => t.Cast<Javax.Swing.Border.Border>();
        /// <summary>
        /// Converter from <see cref="Javax.Swing.Border.AbstractBorder"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Javax.Swing.Border.AbstractBorder t) => t.Cast<Java.Io.Serializable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/AbstractBorder.html#getInteriorRectangle(java.awt.Component,javax.swing.border.Border,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Javax.Swing.Border.Border"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public static Java.Awt.Rectangle GetInteriorRectangle(Java.Awt.Component arg0, Javax.Swing.Border.Border arg1, int arg2, int arg3, int arg4, int arg5)
        {
            return SExecute<Java.Awt.Rectangle>("getInteriorRectangle", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/AbstractBorder.html#isBorderOpaque()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsBorderOpaque()
        {
            return IExecute<bool>("isBorderOpaque");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/AbstractBorder.html#getBaseline(java.awt.Component,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int GetBaseline(Java.Awt.Component arg0, int arg1, int arg2)
        {
            return IExecute<int>("getBaseline", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/AbstractBorder.html#getBaselineResizeBehavior(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Component.BaselineResizeBehavior"/></returns>
        public Java.Awt.Component.BaselineResizeBehavior GetBaselineResizeBehavior(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.Component.BaselineResizeBehavior>("getBaselineResizeBehavior", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/AbstractBorder.html#getBorderInsets(java.awt.Component,java.awt.Insets)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Insets"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetBorderInsets(Java.Awt.Component arg0, Java.Awt.Insets arg1)
        {
            return IExecute<Java.Awt.Insets>("getBorderInsets", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/AbstractBorder.html#getBorderInsets(java.awt.Component)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <returns><see cref="Java.Awt.Insets"/></returns>
        public Java.Awt.Insets GetBorderInsets(Java.Awt.Component arg0)
        {
            return IExecute<Java.Awt.Insets>("getBorderInsets", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/AbstractBorder.html#getInteriorRectangle(java.awt.Component,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.Rectangle"/></returns>
        public Java.Awt.Rectangle GetInteriorRectangle(Java.Awt.Component arg0, int arg1, int arg2, int arg3, int arg4)
        {
            return IExecute<Java.Awt.Rectangle>("getInteriorRectangle", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/swing/border/AbstractBorder.html#paintBorder(java.awt.Component,java.awt.Graphics,int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Component"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Graphics"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void PaintBorder(Java.Awt.Component arg0, Java.Awt.Graphics arg1, int arg2, int arg3, int arg4, int arg5)
        {
            IExecute("paintBorder", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}