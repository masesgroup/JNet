/*
*  Copyright 2025 MASES s.r.l.
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

using Java.Util.Function;
using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html"/>
    /// </summary>
    /// <typeparam name="T">The comparator type</typeparam>
    public partial interface IComparator<T> : IJVMBridgeBase
    {
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html#compare(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        int Compare(T arg0, T arg1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html#equals(java.lang.Object)"/>
        /// </summary>
        public bool Equals(object obj);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html"/>. Extends <see cref="JVMBridgeListener"/>, implements <see cref="IComparator{T}"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class Comparator : JVMBridgeListener
    {
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.Comparator";
    }

    /// <inheritdoc cref="Comparator"/>
    public partial class Comparator<T> : Comparator, IComparator<T>
    {
        /// <summary>
        /// Ctor
        /// </summary>
        public Comparator()
        {
            AddEventHandler("compare", new System.EventHandler<CLRListenerEventArgs<CLREventData<T>>>(CompareEventHandler)); OnCompare = Compare;
            AddEventHandler("equals", new System.EventHandler<CLRListenerEventArgs<CLREventData>>(EqualsEventHandler)); OnEquals = Equals;
        }

        /// <summary>
        /// Accepts a function that extracts a Comparable sort key from a type T, and returns a <see cref="Comparator{T}"/> that compares by that sort key.
        /// </summary>
        /// <typeparam name="SuperT"></typeparam>
        /// <typeparam name="SuperU"></typeparam>
        /// <param name="keyExtractor"></param>
        /// <returns></returns>
        public static Comparator<SuperT> Comparing<SuperT, SuperU>(Function<SuperT, SuperU> keyExtractor) => SExecute<Comparator<SuperT>>("comparing", keyExtractor);
        /// <summary>
        /// Accepts a function that extracts a sort key from a type T, and returns a <see cref="Comparator{T}"/> that compares by that sort key using the specified Comparator.
        /// </summary>
        public static Comparator<SuperT> Comparing<SuperT, SuperU>(Function<SuperT, SuperU> keyExtractor, Comparator<SuperU> keyComparator) => SExecute<Comparator<SuperT>>("comparing", keyExtractor, keyComparator);
        /// <summary>
        /// Accepts a function that extracts a double sort key from a type T, and returns a <see cref="Comparator{T}"/> that compares by that sort key.
        /// </summary>
        /// <typeparam name="SuperT"></typeparam>
        /// <param name="keyExtractor"></param>
        /// <returns></returns>
        public static Comparator<SuperT> ComparingDouble<SuperT>(ToDoubleFunction<SuperT> keyExtractor) => SExecute<Comparator<SuperT>>("comparingDouble", keyExtractor);
        /// <summary>
        /// Accepts a function that extracts an int sort key from a type T, and returns a <see cref="Comparator{T}"/> that compares by that sort key.
        /// </summary>
        public static Comparator<SuperT> ComparingInt<SuperT>(ToIntFunction<SuperT> keyExtractor) => SExecute<Comparator<SuperT>>("comparingInt", keyExtractor);
        /// <summary>
        /// Accepts a function that extracts a long sort key from a type T, and returns a <see cref="Comparator{T}"/> that compares by that sort key.
        /// </summary>
        /// <typeparam name="SuperT"></typeparam>
        /// <param name="keyExtractor"></param>
        /// <returns></returns>
        public static Comparator<SuperT> ComparingLong<SuperT>(ToLongFunction<SuperT> keyExtractor) => SExecute<Comparator<SuperT>>("comparingLong", keyExtractor);
        /// <summary>
        /// Returns a null-friendly comparator that considers null to be less than non-null.
        /// </summary>
        public static Comparator<SuperT> NullsFirst<SuperT>(Comparator<SuperT> comparator) => SExecute<Comparator<SuperT>>("nullsFirst", comparator);
        /// <summary>
        /// Returns a null-friendly comparator that considers null to be greater than non-null.
        /// </summary>
        public static Comparator<SuperT> NullsLast<SuperT>(Comparator<SuperT> comparator) => SExecute<Comparator<SuperT>>("nullsLast", comparator);

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html#compare(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        public System.Func<T, T, int> OnCompare { get; set; }

        void CompareEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            if (OnCompare != null)
            {
                var executionResult = OnCompare.Invoke(data.EventData.TypedEventData, data.EventData.GetAt<T>(0));
                data.SetReturnValue(executionResult);
            }
        }

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html#compare(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="T"/></param>
        /// <returns><see cref="int"/></returns>
        public virtual int Compare(T arg0, T arg1)
        {
            return default;
        }

        /// <summary>
        /// Handler for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html#equals(java.lang.Object)"/>
        /// </summary>
        public System.Func<object, bool> OnEquals { get; set; }

        void EqualsEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            if (OnEquals != null)
            {
                var executionResult = OnEquals.Invoke(data.EventData.EventData);
                data.SetReturnValue(executionResult);
            }
        }
    }
}