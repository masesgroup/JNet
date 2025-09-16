/*
*  Copyright (c) 2022-2025 MASES s.r.l.
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
    /// Listener for Java DoubleSupplier <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoubleSupplier.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class DoubleSupplier : JVMBridgeListener, IDoubleSupplier
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.DoubleSupplier";

        /// <summary>
        /// The <see cref="Func{Double}"/> to be executed
        /// </summary>
        public virtual Func<double> OnGetAsDouble { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoubleSupplier"/>
        /// </summary>
        public DoubleSupplier()
        {
            if (InitHandlers)
            {
                AddEventHandler("getAsDouble", new EventHandler<CLRListenerEventArgs<CLREventData>>(GetAsDoubleEventHandler)); OnGetAsDouble = GetAsDouble;
            }
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

    /// <summary>
    /// Direct override of <see cref="DoubleSupplier"/> or its generic type if there is one
    /// </summary>
    public partial class DoubleSupplierDirect : DoubleSupplier
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.DoubleSupplier";
        private static readonly global::System.Exception _LocalBridgeClazzException = null;
        private static readonly MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType _LocalBridgeClazz = JVMBridgeBase.ClazzOf(_bridgeClassName, out _LocalBridgeClazzException, false);
        private static MASES.JCOBridge.C2JBridge.JVMInterop.IJavaType LocalBridgeClazz => _LocalBridgeClazz ?? throw _LocalBridgeClazzException ?? new global::System.InvalidOperationException($"Class {_bridgeClassName} was not found.");

        /// <inheritdoc />
        public override string BridgeClassName => _bridgeClassName;
        /// <inheritdoc />
        public override bool IsBridgeAbstract => true;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoubleSupplier.html#getAsDouble()"/> 
        /// </summary>
        public override double GetAsDouble()
        {
           return IExecuteWithSignature<double>("getAsDouble", "()D");
        }
    }
}
