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
    #region Collector
    public partial class Collector
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#of(java.util.function.Supplier,java.util.function.BiConsumer,java.util.function.BinaryOperator,java.util.function.Function,java.util.stream.Collector.Characteristics[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg4"><see cref="Java.Util.Stream.Collector.Characteristics"/></param>
        /// <returns><see cref="Java.Util.Stream.Collector"/></returns>
        public static Java.Util.Stream.Collector Of(Java.Util.Function.Supplier arg0, Java.Util.Function.BiConsumer arg1, Java.Util.Function.BinaryOperator arg2, Java.Util.Function.Function arg3, params Java.Util.Stream.Collector.Characteristics[] arg4)
        {
            if (arg4.Length == 0) return SExecute<Java.Util.Stream.Collector>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3); else return SExecute<Java.Util.Stream.Collector>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#of(java.util.function.Supplier,java.util.function.BiConsumer,java.util.function.BinaryOperator,java.util.stream.Collector.Characteristics[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <param name="arg3"><see cref="Java.Util.Stream.Collector.Characteristics"/></param>
        /// <returns><see cref="Java.Util.Stream.Collector"/></returns>
        public static Java.Util.Stream.Collector Of(Java.Util.Function.Supplier arg0, Java.Util.Function.BiConsumer arg1, Java.Util.Function.BinaryOperator arg2, params Java.Util.Stream.Collector.Characteristics[] arg3)
        {
            if (arg3.Length == 0) return SExecute<Java.Util.Stream.Collector>(LocalBridgeClazz, "of", arg0, arg1, arg2); else return SExecute<Java.Util.Stream.Collector>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#accumulator()"/> 
        /// </summary>
        public Java.Util.Function.BiConsumer Accumulator
        {
            get { return IExecute<Java.Util.Function.BiConsumer>("accumulator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#combiner()"/> 
        /// </summary>
        public Java.Util.Function.BinaryOperator Combiner
        {
            get { return IExecute<Java.Util.Function.BinaryOperator>("combiner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#finisher()"/> 
        /// </summary>
        public Java.Util.Function.Function Finisher
        {
            get { return IExecute<Java.Util.Function.Function>("finisher"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#supplier()"/> 
        /// </summary>
        public Java.Util.Function.Supplier Supplier
        {
            get { return IExecute<Java.Util.Function.Supplier>("supplier"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#characteristics()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set CharacteristicsMethod()
        {
            return IExecute<Java.Util.Set>("characteristics");
        }

        #endregion

        #region Nested classes
        #region Characteristics
        public partial class Characteristics
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators

            #endregion

            #region Fields
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.Characteristics.html#CONCURRENT"/>
            /// </summary>
            public static Java.Util.Stream.Collector.Characteristics CONCURRENT { get { return SGetField<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "CONCURRENT"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.Characteristics.html#IDENTITY_FINISH"/>
            /// </summary>
            public static Java.Util.Stream.Collector.Characteristics IDENTITY_FINISH { get { return SGetField<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "IDENTITY_FINISH"); } }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.Characteristics.html#UNORDERED"/>
            /// </summary>
            public static Java.Util.Stream.Collector.Characteristics UNORDERED { get { return SGetField<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "UNORDERED"); } }

            #endregion

            #region Static methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.Characteristics.html#values()"/> 
            /// </summary>
            public static Java.Util.Stream.Collector.Characteristics[] Values
            {
                get { return SExecuteArray<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "values"); }
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.Characteristics.html#valueOf(java.lang.String)"/>
            /// </summary>
            /// <param name="arg0"><see cref="string"/></param>
            /// <returns><see cref="Java.Util.Stream.Collector.Characteristics"/></returns>
            public static Java.Util.Stream.Collector.Characteristics ValueOf(string arg0)
            {
                return SExecute<Java.Util.Stream.Collector.Characteristics>(LocalBridgeClazz, "valueOf", arg0);
            }

            #endregion

            #region Instance methods

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

    
        #endregion

        // TODO: complete the class
    }
    #endregion

    #region Collector<T, A, R>
    public partial class Collector<T, A, R>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.Stream.Collector{T, A, R}"/> to <see cref="Java.Util.Stream.Collector"/>
        /// </summary>
        public static implicit operator Java.Util.Stream.Collector(Java.Util.Stream.Collector<T, A, R> t) => t.Cast<Java.Util.Stream.Collector>();

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#of(java.util.function.Supplier,java.util.function.BiConsumer,java.util.function.BinaryOperator,java.util.function.Function,java.util.stream.Collector.Characteristics[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <param name="arg3"><see cref="Java.Util.Function.Function"/></param>
        /// <param name="arg4"><see cref="Java.Util.Stream.Collector.Characteristics"/></param>
        /// <returns><see cref="Java.Util.Stream.Collector"/></returns>
        public static Java.Util.Stream.Collector<T, A, R> Of(Java.Util.Function.Supplier<A> arg0, Java.Util.Function.BiConsumer<A, T> arg1, Java.Util.Function.BinaryOperator<A> arg2, Java.Util.Function.Function<A, R> arg3, params Java.Util.Stream.Collector.Characteristics[] arg4)
        {
            if (arg4.Length == 0) return SExecute<Java.Util.Stream.Collector<T, A, R>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3); else return SExecute<Java.Util.Stream.Collector<T, A, R>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3, arg4);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#of(java.util.function.Supplier,java.util.function.BiConsumer,java.util.function.BinaryOperator,java.util.stream.Collector.Characteristics[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BinaryOperator"/></param>
        /// <param name="arg3"><see cref="Java.Util.Stream.Collector.Characteristics"/></param>
        /// <returns><see cref="Java.Util.Stream.Collector"/></returns>
        public static Java.Util.Stream.Collector<T, R, R> Of(Java.Util.Function.Supplier<R> arg0, Java.Util.Function.BiConsumer<R, T> arg1, Java.Util.Function.BinaryOperator<R> arg2, params Java.Util.Stream.Collector.Characteristics[] arg3)
        {
            if (arg3.Length == 0) return SExecute<Java.Util.Stream.Collector<T, R, R>>(LocalBridgeClazz, "of", arg0, arg1, arg2); else return SExecute<Java.Util.Stream.Collector<T, R, R>>(LocalBridgeClazz, "of", arg0, arg1, arg2, arg3);
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#accumulator()"/> 
        /// </summary>
        public Java.Util.Function.BiConsumer<A, T> Accumulator
        {
            get { return IExecute<Java.Util.Function.BiConsumer<A, T>>("accumulator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#combiner()"/> 
        /// </summary>
        public Java.Util.Function.BinaryOperator<A> Combiner
        {
            get { return IExecute<Java.Util.Function.BinaryOperator<A>>("combiner"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#finisher()"/> 
        /// </summary>
        public Java.Util.Function.Function<A, R> Finisher
        {
            get { return IExecute<Java.Util.Function.Function<A, R>>("finisher"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#supplier()"/> 
        /// </summary>
        public Java.Util.Function.Supplier<A> Supplier
        {
            get { return IExecute<Java.Util.Function.Supplier<A>>("supplier"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/Collector.html#characteristics()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Set"/></returns>
        public Java.Util.Set<Java.Util.Stream.Collector.Characteristics> CharacteristicsMethod()
        {
            return IExecute<Java.Util.Set<Java.Util.Stream.Collector.Characteristics>>("characteristics");
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}