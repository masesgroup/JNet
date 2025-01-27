/*
*  Copyright 2025 MASES s.r.l.
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
using MASES.JCOBridge.C2JBridge.JVMInterop;
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
    /// Listener for Java DoubleToIntFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleToIntFunction.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class DoubleToIntFunction : JVMBridgeListener, IDoubleToIntFunction
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.DoubleToIntFunction";

        /// <summary>
        /// The <see cref="Func{Double, Int32}"/> to be executed
        /// </summary>
        public virtual Func<double, int> OnApplyAsInt { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleToIntFunction"/>
        /// </summary>
        public DoubleToIntFunction()
        {
            if (InitHandlers)
            {
                AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(ApplyAsIntEventHandler)); OnApplyAsInt = ApplyAsInt;
            }
        }

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
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

    /// <summary>
    /// Direct override of <see cref="DoubleToIntFunction"/> or its generic type if there is one
    /// </summary>
    public partial class DoubleToIntFunctionDirect : DoubleToIntFunction
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.DoubleToIntFunction";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleToIntFunction.html#applyAsInt(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="int"/></returns>
        public override int ApplyAsInt(double arg0)
        {
            return IExecuteWithSignature<int>("applyAsInt", "(D)I", arg0);
        }
    }
}
