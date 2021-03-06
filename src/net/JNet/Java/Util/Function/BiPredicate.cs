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
    /// Listener for Java BiPredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BiPredicate.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    /// <typeparam name="U">The data associated to the event</typeparam> 
    public interface IBiPredicate<T, U> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Predicate action in the CLR
        /// </summary>
        /// <param name="o1">The Predicate object</param>
        /// <param name="o2">The Predicate object</param>
        /// <returns>The test evaluation</returns>
        bool Test(T o1, U o2);
    }

    /// <summary>
    /// Listener for Java BiPredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BiPredicate.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    /// <typeparam name="U">The data associated to the event</typeparam> 
    public class BiPredicate<T, U> : JVMBridgeListener, IBiPredicate<T, U>
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetBiPredicate";

        Func<T, U, bool> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{T, U, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<T, U, bool> OnTest { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="BiPredicate{T, U}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{T, U, Boolean}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public BiPredicate(Func<T, U, bool> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = Test;

            if (attachEventHandler)
            {
                AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
        {
            var retVal = OnTest(data.EventData.TypedEventData, data.EventData.To<U>(0));
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Predicate action in the CLR
        /// </summary>
        /// <param name="o1">The Predicate object</param>
        /// <param name="o2">The Predicate object</param>
        /// <returns>The test evaluation</returns>
        public virtual bool Test(T o1, U o2) { return false; }
    }
}
