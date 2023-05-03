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
*  This file is generated by MASES.JNetReflector (ver. 1.5.5.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Zip
{
    #region ZipEntry
    public partial class ZipEntry
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#%3Cinit%3E(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        public ZipEntry(string arg0)
            : base(arg0)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#%3Cinit%3E(java.util.zip.ZipEntry)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Zip.ZipEntry"/></param>
        public ZipEntry(Java.Util.Zip.ZipEntry arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Zip.ZipEntry"/> to <see cref="Java.Lang.Cloneable"/>
        /// </summary>
        public static implicit operator Java.Lang.Cloneable(Java.Util.Zip.ZipEntry t) => t.Cast<Java.Lang.Cloneable>();

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#DEFLATED"/>
        /// </summary>
        public static int DEFLATED { get { return SGetField<int>(LocalBridgeClazz, "DEFLATED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#STORED"/>
        /// </summary>
        public static int STORED { get { return SGetField<int>(LocalBridgeClazz, "STORED"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getComment()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setComment(java.lang.String)"/>
        /// </summary>
        public string Comment
        {
            get { return IExecute<string>("getComment"); } set { IExecute("setComment", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getCompressedSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setCompressedSize(long)"/>
        /// </summary>
        public long CompressedSize
        {
            get { return IExecute<long>("getCompressedSize"); } set { IExecute("setCompressedSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getCrc()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setCrc(long)"/>
        /// </summary>
        public long Crc
        {
            get { return IExecute<long>("getCrc"); } set { IExecute("setCrc", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getCreationTime()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.FileTime CreationTime
        {
            get { return IExecute<Java.Nio.File.Attribute.FileTime>("getCreationTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getExtra()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setExtra(byte[])"/>
        /// </summary>
        public byte[] Extra
        {
            get { return IExecuteArray<byte>("getExtra"); } set { IExecute("setExtra", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#isDirectory()"/> 
        /// </summary>
        public bool IsDirectory
        {
            get { return IExecute<bool>("isDirectory"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getLastAccessTime()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.FileTime LastAccessTime
        {
            get { return IExecute<Java.Nio.File.Attribute.FileTime>("getLastAccessTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getLastModifiedTime()"/> 
        /// </summary>
        public Java.Nio.File.Attribute.FileTime LastModifiedTime
        {
            get { return IExecute<Java.Nio.File.Attribute.FileTime>("getLastModifiedTime"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getMethod()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setMethod(int)"/>
        /// </summary>
        public int Method
        {
            get { return IExecute<int>("getMethod"); } set { IExecute("setMethod", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getName()"/> 
        /// </summary>
        public string Name
        {
            get { return IExecute<string>("getName"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getSize()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setSize(long)"/>
        /// </summary>
        public long Size
        {
            get { return IExecute<long>("getSize"); } set { IExecute("setSize", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getTime()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setTime(long)"/>
        /// </summary>
        public long Time
        {
            get { return IExecute<long>("getTime"); } set { IExecute("setTime", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#getTimeLocal()"/> <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setTimeLocal(java.time.LocalDateTime)"/>
        /// </summary>
        public Java.Time.LocalDateTime TimeLocal
        {
            get { return IExecute<Java.Time.LocalDateTime>("getTimeLocal"); } set { IExecute("setTimeLocal", value); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setCreationTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetCreationTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecute<Java.Util.Zip.ZipEntry>("setCreationTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setLastAccessTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetLastAccessTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecute<Java.Util.Zip.ZipEntry>("setLastAccessTime", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/ZipEntry.html#setLastModifiedTime(java.nio.file.attribute.FileTime)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.File.Attribute.FileTime"/></param>
        /// <returns><see cref="Java.Util.Zip.ZipEntry"/></returns>
        public Java.Util.Zip.ZipEntry SetLastModifiedTime(Java.Nio.File.Attribute.FileTime arg0)
        {
            return IExecute<Java.Util.Zip.ZipEntry>("setLastModifiedTime", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}