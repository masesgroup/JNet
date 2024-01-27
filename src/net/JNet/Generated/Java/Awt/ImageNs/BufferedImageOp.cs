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

namespace Java.Awt.ImageNs
{
    #region IBufferedImageOp
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IBufferedImageOp
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getRenderingHints()"/> 
        /// </summary>
        Java.Awt.RenderingHints RenderingHints { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getPoint2D(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        Java.Awt.Geom.Point2D GetPoint2D(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getBounds2D(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.BufferedImage arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#createCompatibleDestImage(java.awt.image.BufferedImage,java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        Java.Awt.ImageNs.BufferedImage CreateCompatibleDestImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.ColorModel arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#filter(java.awt.image.BufferedImage,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        Java.Awt.ImageNs.BufferedImage Filter(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImage arg1);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region BufferedImageOp
    public partial class BufferedImageOp : Java.Awt.ImageNs.IBufferedImageOp
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getRenderingHints()"/> 
        /// </summary>
        public Java.Awt.RenderingHints RenderingHints
        {
            get { return IExecute<Java.Awt.RenderingHints>("getRenderingHints"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getPoint2D(java.awt.geom.Point2D,java.awt.geom.Point2D)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Geom.Point2D"/></param>
        /// <returns><see cref="Java.Awt.Geom.Point2D"/></returns>
        public Java.Awt.Geom.Point2D GetPoint2D(Java.Awt.Geom.Point2D arg0, Java.Awt.Geom.Point2D arg1)
        {
            return IExecute<Java.Awt.Geom.Point2D>("getPoint2D", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#getBounds2D(java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.Geom.Rectangle2D"/></returns>
        public Java.Awt.Geom.Rectangle2D GetBounds2D(Java.Awt.ImageNs.BufferedImage arg0)
        {
            return IExecute<Java.Awt.Geom.Rectangle2D>("getBounds2D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#createCompatibleDestImage(java.awt.image.BufferedImage,java.awt.image.ColorModel)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateCompatibleDestImage(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.ColorModel arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createCompatibleDestImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/BufferedImageOp.html#filter(java.awt.image.BufferedImage,java.awt.image.BufferedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.BufferedImage"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage Filter(Java.Awt.ImageNs.BufferedImage arg0, Java.Awt.ImageNs.BufferedImage arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("filter", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}