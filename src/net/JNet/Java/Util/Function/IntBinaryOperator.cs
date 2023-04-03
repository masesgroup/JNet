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
    /// Listener for Java IntBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntBinaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IIntBinaryOperator : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the IntBinaryOperator action in the CLR
        /// </summary>
        /// <param name="o1">The IntBinaryOperator object</param>
        /// <param name="o2">The IntBinaryOperator object</param>
        /// <returns>The apply result</returns>
        int ApplyAsInt(int o1, int o2);
    }

    /// <summary>
    /// Listener for Java IntBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntBinaryOperator.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class IntBinaryOperator : JVMBridgeListener, IIntBinaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "org.mases.jnet.util.function.JNetIntBinaryOperator";

        Func<int, int, int> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{Int32, Int32, Int32}"/> to be executed
        /// </summary>
        public virtual Func<int, int, int> OnApplyAsInt { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="IntBinaryOperator"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Int32, Int32, Int32}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public IntBinaryOperator(Func<int, int, int> func = null, bool attachEventHandler = true)
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
            var retVal = OnApplyAsInt(data.EventData.TypedEventData, data.EventData.To<int>(0));
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the IntBinaryOperator action in the CLR
        /// </summary>
        /// <param name="o1">The IntBinaryOperator object</param>
        /// <param name="o2">The IntBinaryOperator object</param>
        /// <returns>The apply result</returns>
        public virtual int ApplyAsInt(int o1, int o2) { return default(int); }
    }
}
