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

namespace Java.Util
{
    public class Vector<E> : AbstractList<E>
    {
        public override string ClassName => "java.util.Vector";
        /// <summary>
        /// Constructs an empty vector so that its internal data array has size 10 and its standard capacity increment is zero.
        /// </summary>
        public Vector() { }
        /// <summary>
        /// Constructs a vector containing the elements of the specified collection, in the order they are returned by the collection's iterator.
        /// </summary>
        /// <param name="c"></param>
        Vector(Collection<E> c)
            : base(c) { }
        /// <summary>
        /// Constructs an empty vector with the specified initial capacity and with its capacity increment equal to zero.
        /// </summary>
        /// <param name="initialCapacity"></param>
        Vector(int initialCapacity)
            : base(initialCapacity) { }
        /// <summary>
        /// Constructs an empty vector with the specified initial capacity and capacity increment.
        /// </summary>
        /// <param name="initialCapacity"></param>
        /// <param name="capacityIncrement"></param>
        Vector(int initialCapacity, int capacityIncrement)
            : base(initialCapacity, capacityIncrement) { }
    }
}