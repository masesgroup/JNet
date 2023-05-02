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
        /// <typeparam name="T"></typeparam>
        /// <typeparam name="Arg0ExtendsJava_Util_Spliterator_T_"><see cref="Java.Util.Spliterator{T}"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public static Java.Util.Stream.Stream<T> Stream<T, Arg0ExtendsJava_Util_Spliterator_T_>(Java.Util.Function.Supplier<Arg0ExtendsJava_Util_Spliterator_T_> arg0, int arg1, bool arg2) where Arg0ExtendsJava_Util_Spliterator_T_: Java.Util.Spliterator<T>
        {
            return SExecute<Java.Util.Stream.Stream<T>>(LocalBridgeClazz, "stream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#stream(java.util.Spliterator,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <typeparam name="T"></typeparam>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public static Java.Util.Stream.Stream<T> Stream<T>(Java.Util.Spliterator<T> arg0, bool arg1)
        {
            return SExecute<Java.Util.Stream.Stream<T>>(LocalBridgeClazz, "stream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#doubleStream(java.util.function.Supplier,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Spliterator_OfDouble"><see cref="Java.Util.Spliterator.OfDouble"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream DoubleStream<Arg0ExtendsJava_Util_Spliterator_OfDouble>(Java.Util.Function.Supplier<Arg0ExtendsJava_Util_Spliterator_OfDouble> arg0, int arg1, bool arg2) where Arg0ExtendsJava_Util_Spliterator_OfDouble: Java.Util.Spliterator.OfDouble
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "doubleStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#doubleStream(java.util.Spliterator.OfDouble,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfDouble"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream DoubleStream(Java.Util.Spliterator.OfDouble arg0, bool arg1)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalBridgeClazz, "doubleStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#intStream(java.util.function.Supplier,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Spliterator_OfInt"><see cref="Java.Util.Spliterator.OfInt"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream IntStream<Arg0ExtendsJava_Util_Spliterator_OfInt>(Java.Util.Function.Supplier<Arg0ExtendsJava_Util_Spliterator_OfInt> arg0, int arg1, bool arg2) where Arg0ExtendsJava_Util_Spliterator_OfInt: Java.Util.Spliterator.OfInt
        {
            return SExecute<Java.Util.Stream.IntStream>(LocalBridgeClazz, "intStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#intStream(java.util.Spliterator.OfInt,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfInt"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public static Java.Util.Stream.IntStream IntStream(Java.Util.Spliterator.OfInt arg0, bool arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>(LocalBridgeClazz, "intStream", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#longStream(java.util.function.Supplier,int,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="bool"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Spliterator_OfLong"><see cref="Java.Util.Spliterator.OfLong"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream LongStream<Arg0ExtendsJava_Util_Spliterator_OfLong>(Java.Util.Function.Supplier<Arg0ExtendsJava_Util_Spliterator_OfLong> arg0, int arg1, bool arg2) where Arg0ExtendsJava_Util_Spliterator_OfLong: Java.Util.Spliterator.OfLong
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "longStream", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/StreamSupport.html#longStream(java.util.Spliterator.OfLong,boolean)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfLong"/></param>
        /// <param name="arg1"><see cref="bool"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public static Java.Util.Stream.LongStream LongStream(Java.Util.Spliterator.OfLong arg0, bool arg1)
        {
            return SExecute<Java.Util.Stream.LongStream>(LocalBridgeClazz, "longStream", arg0, arg1);
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