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
using Java.Util.Function;
using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    public partial class List
    {
        // can be extended with methods not reflected or not available in Java;
    }
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html"/>
    /// </summary>
    public class List<E> : List
    {
        /// <summary>
        /// Converter from <see cref="List{E}"/> to <see cref="Collection{E}"/>
        /// </summary>
        public static implicit operator Collection<E>(List<E> instance) => instance.Cast<Collection<E>>();
        /// <summary>
        /// Converter from <see cref="List{E}"/> to <see cref="Iterable{E}"/>
        /// </summary>
        public static implicit operator Iterable<E>(List<E> instance) => instance.Cast<Iterable<E>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#add(int,E)"/>
        /// </summary>
        public void Add​(int index, E element) => IExecute("add", index, element);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#add(E)"/>
        /// </summary>
        public bool Add​(E e) => IExecute<bool>("add", e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#addAll(int,java.util.Collection)"/>
        /// </summary>
        public bool AddAll​<ExtendsE>(int index, Collection<ExtendsE> c) where ExtendsE : E => IExecute<bool>("addAll​", index, c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#addAll(java.util.Collection)"/>
        /// </summary>
        public bool AddAll​<ExtendsE>(Collection<ExtendsE> c) where ExtendsE : E => IExecute<bool>("addAll​", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#containsAll(java.util.Collection)"/>
        /// </summary>
        public bool ContainsAll<T>(Collection<T> c) => IExecute<bool>("containsAll", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#copyOf(java.util.Collection)"/>
        /// </summary>
        public static List<E> CopyOf​<ExtendsE>(Collection<ExtendsE> coll) => SExecute<List<E>>("copyOf​", coll);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#get(int)"/>
        /// </summary>
        public new E Get​(int index) => IExecute<E>("get", index);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#isEmpty()"/>
        /// </summary>
        public new bool IsEmpty => IExecute<bool>("isEmpty");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#iterator()"/>
        /// </summary>
        public Iterator<E> Iterator2 => Iterator().Cast<Iterator<E>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#get(int)"/>
        /// </summary>
        public ListIterator<E> ListIterator2() => ListIterator().Cast<ListIterator<E>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#listIterator()"/>
        /// </summary>
        public ListIterator<E> ListIterator2(int index) => ListIterator(index).Cast<ListIterator<E>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of()"/>
        /// </summary>
        public static List<E> Of2() => Of().Cast<List<E>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E)"/>
        /// </summary>
        public static List<E> Of(E e1) => SExecute<List<E>>("of", e1);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E...)"/>
        /// </summary>
        public static List<E> Of(params E[] elements) => elements.Length == 0 ? SExecute<List<E>>("of") : SExecute<List<E>>("of", elements);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2) => SExecute<List<E>>("of", e1, e2);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2, E e3) => SExecute<List<E>>("of", e1, e2, e3);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E,E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2, E e3, E e4) => SExecute<List<E>>("of", e1, e2, e3, e4);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E,E,E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2, E e3, E e4, E e5) => SExecute<List<E>>("of", e1, e2, e3, e4, e5);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E,E,E,E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E,E,E,E,E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6, e7);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E,E,E,E,E,E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E,E,E,E,E,E,E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8, e9);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#of(E,E,E,E,E,E,E,E,E,E)"/>
        /// </summary>
        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9, E e10) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8, e9, e10);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#remove(int)"/>
        /// </summary>
        public new E Remove​(int index) => IExecute<E>("remove​", index);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#removeAll(java.util.Collection)"/>
        /// </summary>
        public bool RemoveAll​<T>(Collection<T> c) => IExecute<bool>("removeAll​", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#replaceAll(java.util.function.UnaryOperator)"/>
        /// </summary>
        public void ReplaceAll​(UnaryOperator<E> op) => IExecute("replaceAll​", op);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#retainAll(java.util.Collection)"/>
        /// </summary>
        public bool RetainAll​<T>(Collection<T> c) => IExecute<bool>("retainAll​​", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#set(int,E)"/>
        /// </summary>
        public E Set​(int index, E element) => IExecute<E>("set", index, element);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#size()"/>
        /// </summary>
        public new int Size => IExecute<int>("size");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#sort(java.util.Comparator)"/>
        /// </summary>
        public void Sort<SuperE>(Comparator<SuperE> c) where SuperE : E => IExecute("sort", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#spliterator()"/>
        /// </summary>
        public Spliterator<E> Spliterator2() => Spliterator().Cast<Spliterator<E>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/List.html#subList(int,int)"/>
        /// </summary>
        public List<E> SubList​2(int fromIndex, int toIndex) => SubList(fromIndex, toIndex).Cast<List<E>>();
    }
}
