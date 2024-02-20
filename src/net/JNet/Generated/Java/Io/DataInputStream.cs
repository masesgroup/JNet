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
*  This file is generated by MASES.JNetReflector (ver. 2.3.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Io
{
    #region DataInputStream
    public partial class DataInputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#%3Cinit%3E(java.io.InputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.InputStream"/></param>
        public DataInputStream(Java.Io.InputStream arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.DataInputStream"/> to <see cref="Java.Io.DataInput"/>
        /// </summary>
        public static implicit operator Java.Io.DataInput(Java.Io.DataInputStream t) => t.Cast<Java.Io.DataInput>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readUTF(java.io.DataInput)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.DataInput"/></param>
        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public static Java.Lang.String ReadUTF(Java.Io.DataInput arg0)
        {
            return SExecute<Java.Lang.String>(LocalBridgeClazz, "readUTF", arg0);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readBoolean()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public bool ReadBoolean()
        {
            return IExecute<bool>("readBoolean");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readByte()"/>
        /// </summary>

        /// <returns><see cref="byte"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public byte ReadByte()
        {
            return IExecute<byte>("readByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readChar()"/>
        /// </summary>

        /// <returns><see cref="char"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public char ReadChar()
        {
            return IExecute<char>("readChar");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readDouble()"/>
        /// </summary>

        /// <returns><see cref="double"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public double ReadDouble()
        {
            return IExecute<double>("readDouble");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readFloat()"/>
        /// </summary>

        /// <returns><see cref="float"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public float ReadFloat()
        {
            return IExecute<float>("readFloat");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readInt()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadInt()
        {
            return IExecute<int>("readInt");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readUnsignedByte()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedByte()
        {
            return IExecute<int>("readUnsignedByte");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readUnsignedShort()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int ReadUnsignedShort()
        {
            return IExecute<int>("readUnsignedShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#skipBytes(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public int SkipBytes(int arg0)
        {
            return IExecute<int>("skipBytes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readUTF()"/>
        /// </summary>

        /// <returns><see cref="Java.Lang.String"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Lang.String ReadUTF()
        {
            return IExecute<Java.Lang.String>("readUTF");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readLong()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public long ReadLong()
        {
            return IExecute<long>("readLong");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readShort()"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public short ReadShort()
        {
            return IExecute<short>("readShort");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readFully(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0, int arg1, int arg2)
        {
            IExecute("readFully", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/DataInputStream.html#readFully(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void ReadFully(byte[] arg0)
        {
            IExecute("readFully", new object[] { arg0 });
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}