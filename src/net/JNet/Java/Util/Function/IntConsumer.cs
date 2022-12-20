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
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java IntConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntConsumer.html"/>. Extends <see cref="Consumer{Int32}"/>
    /// </summary>
    public interface IIntConsumer : IConsumer<int>
    {
    }

    /// <summary>
    /// Listener for Java IntConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntConsumer.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class IntConsumer : Consumer<int>, IIntConsumer
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetIntConsumer";

        /// <inheritdoc cref="Consumer{Int32}"/>
        /// <param name="action">The <see cref="Action{Int32}"/> to be executed</param>
        public IntConsumer(Action<int> action = null) : base(action) { }
    }
}
