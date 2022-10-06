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
    public class List : JVMBridgeBase<List>
    {
        public override string ClassName => "java.util.List";

        public void Clear() => IExecute("clear");

        public bool Contains​(object o) => IExecute<bool>("contains​", o);

        public int IndexOf​(object o) => IExecute<int>("indexOf​", o);

        public int LastIndexOf​(object o) => IExecute<int>("lastIndexOf​​", o);

        public bool Remove​(object o) => IExecute<bool>("remove​", o);
    }

    public class List<E> : List
    {
        public void Add​(int index, E element) => IExecute("add", index, element);

        public bool Add​(E e) => IExecute<bool>("add", e);

        public bool AddAll​<ExtendsE>(int index, Collection<ExtendsE> c) where ExtendsE : E => IExecute<bool>("addAll​", index, c);

        public bool AddAll​<ExtendsE>(Collection<ExtendsE> c) where ExtendsE : E => IExecute<bool>("addAll​", c);

        public bool ContainsAll<T>(Collection<T> c) => IExecute<bool>("containsAll", c);

        public static List<E> CopyOf​<ExtendsE>(Collection<ExtendsE> coll) => SExecute<List<E>>("copyOf​", coll);

        public E Get​(int index) => IExecute<E>("get", index);

        public bool IsEmpty => IExecute<bool>("isEmpty");

        public Iterator<E> Iterator => IExecute<Iterator<E>>("iterator");

        public ListIterator<E> ListIterator() => IExecute<ListIterator<E>>("listIterator");

        public ListIterator<E> ListIterator(int index) => IExecute<ListIterator<E>>("listIterator", index);

        public static List<E> Of() => SExecute<List<E>>("of");

        public static List<E> Of(E e1) => SExecute<List<E>>("of", e1);

        public static List<E> Of(params E[] elements) => SExecute<List<E>>("of", elements);

        public static List<E> Of(E e1, E e2) => SExecute<List<E>>("of", e1, e2);

        public static List<E> Of(E e1, E e2, E e3) => SExecute<List<E>>("of", e1, e2, e3);

        public static List<E> Of(E e1, E e2, E e3, E e4) => SExecute<List<E>>("of", e1, e2, e3, e4);

        public static List<E> Of(E e1, E e2, E e3, E e4, E e5) => SExecute<List<E>>("of", e1, e2, e3, e4, e5);

        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6);

        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6, e7);

        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8);

        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8, e9);

        public static List<E> Of(E e1, E e2, E e3, E e4, E e5, E e6, E e7, E e8, E e9, E e10) => SExecute<List<E>>("of", e1, e2, e3, e4, e5, e6, e7, e8, e9, e10);

        public E Remove​(int index) => IExecute<E>("remove​", index);

        public bool RemoveAll​<T>(Collection<T> c) => IExecute<bool>("removeAll​", c);

        public void ReplaceAll​(UnaryOperator<E> op) => IExecute("replaceAll​", op);

        public bool RetainAll​<T>(Collection<T> c) => IExecute<bool>("retainAll​​", c);

        public E Set​(int index, E element) => IExecute<E>("set", index, element);

        public int Size => IExecute<int>("size");

        public void Sort<SuperE>(Comparator<SuperE> c) where SuperE : E => IExecute("sort", c);

        public Spliterator<E> Spliterator() => IExecute<Spliterator<E>>("spliterator");

        public List<E> SubList​(int fromIndex, int toIndex) => IExecute<List<E>>("subList​", fromIndex, toIndex);
    }
}
