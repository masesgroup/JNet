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
    /// Listener for Java DoubleUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleUnaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IDoubleUnaryOperator : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the DoubleUnaryOperator action in the CLR
        /// </summary>
        /// <param name="obj">The DoubleUnaryOperator object</param>
        /// <returns>The apply result</returns>
        double ApplyAsDouble(double obj);
    }

    /// <summary>
    /// Listener for Java DoubleUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleUnaryOperator.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class DoubleUnaryOperator : JVMBridgeListener, IDoubleUnaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetDoubleUnaryOperator";

        /// <summary>
        /// The <see cref="Func{Double, Double}"/> to be executed
        /// </summary>
        public virtual Func<double, double> OnApplyAsDouble { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleUnaryOperator"/>
        /// </summary>
        public DoubleUnaryOperator()
        {
            AddEventHandler("applyAsDouble", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(ApplyAsDoubleEventHandler)); OnApplyAsDouble = ApplyAsDouble;
        }

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            var retVal = OnApplyAsDouble(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the DoubleUnaryOperator action in the CLR
        /// </summary>
        /// <param name="obj">The DoubleUnaryOperator object</param>
        /// <returns>The apply result</returns>
        public virtual double ApplyAsDouble(double obj) { return default(double); }
    }
}
