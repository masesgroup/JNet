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
using MASES.JCOBridge.C2JBridge.JVMInterop;
using System;

namespace Java.Util.Function
{
    /// <summary>
    /// Listener for Java BooleanSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BooleanSupplier.html"/>. Extends <see cref="IJVMBridgeBase"/>
    /// </summary>
    public interface IBooleanSupplier : IJVMBridgeBase
    {
        /// <summary>
        /// Executes the BooleanSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsBoolean result</returns>
        bool GetAsBoolean();
    }

    /// <summary>
    /// Listener for Java BooleanSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/BooleanSupplier.html"/>. Extends <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener.htm"/>
    /// </summary>
    public class BooleanSupplier : JVMBridgeListener, IBooleanSupplier
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.BooleanSupplier";

        /// <summary>
        /// The <see cref="Func{Boolean}"/> to be executed
        /// </summary>
        public virtual Func<bool> OnGetAsBoolean { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="BooleanSupplier"/>
        /// </summary>
        public BooleanSupplier()
        {
            if (InitHandlers)
            {
                AddEventHandler("getAsBoolean", new EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsBooleanEventHandler)); OnGetAsBoolean = GetAsBoolean;
            }
        }

        void GetAsBooleanEventHandler(object sender, CLRListenerEventArgs<CLREventData> data)
        {
            var retVal = OnGetAsBoolean();
            data.SetReturnValue(retVal);
        }
        /// <summary>
        /// Executes the BooleanSupplier action in the CLR
        /// </summary>
        /// <returns>The getAsBoolean result</returns>
        public virtual bool GetAsBoolean() { return false; }
    }

    /// <summary>
    /// Direct override of <see cref="BooleanSupplier"/> or its generic type if there is one
    /// </summary>
    public partial class BooleanSupplierDirect : BooleanSupplier
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.BooleanSupplier";
        private static readonly IJavaType _LocalBridgeClazz = ClazzOf(_bridgeClassName);
        private static IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw new InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => _bridgeClassName;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeAbstract.htm"/>
        /// </summary>
        public override bool IsBridgeAbstract => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeCloseable.htm"/>
        /// </summary>
        public override bool IsBridgeCloseable => false;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeStatic.htm"/>
        /// </summary>
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BooleanSupplier.html#getAsBoolean()"/> 
        /// </summary>
        public override bool GetAsBoolean() 
        {
            return IExecuteWithSignature<bool>("getAsBoolean", "()Z");
        }
    }
}
