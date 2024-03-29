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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Javax.Tools
{
    #region IStandardJavaFileManager
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IStandardJavaFileManager : Javax.Tools.IJavaFileManager
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#isSameFile(javax.tools.FileObject,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        bool IsSameFile(Javax.Tools.FileObject arg0, Javax.Tools.FileObject arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getLocation(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <typeparam name="ReturnExtendsJava_Io_File"><see cref="Java.Io.File"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJava_Io_File> GetLocation<ReturnExtendsJava_Io_File>(Javax.Tools.JavaFileManager.Location arg0) where ReturnExtendsJava_Io_File: Java.Io.File;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.io.File[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjects<ReturnExtendsJavax_Tools_JavaFileObject>(params Java.Io.File[] arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjects<ReturnExtendsJavax_Tools_JavaFileObject>(params Java.Lang.String[] arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromFiles(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Io_File"><see cref="Java.Io.File"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjectsFromFiles<ReturnExtendsJavax_Tools_JavaFileObject, Arg0ExtendsJava_Io_File>(Java.Lang.Iterable<Arg0ExtendsJava_Io_File> arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject where Arg0ExtendsJava_Io_File: Java.Io.File;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromStrings(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjectsFromStrings<ReturnExtendsJavax_Tools_JavaFileObject>(Java.Lang.Iterable<Java.Lang.String> arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocation(javax.tools.JavaFileManager.Location,java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg1ExtendsJava_Io_File"><see cref="Java.Io.File"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        void SetLocation<Arg1ExtendsJava_Io_File>(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.Iterable<Arg1ExtendsJava_Io_File> arg1) where Arg1ExtendsJava_Io_File: Java.Io.File;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getLocationAsPaths(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <typeparam name="ReturnExtendsJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJava_Nio_File_Path> GetLocationAsPaths<ReturnExtendsJava_Nio_File_Path>(Javax.Tools.JavaFileManager.Location arg0) where ReturnExtendsJava_Nio_File_Path: Java.Nio.File.Path;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.nio.file.Path[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjects<ReturnExtendsJavax_Tools_JavaFileObject>(params Java.Nio.File.Path[] arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromPaths(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjectsFromPaths<ReturnExtendsJavax_Tools_JavaFileObject, Arg0ExtendsJava_Nio_File_Path>(Java.Lang.Iterable<Arg0ExtendsJava_Nio_File_Path> arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject where Arg0ExtendsJava_Nio_File_Path: Java.Nio.File.Path;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#asPath(javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        Java.Nio.File.Path AsPath(Javax.Tools.FileObject arg0);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocationForModule(javax.tools.JavaFileManager.Location,java.lang.String,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg2ExtendsJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        void SetLocationForModule<Arg2ExtendsJava_Nio_File_Path>(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Util.Collection<Arg2ExtendsJava_Nio_File_Path> arg2) where Arg2ExtendsJava_Nio_File_Path: Java.Nio.File.Path;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocationFromPaths(javax.tools.JavaFileManager.Location,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        void SetLocationFromPaths<Arg1ExtendsJava_Nio_File_Path>(Javax.Tools.JavaFileManager.Location arg0, Java.Util.Collection<Arg1ExtendsJava_Nio_File_Path> arg1) where Arg1ExtendsJava_Nio_File_Path: Java.Nio.File.Path;
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setPathFactory(javax.tools.StandardJavaFileManager.PathFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.StandardJavaFileManager.PathFactory"/></param>
        void SetPathFactory(Javax.Tools.StandardJavaFileManager.PathFactory arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region StandardJavaFileManager
    public partial class StandardJavaFileManager : Javax.Tools.IStandardJavaFileManager
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#isSameFile(javax.tools.FileObject,javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <param name="arg1"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool IsSameFile(Javax.Tools.FileObject arg0, Javax.Tools.FileObject arg1)
        {
            return IExecute<bool>("isSameFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getLocation(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <typeparam name="ReturnExtendsJava_Io_File"><see cref="Java.Io.File"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJava_Io_File> GetLocation<ReturnExtendsJava_Io_File>(Javax.Tools.JavaFileManager.Location arg0) where ReturnExtendsJava_Io_File: Java.Io.File
        {
            return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJava_Io_File>>("getLocation", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.io.File[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjects<ReturnExtendsJavax_Tools_JavaFileObject>(params Java.Io.File[] arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjects", "([Ljava/io/File;)Ljava/lang/Iterable;"); else return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjects", "([Ljava/io/File;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.lang.String[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjects<ReturnExtendsJavax_Tools_JavaFileObject>(params Java.Lang.String[] arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjects", "([Ljava/lang/String;)Ljava/lang/Iterable;"); else return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjects", "([Ljava/lang/String;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromFiles(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Io_File"><see cref="Java.Io.File"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjectsFromFiles<ReturnExtendsJavax_Tools_JavaFileObject, Arg0ExtendsJava_Io_File>(Java.Lang.Iterable<Arg0ExtendsJava_Io_File> arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject where Arg0ExtendsJava_Io_File: Java.Io.File
        {
            return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjectsFromFiles", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromStrings(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjectsFromStrings<ReturnExtendsJavax_Tools_JavaFileObject>(Java.Lang.Iterable<Java.Lang.String> arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject
        {
            return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjectsFromStrings", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocation(javax.tools.JavaFileManager.Location,java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="Arg1ExtendsJava_Io_File"><see cref="Java.Io.File"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        public void SetLocation<Arg1ExtendsJava_Io_File>(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.Iterable<Arg1ExtendsJava_Io_File> arg1) where Arg1ExtendsJava_Io_File: Java.Io.File
        {
            IExecute("setLocation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getLocationAsPaths(javax.tools.JavaFileManager.Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <typeparam name="ReturnExtendsJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJava_Nio_File_Path> GetLocationAsPaths<ReturnExtendsJava_Nio_File_Path>(Javax.Tools.JavaFileManager.Location arg0) where ReturnExtendsJava_Nio_File_Path: Java.Nio.File.Path
        {
            return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJava_Nio_File_Path>>("getLocationAsPaths", "(Ljavax/tools/JavaFileManager$Location;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.nio.file.Path[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjects<ReturnExtendsJavax_Tools_JavaFileObject>(params Java.Nio.File.Path[] arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject
        {
            if (arg0.Length == 0) return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjects", "([Ljava/nio/file/Path;)Ljava/lang/Iterable;"); else return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjects", "([Ljava/nio/file/Path;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromPaths(java.lang.Iterable)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <typeparam name="ReturnExtendsJavax_Tools_JavaFileObject"><see cref="Javax.Tools.JavaFileObject"/></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject> GetJavaFileObjectsFromPaths<ReturnExtendsJavax_Tools_JavaFileObject, Arg0ExtendsJava_Nio_File_Path>(Java.Lang.Iterable<Arg0ExtendsJava_Nio_File_Path> arg0) where ReturnExtendsJavax_Tools_JavaFileObject: Javax.Tools.JavaFileObject where Arg0ExtendsJava_Nio_File_Path: Java.Nio.File.Path
        {
            return IExecuteWithSignature<Java.Lang.Iterable<ReturnExtendsJavax_Tools_JavaFileObject>>("getJavaFileObjectsFromPaths", "(Ljava/lang/Iterable;)Ljava/lang/Iterable;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#asPath(javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path AsPath(Javax.Tools.FileObject arg0)
        {
            return IExecuteWithSignature<Java.Nio.File.Path>("asPath", "(Ljavax/tools/FileObject;)Ljava/nio/file/Path;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocationForModule(javax.tools.JavaFileManager.Location,java.lang.String,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.String"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg2ExtendsJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        public void SetLocationForModule<Arg2ExtendsJava_Nio_File_Path>(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.String arg1, Java.Util.Collection<Arg2ExtendsJava_Nio_File_Path> arg2) where Arg2ExtendsJava_Nio_File_Path: Java.Nio.File.Path
        {
            IExecute("setLocationForModule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocationFromPaths(javax.tools.JavaFileManager.Location,java.util.Collection)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <typeparam name="Arg1ExtendsJava_Nio_File_Path"><see cref="Java.Nio.File.Path"/></typeparam>
        /// <exception cref="Java.Io.IOException"/>
        public void SetLocationFromPaths<Arg1ExtendsJava_Nio_File_Path>(Javax.Tools.JavaFileManager.Location arg0, Java.Util.Collection<Arg1ExtendsJava_Nio_File_Path> arg1) where Arg1ExtendsJava_Nio_File_Path: Java.Nio.File.Path
        {
            IExecute("setLocationFromPaths", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setPathFactory(javax.tools.StandardJavaFileManager.PathFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.StandardJavaFileManager.PathFactory"/></param>
        public void SetPathFactory(Javax.Tools.StandardJavaFileManager.PathFactory arg0)
        {
            IExecuteWithSignature("setPathFactory", "(Ljavax/tools/StandardJavaFileManager$PathFactory;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region PathFactory
        public partial class PathFactory
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.PathFactory.html#getPath(java.lang.String,java.lang.String[])"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Lang.String"/></param>
            /// <param name="arg1"><see cref="Java.Lang.String"/></param>
            /// <returns><see cref="Java.Nio.File.Path"/></returns>
            public Java.Nio.File.Path GetPath(Java.Lang.String arg0, params Java.Lang.String[] arg1)
            {
                if (arg1.Length == 0) return IExecute<Java.Nio.File.Path>("getPath", arg0); else return IExecute<Java.Nio.File.Path>("getPath", arg0, arg1);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion
}