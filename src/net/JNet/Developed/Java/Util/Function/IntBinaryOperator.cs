/*
*  Copyright 2024 MASES s.r.l.
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
    /// Listener for Java IntBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntBinaryOperator.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class IntBinaryOperator : JVMBridgeListener, IIntBinaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.IntBinaryOperator";

        /// <summary>
        /// The <see cref="Func{Int32, Int32, Int32}"/> to be executed
        /// </summary>
        public virtual Func<int, int, int> OnApplyAsInt { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="IntBinaryOperator"/>
        /// </summary>
        public IntBinaryOperator()
        {
            AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<int>>>(ApplyAsIntEventHandler)); OnApplyAsInt = ApplyAsInt;
        }

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
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
