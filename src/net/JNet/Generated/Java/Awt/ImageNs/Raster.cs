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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region Raster
    public partial class Raster
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createRaster(java.awt.image.SampleModel,java.awt.image.DataBuffer,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.SampleModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public static Java.Awt.ImageNs.Raster CreateRaster(Java.Awt.ImageNs.SampleModel arg0, Java.Awt.ImageNs.DataBuffer arg1, Java.Awt.Point arg2)
        {
            return SExecute<Java.Awt.ImageNs.Raster>(LocalBridgeClazz, "createRaster", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createBandedRaster(int,int,int,int,int[],int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateBandedRaster(int arg0, int arg1, int arg2, int arg3, int[] arg4, int[] arg5, Java.Awt.Point arg6)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createBandedRaster", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createBandedRaster(int,int,int,int,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateBandedRaster(int arg0, int arg1, int arg2, int arg3, Java.Awt.Point arg4)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createBandedRaster", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createBandedRaster(java.awt.image.DataBuffer,int,int,int,int[],int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateBandedRaster(Java.Awt.ImageNs.DataBuffer arg0, int arg1, int arg2, int arg3, int[] arg4, int[] arg5, Java.Awt.Point arg6)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createBandedRaster", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createInterleavedRaster(int,int,int,int,int,int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateInterleavedRaster(int arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, Java.Awt.Point arg6)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createInterleavedRaster", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createInterleavedRaster(int,int,int,int,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateInterleavedRaster(int arg0, int arg1, int arg2, int arg3, Java.Awt.Point arg4)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createInterleavedRaster", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createInterleavedRaster(java.awt.image.DataBuffer,int,int,int,int,int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateInterleavedRaster(Java.Awt.ImageNs.DataBuffer arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, Java.Awt.Point arg6)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createInterleavedRaster", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createPackedRaster(int,int,int,int,int,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreatePackedRaster(int arg0, int arg1, int arg2, int arg3, int arg4, Java.Awt.Point arg5)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createPackedRaster", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createPackedRaster(int,int,int,int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreatePackedRaster(int arg0, int arg1, int arg2, int[] arg3, Java.Awt.Point arg4)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createPackedRaster", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createPackedRaster(java.awt.image.DataBuffer,int,int,int,int[],java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreatePackedRaster(Java.Awt.ImageNs.DataBuffer arg0, int arg1, int arg2, int arg3, int[] arg4, Java.Awt.Point arg5)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createPackedRaster", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createPackedRaster(java.awt.image.DataBuffer,int,int,int,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreatePackedRaster(Java.Awt.ImageNs.DataBuffer arg0, int arg1, int arg2, int arg3, Java.Awt.Point arg4)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createPackedRaster", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createWritableRaster(java.awt.image.SampleModel,java.awt.image.DataBuffer,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.SampleModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <param name="arg2"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateWritableRaster(Java.Awt.ImageNs.SampleModel arg0, Java.Awt.ImageNs.DataBuffer arg1, Java.Awt.Point arg2)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createWritableRaster", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createWritableRaster(java.awt.image.SampleModel,java.awt.Point)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.SampleModel"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Point"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public static Java.Awt.ImageNs.WritableRaster CreateWritableRaster(Java.Awt.ImageNs.SampleModel arg0, Java.Awt.Point arg1)
        {
            return SExecute<Java.Awt.ImageNs.WritableRaster>(LocalBridgeClazz, "createWritableRaster", arg0, arg1);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getBounds()"/> 
        /// </summary>
        public Java.Awt.Rectangle Bounds
        {
            get { return IExecute<Java.Awt.Rectangle>("getBounds"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getDataBuffer()"/> 
        /// </summary>
        public Java.Awt.ImageNs.DataBuffer DataBuffer
        {
            get { return IExecute<Java.Awt.ImageNs.DataBuffer>("getDataBuffer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecute<int>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getMinX()"/> 
        /// </summary>
        public int MinX
        {
            get { return IExecute<int>("getMinX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getMinY()"/> 
        /// </summary>
        public int MinY
        {
            get { return IExecute<int>("getMinY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getNumBands()"/> 
        /// </summary>
        public int NumBands
        {
            get { return IExecute<int>("getNumBands"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getNumDataElements()"/> 
        /// </summary>
        public int NumDataElements
        {
            get { return IExecute<int>("getNumDataElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getParent()"/> 
        /// </summary>
        public Java.Awt.ImageNs.Raster Parent
        {
            get { return IExecute<Java.Awt.ImageNs.Raster>("getParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.SampleModel SampleModel
        {
            get { return IExecute<Java.Awt.ImageNs.SampleModel>("getSampleModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleModelTranslateX()"/> 
        /// </summary>
        public int SampleModelTranslateX
        {
            get { return IExecute<int>("getSampleModelTranslateX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleModelTranslateY()"/> 
        /// </summary>
        public int SampleModelTranslateY
        {
            get { return IExecute<int>("getSampleModelTranslateY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getTransferType()"/> 
        /// </summary>
        public int TransferType
        {
            get { return IExecute<int>("getTransferType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecute<int>("getWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleDouble(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetSampleDouble(int arg0, int arg1, int arg2)
        {
            return IExecute<double>("getSampleDouble", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixel(int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetPixel(int arg0, int arg1, double[] arg2)
        {
            return IExecuteArray<double>("getPixel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixels(int,int,int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetPixels(int arg0, int arg1, int arg2, int arg3, double[] arg4)
        {
            return IExecuteArray<double>("getPixels", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSamples(int,int,int,int,int,double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, double[] arg5)
        {
            return IExecuteArray<double>("getSamples", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSampleFloat(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetSampleFloat(int arg0, int arg1, int arg2)
        {
            return IExecute<float>("getSampleFloat", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixel(int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetPixel(int arg0, int arg1, float[] arg2)
        {
            return IExecuteArray<float>("getPixel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixels(int,int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetPixels(int arg0, int arg1, int arg2, int arg3, float[] arg4)
        {
            return IExecuteArray<float>("getPixels", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSamples(int,int,int,int,int,float[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, float[] arg5)
        {
            return IExecuteArray<float>("getSamples", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSample(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSample(int arg0, int arg1, int arg2)
        {
            return IExecute<int>("getSample", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixel(int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetPixel(int arg0, int arg1, int[] arg2)
        {
            return IExecuteArray<int>("getPixel", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getPixels(int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetPixels(int arg0, int arg1, int arg2, int arg3, int[] arg4)
        {
            return IExecuteArray<int>("getPixels", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getSamples(int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5)
        {
            return IExecuteArray<int>("getSamples", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createChild(int,int,int,int,int,int,int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster CreateChild(int arg0, int arg1, int arg2, int arg3, int arg4, int arg5, int[] arg6)
        {
            return IExecute<Java.Awt.ImageNs.Raster>("createChild", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createTranslatedChild(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster CreateTranslatedChild(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Raster>("createTranslatedChild", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createCompatibleWritableRaster()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster()
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createCompatibleWritableRaster(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster(int arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createCompatibleWritableRaster(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#createCompatibleWritableRaster(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CreateCompatibleWritableRaster(Java.Awt.Rectangle arg0)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("createCompatibleWritableRaster", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getDataElements(int,int,int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(int arg0, int arg1, int arg2, int arg3, object arg4)
        {
            return IExecute("getDataElements", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/Raster.html#getDataElements(int,int,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(int arg0, int arg1, object arg2)
        {
            return IExecute("getDataElements", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}