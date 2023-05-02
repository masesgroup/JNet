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

namespace Java.Lang
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Comparable.html"/>
    /// </summary>
    public class Comparable : JVMBridgeBase<Comparable>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Comparable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Comparable(params object[] args) : base(args) { }
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.Comparable";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
    }

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Comparable.html"/>
    /// </summary>
    /// <typeparam name="T"><see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Comparable.html"/></typeparam>
    public class Comparable<T> : Comparable
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Comparable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Comparable(params object[] args) : base(args) { }
        /// <summary>
        /// Compares this object with the specified object for order. Returns a negative integer, zero, or a positive integer as this object is less than, equal to, or greater than the specified object. 
        /// </summary>
        /// <param name="o">The object to be compared.</param>
        /// <returns>A negative integer, zero, or a positive integer as this object is less than, equal to, or greater than the specified object.</returns>
        public int CompareTo(T o) => IExecute<int>("compareTo", o);
    }
}
