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
    /// Listener for Java IntSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntSupplier.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IIntSupplier : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the IntSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsInt result</returns>
        int GetAsInt();
    }

    /// <summary>
    /// Listener for Java IntSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/IntSupplier.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class IntSupplier : JVMBridgeListener, IIntSupplier
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.util.function.JNetIntSupplier";

        /// <summary>
        /// The <see cref="Func{Int32}"/> to be executed
        /// </summary>
        public virtual Func<int> OnGetAsInt { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="IntSupplier"/>
        /// </summary>
        public IntSupplier()
        {
            AddEventHandler("getAsInt", new EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsIntEventHandler)); OnGetAsInt = GetAsInt;
        }

        void GetAsIntEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var retVal = OnGetAsInt();
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the IntSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsInt result</returns>
        public virtual int GetAsInt() { return default(int); }
    }
}
