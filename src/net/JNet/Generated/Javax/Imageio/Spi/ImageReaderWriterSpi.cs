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

namespace Javax.Imageio.Spi
{
    #region ImageReaderWriterSpi
    public partial class ImageReaderWriterSpi
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#%3Cinit%3E(java.lang.String,java.lang.String,java.lang.String[],java.lang.String[],java.lang.String[],java.lang.String,boolean,java.lang.String,java.lang.String,java.lang.String[],java.lang.String[],boolean,java.lang.String,java.lang.String,java.lang.String[],java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="string"/></param>
        /// <param name="arg3"><see cref="string"/></param>
        /// <param name="arg4"><see cref="string"/></param>
        /// <param name="arg5"><see cref="string"/></param>
        /// <param name="arg6"><see cref="bool"/></param>
        /// <param name="arg7"><see cref="string"/></param>
        /// <param name="arg8"><see cref="string"/></param>
        /// <param name="arg9"><see cref="string"/></param>
        /// <param name="arg10"><see cref="string"/></param>
        /// <param name="arg11"><see cref="bool"/></param>
        /// <param name="arg12"><see cref="string"/></param>
        /// <param name="arg13"><see cref="string"/></param>
        /// <param name="arg14"><see cref="string"/></param>
        /// <param name="arg15"><see cref="string"/></param>
        public ImageReaderWriterSpi(string arg0, string arg1, string[] arg2, string[] arg3, string[] arg4, string arg5, bool arg6, string arg7, string arg8, string[] arg9, string[] arg10, bool arg11, string arg12, string arg13, string[] arg14, string[] arg15)
            : base(arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getExtraImageMetadataFormatNames()"/> 
        /// </summary>
        public string[] ExtraImageMetadataFormatNames
        {
            get { return IExecuteArray<string>("getExtraImageMetadataFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getExtraStreamMetadataFormatNames()"/> 
        /// </summary>
        public string[] ExtraStreamMetadataFormatNames
        {
            get { return IExecuteArray<string>("getExtraStreamMetadataFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getFileSuffixes()"/> 
        /// </summary>
        public string[] FileSuffixes
        {
            get { return IExecuteArray<string>("getFileSuffixes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getFormatNames()"/> 
        /// </summary>
        public string[] FormatNames
        {
            get { return IExecuteArray<string>("getFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getMIMETypes()"/> 
        /// </summary>
        public string[] MIMETypes
        {
            get { return IExecuteArray<string>("getMIMETypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getNativeImageMetadataFormatName()"/> 
        /// </summary>
        public string NativeImageMetadataFormatName
        {
            get { return IExecute<string>("getNativeImageMetadataFormatName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getNativeStreamMetadataFormatName()"/> 
        /// </summary>
        public string NativeStreamMetadataFormatName
        {
            get { return IExecute<string>("getNativeStreamMetadataFormatName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getPluginClassName()"/> 
        /// </summary>
        public string PluginClassName
        {
            get { return IExecute<string>("getPluginClassName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#isStandardImageMetadataFormatSupported()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsStandardImageMetadataFormatSupported()
        {
            return IExecute<bool>("isStandardImageMetadataFormatSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#isStandardStreamMetadataFormatSupported()"/>
        /// </summary>
        
        /// <returns><see cref="bool"/></returns>
        public bool IsStandardStreamMetadataFormatSupported()
        {
            return IExecute<bool>("isStandardStreamMetadataFormatSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getImageMetadataFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/></returns>
        public Javax.Imageio.Metadata.IIOMetadataFormat GetImageMetadataFormat(string arg0)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadataFormat>("getImageMetadataFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/spi/ImageReaderWriterSpi.html#getStreamMetadataFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/></returns>
        public Javax.Imageio.Metadata.IIOMetadataFormat GetStreamMetadataFormat(string arg0)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadataFormat>("getStreamMetadataFormat", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}