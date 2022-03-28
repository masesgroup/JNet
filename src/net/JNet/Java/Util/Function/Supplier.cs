/*
*  Copyright 2022 MASES s.r.l.
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
    /// Listener for Java Supplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Supplier.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    /// <typeparam name="TReturn">The return data type associated to the event</typeparam>
    public class Supplier<TReturn> : JVMBridgeListener, ISupplier<TReturn>
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetSupplier";

        Func<TReturn> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{TReturn}"/> to be executed
        /// </summary>
        public virtual Func<TReturn> OnGet { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="Supplier{TReturn}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{TReturn}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public Supplier(Func<TReturn> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = Get;

            if (attachEventHandler)
            {
                AddEventHandler("get", new EventHandler<CLRListenerEventArgs<CLREventData>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
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
