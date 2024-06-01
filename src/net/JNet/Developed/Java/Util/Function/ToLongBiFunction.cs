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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ToLongBiFunction.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    /// <typeparam name="U">The data type associated to the event</typeparam>
    public interface IToLongBiFunction<T, U> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o1">The ToLongBiFunction object</param>
        /// <param name="o2">The ToLongBiFunction object</param>
        /// <returns>The applyAsLong result</returns>
        long ApplyAsLong(T o1, U o2);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ToLongBiFunction.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class ToLongBiFunction : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.JNetToLongBiFunction";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/ToLongBiFunction.html"/>. Extends <see cref="ToLongBiFunction"/>
    /// </summary>
    /// <typeparam name="T">The data type associated to the event</typeparam>
    /// <typeparam name="U">The data type associated to the event</typeparam>
    public class ToLongBiFunction<T, U> : ToLongBiFunction, IToLongBiFunction<T, U>
    {
        /// <summary>
        /// The <see cref="Func{T, U, Int64}"/> to be executed
        /// </summary>
        public virtual Func<T, U, long> OnApplyAsLong { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="ToLongBiFunction{T, U}"/>
        /// </summary>
        public ToLongBiFunction()
        {
            AddEventHandler("applyAsLong", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(ApplyAsLongEventHandler)); OnApplyAsLong = ApplyAsLong;
        }

        void ApplyAsLongEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var retVal = OnApplyAsLong(data.EventData.TypedEventData, data.EventData.To<U>(0));
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Function action in the CLR
        /// </summary>
        /// <param name="o1">The ToLongBiFunction object</param>
        /// <param name="o2">The ToLongBiFunction object</param>
        /// <returns>The applyAsLong result</returns>
        public virtual long ApplyAsLong(T o1, U o2) { return default(long); }
    }
}
