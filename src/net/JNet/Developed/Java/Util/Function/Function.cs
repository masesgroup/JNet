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
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java Function <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Function.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public interface IFunction<TObject, TReturn> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="obj">The Function object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        TReturn Apply(TObject obj);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Function.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public abstract class Function : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;

        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.Function";
    }

    /// <summary>
    /// Direct override of <see cref="Function"/>
    /// </summary>
    public class FunctionDirect : Function
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        /// <inheritdoc />
        public override string BridgeClassName => "java.util.function.Function";
        /// <inheritdoc />
        public override bool IsBridgeAbstract => false;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="object"/></returns>
        public object Apply(object arg0)
        {
            return IExecuteWithSignature("apply", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function AndThen(Java.Util.Function.Function arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.FunctionDirect, Java.Util.Function.Function>("andThen", "(Ljava/util/function/Function;)Ljava/util/function/Function;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function Compose(Java.Util.Function.Function arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.FunctionDirect, Java.Util.Function.Function>("compose", "(Ljava/util/function/Function;)Ljava/util/function/Function;", arg0);
        }
    }

    /// <summary>
    /// Listener for Java Function <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Function.html"/>. Extends <see cref="Function"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class Function<TObject, TReturn> : Function, IFunction<TObject, TReturn>
    {
        /// <summary>
        /// The <see cref="Func{TObject, TReturn}"/> to be executed
        /// </summary>
        public virtual Func<TObject, TReturn> OnApply { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Function{TObject, TReturn}"/>
        /// </summary>
        public Function()
        {
            if (InitHandlers)
            {
                AddEventHandler("apply", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(ApplyEventHandler)); OnApply = Apply;
            }
        }

        void ApplyEventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            var retVal = OnApply(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="obj">The Function object</param>
        /// <returns>The apply <typeparamref name="TReturn"/></returns>
        public virtual TReturn Apply(TObject obj) { return default; }
    }

    /// <summary>
    /// Direct override of <see cref="Function{TObject, TReturn}"/>
    /// </summary>
    public class FunctionDirect<T, R> : Function<T, R>
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        /// <inheritdoc />
        public override string BridgeClassName => "java.util.function.Function";
        /// <inheritdoc />
        public override bool IsBridgeAbstract => false;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#apply(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><typeparamref name="R"/></returns>
        public override R Apply(T arg0)
        {
            return IExecuteWithSignature<R>("apply", "(Ljava/lang/Object;)Ljava/lang/Object;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#andThen(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperR"><typeparamref name="R"/></typeparam>
        /// <typeparam name="Arg0ExtendsV"><typeparamref name="V"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function<T, V> AndThen<V, Arg0objectSuperR, Arg0ExtendsV>(Java.Util.Function.Function<Arg0objectSuperR, Arg0ExtendsV> arg0) where Arg0objectSuperR : R where Arg0ExtendsV : V
        {
            return IExecuteWithSignature<Java.Util.Function.FunctionDirect<T, V>, Java.Util.Function.Function<T, V>>("andThen", "(Ljava/util/function/Function;)Ljava/util/function/Function;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Function.html#compose(java.util.function.Function)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Function"/></param>
        /// <typeparam name="V"></typeparam>
        /// <typeparam name="Arg0objectSuperV"><typeparamref name="V"/></typeparam>
        /// <typeparam name="Arg0ExtendsT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Function"/></returns>
        public Java.Util.Function.Function<V, R> Compose<V, Arg0objectSuperV, Arg0ExtendsT>(Java.Util.Function.Function<Arg0objectSuperV, Arg0ExtendsT> arg0) where Arg0objectSuperV : V where Arg0ExtendsT : T
        {
            return IExecuteWithSignature<Java.Util.Function.FunctionDirect<V, R>, Java.Util.Function.Function<V, R>>("compose", "(Ljava/util/function/Function;)Ljava/util/function/Function;", arg0);
        }
    }
}
