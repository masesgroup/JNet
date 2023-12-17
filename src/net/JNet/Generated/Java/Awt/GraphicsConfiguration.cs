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

namespace Java.Awt
{
    #region GraphicsConfiguration
    public partial class GraphicsConfiguration
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#getBufferCapabilities()"/> 
        /// </summary>
        public Java.Awt.BufferCapabilities BufferCapabilities
        {
            get { return IExecute<Java.Awt.BufferCapabilities>("getBufferCapabilities"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#getColorModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecute<Java.Awt.ImageNs.ColorModel>("getColorModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#getDefaultTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform DefaultTransform
        {
            get { return IExecute<Java.Awt.Geom.AffineTransform>("getDefaultTransform"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#getDevice()"/> 
        /// </summary>
        public Java.Awt.GraphicsDevice Device
        {
            get { return IExecute<Java.Awt.GraphicsDevice>("getDevice"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#getImageCapabilities()"/> 
        /// </summary>
        public Java.Awt.ImageCapabilities ImageCapabilities
        {
            get { return IExecute<Java.Awt.ImageCapabilities>("getImageCapabilities"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#getNormalizingTransform()"/> 
        /// </summary>
        public Java.Awt.Geom.AffineTransform NormalizingTransform
        {
            get { return IExecute<Java.Awt.Geom.AffineTransform>("getNormalizingTransform"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#getColorModel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.ColorModel"/></returns>
        public Java.Awt.ImageNs.ColorModel GetColorModel(int arg0)
        {
            return IExecute<Java.Awt.ImageNs.ColorModel>("getColorModel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#isTranslucencyCapable()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsTranslucencyCapable()
        {
            return IExecute<bool>("isTranslucencyCapable");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#createCompatibleImage(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateCompatibleImage(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createCompatibleImage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#createCompatibleImage(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        public Java.Awt.ImageNs.BufferedImage CreateCompatibleImage(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("createCompatibleImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#createCompatibleVolatileImage(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.VolatileImage"/></returns>
        public Java.Awt.ImageNs.VolatileImage CreateCompatibleVolatileImage(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.ImageNs.VolatileImage>("createCompatibleVolatileImage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#createCompatibleVolatileImage(int,int,java.awt.ImageCapabilities,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageCapabilities"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.VolatileImage"/></returns>
        /// <exception cref="Java.Awt.AWTException"/>
        public Java.Awt.ImageNs.VolatileImage CreateCompatibleVolatileImage(int arg0, int arg1, Java.Awt.ImageCapabilities arg2, int arg3)
        {
            return IExecute<Java.Awt.ImageNs.VolatileImage>("createCompatibleVolatileImage", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#createCompatibleVolatileImage(int,int,java.awt.ImageCapabilities)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageCapabilities"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.VolatileImage"/></returns>
        /// <exception cref="Java.Awt.AWTException"/>
        public Java.Awt.ImageNs.VolatileImage CreateCompatibleVolatileImage(int arg0, int arg1, Java.Awt.ImageCapabilities arg2)
        {
            return IExecute<Java.Awt.ImageNs.VolatileImage>("createCompatibleVolatileImage", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/GraphicsConfiguration.html#createCompatibleVolatileImage(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.VolatileImage"/></returns>
        public Java.Awt.ImageNs.VolatileImage CreateCompatibleVolatileImage(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.VolatileImage>("createCompatibleVolatileImage", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}