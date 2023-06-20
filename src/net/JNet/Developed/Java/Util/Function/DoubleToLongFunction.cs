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
    /// Listener for Java DoubleToLongFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleToLongFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IDoubleToLongFunction : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the DoubleToLongFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of </param>
        /// <returns>The getAsBoolean result</returns>
        long ApplyAsLong(double o);
    }

    /// <summary>
    /// Listener for Java DoubleToLongFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleToLongFunction.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class DoubleToLongFunction : JVMBridgeListener, IDoubleToLongFunction
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetDoubleToLongFunction";

        /// <summary>
        /// The <see cref="Func{Double, Int64}"/> to be executed
        /// </summary>
        public virtual Func<double, long> OnApplyAsLong { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleToLongFunction"/>
        /// </summary>
        public DoubleToLongFunction()
        {
            AddEventHandler("applyAsLong", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(ApplyAsLongEventHandler)); OnApplyAsLong = ApplyAsLong;
        }

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            var retVal = OnApplyAsLong(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the DoubleToLongFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of </param>
        /// <returns>The getAsBoolean result</returns>
        public virtual long ApplyAsLong(double o) { return default(long); }
    }
}
