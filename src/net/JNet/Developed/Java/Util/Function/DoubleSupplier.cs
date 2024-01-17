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
    /// Listener for Java DoubleSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleSupplier.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IDoubleSupplier : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the DoubleSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsBoolean result</returns>
        double GetAsDouble();
    }

    /// <summary>
    /// Listener for Java DoubleSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleSupplier.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class DoubleSupplier : JVMBridgeListener, IDoubleSupplier
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetDoubleSupplier";

        /// <summary>
        /// The <see cref="Func{Double}"/> to be executed
        /// </summary>
        public virtual Func<double> OnGetAsDouble { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleSupplier"/>
        /// </summary>
        public DoubleSupplier()
        {
            AddEventHandler("getAsDouble", new EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsDoubleEventHandler)); OnGetAsDouble = GetAsDouble;
        }

        void GetAsDoubleEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var retVal = OnGetAsDouble();
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the DoubleSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsBoolean result</returns>
        public virtual double GetAsDouble() { return default(double); }
    }
}
