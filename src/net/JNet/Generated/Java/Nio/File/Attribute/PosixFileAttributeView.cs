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

namespace Java.Nio.File.Attribute
{
    #region PosixFileAttributeView
    public partial class PosixFileAttributeView
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Attribute.PosixFileAttributeView"/> to <see cref="Java.Nio.File.Attribute.BasicFileAttributeView"/>
        /// </summary>
        public static implicit operator Java.Nio.File.Attribute.BasicFileAttributeView(Java.Nio.File.Attribute.PosixFileAttributeView t) => t.Cast<Java.Nio.File.Attribute.BasicFileAttributeView>();
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Attribute.PosixFileAttributeView"/> to <see cref="Java.Nio.File.Attribute.FileOwnerAttributeView"/>
        /// </summary>
        public static implicit operator Java.Nio.File.Attribute.FileOwnerAttributeView(Java.Nio.File.Attribute.PosixFileAttributeView t) => t.Cast<Java.Nio.File.Attribute.FileOwnerAttributeView>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributeView.html#name()"/>
        /// </summary>
        
        /// <returns><see cref="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributeView.html#setGroup(java.nio.file.attribute.GroupPrincipal)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.GroupPrincipal"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetGroup(Java.Nio.File.Attribute.GroupPrincipal arg0)
        {
            IExecute("setGroup", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributeView.html#setPermissions(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void SetPermissions(Java.Util.Set arg0)
        {
            IExecute("setPermissions", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributeView.html#readAttributes()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.File.Attribute.BasicFileAttributes"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Nio.File.Attribute.BasicFileAttributes ReadAttributes()
        {
            return IExecute<Java.Nio.File.Attribute.BasicFileAttributes>("readAttributes");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}