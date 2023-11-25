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
*  This file is generated by MASES.JNetReflector (ver. 2.1.0.0)
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#hasArray()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasArray()
        {
            return IExecute<bool>("hasArray");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#isDirect()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsDirect()
        {
            return IExecute<bool>("isDirect");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#isReadOnly()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool IsReadOnly()
        {
            return IExecute<bool>("isReadOnly");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#arrayOffset()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int ArrayOffset()
        {
            return IExecute<int>("arrayOffset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#array()"/>
        /// </summary>

        /// <returns><see cref="object"/></returns>
        public object Array()
        {
            return IExecute("array");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#duplicate()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Duplicate()
        {
            return IExecute<Java.Nio.Buffer>("duplicate");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#slice()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Slice()
        {
            return IExecute<Java.Nio.Buffer>("slice");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#hasRemaining()"/>
        /// </summary>

        /// <returns><see cref="bool"/></returns>
        public bool HasRemaining()
        {
            return IExecute<bool>("hasRemaining");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#capacity()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Capacity()
        {
            return IExecute<int>("capacity");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#limit()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Limit()
        {
            return IExecute<int>("limit");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#position()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Position()
        {
            return IExecute<int>("position");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#remaining()"/>
        /// </summary>

        /// <returns><see cref="int"/></returns>
        public int Remaining()
        {
            return IExecute<int>("remaining");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#clear()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Clear()
        {
            return IExecute<Java.Nio.Buffer>("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#flip()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Flip()
        {
            return IExecute<Java.Nio.Buffer>("flip");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#limit(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Limit(int arg0)
        {
            return IExecute<Java.Nio.Buffer>("limit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#mark()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Mark()
        {
            return IExecute<Java.Nio.Buffer>("mark");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#position(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Position(int arg0)
        {
            return IExecute<Java.Nio.Buffer>("position", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#reset()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Buffer"/></returns>
        public Java.Nio.Buffer Reset()
        {
            return IExecute<Java.Nio.Buffer>("reset");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/Buffer.html#rewind()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.Buffer"/></returns>
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