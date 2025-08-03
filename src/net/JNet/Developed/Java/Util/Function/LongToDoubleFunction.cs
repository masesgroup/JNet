/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
    /// Listener for Java LongToDoubleFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongToDoubleFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface ILongToDoubleFunction : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the LongToDoubleFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of LongToDoubleFunction</param>
        /// <returns>The applyAsDouble result</returns>
        double ApplyAsDouble(long o);
    }

    /// <summary>
    /// Listener for Java LongToDoubleFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongToDoubleFunction.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class LongToDoubleFunction : JVMBridgeListener, ILongToDoubleFunction
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.LongToDoubleFunction";

        /// <summary>
        /// The <see cref="Func{Double, Int64}"/> to be executed
        /// </summary>
        public virtual Func<long, double> OnApplyAsDouble { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="LongToDoubleFunction"/>
        /// </summary>
        public LongToDoubleFunction()
        {
            if (InitHandlers)
            {
                AddEventHandler("applyAsDouble", new EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyAsDoubleEventHandler)); OnApplyAsDouble = ApplyAsDouble;
            }
        }

        void ApplyAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var retVal = OnApplyAsDouble(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the LongToDoubleFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of LongToDoubleFunction</param>
        /// <returns>The ApplyAsDouble result</returns>
        public virtual double ApplyAsDouble(long o) { return default(double); }
    }

    /// <summary>
    /// Direct override of <see cref="LongToDoubleFunction"/> or its generic type if there is one
    /// </summary>
    public partial class LongToDoubleFunctionDirect : LongToDoubleFunction
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.LongToDoubleFunction";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <inheritdoc />
        public override string BridgeClassName => _bridgeClassName;
        /// <inheritdoc />
        public override bool IsBridgeAbstract => true;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongToDoubleFunction.html#applyAsDouble(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="double"/></returns>
        public override double ApplyAsDouble(long arg0)
        {
            return IExecuteWithSignature<double>("applyAsDouble", "(J)D", arg0);
        }
    }
}
