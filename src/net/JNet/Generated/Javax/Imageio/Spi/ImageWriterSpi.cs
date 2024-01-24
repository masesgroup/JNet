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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Spi
{
    #region ImageWriterSpi
    public partial class ImageWriterSpi
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String[],java.lang.String[],java.lang.String[],java.lang.String,java.lang.Class[],java.lang.String[],boolean,java.lang.String,java.lang.String,java.lang.String[],java.lang.String[],boolean,java.lang.String,java.lang.String,java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="Java.Lang.Class"/></param>
        /// <param name="arg7"><see cref="string"/></param>
        /// <param name="arg8"><see cref="bool"/></param>
        /// <param name="arg9"><see cref="string"/></param>
        /// <param name="arg10"><see cref="string"/></param>
        /// <param name="arg11"><see cref="string"/></param>
        /// <param name="arg12"><see cref="string"/></param>
        /// <param name="arg13"><see cref="bool"/></param>
        /// <param name="arg14"><see cref="string"/></param>
        /// <param name="arg15"><see cref="string"/></param>
        /// <param name="arg16"><see cref="string"/></param>
        /// <param name="arg17"><see cref="string"/></param>
        public ImageWriterSpi(string arg0, string arg1, string[] arg2, string[] arg3, string[] arg4, string arg5, Java.Lang.Class[] arg6, string[] arg7, bool arg8, string arg9, string arg10, string[] arg11, string[] arg12, bool arg13, string arg14, string arg15, string[] arg16, string[] arg17)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16, arg17)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#getImageReaderSpiNames()"/> 
        /// </summary>
        public string[] ImageReaderSpiNames
        {
            get { return IExecuteArray<string>("getImageReaderSpiNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#getOutputTypes()"/> 
        /// </summary>
        public Java.Lang.Class[] OutputTypes
        {
            get { return IExecuteArray<Java.Lang.Class>("getOutputTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#canEncodeImage(javax.imageio.ImageTypeSpecifier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEncodeImage(Javax.Imageio.ImageTypeSpecifier arg0)
        {
            return IExecute<bool>("canEncodeImage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#createWriterInstance(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Imageio.ImageWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.ImageWriter CreateWriterInstance(object arg0)
        {
            return IExecute<Javax.Imageio.ImageWriter>("createWriterInstance", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#canEncodeImage(java.awt.image.RenderedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool CanEncodeImage(Java.Awt.ImageNs.RenderedImage arg0)
        {
            return IExecute<bool>("canEncodeImage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#isFormatLossless()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFormatLossless()
        {
            return IExecute<bool>("isFormatLossless");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#isOwnWriter(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsOwnWriter(Javax.Imageio.ImageWriter arg0)
        {
            return IExecute<bool>("isOwnWriter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageWriterSpi.html#createWriterInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Imageio.ImageWriter"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.ImageWriter CreateWriterInstance()
        {
            return IExecute<Javax.Imageio.ImageWriter>("createWriterInstance");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}