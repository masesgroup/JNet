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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Boolean.html"/>
    /// </summary>
    public sealed class Boolean : JVMBridgeBase<Boolean>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.Boolean";
        /// <summary>
        /// Compares two boolean values.
        /// </summary>
        /// <param name="x">The first <see cref="bool"/> to compare</param>
        /// <param name="y">The second <see cref="bool"/> to compar</param>
        /// <returns>the value 0 if x == y; a value less than 0 if !x AND y; and a value greater than 0 if x AND !y</returns>
        public static int Compare​(bool x, bool y) => SExecute<int>("compare", x, y);
        /// <summary>
        /// Returns <see langword="true"/> if and only if the system property named by the argument exists and is equal to, ignoring case, the string "true".
        /// </summary>
        /// <param name="name">The system property name.</param>
        /// <returns>The <see cref="bool"/> value of the system property.</returns>
        public static bool GetBoolean​(string name) => SExecute<bool>("getBoolean​", name);
        /// <summary>
        /// Returns a hash code for a <see cref="bool"/> value; compatible with <see cref="JVMBridgeBase.GetHashCode"/>.
        /// </summary>
        /// <param name="value">The value to hash</param>
        /// <returns>A hash code value for a <see cref="bool"/> value.</returns>
        public static int HashCode​(bool value) => SExecute<int>("hashCode​​", value);
        /// <summary>
        /// Returns the result of applying the logical AND operator to the specified boolean operands.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool LogicalAnd​(bool a, bool b) => SExecute<bool>("logicalAnd​​​", a, b);
        /// <summary>
        /// Returns the result of applying the logical OR operator to the specified boolean operands.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool LogicalOr​(bool a, bool b) => SExecute<bool>("logicalOr​​​​", a, b);
        /// <summary>
        /// Returns the result of applying the logical XOR operator to the specified boolean operands.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool LogicalXor​(bool a, bool b) => SExecute<bool>("logicalXor​​​​", a, b);
        /// <summary>
        /// Parses the string argument as a boolean.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool ParseBoolean​(string s) => SExecute<bool>("parseBoolean​​​​​​​", s);
        /// <summary>
        /// Returns a String object representing the specified boolean.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static string ToString​(bool b) => SExecute<string>("toString​​​​​​​​", b);
        /// <summary>
        /// Returns a <see cref="Boolean"/> instance representing the specified <see cref="bool"/> value.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public static Boolean ValueOf​(bool b) => SExecute<Boolean>("valueOf​​​​​", b);
        /// <summary>
        ///  Returns a <see cref="Boolean"/> with a value represented by the specified <see cref="string"/>.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static Boolean ValueOf​(string s) => SExecute<Boolean>("valueOf​​​​​", s);
        /// <summary>
        /// Returns the value of this <see cref="Boolean"/> object as a <see cref="Boolean"/> primitive.
        /// </summary>
        public bool BooleanValue​ => IExecute<bool>("booleanValue​");
        /// <summary>
        /// Compares this <see cref="Boolean"/> instance with another.
        /// </summary>
        /// <param name="b">The <see cref="Boolean"/> instance to be compared</param>
        /// <returns>zero if this object represents the same boolean value as the argument; a positive value if this object represents true and the argument represents false; and a negative value if this object represents false and the argument represents true</returns>
        public int CompareTo​(Boolean b) => IExecute<int>("compareTo​", b);
    }
}
