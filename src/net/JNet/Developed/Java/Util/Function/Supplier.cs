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
    /// Listener for Java Supplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Supplier.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public interface ISupplier<TReturn> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Supplier action in the CLR
        /// </summary>
        /// <returns>The get <typeparamref name="TReturn"/></returns>
        TReturn Get();
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Supplier.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public abstract class Supplier : JVMBridgeListener
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;

        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.Supplier";
    }

    /// <summary>
    /// Direct override of <see cref="Supplier"/>
    /// </summary>
    public class SupplierDirect : Supplier
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        /// <inheritdoc />
        public override string BridgeClassName => "java.util.function.Supplier";
        /// <inheritdoc />
        public override bool IsBridgeAbstract => false;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Supplier.html#get()"/>
        /// </summary>
        /// <returns><see cref="object"/></returns>
        public object Get()
        {
            return IExecuteWithSignature("get", "()Ljava/lang/Object;");
        }
    }

    /// <summary>
    /// Listener for Java Supplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Supplier.html"/>. Extends <see cref="Supplier"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class Supplier<TReturn> : Supplier, ISupplier<TReturn>
    {
        /// <summary>
        /// The <see cref="Func{TReturn}"/> to be executed
        /// </summary>
        public virtual Func<TReturn> OnGet { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Supplier{TReturn}"/>
        /// </summary>
        public Supplier()
        {
            if (InitHandlers)
            {
                AddEventHandler("get", new EventHandler<CLRListenerEventArgs<CLREventData>>(GetEventHandler)); OnGet = Get;
            }
        }

        void GetEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var retVal = OnGet();
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Supplier action in the CLR
        /// </summary>
        /// <returns>The get <typeparamref name="TReturn"/></returns>
        public virtual TReturn Get() { return default(TReturn); }
    }

    /// <summary>
    /// Direct override of <see cref="Supplier{TReturn}"/>
    /// </summary>
    public class SupplierDirect<T> : Supplier<T>
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        /// <inheritdoc />
        public override string BridgeClassName => "java.util.function.Supplier";
        /// <inheritdoc />
        public override bool IsBridgeAbstract => false;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Supplier.html#get()"/>
        /// </summary>
        /// <returns><typeparamref name="T"/></returns>
        public override T Get()
        {
            return IExecuteWithSignature<T>("get", "()Ljava/lang/Object;");
        }
    }
}
