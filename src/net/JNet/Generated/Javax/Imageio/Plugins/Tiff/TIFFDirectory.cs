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

namespace Javax.Imageio.Plugins.Tiff
{
    #region TIFFDirectory
    public partial class TIFFDirectory
    {
        #region Constructors
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#<init>(javax.imageio.plugins.tiff.TIFFTagSet[],javax.imageio.plugins.tiff.TIFFTag)
        /// </summary>
        public TIFFDirectory(Javax.Imageio.Plugins.Tiff.TIFFTagSet[] arg0, Javax.Imageio.Plugins.Tiff.TIFFTag arg1)
            : base(arg0, arg1)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Lang.Cloneable(Javax.Imageio.Plugins.Tiff.TIFFDirectory t) => t.Cast<Java.Lang.Cloneable>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#createFromMetadata(javax.imageio.metadata.IIOMetadata) throws javax.imageio.metadata.IIOInvalidTreeException
        /// </summary>
        public static Javax.Imageio.Plugins.Tiff.TIFFDirectory CreateFromMetadata(Javax.Imageio.Metadata.IIOMetadata arg0)
        {
            return SExecute<Javax.Imageio.Plugins.Tiff.TIFFDirectory>("createFromMetadata", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getAsMetadata() 
        /// </summary>
        public Javax.Imageio.Metadata.IIOMetadata AsMetadata
        {
            get { return IExecute<Javax.Imageio.Metadata.IIOMetadata>("getAsMetadata"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getNumTIFFFields() 
        /// </summary>
        public int NumTIFFFields
        {
            get { return IExecute<int>("getNumTIFFFields"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getParentTag() 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFTag ParentTag
        {
            get { return IExecute<Javax.Imageio.Plugins.Tiff.TIFFTag>("getParentTag"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getTagSets() 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFTagSet[] TagSets
        {
            get { return IExecuteArray<Javax.Imageio.Plugins.Tiff.TIFFTagSet>("getTagSets"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getTIFFFields() 
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFField[] TIFFFields
        {
            get { return IExecuteArray<Javax.Imageio.Plugins.Tiff.TIFFField>("getTIFFFields"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#containsTIFFField(int)
        /// </summary>
        public bool ContainsTIFFField(int arg0)
        {
            return IExecute<bool>("containsTIFFField", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#clone() throws java.lang.CloneNotSupportedException
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFDirectory Clone()
        {
            return IExecute<Javax.Imageio.Plugins.Tiff.TIFFDirectory>("clone");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getTIFFField(int)
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFField GetTIFFField(int arg0)
        {
            return IExecute<Javax.Imageio.Plugins.Tiff.TIFFField>("getTIFFField", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#getTag(int)
        /// </summary>
        public Javax.Imageio.Plugins.Tiff.TIFFTag GetTag(int arg0)
        {
            return IExecute<Javax.Imageio.Plugins.Tiff.TIFFTag>("getTag", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#addTagSet(javax.imageio.plugins.tiff.TIFFTagSet)
        /// </summary>
        public void AddTagSet(Javax.Imageio.Plugins.Tiff.TIFFTagSet arg0)
        {
            IExecute("addTagSet", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#addTIFFField(javax.imageio.plugins.tiff.TIFFField)
        /// </summary>
        public void AddTIFFField(Javax.Imageio.Plugins.Tiff.TIFFField arg0)
        {
            IExecute("addTIFFField", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#removeTagSet(javax.imageio.plugins.tiff.TIFFTagSet)
        /// </summary>
        public void RemoveTagSet(Javax.Imageio.Plugins.Tiff.TIFFTagSet arg0)
        {
            IExecute("removeTagSet", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#removeTIFFField(int)
        /// </summary>
        public void RemoveTIFFField(int arg0)
        {
            IExecute("removeTIFFField", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.desktop/javax/imageio/plugins/tiff/TIFFDirectory.html#removeTIFFFields()
        /// </summary>
        public void RemoveTIFFFields()
        {
            IExecute("removeTIFFFields");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}