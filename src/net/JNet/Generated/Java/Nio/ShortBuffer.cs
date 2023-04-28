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
*  This file is generated by MASES.JNetReflector (ver. 1.5.4.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Nio
{
    #region ShortBuffer
    public partial class ShortBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Nio.ShortBuffer"/> to <see cref="Java.Lang.Comparable"/>
        /// </summary>
        public static implicit operator Java.Lang.Comparable(Java.Nio.ShortBuffer t) => t.Cast<Java.Lang.Comparable>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public static Java.Nio.ShortBuffer Allocate(int arg0)
        {
            return SExecute<Java.Nio.ShortBuffer>(LocalClazz, "allocate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#wrap(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public static Java.Nio.ShortBuffer Wrap(short[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.ShortBuffer>(LocalClazz, "wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#wrap(short[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public static Java.Nio.ShortBuffer Wrap(short[] arg0)
        {
            return SExecute<Java.Nio.ShortBuffer>(LocalClazz, "wrap", new object[] { arg0 });
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#asReadOnlyBuffer()"/> 
        /// </summary>
        public Java.Nio.ShortBuffer AsReadOnlyBuffer
        {
            get { return IExecute<Java.Nio.ShortBuffer>("asReadOnlyBuffer"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#compact()"/> 
        /// </summary>
        public Java.Nio.ShortBuffer Compact
        {
            get { return IExecute<Java.Nio.ShortBuffer>("compact"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#order()"/> 
        /// </summary>
        public Java.Nio.ByteOrder Order
        {
            get { return IExecute<Java.Nio.ByteOrder>("order"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#put(int,short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="short"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public Java.Nio.ShortBuffer Put(int arg0, short arg1)
        {
            return IExecute<Java.Nio.ShortBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#put(short)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public Java.Nio.ShortBuffer Put(short arg0)
        {
            return IExecute<Java.Nio.ShortBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#get()"/>
        /// </summary>

        /// <returns><see cref="short"/></returns>
        public short Get()
        {
            return IExecute<short>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="short"/></returns>
        public short Get(int arg0)
        {
            return IExecute<short>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#put(short[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public Java.Nio.ShortBuffer Put(short[] arg0)
        {
            return IExecute<Java.Nio.ShortBuffer>("put", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#compareTo(java.nio.ShortBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ShortBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int CompareTo(Java.Nio.ShortBuffer arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#mismatch(java.nio.ShortBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ShortBuffer"/></param>
        /// <returns><see cref="int"/></returns>
        public int Mismatch(Java.Nio.ShortBuffer arg0)
        {
            return IExecute<int>("mismatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#get(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public Java.Nio.ShortBuffer Get(short[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.ShortBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#get(short[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public Java.Nio.ShortBuffer Get(short[] arg0)
        {
            return IExecute<Java.Nio.ShortBuffer>("get", new object[] { arg0 });
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#put(java.nio.ShortBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.ShortBuffer"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public Java.Nio.ShortBuffer Put(Java.Nio.ShortBuffer arg0)
        {
            return IExecute<Java.Nio.ShortBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/ShortBuffer.html#put(short[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="short"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.ShortBuffer"/></returns>
        public Java.Nio.ShortBuffer Put(short[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.ShortBuffer>("put", arg0, arg1, arg2);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}