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

namespace Java.Nio.File.Attribute
{
    #region IPosixFileAttributes
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPosixFileAttributes : Java.Nio.File.Attribute.IBasicFileAttributes
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributes.html#group()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.GroupPrincipal"/></returns>
        Java.Nio.File.Attribute.GroupPrincipal Group();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributes.html#owner()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.UserPrincipal"/></returns>
        Java.Nio.File.Attribute.UserPrincipal Owner();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributes.html#permissions()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission> Permissions();

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PosixFileAttributes
    public partial class PosixFileAttributes : Java.Nio.File.Attribute.IPosixFileAttributes
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributes.html#group()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.GroupPrincipal"/></returns>
        public Java.Nio.File.Attribute.GroupPrincipal Group()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.GroupPrincipal>("group", "()Ljava/nio/file/attribute/GroupPrincipal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributes.html#owner()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.File.Attribute.UserPrincipal"/></returns>
        public Java.Nio.File.Attribute.UserPrincipal Owner()
        {
            return IExecuteWithSignature<Java.Nio.File.Attribute.UserPrincipal>("owner", "()Ljava/nio/file/attribute/UserPrincipal;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributes.html#permissions()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission> Permissions()
        {
            return IExecuteWithSignature<Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission>>("permissions", "()Ljava/util/Set;");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}