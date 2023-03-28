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
*  This file is generated by MASES.JNetReflector (ver. 1.5.3.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util.Stream
{
    #region StreamSupport
    public partial class StreamSupport
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#stream(java.util.function.Supplier,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public static Java.Util.Stream.Stream Stream(Java.Util.Function.Supplier arg0, int arg1, bool arg2)
        {
            return SExecute<Java.Util.Stream.Stream>("stream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#stream(java.util.Spliterator,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public static Java.Util.Stream.Stream Stream(Java.Util.Spliterator arg0, bool arg1)
        {
            return SExecute<Java.Util.Stream.Stream>("stream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#doubleStream(java.util.function.Supplier,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream DoubleStream(Java.Util.Function.Supplier arg0, int arg1, bool arg2)
        {
            return SExecute<Java.Util.Stream.DoubleStream>("doubleStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#doubleStream(java.util.Spliterator.OfDouble,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfDouble"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream DoubleStream(Java.Util.Spliterator.OfDouble arg0, bool arg1)
        {
            return SExecute<Java.Util.Stream.DoubleStream>("doubleStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#intStream(java.util.function.Supplier,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream IntStream(Java.Util.Function.Supplier arg0, int arg1, bool arg2)
        {
            return SExecute<Java.Util.Stream.IntStream>("intStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#intStream(java.util.Spliterator.OfInt,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfInt"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream IntStream(Java.Util.Spliterator.OfInt arg0, bool arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("intStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#longStream(java.util.function.Supplier,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream LongStream(Java.Util.Function.Supplier arg0, int arg1, bool arg2)
        {
            return SExecute<Java.Util.Stream.LongStream>("longStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#longStream(java.util.Spliterator.OfLong,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfLong"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream LongStream(Java.Util.Spliterator.OfLong arg0, bool arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>("longStream", arg0, arg1);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}