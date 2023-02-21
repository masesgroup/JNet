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
    #region DosFileAttributeView
    public partial class DosFileAttributeView
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        public static implicit operator Java.Nio.File.Attribute.BasicFileAttributeView(Java.Nio.File.Attribute.DosFileAttributeView t) => t.Cast<Java.Nio.File.Attribute.BasicFileAttributeView>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributeView.html#name()
        /// </summary>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributeView.html#setArchive(boolean) throws java.io.IOException
        /// </summary>
        public void SetArchive(bool arg0)
        {
            IExecute("setArchive", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributeView.html#setHidden(boolean) throws java.io.IOException
        /// </summary>
        public void SetHidden(bool arg0)
        {
            IExecute("setHidden", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributeView.html#setReadOnly(boolean) throws java.io.IOException
        /// </summary>
        public void SetReadOnly(bool arg0)
        {
            IExecute("setReadOnly", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributeView.html#setSystem(boolean) throws java.io.IOException
        /// </summary>
        public void SetSystem(bool arg0)
        {
            IExecute("setSystem", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/DosFileAttributeView.html#readAttributes() throws java.io.IOException
        /// </summary>
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