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
*  This file is generated by MASES.JNetReflector (ver. 2.4.0.0)
*  using java.* as reference
*/

using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    #region PrimitiveIterator
    public partial class PrimitiveIterator
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.html#forEachRemaining(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void ForEachRemaining(object arg0)
        {
            IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes
        #region OfDouble
        public partial class OfDouble
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfDouble.html#nextDouble()"/>
            /// </summary>

            /// <returns><see cref="double"/></returns>
            public double NextDouble()
            {
                return IExecuteWithSignature<double>("nextDouble", "()D");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfDouble.html#next()"/>
            /// </summary>

            /// <returns><see cref="object"/></returns>
            public object Next()
            {
                return IExecuteWithSignature("next", "()Ljava/lang/Object;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfDouble.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfDouble.html#forEachRemaining(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Double"><see cref="Java.Lang.Double"/></typeparam>
            public void ForEachRemaining<Arg0objectSuperJava_Lang_Double>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Double> arg0) where Arg0objectSuperJava_Lang_Double: Java.Lang.Double
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfDouble.html#forEachRemaining(java.util.function.DoubleConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.DoubleConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.DoubleConsumer arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/DoubleConsumer;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfInt
        public partial class OfInt
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfInt.html#nextInt()"/>
            /// </summary>

            /// <returns><see cref="int"/></returns>
            public int NextInt()
            {
                return IExecuteWithSignature<int>("nextInt", "()I");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfInt.html#next()"/>
            /// </summary>

            /// <returns><see cref="object"/></returns>
            public object Next()
            {
                return IExecuteWithSignature("next", "()Ljava/lang/Object;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfInt.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfInt.html#forEachRemaining(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Integer"><see cref="Java.Lang.Integer"/></typeparam>
            public void ForEachRemaining<Arg0objectSuperJava_Lang_Integer>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Integer> arg0) where Arg0objectSuperJava_Lang_Integer: Java.Lang.Integer
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfInt.html#forEachRemaining(java.util.function.IntConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.IntConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.IntConsumer arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/IntConsumer;)V", arg0);
            }

            #endregion

            #region Nested classes

            #endregion

            // TODO: complete the class
        }
        #endregion

        #region OfLong
        public partial class OfLong
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
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfLong.html#nextLong()"/>
            /// </summary>

            /// <returns><see cref="long"/></returns>
            public long NextLong()
            {
                return IExecuteWithSignature<long>("nextLong", "()J");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfLong.html#next()"/>
            /// </summary>

            /// <returns><see cref="object"/></returns>
            public object Next()
            {
                return IExecuteWithSignature("next", "()Ljava/lang/Object;");
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfLong.html#forEachRemaining(java.lang.Object)"/>
            /// </summary>
            /// <param name="arg0"><see cref="object"/></param>
            public void ForEachRemaining(object arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfLong.html#forEachRemaining(java.util.function.Consumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
            /// <typeparam name="Arg0objectSuperJava_Lang_Long"><see cref="Java.Lang.Long"/></typeparam>
            public void ForEachRemaining<Arg0objectSuperJava_Lang_Long>(Java.Util.Function.Consumer<Arg0objectSuperJava_Lang_Long> arg0) where Arg0objectSuperJava_Lang_Long: Java.Lang.Long
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/Consumer;)V", arg0);
            }
            /// <summary>
            /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.OfLong.html#forEachRemaining(java.util.function.LongConsumer)"/>
            /// </summary>
            /// <param name="arg0"><see cref="Java.Util.Function.LongConsumer"/></param>
            public void ForEachRemaining(Java.Util.Function.LongConsumer arg0)
            {
                IExecuteWithSignature("forEachRemaining", "(Ljava/util/function/LongConsumer;)V", arg0);
            }

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

    #region IPrimitiveIterator<T, T_CONS>
    /// <summary>
    /// .NET interface for TO BE DEFINED FROM USER
    /// </summary>
    public partial interface IPrimitiveIterator<T, T_CONS>
    {
        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.html#forEachRemaining(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T_CONS"/></param>
        void ForEachRemaining(T_CONS arg0);

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion

    #region PrimitiveIterator<T, T_CONS>
    public partial class PrimitiveIterator<T, T_CONS> : Java.Util.IPrimitiveIterator<T, T_CONS>
    {
        #region Constructors

        #endregion

        #region Class/Interface conversion operators
        /// <summary>
        /// Converter from <see cref="Java.Util.PrimitiveIterator{T, T_CONS}"/> to <see cref="Java.Util.PrimitiveIterator"/>
        /// </summary>
        public static implicit operator Java.Util.PrimitiveIterator(Java.Util.PrimitiveIterator<T, T_CONS> t) => t.Cast<Java.Util.PrimitiveIterator>();

        #endregion

        #region Fields

        #endregion

        #region Static methods

        #endregion

        #region Instance methods
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/PrimitiveIterator.html#forEachRemaining(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T_CONS"/></param>
        public void ForEachRemaining(T_CONS arg0)
        {
            IExecuteWithSignature("forEachRemaining", "(Ljava/lang/Object;)V", arg0);
        }

        #endregion

        #region Nested classes

        #endregion

        // TODO: complete the class
    }
    #endregion
}