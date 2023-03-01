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

namespace Javax.Imageio
{
    #region ImageReader
    public partial class ImageReader
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getAvailableLocales()"/> 
        /// </summary>
        public Java.Util.Locale[] AvailableLocales
        {
            get { return IExecuteArray<Java.Util.Locale>("getAvailableLocales"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getDefaultReadParam()"/> 
        /// </summary>
        public Javax.Imageio.ImageReadParam DefaultReadParam
        {
            get { return IExecute<Javax.Imageio.ImageReadParam>("getDefaultReadParam"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getFormatName()"/> 
        /// </summary>
        public string FormatName
        {
            get { return IExecute<string>("getFormatName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getInput()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#setInput(java.lang.Object)"/>
        /// </summary>
        public object Input
        {
            get { return IExecute("getInput"); } set { IExecute("setInput", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getLocale()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#setLocale(java.util.Locale)"/>
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecute<Java.Util.Locale>("getLocale"); } set { IExecute("setLocale", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getMinIndex()"/> 
        /// </summary>
        public int MinIndex
        {
            get { return IExecute<int>("getMinIndex"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getOriginatingProvider()"/> 
        /// </summary>
        public Javax.Imageio.Spi.ImageReaderSpi OriginatingProvider
        {
            get { return IExecute<Javax.Imageio.Spi.ImageReaderSpi>("getOriginatingProvider"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getStreamMetadata()"/> 
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadata StreamMetadata
        {
            get { return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getStreamMetadata"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetHeight(int arg0)
        {
            return IExecute<int>("getHeight", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getNumImages(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetNumImages(bool arg0)
        {
            return IExecute<int>("getNumImages", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetWidth(int arg0)
        {
            return IExecute<int>("getWidth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#read(int,javax.imageio.ImageReadParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageReadParam"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.BufferedImage Read(int arg0, Javax.Imageio.ImageReadParam arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getImageTypes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Iterator GetImageTypes(int arg0)
        {
            return IExecute<Java.Util.Iterator>("getImageTypes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getImageMetadata(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.Metadata.IIOMetadata GetImageMetadata(int arg0)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getImageMetadata", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#canReadRaster()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool CanReadRaster()
        {
            return IExecute<bool>("canReadRaster");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#hasThumbnails(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool HasThumbnails(int arg0)
        {
            return IExecute<bool>("hasThumbnails", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#isIgnoringMetadata()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsIgnoringMetadata()
        {
            return IExecute<bool>("isIgnoringMetadata");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#isImageTiled(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsImageTiled(int arg0)
        {
            return IExecute<bool>("isImageTiled", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#isRandomAccessEasy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool IsRandomAccessEasy(int arg0)
        {
            return IExecute<bool>("isRandomAccessEasy", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#isSeekForwardOnly()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsSeekForwardOnly()
        {
            return IExecute<bool>("isSeekForwardOnly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readerSupportsThumbnails()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool ReaderSupportsThumbnails()
        {
            return IExecute<bool>("readerSupportsThumbnails");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getAspectRatio(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float GetAspectRatio(int arg0)
        {
            return IExecute<float>("getAspectRatio", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getNumThumbnails(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetNumThumbnails(int arg0)
        {
            return IExecute<int>("getNumThumbnails", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getThumbnailHeight(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetThumbnailHeight(int arg0, int arg1)
        {
            return IExecute<int>("getThumbnailHeight", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getThumbnailWidth(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetThumbnailWidth(int arg0, int arg1)
        {
            return IExecute<int>("getThumbnailWidth", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getTileGridXOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetTileGridXOffset(int arg0)
        {
            return IExecute<int>("getTileGridXOffset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getTileGridYOffset(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetTileGridYOffset(int arg0)
        {
            return IExecute<int>("getTileGridYOffset", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getTileHeight(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetTileHeight(int arg0)
        {
            return IExecute<int>("getTileHeight", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getTileWidth(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int GetTileWidth(int arg0)
        {
            return IExecute<int>("getTileWidth", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#read(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.BufferedImage Read(int arg0)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readThumbnail(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.BufferedImage ReadThumbnail(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("readThumbnail", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readTile(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.BufferedImage ReadTile(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("readTile", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readRaster(int,javax.imageio.ImageReadParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageReadParam"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.Raster ReadRaster(int arg0, Javax.Imageio.ImageReadParam arg1)
        {
            return IExecute<Java.Awt.ImageNs.Raster>("readRaster", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readTileRaster(int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.Raster ReadTileRaster(int arg0, int arg1, int arg2)
        {
            return IExecute<Java.Awt.ImageNs.Raster>("readTileRaster", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readAsRenderedImage(int,javax.imageio.ImageReadParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageReadParam"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.RenderedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Awt.ImageNs.RenderedImage ReadAsRenderedImage(int arg0, Javax.Imageio.ImageReadParam arg1)
        {
            return IExecute<Java.Awt.ImageNs.RenderedImage>("readAsRenderedImage", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readAll(java.util.Iterator%3C? extends javax.imageio.ImageReadParam%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Util.Iterator ReadAll(Java.Util.Iterator arg0)
        {
            return IExecute<Java.Util.Iterator>("readAll", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#readAll(int,javax.imageio.ImageReadParam)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageReadParam"/></param>
        /// <returns><see cref="Javax.Imageio.IIOImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.IIOImage ReadAll(int arg0, Javax.Imageio.ImageReadParam arg1)
        {
            return IExecute<Javax.Imageio.IIOImage>("readAll", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getRawImageType(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Javax.Imageio.ImageTypeSpecifier"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.ImageTypeSpecifier GetRawImageType(int arg0)
        {
            return IExecute<Javax.Imageio.ImageTypeSpecifier>("getRawImageType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getImageMetadata(int,java.lang.String,java.util.Set%3Cjava.lang.String%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.Metadata.IIOMetadata GetImageMetadata(int arg0, string arg1, Java.Util.Set arg2)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getImageMetadata", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#getStreamMetadata(java.lang.String,java.util.Set%3Cjava.lang.String%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadata"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Javax.Imageio.Metadata.IIOMetadata GetStreamMetadata(string arg0, Java.Util.Set arg1)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getStreamMetadata", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#abort()"/>
        /// </summary>
        public void Abort()
        {
            IExecute("abort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#addIIOReadProgressListener(javax.imageio.event.IIOReadProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadProgressListener"/></param>
        public void AddIIOReadProgressListener(Javax.Imageio.Event.IIOReadProgressListener arg0)
        {
            IExecute("addIIOReadProgressListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#addIIOReadUpdateListener(javax.imageio.event.IIOReadUpdateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadUpdateListener"/></param>
        public void AddIIOReadUpdateListener(Javax.Imageio.Event.IIOReadUpdateListener arg0)
        {
            IExecute("addIIOReadUpdateListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#addIIOReadWarningListener(javax.imageio.event.IIOReadWarningListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadWarningListener"/></param>
        public void AddIIOReadWarningListener(Javax.Imageio.Event.IIOReadWarningListener arg0)
        {
            IExecute("addIIOReadWarningListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#dispose()"/>
        /// </summary>
        public new void Dispose()
        {
            IExecute("dispose");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeAllIIOReadProgressListeners()"/>
        /// </summary>
        public void RemoveAllIIOReadProgressListeners()
        {
            IExecute("removeAllIIOReadProgressListeners");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeAllIIOReadUpdateListeners()"/>
        /// </summary>
        public void RemoveAllIIOReadUpdateListeners()
        {
            IExecute("removeAllIIOReadUpdateListeners");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeAllIIOReadWarningListeners()"/>
        /// </summary>
        public void RemoveAllIIOReadWarningListeners()
        {
            IExecute("removeAllIIOReadWarningListeners");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeIIOReadProgressListener(javax.imageio.event.IIOReadProgressListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadProgressListener"/></param>
        public void RemoveIIOReadProgressListener(Javax.Imageio.Event.IIOReadProgressListener arg0)
        {
            IExecute("removeIIOReadProgressListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeIIOReadUpdateListener(javax.imageio.event.IIOReadUpdateListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadUpdateListener"/></param>
        public void RemoveIIOReadUpdateListener(Javax.Imageio.Event.IIOReadUpdateListener arg0)
        {
            IExecute("removeIIOReadUpdateListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#removeIIOReadWarningListener(javax.imageio.event.IIOReadWarningListener)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Event.IIOReadWarningListener"/></param>
        public void RemoveIIOReadWarningListener(Javax.Imageio.Event.IIOReadWarningListener arg0)
        {
            IExecute("removeIIOReadWarningListener", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#setInput(java.lang.Object,boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        public void SetInput(object arg0, bool arg1, bool arg2)
        {
            IExecute("setInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageReader.html#setInput(java.lang.Object,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public void SetInput(object arg0, bool arg1)
        {
            IExecute("setInput", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}