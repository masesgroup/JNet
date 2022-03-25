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
    public class Stack<E> : Vector<E>
    {
        public override string ClassName => "java.util.Stack";
        /// <summary>
        /// Constructs an empty vector so that its internal data array has size 10 and its standard capacity increment is zero.
        /// </summary>
        public Stack() { }
        /// <summary>
        /// Tests if this stack is empty.
        /// </summary>
        public bool Empty => IExecute<bool>("empty");
        /// <summary>
        /// Looks at the object at the top of this stack without removing it from the stack.
        /// </summary>
        public E Peek => IExecute<E>("peek");
        /// <summary>
        ///  Removes the object at the top of this stack and returns that object as the value of this function.
        /// </summary>
        public E Pop => IExecute<E>("pop");
        /// <summary>
        /// Pushes an item onto the top of this stack.
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public E Push(E item) => IExecute<E>("push", item);
        /// <summary>
        /// Returns the 1-based position where an object is on this stack.
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        public int Search(object o) => IExecute<int>("search", o);
    }
}