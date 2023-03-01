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
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/>
    /// </summary>
    public class Iterable : JVMBridgeBaseEnumerable<Iterable>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.lang.Iterable";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
#if !JNETREFLECTOR
        /// <summary>
        /// Returns an iterator over elements of type <see langref="object"/>
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        public Util.Iterator Iterator => IExecute<Util.Iterator>("iterator");
#endif
    }

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/>
    /// </summary>
    /// <typeparam name="T"><see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/></typeparam>
    public class Iterable<T> : MASES.JNet.Specific.JVMBridgeBaseAsyncEnumerable<Iterable<T>, T>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "java.lang.Iterable";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsInterface.htm"/>
        /// </summary>
        public override bool IsInterface => true;
#if !JNETREFLECTOR
        /// <summary>
        /// Returns an iterator over elements of type <typeparamref name="T"/>.
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        public Util.Iterator<T> Iterator => IExecute<Util.Iterator<T>>("iterator");
#endif
    }
}
