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

namespace Java.Nio.File.Attribute
{
    #region PosixFileAttributes
    public partial class PosixFileAttributes
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Attribute.PosixFileAttributes"/> to <see cref="Java.Nio.File.Attribute.BasicFileAttributes"/>
        /// </summary>
        public static implicit operator Java.Nio.File.Attribute.BasicFileAttributes(Java.Nio.File.Attribute.PosixFileAttributes t) => t.Cast<Java.Nio.File.Attribute.BasicFileAttributes>();
        
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
            return IExecute<Java.Nio.File.Attribute.GroupPrincipal>("group");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributes.html#owner()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.File.Attribute.UserPrincipal"/></returns>
        public Java.Nio.File.Attribute.UserPrincipal Owner()
        {
            return IExecute<Java.Nio.File.Attribute.UserPrincipal>("owner");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/PosixFileAttributes.html#permissions()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set Permissions()
        {
            return IExecute<Java.Util.Set>("permissions");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}