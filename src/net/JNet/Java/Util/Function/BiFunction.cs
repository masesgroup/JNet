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
    /// Listener for Java BiFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BiFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    /// <typeparam name="U">The data type associated to the event</typeparam>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public interface IBiFunction<T, U, TReturn> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o1">The BiFunction object</param>
        /// <param name="o2">The BiFunction object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        TReturn Apply(T o1, U o2);
    }

    /// <summary>
    /// Listener for Java BiFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BiFunction.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    /// <typeparam name="U">The data type associated to the event</typeparam>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class BiFunction<T, U, TReturn> : JVMBridgeListener, IBiFunction<T, U, TReturn>
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetBiFunction";

        Func<T, U, TReturn> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{T, U, TReturn}"/> to be executed
        /// </summary>
        public virtual Func<T, U, TReturn> OnApply { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="BiFunction{T, U, TReturn}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{T, U, TReturn}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public BiFunction(Func<T, U, TReturn> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = Apply;

            if (attachEventHandler)
            {
                AddEventHandler("apply", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var retVal = OnApply(data.EventData.TypedEventData, data.EventData.To<U>(0));
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o1">The BiFunction object</param>
        /// <param name="o2">The BiFunction object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        public virtual TReturn Apply(T o1, U o2) { return default(TReturn); }
    }
}
