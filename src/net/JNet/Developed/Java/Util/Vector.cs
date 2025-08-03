/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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

namespace Java.Util
{
    public partial class Vector<E>
    {
        /// <summary>
        /// Returns a clone of this vector.
        /// </summary>
        /// <returns></returns>
        public Vector<E> Clone() => IExecute<Vector<E>>("clone");

        /// <summary>
        /// Performs the given action for each element of the Iterable until all elements have been processed or the action throws an exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        public void ForEach<T>(Consumer<T> action) where T : E => IExecute("forEach", action);

        /// <summary>
        /// Removes all of the elements of this collection that satisfy the given predicate.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="filter"></param>
        /// <returns></returns>
        public bool RemoveIf<T>(Predicate<T> filter) where T : E => IExecute<bool>("removeIf", filter);
        /// <summary>
        /// Replaces each element of this list with the result of applying the operator to that element.
        /// </summary>
        /// <param name="op"></param>
        public void ReplaceAll(UnaryOperator<E> op) => IExecute("replaceAll", op);
        /// <summary>
        /// Sorts this list according to the order induced by the specified Comparator.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="c"></param>
        public void Sort<T>(Comparator<T> c) where T : E => IExecute("sort", c);
        /// <summary>
        /// Creates a late-binding and fail-fast Spliterator over the elements in this list.
        /// </summary>
        /// <returns></returns>
        public Spliterator<E> Spliterator() => IExecute<Spliterator<E>>("spliterator");
    }
}