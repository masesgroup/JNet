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
    #region WritableRenderedImage
    public partial class WritableRenderedImage
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Awt.ImageNs.WritableRenderedImage"/> to <see cref="Java.Awt.ImageNs.RenderedImage"/>
        /// </summary>
        public static implicit operator Java.Awt.ImageNs.RenderedImage(Java.Awt.ImageNs.WritableRenderedImage t) => t.Cast<Java.Awt.ImageNs.RenderedImage>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#getWritableTileIndices()"/> 
        /// </summary>
        public Java.Awt.Point[] WritableTileIndices
        {
            get { return IExecuteArray<Java.Awt.Point>("getWritableTileIndices"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#hasTileWriters()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasTileWriters()
        {
            return IExecute<bool>("hasTileWriters");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#isTileWritable(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see langword="bool"/></returns>
        public bool IsTileWritable(int arg0, int arg1)
        {
            return IExecute<bool>("isTileWritable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#getWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Awt.ImageNs.WritableRaster"/></returns>
        public Java.Awt.ImageNs.WritableRaster GetWritableTile(int arg0, int arg1)
        {
            return IExecute<Java.Awt.ImageNs.WritableRaster>("getWritableTile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#addTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        public void AddTileObserver(Java.Awt.ImageNs.TileObserver arg0)
        {
            IExecute("addTileObserver", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#releaseWritableTile(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void ReleaseWritableTile(int arg0, int arg1)
        {
            IExecute("releaseWritableTile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#removeTileObserver(java.awt.image.TileObserver)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.TileObserver"/></param>
        public void RemoveTileObserver(Java.Awt.ImageNs.TileObserver arg0)
        {
            IExecute("removeTileObserver", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/java/awt/image/WritableRenderedImage.html#setData(java.awt.image.Raster)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Awt.ImageNs.Raster"/></param>
        public void SetData(Java.Awt.ImageNs.Raster arg0)
        {
            IExecute("setData", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}