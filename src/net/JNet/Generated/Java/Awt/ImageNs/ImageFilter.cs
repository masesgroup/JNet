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
    #region ImageFilter
    public partial class ImageFilter
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Awt.ImageNs.ImageConsumer(Java.Awt.ImageNs.ImageFilter t) => t.Cast<Java.Awt.ImageNs.ImageConsumer>();
        public static implicit operator Java.Lang.Cloneable(Java.Awt.ImageNs.ImageFilter t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageFilter.html#getFilterInstance(java.awt.image.ImageConsumer)
        /// </summary>
        public Java.Awt.ImageNs.ImageFilter GetFilterInstance(Java.Awt.ImageNs.ImageConsumer arg0)
        {
            return IExecute<Java.Awt.ImageNs.ImageFilter>("getFilterInstance", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageFilter.html#imageComplete(int)
        /// </summary>
        public void ImageComplete(int arg0)
        {
            IExecute("imageComplete", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageFilter.html#resendTopDownLeftRight(java.awt.image.ImageProducer)
        /// </summary>
        public void ResendTopDownLeftRight(Java.Awt.ImageNs.ImageProducer arg0)
        {
            IExecute("resendTopDownLeftRight", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageFilter.html#setColorModel(java.awt.image.ColorModel)
        /// </summary>
        public void SetColorModel(Java.Awt.ImageNs.ColorModel arg0)
        {
            IExecute("setColorModel", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageFilter.html#setDimensions(int,int)
        /// </summary>
        public void SetDimensions(int arg0, int arg1)
        {
            IExecute("setDimensions", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageFilter.html#setHints(int)
        /// </summary>
        public void SetHints(int arg0)
        {
            IExecute("setHints", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageFilter.html#setPixels(int,int,int,int,java.awt.image.ColorModel,byte[],int,int)
        /// </summary>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, byte[] arg5, int arg6, int arg7)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/ImageFilter.html#setPixels(int,int,int,int,java.awt.image.ColorModel,int[],int,int)
        /// </summary>
        public void SetPixels(int arg0, int arg1, int arg2, int arg3, Java.Awt.ImageNs.ColorModel arg4, int[] arg5, int arg6, int arg7)
        {
            IExecute("setPixels", arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}