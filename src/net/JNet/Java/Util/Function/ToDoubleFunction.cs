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
    /// Listener for Java ToDoubleFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ToDoubleFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    public interface IToDoubleFunction<T> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o">The ToDoubleFunction object</param>
        /// <returns>The applyAsDouble result</returns>
        double ApplyAsDouble(T o);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ToDoubleFunction.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class ToDoubleFunction : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetToDoubleFunction";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ToDoubleFunction.html"/>. Extends <see cref="ToDoubleFunction"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    public class ToDoubleFunction<T> : ToDoubleFunction, IToDoubleFunction<T>
    {
        Func<T, double> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{T, Double}"/> to be executed
        /// </summary>
        public virtual Func<T, double> OnApplyAsDouble { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="ToDoubleFunction{T}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{T, Double}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public ToDoubleFunction(Func<T, double> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = ApplyAsDouble;

            if (attachEventHandler)
            {
                AddEventHandler("applyAsDouble", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var retVal = OnApplyAsDouble(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o">The ToDoubleFunction object</param>
        /// <returns>The applyAsDouble result</returns>
        public virtual double ApplyAsDouble(T o) { return default(double); }
    }
}
