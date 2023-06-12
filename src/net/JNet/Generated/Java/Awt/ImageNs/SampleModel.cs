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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region SampleModel
    public partial class SampleModel
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#%3Cinit%3E(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public SampleModel(int arg0, int arg1, int arg2, int arg3)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getDataType()"/> 
        /// </summary>
        public int DataType
        {
            get { return IExecute<int>("getDataType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecute<int>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getNumBands()"/> 
        /// </summary>
        public int NumBands
        {
            get { return IExecute<int>("getNumBands"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getNumDataElements()"/> 
        /// </summary>
        public int NumDataElements
        {
            get { return IExecute<int>("getNumDataElements"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getSampleSize()"/> 
        /// </summary>
        public int[] SampleSize
        {
            get { return IExecuteArray<int>("getSampleSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getTransferType()"/> 
        /// </summary>
        public int TransferType
        {
            get { return IExecute<int>("getTransferType"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecute<int>("getWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getSample(int,int,int,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSample(int arg0, int arg1, int arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            return IExecute<int>("getSample", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getSampleSize(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetSampleSize(int arg0)
        {
            return IExecute<int>("getSampleSize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#createDataBuffer()"/>
        /// </summary>

        /// <returns><see cref="Java.Awt.ImageNs.DataBuffer"/></returns>
        public Java.Awt.ImageNs.DataBuffer CreateDataBuffer()
        {
            return IExecute<Java.Awt.ImageNs.DataBuffer>("createDataBuffer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#createCompatibleSampleModel(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.SampleModel"/></returns>
        public Java.Awt.ImageNs.SampleModel CreateCompatibleSampleModel(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.SampleModel>("createCompatibleSampleModel", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#createSubsetSampleModel(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.SampleModel"/></returns>
        public Java.Awt.ImageNs.SampleModel CreateSubsetSampleModel(int[] arg0)
        {
            return IExecute<Java.Awt.ImageNs.SampleModel>("createSubsetSampleModel", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getDataElements(int,int,java.lang.Object,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(int arg0, int arg1, object arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            return IExecute("getDataElements", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setDataElements(int,int,java.lang.Object,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="object"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetDataElements(int arg0, int arg1, object arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            IExecute("setDataElements", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setSample(int,int,int,int,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetSample(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.DataBuffer arg4)
        {
            IExecute("setSample", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getSampleDouble(int,int,int,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="double"/></returns>
        public double GetSampleDouble(int arg0, int arg1, int arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            return IExecute<double>("getSampleDouble", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getPixel(int,int,double[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetPixel(int arg0, int arg1, double[] arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            return IExecuteArray<double>("getPixel", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getPixels(int,int,int,int,double[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetPixels(int arg0, int arg1, int arg2, int arg3, double[] arg4, Java.Awt.ImageNs.DataBuffer arg5)
        {
            return IExecuteArray<double>("getPixels", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getSamples(int,int,int,int,int,double[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="double"/></returns>
        public double[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, double[] arg5, Java.Awt.ImageNs.DataBuffer arg6)
        {
            return IExecuteArray<double>("getSamples", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getSampleFloat(int,int,int,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetSampleFloat(int arg0, int arg1, int arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            return IExecute<float>("getSampleFloat", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getPixel(int,int,float[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetPixel(int arg0, int arg1, float[] arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            return IExecuteArray<float>("getPixel", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getPixels(int,int,int,int,float[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetPixels(int arg0, int arg1, int arg2, int arg3, float[] arg4, Java.Awt.ImageNs.DataBuffer arg5)
        {
            return IExecuteArray<float>("getPixels", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getSamples(int,int,int,int,int,float[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="float"/></returns>
        public float[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, float[] arg5, Java.Awt.ImageNs.DataBuffer arg6)
        {
            return IExecuteArray<float>("getSamples", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getPixel(int,int,int[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetPixel(int arg0, int arg1, int[] arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            return IExecuteArray<int>("getPixel", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getPixels(int,int,int,int,int[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetPixels(int arg0, int arg1, int arg2, int arg3, int[] arg4, Java.Awt.ImageNs.DataBuffer arg5)
        {
            return IExecuteArray<int>("getPixels", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getSamples(int,int,int,int,int,int[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int[] GetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, Java.Awt.ImageNs.DataBuffer arg6)
        {
            return IExecuteArray<int>("getSamples", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#getDataElements(int,int,int,int,java.lang.Object,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetDataElements(int arg0, int arg1, int arg2, int arg3, object arg4, Java.Awt.ImageNs.DataBuffer arg5)
        {
            return IExecute("getDataElements", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setDataElements(int,int,int,int,java.lang.Object,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="object"/></param>
        /// <param name="arg5"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetDataElements(int arg0, int arg1, int arg2, int arg3, object arg4, Java.Awt.ImageNs.DataBuffer arg5)
        {
            IExecute("setDataElements", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setPixel(int,int,double[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="double"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetPixel(int arg0, int arg1, double[] arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            IExecute("setPixel", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setPixel(int,int,float[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="float"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetPixel(int arg0, int arg1, float[] arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            IExecute("setPixel", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setPixel(int,int,int[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetPixel(int arg0, int arg1, int[] arg2, Java.Awt.ImageNs.DataBuffer arg3)
        {
            IExecute("setPixel", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setPixels(int,int,int,int,double[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="double"/></param>
        /// <param name="arg5"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, double[] arg4, Java.Awt.ImageNs.DataBuffer arg5)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setPixels(int,int,int,int,float[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="float"/></param>
        /// <param name="arg5"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, float[] arg4, Java.Awt.ImageNs.DataBuffer arg5)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setPixels(int,int,int,int,int[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, int[] arg4, Java.Awt.ImageNs.DataBuffer arg5)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setSample(int,int,int,double,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="double"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetSample(int arg0, int arg1, int arg2, double arg3, Java.Awt.ImageNs.DataBuffer arg4)
        {
            IExecute("setSample", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setSample(int,int,int,float,java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="float"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetSample(int arg0, int arg1, int arg2, float arg3, Java.Awt.ImageNs.DataBuffer arg4)
        {
            IExecute("setSample", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setSamples(int,int,int,int,int,double[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="double"/></param>
        /// <param name="arg6"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, double[] arg5, Java.Awt.ImageNs.DataBuffer arg6)
        {
            IExecute("setSamples", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setSamples(int,int,int,int,int,float[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="float"/></param>
        /// <param name="arg6"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, float[] arg5, Java.Awt.ImageNs.DataBuffer arg6)
        {
            IExecute("setSamples", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/SampleModel.html#setSamples(int,int,int,int,int,int[],java.awt.image.DataBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="Java.Awt.ImageNs.DataBuffer"/></param>
        public void SetSamples(int arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, Java.Awt.ImageNs.DataBuffer arg6)
        {
            IExecute("setSamples", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}