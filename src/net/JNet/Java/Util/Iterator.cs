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

using MASES.JCOBridge.C2JBridge;
using System.Collections;
using System.Collections.Generic;

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/util/Iterator.html"/>
    /// </summary>
    /// <typeparam name="E"><see href="https://docs.oracle.com/javase/8/docs/api/java/util/Iterator.html"/></typeparam>
    public class Iterator<E> : JVMBridgeBase<Iterator<E>>, IEnumerable<E>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.Iterator";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// Returns <see langword="true"/> if the iteration has more elements.
        /// </summary>
        public bool HasNext => IExecute<bool>("hasNext");
        /// <summary>
        /// Returns the next element in the iteration.
        /// </summary>
        public E Next => IExecute<E>("next");
        /// <inheritdoc cref="IEnumerable{T}.GetEnumerator"/>
        public IEnumerator<E> GetEnumerator()
        {
            return new JVMBridgeBaseEnumerator<E>(Instance);
        }
        /// <inheritdoc cref="IEnumerable.GetEnumerator"/>
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}