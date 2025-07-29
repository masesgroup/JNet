/*
*  Copyright 2025 MASES s.r.l.
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
        /// Enable/disable handlers initialization, default is <see langword="true"/>
        /// </summary>
        protected virtual bool InitHandlers { get; } = true;

        /// <inheritdoc />
        public override string BridgeClassName => "org.mases.jnet.developed.java.util.function.Predicate";
    }


    /// <summary>
    /// Direct override of <see cref="Predicate"/>
    /// </summary>
    public class PredicateDirect : Predicate
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        /// <inheritdoc />
        public override string BridgeClassName => "java.util.function.Predicate";
        /// <inheritdoc />
        public override bool IsBridgeAbstract => false;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><see cref="object"/></param>
        /// <returns><see cref="bool"/></returns>
        public bool Test(object arg0)
        {
            return IExecuteWithSignature<bool>("test", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate And(Java.Util.Function.Predicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.PredicateDirect, Java.Util.Function.Predicate>("and", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.PredicateDirect, Java.Util.Function.Predicate>("negate", "()Ljava/util/function/Predicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate Or(Java.Util.Function.Predicate arg0)
        {
            return IExecuteWithSignature<Java.Util.Function.PredicateDirect, Java.Util.Function.Predicate>("or", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", arg0);
        }
    }

    /// <summary>
    /// Listener for <see href="https://docs.oracle.com/javase/8/docs/api/java/util/function/Predicate.html"/>. Extends <see cref="Predicate"/>
    /// </summary>
    /// <typeparam name="TObject">The data type associated to the event</typeparam>
    public class Predicate<TObject> : Predicate, IPredicate<TObject>
    {
        /// <summary>
        /// The <see cref="Func{TObject, Boolean}"/> to be executed
        /// </summary>
        public virtual Func<TObject, bool> OnTest { get; set; }
        /// <summary>
        /// Initialize a new instance of <see cref="Predicate{TObject}"/>
        /// </summary>
        public Predicate()
        {
            if (InitHandlers)
            {
                AddEventHandler("test", new EventHandler<CLRListenerEventArgs<CLREventData<TObject>>>(TestEventHandler)); OnTest = Test;
            }
        }

        void TestEventHandler(object sender, CLRListenerEventArgs<CLREventData<TObject>> data)
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

    /// <summary>
    /// Direct override of <see cref="Predicate{T}"/>
    /// </summary>
    public class PredicateDirect<T> : Predicate<T>
    {
        /// <inheritdoc />
        public override bool AutoInit => false;

        /// <inheritdoc />
        protected override bool InitHandlers => false;

        /// <inheritdoc />
        public override string BridgeClassName => "java.util.function.Predicate";
        /// <inheritdoc />
        public override bool IsBridgeAbstract => false;
        /// <inheritdoc />
        public override bool IsBridgeCloseable => false;
        /// <inheritdoc />
        public override bool IsBridgeInterface => true;
        /// <inheritdoc />
        public override bool IsBridgeStatic => false;

        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#test(java.lang.Object)"/>
        /// </summary>
        /// <param name="arg0"><typeparamref name="T"/></param>
        /// <returns><see cref="bool"/></returns>
        public override bool Test(T arg0)
        {
            return IExecuteWithSignature<bool>("test", "(Ljava/lang/Object;)Z", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#and(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<T> And<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return IExecuteWithSignature<Java.Util.Function.PredicateDirect<T>, Java.Util.Function.Predicate<T>>("and", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", arg0);
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#negate()"/>
        /// </summary>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<T> Negate()
        {
            return IExecuteWithSignature<Java.Util.Function.PredicateDirect<T>, Java.Util.Function.Predicate<T>>("negate", "()Ljava/util/function/Predicate;");
        }
        /// <summary>
        /// <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/util/function/Predicate.html#or(java.util.function.Predicate)"/>
        /// </summary>
        /// <param name="arg0"><see cref="Java.Util.Function.Predicate"/></param>
        /// <typeparam name="Arg0objectSuperT"><typeparamref name="T"/></typeparam>
        /// <returns><see cref="Java.Util.Function.Predicate"/></returns>
        public Java.Util.Function.Predicate<T> Or<Arg0objectSuperT>(Java.Util.Function.Predicate<Arg0objectSuperT> arg0) where Arg0objectSuperT : T
        {
            return IExecuteWithSignature<Java.Util.Function.PredicateDirect<T>, Java.Util.Function.Predicate<T>>("or", "(Ljava/util/function/Predicate;)Ljava/util/function/Predicate;", arg0);
        }
    }
}
