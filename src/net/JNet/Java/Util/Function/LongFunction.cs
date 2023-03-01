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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongFunction.html"/>. Extends <see cref="Function{Int64, TReturn}"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public interface ILongFunction<TReturn> : IFunction<long, TReturn>
    {
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongFunction.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public abstract class LongFunction : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetLongFunction";
    }

    /// <summary>
    /// Listener for Java LongFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongFunction.html"/>. Extends <see cref="Function{Int64, TResult}"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class LongFunction<TReturn> : LongFunction, ILongFunction<TReturn>
    {
        Func<long, TReturn> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{T, TReturn}"/> to be executed
        /// </summary>
        public virtual Func<long, TReturn> OnApply { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="Function{T, TReturn}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{T, TReturn}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public LongFunction(Func<long, TReturn> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = Apply;

            if (attachEventHandler)
            {
                AddEventHandler("apply", new EventHandler<CLRListenerEventArgs<CLREventData<long>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var retVal = OnApply(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="obj">The Function object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        public virtual TReturn Apply(long obj) { return default; }
    }
}
