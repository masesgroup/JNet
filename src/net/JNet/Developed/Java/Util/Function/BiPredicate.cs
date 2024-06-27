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
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.BiPredicate";
    }

    /// <summary>
    /// Direct override of <see cref="BiPredicate"/> or its generic type if there is one
    /// </summary>
    public partial class BiPredicateDirect : BiPredicate
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.BiPredicate";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <param name="arg1"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(object arg0, object arg1)
        {
            return IExecute<bool>("test", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate And(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("and", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("negate", "()Ljava/util/function/BiPredicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate Or(Java.Util.Function.BiPredicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect, Java.Util.Function.BiPredicate>("or", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
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
            if (InitHandlers)
            {
                AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<T>>>(TestEventHandler)); OnTest = Test;
            }
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

    /// <summary>
    /// Direct override of <see cref="BiPredicate"/> or its generic type if there is one
    /// </summary>
    public partial class BiPredicateDirect<T, U> : BiPredicate<T, U>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeListener_AutoInit.htm"/>
        /// </summary>
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        const string _bridgeClassName = "java.util.function.BiPredicate";
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
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#test(java.lang.Object,java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <param name="arg1"><typeparamref name="U"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(T arg0, U arg1)
        {
            return IExecute<bool>("test", arg0, arg1);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#and(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate<T, U> And<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("and", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate<T, U> Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("negate", "()Ljava/util/function/BiPredicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/BiPredicate.html#or(java.util.function.BiPredicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.BiPredicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <typeparam name="Arg0objectSuperU"><typeparamref name="U"/></typeparam>
        /// <returns><see cref="Java.Util.Function.BiPredicate"/></returns>
        public Java.Util.Function.BiPredicate<T, U> Or<Arg0objectSuperT, Arg0objectSuperU>(Java.Util.Function.BiPredicate<Arg0objectSuperT, Arg0objectSuperU> arg0) where Arg0objectSuperT : T where Arg0objectSuperU : U
        {
            return IExecuteWithSignature<Java.Util.Function.BiPredicateDirect<T, U>, Java.Util.Function.BiPredicate<T, U>>("or", "(Ljava/util/function/BiPredicate;)Ljava/util/function/BiPredicate;", arg0);
        }
    }
}
