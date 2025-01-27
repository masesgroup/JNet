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
    /// Listener for Java LongUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongUnaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface ILongUnaryOperator : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the LongUnaryOperator action in the CLR
        /// </summary>
        /// <param name="o">The input of LongUnaryOperator</param>
        /// <returns>The applyAsLong result</returns>
        long ApplyAsLong(long o);
    }

    /// <summary>
    /// Listener for Java LongUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongUnaryOperator.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class LongUnaryOperator : JVMBridgeListener, ILongUnaryOperator
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.LongUnaryOperator";

        /// <summary>
        /// The <see cref="Func{Int64, Int64}"/> to be executed
        /// </summary>
        public virtual Func<long, long> OnApplyAsLong { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="LongUnaryOperator"/>
        /// </summary>
        public LongUnaryOperator()
        {
            if (InitHandlers)
            {
                AddEventHandler("applyAsLong", new EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyAsLongEventHandler)); OnApplyAsLong = ApplyAsLong;
            }
        }

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var retVal = OnApplyAsLong(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the LongUnaryOperator action in the CLR
        /// </summary>
        /// <param name="o">The input of LongUnaryOperator</param>
        /// <returns>The applyAsLong result</returns>
        public virtual long ApplyAsLong(long o) { return default(long); }
    }

    /// <summary>
    /// Direct override of <see cref="LongUnaryOperator"/> or its generic type if there is one
    /// </summary>
    public partial class LongUnaryOperatorDirect : LongUnaryOperator
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.LongUnaryOperator";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#applyAsLong(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="long"/></returns>
        public override long ApplyAsLong(long arg0)
        {
            return IExecuteWithSignature<long>("applyAsLong", "(J)J", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#andThen(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public Java.Util.Function.LongUnaryOperator AndThen(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongUnaryOperatorDirect, Java.Util.Function.LongUnaryOperator>("andThen", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongUnaryOperator.html#compose(java.util.function.LongUnaryOperator)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.LongUnaryOperator"/></param>
        /// <returns><see cref="Java.Util.Function.LongUnaryOperator"/></returns>
        public Java.Util.Function.LongUnaryOperator Compose(Java.Util.Function.LongUnaryOperator arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.LongUnaryOperatorDirect, Java.Util.Function.LongUnaryOperator>("compose", "(Ljava/util/function/LongUnaryOperator;)Ljava/util/function/LongUnaryOperator;", arg0);
        }
    }
}
