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
    public class Collection<E> : JVMBridgeBaseEnumerable<Collection<E>>
    {
        public override string ClassName => "java.util.Collection";

        public static implicit operator Lang.Iterable<E>(Collection<E> instance) => instance.Cast<Lang.Iterable<E>>();

        public bool Add(E e) => IExecute<bool>("add", e);

        public bool AddAll<ExtendsE>(Collection<ExtendsE> c) where ExtendsE : E => IExecute<bool>("addAll", c);

        public void Clear() => IExecute("clear");

        public bool Contains​(object o) => IExecute<bool>("contains​", o);

        public bool ContainsAll<T>(Collection<T> c) => IExecute<bool>("containsAll", c);

        public bool IsEmpty => IExecute<bool>("isEmpty");

        public Iterator<E> Iterator() => IExecute<Iterator<E>>("iterator");

        public bool Remove​(object o) => IExecute<bool>("remove​​", o);

        public bool RemoveAll​<T>(Collection<T> c) => IExecute<bool>("removeAll​", c);

        public bool RemoveIf<SuperE>(Predicate<SuperE> filter) => IExecute<bool>("removeIf", filter);

        public bool RetainAll​<T>(Collection<T> c) => IExecute<bool>("retainAll​​", c);

        public int Size => IExecute<int>("size");

        public Spliterator<E> Spliterator() => IExecute<Spliterator<E>>("spliterator");
    }
}
