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

using Java.Lang;

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractList.html"/>
    /// </summary>
    public class AbstractList<E> : AbstractCollection<E>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.AbstractList";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AbstractList()
        {
        }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        protected AbstractList(params object[] args)
            : base(args)
        {

        }
        /// <summary>
        /// Inserts the specified element at the specified position in this list(optional operation).
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        public void Add(int index, E element) => IExecute("add", index, element);
        /// <summary>
        /// Inserts all of the elements in the specified collection into this list at the specified position(optional operation).
        /// </summary>
        /// <param name="index"></param>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool AddAll<T>(int index, Collection<T> c) where T : E => IExecute<bool>("addAll", index, c);
        /// <summary>
        /// Returns the element at the specified position in this list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public E Get(int index) => IExecute<E>("get", index);
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
        /// Returns a list iterator over the elements in this list (in proper sequence).
        /// </summary>
        /// <returns></returns>
        public ListIterator<E> ListIterator() => IExecute<ListIterator<E>>("listIterator");
        /// <summary>
        /// Returns a list iterator over the elements in this list(in proper sequence), starting at the specified position in the list.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public ListIterator<E> ListIterator(int index) => IExecute<ListIterator<E>>("listIterator", index);
        /// <summary>
        /// Removes the element at the specified position in this list(optional operation).
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public E Remove(int index) => IExecute<E>("remove", index);
        /// <summary>
        /// Replaces the element at the specified position in this list with the specified element(optional operation).
        /// </summary>
        /// <param name="index"></param>
        /// <param name="element"></param>
        /// <returns></returns>
        public E Set(int index, E element) => IExecute<E>("set", index, element);
        /// <summary>
        /// Returns a view of the portion of this list between the specified fromIndex, inclusive, and toIndex, exclusive.
        /// </summary>
        /// <param name="fromIndex"></param>
        /// <param name="toIndex"></param>
        /// <returns></returns>
        public List<E> SubList(int fromIndex, int toIndex) => IExecute<List<E>>("subList", fromIndex, toIndex);
    }
}