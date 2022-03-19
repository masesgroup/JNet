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

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Comparable.html"/>
    /// </summary>
    /// <typeparam name="T"><see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Comparable.html"/></typeparam>
    public class Comparable<T> : JVMBridgeBase<Comparable<T>>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.lang.Comparable";
        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;
        /// <summary>
        /// Compares this object with the specified object for order. Returns a negative integer, zero, or a positive integer as this object is less than, equal to, or greater than the specified object. 
        /// </summary>
        /// <param name="o">The object to be compared.</param>
        /// <returns>A negative integer, zero, or a positive integer as this object is less than, equal to, or greater than the specified object.</returns>
        public int CompareTo(T o) => IExecute<int>("compareTo", o);
    }
}
