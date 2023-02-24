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
    #region IntBuffer
    public partial class IntBuffer
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#allocate(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Allocate(int arg0)
        {
            return SExecute<Java.Nio.IntBuffer>("allocate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#wrap(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Wrap(int[] arg0, int arg1, int arg2)
        {
            return SExecute<Java.Nio.IntBuffer>("wrap", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#wrap(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public static Java.Nio.IntBuffer Wrap(int[] arg0)
        {
            return SExecute<Java.Nio.IntBuffer>("wrap", arg0);
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#get()"/>
        /// </summary>
        
        /// <returns><see langword="int"/></returns>
        public int Get()
        {
            return IExecute<int>("get");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#get(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see langword="int"/></returns>
        public int Get(int arg0)
        {
            return IExecute<int>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#order()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.ByteOrder"/></returns>
        public Java.Nio.ByteOrder Order()
        {
            return IExecute<Java.Nio.ByteOrder>("order");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#asReadOnlyBuffer()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer AsReadOnlyBuffer()
        {
            return IExecute<Java.Nio.IntBuffer>("asReadOnlyBuffer");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#compact()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Compact()
        {
            return IExecute<Java.Nio.IntBuffer>("compact");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#put(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0, int arg1)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#put(int)"/>
        /// </summary>
        /// <param name="arg0"><see langword="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int arg0)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#put(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int[] arg0)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#compareTo(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see langword="object"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(object arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#compareTo(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        public int CompareTo(Java.Nio.IntBuffer arg0)
        {
            return IExecute<int>("compareTo", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#mismatch(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see langword="int"/></returns>
        public int Mismatch(Java.Nio.IntBuffer arg0)
        {
            return IExecute<int>("mismatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#get(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.IntBuffer>("get", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#get(int[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Get(int[] arg0)
        {
            return IExecute<Java.Nio.IntBuffer>("get", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#put(int[],int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see langword="int"/></param>
        /// <param name="arg2"><see langword="int"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(int[] arg0, int arg1, int arg2)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/nio/IntBuffer.html#put(java.nio.IntBuffer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Nio.IntBuffer"/></param>
        /// <returns><see cref="Java.Nio.IntBuffer"/></returns>
        public Java.Nio.IntBuffer Put(Java.Nio.IntBuffer arg0)
        {
            return IExecute<Java.Nio.IntBuffer>("put", arg0);
        }
        
        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}