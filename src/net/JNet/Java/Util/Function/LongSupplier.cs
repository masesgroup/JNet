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
    /// Listener for Java LongSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongSupplier.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface ILongSupplier : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the LongSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsInt result</returns>
        long GetAsLong();
    }

    /// <summary>
    /// Listener for Java LongSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongSupplier.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class LongSupplier : JVMBridgeListener, ILongSupplier
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetLongSupplier";

        Func<long> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{Int64}"/> to be executed
        /// </summary>
        public virtual Func<long> OnGetAsLong { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="LongSupplier"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Int64}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public LongSupplier(Func<long> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = GetAsLong;

            if (attachEventHandler)
            {
                AddEventHandler("getAsLong", new EventHandler<CLRListenerEventArgs<CLREventData>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var retVal = OnGetAsLong();
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the LongSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsInt result</returns>
        public virtual long GetAsLong() { return default(long); }
    }
}
