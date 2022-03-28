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
    /// Listener for Java LongFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongFunction.html"/>. Extends <see cref="Function{Int64, TReturn}"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public interface ILongFunction<TReturn> : IFunction<long, TReturn>
    {
    }

    /// <summary>
    /// Listener for Java LongFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongFunction.html"/>. Extends <see cref="FunctionListener{Int64, TResult}"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class LongFunction<TReturn> : Function<long, TReturn>, ILongFunction<TReturn>
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetLongFunction";

        /// <inheritdoc cref="Function{Int64, TReturn}"/>
        /// <param name="func">The <see cref="Func{Int32, TReturn}"/> to be executed</param>
        public LongFunction(Func<long, TReturn> func = null) : base(func) { }
    }
}
