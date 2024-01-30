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
*  This file is generated by MASES.JNetReflector (ver. 2.2.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Awt.ImageNs
{
    #region IRenderedImage
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IRenderedImage
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getColorModel()"/> 
        /// </summary>
        Java.Awt.ImageNs.ColorModel ColorModel { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getData()"/> 
        /// </summary>
        Java.Awt.ImageNs.Raster Data { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getHeight()"/> 
        /// </summary>
        int Height { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinTileX()"/> 
        /// </summary>
        int MinTileX { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinTileY()"/> 
        /// </summary>
        int MinTileY { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinX()"/> 
        /// </summary>
        int MinX { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinY()"/> 
        /// </summary>
        int MinY { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getNumXTiles()"/> 
        /// </summary>
        int NumXTiles { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getNumYTiles()"/> 
        /// </summary>
        int NumYTiles { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getPropertyNames()"/> 
        /// </summary>
        string[] PropertyNames { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getSampleModel()"/> 
        /// </summary>
        Java.Awt.ImageNs.SampleModel SampleModel { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getSources()"/> 
        /// </summary>
        Java.Util.Vector<Java.Awt.ImageNs.RenderedImage> Sources { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileGridXOffset()"/> 
        /// </summary>
        int TileGridXOffset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileGridYOffset()"/> 
        /// </summary>
        int TileGridYOffset { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileHeight()"/> 
        /// </summary>
        int TileHeight { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileWidth()"/> 
        /// </summary>
        int TileWidth { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getWidth()"/> 
        /// </summary>
        int Width { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getData(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        Java.Awt.ImageNs.Raster GetData(Java.Awt.Rectangle arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        Java.Awt.ImageNs.Raster GetTile(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#copyData(java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        Java.Awt.ImageNs.WritableRaster CopyData(Java.Awt.ImageNs.WritableRaster arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        object GetProperty(string arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region RenderedImage
    public partial class RenderedImage : Java.Awt.ImageNs.IRenderedImage
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getColorModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.ColorModel ColorModel
        {
            get { return IExecute<Java.Awt.ImageNs.ColorModel>("getColorModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getData()"/> 
        /// </summary>
        public Java.Awt.ImageNs.Raster Data
        {
            get { return IExecute<Java.Awt.ImageNs.Raster>("getData"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getHeight()"/> 
        /// </summary>
        public int Height
        {
            get { return IExecute<int>("getHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinTileX()"/> 
        /// </summary>
        public int MinTileX
        {
            get { return IExecute<int>("getMinTileX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinTileY()"/> 
        /// </summary>
        public int MinTileY
        {
            get { return IExecute<int>("getMinTileY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinX()"/> 
        /// </summary>
        public int MinX
        {
            get { return IExecute<int>("getMinX"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getMinY()"/> 
        /// </summary>
        public int MinY
        {
            get { return IExecute<int>("getMinY"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getNumXTiles()"/> 
        /// </summary>
        public int NumXTiles
        {
            get { return IExecute<int>("getNumXTiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getNumYTiles()"/> 
        /// </summary>
        public int NumYTiles
        {
            get { return IExecute<int>("getNumYTiles"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getPropertyNames()"/> 
        /// </summary>
        public string[] PropertyNames
        {
            get { return IExecuteArray<string>("getPropertyNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getSampleModel()"/> 
        /// </summary>
        public Java.Awt.ImageNs.SampleModel SampleModel
        {
            get { return IExecute<Java.Awt.ImageNs.SampleModel>("getSampleModel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getSources()"/> 
        /// </summary>
        public Java.Util.Vector<Java.Awt.ImageNs.RenderedImage> Sources
        {
            get { return IExecute<Java.Util.Vector<Java.Awt.ImageNs.RenderedImage>>("getSources"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileGridXOffset()"/> 
        /// </summary>
        public int TileGridXOffset
        {
            get { return IExecute<int>("getTileGridXOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileGridYOffset()"/> 
        /// </summary>
        public int TileGridYOffset
        {
            get { return IExecute<int>("getTileGridYOffset"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileHeight()"/> 
        /// </summary>
        public int TileHeight
        {
            get { return IExecute<int>("getTileHeight"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTileWidth()"/> 
        /// </summary>
        public int TileWidth
        {
            get { return IExecute<int>("getTileWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getWidth()"/> 
        /// </summary>
        public int Width
        {
            get { return IExecute<int>("getWidth"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getData(java.awt.Rectangle)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.Rectangle"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster GetData(Java.Awt.Rectangle arg0)
        {
            return IExecute<Java.Awt.ImageNs.Raster>("getData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.Raster"/></returns>
        public Java.Awt.ImageNs.Raster GetTile(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.Raster>("getTile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#copyData(java.awt.image.WritableRaster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.WritableRaster"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster CopyData(Java.Awt.ImageNs.WritableRaster arg0)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("copyData", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/RenderedImage.html#getProperty(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        public object GetProperty(string arg0)
        {
            return IExecute("getProperty", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}