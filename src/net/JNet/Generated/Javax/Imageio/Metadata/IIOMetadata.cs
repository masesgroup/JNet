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

namespace Javax.Imageio.Metadata
{
    #region IIOMetadata
    public partial class IIOMetadata
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getController()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#setController(javax.imageio.metadata.IIOMetadataController)"/>
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadataController Controller
        {
            get { return IExecute<Javax.Imageio.Metadata.IIOMetadataController>("getController"); } set { IExecute("setController", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getDefaultController()"/> 
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadataController DefaultController
        {
            get { return IExecute<Javax.Imageio.Metadata.IIOMetadataController>("getDefaultController"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getExtraMetadataFormatNames()"/> 
        /// </summary>
        public string[] ExtraMetadataFormatNames
        {
            get { return IExecuteArray<string>("getExtraMetadataFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getMetadataFormatNames()"/> 
        /// </summary>
        public string[] MetadataFormatNames
        {
            get { return IExecuteArray<string>("getMetadataFormatNames"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getNativeMetadataFormatName()"/> 
        /// </summary>
        public string NativeMetadataFormatName
        {
            get { return IExecute<string>("getNativeMetadataFormatName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#isReadOnly()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecute<bool>("isReadOnly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getAsTree(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Org.W3c.Dom.Node"/></returns>
        public Org.W3c.Dom.Node GetAsTree(string arg0)
        {
            return IExecute<Org.W3c.Dom.Node>("getAsTree", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#mergeTree(java.lang.String,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Javax.Imageio.Metadata.IIOInvalidTreeException"/>
        public void MergeTree(string arg0, Org.W3c.Dom.Node arg1)
        {
            IExecute("mergeTree", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#activateController()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool ActivateController()
        {
            return IExecute<bool>("activateController");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#hasController()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool HasController()
        {
            return IExecute<bool>("hasController");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#isStandardMetadataFormatSupported()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool IsStandardMetadataFormatSupported()
        {
            return IExecute<bool>("isStandardMetadataFormatSupported");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#getMetadataFormat(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <returns><see cref="Javax.Imageio.Metadata.IIOMetadataFormat"/></returns>
        public Javax.Imageio.Metadata.IIOMetadataFormat GetMetadataFormat(string arg0)
        {
            return IExecute<Javax.Imageio.Metadata.IIOMetadataFormat>("getMetadataFormat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/metadata/IIOMetadata.html#setFromTree(java.lang.String,org.w3c.dom.Node)"/>
        /// </summary>
        /// <param name="arg0"><see langword="string"/></param>
        /// <param name="arg1"><see cref="Org.W3c.Dom.Node"/></param>
        /// <exception cref="Javax.Imageio.Metadata.IIOInvalidTreeException"/>
        public void SetFromTree(string arg0, Org.W3c.Dom.Node arg1)
        {
            IExecute("setFromTree", arg0, arg1);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}