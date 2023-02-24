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
    #region UserDefinedFileAttributeView
    public partial class UserDefinedFileAttributeView
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.File.Attribute.UserDefinedFileAttributeView"/> to <see cref="Java.Nio.File.Attribute.FileAttributeView"/>
        /// </summary>
        public static implicit operator Java.Nio.File.Attribute.FileAttributeView(Java.Nio.File.Attribute.UserDefinedFileAttributeView t) => t.Cast<Java.Nio.File.Attribute.FileAttributeView>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/UserDefinedFileAttributeView.html#read(java.lang.String,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Read(string arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<int>("read", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/UserDefinedFileAttributeView.html#size(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Size(string arg0)
        {
            return IExecute<int>("size", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/UserDefinedFileAttributeView.html#write(java.lang.String,java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <param name="arg1"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int Write(string arg0, Java.Nio.ByteBuffer arg1)
        {
            return IExecute<int>("write", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/UserDefinedFileAttributeView.html#name()"/>
        /// </summary>
        
        /// <returns><see langword="string"/></returns>
        public string Name()
        {
            return IExecute<string>("name");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/file/attribute/UserDefinedFileAttributeView.html#delete(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void Delete(string arg0)
        {
            IExecute("delete", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}