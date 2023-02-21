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

namespace Java.Nio
{
    #region Buffer
    public partial class Buffer
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
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#hasArray()
        /// </summary>
        public bool HasArray()
        {
            return IExecute<bool>("hasArray");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#isDirect()
        /// </summary>
        public bool IsDirect()
        {
            return IExecute<bool>("isDirect");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#isReadOnly()
        /// </summary>
        public bool IsReadOnly()
        {
            return IExecute<bool>("isReadOnly");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#arrayOffset()
        /// </summary>
        public int ArrayOffset()
        {
            return IExecute<int>("arrayOffset");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#array()
        /// </summary>
        public object Array()
        {
            return IExecute("array");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#duplicate()
        /// </summary>
        public Java.Nio.Buffer Duplicate()
        {
            return IExecute<Java.Nio.Buffer>("duplicate");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#slice()
        /// </summary>
        public Java.Nio.Buffer Slice()
        {
            return IExecute<Java.Nio.Buffer>("slice");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#hasRemaining()
        /// </summary>
        public bool HasRemaining()
        {
            return IExecute<bool>("hasRemaining");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#capacity()
        /// </summary>
        public int Capacity()
        {
            return IExecute<int>("capacity");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#limit()
        /// </summary>
        public int Limit()
        {
            return IExecute<int>("limit");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#position()
        /// </summary>
        public int Position()
        {
            return IExecute<int>("position");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#remaining()
        /// </summary>
        public int Remaining()
        {
            return IExecute<int>("remaining");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#clear()
        /// </summary>
        public Java.Nio.Buffer Clear()
        {
            return IExecute<Java.Nio.Buffer>("clear");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#flip()
        /// </summary>
        public Java.Nio.Buffer Flip()
        {
            return IExecute<Java.Nio.Buffer>("flip");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#limit(int)
        /// </summary>
        public Java.Nio.Buffer Limit(int arg0)
        {
            return IExecute<Java.Nio.Buffer>("limit", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#mark()
        /// </summary>
        public Java.Nio.Buffer Mark()
        {
            return IExecute<Java.Nio.Buffer>("mark");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#position(int)
        /// </summary>
        public Java.Nio.Buffer Position(int arg0)
        {
            return IExecute<Java.Nio.Buffer>("position", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#reset()
        /// </summary>
        public Java.Nio.Buffer Reset()
        {
            return IExecute<Java.Nio.Buffer>("reset");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#rewind()
        /// </summary>
        public Java.Nio.Buffer Rewind()
        {
            return IExecute<Java.Nio.Buffer>("rewind");
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}