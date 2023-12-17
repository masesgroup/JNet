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

namespace Java.Nio.File
{
    #region IPath
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPath
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getFileName()"/> 
        /// </summary>
        Java.Nio.File.Path FileName { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getFileSystem()"/> 
        /// </summary>
        Java.Nio.File.FileSystem FileSystem { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getNameCount()"/> 
        /// </summary>
        int NameCount { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getParent()"/> 
        /// </summary>
        Java.Nio.File.Path Parent { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getRoot()"/> 
        /// </summary>
        Java.Nio.File.Path Root { get; }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#endsWith(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        bool EndsWith(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#isAbsolute()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        bool IsAbsolute();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#startsWith(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        bool StartsWith(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#compareTo(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="int"/></returns>
        int CompareTo(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toUri()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        Java.Net.URI ToUri();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path GetName(int arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#normalize()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Normalize();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#relativize(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Relativize(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolve(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Resolve(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#subpath(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Subpath(int arg0, int arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toAbsolutePath()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path ToAbsolutePath();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toRealPath(java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.Path ToRealPath(params Java.Nio.File.LinkOption[] arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[],java.nio.file.WatchEvent.Modifier[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.WatchEvent.Modifier"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, Java.Nio.File.WatchEvent.Kind<object>[] arg1, params Java.Nio.File.WatchEvent.Modifier[] arg2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#endsWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        bool EndsWith(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#startsWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        bool StartsWith(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        int CompareTo(object arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toFile()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.File"/></returns>
        Java.Io.File ToFile();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolve(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path Resolve(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolveSibling(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path ResolveSibling(string arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolveSibling(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path ResolveSibling(Java.Nio.File.Path arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, params Java.Nio.File.WatchEvent.Kind<object>[] arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        Java.Util.Iterator<Java.Nio.File.Path> Iterator();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Path
    public partial class Path : Java.Nio.File.IPath
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Path"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.File.Path t) => t.Cast<Java.Lang.Comparable>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Path"/> to <see cref="Java.Nio.File.Watchable"/>
        /// </summary>
        public static implicit operator Java.Nio.File.Watchable(Java.Nio.File.Path t) => t.Cast<Java.Nio.File.Watchable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#of(java.lang.String,java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public static Java.Nio.File.Path Of(string arg0, params string[] arg1)
        {
            if (arg1.Length == 0) return SExecute<Java.Nio.File.Path>(LocalBridgeClazz, "of", arg0); else return SExecute<Java.Nio.File.Path>(LocalBridgeClazz, "of", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#of(java.net.URI)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Net.URI"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public static Java.Nio.File.Path Of(Java.Net.URI arg0)
        {
            return SExecute<Java.Nio.File.Path>(LocalBridgeClazz, "of", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getFileName()"/> 
        /// </summary>
        public Java.Nio.File.Path FileName
        {
            get { return IExecute<Java.Nio.File.Path>("getFileName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getFileSystem()"/> 
        /// </summary>
        public Java.Nio.File.FileSystem FileSystem
        {
            get { return IExecute<Java.Nio.File.FileSystem>("getFileSystem"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getNameCount()"/> 
        /// </summary>
        public int NameCount
        {
            get { return IExecute<int>("getNameCount"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getParent()"/> 
        /// </summary>
        public Java.Nio.File.Path Parent
        {
            get { return IExecute<Java.Nio.File.Path>("getParent"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getRoot()"/> 
        /// </summary>
        public Java.Nio.File.Path Root
        {
            get { return IExecute<Java.Nio.File.Path>("getRoot"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#endsWith(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EndsWith(Java.Nio.File.Path arg0)
        {
            return IExecute<bool>("endsWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#isAbsolute()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsAbsolute()
        {
            return IExecute<bool>("isAbsolute");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#startsWith(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StartsWith(Java.Nio.File.Path arg0)
        {
            return IExecute<bool>("startsWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#compareTo(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.File.Path arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toUri()"/>
        /// </summary>

        /// <returns><see cref="Java.Net.URI"/></returns>
        public Java.Net.URI ToUri()
        {
            return IExecute<Java.Net.URI>("toUri");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#getName(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path GetName(int arg0)
        {
            return IExecute<Java.Nio.File.Path>("getName", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#normalize()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Normalize()
        {
            return IExecute<Java.Nio.File.Path>("normalize");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#relativize(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Relativize(Java.Nio.File.Path arg0)
        {
            return IExecute<Java.Nio.File.Path>("relativize", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolve(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Resolve(Java.Nio.File.Path arg0)
        {
            return IExecute<Java.Nio.File.Path>("resolve", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#subpath(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Subpath(int arg0, int arg1)
        {
            return IExecute<Java.Nio.File.Path>("subpath", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toAbsolutePath()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path ToAbsolutePath()
        {
            return IExecute<Java.Nio.File.Path>("toAbsolutePath");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toRealPath(java.nio.file.LinkOption[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.LinkOption"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.Path ToRealPath(params Java.Nio.File.LinkOption[] arg0)
        {
            if (arg0.Length == 0) return IExecute<Java.Nio.File.Path>("toRealPath"); else return IExecute<Java.Nio.File.Path>("toRealPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[],java.nio.file.WatchEvent.Modifier[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <param name="arg2"><see cref="Java.Nio.File.WatchEvent.Modifier"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, Java.Nio.File.WatchEvent.Kind<object>[] arg1, params Java.Nio.File.WatchEvent.Modifier[] arg2)
        {
            if (arg2.Length == 0) return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1); else return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#endsWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool EndsWith(string arg0)
        {
            return IExecute<bool>("endsWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#startsWith(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool StartsWith(string arg0)
        {
            return IExecute<bool>("startsWith", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#toFile()"/>
        /// </summary>

        /// <returns><see cref="Java.Io.File"/></returns>
        public Java.Io.File ToFile()
        {
            return IExecute<Java.Io.File>("toFile");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolve(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path Resolve(string arg0)
        {
            return IExecute<Java.Nio.File.Path>("resolve", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolveSibling(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path ResolveSibling(string arg0)
        {
            return IExecute<Java.Nio.File.Path>("resolveSibling", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#resolveSibling(java.nio.file.Path)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path ResolveSibling(Java.Nio.File.Path arg0)
        {
            return IExecute<Java.Nio.File.Path>("resolveSibling", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#register(java.nio.file.WatchService,java.nio.file.WatchEvent.Kind[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.WatchService"/></param>
        /// <param name="arg1"><see cref="Java.Nio.File.WatchEvent.Kind"/></param>
        /// <returns><see cref="Java.Nio.File.WatchKey"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.WatchKey Register(Java.Nio.File.WatchService arg0, params Java.Nio.File.WatchEvent.Kind<object>[] arg1)
        {
            if (arg1.Length == 0) return IExecute<Java.Nio.File.WatchKey>("register", arg0); else return IExecute<Java.Nio.File.WatchKey>("register", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/Path.html#iterator()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public Java.Util.Iterator<Java.Nio.File.Path> Iterator()
        {
            return IExecute<Java.Util.Iterator<Java.Nio.File.Path>>("iterator");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}