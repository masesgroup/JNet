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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Imageio
{
    #region ImageWriteParam
    public partial class ImageWriteParam
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#%3Cinit%3E(java.util.Locale)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Locale"/></param>
        public ImageWriteParam(Java.Util.Locale arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#MODE_COPY_FROM_METADATA"/>
        /// </summary>
        public static int MODE_COPY_FROM_METADATA { get { return SGetField<int>(LocalBridgeClazz, "MODE_COPY_FROM_METADATA"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#MODE_DEFAULT"/>
        /// </summary>
        public static int MODE_DEFAULT { get { return SGetField<int>(LocalBridgeClazz, "MODE_DEFAULT"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#MODE_DISABLED"/>
        /// </summary>
        public static int MODE_DISABLED { get { return SGetField<int>(LocalBridgeClazz, "MODE_DISABLED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#MODE_EXPLICIT"/>
        /// </summary>
        public static int MODE_EXPLICIT { get { return SGetField<int>(LocalBridgeClazz, "MODE_EXPLICIT"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#canOffsetTiles()"/> 
        /// </summary>
        public bool CanOffsetTiles
        {
            get { return IExecute<bool>("canOffsetTiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#canWriteCompressed()"/> 
        /// </summary>
        public bool CanWriteCompressed
        {
            get { return IExecute<bool>("canWriteCompressed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#canWriteProgressive()"/> 
        /// </summary>
        public bool CanWriteProgressive
        {
            get { return IExecute<bool>("canWriteProgressive"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#canWriteTiles()"/> 
        /// </summary>
        public bool CanWriteTiles
        {
            get { return IExecute<bool>("canWriteTiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setCompressionMode(int)"/>
        /// </summary>
        public int CompressionMode
        {
            get { return IExecute<int>("getCompressionMode"); } set { IExecute("setCompressionMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionQuality()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setCompressionQuality(float)"/>
        /// </summary>
        public float CompressionQuality
        {
            get { return IExecute<float>("getCompressionQuality"); } set { IExecute("setCompressionQuality", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionQualityDescriptions()"/> 
        /// </summary>
        public string[] CompressionQualityDescriptions
        {
            get { return IExecuteArray<string>("getCompressionQualityDescriptions"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionQualityValues()"/> 
        /// </summary>
        public float[] CompressionQualityValues
        {
            get { return IExecuteArray<float>("getCompressionQualityValues"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionType()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setCompressionType(java.lang.String)"/>
        /// </summary>
        public string CompressionType
        {
            get { return IExecute<string>("getCompressionType"); } set { IExecute("setCompressionType", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getCompressionTypes()"/> 
        /// </summary>
        public string[] CompressionTypes
        {
            get { return IExecuteArray<string>("getCompressionTypes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#isCompressionLossless()"/> 
        /// </summary>
        public bool IsCompressionLossless
        {
            get { return IExecute<bool>("isCompressionLossless"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getLocale()"/> 
        /// </summary>
        public Java.Util.Locale Locale
        {
            get { return IExecute<Java.Util.Locale>("getLocale"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getLocalizedCompressionTypeName()"/> 
        /// </summary>
        public string LocalizedCompressionTypeName
        {
            get { return IExecute<string>("getLocalizedCompressionTypeName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getPreferredTileSizes()"/> 
        /// </summary>
        public Java.Awt.Dimension[] PreferredTileSizes
        {
            get { return IExecuteArray<Java.Awt.Dimension>("getPreferredTileSizes"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getProgressiveMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setProgressiveMode(int)"/>
        /// </summary>
        public int ProgressiveMode
        {
            get { return IExecute<int>("getProgressiveMode"); } set { IExecute("setProgressiveMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTileGridXOffset()"/> 
        /// </summary>
        public int TileGridXOffset
        {
            get { return IExecute<int>("getTileGridXOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTileGridYOffset()"/> 
        /// </summary>
        public int TileGridYOffset
        {
            get { return IExecute<int>("getTileGridYOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTileHeight()"/> 
        /// </summary>
        public int TileHeight
        {
            get { return IExecute<int>("getTileHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTileWidth()"/> 
        /// </summary>
        public int TileWidth
        {
            get { return IExecute<int>("getTileWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getTilingMode()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setTilingMode(int)"/>
        /// </summary>
        public int TilingMode
        {
            get { return IExecute<int>("getTilingMode"); } set { IExecute("setTilingMode", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#getBitRate(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <returns><see cref="float"/></returns>
        public float GetBitRate(float arg0)
        {
            return IExecute<float>("getBitRate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#setTiling(int,int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        public void SetTiling(int arg0, int arg1, int arg2, int arg3)
        {
            IExecute("setTiling", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#unsetCompression()"/>
        /// </summary>
        public void UnsetCompression()
        {
            IExecute("unsetCompression");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/ImageWriteParam.html#unsetTiling()"/>
        /// </summary>
        public void UnsetTiling()
        {
            IExecute("unsetTiling");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}