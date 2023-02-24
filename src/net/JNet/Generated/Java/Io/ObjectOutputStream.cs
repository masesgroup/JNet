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

namespace Java.Io
{
    #region ObjectOutputStream
    public partial class ObjectOutputStream
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#%3Cinit%3E(java.io.OutputStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Io.OutputStream"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public ObjectOutputStream(Java.Io.OutputStream arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Io.ObjectOutputStream"/> to <see cref="Java.Io.ObjectOutput"/>
        /// </summary>
        public static implicit operator Java.Io.ObjectOutput(Java.Io.ObjectOutputStream t) => t.Cast<Java.Io.ObjectOutput>();
        /// <summary>
        /// Converter from <see cref="Java.Io.ObjectOutputStream"/> to <see cref="Java.Io.ObjectStreamConstants"/>
        /// </summary>
        public static implicit operator Java.Io.ObjectStreamConstants(Java.Io.ObjectOutputStream t) => t.Cast<Java.Io.ObjectStreamConstants>();
        
        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeObject(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteObject(object arg0)
        {
            IExecute("writeObject", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#putFields()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Io.ObjectOutputStream.PutField"/></returns>
        /// <exception cref="Java.Io.IOException"/>
        public Java.Io.ObjectOutputStream.PutField PutFields()
        {
            return IExecute<Java.Io.ObjectOutputStream.PutField>("putFields");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#defaultWriteObject()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void DefaultWriteObject()
        {
            IExecute("defaultWriteObject");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#reset()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#useProtocolVersion(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void UseProtocolVersion(int arg0)
        {
            IExecute("useProtocolVersion", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeBoolean(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBoolean(bool arg0)
        {
            IExecute("writeBoolean", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeByte(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteByte(int arg0)
        {
            IExecute("writeByte", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeBytes(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteBytes(string arg0)
        {
            IExecute("writeBytes", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeChar(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteChar(int arg0)
        {
            IExecute("writeChar", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeChars(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteChars(string arg0)
        {
            IExecute("writeChars", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteDouble(double arg0)
        {
            IExecute("writeDouble", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeFields()"/>
        /// </summary>
        
        /// <exception cref="Java.Io.IOException"/>
        public void WriteFields()
        {
            IExecute("writeFields");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeFloat(float)"/>
        /// </summary>
        /// <param name="arg0"><see cref="float"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteFloat(float arg0)
        {
            IExecute("writeFloat", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeInt(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteInt(int arg0)
        {
            IExecute("writeInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteLong(long arg0)
        {
            IExecute("writeLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeShort(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteShort(int arg0)
        {
            IExecute("writeShort", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeUnshared(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteUnshared(object arg0)
        {
            IExecute("writeUnshared", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.html#writeUTF(java.lang.String)"/>
        /// </summary>
        /// <param name="arg0"><see cref="string"/></param>
        /// <exception cref="Java.Io.IOException"/>
        public void WriteUTF(string arg0)
        {
            IExecute("writeUTF", arg0);
        }
        
        #endregion

        #region Nested classes
        #region PutField
        public partial class PutField
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,boolean)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="bool"/></param>
            public void Put(string arg0, bool arg1)
            {
                IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,byte)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="byte"/></param>
            public void Put(string arg0, byte arg1)
            {
                IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,char)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="char"/></param>
            public void Put(string arg0, char arg1)
            {
                IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,double)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="double"/></param>
            public void Put(string arg0, double arg1)
            {
                IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,float)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="float"/></param>
            public void Put(string arg0, float arg1)
            {
                IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,int)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="int"/></param>
            public void Put(string arg0, int arg1)
            {
                IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="object"/></param>
            public void Put(string arg0, object arg1)
            {
                IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,long)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="long"/></param>
            public void Put(string arg0, long arg1)
            {
                IExecute("put", arg0, arg1);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/ObjectOutputStream.PutField.html#putStream$PutField.put(java.lang.String,short)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <param name="arg1"><see cref="short"/></param>
            public void Put(string arg0, short arg1)
            {
                IExecute("put", arg0, arg1);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}