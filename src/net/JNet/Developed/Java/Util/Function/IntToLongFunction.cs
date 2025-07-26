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
    /// Listener for Java IntToLongFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntToLongFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IIntToLongFunction : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the IntToLongFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of IntToLongFunction</param>
        /// <returns>The applyAsLong result</returns>
        long ApplyAsLong(int o);
    }

    /// <summary>
    /// Listener for Java IntToLongFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntToLongFunction.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class IntToLongFunction : JVMBridgeListener, IIntToLongFunction
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.IntToLongFunction";

        /// <summary>
        /// The <see cref="Func{Int64, Int32}"/> to be executed
        /// </summary>
        public virtual Func<int, long> OnApplyAsLong { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="IntToLongFunction"/>
        /// </summary>
        public IntToLongFunction()
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
        /// Executes the IntToLongFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of IntToLongFunction</param>
        /// <returns>The applyAsLong result</returns>
        public virtual long ApplyAsLong(int o) { return default(long); }
    }

    /// <summary>
    /// Direct override of <see cref="IntToLongFunction"/> or its generic type if there is one
    /// </summary>
    public partial class IntToLongFunctionDirect : IntToLongFunction
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.IntToLongFunction";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/IntToLongFunction.html#applyAsLong(int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="int"/></param>
        /// <returns><see cref="long"/></returns>
        public override long ApplyAsLong(int arg0)
        {
            return IExecuteWithSignature<long>("applyAsLong", "(I)J", arg0);
        }
    }
}
