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
    /// Listener for Java DoublePredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoublePredicate.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IDoublePredicate : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the DoublePredicate action in the CLR
        /// </summary>
        /// <param name="obj">The DoublePredicate object</param>
        /// <returns>The test evaluation</returns>
        bool Test(double obj);
    }

    /// <summary>
    /// Listener for Java DoublePredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoublePredicate.html"/>. Extends <see cref="JVMBridgeListener"/>
    /// </summary>
    public class DoublePredicate : JVMBridgeListener, IDoublePredicate
    {
        /// <inheritdoc cref="JVMBridgeListener.ClassName"/>
        public sealed override string ClassName => "org.mases.jnet.util.function.JNetDoublePredicate";

        Func<double, bool> executionFunction = null;
        /// <summary>
        /// The <see cref="Func{TObject, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<double, bool> OnTest { get { return executionFunction; } }
        /// <summary>
        /// Initialize a new instance of <see cref="DoublePredicate"/>
        /// </summary>
        /// <param name="func">The <see cref="Func{TObject, Boolean}"/> to be executed</param>
        /// <param name="attachEventHandler">Set to <see langword="false" /> to disable invocation of <see cref="JVMBridgeListener.AddEventHandler(string, System.EventHandler)"/>: the call can be done in the derived class</param>
        public DoublePredicate(Func<double, bool> func = null, bool attachEventHandler = true)
        {
            if (func != null) executionFunction = func;
            else executionFunction = Test;

            if (attachEventHandler)
            {
                AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(EventHandler));
            }
        }

        void EventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
        {
            var retVal = OnTest(data.EventData.TypedEventData);
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the DoublePredicate action in the CLR
        /// </summary>
        /// <param name="obj">The DoublePredicate object</param>
        /// <returns>The test evaluation</returns>
        public virtual bool Test(double obj) { return false; }
    }
}
