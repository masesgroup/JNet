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
    /// Listener for Java DoubleToIntFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleToIntFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IDoubleToIntFunction : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the DoubleToIntFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of </param>
        /// <returns>The getAsBoolean result</returns>
        int ApplyAsInt(double o);
    }

    /// <summary>
    /// Listener for Java DoubleToIntFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleToIntFunction.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class DoubleToIntFunction : JVMBridgeListener, IDoubleToIntFunction
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "org.mases.jnet.util.function.JNetDoubleToIntFunction";

        Func<double, int> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{Double, Int32}"/> to be executed
        /// </summary>
        public virtual Func<double, int> OnApplyAsInt { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleToIntFunction"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Double, Int32}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public DoubleToIntFunction(Func<double, int> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = ApplyAsInt;

            if (attachEventHandler)
            {
                AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            var retVal = OnApplyAsInt(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the DoubleToIntFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of </param>
        /// <returns>The getAsBoolean result</returns>
        public virtual int ApplyAsInt(double o) { return default(int); }
    }
}
