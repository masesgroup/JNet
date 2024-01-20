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
*  This file is generated by MASES.JNetReflector (ver. 2.2.1.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Zip
{
    #region Deflater
    public partial class Deflater
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#%3Cinit%3E(int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        public Deflater(int arg0, bool arg1)
            : base(arg0, arg1)
        {
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#%3Cinit%3E(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public Deflater(int arg0)
            : base(arg0)
        {
        }

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#BEST_COMPRESSION"/>
        /// </summary>
        public static int BEST_COMPRESSION { get { return SGetField<int>(LocalBridgeClazz, "BEST_COMPRESSION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#BEST_SPEED"/>
        /// </summary>
        public static int BEST_SPEED { get { return SGetField<int>(LocalBridgeClazz, "BEST_SPEED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#DEFAULT_COMPRESSION"/>
        /// </summary>
        public static int DEFAULT_COMPRESSION { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_COMPRESSION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#DEFAULT_STRATEGY"/>
        /// </summary>
        public static int DEFAULT_STRATEGY { get { return SGetField<int>(LocalBridgeClazz, "DEFAULT_STRATEGY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#DEFLATED"/>
        /// </summary>
        public static int DEFLATED { get { return SGetField<int>(LocalBridgeClazz, "DEFLATED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#FILTERED"/>
        /// </summary>
        public static int FILTERED { get { return SGetField<int>(LocalBridgeClazz, "FILTERED"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#FULL_FLUSH"/>
        /// </summary>
        public static int FULL_FLUSH { get { return SGetField<int>(LocalBridgeClazz, "FULL_FLUSH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#HUFFMAN_ONLY"/>
        /// </summary>
        public static int HUFFMAN_ONLY { get { return SGetField<int>(LocalBridgeClazz, "HUFFMAN_ONLY"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#NO_COMPRESSION"/>
        /// </summary>
        public static int NO_COMPRESSION { get { return SGetField<int>(LocalBridgeClazz, "NO_COMPRESSION"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#NO_FLUSH"/>
        /// </summary>
        public static int NO_FLUSH { get { return SGetField<int>(LocalBridgeClazz, "NO_FLUSH"); } }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#SYNC_FLUSH"/>
        /// </summary>
        public static int SYNC_FLUSH { get { return SGetField<int>(LocalBridgeClazz, "SYNC_FLUSH"); } }

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getAdler()"/> 
        /// </summary>
        public int Adler
        {
            get { return IExecute<int>("getAdler"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getBytesRead()"/> 
        /// </summary>
        public long BytesRead
        {
            get { return IExecute<long>("getBytesRead"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getBytesWritten()"/> 
        /// </summary>
        public long BytesWritten
        {
            get { return IExecute<long>("getBytesWritten"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getTotalIn()"/> 
        /// </summary>
        public int TotalIn
        {
            get { return IExecute<int>("getTotalIn"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#getTotalOut()"/> 
        /// </summary>
        public int TotalOut
        {
            get { return IExecute<int>("getTotalOut"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#finished()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool Finished()
        {
            return IExecute<bool>("finished");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#needsInput()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool NeedsInput()
        {
            return IExecute<bool>("needsInput");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(byte[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(byte[] arg0, int arg1, int arg2, int arg3)
        {
            return IExecute<int>("deflate", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("deflate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(byte[] arg0)
        {
            return IExecute<int>("deflate", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(java.nio.ByteBuffer,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(Java.Nio.ByteBuffer arg0, int arg1)
        {
            return IExecute<int>("deflate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#deflate(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Deflate(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<int>("deflate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#end()"/>
        /// </summary>
        public void End()
        {
            IExecute("end");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#finish()"/>
        /// </summary>
        public void Finish()
        {
            IExecute("finish");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setDictionary(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetDictionary(byte[] arg0, int arg1, int arg2)
        {
            IExecute("setDictionary", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setDictionary(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetDictionary(byte[] arg0)
        {
            IExecute("setDictionary", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setDictionary(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void SetDictionary(Java.Nio.ByteBuffer arg0)
        {
            IExecute("setDictionary", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setInput(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetInput(byte[] arg0, int arg1, int arg2)
        {
            IExecute("setInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setInput(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetInput(byte[] arg0)
        {
            IExecute("setInput", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setInput(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void SetInput(Java.Nio.ByteBuffer arg0)
        {
            IExecute("setInput", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setLevel(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetLevel(int arg0)
        {
            IExecute("setLevel", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Deflater.html#setStrategy(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        public void SetStrategy(int arg0)
        {
            IExecute("setStrategy", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}