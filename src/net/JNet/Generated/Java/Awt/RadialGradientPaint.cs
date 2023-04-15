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

namespace Java.Awt
{
    #region RadialGradientPaint
    public partial class RadialGradientPaint
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#%3Cinit%3E(float,float,float,float,float,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg7"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        public RadialGradientPaint(float arg0, float arg1, float arg2, float arg3, float arg4, float[] arg5, Java.Awt.Color[] arg6, Java.Awt.MultipleGradientPaint.CycleMethod arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#%3Cinit%3E(float,float,float,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg5"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        public RadialGradientPaint(float arg0, float arg1, float arg2, float[] arg3, Java.Awt.Color[] arg4, Java.Awt.MultipleGradientPaint.CycleMethod arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#%3Cinit%3E(float,float,float,float[],java.awt.Color[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        public RadialGradientPaint(float arg0, float arg1, float arg2, float[] arg3, Java.Awt.Color[] arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,float,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg4"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        public RadialGradientPaint(Java.Awt.Geom.Point2D arg0, float arg1, float[] arg2, Java.Awt.Color[] arg3, Java.Awt.MultipleGradientPaint.CycleMethod arg4)
            : base(arg0, arg1, arg2, arg3, arg4)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,float,float[],java.awt.Color[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.Color"/></param>
        public RadialGradientPaint(Java.Awt.Geom.Point2D arg0, float arg1, float[] arg2, Java.Awt.Color[] arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,float,java.awt.geom.Point2D,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod,java.awt.MultipleGradientPaint.ColorSpaceType,java.awt.geom.AffineTransform)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg5"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        /// <param name="arg6"><see cref="Java.Awt.MultipleGradientPaint.ColorSpaceType"/></param>
        /// <param name="arg7"><see cref="Java.Awt.Geom.AffineTransform"/></param>
        public RadialGradientPaint(Java.Awt.Geom.Point2D arg0, float arg1, Java.Awt.Geom.Point2D arg2, float[] arg3, Java.Awt.Color[] arg4, Java.Awt.MultipleGradientPaint.CycleMethod arg5, Java.Awt.MultipleGradientPaint.ColorSpaceType arg6, Java.Awt.Geom.AffineTransform arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#%3Cinit%3E(java.awt.geom.Point2D,float,java.awt.geom.Point2D,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg5"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        public RadialGradientPaint(Java.Awt.Geom.Point2D arg0, float arg1, Java.Awt.Geom.Point2D arg2, float[] arg3, Java.Awt.Color[] arg4, Java.Awt.MultipleGradientPaint.CycleMethod arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#%3Cinit%3E(java.awt.geom.Rectangle2D,float[],java.awt.Color[],java.awt.MultipleGradientPaint.CycleMethod)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Rectangle2D"/></param>
        /// <param name="arg1"><see cref="float"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Color"/></param>
        /// <param name="arg3"><see cref="Java.Awt.MultipleGradientPaint.CycleMethod"/></param>
        public RadialGradientPaint(Java.Awt.Geom.Rectangle2D arg0, float[] arg1, Java.Awt.Color[] arg2, Java.Awt.MultipleGradientPaint.CycleMethod arg3)
            : base(arg0, arg1, arg2, arg3)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#getCenterPoint()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D CenterPoint
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getCenterPoint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#getFocusPoint()"/> 
        /// </summary>
        public Java.Awt.Geom.Point2D FocusPoint
        {
            get { return IExecute<Java.Awt.Geom.Point2D>("getFocusPoint"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/RadialGradientPaint.html#getRadius()"/> 
        /// </summary>
        public float Radius
        {
            get { return IExecute<float>("getRadius"); }
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}