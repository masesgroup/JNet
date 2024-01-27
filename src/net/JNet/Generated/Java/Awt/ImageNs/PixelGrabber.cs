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
    #region PixelGrabber
    public partial class PixelGrabber
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#%3Cinit%3E(java.awt.Image,int,int,int,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="bool"/></param>
        public PixelGrabber(Java.Awt.Image arg0, int arg1, int arg2, int arg3, int arg4, bool arg5)
            : base(arg0, arg1, arg2, arg3, arg4, arg5)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#%3Cinit%3E(java.awt.Image,int,int,int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Image"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public PixelGrabber(Java.Awt.Image arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, int arg6, int arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#%3Cinit%3E(java.awt.image.ImageProducer,int,int,int,int,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.ImageProducer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="int"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public PixelGrabber(Java.Awt.ImageNs.ImageProducer arg0, int arg1, int arg2, int arg3, int arg4, int[] arg5, int arg6, int arg7)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getColorModel()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setColorModel(java.awt.image.ColorModel)"/>
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecute<Java.Awt.ImageNs.ColorModel>("getColorModel"); } set { IExecute("setColorModel", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecute<int>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getPixels()"/> 
        /// </summary>
        public object Pixels
        {
            get { return IExecute("getPixels"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecute<int>("getWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#grabPixels()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool GrabPixels()
        {
            return IExecute<bool>("grabPixels");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#grabPixels(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Lang.InterruptedException"/>
        public bool GrabPixels(long arg0)
        {
            return IExecute<bool>("grabPixels", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#getStatus()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int GetStatus()
        {
            return IExecute<int>("getStatus");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#status()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Status()
        {
            return IExecute<int>("status");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#abortGrabbing()"/>
        /// </summary>
        public void AbortGrabbing()
        {
            IExecute("abortGrabbing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#imageComplete(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void ImageComplete(int arg0)
        {
            IExecute("imageComplete", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#startGrabbing()"/>
        /// </summary>
        public void StartGrabbing()
        {
            IExecute("startGrabbing");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setDimensions(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void SetDimensions(int arg0, int arg1)
        {
            IExecute("setDimensions", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setHints(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetHints(int arg0)
        {
            IExecute("setHints", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setPixels(int,int,int,int,java.awt.image.ColorModel,byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg5"><see cref="byte"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, byte[] arg5, int arg6, int arg7)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setPixels(int,int,int,int,java.awt.image.ColorModel,int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Java.Awt.ImageNs.ColorModel"/></param>
        /// <param name="arg5"><see cref="int"/></param>
        /// <param name="arg6"><see cref="int"/></param>
        /// <param name="arg7"><see cref="int"/></param>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, int[] arg5, int arg6, int arg7)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/PixelGrabber.html#setProperties(java.util.Hashtable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Hashtable"/></param>
        public void SetProperties(Java.Util.Hashtable<object, object> arg0)
        {
            IExecute("setProperties", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}