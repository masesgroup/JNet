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

using MASES.JCOBridge.C2JBridge;
using System.Collections;
using System.Collections.Generic;

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/util/ListIterator.html"/>
    /// </summary>
    /// <typeparam name="E"><see href="https://docs.oracle.com/javase/8/docs/api/java/util/ListIterator.html"/></typeparam>
    public class ListIterator<E> : Iterator<E>
    {
//        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.ListIterator";
//        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;
        /// <summary>
        /// Inserts the specified element into the list(optional operation).
        /// </summary>
        /// <param name="e"></param>
        public void Add(E e) => IExecute("add", e);
        /// <summary>
        /// Returns true if this list iterator has more elements when traversing the list in the reverse direction.
        /// </summary>
        public bool HasPrevious => IExecute<bool>("hasPrevious");
        /// <summary>
        /// Returns the index of the element that would be returned by a subsequent call to next().
        /// </summary>
        public int NextIndex => IExecute<int>("nextIndex");
        /// <summary>
        /// Returns the previous element in the list and moves the cursor position backwards.
        /// </summary>
        public E Previous => IExecute<E>("previous");
        /// <summary>
        ///  Returns the index of the element that would be returned by a subsequent call to previous().
        /// </summary>
        public int PreviousIndex => IExecute<int>("previousIndex");
        /// <summary>
        /// Removes from the list the last element that was returned by next() or previous() (optional operation).
        /// </summary>
        public void Remove() => IExecute("remove");
        /// <summary>
        /// Replaces the last element returned by next() or previous() with the specified element (optional operation).
        /// </summary>
        /// <param name="e"></param>
        public void Set(E e) => IExecute("set", e);
    }
}