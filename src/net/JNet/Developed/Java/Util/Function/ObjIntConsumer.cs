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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjIntConsumer.html"/>. Extends <see cref="BiConsumer{T, Int32}"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public interface IObjIntConsumer<T> : IBiConsumer<T, int>
    {
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjIntConsumer.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public abstract class ObjIntConsumer : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.ObjIntConsumer";
    }

    /// <summary>
    /// Direct override of <see cref="ObjIntConsumer"/> or its generic type if there is one
    /// </summary>
    public partial class ObjIntConsumerDirect : ObjIntConsumer
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.ObjIntConsumer";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjIntConsumer.html#accept(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public void Accept(object arg0, int arg1)
        {
            IExecute("accept", arg0, arg1);
        }
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ObjIntConsumer.html"/>. Extends <see cref="ObjIntConsumer"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    public class ObjIntConsumer<T> : ObjIntConsumer, IObjIntConsumer<T>
    {
        /// <summary>
        /// The <see cref="Action{T, U}"/> to be executed
        /// </summary>
        public virtual Action<T, int> OnAccept { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="BiConsumer{T, U}"/>
        /// </summary>
        public ObjIntConsumer()
        {
            if (InitHandlers)
            {
                AddEventHandler("accept", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(AcceptEventHandler)); OnAccept = Accept;
            }
        }

        void AcceptEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            OnAccept(data.EventData.TypedEventData, data.EventData.To<int>(0));
        }
        /// <summary>
        /// Executes the Consumer action in the CLR
        /// </summary>
        /// <param name="o1">The Consumer object</param>
        /// <param name="o2">The Consumer object</param>
        public virtual void Accept(T o1, int o2) { }
    }

    /// <summary>
    /// Direct override of <see cref="ObjIntConsumer"/> or its generic type if there is one
    /// </summary>
    public partial class ObjIntConsumerDirect<T> : ObjIntConsumer<T>
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.ObjIntConsumer";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/ObjIntConsumer.html#accept(java.lang.Object,int)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><see cref="int"/></param>
        public override void Accept(T arg0, int arg1)
        {
            IExecute("accept", arg0, arg1);
        }
    }
}
