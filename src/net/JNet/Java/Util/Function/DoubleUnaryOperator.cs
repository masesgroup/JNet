/*
*  Copyright 2022 MASES s.r.l.
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
    /// Listener for Java DoubleUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleUnaryOperator.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class DoubleUnaryOperator : JVMBridgeListener, IDoubleUnaryOperator
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetDoubleUnaryOperator";

        Func<double, double> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{Double, Double}"/> to be executed
        /// </summary>
        public virtual Func<double, double> OnApplyAsDouble { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleUnaryOperator"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Double, Double}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public DoubleUnaryOperator(Func<double, double> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = ApplyAsDouble;

            if (attachEventHandler)
            {
                AddEventHandler("applyAsDouble", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
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
