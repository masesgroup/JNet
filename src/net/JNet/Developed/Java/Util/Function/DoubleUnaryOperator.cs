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
    /// Listener for Java DoubleUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleUnaryOperator.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class DoubleUnaryOperator : JVMBridgeListener, IDoubleUnaryOperator
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.DoubleUnaryOperator";

        /// <summary>
        /// The <see cref="Func{Double, Double}"/> to be executed
        /// </summary>
        public virtual Func<double, double> OnApplyAsDouble { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleUnaryOperator"/>
        /// </summary>
        public DoubleUnaryOperator()
        {
            if (InitHandlers)
            {
                AddEventHandler("applyAsDouble", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(ApplyAsDoubleEventHandler)); OnApplyAsDouble = ApplyAsDouble;
            }
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

    /// <summary>
    /// Direct override of <see cref="DoubleUnaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class DoubleUnaryOperatorDirect : DoubleUnaryOperator
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.DoubleUnaryOperator";
        private static readonly global::System.Exception _LocalBridgeClazzException = null;
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName, out _LocalBridgeClazzException, false);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw _LocalBridgeClazzException ?? new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#applyAsDouble(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="double"/></returns>
        public override double ApplyAsDouble(double arg0)
        {
            return IExecuteWithSignature<double>("applyAsDouble", "(D)D", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#andThen(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        public Java.Util.Function.DoubleUnaryOperator AndThen(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoubleUnaryOperatorDirect, Java.Util.Function.DoubleUnaryOperator>("andThen", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleUnaryOperator.html#compose(java.util.function.DoubleUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoubleUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.DoubleUnaryOperator"/></returns>
        public Java.Util.Function.DoubleUnaryOperator Compose(Java.Util.Function.DoubleUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoubleUnaryOperatorDirect, Java.Util.Function.DoubleUnaryOperator>("compose", "(Ljava/util/function/DoubleUnaryOperator;)Ljava/util/function/DoubleUnaryOperator;", arg0);
        }
    }
}
