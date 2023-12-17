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

namespace Javax.Imageio
{
    #region ImageWriter
    public partial class ImageWriter
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getAvailableLocales()"/> 
        /// </summary>
        public Java.Util.Locale[] AvailableLocales
        {
            get { return IExecuteArray<Java.Util.Locale>("getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getDefaultWriteParam()"/> 
        /// </summary>
        public Javax.Imageio.ImageWriteParam DefaultWriteParam
        {
            get { return IExecute<Javax.Imageio.ImageWriteParam>("getDefaultWriteParam"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#setLocale(java.util.Locale)"/>
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecute<Java.Util.Locale>("getLocale"); } set { IExecute("setLocale", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getOriginatingProvider()"/> 
        /// </summary>
        public Javax.Imageio.Spi.ImageWriterSpi OriginatingProvider
        {
            get { return IExecute<Javax.Imageio.Spi.ImageWriterSpi>("getOriginatingProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getOutput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#setOutput(java.lang.Object)"/>
        /// </summary>
        public object Output
        {
            get { return IExecute("getOutput"); } set { IExecute("setOutput", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#convertImageMetadata(javax.imageio.metadata.IIOMetadata,javax.imageio.ImageTypeSpecifier,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        public Javax.Imageio.Metadata.IIOMetadata ConvertImageMetadata(Javax.Imageio.Metadata.IIOMetadata arg0, Javax.Imageio.ImageTypeSpecifier arg1, Javax.Imageio.ImageWriteParam arg2)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("convertImageMetadata", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#convertStreamMetadata(javax.imageio.metadata.IIOMetadata,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        public Javax.Imageio.Metadata.IIOMetadata ConvertStreamMetadata(Javax.Imageio.Metadata.IIOMetadata arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("convertStreamMetadata", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getDefaultImageMetadata(javax.imageio.ImageTypeSpecifier,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        public Javax.Imageio.Metadata.IIOMetadata GetDefaultImageMetadata(Javax.Imageio.ImageTypeSpecifier arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getDefaultImageMetadata", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getDefaultStreamMetadata(javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        public Javax.Imageio.Metadata.IIOMetadata GetDefaultStreamMetadata(Javax.Imageio.ImageWriteParam arg0)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getDefaultStreamMetadata", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#write(javax.imageio.metadata.IIOMetadata,javax.imageio.IIOImage,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.IIOImage"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Javax.Imageio.Metadata.IIOMetadata arg0, Javax.Imageio.IIOImage arg1, Javax.Imageio.ImageWriteParam arg2)
        {
            IExecute("write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canInsertEmpty(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanInsertEmpty(int arg0)
        {
            return IExecute<bool>("canInsertEmpty", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canInsertImage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanInsertImage(int arg0)
        {
            return IExecute<bool>("canInsertImage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canRemoveImage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanRemoveImage(int arg0)
        {
            return IExecute<bool>("canRemoveImage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canReplaceImageMetadata(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanReplaceImageMetadata(int arg0)
        {
            return IExecute<bool>("canReplaceImageMetadata", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canReplacePixels(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanReplacePixels(int arg0)
        {
            return IExecute<bool>("canReplacePixels", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canReplaceStreamMetadata()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanReplaceStreamMetadata()
        {
            return IExecute<bool>("canReplaceStreamMetadata");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canWriteEmpty()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CanWriteEmpty()
        {
            return IExecute<bool>("canWriteEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canWriteRasters()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool CanWriteRasters()
        {
            return IExecute<bool>("canWriteRasters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#canWriteSequence()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool CanWriteSequence()
        {
            return IExecute<bool>("canWriteSequence");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getNumThumbnailsSupported(javax.imageio.ImageTypeSpecifier,javax.imageio.ImageWriteParam,javax.imageio.metadata.IIOMetadata,javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg3"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <returns><see cref="int"/></returns>
        public int GetNumThumbnailsSupported(Javax.Imageio.ImageTypeSpecifier arg0, Javax.Imageio.ImageWriteParam arg1, Javax.Imageio.Metadata.IIOMetadata arg2, Javax.Imageio.Metadata.IIOMetadata arg3)
        {
            return IExecute<int>("getNumThumbnailsSupported", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#getPreferredThumbnailSizes(javax.imageio.ImageTypeSpecifier,javax.imageio.ImageWriteParam,javax.imageio.metadata.IIOMetadata,javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg3"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <returns><see cref="Java.Awt.Dimension"/></returns>
        public Java.Awt.Dimension[] GetPreferredThumbnailSizes(Javax.Imageio.ImageTypeSpecifier arg0, Javax.Imageio.ImageWriteParam arg1, Javax.Imageio.Metadata.IIOMetadata arg2, Javax.Imageio.Metadata.IIOMetadata arg3)
        {
            return IExecuteArray<Java.Awt.Dimension>("getPreferredThumbnailSizes", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecute("abort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#addIIOWriteProgressListener(javax.imageio.event.IIOWriteProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOWriteProgressListener"/></param>
        public void AddIIOWriteProgressListener(Javax.Imageio.Event.IIOWriteProgressListener arg0)
        {
            IExecute("addIIOWriteProgressListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#addIIOWriteWarningListener(javax.imageio.event.IIOWriteWarningListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOWriteWarningListener"/></param>
        public void AddIIOWriteWarningListener(Javax.Imageio.Event.IIOWriteWarningListener arg0)
        {
            IExecute("addIIOWriteWarningListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecute("dispose");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#endInsertEmpty()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void EndInsertEmpty()
        {
            IExecute("endInsertEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#endReplacePixels()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void EndReplacePixels()
        {
            IExecute("endReplacePixels");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#endWriteEmpty()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void EndWriteEmpty()
        {
            IExecute("endWriteEmpty");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#endWriteSequence()"/>
        /// </summary>

        /// <exception cref="Java.Io.IOException"/>
        public void EndWriteSequence()
        {
            IExecute("endWriteSequence");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#prepareInsertEmpty(int,javax.imageio.ImageTypeSpecifier,int,int,javax.imageio.metadata.IIOMetadata,java.util.List,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg5"><see cref="Java.Util.List"/></param>
        /// <param name="arg6"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <typeparam name="Arg5ExtendsJava_Awt_ImageNs_BufferedImage"><see cref="Java.Awt.ImageNs.BufferedImage"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        public void PrepareInsertEmpty<Arg5ExtendsJava_Awt_ImageNs_BufferedImage>(int arg0, Javax.Imageio.ImageTypeSpecifier arg1, int arg2, int arg3, Javax.Imageio.Metadata.IIOMetadata arg4, Java.Util.List<Arg5ExtendsJava_Awt_ImageNs_BufferedImage> arg5, Javax.Imageio.ImageWriteParam arg6) where Arg5ExtendsJava_Awt_ImageNs_BufferedImage: Java.Awt.ImageNs.BufferedImage
        {
            IExecute("prepareInsertEmpty", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#prepareReplacePixels(int,java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Java.Awt.Rectangle"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void PrepareReplacePixels(int arg0, Java.Awt.Rectangle arg1)
        {
            IExecute("prepareReplacePixels", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#prepareWriteEmpty(javax.imageio.metadata.IIOMetadata,javax.imageio.ImageTypeSpecifier,int,int,javax.imageio.metadata.IIOMetadata,java.util.List,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <param name="arg4"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <param name="arg5"><see cref="Java.Util.List"/></param>
        /// <param name="arg6"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <typeparam name="Arg5ExtendsJava_Awt_ImageNs_BufferedImage"><see cref="Java.Awt.ImageNs.BufferedImage"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        public void PrepareWriteEmpty<Arg5ExtendsJava_Awt_ImageNs_BufferedImage>(Javax.Imageio.Metadata.IIOMetadata arg0, Javax.Imageio.ImageTypeSpecifier arg1, int arg2, int arg3, Javax.Imageio.Metadata.IIOMetadata arg4, Java.Util.List<Arg5ExtendsJava_Awt_ImageNs_BufferedImage> arg5, Javax.Imageio.ImageWriteParam arg6) where Arg5ExtendsJava_Awt_ImageNs_BufferedImage: Java.Awt.ImageNs.BufferedImage
        {
            IExecute("prepareWriteEmpty", arg0, arg1, arg2, arg3, arg4, arg5, arg6);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#prepareWriteSequence(javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void PrepareWriteSequence(Javax.Imageio.Metadata.IIOMetadata arg0)
        {
            IExecute("prepareWriteSequence", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeAllIIOWriteProgressListeners()"/>
        /// </summary>
        public void RemoveAllIIOWriteProgressListeners()
        {
            IExecute("removeAllIIOWriteProgressListeners");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeAllIIOWriteWarningListeners()"/>
        /// </summary>
        public void RemoveAllIIOWriteWarningListeners()
        {
            IExecute("removeAllIIOWriteWarningListeners");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeIIOWriteProgressListener(javax.imageio.event.IIOWriteProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOWriteProgressListener"/></param>
        public void RemoveIIOWriteProgressListener(Javax.Imageio.Event.IIOWriteProgressListener arg0)
        {
            IExecute("removeIIOWriteProgressListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeIIOWriteWarningListener(javax.imageio.event.IIOWriteWarningListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOWriteWarningListener"/></param>
        public void RemoveIIOWriteWarningListener(Javax.Imageio.Event.IIOWriteWarningListener arg0)
        {
            IExecute("removeIIOWriteWarningListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#removeImage(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void RemoveImage(int arg0)
        {
            IExecute("removeImage", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#replaceImageMetadata(int,javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReplaceImageMetadata(int arg0, Javax.Imageio.Metadata.IIOMetadata arg1)
        {
            IExecute("replaceImageMetadata", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#replacePixels(java.awt.image.Raster,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReplacePixels(Java.Awt.ImageNs.Raster arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            IExecute("replacePixels", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#replacePixels(java.awt.image.RenderedImage,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReplacePixels(Java.Awt.ImageNs.RenderedImage arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            IExecute("replacePixels", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#replaceStreamMetadata(javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReplaceStreamMetadata(Javax.Imageio.Metadata.IIOMetadata arg0)
        {
            IExecute("replaceStreamMetadata", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#write(java.awt.image.RenderedImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Java.Awt.ImageNs.RenderedImage arg0)
        {
            IExecute("write", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#write(javax.imageio.IIOImage)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.IIOImage"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Write(Javax.Imageio.IIOImage arg0)
        {
            IExecute("write", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#writeInsert(int,javax.imageio.IIOImage,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.IIOImage"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteInsert(int arg0, Javax.Imageio.IIOImage arg1, Javax.Imageio.ImageWriteParam arg2)
        {
            IExecute("writeInsert", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriter.html#writeToSequence(javax.imageio.IIOImage,javax.imageio.ImageWriteParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.IIOImage"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriteParam"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteToSequence(Javax.Imageio.IIOImage arg0, Javax.Imageio.ImageWriteParam arg1)
        {
            IExecute("writeToSequence", arg0, arg1);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}