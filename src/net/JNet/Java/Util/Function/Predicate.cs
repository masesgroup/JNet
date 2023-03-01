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
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public interface IPredicate<TObject> : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the Predicate action in the CLR
        /// </summary>
        /// <param name="obj">The Predicate object</param>
        /// <returns>The test evaluation</returns>
        bool Test(TObject obj);
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public abstract class Predicate : JVMBridgeListener
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr_2.5.3/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_ClassName.htm"/>
        /// </summary>
        public override string ClassName => "org.mases.jnet.util.function.JNetPredicate";
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html"/>. Extends <see cref="Predicate"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public class Predicate<TObject> : Predicate, IPredicate<TObject>
    {
        Func<TObject, bool> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{TObject, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<TObject, bool> OnTest { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="Predicate{TObject}"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{TObject, Boolean}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public Predicate(Func<TObject, bool> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = Test;

            if (attachEventHandler)
            {
                AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
        {
            var retVal = OnTest(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the Predicate action in the CLR
        /// </summary>
        /// <param name="obj">The Predicate object</param>
        /// <returns>The test evaluation</returns>
        public virtual bool Test(TObject obj) { return false; }
    }
}
