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
    /// Listener for Java IntToDoubleFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntToDoubleFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IIntToDoubleFunction : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the IntToDoubleFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of IntToDoubleFunction</param>
        /// <returns>The ApplyAsLong result</returns>
        long ApplyAsLong(int o);
    }

    /// <summary>
    /// Listener for Java IntToDoubleFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntToDoubleFunction.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class IntToDoubleFunction : JVMBridgeListener, IIntToDoubleFunction
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.IntToDoubleFunction";

        /// <summary>
        /// The <see cref="Func{Int64, Int32}"/> to be executed
        /// </summary>
        public virtual Func<int, long> OnApplyAsLong { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="IntToDoubleFunction"/>
        /// </summary>
        public IntToDoubleFunction()
        {
            if (InitHandlers)
            {
                AddEventHandler("applyAsLong", new EventHandler<CLRListenerEventArgs<CLREventData<int>>>(ApplyAsLongEventHandler)); OnApplyAsLong = ApplyAsLong;
            }
        }

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<int>> data)
        {
            var retVal = OnApplyAsLong(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the IntToDoubleFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of IntToDoubleFunction</param>
        /// <returns>The ApplyAsLong result</returns>
        public virtual long ApplyAsLong(int o) { return default(long); }
    }

    /// <summary>
    /// Direct override of <see cref="IntToDoubleFunction"/> or its generic type if there is one
    /// </summary>
    public partial class IntToDoubleFunctionDirect : IntToDoubleFunction
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.IntToDoubleFunction";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntToDoubleFunction.html#applyAsDouble(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="double"/></returns>
        public double ApplyAsDouble(int arg0)
        {
            return IExecuteWithSignature<double>("applyAsDouble", "(I)D", arg0);
        }
    }
}
