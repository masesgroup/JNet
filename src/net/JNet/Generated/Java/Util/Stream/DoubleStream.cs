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
    #region DoubleStream
    public partial class DoubleStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#empty()"/> 
        /// </summary>
        public static Java.Util.Stream.DoubleStream Empty
        {
            get { return SExecute<Java.Util.Stream.DoubleStream>(LocalClazz, "empty"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#concat(java.util.stream.DoubleStream,java.util.stream.DoubleStream)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Stream.DoubleStream"/></param>
        /// <param name="arg1"><see cref="Java.Util.Stream.DoubleStream"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Concat(Java.Util.Stream.DoubleStream arg0, Java.Util.Stream.DoubleStream arg1)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalClazz, "concat", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#generate(java.util.function.DoubleSupplier)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleSupplier"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Generate(Java.Util.Function.DoubleSupplier arg0)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalClazz, "generate", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#iterate(double,java.util.function.DoublePredicate,java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Iterate(double arg0, Java.Util.Function.DoublePredicate arg1, Java.Util.Function.DoubleUnaryOperator arg2)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalClazz, "iterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#iterate(double,java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Iterate(double arg0, Java.Util.Function.DoubleUnaryOperator arg1)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalClazz, "iterate", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#of(double[])"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Of(params double[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Util.Stream.DoubleStream>(LocalClazz, "of"); else return SExecute<Java.Util.Stream.DoubleStream>(LocalClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#of(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public static Java.Util.Stream.DoubleStream Of(double arg0)
        {
            return SExecute<Java.Util.Stream.DoubleStream>(LocalClazz, "of", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#builder()"/>
        /// </summary>

        /// <returns><see cref="Java.Util.Stream.DoubleStream.Builder"/></returns>
        public static Java.Util.Stream.DoubleStream.Builder BuilderMethod()
        {
            return SExecute<Java.Util.Stream.DoubleStream.Builder>(LocalClazz, "builder");
        }

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#average()"/> 
        /// </summary>
        public Java.Util.OptionalDouble Average
        {
            get { return IExecute<Java.Util.OptionalDouble>("average"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#boxed()"/> 
        /// </summary>
        public Java.Util.Stream.Stream<double?> Boxed
        {
            get { return IExecute<Java.Util.Stream.Stream<double?>>("boxed"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#count()"/> 
        /// </summary>
        public long Count
        {
            get { return IExecute<long>("count"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#distinct()"/> 
        /// </summary>
        public Java.Util.Stream.DoubleStream Distinct
        {
            get { return IExecute<Java.Util.Stream.DoubleStream>("distinct"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#findAny()"/> 
        /// </summary>
        public Java.Util.OptionalDouble FindAny
        {
            get { return IExecute<Java.Util.OptionalDouble>("findAny"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#findFirst()"/> 
        /// </summary>
        public Java.Util.OptionalDouble FindFirst
        {
            get { return IExecute<Java.Util.OptionalDouble>("findFirst"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#iterator()"/> 
        /// </summary>
        public Java.Util.Iterator Iterator
        {
            get { return IExecute<Java.Util.Iterator>("iterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#max()"/> 
        /// </summary>
        public Java.Util.OptionalDouble Max
        {
            get { return IExecute<Java.Util.OptionalDouble>("max"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#min()"/> 
        /// </summary>
        public Java.Util.OptionalDouble Min
        {
            get { return IExecute<Java.Util.OptionalDouble>("min"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#parallel()"/> 
        /// </summary>
        public Java.Util.Stream.BaseStream Parallel
        {
            get { return IExecute<Java.Util.Stream.BaseStream>("parallel"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#sequential()"/> 
        /// </summary>
        public Java.Util.Stream.BaseStream Sequential
        {
            get { return IExecute<Java.Util.Stream.BaseStream>("sequential"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#sorted()"/> 
        /// </summary>
        public Java.Util.Stream.DoubleStream Sorted
        {
            get { return IExecute<Java.Util.Stream.DoubleStream>("sorted"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#spliterator()"/> 
        /// </summary>
        public Java.Util.Spliterator Spliterator
        {
            get { return IExecute<Java.Util.Spliterator>("spliterator"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#sum()"/> 
        /// </summary>
        public double Sum
        {
            get { return IExecute<double>("sum"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#summaryStatistics()"/> 
        /// </summary>
        public Java.Util.DoubleSummaryStatistics SummaryStatistics
        {
            get { return IExecute<Java.Util.DoubleSummaryStatistics>("summaryStatistics"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#toArray()"/> 
        /// </summary>
        public double[] ToArray
        {
            get { return IExecuteArray<double>("toArray"); }
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#collect(java.util.function.Supplier,java.util.function.ObjDoubleConsumer,java.util.function.BiConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Supplier"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.ObjDoubleConsumer"/></param>
        /// <param name="arg2"><see cref="Java.Util.Function.BiConsumer"/></param>
        /// <typeparam name="R"></typeparam>
        /// <returns><typeparamref name="R"/></returns>
        public R Collect<R>(Java.Util.Function.Supplier<R> arg0, Java.Util.Function.ObjDoubleConsumer<R> arg1, Java.Util.Function.BiConsumer<R, R> arg2)
        {
            return IExecute<R>("collect", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#mapToObj(java.util.function.DoubleFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleFunction"/></param>
        /// <typeparam name="U"></typeparam>
        /// <typeparam name="Arg0ExtendsU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.Stream"/></returns>
        public Java.Util.Stream.Stream<U> MapToObj<U, Arg0ExtendsU>(Java.Util.Function.DoubleFunction<Arg0ExtendsU> arg0) where Arg0ExtendsU: U
        {
            return IExecute<Java.Util.Stream.Stream<U>>("mapToObj", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#allMatch(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AllMatch(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecute<bool>("allMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#anyMatch(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool AnyMatch(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecute<bool>("anyMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#noneMatch(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool NoneMatch(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecute<bool>("noneMatch", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#reduce(double,java.util.function.DoubleBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="Java.Util.Function.DoubleBinaryOperator"/></param>
        /// <returns><see cref="double"/></returns>
        public double Reduce(double arg0, Java.Util.Function.DoubleBinaryOperator arg1)
        {
            return IExecute<double>("reduce", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#reduce(java.util.function.DoubleBinaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleBinaryOperator"/></param>
        /// <returns><see cref="Java.Util.OptionalDouble"/></returns>
        public Java.Util.OptionalDouble Reduce(Java.Util.Function.DoubleBinaryOperator arg0)
        {
            return IExecute<Java.Util.OptionalDouble>("reduce", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#filter(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Filter(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("filter", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#flatMap(java.util.function.DoubleFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleFunction"/></param>
        /// <typeparam name="Arg0ExtendsJava_Util_Stream_DoubleStream"><see cref="Java.Util.Stream.DoubleStream"/></typeparam>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream FlatMap<Arg0ExtendsJava_Util_Stream_DoubleStream>(Java.Util.Function.DoubleFunction<Arg0ExtendsJava_Util_Stream_DoubleStream> arg0) where Arg0ExtendsJava_Util_Stream_DoubleStream: Java.Util.Stream.DoubleStream
        {
            return IExecute<Java.Util.Stream.DoubleStream>("flatMap", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#limit(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Limit(long arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("limit", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#map(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Map(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("map", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#peek(java.util.function.DoubleConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Peek(Java.Util.Function.DoubleConsumer arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("peek", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#skip(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream Skip(long arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("skip", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#mapToInt(java.util.function.DoubleToIntFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleToIntFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.IntStream"/></returns>
        public Java.Util.Stream.IntStream MapToInt(Java.Util.Function.DoubleToIntFunction arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("mapToInt", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#mapToLong(java.util.function.DoubleToLongFunction)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleToLongFunction"/></param>
        /// <returns><see cref="Java.Util.Stream.LongStream"/></returns>
        public Java.Util.Stream.LongStream MapToLong(Java.Util.Function.DoubleToLongFunction arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("mapToLong", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#forEach(java.util.function.DoubleConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        public void ForEach(Java.Util.Function.DoubleConsumer arg0)
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#forEachOrdered(java.util.function.DoubleConsumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
        public void ForEachOrdered(Java.Util.Function.DoubleConsumer arg0)
        {
            IExecute("forEachOrdered", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#dropWhile(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream DropWhile(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("dropWhile", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/DoubleStream.html#takeWhile(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Stream.DoubleStream"/></returns>
        public Java.Util.Stream.DoubleStream TakeWhile(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("takeWhile", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}