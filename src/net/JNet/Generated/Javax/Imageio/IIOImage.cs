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
    #region IIOImage
    public partial class IIOImage
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getMetadata() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#setMetadata(javax.imageio.metadata.IIOMetadata)
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadata Metadata
        {
            get { return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getMetadata"); } set { IExecute("setMetadata", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getNumThumbnails() 
        /// </summary>
        public int NumThumbnails
        {
            get { return IExecute<int>("getNumThumbnails"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getRaster() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#setRaster(java.awt.image.Raster)
        /// </summary>
        public Java.Awt.ImageNs.Raster Raster
        {
            get { return IExecute<Java.Awt.ImageNs.Raster>("getRaster"); } set { IExecute("setRaster", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getRenderedImage() https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#setRenderedImage(java.awt.image.RenderedImage)
        /// </summary>
        public Java.Awt.ImageNs.RenderedImage RenderedImage
        {
            get { return IExecute<Java.Awt.ImageNs.RenderedImage>("getRenderedImage"); } set { IExecute("setRenderedImage", value); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#hasRaster()
        /// </summary>
        public bool HasRaster()
        {
            return IExecute<bool>("hasRaster");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/IIOImage.html#getThumbnail(int)
        /// </summary>
        public Java.Awt.ImageNs.BufferedImage GetThumbnail(int arg0)
        {
            return IExecute<Java.Awt.ImageNs.BufferedImage>("getThumbnail", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}