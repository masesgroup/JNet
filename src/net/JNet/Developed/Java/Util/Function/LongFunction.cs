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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongFunction.html"/>. Extends <see cref="Function{Int64, TReturn}"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public interface ILongFunction<TReturn> : IFunction<long, TReturn>
    {
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongFunction.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public abstract class LongFunction : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.LongFunction";
    }

    /// <summary>
    /// Direct override of <see cref="LongFunction"/> or its generic type if there is one
    /// </summary>
    public partial class LongFunctionDirect : LongFunction
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.LongFunction";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongFunction.html#apply(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><see cref="object"/></returns>
        public object Apply(long arg0)
        {
            return IExecuteWithSignature("apply", "(J)Ljava/lang/Object;", arg0);
        }
    }

    /// <summary>
    /// Listener for Java LongFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongFunction.html"/>. Extends <see cref="Function{Int64, TResult}"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class LongFunction<TReturn> : LongFunction, ILongFunction<TReturn>
    {
        /// <summary>
        /// The <see cref="Func{T, TReturn}"/> to be executed
        /// </summary>
        public virtual Func<long, TReturn> OnApply { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Function{T, TReturn}"/>
        /// </summary>
        public LongFunction()
        {
            if (InitHandlers)
            {
                AddEventHandler("apply", new EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyEventHandler)); OnApply = Apply;
            }
        }

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var retVal = OnApply(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="obj">The Function object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        public virtual TReturn Apply(long obj) { return default; }
    }

    /// <summary>
    /// Direct override of <see cref="LongFunction"/> or its generic type if there is one
    /// </summary>
    public partial class LongFunctionDirect<R> : LongFunction<R>
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.LongFunction";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/LongFunction.html#apply(long)"/>
        /// </summary>
        /// <param name="arg0"><see cref="long"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public override R Apply(long arg0)
        {
            return IExecuteWithSignature<R>("apply", "(J)Ljava/lang/Object;", arg0);
        }
    }
}
