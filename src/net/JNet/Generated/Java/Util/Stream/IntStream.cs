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

namespace Java.Util.Stream
{
    #region IntStream
    public partial class IntStream
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#concat(java.util.stream.IntStream,java.util.stream.IntStream)
        /// </summary>
        public static Java.Util.Stream.IntStream Concat(Java.Util.Stream.IntStream arg0, Java.Util.Stream.IntStream arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("concat", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#empty()
        /// </summary>
        public static Java.Util.Stream.IntStream Empty()
        {
            return SExecute<Java.Util.Stream.IntStream>("empty");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#generate(java.util.function.IntSupplier)
        /// </summary>
        public static Java.Util.Stream.IntStream Generate(Java.Util.Function.IntSupplier arg0)
        {
            return SExecute<Java.Util.Stream.IntStream>("generate", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#iterate(int,java.util.function.IntPredicate,java.util.function.IntUnaryOperator)
        /// </summary>
        public static Java.Util.Stream.IntStream Iterate(int arg0, Java.Util.Function.IntPredicate arg1, Java.Util.Function.IntUnaryOperator arg2)
        {
            return SExecute<Java.Util.Stream.IntStream>("iterate", arg0, arg1, arg2);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#iterate(int,java.util.function.IntUnaryOperator)
        /// </summary>
        public static Java.Util.Stream.IntStream Iterate(int arg0, Java.Util.Function.IntUnaryOperator arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("iterate", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#of(int...)
        /// </summary>
        public static Java.Util.Stream.IntStream Of(params int[] arg0)
        {
            if (arg0.Length == 0) return SExecute<Java.Util.Stream.IntStream>("of"); else return SExecute<Java.Util.Stream.IntStream>("of", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#of(int)
        /// </summary>
        public static Java.Util.Stream.IntStream Of(int arg0)
        {
            return SExecute<Java.Util.Stream.IntStream>("of", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#range(int,int)
        /// </summary>
        public static Java.Util.Stream.IntStream Range(int arg0, int arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("range", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#rangeClosed(int,int)
        /// </summary>
        public static Java.Util.Stream.IntStream RangeClosed(int arg0, int arg1)
        {
            return SExecute<Java.Util.Stream.IntStream>("rangeClosed", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#builder()
        /// </summary>
        public static Java.Util.Stream.IntStream.Builder BuilderMethod()
        {
            return SExecute<Java.Util.Stream.IntStream.Builder>("builder");
        }
        
        #endregion

        #region Instance methods
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#allMatch(java.util.function.IntPredicate)
        /// </summary>
        public bool AllMatch(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<bool>("allMatch", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#anyMatch(java.util.function.IntPredicate)
        /// </summary>
        public bool AnyMatch(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<bool>("anyMatch", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#noneMatch(java.util.function.IntPredicate)
        /// </summary>
        public bool NoneMatch(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<bool>("noneMatch", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#reduce(int,java.util.function.IntBinaryOperator)
        /// </summary>
        public int Reduce(int arg0, Java.Util.Function.IntBinaryOperator arg1)
        {
            return IExecute<int>("reduce", arg0, arg1);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#sum()
        /// </summary>
        public int Sum()
        {
            return IExecute<int>("sum");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#toArray()
        /// </summary>
        public int[] ToArray()
        {
            return IExecuteArray<int>("toArray");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#summaryStatistics()
        /// </summary>
        public Java.Util.IntSummaryStatistics SummaryStatistics()
        {
            return IExecute<Java.Util.IntSummaryStatistics>("summaryStatistics");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#average()
        /// </summary>
        public Java.Util.OptionalDouble Average()
        {
            return IExecute<Java.Util.OptionalDouble>("average");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#findAny()
        /// </summary>
        public Java.Util.OptionalInt FindAny()
        {
            return IExecute<Java.Util.OptionalInt>("findAny");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#findFirst()
        /// </summary>
        public Java.Util.OptionalInt FindFirst()
        {
            return IExecute<Java.Util.OptionalInt>("findFirst");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#max()
        /// </summary>
        public Java.Util.OptionalInt Max()
        {
            return IExecute<Java.Util.OptionalInt>("max");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#min()
        /// </summary>
        public Java.Util.OptionalInt Min()
        {
            return IExecute<Java.Util.OptionalInt>("min");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#reduce(java.util.function.IntBinaryOperator)
        /// </summary>
        public Java.Util.OptionalInt Reduce(Java.Util.Function.IntBinaryOperator arg0)
        {
            return IExecute<Java.Util.OptionalInt>("reduce", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#asDoubleStream()
        /// </summary>
        public Java.Util.Stream.DoubleStream AsDoubleStream()
        {
            return IExecute<Java.Util.Stream.DoubleStream>("asDoubleStream");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#mapToDouble(java.util.function.IntToDoubleFunction)
        /// </summary>
        public Java.Util.Stream.DoubleStream MapToDouble(Java.Util.Function.IntToDoubleFunction arg0)
        {
            return IExecute<Java.Util.Stream.DoubleStream>("mapToDouble", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#distinct()
        /// </summary>
        public Java.Util.Stream.IntStream Distinct()
        {
            return IExecute<Java.Util.Stream.IntStream>("distinct");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#filter(java.util.function.IntPredicate)
        /// </summary>
        public Java.Util.Stream.IntStream Filter(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("filter", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#limit(long)
        /// </summary>
        public Java.Util.Stream.IntStream Limit(long arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("limit", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#map(java.util.function.IntUnaryOperator)
        /// </summary>
        public Java.Util.Stream.IntStream Map(Java.Util.Function.IntUnaryOperator arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("map", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#peek(java.util.function.IntConsumer)
        /// </summary>
        public Java.Util.Stream.IntStream Peek(Java.Util.Function.IntConsumer arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("peek", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#skip(long)
        /// </summary>
        public Java.Util.Stream.IntStream Skip(long arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("skip", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#sorted()
        /// </summary>
        public Java.Util.Stream.IntStream Sorted()
        {
            return IExecute<Java.Util.Stream.IntStream>("sorted");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#asLongStream()
        /// </summary>
        public Java.Util.Stream.LongStream AsLongStream()
        {
            return IExecute<Java.Util.Stream.LongStream>("asLongStream");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#mapToLong(java.util.function.IntToLongFunction)
        /// </summary>
        public Java.Util.Stream.LongStream MapToLong(Java.Util.Function.IntToLongFunction arg0)
        {
            return IExecute<Java.Util.Stream.LongStream>("mapToLong", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#count()
        /// </summary>
        public long Count()
        {
            return IExecute<long>("count");
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#forEach(java.util.function.IntConsumer)
        /// </summary>
        public void ForEach(Java.Util.Function.IntConsumer arg0)
        {
            IExecute("forEach", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#forEachOrdered(java.util.function.IntConsumer)
        /// </summary>
        public void ForEachOrdered(Java.Util.Function.IntConsumer arg0)
        {
            IExecute("forEachOrdered", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#dropWhile(java.util.function.IntPredicate)
        /// </summary>
        public Java.Util.Stream.IntStream DropWhile(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("dropWhile", arg0);
        }
        /// <summary>
        /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.html#takeWhile(java.util.function.IntPredicate)
        /// </summary>
        public Java.Util.Stream.IntStream TakeWhile(Java.Util.Function.IntPredicate arg0)
        {
            return IExecute<Java.Util.Stream.IntStream>("takeWhile", arg0);
        }
        
        #endregion

        #region Nested classes
        #region Builder
        public partial class Builder
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            public static implicit operator Java.Util.Function.IntConsumer(Java.Util.Stream.IntStream.Builder t) => t.Cast<Java.Util.Function.IntConsumer>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.Builder.html#build()
            /// </summary>
            public Java.Util.Stream.IntStream Build()
            {
                return IExecute<Java.Util.Stream.IntStream>("build");
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.Builder.html#accept(int)
            /// </summary>
            public void Accept(int arg0)
            {
                IExecute("accept", arg0);
            }
            /// <summary>
            /// https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/stream/IntStream.Builder.html#add(int)
            /// </summary>
            public Java.Util.Stream.IntStream.Builder Add(int arg0)
            {
                return IExecute<Java.Util.Stream.IntStream.Builder>("add", arg0);
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion


        #endregion

        // TODO: complete the class
    }
    #endregion
}