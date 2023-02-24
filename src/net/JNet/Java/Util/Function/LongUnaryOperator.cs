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
    /// Listener for Java LongUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongUnaryOperator.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface ILongUnaryOperator : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the LongUnaryOperator action in the CLR
        /// </summary>
        /// <param name="o">The input of LongUnaryOperator</param>
        /// <returns>The applyAsLong result</returns>
        long ApplyAsLong(long o);
    }

    /// <summary>
    /// Listener for Java LongUnaryOperator <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongUnaryOperator.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class LongUnaryOperator : JVMBridgeListener, ILongUnaryOperator
    {
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_ClassName.htm"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetLongUnaryOperator";

        Func<long, long> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{Int64, Int64}"/> to be executed
        /// </summary>
        public virtual Func<long, long> OnApplyAsLong { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="LongUnaryOperator"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{Int64, Int64}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public LongUnaryOperator(Func<long, long> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = ApplyAsLong;

            if (attachEventHandler)
            {
                AddEventHandler("applyAsLong", new EventHandler<CLRListenerEventArgs<CLREventData<long>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var retVal = OnApplyAsLong(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the LongUnaryOperator action in the CLR
        /// </summary>
        /// <param name="o">The input of LongUnaryOperator</param>
        /// <returns>The applyAsLong result</returns>
        public virtual long ApplyAsLong(long o) { return default(long); }
    }
}
