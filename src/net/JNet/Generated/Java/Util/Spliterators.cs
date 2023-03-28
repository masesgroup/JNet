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

namespace Java.Util
{
    #region Spliterators
    public partial class Spliterators
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators

        #endregion

        #region Fields

        #endregion

        #region Static methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#iterator(java.util.Spliterator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator"/></param>
        /// <returns><see cref="Java.Util.Iterator"/></returns>
        public static Java.Util.Iterator Iterator(Java.Util.Spliterator arg0)
        {
            return SExecute<Java.Util.Iterator>("iterator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#emptySpliterator()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator EmptySpliteratorMethod()
        {
            return SExecute<Java.Util.Spliterator>("emptySpliterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(java.lang.Object[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator Spliterator(object[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Util.Spliterator>("spliterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(java.lang.Object[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator Spliterator(object[] arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator>("spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(java.util.Collection,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Collection"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator Spliterator(Java.Util.Collection arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator>("spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(java.util.Iterator,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator Spliterator(Java.Util.Iterator arg0, long arg1, int arg2)
        {
            return SExecute<Java.Util.Spliterator>("spliterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliteratorUnknownSize(java.util.Iterator,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Iterator"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator"/></returns>
        public static Java.Util.Spliterator SpliteratorUnknownSize(Java.Util.Iterator arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator>("spliteratorUnknownSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#iterator(java.util.Spliterator.OfDouble)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfDouble"/></param>
        /// <returns><see cref="Java.Util.PrimitiveIterator.OfDouble"/></returns>
        public static Java.Util.PrimitiveIterator.OfDouble Iterator(Java.Util.Spliterator.OfDouble arg0)
        {
            return SExecute<Java.Util.PrimitiveIterator.OfDouble>("iterator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#iterator(java.util.Spliterator.OfInt)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfInt"/></param>
        /// <returns><see cref="Java.Util.PrimitiveIterator.OfInt"/></returns>
        public static Java.Util.PrimitiveIterator.OfInt Iterator(Java.Util.Spliterator.OfInt arg0)
        {
            return SExecute<Java.Util.PrimitiveIterator.OfInt>("iterator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#iterator(java.util.Spliterator.OfLong)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Spliterator.OfLong"/></param>
        /// <returns><see cref="Java.Util.PrimitiveIterator.OfLong"/></returns>
        public static Java.Util.PrimitiveIterator.OfLong Iterator(Java.Util.Spliterator.OfLong arg0)
        {
            return SExecute<Java.Util.PrimitiveIterator.OfLong>("iterator", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#emptyDoubleSpliterator()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble EmptyDoubleSpliterator()
        {
            return SExecute<Java.Util.Spliterator.OfDouble>("emptyDoubleSpliterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(double[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble Spliterator(double[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Util.Spliterator.OfDouble>("spliterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(double[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble Spliterator(double[] arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfDouble>("spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(java.util.PrimitiveIterator.OfDouble,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfDouble"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble Spliterator(Java.Util.PrimitiveIterator.OfDouble arg0, long arg1, int arg2)
        {
            return SExecute<Java.Util.Spliterator.OfDouble>("spliterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliteratorUnknownSize(java.util.PrimitiveIterator.OfDouble,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfDouble"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
        public static Java.Util.Spliterator.OfDouble SpliteratorUnknownSize(Java.Util.PrimitiveIterator.OfDouble arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfDouble>("spliteratorUnknownSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#emptyIntSpliterator()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt EmptyIntSpliterator()
        {
            return SExecute<Java.Util.Spliterator.OfInt>("emptyIntSpliterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(int[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt Spliterator(int[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Util.Spliterator.OfInt>("spliterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(int[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt Spliterator(int[] arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfInt>("spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(java.util.PrimitiveIterator.OfInt,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfInt"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt Spliterator(Java.Util.PrimitiveIterator.OfInt arg0, long arg1, int arg2)
        {
            return SExecute<Java.Util.Spliterator.OfInt>("spliterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliteratorUnknownSize(java.util.PrimitiveIterator.OfInt,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfInt"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
        public static Java.Util.Spliterator.OfInt SpliteratorUnknownSize(Java.Util.PrimitiveIterator.OfInt arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfInt>("spliteratorUnknownSize", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#emptyLongSpliterator()"/>
        /// </summary>
        
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong EmptyLongSpliterator()
        {
            return SExecute<Java.Util.Spliterator.OfLong>("emptyLongSpliterator");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(java.util.PrimitiveIterator.OfLong,long,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfLong"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong Spliterator(Java.Util.PrimitiveIterator.OfLong arg0, long arg1, int arg2)
        {
            return SExecute<Java.Util.Spliterator.OfLong>("spliterator", arg0, arg1, arg2);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(long[],int,int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <param name="arg2"><see cref="int"/></param>
        /// <param name="arg3"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong Spliterator(long[] arg0, int arg1, int arg2, int arg3)
        {
            return SExecute<Java.Util.Spliterator.OfLong>("spliterator", arg0, arg1, arg2, arg3);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliterator(long[],int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong Spliterator(long[] arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfLong>("spliterator", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.html#spliteratorUnknownSize(java.util.PrimitiveIterator.OfLong,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.PrimitiveIterator.OfLong"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
        public static Java.Util.Spliterator.OfLong SpliteratorUnknownSize(Java.Util.PrimitiveIterator.OfLong arg0, int arg1)
        {
            return SExecute<Java.Util.Spliterator.OfLong>("spliteratorUnknownSize", arg0, arg1);
        }
        
        #endregion

        #region Instance methods

        #endregion

        #region Nested classes
        #region AbstractDoubleSpliterator
        public partial class AbstractDoubleSpliterator
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractDoubleSpliterator.html#characteristics()"/>
            /// </summary>
            
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecute<int>("characteristics");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractDoubleSpliterator.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator.OfDouble"/></returns>
            public Java.Util.Spliterator.OfDouble TrySplit()
            {
                return IExecute<Java.Util.Spliterator.OfDouble>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractDoubleSpliterator.html#estimateSize()"/>
            /// </summary>
            
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecute<long>("estimateSize");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractIntSpliterator
        public partial class AbstractIntSpliterator
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractIntSpliterator.html#characteristics()"/>
            /// </summary>
            
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecute<int>("characteristics");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractIntSpliterator.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator.OfInt"/></returns>
            public Java.Util.Spliterator.OfInt TrySplit()
            {
                return IExecute<Java.Util.Spliterator.OfInt>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractIntSpliterator.html#estimateSize()"/>
            /// </summary>
            
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecute<long>("estimateSize");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractLongSpliterator
        public partial class AbstractLongSpliterator
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractLongSpliterator.html#characteristics()"/>
            /// </summary>
            
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecute<int>("characteristics");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractLongSpliterator.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator.OfLong"/></returns>
            public Java.Util.Spliterator.OfLong TrySplit()
            {
                return IExecute<Java.Util.Spliterator.OfLong>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractLongSpliterator.html#estimateSize()"/>
            /// </summary>
            
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecute<long>("estimateSize");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractSpliterator
        public partial class AbstractSpliterator
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Spliterators.AbstractSpliterator"/> to <see cref="Java.Util.Spliterator"/>
            /// </summary>
            public static implicit operator Java.Util.Spliterator(Java.Util.Spliterators.AbstractSpliterator t) => t.Cast<Java.Util.Spliterator>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractSpliterator.html#characteristics()"/>
            /// </summary>
            
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecute<int>("characteristics");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractSpliterator.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator"/></returns>
            public Java.Util.Spliterator TrySplit()
            {
                return IExecute<Java.Util.Spliterator>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractSpliterator.html#estimateSize()"/>
            /// </summary>
            
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecute<long>("estimateSize");
            }
            
            #endregion

            // TODO: complete the class
        }
        #endregion

        #region AbstractSpliterator<T>
        public partial class AbstractSpliterator<T>
        {
            #region Constructors

            #endregion

            #region Class/Interface conversion operators
            /// <summary>
            /// Converter from <see cref="Java.Util.Spliterators.AbstractSpliterator{T}"/> to <see cref="Java.Util.Spliterator{T}"/>
            /// </summary>
            public static implicit operator Java.Util.Spliterator<T>(Java.Util.Spliterators.AbstractSpliterator<T> t) => t.Cast<Java.Util.Spliterator<T>>();
            /// <summary>
            /// Converter from <see cref="Java.Util.Spliterators.AbstractSpliterator{T}"/> to <see cref="Java.Util.Spliterators.AbstractSpliterator"/>
            /// </summary>
            public static implicit operator Java.Util.Spliterators.AbstractSpliterator(Java.Util.Spliterators.AbstractSpliterator<T> t) => t.Cast<Java.Util.Spliterators.AbstractSpliterator>();
            
            #endregion

            #region Fields

            #endregion

            #region Static methods

            #endregion

            #region Instance methods
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractSpliterator.html#characteristics()"/>
            /// </summary>
            
            /// <returns><see cref="int"/></returns>
            public int Characteristics()
            {
                return IExecute<int>("characteristics");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractSpliterator.html#trySplit()"/>
            /// </summary>
            
            /// <returns><see cref="Java.Util.Spliterator"/></returns>
            public Java.Util.Spliterator<T> TrySplit()
            {
                return IExecute<Java.Util.Spliterator<T>>("trySplit");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Spliterators.AbstractSpliterator.html#estimateSize()"/>
            /// </summary>
            
            /// <returns><see cref="long"/></returns>
            public long EstimateSize()
            {
                return IExecute<long>("estimateSize");
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