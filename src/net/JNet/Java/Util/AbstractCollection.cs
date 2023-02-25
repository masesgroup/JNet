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
using MASES.JCOBridge.C2JBridge;
using MASES.JCOBridge.C2JBridge.JVMInterop;

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/AbstractCollection.html"/>
    /// </summary>
    public class AbstractCollection<E> : JVMBridgeBase<AbstractCollection<E>>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.AbstractCollection";
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public AbstractCollection()
        {
        }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        protected AbstractCollection(params object[] args)
            : base(args)
        {

        }
        /// <summary>
        /// Returns an iterator over the elements contained in this collection.
        /// </summary>
        /// <param name="coll"></param>
        public static implicit operator Iterator<E>(AbstractCollection<E> coll) { var obj = coll.IExecute<IJavaObject>("iterator"); return Wraps<Iterator<E>>(obj); }

        /// <summary>
        /// Ensures that this collection contains the specified element(optional operation).
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public bool Add(E e) => IExecute<bool>("add", e);
        /// <summary>
        /// Adds all of the elements in the specified collection to this collection(optional operation).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool AddAll<T>(Collection<T> c) where T : E => IExecute<bool>("addAll", c);
        /// <summary>
        /// Removes all of the elements from this collection(optional operation).
        /// </summary>
        public void Clear() => IExecute("clear");
        /// <summary>
        /// Returns true if this collection contains the specified element.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Contains(Object o) => IExecute<bool>("contains", o);
        /// <summary>
        /// Returns true if this collection contains all of the elements in the specified collection.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool ContainsAll<T>(Collection<T> c) => IExecute<bool>("containsAll", c);
        /// <summary>
        ///  Returns true if this collection contains no elements.
        /// </summary>
        public bool IsEmpty => IExecute<bool>("isEmpty");
        /// <summary>
        /// Removes a single instance of the specified element from this collection, if it is present (optional operation).
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public bool Remove(Object o) => IExecute<bool>("remove", o);
        /// <summary>
        /// Removes all of this collection's elements that are also contained in the specified collection (optional operation).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool RemoveAll<T>(Collection<T> c) => IExecute<bool>("removeAll", c);
        /// <summary>
        /// Retains only the elements in this collection that are contained in the specified collection (optional operation).
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="c"></param>
        /// <returns></returns>
        public bool RetainAll<T>(Collection<T> c) => IExecute<bool>("retainAll", c);
        /// <summary>
        /// Returns the number of elements in this collection.
        /// </summary>
        public int Size => IExecute<int>("size");
    }
}