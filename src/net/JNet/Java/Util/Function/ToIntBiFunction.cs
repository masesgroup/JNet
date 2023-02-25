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
    /// Listener for Java ToIntBiFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ToIntBiFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    /// <typeparam name="U">The data type associated to the event</typeparam>
    public interface IToIntBiFunction<T, U> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o1">The ToIntBiFunction object</param>
        /// <param name="o2">The ToIntBiFunction object</param>
        /// <returns>The applyAsInt result</returns>
        int ApplyAsInt(T o1, U o2);
    }

    /// <summary>
    /// Listener for Java ToIntBiFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ToIntBiFunction.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    /// <typeparam name="U">The data type associated to the event</typeparam>
    public class ToIntBiFunction<T, U> : JVMBridgeListener, IToIntBiFunction<T, U>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetToIntBiFunction";

        Func<T, U, int> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{T, U, Int32}"/> to be executed
        /// </summary>
        public virtual Func<T, U, int> OnApplyAsInt { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="ToIntBiFunction{T, U}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{T, U, Int32}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public ToIntBiFunction(Func<T, U, int> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = ApplyAsInt;

            if (attachEventHandler)
            {
                AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var retVal = OnApplyAsInt(data.EventData.TypedEventData, data.EventData.To<U>(0));
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o1">The ToIntBiFunction object</param>
        /// <param name="o2">The ToIntBiFunction object</param>
        /// <returns>The applyAsInt result</returns>
        public virtual int ApplyAsInt(T o1, U o2) { return default(int); }
    }
}
