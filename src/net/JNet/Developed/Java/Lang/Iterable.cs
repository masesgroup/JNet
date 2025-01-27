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

namespace Java.Lang
{
    #region IIterable
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Iterable.html"/>
    /// </summary>
    public partial interface IIterable
    {
        /// <summary>
        /// Returns an iterator over elements of type <see langref="object"/>
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        Java.Util.Iterator Iterator();
    }
    #endregion

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/>
    /// </summary>
    public class Iterable : JVMBridgeBaseEnumerable<Iterable>, IIterable
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.Iterable";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Iterable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Iterable(params object[] args) : base(args) { }
        /// <summary>
        /// Returns an iterator over elements of type <see langref="object"/>
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        public Util.Iterator Iterator() => IExecute<Util.Iterator>("iterator");
    }

    #region IIterable<E>
    /// <summary>
    /// .NET interface for <see href="https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/lang/Iterable.html"/>
    /// </summary>
    public partial interface IIterable<T>
    {
        /// <summary>
        /// Returns an iterator over elements of type <typeparamref name="T"/>.
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        Java.Util.Iterator<T> Iterator();
    }
    #endregion

    /// <summary>
    /// .NET implementations of <see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/>
    /// </summary>
    /// <typeparam name="T"><see href="https://docs.oracle.com/javase/8/docs/api/java/lang/Iterable.html"/></typeparam>
    public class Iterable<T> : MASES.JNet.Specific.JNetAsyncEnumerable<Iterable<T>, T>, IIterable<T>
    {
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_BridgeClassName.htm"/>
        /// </summary>
        public override string BridgeClassName => "java.lang.Iterable";
        /// <summary>
        /// <see href="https://www.jcobridge.com/api-clr/html/P_MASES_JCOBridge_C2JBridge_JVMBridgeBase_IsBridgeInterface.htm"/>
        /// </summary>
        public override bool IsBridgeInterface => true;
        /// <summary>
        /// Default constructor: even if the corresponding Java class does not have one, it is mandatory for JCOBridge
        /// </summary>
        public Iterable() { }
        /// <summary>
        /// Generic constructor: it is useful for JCOBridge when there is a derived class which needs to pass arguments to the highest JVMBridgeBase class
        /// </summary>
        public Iterable(params object[] args) : base(args) { }

        /// <summary>
        /// Returns an iterator over elements of type <typeparamref name="T"/>.
        /// </summary>
        /// <returns>An <see cref="Util.Iterator{T}"/></returns>
        public Util.Iterator<T> Iterator() => IExecute<Util.Iterator<T>>("iterator");
    }
}
