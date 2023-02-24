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
    /// Listener for Java IntUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntUnaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IIntUnaryOperator : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the IntUnaryOperator action in the CLR
        /// </summary>
        /// <param name="o">The input of IntUnaryOperator</param>
        /// <returns>The applyAsInt result</returns>
        int ApplyAsInt(int o);
    }

    /// <summary>
    /// Listener for Java IntUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntUnaryOperator.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class IntUnaryOperator : JVMBridgeListener, IIntUnaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetIntUnaryOperator";

        Func<int, int> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{Int32, Int32}"/> to be executed
        /// </summary>
        public virtual Func<int, int> OnApplyAsInt { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="IntUnaryOperator"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Int32, Int32}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public IntUnaryOperator(Func<int, int> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = ApplyAsInt;

            if (attachEventHandler)
            {
                AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<int>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var retVal = OnApplyAsInt(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the IntUnaryOperator action in the CLR
        /// </summary>
        /// <param name="o">The input of IntUnaryOperator</param>
        /// <returns>The applyAsInt result</returns>
        public virtual int ApplyAsInt(int o) { return default(int); }
    }
}
