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
    /// Listener for Java UnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/UnaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public interface IUnaryOperator<TObject> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the UnaryOperator action in the CLR
        /// </summary>
        /// <param name="obj">The UnaryOperator object</param>
        /// <returns>The apply <typeparamref name="TObject"/></returns>
        TObject Apply(TObject obj);
    }

    /// <summary>
    /// Listener for Java UnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/UnaryOperator.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public class UnaryOperator<TObject> : JVMBridgeListener, IUnaryOperator<TObject>
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetUnaryOperator";

        Func<TObject, TObject> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{TObject, TObject}"/> to be executed
        /// </summary>
        public virtual Func<TObject, TObject> OnApply { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="UnaryOperator{TObject}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{TObject, TReturn}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public UnaryOperator(Func<TObject, TObject> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = Apply;

            if (attachEventHandler)
            {
                AddEventHandler("apply", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            var retVal = OnApply(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the UnaryOperator action in the CLR
        /// </summary>
        /// <param name="obj">The UnaryOperator object</param>
        /// <returns>The apply <typeparamref name="TObject"/></returns>
        public virtual TObject Apply(TObject obj) { return default(TObject); }
    }
}
