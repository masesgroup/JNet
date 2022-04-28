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
    /// Listener for Java ObjLongConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjLongConsumer.html"/>. Extends <see cref="BiConsumerListener{T, Int64}"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public interface IObjLongConsumer<T> : IBiConsumer<T, long>
    {
    }

    /// <summary>
    /// Listener for Java ObjLongConsumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjLongConsumer.html"/>. Extends <see cref="BiConsumer{T, Int64}"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public class ObjLongConsumer<T> : BiConsumer<T, long>, IObjLongConsumer<T>
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetObjLongConsumer";

        /// <inheritdoc cref="BiConsumer{T, Int64}"/>
        public ObjLongConsumer(Action<T, long> action = null) : base(action) { }
    }
}
