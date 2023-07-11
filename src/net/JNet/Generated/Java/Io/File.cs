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
*  This file is generated by MASES.JNetReflector (ver. 2.0.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region File
    public partial class File
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#%3Cinit%3E(java.io.File,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public File(Java.Io.File arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#%3Cinit%3E(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        public File(string arg0, string arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public File(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#%3Cinit%3E(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        public File(Java.Net.URI arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.File"/> to <see cref="Java.Io.Serializable"/>
        /// </summary>
        public static implicit operator Java.Io.Serializable(Java.Io.File t) => t.Cast<Java.Io.Serializable>();
        /// <summary>
        /// Converter from <see cref="Java.Io.File"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Io.File t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#pathSeparatorChar"/>
        /// </summary>
        public static char pathSeparatorChar { get { return SGetField<char>(LocalBridgeClazz, "pathSeparatorChar"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#separatorChar"/>
        /// </summary>
        public static char separatorChar { get { return SGetField<char>(LocalBridgeClazz, "separatorChar"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#pathSeparator"/>
        /// </summary>
        public static string pathSeparator { get { return SGetField<string>(LocalBridgeClazz, "pathSeparator"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#separator"/>
        /// </summary>
        public static string separator { get { return SGetField<string>(LocalBridgeClazz, "separator"); } }

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#createTempFile(java.lang.String,java.lang.String,java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Io.File CreateTempFile(string arg0, string arg1, Java.Io.File arg2)
        {
            return SExecute<Java.Io.File>(LocalBridgeClazz, "createTempFile", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#createTempFile(java.lang.String,java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Io.File CreateTempFile(string arg0, string arg1)
        {
            return SExecute<Java.Io.File>(LocalBridgeClazz, "createTempFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#listRoots()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.File"/></returns>
        public static Java.Io.File[] ListRoots()
        {
            return SExecuteArray<Java.Io.File>(LocalBridgeClazz, "listRoots");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getAbsoluteFile()"/> 
        /// </summary>
        public Java.Io.File AbsoluteFile
        {
            get { return IExecute<Java.Io.File>("getAbsoluteFile"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getAbsolutePath()"/> 
        /// </summary>
        public string AbsolutePath
        {
            get { return IExecute<string>("getAbsolutePath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getCanonicalFile()"/> 
        /// </summary>
        public Java.Io.File CanonicalFile
        {
            get { return IExecute<Java.Io.File>("getCanonicalFile"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getCanonicalPath()"/> 
        /// </summary>
        public string CanonicalPath
        {
            get { return IExecute<string>("getCanonicalPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getFreeSpace()"/> 
        /// </summary>
        public long FreeSpace
        {
            get { return IExecute<long>("getFreeSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getParent()"/> 
        /// </summary>
        public string Parent
        {
            get { return IExecute<string>("getParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getParentFile()"/> 
        /// </summary>
        public Java.Io.File ParentFile
        {
            get { return IExecute<Java.Io.File>("getParentFile"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getPath()"/> 
        /// </summary>
        public string Path
        {
            get { return IExecute<string>("getPath"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getTotalSpace()"/> 
        /// </summary>
        public long TotalSpace
        {
            get { return IExecute<long>("getTotalSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#getUsableSpace()"/> 
        /// </summary>
        public long UsableSpace
        {
            get { return IExecute<long>("getUsableSpace"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#canExecute()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool CanExecute()
        {
            return IExecute<bool>("canExecute");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#canRead()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool CanRead()
        {
            return IExecute<bool>("canRead");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#canWrite()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool CanWrite()
        {
            return IExecute<bool>("canWrite");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#createNewFile()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool CreateNewFile()
        {
            return IExecute<bool>("createNewFile");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#delete()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Delete()
        {
            return IExecute<bool>("delete");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#exists()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Exists()
        {
            return IExecute<bool>("exists");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#isAbsolute()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAbsolute()
        {
            return IExecute<bool>("isAbsolute");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#isDirectory()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDirectory()
        {
            return IExecute<bool>("isDirectory");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#isFile()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsFile()
        {
            return IExecute<bool>("isFile");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#isHidden()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsHidden()
        {
            return IExecute<bool>("isHidden");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#mkdir()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Mkdir()
        {
            return IExecute<bool>("mkdir");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#mkdirs()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Mkdirs()
        {
            return IExecute<bool>("mkdirs");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#renameTo(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool RenameTo(Java.Io.File arg0)
        {
            return IExecute<bool>("renameTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setExecutable(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetExecutable(bool arg0, bool arg1)
        {
            return IExecute<bool>("setExecutable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setExecutable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetExecutable(bool arg0)
        {
            return IExecute<bool>("setExecutable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setLastModified(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetLastModified(long arg0)
        {
            return IExecute<bool>("setLastModified", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setReadable(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetReadable(bool arg0, bool arg1)
        {
            return IExecute<bool>("setReadable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setReadable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetReadable(bool arg0)
        {
            return IExecute<bool>("setReadable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setReadOnly()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool SetReadOnly()
        {
            return IExecute<bool>("setReadOnly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setWritable(boolean,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetWritable(bool arg0, bool arg1)
        {
            return IExecute<bool>("setWritable", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#setWritable(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool SetWritable(bool arg0)
        {
            return IExecute<bool>("setWritable", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#compareTo(java.io.File)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Io.File arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#listFiles()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File[] ListFiles()
        {
            return IExecuteArray<Java.Io.File>("listFiles");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#listFiles(java.io.FileFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FileFilter"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File[] ListFiles(Java.Io.FileFilter arg0)
        {
            return IExecuteArray<Java.Io.File>("listFiles", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#listFiles(java.io.FilenameFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FilenameFilter"/></param>
        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File[] ListFiles(Java.Io.FilenameFilter arg0)
        {
            return IExecuteArray<Java.Io.File>("listFiles", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#list()"/>
        /// </summary>

        /// <returns><see cref="string"/></returns>
        public string[] List()
        {
            return IExecuteArray<string>("list");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#list(java.io.FilenameFilter)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.FilenameFilter"/></param>
        /// <returns><see cref="string"/></returns>
        public string[] List(Java.Io.FilenameFilter arg0)
        {
            return IExecuteArray<string>("list", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#toURI()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI ToURI()
        {
            return IExecute<Java.Net.URI>("toURI");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#toPath()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path ToPath()
        {
            return IExecute<Java.Nio.File.Path>("toPath");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#lastModified()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long LastModified()
        {
            return IExecute<long>("lastModified");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#length()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Length()
        {
            return IExecute<long>("length");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html#deleteOnExit()"/>
        /// </summary>
        public void DeleteOnExit()
        {
            IExecute("deleteOnExit");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}