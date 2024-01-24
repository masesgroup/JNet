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
*  This file is generated by MASES.JNetReflector (ver. 2.2.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio
{
    #region ImageIO
    public partial class ImageIO
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getCacheDirectory()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#setCacheDirectory(java.io.File)"/>
        /// </summary>
        public static Java.Io.File CacheDirectory
        {
            get { return SExecute<Java.Io.File>(LocalBridgeClazz, "getCacheDirectory"); } set { SExecute(LocalBridgeClazz, "setCacheDirectory", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getReaderFileSuffixes()"/> 
        /// </summary>
        public static string[] ReaderFileSuffixes
        {
            get { return SExecuteArray<string>(LocalBridgeClazz, "getReaderFileSuffixes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getReaderFormatNames()"/> 
        /// </summary>
        public static string[] ReaderFormatNames
        {
            get { return SExecuteArray<string>(LocalBridgeClazz, "getReaderFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getReaderMIMETypes()"/> 
        /// </summary>
        public static string[] ReaderMIMETypes
        {
            get { return SExecuteArray<string>(LocalBridgeClazz, "getReaderMIMETypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getUseCache()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#setUseCache(boolean)"/>
        /// </summary>
        public static bool UseCache
        {
            get { return SExecute<bool>(LocalBridgeClazz, "getUseCache"); } set { SExecute(LocalBridgeClazz, "setUseCache", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getWriterFileSuffixes()"/> 
        /// </summary>
        public static string[] WriterFileSuffixes
        {
            get { return SExecuteArray<string>(LocalBridgeClazz, "getWriterFileSuffixes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getWriterFormatNames()"/> 
        /// </summary>
        public static string[] WriterFormatNames
        {
            get { return SExecuteArray<string>(LocalBridgeClazz, "getWriterFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getWriterMIMETypes()"/> 
        /// </summary>
        public static string[] WriterMIMETypes
        {
            get { return SExecuteArray<string>(LocalBridgeClazz, "getWriterMIMETypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#write(java.awt.image.RenderedImage,java.lang.String,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static bool Write(Java.Awt.ImageNs.RenderedImage arg0, string arg1, Java.Io.File arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#write(java.awt.image.RenderedImage,java.lang.String,java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Io.OutputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static bool Write(Java.Awt.ImageNs.RenderedImage arg0, string arg1, Java.Io.OutputStream arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#write(java.awt.image.RenderedImage,java.lang.String,javax.imageio.stream.ImageOutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.RenderedImage"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Javax.Imageio.Stream.ImageOutputStream"/></param>
        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static bool Write(Java.Awt.ImageNs.RenderedImage arg0, string arg1, Javax.Imageio.Stream.ImageOutputStream arg2)
        {
            return SExecute<bool>(LocalBridgeClazz, "write", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#read(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ImageNs.BufferedImage Read(Java.Io.File arg0)
        {
            return SExecute<Java.Awt.ImageNs.BufferedImage>(LocalBridgeClazz, "read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#read(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ImageNs.BufferedImage Read(Java.Io.InputStream arg0)
        {
            return SExecute<Java.Awt.ImageNs.BufferedImage>(LocalBridgeClazz, "read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#read(java.net.URL)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URL"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ImageNs.BufferedImage Read(Java.Net.URL arg0)
        {
            return SExecute<Java.Awt.ImageNs.BufferedImage>(LocalBridgeClazz, "read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#read(javax.imageio.stream.ImageInputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Stream.ImageInputStream"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.BufferedImage"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Awt.ImageNs.BufferedImage Read(Javax.Imageio.Stream.ImageInputStream arg0)
        {
            return SExecute<Java.Awt.ImageNs.BufferedImage>(LocalBridgeClazz, "read", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReaders(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageReader> GetImageReaders(object arg0)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageReader>>(LocalBridgeClazz, "getImageReaders", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReadersByFormatName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageReader> GetImageReadersByFormatName(string arg0)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageReader>>(LocalBridgeClazz, "getImageReadersByFormatName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReadersByMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageReader> GetImageReadersByMIMEType(string arg0)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageReader>>(LocalBridgeClazz, "getImageReadersByMIMEType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReadersBySuffix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageReader> GetImageReadersBySuffix(string arg0)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageReader>>(LocalBridgeClazz, "getImageReadersBySuffix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageTranscoders(javax.imageio.ImageReader,javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <param name="arg1"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageTranscoder> GetImageTranscoders(Javax.Imageio.ImageReader arg0, Javax.Imageio.ImageWriter arg1)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageTranscoder>>(LocalBridgeClazz, "getImageTranscoders", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWriters(javax.imageio.ImageTypeSpecifier,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageTypeSpecifier"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageWriter> GetImageWriters(Javax.Imageio.ImageTypeSpecifier arg0, string arg1)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageWriter>>(LocalBridgeClazz, "getImageWriters", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWritersByFormatName(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageWriter> GetImageWritersByFormatName(string arg0)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageWriter>>(LocalBridgeClazz, "getImageWritersByFormatName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWritersByMIMEType(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageWriter> GetImageWritersByMIMEType(string arg0)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageWriter>>(LocalBridgeClazz, "getImageWritersByMIMEType", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWritersBySuffix(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator<Javax.Imageio.ImageWriter> GetImageWritersBySuffix(string arg0)
        {
            return SExecute<Java.Util.Iterator<Javax.Imageio.ImageWriter>>(LocalBridgeClazz, "getImageWritersBySuffix", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageReader(javax.imageio.ImageWriter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageWriter"/></param>
        /// <returns><see cref="Javax.Imageio.ImageReader"/></returns>
        public static Javax.Imageio.ImageReader GetImageReader(Javax.Imageio.ImageWriter arg0)
        {
            return SExecute<Javax.Imageio.ImageReader>(LocalBridgeClazz, "getImageReader", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#getImageWriter(javax.imageio.ImageReader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.ImageReader"/></param>
        /// <returns><see cref="Javax.Imageio.ImageWriter"/></returns>
        public static Javax.Imageio.ImageWriter GetImageWriter(Javax.Imageio.ImageReader arg0)
        {
            return SExecute<Javax.Imageio.ImageWriter>(LocalBridgeClazz, "getImageWriter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#createImageInputStream(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Imageio.Stream.ImageInputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Imageio.Stream.ImageInputStream CreateImageInputStream(object arg0)
        {
            return SExecute<Javax.Imageio.Stream.ImageInputStream>(LocalBridgeClazz, "createImageInputStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#createImageOutputStream(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="Javax.Imageio.Stream.ImageOutputStream"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Javax.Imageio.Stream.ImageOutputStream CreateImageOutputStream(object arg0)
        {
            return SExecute<Javax.Imageio.Stream.ImageOutputStream>(LocalBridgeClazz, "createImageOutputStream", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageIO.html#scanForPlugins()"/>
        /// </summary>
        public static void ScanForPlugins()
        {
            SExecute(LocalBridgeClazz, "scanForPlugins");
        }

        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}