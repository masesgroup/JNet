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
    #region PosixFilePermissions
    public partial class PosixFilePermissions
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermissions.html#toString(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        public static Java.Lang.String ToString(Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission> arg0)
        {
            return SExecuteWithSignature<Java.Lang.String>(LocalBridgeClazz, "toString", "(Ljava/util/Set;)Ljava/lang/String;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermissions.html#asFileAttribute(java.util.Set)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Set"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.FileAttribute"/></returns>
        public static Java.Nio.File.Attribute.FileAttribute<Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission>> AsFileAttribute(Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission> arg0)
        {
            return SExecuteWithSignature<Java.Nio.File.Attribute.FileAttribute<Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission>>>(LocalBridgeClazz, "asFileAttribute", "(Ljava/util/Set;)Ljava/nio/file/attribute/FileAttribute;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFilePermissions.html#fromString(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Lang.String"/></param>
        /// <returns><see cref="Java.Util.Set"/></returns>
        public static Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission> FromString(Java.Lang.String arg0)
        {
            return SExecuteWithSignature<Java.Util.Set<Java.Nio.File.Attribute.PosixFilePermission>>(LocalBridgeClazz, "fromString", "(Ljava/lang/String;)Ljava/util/Set;", arg0);
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