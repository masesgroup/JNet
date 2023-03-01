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

namespace Javax.Tools
{
    #region StandardJavaFileManager
    public partial class StandardJavaFileManager
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Javax.Tools.StandardJavaFileManager"/> to <see cref="Javax.Tools.JavaFileManager"/>
        /// </summary>
        public static implicit operator Javax.Tools.JavaFileManager(Javax.Tools.StandardJavaFileManager t) => t.Cast<Javax.Tools.JavaFileManager>();
        
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
        /// <returns><see langword="bool"/></returns>
        public bool IsSameFile(Javax.Tools.FileObject arg0, Javax.Tools.FileObject arg1)
        {
            return IExecute<bool>("isSameFile", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getLocation(javax.tools.JavaFileManager$Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetLocation(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecute<Java.Lang.Iterable>("getLocation", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.io.File...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.File"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetJavaFileObjects(params Java.Io.File[] arg0)
        {
            if (arg0.Length == 0) return IExecute<Java.Lang.Iterable>("getJavaFileObjects"); else return IExecute<Java.Lang.Iterable>("getJavaFileObjects", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.lang.String...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetJavaFileObjects(params string[] arg0)
        {
            if (arg0.Length == 0) return IExecute<Java.Lang.Iterable>("getJavaFileObjects"); else return IExecute<Java.Lang.Iterable>("getJavaFileObjects", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromFiles(java.lang.Iterable%3C? extends java.io.File%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetJavaFileObjectsFromFiles(Java.Lang.Iterable arg0)
        {
            return IExecute<Java.Lang.Iterable>("getJavaFileObjectsFromFiles", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromStrings(java.lang.Iterable%3Cjava.lang.String%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetJavaFileObjectsFromStrings(Java.Lang.Iterable arg0)
        {
            return IExecute<Java.Lang.Iterable>("getJavaFileObjectsFromStrings", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocation(javax.tools.JavaFileManager$Location,java.lang.Iterable%3C? extends java.io.File%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Lang.Iterable"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetLocation(Javax.Tools.JavaFileManager.Location arg0, Java.Lang.Iterable arg1)
        {
            IExecute("setLocation", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getLocationAsPaths(javax.tools.JavaFileManager$Location)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetLocationAsPaths(Javax.Tools.JavaFileManager.Location arg0)
        {
            return IExecute<Java.Lang.Iterable>("getLocationAsPaths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjects(java.nio.file.Path...)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Path"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetJavaFileObjects(params Java.Nio.File.Path[] arg0)
        {
            if (arg0.Length == 0) return IExecute<Java.Lang.Iterable>("getJavaFileObjects"); else return IExecute<Java.Lang.Iterable>("getJavaFileObjects", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#getJavaFileObjectsFromPaths(java.lang.Iterable%3C? extends java.nio.file.Path%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.Iterable"/></param>
        /// <returns><see cref="Java.Lang.Iterable"/></returns>
        public Java.Lang.Iterable GetJavaFileObjectsFromPaths(Java.Lang.Iterable arg0)
        {
            return IExecute<Java.Lang.Iterable>("getJavaFileObjectsFromPaths", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#asPath(javax.tools.FileObject)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.FileObject"/></param>
        /// <returns><see cref="Java.Nio.File.Path"/></returns>
        public Java.Nio.File.Path AsPath(Javax.Tools.FileObject arg0)
        {
            return IExecute<Java.Nio.File.Path>("asPath", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocationForModule(javax.tools.JavaFileManager$Location,java.lang.String,java.util.Collection%3C? extends java.nio.file.Path%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="string"/></param>
        /// <param name="arg2"><see cref="Java.Util.Collection"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetLocationForModule(Javax.Tools.JavaFileManager.Location arg0, string arg1, Java.Util.Collection arg2)
        {
            IExecute("setLocationForModule", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setLocationFromPaths(javax.tools.JavaFileManager$Location,java.util.Collection%3C? extends java.nio.file.Path%3E)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.JavaFileManager.Location"/></param>
        /// <param name="arg1"><see cref="Java.Util.Collection"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetLocationFromPaths(Javax.Tools.JavaFileManager.Location arg0, Java.Util.Collection arg1)
        {
            IExecute("setLocationFromPaths", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.html#setPathFactory(javax.tools.StandardJavaFileManager$PathFactory)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Javax.Tools.StandardJavaFileManager.PathFactory"/></param>
        public void SetPathFactory(Javax.Tools.StandardJavaFileManager.PathFactory arg0)
        {
            IExecute("setPathFactory", arg0);
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.compiler/javax/tools/StandardJavaFileManager.PathFactory.html#getPath(java.lang.String,java.lang.String...)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="string"/></param>
            /// <returns><see cref="Java.Nio.File.Path"/></returns>
            public Java.Nio.File.Path GetPath(string arg0, params string[] arg1)
            {
                if (arg1.Length == 0) return IExecute<Java.Nio.File.Path>("getPath", arg0); else return IExecute<Java.Nio.File.Path>("getPath", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}