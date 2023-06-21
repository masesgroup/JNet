﻿/*
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
    /// Listener for Java DoublePredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoublePredicate.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class DoublePredicate : JVMBridgeListener, IDoublePredicate
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetDoublePredicate";

        /// <summary>
        /// The <see cref="Func{TObject, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<double, bool> OnTest { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoublePredicate"/>
        /// </summary>
        public DoublePredicate()
        {
            AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(TestEventHandler)); OnTest = Test;
        }

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<double>> data)
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
