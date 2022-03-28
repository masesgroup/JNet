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
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java ObjIntConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjIntConsumer.html"/>. Extends <see cref="BiConsumer{T, Int32}"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public interface IObjIntConsumer<T> : IBiConsumer<T, int>
    {
    }

    /// <summary>
    /// Listener for Java ObjIntConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjIntConsumer.html"/>. Extends <see cref="BiConsumerListener{T, Int32}"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public class ObjIntConsumer<T> : BiConsumer<T, int>, IObjIntConsumer<T>
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetObjIntConsumer";

        /// <inheritdoc cref="BiConsumer{T, Int32}"/>
        /// <param name="action">The <see cref="Action{T, Int32}"/> to be executed</param>
        public ObjIntConsumer(Action<T, int> action = null) : base(action) { }
    }
}
