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
using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public interface IDoubleFunction<TReturn> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the DoubleFunction action in the CLR
        /// </summary>
        /// <param name="obj">The DoubleFunction object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        TReturn Apply(double obj);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleFunction.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class DoubleFunction : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.DoubleFunction";
    }

    /// <summary>
    /// Direct override of <see cref="DoubleFunction"/> or its generic type if there is one
    /// </summary>
    public partial class DoubleFunctionDirect : DoubleFunction
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.DoubleFunction";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleFunction.html#apply(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="object"/></returns>
        public object Apply(double arg0)
        {
            return IExecuteWithSignature("apply", "(D)Ljava/lang/Object;", arg0);
        }
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleFunction.html"/>. Extends <see cref="DoubleFunction"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class DoubleFunction<TReturn> : DoubleFunction, IDoubleFunction<TReturn>
    {
        /// <summary>
        /// The <see cref="Func{Double, TReturn}"/> to be executed
        /// </summary>
        public virtual Func<double, TReturn> OnApply { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleFunction{TReturn}"/>
        /// </summary>
        public DoubleFunction(Func<double, TReturn> func = null, bool attachEventHandler = true)
        {
            if (InitHandlers)
            {
                AddEventHandler("apply", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(ApplyEventHandler)); OnApply = Apply;
            }
        }

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            var retVal = OnApply(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the DoubleFunction action in the CLR
        /// </summary>
        /// <param name="obj">The DoubleFunction object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        public virtual TReturn Apply(double obj) { return default(TReturn); }
    }

    /// <summary>
    /// Direct override of <see cref="DoubleFunction"/> or its generic type if there is one
    /// </summary>
    public partial class DoubleFunctionDirect<R> : DoubleFunction<R>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.DoubleFunction";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleFunction.html#apply(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public override R Apply(double arg0)
        {
            return IExecuteWithSignature<R>("apply", "(D)Ljava/lang/Object;", arg0);
        }
    }
}
