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
using System.Collections;
using System.Collections.Generic;

namespace Java.Util
{
    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/util/Enumeration.html"/>
    /// </summary>
    /// <typeparam name="E"><see href="https://docs.oracle.com/javase/8/docs/api/java/util/Enumeration.html"/></typeparam>
    public class Enumeration<E> : JVMBridgeBase<Enumeration<E>>
    {
        /// <inheritdoc cref="JVMBridgeBase.ClassName"/>
        public override string ClassName => "java.util.Enumeration";
        /// <inheritdoc cref="JVMBridgeBase.IsInterface"/>
        public override bool IsInterface => true;
        /// <summary>
        /// Tests if this enumeration contains more elements.
        /// </summary>
        public bool HasMoreElements => IExecute<bool>("hasMoreElements");
        /// <summary>
        /// Returns the next element of this enumeration if this enumeration object has at least one more element to provide.
        /// </summary>
        public E NextElement => IExecute<E>("nextElement");
    }
}