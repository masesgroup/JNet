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
#if !JNETREFLECTOR
using Java.Util.Function;
#endif
using MASES.JCOBridge.C2JBridge;

namespace Java.Util
{
#if !JNETREFLECTOR
    public partial class Collection<E>
    {

    }
#else
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/util/Collection.html"/>
    /// </summary>
    /// <typeparam name="E"><see href="https://docs.oracle.com/javase/8/docs/api/java/util/Collection.html"/></typeparam>
    public class Collection<E> : Iterable<E>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.Collection";

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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#remove(java.lang.Object)"/>
        /// </summary>
        public bool Remove​(object o) => IExecute<bool>("remove​​", o);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#removeAll(java.util.Collection)"/>
        /// </summary>
        public bool RemoveAll​<T>(Collection<T> c) => IExecute<bool>("removeAll​", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#retainAll(java.util.Collection)"/>
        /// </summary>
        public bool RetainAll​<T>(Collection<T> c) => IExecute<bool>("retainAll​​", c);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Collection.html#size()"/>
        /// </summary>
        public int Size => IExecute<int>("size");
    }
#endif
}
