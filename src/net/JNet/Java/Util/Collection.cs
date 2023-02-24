﻿/*
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
#if !JNETREFLECTOR
using Java.Util.Function;
#endif
using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/util/Collection.html"/>
    /// </summary>
    /// <typeparam name="E"><see href="https://docs.oracle.com/javase/8/docs/api/java/util/Collection.html"/></typeparam>
    public class Collection<E> : JVMBridgeBaseEnumerable<Collection<E>, E>
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        public override bool IsInterface => true;
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "java.util.Collection";
#if !JNETREFLECTOR
        /// <summary>
        /// Converter from <see cref="Collection{E}"/> to <see cref="Lang.Iterable{E}"/>
        /// </summary>
        public static implicit operator Lang.Iterable<E>(Collection<E> instance) => instance.Cast<Lang.Iterable<E>>();
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#add(E)"/>
        /// </summary>
        public bool Add(E e) => IExecute<bool>("add", e);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#addAll(java.util.Collection)"/>
        /// </summary>
        public bool AddAll<ExtendsE>(Collection<ExtendsE> c) where ExtendsE : E => IExecute<bool>("addAll", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#clear()"/>
        /// </summary>
        public void Clear() => IExecute("clear");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#contains(java.lang.Object)"/>
        /// </summary>
        public bool Contains​(object o) => IExecute<bool>("contains​", o);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#containsAll(java.util.Collection)"/>
        /// </summary>
        public bool ContainsAll<T>(Collection<T> c) => IExecute<bool>("containsAll", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#isEmpty()"/>
        /// </summary>
        public bool IsEmpty => IExecute<bool>("isEmpty");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#iterator()"/>
        /// </summary>
        public Iterator<E> Iterator() => IExecute<Iterator<E>>("iterator");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#remove(java.lang.Object)"/>
        /// </summary>
        public bool Remove​(object o) => IExecute<bool>("remove​​", o);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#removeAll(java.util.Collection)"/>
        /// </summary>
        public bool RemoveAll​<T>(Collection<T> c) => IExecute<bool>("removeAll​", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#removeIf(java.util.function.Predicate)"/>
        /// </summary>
        public bool RemoveIf<SuperE>(Predicate<SuperE> filter) => IExecute<bool>("removeIf", filter);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#retainAll(java.util.Collection)"/>
        /// </summary>
        public bool RetainAll​<T>(Collection<T> c) => IExecute<bool>("retainAll​​", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#size()"/>
        /// </summary>
        public int Size => IExecute<int>("size");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#spliterator()"/>
        /// </summary>
        public Spliterator<E> Spliterator() => IExecute<Spliterator<E>>("spliterator");
#endif
    }
}
