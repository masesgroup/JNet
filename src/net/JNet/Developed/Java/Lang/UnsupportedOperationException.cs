/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/UnsupportedOperationException.html"/>
    /// </summary>
    public class UnsupportedOperationException : RuntimeException
    {
        /// <inheritdoc cref="global::System.Exception()"/>
        public UnsupportedOperationException() { }
        /// <inheritdoc cref="global::System.Exception(string)"/>
        public UnsupportedOperationException(string message) : base(message) { }
        /// <inheritdoc cref="global::System.Exception(string, global::System.Exception)"/>
        public UnsupportedOperationException(string message, global::System.Exception innerException) : base(message, innerException) { }
        /// <inheritdoc />
        public override string BridgeClassName => "java.lang.UnsupportedOperationException";
    }
}
