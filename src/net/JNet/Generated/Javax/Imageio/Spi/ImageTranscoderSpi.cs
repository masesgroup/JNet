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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio.Spi
{
    #region ImageTranscoderSpi
    public partial class ImageTranscoderSpi
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageTranscoderSpi.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        public ImageTranscoderSpi(Java.Lang.String arg0, Java.Lang.String arg1)
            : base(arg0, arg1)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageTranscoderSpi.html#getReaderServiceProviderName()"/> 
        /// </summary>
        public Java.Lang.String ReaderServiceProviderName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getReaderServiceProviderName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageTranscoderSpi.html#getWriterServiceProviderName()"/> 
        /// </summary>
        public Java.Lang.String WriterServiceProviderName
        {
            get { return IExecuteWithSignature<Java.Lang.String>("getWriterServiceProviderName", "()Ljava/lang/String;"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageTranscoderSpi.html#createTranscoderInstance()"/>
        /// </summary>

        /// <returns><see cref="Javax.Imageio.ImageTranscoder"/></returns>
        public Javax.Imageio.ImageTranscoder CreateTranscoderInstance()
        {
            return IExecuteWithSignature<Javax.Imageio.ImageTranscoder>("createTranscoderInstance", "()Ljavax/imageio/ImageTranscoder;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}