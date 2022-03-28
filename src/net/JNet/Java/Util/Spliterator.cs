/*
*  Copyright 2022 MASES s.r.l.
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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/util/Spliterator.html"/>
    /// </summary>
    /// <typeparam name="E"><see href="https://docs.oracle.com/javase/8/docs/api/java/util/Spliterator.html"/></typeparam>
    public class Spliterator<T> : JVMBridgeBase<Spliterator<T>>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.Spliterator";
        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;
        /// <summary>
        /// Returns a set of characteristics of this Spliterator and its elements.
        /// </summary>
        public int Characteristics => IExecute<int>("characteristics");
        /// <summary>
        /// Returns an estimate of the number of elements that would be encountered by a forEachRemaining(java.util.function.Consumer<? super T>) traversal, or returns Long.MAX_VALUE if infinite, unknown, or too expensive to compute.
        /// </summary>
        public long EstimateSize => IExecute<long>("estimateSize");
        /// <summary>
        /// Performs the given action for each remaining element, sequentially in the current thread, until all elements have been processed or the action throws an exception.
        /// </summary>
        /// <typeparam name="TSuper"></typeparam>
        /// <param name="action"></param>
        public void ForEachRemaining<TSuper>(Consumer<TSuper> action) where TSuper : T => IExecute("forEachRemaining", action);
        /// <summary>
        /// If this Spliterator's source is SORTED by a Comparator, returns that Comparator.
        /// </summary>
        public Comparator Comparator => IExecute<Comparator>("getComparator");
        /// <summary>
        /// Convenience method that returns estimateSize() if this Spliterator is SIZED, else -1.
        /// </summary>
        public long ExactSizeIfKnown => IExecute<long>("getExactSizeIfKnown");
        /// <summary>
        /// Returns true if this Spliterator's characteristics() contain all of the given characteristics.
        /// </summary>
        /// <param name="characteristics"></param>
        /// <returns></returns>
        public bool HasCharacteristics(int characteristics) => IExecute<bool>("hasCharacteristics", characteristics);
        /// <summary>
        /// If a remaining element exists, performs the given action on it, returning true; else returns false.
        /// </summary>
        /// <typeparam name="SuperT"></typeparam>
        /// <param name="action"></param>
        /// <returns></returns>
        public bool TryAdvance<SuperT>(Consumer<SuperT> action) where SuperT : T => IExecute<bool>("tryAdvance", action);
        /// <summary>
        /// If this spliterator can be partitioned, returns a Spliterator covering elements, that will, upon return from this method, not be covered by this Spliterator.
        /// </summary>
        /// <returns></returns>
        public Spliterator<T> TrySplit() => IExecute<Spliterator<T>>("trySplit");
    }
}