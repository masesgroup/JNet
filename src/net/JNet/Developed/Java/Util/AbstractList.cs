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

using Java.Lang;

namespace Java.Util
{
    public partial class AbstractList<E>
    {
        /// <summary>
        /// Returns the index of the first occurrence of the specified element in this list, or -1 if this list does not contain the element.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int IndexOf(Object o) => IExecute<int>("indexOf", o);
        /// <summary>
        /// Returns the index of the last occurrence of the specified element in this list, or -1 if this list does not contain the element.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int LastIndexOf(Object o) => IExecute<int>("lastIndexOf", o);
        /// <summary>
        /// Returns a view of the portion of this list between the specified fromIndex, inclusive, and toIndex, exclusive.
        /// </summary>
        /// <param name="fromIndex"></param>
        /// <param name="toIndex"></param>
        /// <returns></returns>
        public List<E> SubList(int fromIndex, int toIndex) => IExecute<List<E>>("subList", fromIndex, toIndex);
    }
}