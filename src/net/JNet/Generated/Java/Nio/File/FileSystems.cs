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

namespace Java.Nio.File
{
    #region FileSystems
    public partial class FileSystems
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystems.html#getDefault()"/> 
        /// </summary>
        public static Java.Nio.File.FileSystem Default
        {
            get { return SExecute<Java.Nio.File.FileSystem>("getDefault"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystems.html#getFileSystem(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        public static Java.Nio.File.FileSystem GetFileSystem(Java.Net.URI arg0)
        {
            return SExecute<Java.Nio.File.FileSystem>("getFileSystem", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystems.html#newFileSystem(java.net.URI,java.util.Map%3Cjava.lang.String, ?%3E,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <param name="arg2"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.File.FileSystem NewFileSystem(Java.Net.URI arg0, Java.Util.Map arg1, Java.Lang.ClassLoader arg2)
        {
            return SExecute<Java.Nio.File.FileSystem>("newFileSystem", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystems.html#newFileSystem(java.net.URI,java.util.Map%3Cjava.lang.String, ?%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <param name="arg1"><see cref="Java.Util.Map"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.File.FileSystem NewFileSystem(Java.Net.URI arg0, Java.Util.Map arg1)
        {
            return SExecute<Java.Nio.File.FileSystem>("newFileSystem", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileSystems.html#newFileSystem(java.nio.file.Path,java.lang.ClassLoader)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <param name="arg1"><see cref="Java.Lang.ClassLoader"/></param>
        /// <returns><see cref="Java.Nio.File.FileSystem"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Nio.File.FileSystem NewFileSystem(Java.Nio.File.Path arg0, Java.Lang.ClassLoader arg1)
        {
            return SExecute<Java.Nio.File.FileSystem>("newFileSystem", arg0, arg1);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}