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

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html"/>
    /// </summary>
    public class Optional<T> : JVMBridgeBase<Optional<T>>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.util.Optional";
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#empty()"/>
        /// </summary>
        public static Optional<T> Empty => SExecute<Optional<T>>("empty");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#of(T)"/>
        /// </summary>
        public static Optional<T> Of(T value) => SExecute<Optional<T>>("of", value);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#ofNullable(T)"/>
        /// </summary>
        public static Optional<T> OfNullable(T value) => SExecute<Optional<T>>("ofNullable", value);
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#isPresent()"/>
        /// </summary>
        public bool IsPresent => IExecute<bool>("isPresent");
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/Optional.html#get()"/>
        /// </summary>
        public virtual T Get​() { return IExecute<T>("get"); }
    }
}

