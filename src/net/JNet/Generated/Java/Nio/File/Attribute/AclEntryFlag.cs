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
    #region AclEntryFlag
    public partial class AclEntryFlag
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#DIRECTORY_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag DIRECTORY_INHERIT => Clazz.GetField<Java.Nio.File.Attribute.AclEntryFlag>("DIRECTORY_INHERIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#FILE_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag FILE_INHERIT => Clazz.GetField<Java.Nio.File.Attribute.AclEntryFlag>("FILE_INHERIT");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#INHERIT_ONLY"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag INHERIT_ONLY => Clazz.GetField<Java.Nio.File.Attribute.AclEntryFlag>("INHERIT_ONLY");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#NO_PROPAGATE_INHERIT"/>
        /// </summary>
        public static Java.Nio.File.Attribute.AclEntryFlag NO_PROPAGATE_INHERIT => Clazz.GetField<Java.Nio.File.Attribute.AclEntryFlag>("NO_PROPAGATE_INHERIT");
        
        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#valueOf(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryFlag"/></returns>
        public static Java.Nio.File.Attribute.AclEntryFlag ValueOf(string arg0)
        {
            return SExecute<Java.Nio.File.Attribute.AclEntryFlag>("valueOf", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/AclEntryFlag.html#values()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.File.Attribute.AclEntryFlag"/></returns>
        public static Java.Nio.File.Attribute.AclEntryFlag[] Values()
        {
            return SExecuteArray<Java.Nio.File.Attribute.AclEntryFlag>("values");
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