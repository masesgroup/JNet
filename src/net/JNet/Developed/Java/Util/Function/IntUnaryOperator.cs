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
    /// Listener for Java IntUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntUnaryOperator.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class IntUnaryOperator : JVMBridgeListener, IIntUnaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetIntUnaryOperator";

        /// <summary>
        /// The <see cref="Func{Int32, Int32}"/> to be executed
        /// </summary>
        public virtual Func<int, int> OnApplyAsInt { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="IntUnaryOperator"/>
        /// </summary>
        public IntUnaryOperator()
        {
            AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<int>>>(ApplyAsIntEventHandler)); OnApplyAsInt = ApplyAsInt;
        }

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
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
