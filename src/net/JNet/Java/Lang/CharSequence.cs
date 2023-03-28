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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/CharSequence.html"/>
    /// </summary>
    public class CharSequence : JVMBridgeBase<CharSequence>
    {
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public CharSequence() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public CharSequence(params object[] args) : base(args) { }
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.lang.CharSequence";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
        /// <summary>
        /// Returns the char value at the specified index. An index ranges from zero to length() - 1. The first char value of the sequence is at index zero, the next at index one, and so on, as for array indexing. 
        /// </summary>
        /// <param name="index">The index of the char value to be returned</param>
        /// <returns>The specified char value</returns>
        public char CharAt(int index) => IExecute<char>("charAt", index);
        /// <summary>
        /// Returns the length of this character sequence.
        /// </summary>
        /// <returns>The number of chars in this sequence</returns>
        public int Length => IExecute<int>("length");
        /// <summary>
        /// Returns a CharSequence that is a subsequence of this sequence. The subsequence starts with the char value at the specified index and ends with the char value at index end - 1. The length (in chars) of the returned sequence is end - start, so if start == end then an empty sequence is returned.
        /// </summary>
        /// <param name="start">The start index, inclusive</param>
        /// <param name="end">The end index, exclusive</param>
        /// <returns>The specified subsequence</returns>
        public CharSequence SubSequence(int start, int end) => IExecute<CharSequence>("subSequence", start, end);
    }
}
