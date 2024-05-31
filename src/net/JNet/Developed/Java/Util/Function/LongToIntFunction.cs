/*
*  Copyright 2024 MASES s.r.l.
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
    /// Listener for Java LongToIntFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongToIntFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface ILongToIntFunction : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the LongToIntFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of LongToIntFunction</param>
        /// <returns>The applyAsInt result</returns>
        int ApplyAsInt(long o);
    }

    /// <summary>
    /// Listener for Java LongToIntFunction <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/LongToIntFunction.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class LongToIntFunction : JVMBridgeListener, ILongToIntFunction
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.JNetLongToIntFunction";

        /// <summary>
        /// The <see cref="Func{Int32, Int64}"/> to be executed
        /// </summary>
        public virtual Func<long, int> OnApplyAsInt { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="LongToIntFunction"/>
        /// </summary>
        public LongToIntFunction()
        {
            AddEventHandler("applyAsInt", new EventHandler<CLRListenerEventArgs<CLREventData<long>>>(ApplyAsIntEventHandler)); OnApplyAsInt = ApplyAsInt;
        }

        void ApplyAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData<long>> data)
        {
            var retVal = OnApplyAsInt(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the LongToIntFunction action in the CLR
        /// </summary>
        /// <param name="o">The input of LongToIntFunction</param>
        /// <returns>The applyAsInt result</returns>
        public virtual int ApplyAsInt(long o) { return default(int); }
    }
}
