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

namespace Java.Util.Zip
{
    #region Inflater
    public partial class Inflater
    {
        #region Constructors
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#%3Cinit%3E(boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="bool"/></param>
        public Inflater(bool arg0)
            : base(arg0)
        {
        }
        
        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#getAdler()"/> 
        /// </summary>
        public int Adler
        {
            get { return IExecute<int>("getAdler"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#getBytesRead()"/> 
        /// </summary>
        public long BytesRead
        {
            get { return IExecute<long>("getBytesRead"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#getBytesWritten()"/> 
        /// </summary>
        public long BytesWritten
        {
            get { return IExecute<long>("getBytesWritten"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#getRemaining()"/> 
        /// </summary>
        public int Remaining
        {
            get { return IExecute<int>("getRemaining"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#getTotalIn()"/> 
        /// </summary>
        public int TotalIn
        {
            get { return IExecute<int>("getTotalIn"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#getTotalOut()"/> 
        /// </summary>
        public int TotalOut
        {
            get { return IExecute<int>("getTotalOut"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#finished()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool Finished()
        {
            return IExecute<bool>("finished");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#needsDictionary()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool NeedsDictionary()
        {
            return IExecute<bool>("needsDictionary");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#needsInput()"/>
        /// </summary>
        
        /// <returns><see langword="bool"/></returns>
        public bool NeedsInput()
        {
            return IExecute<bool>("needsInput");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#inflate(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Util.Zip.DataFormatException"/>
        public int Inflate(byte[] arg0, int arg1, int arg2)
        {
            return IExecute<int>("inflate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#inflate(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Util.Zip.DataFormatException"/>
        public int Inflate(byte[] arg0)
        {
            return IExecute<int>("inflate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#inflate(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        /// <exception cref="Java.Util.Zip.DataFormatException"/>
        public int Inflate(Java.Nio.ByteBuffer arg0)
        {
            return IExecute<int>("inflate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#end()"/>
        /// </summary>
        public void End()
        {
            IExecute("end");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#reset()"/>
        /// </summary>
        public void Reset()
        {
            IExecute("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#setDictionary(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetDictionary(byte[] arg0, int arg1, int arg2)
        {
            IExecute("setDictionary", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#setDictionary(byte[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        public void SetDictionary(byte[] arg0)
        {
            IExecute("setDictionary", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#setInput(byte[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="byte"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        public void SetInput(byte[] arg0, int arg1, int arg2)
        {
            IExecute("setInput", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/zip/Inflater.html#setInput(java.nio.ByteBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ByteBuffer"/></param>
        public void SetInput(Java.Nio.ByteBuffer arg0)
        {
            IExecute("setInput", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}