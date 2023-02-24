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

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/util/Vector.html"/>
    /// </summary>
    public class Vector<E> : AbstractList<E>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsAbstract.htm"/>
        /// </summary>
        public override bool IsAbstract => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.Vector";
        /// <summary>
        /// Constructs an empty vector so that its internal data array has size 10 and its standard capacity increment is zero.
        /// </summary>
        public Vector() { }
        /// <summary>
        /// Constructs a vector containing the elements of the specified collection, in the order they are returned by the collection's iterator.
        /// </summary>
        /// <param name="c"></param>
        public Vector(Collection<E> c)
            : base(c) { }
        /// <summary>
        /// Constructs an empty vector with the specified initial capacity and with its capacity increment equal to zero.
        /// </summary>
        /// <param name="initialCapacity"></param>
        public Vector(int initialCapacity)
            : base(initialCapacity) { }
        /// <summary>
        /// Constructs an empty vector with the specified initial capacity and capacity increment.
        /// </summary>
        /// <param name="initialCapacity"></param>
        /// <param name="capacityIncrement"></param>
        public Vector(int initialCapacity, int capacityIncrement)
            : base(initialCapacity, capacityIncrement) { }
        /// <summary>
        /// Adds the specified component to the end of this vector, increasing its size by one.
        /// </summary>
        /// <param name="obj"></param>
        public void AddElement(E obj) => IExecute("addElement", obj);
        /// <summary>
        /// Returns the current capacity of this vector.
        /// </summary>
        public int Capacity => IExecute<int>("capacity");
        /// <summary>
        /// Returns a clone of this vector.
        /// </summary>
        /// <returns></returns>
        public Vector<E> Clone() => IExecute<Vector<E>>("clone");
        /// <summary>
        /// Returns true if this vector contains the specified element.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Contains(object o) => IExecute<bool>("contains", o);
        /// <summary>
        /// Returns the component at the specified index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public E ElementAt(int index) => IExecute<E>("elementAt", index);
        /// <summary>
        /// Returns an enumeration of the components of this vector.
        /// </summary>
        public Enumeration<E> Elements => IExecute<Enumeration<E>>("elements");
        /// <summary>
        /// Increases the capacity of this vector, if necessary, to ensure that it can hold at least the number of components specified by the minimum capacity argument.
        /// </summary>
        /// <param name="minCapacity"></param>
        public void EnsureCapacity(int minCapacity) => IExecute("ensureCapacity", minCapacity);
        /// <summary>
        /// Returns the first component (the item at index 0) of this vector.
        /// </summary>
        public E FirstElement => IExecute<E>("firstElement");
        /// <summary>
        /// Performs the given action for each element of the Iterable until all elements have been processed or the action throws an exception.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="action"></param>
        public void ForEach<T>(Consumer<T> action) where T : E => IExecute("forEach", action);
        /// <summary>
        /// Returns the index of the first occurrence of the specified element in this vector, or -1 if this vector does not contain the element.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int IndexOf(object o) => IExecute<int>("indexOf", o);
        /// <summary>
        /// Returns the index of the first occurrence of the specified element in this vector, searching forwards from index, or returns -1 if the element is not found.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int IndexOf(object o, int index) => IExecute<int>("indexOf", o, index);
        /// <summary>
        /// Inserts the specified object as a component in this vector at the specified index.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="index"></param>
        public void InsertElementAt(E obj, int index) => IExecute<int>("insertElementAt", obj, index);
        /// <summary>
        /// Returns the last component of the vector.
        /// </summary>
        public E LastElement => IExecute<E>("lastElement");
        /// <summary>
        /// Returns the index of the last occurrence of the specified element in this vector, or -1 if this vector does not contain the element.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int LastIndexOf(object o) => IExecute<int>("lastIndexOf", o);
        /// <summary>
        /// Returns the index of the last occurrence of the specified element in this vector, searching backwards from index, or returns -1 if the element is not found.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int LastIndexOf(object o, int index) => IExecute<int>("lastIndexOf", o, index);
        /// <summary>
        /// Removes all components from this vector and sets its size to zero.
        /// </summary>
        public void RemoveAllElements() => IExecute("removeAllElements");
        /// <summary>
        /// Removes the first (lowest-indexed) occurrence of the argument from this vector.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool RemoveElement(object obj) => IExecute<bool>("removeElement", obj);
        /// <summary>
        /// Deletes the component at the specified index.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveElementAt(int index) => IExecute("removeElementAt", index);
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
        /// Sets the component at the specified index of this vector to be the specified object.
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="index"></param>
        public void SetElementAt(E obj, int index) => IExecute("setElementAt", obj, index);
        /// <summary>
        /// Sets the size of this vector.
        /// </summary>
        /// <param name="newSize"></param>
        public void SetSize(int newSize) => IExecute("setSize", newSize);
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
        /// <summary>
        /// Trims the capacity of this vector to be the vector's current size.
        /// </summary>
        public void TrimToSize() => IExecute("trimToSize");
    }
}