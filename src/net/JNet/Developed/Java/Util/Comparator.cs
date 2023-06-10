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

using Java.Util.Function;
using MASES.JCOBridge.C2JBridge;
using System;

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/util/Comparator.html"/>
    /// </summary>
    public partial class Comparator
    {
        /// <summary>
        /// Accepts a function that extracts a Comparable sort key from a type T, and returns a <see cref="Comparator"/> that compares by that sort key.
        /// </summary>
        /// <typeparam name="SuperT"></typeparam>
        /// <typeparam name="SuperU"></typeparam>
        /// <param name="keyExtractor"></param>
        /// <returns></returns>
        public static Comparator Comparing<SuperT, SuperU>(Function<SuperT, SuperU> keyExtractor) => SExecute<Comparator>("comparing", keyExtractor);
        /// <summary>
        /// Accepts a function that extracts a sort key from a type T, and returns a <see cref="Comparator"/> that compares by that sort key using the specified Comparator.
        /// </summary>
        public static Comparator Comparing<SuperT, SuperU>(Function<SuperT, SuperU> keyExtractor, Comparator<SuperU> keyComparator) => SExecute<Comparator>("comparing", keyExtractor, keyComparator);
        /// <summary>
        /// Accepts a function that extracts a double sort key from a type T, and returns a <see cref="Comparator"/> that compares by that sort key.
        /// </summary>
        /// <typeparam name="SuperT"></typeparam>
        /// <param name="keyExtractor"></param>
        /// <returns></returns>
        public static Comparator ComparingDouble<SuperT>(ToDoubleFunction<SuperT> keyExtractor) => SExecute<Comparator>("comparingDouble", keyExtractor);
        /// <summary>
        /// Accepts a function that extracts an int sort key from a type T, and returns a <see cref="Comparator"/> that compares by that sort key.
        /// </summary>
        public static Comparator ComparingInt<SuperT>(ToIntFunction<SuperT> keyExtractor) => SExecute<Comparator>("comparingInt", keyExtractor);
        /// <summary>
        /// Accepts a function that extracts a long sort key from a type T, and returns a <see cref="Comparator"/> that compares by that sort key.
        /// </summary>
        /// <typeparam name="SuperT"></typeparam>
        /// <param name="keyExtractor"></param>
        /// <returns></returns>
        public static Comparator ComparingLong<SuperT>(ToLongFunction<SuperT> keyExtractor) => SExecute<Comparator>("comparingLong", keyExtractor);
        /// <summary>
        /// Returns a null-friendly comparator that considers null to be less than non-null.
        /// </summary>
        public static Comparator NullsFirst<SuperT>(Comparator<SuperT> comparator) => SExecute<Comparator>("nullsFirst", comparator);
        /// <summary>
        /// Returns a null-friendly comparator that considers null to be greater than non-null.
        /// </summary>
        public static Comparator NullsLast<SuperT>(Comparator<SuperT> comparator) => SExecute<Comparator>("nullsLast", comparator);
    }
    /// <summary>
    /// Interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html"/>
    /// </summary>
    /// <typeparam name="T">The comparator type</typeparam>
    public partial interface IComparator<T> : IJVMBridgeBase
    {

    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Comparator.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>, implements <see cref="IComparator{T}"/>
    /// </summary>
    /// <remarks>Remember to Dispose the object otherwise there is a resource leak, the object contains a reference to the the corresponding JVM object</remarks>
    public partial class Comparator<T> : JVMBridgeListener, IComparator<T>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.JNetComparator";

        readonly Func<T, T, int> CompareFunction = null;
        /// <summary>
        /// The <see cref="Func{T1, T2, TResult}"/> to be executed on Compare
        /// </summary>
        public virtual Func<T, T, int> OnCompare { get { return CompareFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="Comparator{T}"/>
        /// </summary>
        /// <param name="compare">The <see cref="Func{T1, T2, TResult}"/> to be executed on Compare</param>
        /// <param name="attachEventHandler">Set to false to disable attach of <see cref="EventHandler"/> and set an own one</param>
        public Comparator(Func<T, T, int> compare = null, bool attachEventHandler = true)
        {
            if (compare != null) CompareFunction = compare;
            else CompareFunction = Compare;

            if (attachEventHandler)
            {
                AddEventHandler("compare", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(EventHandlerCompare));
            }
        }

        void EventHandlerCompare(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var retVal = OnCompare(data.EventData.TypedEventData, data.EventData.GetAt<T>(0));
            data.SetReturnValue(retVal);
        }
    }
}