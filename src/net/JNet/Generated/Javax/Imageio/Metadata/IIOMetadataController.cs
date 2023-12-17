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

namespace Javax.Imageio.Metadata
{
    #region IIIOMetadataController
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IIIOMetadataController
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataController.html#activate(javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <returns><see cref="bool"/></returns>
        bool Activate(Javax.Imageio.Metadata.IIOMetadata arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region IIOMetadataController
    public partial class IIOMetadataController : Javax.Imageio.Metadata.IIIOMetadataController
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadataController.html#activate(javax.imageio.metadata.IIOMetadata)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Imageio.Metadata.IIOMetadata"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Activate(Javax.Imageio.Metadata.IIOMetadata arg0)
        {
            return IExecute<bool>("activate", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}