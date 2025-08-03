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
    /// Listener for Java LongToIntFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongToIntFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface ILongToIntFunction : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the LongToIntFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of LongToIntFunction</param>
        /// <returns>The applyAsInt result</returns>
        int ApplyAsInt(long o);
    }

    /// <summary>
    /// Listener for Java LongToIntFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongToIntFunction.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class LongToIntFunction : JVMBridgeListener, ILongToIntFunction
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.LongToIntFunction";

        /// <summary>
        /// The <see cref="Func{Int32, Int64}"/> to be executed
        /// </summary>
        public virtual Func<long, int> OnApplyAsInt { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="LongToIntFunction"/>
        /// </summary>
        public LongToIntFunction()
        {
            if (InitHandlers)
            {
                AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyAsIntEventHandler)); OnApplyAsInt = ApplyAsInt;
            }
        }

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var retVal = OnApplyAsInt(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the LongToIntFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of LongToIntFunction</param>
        /// <returns>The applyAsInt result</returns>
        public virtual int ApplyAsInt(long o) { return default(int); }
    }

    /// <summary>
    /// Direct override of <see cref="LongToIntFunction"/> or its generic type if there is one
    /// </summary>
    public partial class LongToIntFunctionDirect : LongToIntFunction
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.LongToIntFunction";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongToIntFunction.html#applyAsInt(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="int"/></returns>
        public override int ApplyAsInt(long arg0)
        {
            return IExecuteWithSignature<int>("applyAsInt", "(J)I", arg0);
        }
    }
}
