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
    /// Listener for Java DoubleBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleBinaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IDoubleBinaryOperator : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the DoubleBinaryOperator action in the CLR
        /// </summary>
        /// <param name="o1">The DoubleBinaryOperator object</param>
        /// <param name="o2">The DoubleBinaryOperator object</param>
        /// <returns>The applyAsDouble result</returns>
        double ApplyAsDouble(double o1, double o2);
    }

    /// <summary>
    /// Listener for Java DoubleBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleBinaryOperator.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class DoubleBinaryOperator : JVMBridgeListener, IDoubleBinaryOperator
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetDoubleBinaryOperator";

        Func<double, double, double> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{Double, Double, Double}"/> to be executed
        /// </summary>
        public virtual Func<double, double, double> OnApplyAsDouble { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleBinaryOperator"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Double, Double, Double}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public DoubleBinaryOperator(Func<double, double, double> func = null, bool attachEventHandler = true)
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
            var retVal = OnApplyAsDouble(data.EventData.TypedEventData, data.EventData.To<double>(0));
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the DoubleBinaryOperator action in the CLR
        /// </summary>
        /// <param name="o1">The DoubleBinaryOperator object</param>
        /// <param name="o2">The DoubleBinaryOperator object</param>
        /// <returns>The applyAsDouble result</returns>
        public virtual double ApplyAsDouble(double o1, double o2) { return default(double); }
    }
}
