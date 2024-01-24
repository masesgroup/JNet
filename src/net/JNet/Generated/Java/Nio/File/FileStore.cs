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

namespace Java.Nio.File
{
    #region FileStore
    public partial class FileStore
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#getBlockSize()"/> 
        /// </summary>
        public long BlockSize
        {
            get { return IExecute<long>("getBlockSize"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#getTotalSpace()"/> 
        /// </summary>
        public long TotalSpace
        {
            get { return IExecute<long>("getTotalSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#getUnallocatedSpace()"/> 
        /// </summary>
        public long UnallocatedSpace
        {
            get { return IExecute<long>("getUnallocatedSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#getUsableSpace()"/> 
        /// </summary>
        public long UsableSpace
        {
            get { return IExecute<long>("getUsableSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#getFileStoreAttributeView(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <typeparam name="V"><see cref="Java.Nio.File.Attribute.IFileStoreAttributeView"/></typeparam>
        /// <returns><typeparamref name="V"/></returns>
        public V GetFileStoreAttributeView<V>(Java.Lang.Class arg0) where V: Java.Nio.File.Attribute.IFileStoreAttributeView, new()
        {
            return IExecute<V>("getFileStoreAttributeView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#isReadOnly()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecute<bool>("isReadOnly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#supportsFileAttributeView(java.lang.Class)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Class"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsFileAttributeView(Java.Lang.Class arg0)
        {
            return IExecute<bool>("supportsFileAttributeView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#supportsFileAttributeView(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SupportsFileAttributeView(string arg0)
        {
            return IExecute<bool>("supportsFileAttributeView", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#getAttribute(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="object"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public object GetAttribute(string arg0)
        {
            return IExecute("getAttribute", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#name()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileStore.html#type()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string Type()
        {
            return IExecute<string>("type");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}