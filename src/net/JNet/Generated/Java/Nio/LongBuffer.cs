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
*  This file is generated by MASES.JNetReflector (ver. 2.2.2.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    #region LongBuffer
    public partial class LongBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.LongBuffer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.LongBuffer t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public static Java.Nio.LongBuffer Allocate(int arg0)
        {
            return SExecute<Java.Nio.LongBuffer>(LocalBridgeClazz, "allocate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#wrap(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public static Java.Nio.LongBuffer Wrap(long[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.LongBuffer>(LocalBridgeClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#wrap(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public static Java.Nio.LongBuffer Wrap(long[] arg0)
        {
            return SExecute<Java.Nio.LongBuffer>(LocalBridgeClazz, "wrap", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#order()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public Java.Nio.ByteOrder Order()
        {
            return IExecute<Java.Nio.ByteOrder>("order");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#asReadOnlyBuffer()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer AsReadOnlyBuffer()
        {
            return IExecute<Java.Nio.LongBuffer>("asReadOnlyBuffer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#compact()"/>
        /// </summary>

        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer Compact()
        {
            return IExecute<Java.Nio.LongBuffer>("compact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#put(int,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer Put(int arg0, long arg1)
        {
            return IExecute<Java.Nio.LongBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#put(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer Put(long arg0)
        {
            return IExecute<Java.Nio.LongBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#get()"/>
        /// </summary>

        /// <returns><see cref="long"/></returns>
        public long Get()
        {
            return IExecute<long>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public long Get(int arg0)
        {
            return IExecute<long>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#put(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer Put(long[] arg0)
        {
            return IExecute<Java.Nio.LongBuffer>("put", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#compareTo(java.nio.LongBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.LongBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.LongBuffer arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#mismatch(java.nio.LongBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.LongBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Mismatch(Java.Nio.LongBuffer arg0)
        {
            return IExecute<int>("mismatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#get(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer Get(long[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.LongBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#get(long[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer Get(long[] arg0)
        {
            return IExecute<Java.Nio.LongBuffer>("get", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#put(java.nio.LongBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.LongBuffer"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer Put(Java.Nio.LongBuffer arg0)
        {
            return IExecute<Java.Nio.LongBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/LongBuffer.html#put(long[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.LongBuffer"/></returns>
        public Java.Nio.LongBuffer Put(long[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.LongBuffer>("put", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}