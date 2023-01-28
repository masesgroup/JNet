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
    /// Listener for Java BinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BinaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    public interface IBinaryOperator<T> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o1">The Function object</param>
        /// <param name="o2">The Function object</param>
        /// <returns>The apply <typeparamref name="T"/></returns>
        T Apply(T o1, T o2);
    }

    /// <summary>
    /// Listener for Java BinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BinaryOperator.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    public class BinaryOperator<T> : JVMBridgeListener, IBinaryOperator<T>
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetBinaryOperator";

        Func<T, T, T> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{TObject, TReturn}"/> to be executed
        /// </summary>
        public virtual Func<T, T, T> OnApply { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="BinaryOperator{T}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{T,T,T}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public BinaryOperator(Func<T, T, T> func = null, bool attachEventHandler = true)
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
            var retVal = OnApply(data.EventData.TypedEventData, data.EventData.To<T>(0));
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o1">The Function object</param>
        /// <param name="o2">The Function object</param>
        /// <returns>The apply <typeparamref name="T"/></returns>
        public virtual T Apply(T o1, T o2) { return default(T); }
    }
}
