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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio.File
{
    #region FileVisitResult
    public partial class FileVisitResult
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitResult.html#CONTINUE"/>
        /// </summary>
        public static Java.Nio.File.FileVisitResult CONTINUE => Clazz.GetField<Java.Nio.File.FileVisitResult>("CONTINUE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitResult.html#SKIP_SIBLINGS"/>
        /// </summary>
        public static Java.Nio.File.FileVisitResult SKIP_SIBLINGS => Clazz.GetField<Java.Nio.File.FileVisitResult>("SKIP_SIBLINGS");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitResult.html#SKIP_SUBTREE"/>
        /// </summary>
        public static Java.Nio.File.FileVisitResult SKIP_SUBTREE => Clazz.GetField<Java.Nio.File.FileVisitResult>("SKIP_SUBTREE");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitResult.html#TERMINATE"/>
        /// </summary>
        public static Java.Nio.File.FileVisitResult TERMINATE => Clazz.GetField<Java.Nio.File.FileVisitResult>("TERMINATE");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitResult.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        public static Java.Nio.File.FileVisitResult ValueOf(string arg0)
        {
            return SExecute<Java.Nio.File.FileVisitResult>("valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/FileVisitResult.html#values()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.File.FileVisitResult"/></returns>
        public static Java.Nio.File.FileVisitResult[] Values()
        {
            return SExecuteArray<Java.Nio.File.FileVisitResult>("values");
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