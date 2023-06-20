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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BiPredicate.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public abstract class BiPredicate : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetBiPredicate";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BiPredicate.html"/>. Extends <see cref="BiPredicate"/>
    /// </summary>
    /// <typeparam name="T">The data associated to the event</typeparam>
    /// <typeparam name="U">The data associated to the event</typeparam> 
    public class BiPredicate<T, U> : BiPredicate, IBiPredicate<T, U>
    {
        /// <summary>
        /// The <see cref="Func{T, U, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<T, U, bool> OnTest { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="BiPredicate{T, U}"/>
        /// </summary>
        public BiPredicate()
        {
            AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(TestEventHandler)); OnTest = Test;
        }

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<T>> data)
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
