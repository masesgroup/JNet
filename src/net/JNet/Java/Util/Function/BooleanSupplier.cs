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
    /// Listener for Java BooleanSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BooleanSupplier.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IBooleanSupplier : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the BooleanSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsBoolean result</returns>
        bool GetAsBoolean();
    }

    /// <summary>
    /// Listener for Java BooleanSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BooleanSupplier.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class BooleanSupplier : JVMBridgeListener, IBooleanSupplier
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetBooleanSupplier";

        Func<bool> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{Boolean}"/> to be executed
        /// </summary>
        public virtual Func<bool> OnGetAsBoolean { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="BooleanSupplier"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Boolean}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public BooleanSupplier(Func<bool> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = GetAsBoolean;

            if (attachEventHandler)
            {
                AddEventHandler("getAsBoolean", new EventHandler<CLRListenerEventArgs<CLREventData>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var retVal = OnGetAsBoolean();
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the BooleanSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsBoolean result</returns>
        public virtual bool GetAsBoolean() { return false; }
    }
}
