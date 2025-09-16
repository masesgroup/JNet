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
    /// Listener for Java DoublePredicate <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/DoublePredicate.html"/>. Extends <see cref="MASES.JCOBridge.C2JBridge.JVMBridgeListener"/>
    /// </summary>
    public class DoublePredicate : JVMBridgeListener, IDoublePredicate
    {
        /// <summary>
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.DoublePredicate";

        /// <summary>
        /// The <see cref="Func{TObject, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<double, bool> OnTest { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="DoublePredicate"/>
        /// </summary>
        public DoublePredicate()
        {
            if (InitHandlers)
            {
                AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<double>>>(TestEventHandler)); OnTest = Test;
            }
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

    /// <summary>
    /// Direct override of <see cref="DoublePredicate"/> or its generic type if there is one
    /// </summary>
    public partial class DoublePredicateDirect : DoublePredicate
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.DoublePredicate";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#test(double)"/>
        /// </summary>
        /// <param name="arg0"><see cref="double"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(double arg0)
        {
            return IExecuteWithSignature<bool>("test", "(D)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#and(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public Java.Util.Function.DoublePredicate And(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicateDirect, Java.Util.Function.DoublePredicate>("and", "(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public Java.Util.Function.DoublePredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicateDirect, Java.Util.Function.DoublePredicate>("negate", "()Ljava/util/function/DoublePredicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/DoublePredicate.html#or(java.util.function.DoublePredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.DoublePredicate"/></param>
        /// <returns><see cref="Java.Util.Function.DoublePredicate"/></returns>
        public Java.Util.Function.DoublePredicate Or(Java.Util.Function.DoublePredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.DoublePredicateDirect, Java.Util.Function.DoublePredicate>("or", "(Ljava/util/function/DoublePredicate;)Ljava/util/function/DoublePredicate;", arg0);
        }
    }
}
