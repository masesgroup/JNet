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
    /// Listener for Java IntBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntBinaryOperator.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class IntBinaryOperator : JVMBridgeListener, IIntBinaryOperator
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
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
            if (InitHandlers)
            {
                AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<int>>>(ApplyAsIntEventHandler)); OnApplyAsInt = ApplyAsInt;
            }
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

    /// <summary>
    /// Direct override of <see cref="IntBinaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class IntBinaryOperatorDirect : IntBinaryOperator
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.IntBinaryOperator";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntBinaryOperator.html#applyAsInt(int,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        /// <returns><see cref="int"/></returns>
        public override int ApplyAsInt(int arg0, int arg1)
        {
            return IExecute<int>("applyAsInt", arg0, arg1);
        }
    }
}
