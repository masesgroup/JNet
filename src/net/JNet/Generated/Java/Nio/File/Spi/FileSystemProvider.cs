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

namespace Java.Nio.File.Spi
{
    #region FileSystemProvider
    public partial class FileSystemProvider
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getScheme() 
        /// </summary>
        public string Scheme
        {
            get { return IExecute<string>("getScheme"); }
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#isHidden(java.nio.file.Path) throws java.io.IOException
        /// </summary>
        public bool IsHidden(Java.Nio.File.Path arg0)
        {
            return IExecute<bool>("isHidden", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#isSameFile(java.nio.file.Path,java.nio.file.Path) throws java.io.IOException
        /// </summary>
        public bool IsSameFile(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1)
        {
            return IExecute<bool>("isSameFile", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getFileStore(java.nio.file.Path) throws java.io.IOException
        /// </summary>
        public Java.Nio.File.FileStore GetFileStore(Java.Nio.File.Path arg0)
        {
            return IExecute<Java.Nio.File.FileStore>("getFileStore", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getFileSystem(java.net.URI)
        /// </summary>
        public Java.Nio.File.FileSystem GetFileSystem(Java.Net.URI arg0)
        {
            return IExecute<Java.Nio.File.FileSystem>("getFileSystem", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#getPath(java.net.URI)
        /// </summary>
        public Java.Nio.File.Path GetPath(Java.Net.URI arg0)
        {
            return IExecute<Java.Nio.File.Path>("getPath", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#checkAccess(java.nio.file.Path,java.nio.file.AccessMode...) throws java.io.IOException
        /// </summary>
        public void CheckAccess(Java.Nio.File.Path arg0, params Java.Nio.File.AccessMode[] arg1)
        {
            if (arg1.Length == 0) IExecute("checkAccess", arg0); else IExecute("checkAccess", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#copy(java.nio.file.Path,java.nio.file.Path,java.nio.file.CopyOption...) throws java.io.IOException
        /// </summary>
        public void Copy(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1, params Java.Nio.File.CopyOption[] arg2)
        {
            if (arg2.Length == 0) IExecute("copy", arg0, arg1); else IExecute("copy", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#createDirectory(java.nio.file.Path,java.nio.file.attribute.FileAttribute<?>...) throws java.io.IOException
        /// </summary>
        public void CreateDirectory(Java.Nio.File.Path arg0, params Java.Nio.File.Attribute.FileAttribute[] arg1)
        {
            if (arg1.Length == 0) IExecute("createDirectory", arg0); else IExecute("createDirectory", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#delete(java.nio.file.Path) throws java.io.IOException
        /// </summary>
        public void Delete(Java.Nio.File.Path arg0)
        {
            IExecute("delete", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#move(java.nio.file.Path,java.nio.file.Path,java.nio.file.CopyOption...) throws java.io.IOException
        /// </summary>
        public void Move(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1, params Java.Nio.File.CopyOption[] arg2)
        {
            if (arg2.Length == 0) IExecute("move", arg0, arg1); else IExecute("move", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#setAttribute(java.nio.file.Path,java.lang.String,java.lang.Object,java.nio.file.LinkOption...) throws java.io.IOException
        /// </summary>
        public void SetAttribute(Java.Nio.File.Path arg0, string arg1, object arg2, params Java.Nio.File.LinkOption[] arg3)
        {
            if (arg3.Length == 0) IExecute("setAttribute", arg0, arg1, arg2); else IExecute("setAttribute", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#deleteIfExists(java.nio.file.Path) throws java.io.IOException
        /// </summary>
        public bool DeleteIfExists(Java.Nio.File.Path arg0)
        {
            return IExecute<bool>("deleteIfExists", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newInputStream(java.nio.file.Path,java.nio.file.OpenOption...) throws java.io.IOException
        /// </summary>
        public Java.Io.InputStream NewInputStream(Java.Nio.File.Path arg0, params Java.Nio.File.OpenOption[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Io.InputStream>("newInputStream", arg0); else return IExecute<Java.Io.InputStream>("newInputStream", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#newOutputStream(java.nio.file.Path,java.nio.file.OpenOption...) throws java.io.IOException
        /// </summary>
        public Java.Io.OutputStream NewOutputStream(Java.Nio.File.Path arg0, params Java.Nio.File.OpenOption[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Io.OutputStream>("newOutputStream", arg0); else return IExecute<Java.Io.OutputStream>("newOutputStream", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#readSymbolicLink(java.nio.file.Path) throws java.io.IOException
        /// </summary>
        public Java.Nio.File.Path ReadSymbolicLink(Java.Nio.File.Path arg0)
        {
            return IExecute<Java.Nio.File.Path>("readSymbolicLink", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#createLink(java.nio.file.Path,java.nio.file.Path) throws java.io.IOException
        /// </summary>
        public void CreateLink(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1)
        {
            IExecute("createLink", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/spi/FileSystemProvider.html#createSymbolicLink(java.nio.file.Path,java.nio.file.Path,java.nio.file.attribute.FileAttribute<?>...) throws java.io.IOException
        /// </summary>
        public void CreateSymbolicLink(Java.Nio.File.Path arg0, Java.Nio.File.Path arg1, params Java.Nio.File.Attribute.FileAttribute[] arg2)
        {
            if (arg2.Length == 0) IExecute("createSymbolicLink", arg0, arg1); else IExecute("createSymbolicLink", arg0, arg1, arg2);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}