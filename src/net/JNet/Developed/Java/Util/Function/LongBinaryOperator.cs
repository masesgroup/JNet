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
    /// Listener for Java LongBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongBinaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface ILongBinaryOperator : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the LongBinaryOperator action in the CLR
        /// </summary>
        /// <param name="o1">The LongBinaryOperator object</param>
        /// <param name="o2">The LongBinaryOperator object</param>
        /// <returns>The apply result</returns>
        long ApplyAsLong(long o1, long o2);
    }

    /// <summary>
    /// Listener for Java LongBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongBinaryOperator.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class LongBinaryOperator : JVMBridgeListener, ILongBinaryOperator
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.LongBinaryOperator";

        /// <summary>
        /// The <see cref="Func{Int64, Int64, Int64}"/> to be executed
        /// </summary>
        public virtual Func<long, long, long> OnApplyAsLong { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="LongBinaryOperator"/>
        /// </summary>
        public LongBinaryOperator()
        {
            if (InitHandlers)
            {
                AddEventHandler("applyAsLong", new EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyAsLongEventHandler)); OnApplyAsLong = ApplyAsLong;
            }
        }

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var retVal = OnApplyAsLong(data.EventData.TypedEventData, data.EventData.To<long>(0));
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the LongBinaryOperator action in the CLR
        /// </summary>
        /// <param name="o1">The LongBinaryOperator object</param>
        /// <param name="o2">The LongBinaryOperator object</param>
        /// <returns>The apply result</returns>
        public virtual long ApplyAsLong(long o1, long o2) { return default(long); }
    }

    /// <summary>
    /// Direct override of <see cref="LongBinaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class LongBinaryOperatorDirect : LongBinaryOperator
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.LongBinaryOperator";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongBinaryOperator.html#applyAsLong(long,long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <param name="arg1"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public override long ApplyAsLong(long arg0, long arg1)
        {
            return IExecute<long>("applyAsLong", arg0, arg1);
        }
    }
}
