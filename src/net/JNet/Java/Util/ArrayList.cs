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

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html"/>
    /// </summary>
    /// <typeparam name="E"><see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html"/></typeparam>
    public class ArrayList<E> : JVMBridgeBase<ArrayList<E>>
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public override string ClassName => "java.util.ArrayList";
        /// <summary>
        /// Converter from <see cref="ArrayList{E}"/> to <see cref="Iterable{E}"/>
        /// </summary>
        public static implicit operator Iterable<E>(ArrayList<E> array) { return Wraps<Iterable<E>>(array.Instance); }
        /// <summary>
        /// Converter from <see cref="ArrayList{E}"/> to <see cref="Collection{E}"/>
        /// </summary>
        public static implicit operator Collection<E>(ArrayList<E> array) { return Wraps<Collection<E>>(array.Instance); }
        /// <summary>
        /// Converter from <see cref="ArrayList{E}"/> to <see cref="List{E}"/>
        /// </summary>
        public static implicit operator List<E>(ArrayList<E> array) { return Wraps<List<E>>(array.Instance); }
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public ArrayList() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        protected ArrayList(params object[] args) : base(args) { }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#isEmpty()"/>
        /// </summary>
        public bool IsEmpty => IExecute<bool>("isEmpty");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#add(E)"/>
        /// </summary>
        public bool Add(E element)
        {
            return IExecute<bool>("add", element);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#add(int,E)"/>
        /// </summary>
        public bool Add(int index, E element)
        {
            return IExecute<bool>("add", index, element);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#addAll(java.util.Collection)"/>
        /// </summary>
        public bool AddAll<TSuperE>(Collection<TSuperE> elements)
            where TSuperE : E
        {
            return IExecute<bool>("addAll", elements);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#addAll(int,java.util.Collection)"/>
        /// </summary>
        public bool AddAll<TSuperE>(int index, Collection<TSuperE> elements)
            where TSuperE : E
        {
            return IExecute<bool>("addAll", index, elements);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#clear()"/>
        /// </summary>
        public void Clear()
        {
            IExecute("clear");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#get(int)"/>
        /// </summary>
        public E Get(int index)
        {
            return IExecute<E>("get", index);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#remove(int)"/>
        /// </summary>
        public E Remove(int index)
        {
            return IExecute<E>("remove", index);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/ArrayList.html#set(int,E)"/>
        /// </summary>
        public E Set(int index, E element)
        {
            return IExecute<E>("set", index, element);
        }
    }
}
