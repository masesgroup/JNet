/*
*  Copyright 2024 MASES s.r.l.
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
    /// Listener for Java IntBinaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntBinaryOperator.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class IntBinaryOperator : JVMBridgeListener, IIntBinaryOperator
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
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
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.IntBinaryOperator";
        private static readonly IJavaType LocalBridgeClazz = ClazzOf(_bridgeClassName);

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
