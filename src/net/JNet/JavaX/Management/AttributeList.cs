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

using Java.Util;

namespace JavaX.Management
{
    public class AttributeList : Java.Util.ArrayList<object>
    {
        public override string ClassName => "javax.management.AttributeList";

        public AttributeList() { }

        protected AttributeList(params object[] args) : base(args) { }
        /// <summary>
        /// Constructs an empty <see cref="AttributeList"/> with the initial capacity specified.
        /// </summary>
        public AttributeList(int initialCapacity) :base(initialCapacity) { }
        /// <summary>
        /// Constructs an <see cref="AttributeList"/> containing the elements of the List specified, in the order in which they are returned by the List's iterator.
        /// </summary>
        public AttributeList(List<Attribute> list) : base(list) { }
        /// <summary>
        /// Constructs an <see cref="AttributeList"/> containing the elements of the <see cref="AttributeList"/> specified, in the order in which they are returned by the <see cref="AttributeList"/>'s iterator.
        /// </summary>
        public AttributeList(AttributeList list) :base(list) { }
        /// <summary>
        /// Return a view of this list as a <see cref="List{Attribute}"/>.
        /// </summary>
        public List<Attribute> AsList => IExecute<List<Attribute>>("asList");
    }
}
