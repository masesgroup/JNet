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

namespace Java.Awt.ImageNs
{
    #region WritableRaster
    public partial class WritableRaster
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#getWritableParent()"/> 
        /// </summary>
        public Java.Awt.ImageNs.WritableRaster WritableParent
        {
            get { return IExecute<Java.Awt.ImageNs.WritableRaster>("getWritableParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#createWritableChild(int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateWritableChild(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int[] arg6)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("createWritableChild", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#createWritableTranslatedChild(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateWritableTranslatedChild(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("createWritableTranslatedChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setDataElements(int,int,int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        public void SetDataElements(int arg0, int arg1, int arg2, int arg3, object arg4)
        {
            IExecute("setDataElements", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setDataElements(int,int,java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.Raster"/></param>
        public void SetDataElements(int arg0, int arg1, Java.Awt.ImageNs.Raster arg2)
        {
            IExecute("setDataElements", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setDataElements(int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        public void SetDataElements(int arg0, int arg1, object arg2)
        {
            IExecute("setDataElements", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setPixel(int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        public void SetPixel(int arg0, int arg1, double[] arg2)
        {
            IExecute("setPixel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setPixel(int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        public void SetPixel(int arg0, int arg1, float[] arg2)
        {
            IExecute("setPixel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setPixel(int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetPixel(int arg0, int arg1, int[] arg2)
        {
            IExecute("setPixel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setPixels(int,int,int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, double[] arg4)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setPixels(int,int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, float[] arg4)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setPixels(int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, int[] arg4)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setRect(int,int,java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="Java.Awt.ImageNs.Raster"/></param>
        public void SetRect(int arg0, int arg1, Java.Awt.ImageNs.Raster arg2)
        {
            IExecute("setRect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setRect(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        public void SetRect(Java.Awt.ImageNs.Raster arg0)
        {
            IExecute("setRect", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setSample(int,int,int,double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        public void SetSample(int arg0, int arg1, int arg2, double arg3)
        {
            IExecute("setSample", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setSample(int,int,int,float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        public void SetSample(int arg0, int arg1, int arg2, float arg3)
        {
            IExecute("setSample", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setSample(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetSample(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setSample", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setSamples(int,int,int,int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        public void SetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, double[] arg5)
        {
            IExecute("setSamples", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setSamples(int,int,int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        public void SetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, float[] arg5)
        {
            IExecute("setSamples", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRaster.html#setSamples(int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        public void SetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5)
        {
            IExecute("setSamples", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}