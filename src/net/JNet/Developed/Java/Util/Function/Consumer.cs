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
    /// Listener for Java Consumer <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Consumer.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public interface IConsumer<TObject> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Consumer action in the CLR
        /// </summary>
        /// <param name="obj">The Consumer object</param>
        void Accept(TObject obj);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Consumer.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public abstract class Consumer : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.Consumer";
    }

    /// <summary>
    /// Direct override of <see cref="Consumer"/> or its generic type if there is one
    /// </summary>
    public partial class ConsumerDirect : Consumer
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.Consumer";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        public void Accept(object arg0)
        {
            IExecuteWithSignature("accept", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        public Java.Util.Function.Consumer AndThen(Java.Util.Function.Consumer arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.ConsumerDirect, Java.Util.Function.Consumer>("andThen", "(Ljava/util/function/Consumer;)Ljava/util/function/Consumer;", arg0);
        }
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Consumer.html"/>. Extends <see cref="Consumer"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public class Consumer<TObject> : Consumer, IConsumer<TObject>
    {
        /// <summary>
        /// The <see cref="Action{TObject}"/> to be executed
        /// </summary>
        public virtual Action<TObject> OnAccept { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Consumer{TObject}"/>
        /// </summary>
        public Consumer()
        {
            if (InitHandlers)
            {
                AddEventHandler("accept", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(AcceptEventHandler)); OnAccept = Accept;
            }
        }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            OnAccept(data.EventData.TypedEventData);
        }
        /// <summary>
        /// Executes the Consumer action in the CLR
        /// </summary>
        /// <param name="obj">The Consumer object</param>
        public virtual void Accept(TObject obj) { }
    }

    /// <summary>
    /// Direct override of <see cref="Consumer"/> or its generic type if there is one
    /// </summary>
    public partial class ConsumerDirect<T> : Consumer<T>
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.Consumer";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#accept(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        public override void Accept(T arg0)
        {
            IExecuteWithSignature("accept", "(Ljava/lang/Object;)V", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Consumer.html#andThen(java.util.function.Consumer)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Consumer"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Consumer"/></returns>
        public Java.Util.Function.Consumer<T> AndThen<Arg0objectSuperT>(Java.Util.Function.Consumer<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return IExecuteWithSignature<Java.Util.Function.ConsumerDirect<T>, Java.Util.Function.Consumer<T>>("andThen", "(Ljava/util/function/Consumer;)Ljava/util/function/Consumer;", arg0);
        }
    }
}
