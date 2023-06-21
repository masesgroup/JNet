/*
*  Copyright 2023 MASES s.r.l.
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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Supplier.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class Supplier : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetSupplier";
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
            AddEventHandler("get", new EventHandler<CLRListenerEventArgs<CLREventData>>(GetEventHandler)); OnGet = Get;
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
}
